namespace Inspections
{
    partial class RelatorioAdequado
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
            this.reportGenerator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.finalDate = new System.Windows.Forms.MaskedTextBox();
            this.initialDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportGenerator
            // 
            this.reportGenerator.Location = new System.Drawing.Point(166, 62);
            this.reportGenerator.Name = "reportGenerator";
            this.reportGenerator.Size = new System.Drawing.Size(75, 23);
            this.reportGenerator.TabIndex = 33;
            this.reportGenerator.Text = "Gerar";
            this.reportGenerator.UseVisualStyleBackColor = true;
            this.reportGenerator.Click += new System.EventHandler(this.reportGenerator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "até";
            // 
            // finalDate
            // 
            this.finalDate.Location = new System.Drawing.Point(226, 36);
            this.finalDate.Mask = "00/00/0000";
            this.finalDate.Name = "finalDate";
            this.finalDate.PromptChar = ' ';
            this.finalDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.finalDate.Size = new System.Drawing.Size(126, 20);
            this.finalDate.TabIndex = 31;
            this.finalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalDate.ValidatingType = typeof(System.DateTime);
            // 
            // initialDate
            // 
            this.initialDate.Location = new System.Drawing.Point(56, 36);
            this.initialDate.Mask = "00/00/0000";
            this.initialDate.Name = "initialDate";
            this.initialDate.PromptChar = ' ';
            this.initialDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.initialDate.Size = new System.Drawing.Size(126, 20);
            this.initialDate.TabIndex = 30;
            this.initialDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.initialDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Insira o periodo em que você quer gerar o roleatório";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RelatorioAdequado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 260);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finalDate);
            this.Controls.Add(this.initialDate);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(428, 299);
            this.MinimumSize = new System.Drawing.Size(428, 299);
            this.Name = "RelatorioAdequado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RelatorioAdequado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox finalDate;
        private System.Windows.Forms.MaskedTextBox initialDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}