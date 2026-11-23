namespace Notepad
{
    public partial class блокнотик : Form
    {
        // Полный путь к открытому документу. Пустая строка означает новый документ.
        private string currentFileName = string.Empty;
        // true, если пользователь изменил текст после последнего сохранения.
        private bool hasUnsavedChanges;
        // Подпись из настроек, добавляемая в конец файла при сохранении.
        private string signature = string.Empty;
        // Не считаем программную загрузку текста пользовательским изменением.
        private bool isLoadingDocument;

        public блокнотик()
        {
            InitializeComponent();
        }

        /// <summary>Загружает настройки редактора при запуске программы.</summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadEditorSettings();
            fontDialog.Font = textBoxField.Font;
            colorDialog.Color = textBoxField.ForeColor;
            UpdateWindowTitle();
        }

        /// <summary>Читает размер шрифта и подпись; использует настройки по умолчанию, если файла нет.</summary>
        private void LoadEditorSettings()
        {
            string settingsPath = Path.Combine(AppContext.BaseDirectory, "settings.txt");
            if (!File.Exists(settingsPath))
            {
                signature = string.Empty;
                return;
            }

            string[] settings = File.ReadAllLines(settingsPath);
            if (settings.Length > 0 && int.TryParse(settings[0], out int fontSize))
            {
                fontSize = Math.Clamp(fontSize, 8, 28);
                textBoxField.Font = new Font(textBoxField.Font.FontFamily, fontSize);
            }
            signature = settings.Length > 1
                ? string.Join(Environment.NewLine, settings.Skip(1))
                : string.Empty;
        }

        /// <summary>Отмечает документ изменённым после редактирования текста.</summary>
        private void textBoxField_TextChanged(object sender, EventArgs e)
        {
            if (!isLoadingDocument)
            {
                hasUnsavedChanges = true;
                UpdateWindowTitle();
            }
        }

        /// <summary>Показывает звёздочку в заголовке, если есть несохранённые изменения.</summary>
        private void UpdateWindowTitle()
        {
            string documentName = string.IsNullOrEmpty(currentFileName)
                ? "Безымянный"
                : Path.GetFileName(currentFileName);
            Text = (hasUnsavedChanges ? "* " : string.Empty) + documentName + " — Блокнот";
        }

        /// <summary>Спрашивает, что сделать с изменениями: сохранить, отбросить или отменить действие.</summary>
        private bool AskToSaveChanges()
        {
            if (!hasUnsavedChanges)
                return true;

            DialogResult answer = MessageBox.Show(
                "В документе есть несохранённые изменения.\nСохранить их?",
                "Изменения не сохранены",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.Cancel)
                return false;
            if (answer == DialogResult.No)
                return true;
            // Если пользователь нажал «Да», продолжаем только после успешного сохранения.
            return SaveDocument();
        }

        /// <summary>Создаёт пустой документ после обработки несохранённых изменений.</summary>
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AskToSaveChanges())
                return;
            SetDocumentText(string.Empty);
            currentFileName = string.Empty;
            hasUnsavedChanges = false;
            UpdateWindowTitle();
        }

        /// <summary>Открывает выбранный файл, не теряя текущий документ при отмене или ошибке.</summary>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!AskToSaveChanges())
                return;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string loadedText = File.ReadAllText(openFileDialog.FileName);
                SetDocumentText(loadedText);
                currentFileName = openFileDialog.FileName;
                hasUnsavedChanges = false;
                UpdateWindowTitle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть файл.\n" + ex.Message,
                    "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Сохраняет документ в текущий файл или вызывает «Сохранить как».</summary>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        /// <summary>Открывает диалог выбора имени и места сохранения.</summary>
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDocumentAs();
        }

        /// <summary>Сохраняет текст документа в текущий файл; возвращает true при успехе.</summary>
        private bool SaveDocument()
        {
            if (string.IsNullOrEmpty(currentFileName))
                return SaveDocumentAs();
            return WriteDocumentToFile(currentFileName);
        }

        /// <summary>Предлагает имя файла и сохраняет документ по выбранному пути.</summary>
        private bool SaveDocumentAs()
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return false;
            if (!WriteDocumentToFile(saveFileDialog.FileName))
                return false;
            currentFileName = saveFileDialog.FileName;
            UpdateWindowTitle();
            return true;
        }

        /// <summary>Записывает текст и подпись в UTF-8; сбрасывает признак изменений только при успехе.</summary>
        private bool WriteDocumentToFile(string fileName)
        {
            try
            {
                string content = textBoxField.Text;
                if (!string.IsNullOrWhiteSpace(signature) &&
                    !content.EndsWith(signature, StringComparison.Ordinal))
                    content += Environment.NewLine + signature;
                File.WriteAllText(fileName, content, new System.Text.UTF8Encoding(false));
                hasUnsavedChanges = false;
                UpdateWindowTitle();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл.\n" + ex.Message,
                    "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>Заменяет текст программно, не помечая документ как изменённый.</summary>
        private void SetDocumentText(string text)
        {
            isLoadingDocument = true;
            textBoxField.Text = text;
            isLoadingDocument = false;
        }

        /// <summary>Закрывает приложение по команде меню после проверки изменений.</summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>Не даёт закрыть окно, если пользователь отменил сохранение.</summary>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AskToSaveChanges())
                e.Cancel = true;
        }

        /// <summary>Меняет шрифт текста через стандартный диалог Windows.</summary>
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                textBoxField.Font = fontDialog.Font;
        }

        /// <summary>Меняет цвет текста через стандартный диалог Windows.</summary>
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                textBoxField.ForeColor = colorDialog.Color;
        }

        /// <summary>Выделяет весь текст документа.</summary>
        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxField.SelectAll();
        }

        /// <summary>Копирует выделенный текст в буфер обмена.</summary>
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxField.Copy();
        }

        /// <summary>Вырезает выделенный текст в буфер обмена.</summary>
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxField.Cut();
        }

        /// <summary>Вставляет текст из буфера обмена.</summary>
        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxField.Paste();
        }

        /// <summary>Открывает окно настроек редактора.</summary>
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using FormSettings settingsForm = new FormSettings();
            settingsForm.ShowDialog(this);
            LoadEditorSettings();
        }
    }
}
