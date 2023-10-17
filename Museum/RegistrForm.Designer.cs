namespace Museum
{
    partial class RegistrForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationSwitch = new System.Windows.Forms.ComboBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.yearField = new System.Windows.Forms.TextBox();
            this.Accaunt = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.authorField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.locationSwitch);
            this.panel1.Controls.Add(this.LocationLabel);
            this.panel1.Controls.Add(this.YearLabel);
            this.panel1.Controls.Add(this.yearField);
            this.panel1.Controls.Add(this.Accaunt);
            this.panel1.Controls.Add(this.AuthorLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.authorField);
            this.panel1.Controls.Add(this.nameField);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 414);
            this.panel1.TabIndex = 1;
            // 
            // locationSwitch
            // 
            this.locationSwitch.BackColor = System.Drawing.Color.Teal;
            this.locationSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationSwitch.ForeColor = System.Drawing.SystemColors.Control;
            this.locationSwitch.FormattingEnabled = true;
            this.locationSwitch.Items.AddRange(new object[] {
            "Зал",
            "Склад",
            "Выставка"});
            this.locationSwitch.Location = new System.Drawing.Point(259, 244);
            this.locationSwitch.Name = "locationSwitch";
            this.locationSwitch.Size = new System.Drawing.Size(299, 33);
            this.locationSwitch.TabIndex = 15;
            this.locationSwitch.Text = "Выбирите расположение";
            this.locationSwitch.Enter += new System.EventHandler(this.locationSwitch_Enter);
            this.locationSwitch.Leave += new System.EventHandler(this.locationSwitch_Leave);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.LocationLabel.Location = new System.Drawing.Point(52, 247);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(178, 25);
            this.LocationLabel.TabIndex = 14;
            this.LocationLabel.Text = "Местоположение";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.YearLabel.Location = new System.Drawing.Point(183, 196);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(47, 25);
            this.YearLabel.TabIndex = 13;
            this.YearLabel.Text = "Год";
            // 
            // yearField
            // 
            this.yearField.BackColor = System.Drawing.Color.Teal;
            this.yearField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearField.ForeColor = System.Drawing.SystemColors.Control;
            this.yearField.Location = new System.Drawing.Point(259, 196);
            this.yearField.Multiline = true;
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(299, 33);
            this.yearField.TabIndex = 11;
            this.yearField.Enter += new System.EventHandler(this.yearField_Enter);
            this.yearField.Leave += new System.EventHandler(this.yearField_Leave);
            // 
            // Accaunt
            // 
            this.Accaunt.AutoSize = true;
            this.Accaunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Accaunt.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Accaunt.Location = new System.Drawing.Point(299, 361);
            this.Accaunt.Name = "Accaunt";
            this.Accaunt.Size = new System.Drawing.Size(83, 17);
            this.Accaunt.TabIndex = 10;
            this.Accaunt.Text = "На главную";
            this.Accaunt.Click += new System.EventHandler(this.Accaunt_Click);
            this.Accaunt.MouseEnter += new System.EventHandler(this.Accaunt_MouseEnter);
            this.Accaunt.MouseLeave += new System.EventHandler(this.Accaunt_MouseLeave);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.AuthorLabel.Location = new System.Drawing.Point(161, 150);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(69, 25);
            this.AuthorLabel.TabIndex = 9;
            this.AuthorLabel.Text = "Автор";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.NameLabel.Location = new System.Drawing.Point(81, 109);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(149, 25);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Наименование";
            // 
            // authorField
            // 
            this.authorField.BackColor = System.Drawing.Color.Teal;
            this.authorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorField.ForeColor = System.Drawing.SystemColors.Control;
            this.authorField.Location = new System.Drawing.Point(259, 150);
            this.authorField.Multiline = true;
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(299, 33);
            this.authorField.TabIndex = 7;
            this.authorField.Enter += new System.EventHandler(this.authorField_Enter);
            this.authorField.Leave += new System.EventHandler(this.authorField_Leave);
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.Teal;
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.ForeColor = System.Drawing.SystemColors.Control;
            this.nameField.Location = new System.Drawing.Point(259, 106);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(299, 33);
            this.nameField.TabIndex = 6;
            this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
            this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegister.Location = new System.Drawing.Point(236, 306);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(215, 39);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Внести данные";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Title.Size = new System.Drawing.Size(673, 100);
            this.Title.TabIndex = 0;
            this.Title.Text = "Прием экспонатов";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 414);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrForm";
            this.Text = "RegistrForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label Accaunt;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox yearField;
        private System.Windows.Forms.ComboBox locationSwitch;
    }
}