namespace Inspections
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listTabs = new System.Windows.Forms.TabControl();
            this.polesTab = new System.Windows.Forms.TabPage();
            this.poleGridView = new System.Windows.Forms.DataGridView();
            this.boxesTab = new System.Windows.Forms.TabPage();
            this.boxGridView = new System.Windows.Forms.DataGridView();
            this.inspectionsTab = new System.Windows.Forms.TabPage();
            this.inspectionGridView = new System.Windows.Forms.DataGridView();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.listTabs.SuspendLayout();
            this.polesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poleGridView)).BeginInit();
            this.boxesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxGridView)).BeginInit();
            this.inspectionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionGridView)).BeginInit();
            this.registerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // listTabs
            // 
            this.listTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.listTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listTabs.Controls.Add(this.polesTab);
            this.listTabs.Controls.Add(this.boxesTab);
            this.listTabs.Controls.Add(this.inspectionsTab);
            this.listTabs.Controls.Add(this.registerTab);
            this.listTabs.Location = new System.Drawing.Point(12, 129);
            this.listTabs.Multiline = true;
            this.listTabs.Name = "listTabs";
            this.listTabs.SelectedIndex = 0;
            this.listTabs.Size = new System.Drawing.Size(428, 303);
            this.listTabs.TabIndex = 4;
            // 
            // polesTab
            // 
            this.polesTab.Controls.Add(this.poleGridView);
            this.polesTab.Location = new System.Drawing.Point(4, 4);
            this.polesTab.Name = "polesTab";
            this.polesTab.Padding = new System.Windows.Forms.Padding(3);
            this.polesTab.Size = new System.Drawing.Size(420, 277);
            this.polesTab.TabIndex = 0;
            this.polesTab.Text = "Postes";
            this.polesTab.UseVisualStyleBackColor = true;
            // 
            // poleGridView
            // 
            this.poleGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.poleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poleGridView.Location = new System.Drawing.Point(3, 3);
            this.poleGridView.Name = "poleGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "oie";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poleGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poleGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poleGridView.Size = new System.Drawing.Size(414, 271);
            this.poleGridView.TabIndex = 0;
            // 
            // boxesTab
            // 
            this.boxesTab.Controls.Add(this.boxGridView);
            this.boxesTab.Location = new System.Drawing.Point(4, 4);
            this.boxesTab.Name = "boxesTab";
            this.boxesTab.Padding = new System.Windows.Forms.Padding(3);
            this.boxesTab.Size = new System.Drawing.Size(420, 274);
            this.boxesTab.TabIndex = 1;
            this.boxesTab.Text = "Caixas";
            this.boxesTab.UseVisualStyleBackColor = true;
            // 
            // boxGridView
            // 
            this.boxGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.boxGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boxGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxGridView.Location = new System.Drawing.Point(3, 3);
            this.boxGridView.Name = "boxGridView";
            this.boxGridView.Size = new System.Drawing.Size(414, 268);
            this.boxGridView.TabIndex = 0;
            // 
            // inspectionsTab
            // 
            this.inspectionsTab.Controls.Add(this.inspectionGridView);
            this.inspectionsTab.Location = new System.Drawing.Point(4, 4);
            this.inspectionsTab.Name = "inspectionsTab";
            this.inspectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.inspectionsTab.Size = new System.Drawing.Size(420, 274);
            this.inspectionsTab.TabIndex = 2;
            this.inspectionsTab.Text = "Inspeções";
            this.inspectionsTab.UseVisualStyleBackColor = true;
            // 
            // inspectionGridView
            // 
            this.inspectionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inspectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionGridView.Location = new System.Drawing.Point(3, 3);
            this.inspectionGridView.Name = "inspectionGridView";
            this.inspectionGridView.Size = new System.Drawing.Size(414, 268);
            this.inspectionGridView.TabIndex = 0;
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.label1);
            this.registerTab.Controls.Add(this.comboBox1);
            this.registerTab.Location = new System.Drawing.Point(4, 4);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(420, 274);
            this.registerTab.TabIndex = 3;
            this.registerTab.Text = "Cadastro";
            this.registerTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(133, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Inspections.Properties.Resources.detalhes;
            this.pictureBox3.Location = new System.Drawing.Point(323, 415);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Inspections.Properties.Resources.incluir;
            this.pictureBox2.Location = new System.Drawing.Point(364, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.insertNewPole_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Inspections.Properties.Resources.excluir;
            this.pictureBox1.Location = new System.Drawing.Point(405, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox7);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 114);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Inspections.Properties.Resources.caixasc;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(208, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.energyBoxPictureBox_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(217, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(208, 51);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.polesPictureBox_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Inspections.Properties.Resources.inspeçãoc;
            this.pictureBox7.Location = new System.Drawing.Point(3, 60);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(208, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.inspectionsPictureBox_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Inspections.Properties.Resources.relatorioc;
            this.pictureBox8.Location = new System.Drawing.Point(217, 60);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(208, 51);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 459);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listTabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.listTabs.ResumeLayout(false);
            this.polesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poleGridView)).EndInit();
            this.boxesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxGridView)).EndInit();
            this.inspectionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionGridView)).EndInit();
            this.registerTab.ResumeLayout(false);
            this.registerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGrids;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl listTabs;
        private System.Windows.Forms.TabPage polesTab;
        private System.Windows.Forms.TabPage boxesTab;
        private System.Windows.Forms.TabPage inspectionsTab;
        private System.Windows.Forms.DataGridView poleGridView;
        private System.Windows.Forms.DataGridView boxGridView;
        private System.Windows.Forms.DataGridView inspectionGridView;
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

