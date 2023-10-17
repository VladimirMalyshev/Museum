namespace Museum
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
            this.panel = new System.Windows.Forms.Panel();
            this.buttonAuthorReport = new System.Windows.Forms.Button();
            this.buttonItemReport = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Teal;
            this.panel.Controls.Add(this.buttonAuthorReport);
            this.panel.Controls.Add(this.buttonItemReport);
            this.panel.Controls.Add(this.buttonCount);
            this.panel.Controls.Add(this.buttonRegister);
            this.panel.Controls.Add(this.Title);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(701, 390);
            this.panel.TabIndex = 2;
            // 
            // buttonAuthorReport
            // 
            this.buttonAuthorReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAuthorReport.BackColor = System.Drawing.Color.Teal;
            this.buttonAuthorReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthorReport.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAuthorReport.Location = new System.Drawing.Point(89, 284);
            this.buttonAuthorReport.Name = "buttonAuthorReport";
            this.buttonAuthorReport.Size = new System.Drawing.Size(542, 39);
            this.buttonAuthorReport.TabIndex = 8;
            this.buttonAuthorReport.Text = "Список авторов, чьи экспонаты находятся на выставке";
            this.buttonAuthorReport.UseVisualStyleBackColor = false;
            this.buttonAuthorReport.Click += new System.EventHandler(this.buttonAuthorReport_Click);
            // 
            // buttonItemReport
            // 
            this.buttonItemReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonItemReport.BackColor = System.Drawing.Color.Teal;
            this.buttonItemReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItemReport.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonItemReport.Location = new System.Drawing.Point(155, 229);
            this.buttonItemReport.Name = "buttonItemReport";
            this.buttonItemReport.Size = new System.Drawing.Size(398, 39);
            this.buttonItemReport.TabIndex = 7;
            this.buttonItemReport.Text = "Список экспонатов заданного автора";
            this.buttonItemReport.UseVisualStyleBackColor = false;
            this.buttonItemReport.Click += new System.EventHandler(this.buttonItemReport_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCount.BackColor = System.Drawing.Color.Teal;
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCount.Location = new System.Drawing.Point(184, 175);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(337, 39);
            this.buttonCount.TabIndex = 6;
            this.buttonCount.Text = "Количество экспонатов в зале";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegister.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegister.Location = new System.Drawing.Point(248, 120);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(215, 39);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Добавить экспонат";
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
            this.Title.Size = new System.Drawing.Size(701, 100);
            this.Title.TabIndex = 0;
            this.Title.Text = "Добро пожаловать в ИС \"Музей\"";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 390);
            this.Controls.Add(this.panel);
            this.Name = "MainForm";
            this.Text = "ИС \"Музей\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button buttonAuthorReport;
        private System.Windows.Forms.Button buttonItemReport;
        private System.Windows.Forms.Button buttonCount;
    }
}

