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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listTabs = new System.Windows.Forms.TabControl();
            this.polesTab = new System.Windows.Forms.TabPage();
            this.poleGridView = new System.Windows.Forms.DataGridView();
            this.boxesTab = new System.Windows.Forms.TabPage();
            this.boxGridView = new System.Windows.Forms.DataGridView();
            this.inspectionsTab = new System.Windows.Forms.TabPage();
            this.inspectionGridView = new System.Windows.Forms.DataGridView();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.inspectionRegister = new System.Windows.Forms.Panel();
            this.wiringComboBox = new System.Windows.Forms.ComboBox();
            this.bobComboBox = new System.Windows.Forms.ComboBox();
            this.inspectionDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.situationComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inspectionPoleIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxRegister = new System.Windows.Forms.Panel();
            this.boxWattsTextBox = new System.Windows.Forms.MaskedTextBox();
            this.boxTypeComboBox = new System.Windows.Forms.ComboBox();
            this.boxLongitudeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxLatitudeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.poleRegister = new System.Windows.Forms.Panel();
            this.poleBoxIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.boxID_FK = new System.Windows.Forms.Label();
            this.poleLongitudeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.poleLongitude = new System.Windows.Forms.Label();
            this.poleLatitudeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.poleLatitude = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.poleMaterial = new System.Windows.Forms.Label();
            this.poleHeightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.poleHeight = new System.Windows.Forms.Label();
            this.poleIdTextBox = new System.Windows.Forms.MaskedTextBox();
            this.poleID = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.typeRegistration = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.boxesPictureBox = new System.Windows.Forms.PictureBox();
            this.polesPictureBox = new System.Windows.Forms.PictureBox();
            this.inspectionsPictureBox = new System.Windows.Forms.PictureBox();
            this.reportsPictureBox = new System.Windows.Forms.PictureBox();
            this.listTabs.SuspendLayout();
            this.polesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poleGridView)).BeginInit();
            this.boxesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxGridView)).BeginInit();
            this.inspectionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionGridView)).BeginInit();
            this.registerTab.SuspendLayout();
            this.inspectionRegister.SuspendLayout();
            this.boxRegister.SuspendLayout();
            this.poleRegister.SuspendLayout();
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
            this.polesTab.Size = new System.Drawing.Size(420, 273);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "oie";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poleGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.poleGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.poleGridView.Size = new System.Drawing.Size(414, 267);
            this.poleGridView.TabIndex = 0;
            // 
            // boxesTab
            // 
            this.boxesTab.Controls.Add(this.boxGridView);
            this.boxesTab.Location = new System.Drawing.Point(4, 4);
            this.boxesTab.Name = "boxesTab";
            this.boxesTab.Padding = new System.Windows.Forms.Padding(3);
            this.boxesTab.Size = new System.Drawing.Size(420, 273);
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
            this.boxGridView.Size = new System.Drawing.Size(414, 267);
            this.boxGridView.TabIndex = 0;
            // 
            // inspectionsTab
            // 
            this.inspectionsTab.Controls.Add(this.inspectionGridView);
            this.inspectionsTab.Location = new System.Drawing.Point(4, 4);
            this.inspectionsTab.Name = "inspectionsTab";
            this.inspectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.inspectionsTab.Size = new System.Drawing.Size(420, 273);
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
            this.inspectionGridView.Size = new System.Drawing.Size(414, 267);
            this.inspectionGridView.TabIndex = 0;
            // 
            // registerTab
            // 
            this.registerTab.Controls.Add(this.boxRegister);
            this.registerTab.Controls.Add(this.poleRegister);
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
            // inspectionRegister
            // 
            this.inspectionRegister.Controls.Add(this.wiringComboBox);
            this.inspectionRegister.Controls.Add(this.bobComboBox);
            this.inspectionRegister.Controls.Add(this.inspectionDate);
            this.inspectionRegister.Controls.Add(this.label1);
            this.inspectionRegister.Controls.Add(this.situationComboBox);
            this.inspectionRegister.Controls.Add(this.label7);
            this.inspectionRegister.Controls.Add(this.label8);
            this.inspectionRegister.Controls.Add(this.label9);
            this.inspectionRegister.Controls.Add(this.inspectionPoleIdTextBox);
            this.inspectionRegister.Controls.Add(this.label10);
            this.inspectionRegister.Location = new System.Drawing.Point(0, 0);
            this.inspectionRegister.Name = "inspectionRegister";
            this.inspectionRegister.Size = new System.Drawing.Size(201, 192);
            this.inspectionRegister.TabIndex = 23;
            // 
            // wiringComboBox
            // 
            this.wiringComboBox.FormattingEnabled = true;
            this.wiringComboBox.Items.AddRange(new object[] {
            "Conservada",
            "Deteriorada"});
            this.wiringComboBox.Location = new System.Drawing.Point(59, 82);
            this.wiringComboBox.Name = "wiringComboBox";
            this.wiringComboBox.Size = new System.Drawing.Size(126, 21);
            this.wiringComboBox.TabIndex = 26;
            this.wiringComboBox.Text = "[Selecione]";
            // 
            // bobComboBox
            // 
            this.bobComboBox.FormattingEnabled = true;
            this.bobComboBox.Items.AddRange(new object[] {
            "Alinhado",
            "Desalinhado"});
            this.bobComboBox.Location = new System.Drawing.Point(59, 55);
            this.bobComboBox.Name = "bobComboBox";
            this.bobComboBox.Size = new System.Drawing.Size(126, 21);
            this.bobComboBox.TabIndex = 25;
            this.bobComboBox.Text = "[Selecione]";
            // 
            // inspectionDate
            // 
            this.inspectionDate.Location = new System.Drawing.Point(59, 108);
            this.inspectionDate.Mask = "00/00/0000";
            this.inspectionDate.Name = "inspectionDate";
            this.inspectionDate.PromptChar = ' ';
            this.inspectionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inspectionDate.Size = new System.Drawing.Size(126, 20);
            this.inspectionDate.TabIndex = 24;
            this.inspectionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inspectionDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data";
            // 
            // situationComboBox
            // 
            this.situationComboBox.FormattingEnabled = true;
            this.situationComboBox.Items.AddRange(new object[] {
            "Conservado",
            "Deteriorado"});
            this.situationComboBox.Location = new System.Drawing.Point(59, 29);
            this.situationComboBox.Name = "situationComboBox";
            this.situationComboBox.Size = new System.Drawing.Size(126, 21);
            this.situationComboBox.TabIndex = 21;
            this.situationComboBox.Text = "[Selecione]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fiação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Prumo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Estado";
            // 
            // inspectionPoleIdTextBox
            // 
            this.inspectionPoleIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inspectionPoleIdTextBox.Location = new System.Drawing.Point(59, 3);
            this.inspectionPoleIdTextBox.Mask = "99999999999999999999";
            this.inspectionPoleIdTextBox.Name = "inspectionPoleIdTextBox";
            this.inspectionPoleIdTextBox.PromptChar = ' ';
            this.inspectionPoleIdTextBox.Size = new System.Drawing.Size(126, 20);
            this.inspectionPoleIdTextBox.TabIndex = 9;
            this.inspectionPoleIdTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Poste";
            // 
            // boxRegister
            // 
            this.boxRegister.Controls.Add(this.inspectionRegister);
            this.boxRegister.Controls.Add(this.boxWattsTextBox);
            this.boxRegister.Controls.Add(this.boxTypeComboBox);
            this.boxRegister.Controls.Add(this.boxLongitudeTextBox);
            this.boxRegister.Controls.Add(this.label2);
            this.boxRegister.Controls.Add(this.boxLatitudeTextBox);
            this.boxRegister.Controls.Add(this.label3);
            this.boxRegister.Controls.Add(this.label4);
            this.boxRegister.Controls.Add(this.label5);
            this.boxRegister.Controls.Add(this.boxIdTextBox);
            this.boxRegister.Controls.Add(this.label6);
            this.boxRegister.Location = new System.Drawing.Point(9, 33);
            this.boxRegister.Name = "boxRegister";
            this.boxRegister.Size = new System.Drawing.Size(201, 192);
            this.boxRegister.TabIndex = 21;
            // 
            // boxWattsTextBox
            // 
            this.boxWattsTextBox.Location = new System.Drawing.Point(59, 55);
            this.boxWattsTextBox.Mask = "000000";
            this.boxWattsTextBox.Name = "boxWattsTextBox";
            this.boxWattsTextBox.PromptChar = ' ';
            this.boxWattsTextBox.Size = new System.Drawing.Size(126, 20);
            this.boxWattsTextBox.TabIndex = 22;
            this.boxWattsTextBox.ValidatingType = typeof(int);
            // 
            // boxTypeComboBox
            // 
            this.boxTypeComboBox.FormattingEnabled = true;
            this.boxTypeComboBox.Items.AddRange(new object[] {
            "Externa",
            "Interna"});
            this.boxTypeComboBox.Location = new System.Drawing.Point(59, 29);
            this.boxTypeComboBox.Name = "boxTypeComboBox";
            this.boxTypeComboBox.Size = new System.Drawing.Size(126, 21);
            this.boxTypeComboBox.TabIndex = 21;
            this.boxTypeComboBox.Text = "[Selecione]";
            // 
            // boxLongitudeTextBox
            // 
            this.boxLongitudeTextBox.Location = new System.Drawing.Point(59, 108);
            this.boxLongitudeTextBox.Mask = "###########.##";
            this.boxLongitudeTextBox.Name = "boxLongitudeTextBox";
            this.boxLongitudeTextBox.PromptChar = ' ';
            this.boxLongitudeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxLongitudeTextBox.Size = new System.Drawing.Size(126, 20);
            this.boxLongitudeTextBox.TabIndex = 18;
            this.boxLongitudeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Longitude";
            // 
            // boxLatitudeTextBox
            // 
            this.boxLatitudeTextBox.Location = new System.Drawing.Point(59, 82);
            this.boxLatitudeTextBox.Mask = "##########.##";
            this.boxLatitudeTextBox.Name = "boxLatitudeTextBox";
            this.boxLatitudeTextBox.PromptChar = ' ';
            this.boxLatitudeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxLatitudeTextBox.Size = new System.Drawing.Size(126, 20);
            this.boxLatitudeTextBox.TabIndex = 16;
            this.boxLatitudeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Watts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo";
            // 
            // boxIdTextBox
            // 
            this.boxIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxIdTextBox.Location = new System.Drawing.Point(59, 3);
            this.boxIdTextBox.Mask = "99999999999999999999";
            this.boxIdTextBox.Name = "boxIdTextBox";
            this.boxIdTextBox.PromptChar = ' ';
            this.boxIdTextBox.Size = new System.Drawing.Size(126, 20);
            this.boxIdTextBox.TabIndex = 9;
            this.boxIdTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Etiqueta";
            // 
            // poleRegister
            // 
            this.poleRegister.Controls.Add(this.poleBoxIdTextBox);
            this.poleRegister.Controls.Add(this.boxID_FK);
            this.poleRegister.Controls.Add(this.poleLongitudeTextBox);
            this.poleRegister.Controls.Add(this.poleLongitude);
            this.poleRegister.Controls.Add(this.poleLatitudeTextBox);
            this.poleRegister.Controls.Add(this.poleLatitude);
            this.poleRegister.Controls.Add(this.materialComboBox);
            this.poleRegister.Controls.Add(this.poleMaterial);
            this.poleRegister.Controls.Add(this.poleHeightTextBox);
            this.poleRegister.Controls.Add(this.poleHeight);
            this.poleRegister.Controls.Add(this.poleIdTextBox);
            this.poleRegister.Controls.Add(this.poleID);
            this.poleRegister.Location = new System.Drawing.Point(9, 33);
            this.poleRegister.Name = "poleRegister";
            this.poleRegister.Size = new System.Drawing.Size(201, 192);
            this.poleRegister.TabIndex = 8;
            // 
            // poleBoxIdTextBox
            // 
            this.poleBoxIdTextBox.Location = new System.Drawing.Point(59, 134);
            this.poleBoxIdTextBox.Mask = "99999999999999999999";
            this.poleBoxIdTextBox.Name = "poleBoxIdTextBox";
            this.poleBoxIdTextBox.PromptChar = ' ';
            this.poleBoxIdTextBox.Size = new System.Drawing.Size(126, 20);
            this.poleBoxIdTextBox.TabIndex = 20;
            // 
            // boxID_FK
            // 
            this.boxID_FK.AutoSize = true;
            this.boxID_FK.Location = new System.Drawing.Point(3, 137);
            this.boxID_FK.Name = "boxID_FK";
            this.boxID_FK.Size = new System.Drawing.Size(33, 13);
            this.boxID_FK.TabIndex = 19;
            this.boxID_FK.Text = "Caixa";
            // 
            // poleLongitudeTextBox
            // 
            this.poleLongitudeTextBox.Location = new System.Drawing.Point(59, 108);
            this.poleLongitudeTextBox.Mask = "###########.##";
            this.poleLongitudeTextBox.Name = "poleLongitudeTextBox";
            this.poleLongitudeTextBox.PromptChar = ' ';
            this.poleLongitudeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poleLongitudeTextBox.Size = new System.Drawing.Size(126, 20);
            this.poleLongitudeTextBox.TabIndex = 18;
            this.poleLongitudeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleLongitude
            // 
            this.poleLongitude.AutoSize = true;
            this.poleLongitude.Location = new System.Drawing.Point(3, 111);
            this.poleLongitude.Name = "poleLongitude";
            this.poleLongitude.Size = new System.Drawing.Size(54, 13);
            this.poleLongitude.TabIndex = 17;
            this.poleLongitude.Text = "Longitude";
            // 
            // poleLatitudeTextBox
            // 
            this.poleLatitudeTextBox.Location = new System.Drawing.Point(59, 82);
            this.poleLatitudeTextBox.Mask = "##########.##";
            this.poleLatitudeTextBox.Name = "poleLatitudeTextBox";
            this.poleLatitudeTextBox.PromptChar = ' ';
            this.poleLatitudeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.poleLatitudeTextBox.Size = new System.Drawing.Size(126, 20);
            this.poleLatitudeTextBox.TabIndex = 16;
            this.poleLatitudeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // poleLatitude
            // 
            this.poleLatitude.AutoSize = true;
            this.poleLatitude.Location = new System.Drawing.Point(3, 85);
            this.poleLatitude.Name = "poleLatitude";
            this.poleLatitude.Size = new System.Drawing.Size(45, 13);
            this.poleLatitude.TabIndex = 15;
            this.poleLatitude.Text = "Latitude";
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Items.AddRange(new object[] {
            "Concreto",
            "Madeira",
            "Metal"});
            this.materialComboBox.Location = new System.Drawing.Point(59, 55);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(126, 21);
            this.materialComboBox.TabIndex = 14;
            this.materialComboBox.Text = "[Selecione]";
            // 
            // poleMaterial
            // 
            this.poleMaterial.AutoSize = true;
            this.poleMaterial.Location = new System.Drawing.Point(3, 58);
            this.poleMaterial.Name = "poleMaterial";
            this.poleMaterial.Size = new System.Drawing.Size(44, 13);
            this.poleMaterial.TabIndex = 12;
            this.poleMaterial.Text = "Material";
            // 
            // poleHeightTextBox
            // 
            this.poleHeightTextBox.Location = new System.Drawing.Point(59, 30);
            this.poleHeightTextBox.Mask = "##.#######";
            this.poleHeightTextBox.Name = "poleHeightTextBox";
            this.poleHeightTextBox.PromptChar = ' ';
            this.poleHeightTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.poleHeightTextBox.Size = new System.Drawing.Size(126, 20);
            this.poleHeightTextBox.TabIndex = 11;
            // 
            // poleHeight
            // 
            this.poleHeight.AutoSize = true;
            this.poleHeight.Location = new System.Drawing.Point(3, 32);
            this.poleHeight.Name = "poleHeight";
            this.poleHeight.Size = new System.Drawing.Size(34, 13);
            this.poleHeight.TabIndex = 10;
            this.poleHeight.Text = "Altura";
            // 
            // poleIdTextBox
            // 
            this.poleIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.poleIdTextBox.Location = new System.Drawing.Point(59, 3);
            this.poleIdTextBox.Mask = "99999999999999999999";
            this.poleIdTextBox.Name = "poleIdTextBox";
            this.poleIdTextBox.PromptChar = ' ';
            this.poleIdTextBox.Size = new System.Drawing.Size(126, 20);
            this.poleIdTextBox.TabIndex = 9;
            this.poleIdTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // poleID
            // 
            this.poleID.AutoSize = true;
            this.poleID.Location = new System.Drawing.Point(3, 6);
            this.poleID.Name = "poleID";
            this.poleID.Size = new System.Drawing.Size(46, 13);
            this.poleID.TabIndex = 8;
            this.poleID.Text = "Etiqueta";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(12, 9);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(28, 13);
            this.type.TabIndex = 1;
            this.type.Text = "Tipo";
            // 
            // typeRegistration
            // 
            this.typeRegistration.FormattingEnabled = true;
            this.typeRegistration.Items.AddRange(new object[] {
            "Caixa",
            "Poste",
            "Inspeção"});
            this.typeRegistration.Location = new System.Drawing.Point(68, 6);
            this.typeRegistration.Name = "typeRegistration";
            this.typeRegistration.Size = new System.Drawing.Size(126, 21);
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
            this.pictureBox2.Click += new System.EventHandler(this.insertNewRegister_Click);
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
            this.boxesPictureBox.DoubleClick += new System.EventHandler(this.insertNewRegister_Click);
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
            this.polesPictureBox.DoubleClick += new System.EventHandler(this.insertNewRegister_Click);
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
            this.inspectionsPictureBox.DoubleClick += new System.EventHandler(this.insertNewRegister_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 460);
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
            this.inspectionRegister.ResumeLayout(false);
            this.inspectionRegister.PerformLayout();
            this.boxRegister.ResumeLayout(false);
            this.boxRegister.PerformLayout();
            this.poleRegister.ResumeLayout(false);
            this.poleRegister.PerformLayout();
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
        private System.Windows.Forms.Panel poleRegister;
        private System.Windows.Forms.MaskedTextBox poleBoxIdTextBox;
        private System.Windows.Forms.Label boxID_FK;
        private System.Windows.Forms.MaskedTextBox poleLongitudeTextBox;
        private System.Windows.Forms.Label poleLongitude;
        private System.Windows.Forms.MaskedTextBox poleLatitudeTextBox;
        private System.Windows.Forms.Label poleLatitude;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label poleMaterial;
        private System.Windows.Forms.MaskedTextBox poleHeightTextBox;
        private System.Windows.Forms.Label poleHeight;
        private System.Windows.Forms.MaskedTextBox poleIdTextBox;
        private System.Windows.Forms.Label poleID;
        private System.Windows.Forms.Panel inspectionRegister;
        private System.Windows.Forms.ComboBox wiringComboBox;
        private System.Windows.Forms.ComboBox bobComboBox;
        private System.Windows.Forms.MaskedTextBox inspectionDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox situationComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox inspectionPoleIdTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel boxRegister;
        private System.Windows.Forms.MaskedTextBox boxWattsTextBox;
        private System.Windows.Forms.ComboBox boxTypeComboBox;
        private System.Windows.Forms.MaskedTextBox boxLongitudeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox boxLatitudeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox boxIdTextBox;
        private System.Windows.Forms.Label label6;
    }
}

