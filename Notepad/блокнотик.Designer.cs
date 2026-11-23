namespace Notepad
{
    partial class блокнотик
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStripMainMenu = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            выделитьВсеToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            цветToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button1 = new Button();
            buttonBold = new Button();
            textBoxField = new TextBox();
            contextMenuStripTextBoxField = new ContextMenuStrip(components);
            копироватьToolStripMenuItem1 = new ToolStripMenuItem();
            выToolStripMenuItem = new ToolStripMenuItem();
            резатьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            выделитьВсеToolStripMenuItem1 = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            menuStripMainMenu.SuspendLayout();
            panel1.SuspendLayout();
            contextMenuStripTextBoxField.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.ImageScalingSize = new Size(20, 20);
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, форматToolStripMenuItem, настройкиToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Padding = new Padding(7, 3, 0, 3);
            menuStripMainMenu.Size = new Size(914, 30);
            menuStripMainMenu.TabIndex = 0;
            menuStripMainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, toolStripMenuItem1, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(192, 26);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(192, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(192, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(192, 26);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(189, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(192, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копироватьToolStripMenuItem, вырезатьToolStripMenuItem, вставитьToolStripMenuItem, toolStripMenuItem2, выделитьВсеToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(74, 24);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(186, 26);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(186, 26);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(186, 26);
            вставитьToolStripMenuItem.Text = "Вставить";
            вставитьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(183, 6);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            выделитьВсеToolStripMenuItem.Size = new Size(186, 26);
            выделитьВсеToolStripMenuItem.Text = "Выделить все";
            выделитьВсеToolStripMenuItem.Click += выделитьВсеToolStripMenuItem_Click;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { шрифтToolStripMenuItem, цветToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(77, 24);
            форматToolStripMenuItem.Text = "Формат";
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(140, 26);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += шрифтToolStripMenuItem_Click;
            // 
            // цветToolStripMenuItem
            // 
            цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            цветToolStripMenuItem.Size = new Size(140, 26);
            цветToolStripMenuItem.Text = "Цвет";
            цветToolStripMenuItem.Click += цветToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(98, 24);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonBold);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 49);
            panel1.TabIndex = 1;
            panel1.Paint += this.panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(49, 11);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(32, 31);
            button1.TabIndex = 1;
            button1.Text = "B";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonBold
            // 
            buttonBold.Location = new Point(10, 9);
            buttonBold.Margin = new Padding(3, 4, 3, 4);
            buttonBold.Name = "buttonBold";
            buttonBold.Size = new Size(32, 31);
            buttonBold.TabIndex = 0;
            buttonBold.Text = "B";
            buttonBold.UseVisualStyleBackColor = true;
            // 
            // textBoxField
            // 
            textBoxField.ContextMenuStrip = contextMenuStripTextBoxField;
            textBoxField.Dock = DockStyle.Fill;
            textBoxField.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxField.ForeColor = Color.IndianRed;
            textBoxField.Location = new Point(0, 79);
            textBoxField.Margin = new Padding(3, 4, 3, 4);
            textBoxField.Multiline = true;
            textBoxField.Name = "textBoxField";
            textBoxField.Size = new Size(914, 521);
            textBoxField.TabIndex = 2;
            textBoxField.TextChanged += textBoxField_TextChanged;
            // 
            // contextMenuStripTextBoxField
            // 
            contextMenuStripTextBoxField.ImageScalingSize = new Size(20, 20);
            contextMenuStripTextBoxField.Items.AddRange(new ToolStripItem[] { копироватьToolStripMenuItem1, выToolStripMenuItem, резатьToolStripMenuItem, toolStripMenuItem3, выделитьВсеToolStripMenuItem1 });
            contextMenuStripTextBoxField.Name = "contextMenuStripTextBoxField";
            contextMenuStripTextBoxField.Size = new Size(173, 106);
            // 
            // копироватьToolStripMenuItem1
            // 
            копироватьToolStripMenuItem1.Name = "копироватьToolStripMenuItem1";
            копироватьToolStripMenuItem1.Size = new Size(172, 24);
            копироватьToolStripMenuItem1.Text = "Копировать";
            копироватьToolStripMenuItem1.Click += копироватьToolStripMenuItem_Click;
            // 
            // выToolStripMenuItem
            // 
            выToolStripMenuItem.Name = "выToolStripMenuItem";
            выToolStripMenuItem.Size = new Size(172, 24);
            выToolStripMenuItem.Text = "Вырезать";
            выToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // резатьToolStripMenuItem
            // 
            резатьToolStripMenuItem.Name = "резатьToolStripMenuItem";
            резатьToolStripMenuItem.Size = new Size(172, 24);
            резатьToolStripMenuItem.Text = "Вставить";
            резатьToolStripMenuItem.Click += вставитьToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(169, 6);
            // 
            // выделитьВсеToolStripMenuItem1
            // 
            выделитьВсеToolStripMenuItem1.Name = "выделитьВсеToolStripMenuItem1";
            выделитьВсеToolStripMenuItem1.Size = new Size(172, 24);
            выделитьВсеToolStripMenuItem1.Text = "Выделить все";
            выделитьВсеToolStripMenuItem1.Click += выделитьВсеToolStripMenuItem_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "Текстовые документы|*.txt|Все файлы|*.*";
            openFileDialog.InitialDirectory = "C:\\";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "Безымянный";
            saveFileDialog.Filter = "Текстовые документы|*.txt|Все файлы|*.*";
            saveFileDialog.InitialDirectory = "C:\\";
            // 
            // блокнотик
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(textBoxField);
            Controls.Add(panel1);
            Controls.Add(menuStripMainMenu);
            MainMenuStrip = menuStripMainMenu;
            Margin = new Padding(3, 4, 3, 4);
            Name = "блокнотик";
            Text = "Блокнот";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            panel1.ResumeLayout(false);
            contextMenuStripTextBoxField.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Panel panel1;
        private Button buttonBold;
        private TextBox textBoxField;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button button1;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem цветToolStripMenuItem;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private ContextMenuStrip contextMenuStripTextBoxField;
        private ToolStripMenuItem копироватьToolStripMenuItem1;
        private ToolStripMenuItem выToolStripMenuItem;
        private ToolStripMenuItem резатьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
    }
}
