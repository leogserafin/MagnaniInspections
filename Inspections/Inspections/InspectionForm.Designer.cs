namespace Inspections
{
    partial class InspectionForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.finalDate = new System.Windows.Forms.MaskedTextBox();
            this.initialDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "até";
            // 
            // finalDate
            // 
            this.finalDate.Location = new System.Drawing.Point(219, 26);
            this.finalDate.Mask = "00/00/0000";
            this.finalDate.Name = "finalDate";
            this.finalDate.PromptChar = ' ';
            this.finalDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.finalDate.Size = new System.Drawing.Size(126, 20);
            this.finalDate.TabIndex = 32;
            this.finalDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalDate.ValidatingType = typeof(System.DateTime);
            // 
            // initialDate
            // 
            this.initialDate.Location = new System.Drawing.Point(62, 26);
            this.initialDate.Mask = "00/00/0000";
            this.initialDate.Name = "initialDate";
            this.initialDate.PromptChar = ' ';
            this.initialDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.initialDate.Size = new System.Drawing.Size(126, 20);
            this.initialDate.TabIndex = 31;
            this.initialDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.initialDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Digite o periodo de tempo desejado";
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 460);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finalDate);
            this.Controls.Add(this.initialDate);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(467, 499);
            this.MinimumSize = new System.Drawing.Size(467, 499);
            this.Name = "InspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InspectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox finalDate;
        private System.Windows.Forms.MaskedTextBox initialDate;
        private System.Windows.Forms.Label label1;
    }
}