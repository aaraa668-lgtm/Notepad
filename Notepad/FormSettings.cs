namespace Notepad
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        /// <summary>Сохраняет размер шрифта и подпись в файл настроек рядом с программой.</summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string settingsPath = Path.Combine(AppContext.BaseDirectory, "settings.txt");
            try
            {
                File.WriteAllLines(settingsPath,
                    new[] { numericUpDownFontSize.Value.ToString(), textBoxSign.Text },
                    new System.Text.UTF8Encoding(false));
                MessageBox.Show("Настройки сохранены.", "Настройки",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить настройки.\n" + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
