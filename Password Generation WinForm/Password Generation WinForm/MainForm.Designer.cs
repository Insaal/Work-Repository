namespace Password_Generation_WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcGenerationPassword = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.NudNumber = new System.Windows.Forms.NumericUpDown();
            this.NudLenght = new System.Windows.Forms.NumericUpDown();
            this.RtbOutputPassword = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGeneratePassword = new System.Windows.Forms.Button();
            this.CbLowerCaseRussian = new System.Windows.Forms.CheckBox();
            this.CbLowerCaseEnglish = new System.Windows.Forms.CheckBox();
            this.CbSymbols = new System.Windows.Forms.CheckBox();
            this.CbUpperCaseRussian = new System.Windows.Forms.CheckBox();
            this.CbUpperCaseEnglish = new System.Windows.Forms.CheckBox();
            this.CbNumbers = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNumber = new System.Windows.Forms.TrackBar();
            this.TbLenght = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GbVizhener = new System.Windows.Forms.GroupBox();
            this.TbStepOfVizhener = new System.Windows.Forms.TextBox();
            this.GbCesar = new System.Windows.Forms.GroupBox();
            this.TbStepOfCesar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbAtbash = new System.Windows.Forms.RadioButton();
            this.RbVigener = new System.Windows.Forms.RadioButton();
            this.RbCesar = new System.Windows.Forms.RadioButton();
            this.TbInputEncrypted = new System.Windows.Forms.TextBox();
            this.RtbOutputEncrypted = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NudStepOfCesar = new System.Windows.Forms.NumericUpDown();
            this.tcGenerationPassword.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbLenght)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.GbVizhener.SuspendLayout();
            this.GbCesar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbStepOfCesar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudStepOfCesar)).BeginInit();
            this.SuspendLayout();
            // 
            // tcGenerationPassword
            // 
            this.tcGenerationPassword.Controls.Add(this.tabPage1);
            this.tcGenerationPassword.Controls.Add(this.tabPage2);
            this.tcGenerationPassword.Location = new System.Drawing.Point(12, 12);
            this.tcGenerationPassword.Name = "tcGenerationPassword";
            this.tcGenerationPassword.SelectedIndex = 0;
            this.tcGenerationPassword.Size = new System.Drawing.Size(776, 539);
            this.tcGenerationPassword.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NudNumber);
            this.tabPage1.Controls.Add(this.NudLenght);
            this.tabPage1.Controls.Add(this.RtbOutputPassword);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BtnGeneratePassword);
            this.tabPage1.Controls.Add(this.CbLowerCaseRussian);
            this.tabPage1.Controls.Add(this.CbLowerCaseEnglish);
            this.tabPage1.Controls.Add(this.CbSymbols);
            this.tabPage1.Controls.Add(this.CbUpperCaseRussian);
            this.tabPage1.Controls.Add(this.CbUpperCaseEnglish);
            this.tabPage1.Controls.Add(this.CbNumbers);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TbNumber);
            this.tabPage1.Controls.Add(this.TbLenght);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Генерация паролей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // NudNumber
            // 
            this.NudNumber.Location = new System.Drawing.Point(288, 126);
            this.NudNumber.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudNumber.Name = "NudNumber";
            this.NudNumber.Size = new System.Drawing.Size(57, 26);
            this.NudNumber.TabIndex = 14;
            this.NudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudNumber.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // NudLenght
            // 
            this.NudLenght.Location = new System.Drawing.Point(286, 32);
            this.NudLenght.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NudLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudLenght.Name = "NudLenght";
            this.NudLenght.Size = new System.Drawing.Size(57, 26);
            this.NudLenght.TabIndex = 13;
            this.NudLenght.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudLenght.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // RtbOutputPassword
            // 
            this.RtbOutputPassword.Location = new System.Drawing.Point(351, 31);
            this.RtbOutputPassword.Name = "RtbOutputPassword";
            this.RtbOutputPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbOutputPassword.Size = new System.Drawing.Size(411, 469);
            this.RtbOutputPassword.TabIndex = 12;
            this.RtbOutputPassword.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ваши пароли:";
            // 
            // BtnGeneratePassword
            // 
            this.BtnGeneratePassword.Location = new System.Drawing.Point(59, 302);
            this.BtnGeneratePassword.Name = "BtnGeneratePassword";
            this.BtnGeneratePassword.Size = new System.Drawing.Size(150, 50);
            this.BtnGeneratePassword.TabIndex = 10;
            this.BtnGeneratePassword.Text = "Генерировать пароли";
            this.BtnGeneratePassword.UseVisualStyleBackColor = true;
            this.BtnGeneratePassword.Click += new System.EventHandler(this.BtnClick);
            // 
            // CbLowerCaseRussian
            // 
            this.CbLowerCaseRussian.AutoSize = true;
            this.CbLowerCaseRussian.Location = new System.Drawing.Point(182, 262);
            this.CbLowerCaseRussian.Name = "CbLowerCaseRussian";
            this.CbLowerCaseRussian.Size = new System.Drawing.Size(58, 24);
            this.CbLowerCaseRussian.TabIndex = 9;
            this.CbLowerCaseRussian.Text = "а-я";
            this.CbLowerCaseRussian.UseVisualStyleBackColor = true;
            this.CbLowerCaseRussian.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // CbLowerCaseEnglish
            // 
            this.CbLowerCaseEnglish.AutoSize = true;
            this.CbLowerCaseEnglish.Location = new System.Drawing.Point(182, 232);
            this.CbLowerCaseEnglish.Name = "CbLowerCaseEnglish";
            this.CbLowerCaseEnglish.Size = new System.Drawing.Size(57, 24);
            this.CbLowerCaseEnglish.TabIndex = 8;
            this.CbLowerCaseEnglish.Text = "a-z";
            this.CbLowerCaseEnglish.UseVisualStyleBackColor = true;
            this.CbLowerCaseEnglish.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // CbSymbols
            // 
            this.CbSymbols.AutoSize = true;
            this.CbSymbols.Location = new System.Drawing.Point(182, 202);
            this.CbSymbols.Name = "CbSymbols";
            this.CbSymbols.Size = new System.Drawing.Size(98, 24);
            this.CbSymbols.TabIndex = 7;
            this.CbSymbols.Text = "@#$%*?";
            this.CbSymbols.UseVisualStyleBackColor = true;
            this.CbSymbols.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // CbUpperCaseRussian
            // 
            this.CbUpperCaseRussian.AutoSize = true;
            this.CbUpperCaseRussian.Location = new System.Drawing.Point(41, 262);
            this.CbUpperCaseRussian.Name = "CbUpperCaseRussian";
            this.CbUpperCaseRussian.Size = new System.Drawing.Size(63, 24);
            this.CbUpperCaseRussian.TabIndex = 6;
            this.CbUpperCaseRussian.Text = "А-Я";
            this.CbUpperCaseRussian.UseVisualStyleBackColor = true;
            this.CbUpperCaseRussian.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // CbUpperCaseEnglish
            // 
            this.CbUpperCaseEnglish.AutoSize = true;
            this.CbUpperCaseEnglish.Location = new System.Drawing.Point(41, 232);
            this.CbUpperCaseEnglish.Name = "CbUpperCaseEnglish";
            this.CbUpperCaseEnglish.Size = new System.Drawing.Size(61, 24);
            this.CbUpperCaseEnglish.TabIndex = 5;
            this.CbUpperCaseEnglish.Text = "A-Z";
            this.CbUpperCaseEnglish.UseVisualStyleBackColor = true;
            this.CbUpperCaseEnglish.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // CbNumbers
            // 
            this.CbNumbers.AutoSize = true;
            this.CbNumbers.Location = new System.Drawing.Point(41, 202);
            this.CbNumbers.Name = "CbNumbers";
            this.CbNumbers.Size = new System.Drawing.Size(58, 24);
            this.CbNumbers.TabIndex = 4;
            this.CbNumbers.Text = "0-9";
            this.CbNumbers.UseVisualStyleBackColor = true;
            this.CbNumbers.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество паролей:";
            // 
            // TbNumber
            // 
            this.TbNumber.LargeChange = 1;
            this.TbNumber.Location = new System.Drawing.Point(7, 126);
            this.TbNumber.Maximum = 50;
            this.TbNumber.Minimum = 1;
            this.TbNumber.Name = "TbNumber";
            this.TbNumber.Size = new System.Drawing.Size(273, 69);
            this.TbNumber.TabIndex = 2;
            this.TbNumber.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TbNumber.Value = 1;
            this.TbNumber.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // TbLenght
            // 
            this.TbLenght.LargeChange = 1;
            this.TbLenght.Location = new System.Drawing.Point(7, 31);
            this.TbLenght.Maximum = 25;
            this.TbLenght.Minimum = 1;
            this.TbLenght.Name = "TbLenght";
            this.TbLenght.Size = new System.Drawing.Size(273, 69);
            this.TbLenght.TabIndex = 1;
            this.TbLenght.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TbLenght.Value = 1;
            this.TbLenght.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина пароля:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GbVizhener);
            this.tabPage2.Controls.Add(this.GbCesar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.TbInputEncrypted);
            this.tabPage2.Controls.Add(this.RtbOutputEncrypted);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtnEncrypt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Шифрование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GbVizhener
            // 
            this.GbVizhener.Controls.Add(this.TbStepOfVizhener);
            this.GbVizhener.Enabled = false;
            this.GbVizhener.Location = new System.Drawing.Point(11, 317);
            this.GbVizhener.Name = "GbVizhener";
            this.GbVizhener.Size = new System.Drawing.Size(338, 102);
            this.GbVizhener.TabIndex = 32;
            this.GbVizhener.TabStop = false;
            this.GbVizhener.Text = "Введите кодовое слово:";
            // 
            // TbStepOfVizhener
            // 
            this.TbStepOfVizhener.Location = new System.Drawing.Point(7, 26);
            this.TbStepOfVizhener.Multiline = true;
            this.TbStepOfVizhener.Name = "TbStepOfVizhener";
            this.TbStepOfVizhener.Size = new System.Drawing.Size(276, 50);
            this.TbStepOfVizhener.TabIndex = 0;
            // 
            // GbCesar
            // 
            this.GbCesar.Controls.Add(this.NudStepOfCesar);
            this.GbCesar.Controls.Add(this.TbStepOfCesar);
            this.GbCesar.Enabled = false;
            this.GbCesar.Location = new System.Drawing.Point(11, 204);
            this.GbCesar.Name = "GbCesar";
            this.GbCesar.Size = new System.Drawing.Size(338, 107);
            this.GbCesar.TabIndex = 31;
            this.GbCesar.TabStop = false;
            this.GbCesar.Text = "Выберите шаг:";
            // 
            // TbStepOfCesar
            // 
            this.TbStepOfCesar.Location = new System.Drawing.Point(7, 26);
            this.TbStepOfCesar.Maximum = 50;
            this.TbStepOfCesar.Minimum = 1;
            this.TbStepOfCesar.Name = "TbStepOfCesar";
            this.TbStepOfCesar.Size = new System.Drawing.Size(253, 69);
            this.TbStepOfCesar.TabIndex = 0;
            this.TbStepOfCesar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TbStepOfCesar.Value = 1;
            this.TbStepOfCesar.ValueChanged += new System.EventHandler(this.TrackBar_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbAtbash);
            this.groupBox1.Controls.Add(this.RbVigener);
            this.groupBox1.Controls.Add(this.RbCesar);
            this.groupBox1.Location = new System.Drawing.Point(11, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 108);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите метод шифрования:";
            // 
            // RbAtbash
            // 
            this.RbAtbash.AutoSize = true;
            this.RbAtbash.Location = new System.Drawing.Point(6, 25);
            this.RbAtbash.Name = "RbAtbash";
            this.RbAtbash.Size = new System.Drawing.Size(85, 24);
            this.RbAtbash.TabIndex = 27;
            this.RbAtbash.TabStop = true;
            this.RbAtbash.Text = "Атбаш";
            this.RbAtbash.UseVisualStyleBackColor = true;
            this.RbAtbash.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RbVigener
            // 
            this.RbVigener.AutoSize = true;
            this.RbVigener.Location = new System.Drawing.Point(67, 65);
            this.RbVigener.Name = "RbVigener";
            this.RbVigener.Size = new System.Drawing.Size(110, 24);
            this.RbVigener.TabIndex = 29;
            this.RbVigener.TabStop = true;
            this.RbVigener.Text = "Виженера";
            this.RbVigener.UseVisualStyleBackColor = true;
            this.RbVigener.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RbCesar
            // 
            this.RbCesar.AutoSize = true;
            this.RbCesar.Location = new System.Drawing.Point(170, 25);
            this.RbCesar.Name = "RbCesar";
            this.RbCesar.Size = new System.Drawing.Size(90, 24);
            this.RbCesar.TabIndex = 28;
            this.RbCesar.TabStop = true;
            this.RbCesar.Text = "Цезаря";
            this.RbCesar.UseVisualStyleBackColor = true;
            this.RbCesar.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // TbInputEncrypted
            // 
            this.TbInputEncrypted.Location = new System.Drawing.Point(11, 40);
            this.TbInputEncrypted.Multiline = true;
            this.TbInputEncrypted.Name = "TbInputEncrypted";
            this.TbInputEncrypted.Size = new System.Drawing.Size(338, 43);
            this.TbInputEncrypted.TabIndex = 26;
            // 
            // RtbOutputEncrypted
            // 
            this.RtbOutputEncrypted.Location = new System.Drawing.Point(355, 40);
            this.RtbOutputEncrypted.Name = "RtbOutputEncrypted";
            this.RtbOutputEncrypted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbOutputEncrypted.Size = new System.Drawing.Size(407, 460);
            this.RtbOutputEncrypted.TabIndex = 25;
            this.RtbOutputEncrypted.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ваши пароли:";
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Location = new System.Drawing.Point(78, 425);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(150, 64);
            this.BtnEncrypt.TabIndex = 23;
            this.BtnEncrypt.Text = "Зашифровать строку";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Введите шифруемую строку:";
            // 
            // NudStepOfCesar
            // 
            this.NudStepOfCesar.Location = new System.Drawing.Point(266, 26);
            this.NudStepOfCesar.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudStepOfCesar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudStepOfCesar.Name = "NudStepOfCesar";
            this.NudStepOfCesar.Size = new System.Drawing.Size(57, 26);
            this.NudStepOfCesar.TabIndex = 33;
            this.NudStepOfCesar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudStepOfCesar.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.tcGenerationPassword);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.tcGenerationPassword.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbLenght)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GbVizhener.ResumeLayout(false);
            this.GbVizhener.PerformLayout();
            this.GbCesar.ResumeLayout(false);
            this.GbCesar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbStepOfCesar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudStepOfCesar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcGenerationPassword;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar TbLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGeneratePassword;
        private System.Windows.Forms.CheckBox CbLowerCaseRussian;
        private System.Windows.Forms.CheckBox CbLowerCaseEnglish;
        private System.Windows.Forms.CheckBox CbSymbols;
        private System.Windows.Forms.CheckBox CbUpperCaseRussian;
        private System.Windows.Forms.CheckBox CbUpperCaseEnglish;
        private System.Windows.Forms.CheckBox CbNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TbNumber;
        private System.Windows.Forms.RichTextBox RtbOutputPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RtbOutputEncrypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbInputEncrypted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbAtbash;
        private System.Windows.Forms.RadioButton RbVigener;
        private System.Windows.Forms.RadioButton RbCesar;
        private System.Windows.Forms.GroupBox GbCesar;
        private System.Windows.Forms.GroupBox GbVizhener;
        private System.Windows.Forms.TextBox TbStepOfVizhener;
        private System.Windows.Forms.TrackBar TbStepOfCesar;
        private System.Windows.Forms.NumericUpDown NudNumber;
        private System.Windows.Forms.NumericUpDown NudLenght;
        private System.Windows.Forms.NumericUpDown NudStepOfCesar;
    }
}

