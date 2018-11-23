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
            this.typeRegistration = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.boxesPictureBox = new System.Windows.Forms.PictureBox();
            this.polesPictureBox = new System.Windows.Forms.PictureBox();
            this.inspectionsPictureBox = new System.Windows.Forms.PictureBox();
            this.reportsPictureBox = new System.Windows.Forms.PictureBox();
            this.type = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.boxesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsPictureBox)).BeginInit();
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
            this.listTabs.Size = new System.Drawing.Size(428, 299);
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
            this.boxesTab.Size = new System.Drawing.Size(420, 277);
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
            this.boxGridView.Size = new System.Drawing.Size(414, 271);
            this.boxGridView.TabIndex = 0;
            // 
            // inspectionsTab
            // 
            this.inspectionsTab.Controls.Add(this.inspectionGridView);
            this.inspectionsTab.Location = new System.Drawing.Point(4, 4);
            this.inspectionsTab.Name = "inspectionsTab";
            this.inspectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.inspectionsTab.Size = new System.Drawing.Size(420, 277);
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
            this.inspectionGridView.Size = new System.Drawing.Size(414, 271);
            this.inspectionGridView.TabIndex = 0;
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.type);
            this.registerTab.Controls.Add(this.typeRegistration);
            this.registerTab.Location = new System.Drawing.Point(4, 4);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(420, 273);
            this.registerTab.TabIndex = 3;
            this.registerTab.Text = "Cadastro";
            this.registerTab.UseVisualStyleBackColor = true;
            // 
            // typeRegistration
            // 
            this.typeRegistration.FormattingEnabled = true;
            this.typeRegistration.Items.AddRange(new object[] {
            "Caixa",
            "Poste",
            "Inspeção"});
            this.typeRegistration.Location = new System.Drawing.Point(40, 6);
            this.typeRegistration.Name = "typeRegistration";
            this.typeRegistration.Size = new System.Drawing.Size(121, 21);
            this.typeRegistration.TabIndex = 0;
            this.typeRegistration.SelectedIndexChanged += new System.EventHandler(this.typeRegistration_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Inspections.Properties.Resources.detalhes;
            this.pictureBox3.Location = new System.Drawing.Point(307, 412);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Inspections.Properties.Resources.incluir;
            this.pictureBox2.Location = new System.Drawing.Point(353, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.insertNewPole_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Inspections.Properties.Resources.excluir;
            this.pictureBox1.Location = new System.Drawing.Point(399, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.boxesPictureBox);
            this.flowLayoutPanel1.Controls.Add(this.polesPictureBox);
            this.flowLayoutPanel1.Controls.Add(this.inspectionsPictureBox);
            this.flowLayoutPanel1.Controls.Add(this.reportsPictureBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 114);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // boxesPictureBox
            // 
            this.boxesPictureBox.Image = global::Inspections.Properties.Resources.caixasc;
            this.boxesPictureBox.Location = new System.Drawing.Point(3, 3);
            this.boxesPictureBox.Name = "boxesPictureBox";
            this.boxesPictureBox.Size = new System.Drawing.Size(208, 51);
            this.boxesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxesPictureBox.TabIndex = 2;
            this.boxesPictureBox.TabStop = false;
            this.boxesPictureBox.Click += new System.EventHandler(this.energyBoxPictureBox_Click);
            // 
            // polesPictureBox
            // 
            this.polesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("polesPictureBox.Image")));
            this.polesPictureBox.Location = new System.Drawing.Point(217, 3);
            this.polesPictureBox.Name = "polesPictureBox";
            this.polesPictureBox.Size = new System.Drawing.Size(208, 51);
            this.polesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.polesPictureBox.TabIndex = 3;
            this.polesPictureBox.TabStop = false;
            this.polesPictureBox.Click += new System.EventHandler(this.polesPictureBox_Click);
            // 
            // inspectionsPictureBox
            // 
            this.inspectionsPictureBox.Image = global::Inspections.Properties.Resources.inspeçãoc;
            this.inspectionsPictureBox.Location = new System.Drawing.Point(3, 60);
            this.inspectionsPictureBox.Name = "inspectionsPictureBox";
            this.inspectionsPictureBox.Size = new System.Drawing.Size(208, 51);
            this.inspectionsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inspectionsPictureBox.TabIndex = 4;
            this.inspectionsPictureBox.TabStop = false;
            this.inspectionsPictureBox.Click += new System.EventHandler(this.inspectionsPictureBox_Click);
            // 
            // reportsPictureBox
            // 
            this.reportsPictureBox.Image = global::Inspections.Properties.Resources.relatorioc;
            this.reportsPictureBox.Location = new System.Drawing.Point(217, 60);
            this.reportsPictureBox.Name = "reportsPictureBox";
            this.reportsPictureBox.Size = new System.Drawing.Size(208, 51);
            this.reportsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportsPictureBox.TabIndex = 5;
            this.reportsPictureBox.TabStop = false;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(6, 9);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(28, 13);
            this.type.TabIndex = 1;
            this.type.Text = "Tipo";
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
            this.MinimumSize = new System.Drawing.Size(467, 498);
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
            ((System.ComponentModel.ISupportInitialize)(this.boxesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsPictureBox)).EndInit();
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
        private System.Windows.Forms.ComboBox typeRegistration;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox boxesPictureBox;
        private System.Windows.Forms.PictureBox polesPictureBox;
        private System.Windows.Forms.PictureBox inspectionsPictureBox;
        private System.Windows.Forms.PictureBox reportsPictureBox;
        private System.Windows.Forms.Label type;
    }
}

