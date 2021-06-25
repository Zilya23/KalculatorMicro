namespace KalculatorMicro
{
    partial class FormCalc
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
            this.tbDays = new System.Windows.Forms.TextBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.lblProcent = new System.Windows.Forms.Label();
            this.tbProcent = new System.Windows.Forms.TextBox();
            this.btnOkFirst = new System.Windows.Forms.Button();
            this.lboxRez = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(131, 40);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(208, 20);
            this.tbDays.TabIndex = 0;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(42, 39);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "Days";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(42, 92);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Sum";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(131, 93);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(208, 20);
            this.tbSum.TabIndex = 2;
            // 
            // lblProcent
            // 
            this.lblProcent.AutoSize = true;
            this.lblProcent.Location = new System.Drawing.Point(42, 145);
            this.lblProcent.Name = "lblProcent";
            this.lblProcent.Size = new System.Drawing.Size(44, 13);
            this.lblProcent.TabIndex = 5;
            this.lblProcent.Text = "Procent";
            // 
            // tbProcent
            // 
            this.tbProcent.Location = new System.Drawing.Point(131, 146);
            this.tbProcent.Name = "tbProcent";
            this.tbProcent.Size = new System.Drawing.Size(208, 20);
            this.tbProcent.TabIndex = 4;
            // 
            // btnOkFirst
            // 
            this.btnOkFirst.Location = new System.Drawing.Point(194, 198);
            this.btnOkFirst.Name = "btnOkFirst";
            this.btnOkFirst.Size = new System.Drawing.Size(75, 51);
            this.btnOkFirst.TabIndex = 6;
            this.btnOkFirst.Text = "Ok";
            this.btnOkFirst.UseVisualStyleBackColor = true;
            this.btnOkFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // lboxRez
            // 
            this.lboxRez.FormattingEnabled = true;
            this.lboxRez.Location = new System.Drawing.Point(45, 281);
            this.lboxRez.Name = "lboxRez";
            this.lboxRez.Size = new System.Drawing.Size(315, 290);
            this.lboxRez.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(353, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 594);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lboxRez);
            this.Controls.Add(this.btnOkFirst);
            this.Controls.Add(this.lblProcent);
            this.Controls.Add(this.tbProcent);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.tbDays);
            this.Name = "FormCalc";
            this.Text = "Калькулятор микрокредита";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label lblProcent;
        private System.Windows.Forms.TextBox tbProcent;
        private System.Windows.Forms.Button btnOkFirst;
        private System.Windows.Forms.ListBox lboxRez;
        private System.Windows.Forms.Button btnSave;
    }
}

