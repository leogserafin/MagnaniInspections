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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inspectionsPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.energyBoxPictureBox = new System.Windows.Forms.PictureBox();
            this.PolesPictureBox = new System.Windows.Forms.PictureBox();
            this.listTabs = new System.Windows.Forms.TabControl();
            this.polesTab = new System.Windows.Forms.TabPage();
            this.poleGridView = new System.Windows.Forms.DataGridView();
            this.boxesTab = new System.Windows.Forms.TabPage();
            this.boxGridView = new System.Windows.Forms.DataGridView();
            this.inspectionsTab = new System.Windows.Forms.TabPage();
            this.inspectionGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyBoxPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolesPictureBox)).BeginInit();
            this.listTabs.SuspendLayout();
            this.polesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poleGridView)).BeginInit();
            this.boxesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxGridView)).BeginInit();
            this.inspectionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.inspectionsPictureBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.energyBoxPictureBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PolesPictureBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inspectionsPictureBox
            // 
            this.inspectionsPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inspectionsPictureBox.Image = global::Inspections.Properties.Resources.inspeçãoc;
            this.inspectionsPictureBox.Location = new System.Drawing.Point(3, 60);
            this.inspectionsPictureBox.Name = "inspectionsPictureBox";
            this.inspectionsPictureBox.Size = new System.Drawing.Size(208, 51);
            this.inspectionsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inspectionsPictureBox.TabIndex = 2;
            this.inspectionsPictureBox.TabStop = false;
            this.inspectionsPictureBox.Click += new System.EventHandler(this.inspectionsPictureBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::Inspections.Properties.Resources.relatorioc;
            this.pictureBox4.Location = new System.Drawing.Point(217, 60);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(208, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // energyBoxPictureBox
            // 
            this.energyBoxPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.energyBoxPictureBox.Image = global::Inspections.Properties.Resources.caixasc;
            this.energyBoxPictureBox.Location = new System.Drawing.Point(217, 3);
            this.energyBoxPictureBox.Name = "energyBoxPictureBox";
            this.energyBoxPictureBox.Size = new System.Drawing.Size(208, 51);
            this.energyBoxPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.energyBoxPictureBox.TabIndex = 1;
            this.energyBoxPictureBox.TabStop = false;
            this.energyBoxPictureBox.Click += new System.EventHandler(this.energyBoxPictureBox_Click);
            // 
            // PolesPictureBox
            // 
            this.PolesPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PolesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PolesPictureBox.Image")));
            this.PolesPictureBox.Location = new System.Drawing.Point(3, 3);
            this.PolesPictureBox.Name = "PolesPictureBox";
            this.PolesPictureBox.Size = new System.Drawing.Size(208, 51);
            this.PolesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PolesPictureBox.TabIndex = 0;
            this.PolesPictureBox.TabStop = false;
            this.PolesPictureBox.Click += new System.EventHandler(this.polesPictureBox_Click);
            // 
            // listTabs
            // 
            this.listTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.listTabs.Controls.Add(this.polesTab);
            this.listTabs.Controls.Add(this.boxesTab);
            this.listTabs.Controls.Add(this.inspectionsTab);
            this.listTabs.Location = new System.Drawing.Point(12, 132);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "oie";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poleGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poleGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poleGridView.Size = new System.Drawing.Size(414, 271);
            this.poleGridView.TabIndex = 0;
            this.poleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.boxGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            this.inspectionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inspectionGridView_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Inspections.Properties.Resources.detalhes;
            this.pictureBox3.Location = new System.Drawing.Point(319, 415);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inspections.Properties.Resources.incluir;
            this.pictureBox2.Location = new System.Drawing.Point(360, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inspections.Properties.Resources.excluir;
            this.pictureBox1.Location = new System.Drawing.Point(401, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 459);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listTabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyBoxPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolesPictureBox)).EndInit();
            this.listTabs.ResumeLayout(false);
            this.polesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poleGridView)).EndInit();
            this.boxesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxGridView)).EndInit();
            this.inspectionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inspectionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PolesPictureBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox inspectionsPictureBox;
        private System.Windows.Forms.PictureBox energyBoxPictureBox;
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
    }
}

