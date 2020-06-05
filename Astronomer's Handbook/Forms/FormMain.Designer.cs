namespace Astronomer_s_Handbook
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.pNav = new System.Windows.Forms.Panel();
            this.flowLPWay = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleEdit = new System.Windows.Forms.Label();
            this.bAddConstellation = new System.Windows.Forms.Button();
            this.bAddStar = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.pBoxRightPanel = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numLatitudeSeconds = new System.Windows.Forms.NumericUpDown();
            this.numLatitudeMinutes = new System.Windows.Forms.NumericUpDown();
            this.numLatitudeDegree = new System.Windows.Forms.NumericUpDown();
            this.dTPickerCurrDateTime = new System.Windows.Forms.DateTimePicker();
            this.numLongtitudeSeconds = new System.Windows.Forms.NumericUpDown();
            this.numLongtitudeMinutes = new System.Windows.Forms.NumericUpDown();
            this.numLongtitudeDegree = new System.Windows.Forms.NumericUpDown();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.pSearch = new System.Windows.Forms.Panel();
            this.pFindFrom = new System.Windows.Forms.Panel();
            this.rBOnlyStars = new System.Windows.Forms.RadioButton();
            this.rBOnlyConstellations = new System.Windows.Forms.RadioButton();
            this.pFilters = new System.Windows.Forms.Panel();
            this.chBoxOnlyVisible = new System.Windows.Forms.CheckBox();
            this.pSortedBy = new System.Windows.Forms.Panel();
            this.lblSortedBy = new System.Windows.Forms.Label();
            this.cBoxSortedBy = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lBoxSky = new System.Windows.Forms.ListBox();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.pNav.SuspendLayout();
            this.flowLPWay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRightPanel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitudeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitudeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitudeDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongtitudeSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongtitudeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongtitudeDegree)).BeginInit();
            this.pSearch.SuspendLayout();
            this.pFindFrom.SuspendLayout();
            this.pFilters.SuspendLayout();
            this.pSortedBy.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNav
            // 
            this.pNav.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pNav.Controls.Add(this.flowLPWay);
            this.pNav.Controls.Add(this.pBoxRightPanel);
            this.pNav.Controls.Add(this.panel1);
            this.pNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.pNav.Location = new System.Drawing.Point(886, 0);
            this.pNav.Name = "pNav";
            this.pNav.Size = new System.Drawing.Size(230, 569);
            this.pNav.TabIndex = 0;
            // 
            // flowLPWay
            // 
            this.flowLPWay.Controls.Add(this.lblTitleEdit);
            this.flowLPWay.Controls.Add(this.bAddConstellation);
            this.flowLPWay.Controls.Add(this.bAddStar);
            this.flowLPWay.Controls.Add(this.bSave);
            this.flowLPWay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLPWay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLPWay.Location = new System.Drawing.Point(0, 437);
            this.flowLPWay.Name = "flowLPWay";
            this.flowLPWay.Size = new System.Drawing.Size(230, 132);
            this.flowLPWay.TabIndex = 1;
            // 
            // lblTitleEdit
            // 
            this.lblTitleEdit.AutoSize = true;
            this.lblTitleEdit.Location = new System.Drawing.Point(5, 5);
            this.lblTitleEdit.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.lblTitleEdit.Name = "lblTitleEdit";
            this.lblTitleEdit.Size = new System.Drawing.Size(39, 13);
            this.lblTitleEdit.TabIndex = 11;
            this.lblTitleEdit.Text = "Опции";
            // 
            // bAddConstellation
            // 
            this.bAddConstellation.Location = new System.Drawing.Point(5, 24);
            this.bAddConstellation.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bAddConstellation.Name = "bAddConstellation";
            this.bAddConstellation.Size = new System.Drawing.Size(220, 29);
            this.bAddConstellation.TabIndex = 0;
            this.bAddConstellation.Text = "Создать созвездие";
            this.bAddConstellation.UseVisualStyleBackColor = true;
            this.bAddConstellation.Click += new System.EventHandler(this.bAddConstellation_Click);
            // 
            // bAddStar
            // 
            this.bAddStar.Location = new System.Drawing.Point(5, 59);
            this.bAddStar.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bAddStar.Name = "bAddStar";
            this.bAddStar.Size = new System.Drawing.Size(220, 29);
            this.bAddStar.TabIndex = 1;
            this.bAddStar.Text = "Создать звезду";
            this.bAddStar.UseVisualStyleBackColor = true;
            this.bAddStar.Click += new System.EventHandler(this.bAddStar_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(5, 94);
            this.bSave.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(220, 29);
            this.bSave.TabIndex = 12;
            this.bSave.Text = "Сохранить все изменения";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // pBoxRightPanel
            // 
            this.pBoxRightPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBoxRightPanel.Location = new System.Drawing.Point(0, 98);
            this.pBoxRightPanel.Name = "pBoxRightPanel";
            this.pBoxRightPanel.Size = new System.Drawing.Size(230, 333);
            this.pBoxRightPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxRightPanel.TabIndex = 9;
            this.pBoxRightPanel.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numLatitudeSeconds);
            this.panel1.Controls.Add(this.numLatitudeMinutes);
            this.panel1.Controls.Add(this.numLatitudeDegree);
            this.panel1.Controls.Add(this.dTPickerCurrDateTime);
            this.panel1.Controls.Add(this.numLongtitudeSeconds);
            this.panel1.Controls.Add(this.numLongtitudeMinutes);
            this.panel1.Controls.Add(this.numLongtitudeDegree);
            this.panel1.Controls.Add(this.lblLatitude);
            this.panel1.Controls.Add(this.lblLongitude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 98);
            this.panel1.TabIndex = 0;
            // 
            // numLatitudeSeconds
            // 
            this.numLatitudeSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numLatitudeSeconds.Location = new System.Drawing.Point(173, 30);
            this.numLatitudeSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLatitudeSeconds.Name = "numLatitudeSeconds";
            this.numLatitudeSeconds.Size = new System.Drawing.Size(44, 20);
            this.numLatitudeSeconds.TabIndex = 5;
            this.numLatitudeSeconds.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numLatitudeSeconds.ValueChanged += new System.EventHandler(this.numLongtitudeDegree_ValueChanged);
            // 
            // numLatitudeMinutes
            // 
            this.numLatitudeMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numLatitudeMinutes.Location = new System.Drawing.Point(123, 30);
            this.numLatitudeMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLatitudeMinutes.Name = "numLatitudeMinutes";
            this.numLatitudeMinutes.Size = new System.Drawing.Size(44, 20);
            this.numLatitudeMinutes.TabIndex = 4;
            this.numLatitudeMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLatitudeMinutes.ValueChanged += new System.EventHandler(this.numLongtitudeDegree_ValueChanged);
            // 
            // numLatitudeDegree
            // 
            this.numLatitudeDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numLatitudeDegree.Location = new System.Drawing.Point(73, 30);
            this.numLatitudeDegree.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numLatitudeDegree.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numLatitudeDegree.Name = "numLatitudeDegree";
            this.numLatitudeDegree.Size = new System.Drawing.Size(44, 20);
            this.numLatitudeDegree.TabIndex = 3;
            this.numLatitudeDegree.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLatitudeDegree.ValueChanged += new System.EventHandler(this.numLongtitudeDegree_ValueChanged);
            // 
            // dTPickerCurrDateTime
            // 
            this.dTPickerCurrDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dTPickerCurrDateTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dTPickerCurrDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerCurrDateTime.Location = new System.Drawing.Point(8, 63);
            this.dTPickerCurrDateTime.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dTPickerCurrDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dTPickerCurrDateTime.Name = "dTPickerCurrDateTime";
            this.dTPickerCurrDateTime.Size = new System.Drawing.Size(209, 20);
            this.dTPickerCurrDateTime.TabIndex = 6;
            this.dTPickerCurrDateTime.ValueChanged += new System.EventHandler(this.dTPickerCurrDateTime_ValueChanged);
            // 
            // numLongtitudeSeconds
            // 
            this.numLongtitudeSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numLongtitudeSeconds.Location = new System.Drawing.Point(173, 6);
            this.numLongtitudeSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLongtitudeSeconds.Name = "numLongtitudeSeconds";
            this.numLongtitudeSeconds.Size = new System.Drawing.Size(44, 20);
            this.numLongtitudeSeconds.TabIndex = 2;
            this.numLongtitudeSeconds.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numLongtitudeSeconds.ValueChanged += new System.EventHandler(this.numLongtitudeDegree_ValueChanged);
            // 
            // numLongtitudeMinutes
            // 
            this.numLongtitudeMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numLongtitudeMinutes.Location = new System.Drawing.Point(123, 6);
            this.numLongtitudeMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLongtitudeMinutes.Name = "numLongtitudeMinutes";
            this.numLongtitudeMinutes.Size = new System.Drawing.Size(44, 20);
            this.numLongtitudeMinutes.TabIndex = 1;
            this.numLongtitudeMinutes.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numLongtitudeMinutes.ValueChanged += new System.EventHandler(this.numLongtitudeDegree_ValueChanged);
            // 
            // numLongtitudeDegree
            // 
            this.numLongtitudeDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numLongtitudeDegree.Location = new System.Drawing.Point(73, 6);
            this.numLongtitudeDegree.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numLongtitudeDegree.Name = "numLongtitudeDegree";
            this.numLongtitudeDegree.Size = new System.Drawing.Size(44, 20);
            this.numLongtitudeDegree.TabIndex = 0;
            this.numLongtitudeDegree.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numLongtitudeDegree.ValueChanged += new System.EventHandler(this.numLongtitudeDegree_ValueChanged);
            // 
            // lblLatitude
            // 
            this.lblLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(5, 33);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(51, 13);
            this.lblLatitude.TabIndex = 7;
            this.lblLatitude.Text = "Широта :";
            // 
            // lblLongitude
            // 
            this.lblLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(5, 8);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(56, 13);
            this.lblLongitude.TabIndex = 6;
            this.lblLongitude.Text = "Долгота :";
            // 
            // pSearch
            // 
            this.pSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSearch.Controls.Add(this.pFindFrom);
            this.pSearch.Controls.Add(this.pFilters);
            this.pSearch.Controls.Add(this.pSortedBy);
            this.pSearch.Controls.Add(this.bSearch);
            this.pSearch.Controls.Add(this.tBoxSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(886, 52);
            this.pSearch.TabIndex = 0;
            // 
            // pFindFrom
            // 
            this.pFindFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFindFrom.Controls.Add(this.rBOnlyStars);
            this.pFindFrom.Controls.Add(this.rBOnlyConstellations);
            this.pFindFrom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFindFrom.Location = new System.Drawing.Point(366, 0);
            this.pFindFrom.Name = "pFindFrom";
            this.pFindFrom.Size = new System.Drawing.Size(180, 50);
            this.pFindFrom.TabIndex = 8;
            // 
            // rBOnlyStars
            // 
            this.rBOnlyStars.AutoSize = true;
            this.rBOnlyStars.Location = new System.Drawing.Point(108, 17);
            this.rBOnlyStars.Name = "rBOnlyStars";
            this.rBOnlyStars.Size = new System.Drawing.Size(64, 17);
            this.rBOnlyStars.TabIndex = 1;
            this.rBOnlyStars.Text = "Звёзды";
            this.rBOnlyStars.UseVisualStyleBackColor = true;
            // 
            // rBOnlyConstellations
            // 
            this.rBOnlyConstellations.AutoSize = true;
            this.rBOnlyConstellations.Checked = true;
            this.rBOnlyConstellations.Location = new System.Drawing.Point(12, 16);
            this.rBOnlyConstellations.Name = "rBOnlyConstellations";
            this.rBOnlyConstellations.Size = new System.Drawing.Size(80, 17);
            this.rBOnlyConstellations.TabIndex = 0;
            this.rBOnlyConstellations.TabStop = true;
            this.rBOnlyConstellations.Text = "Созвездия";
            this.rBOnlyConstellations.UseVisualStyleBackColor = true;
            // 
            // pFilters
            // 
            this.pFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFilters.Controls.Add(this.chBoxOnlyVisible);
            this.pFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFilters.Location = new System.Drawing.Point(546, 0);
            this.pFilters.Name = "pFilters";
            this.pFilters.Size = new System.Drawing.Size(130, 50);
            this.pFilters.TabIndex = 7;
            // 
            // chBoxOnlyVisible
            // 
            this.chBoxOnlyVisible.AutoSize = true;
            this.chBoxOnlyVisible.Location = new System.Drawing.Point(12, 17);
            this.chBoxOnlyVisible.Name = "chBoxOnlyVisible";
            this.chBoxOnlyVisible.Size = new System.Drawing.Size(112, 17);
            this.chBoxOnlyVisible.TabIndex = 0;
            this.chBoxOnlyVisible.Text = "Только видимые";
            this.chBoxOnlyVisible.UseVisualStyleBackColor = true;
            // 
            // pSortedBy
            // 
            this.pSortedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pSortedBy.Controls.Add(this.lblSortedBy);
            this.pSortedBy.Controls.Add(this.cBoxSortedBy);
            this.pSortedBy.Dock = System.Windows.Forms.DockStyle.Right;
            this.pSortedBy.Location = new System.Drawing.Point(676, 0);
            this.pSortedBy.Name = "pSortedBy";
            this.pSortedBy.Size = new System.Drawing.Size(208, 50);
            this.pSortedBy.TabIndex = 6;
            // 
            // lblSortedBy
            // 
            this.lblSortedBy.AutoSize = true;
            this.lblSortedBy.Location = new System.Drawing.Point(3, 18);
            this.lblSortedBy.Name = "lblSortedBy";
            this.lblSortedBy.Size = new System.Drawing.Size(67, 13);
            this.lblSortedBy.TabIndex = 5;
            this.lblSortedBy.Text = "Сортировка";
            // 
            // cBoxSortedBy
            // 
            this.cBoxSortedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSortedBy.FormattingEnabled = true;
            this.cBoxSortedBy.Location = new System.Drawing.Point(76, 14);
            this.cBoxSortedBy.Name = "cBoxSortedBy";
            this.cBoxSortedBy.Size = new System.Drawing.Size(121, 21);
            this.cBoxSortedBy.TabIndex = 0;
            // 
            // bSearch
            // 
            this.bSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSearch.Location = new System.Drawing.Point(262, 9);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(92, 30);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Искать";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.AccessibleDescription = "";
            this.tBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxSearch.Location = new System.Drawing.Point(11, 12);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(246, 26);
            this.tBoxSearch.TabIndex = 0;
            this.tTip.SetToolTip(this.tBoxSearch, "Оставьте пустым для отображения всех(отфильтрованых) звёзд или созвездий.");
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pMain.Controls.Add(this.lblTitle);
            this.pMain.Controls.Add(this.lBoxSky);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 52);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(886, 517);
            this.pMain.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Созвездия :";
            // 
            // lBoxSky
            // 
            this.lBoxSky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lBoxSky.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBoxSky.FormattingEnabled = true;
            this.lBoxSky.ItemHeight = 24;
            this.lBoxSky.Location = new System.Drawing.Point(0, 45);
            this.lBoxSky.Name = "lBoxSky";
            this.lBoxSky.Size = new System.Drawing.Size(886, 484);
            this.lBoxSky.TabIndex = 0;
            this.lBoxSky.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxSky_MouseDoubleClick);
            this.lBoxSky.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lBoxSky_PreviewKeyDown);
            // 
            // tTip
            // 
            this.tTip.IsBalloon = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 569);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pSearch);
            this.Controls.Add(this.pNav);
            this.MinimumSize = new System.Drawing.Size(1132, 608);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomer`s Handbook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.pNav.ResumeLayout(false);
            this.flowLPWay.ResumeLayout(false);
            this.flowLPWay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRightPanel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitudeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitudeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitudeDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongtitudeSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongtitudeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongtitudeDegree)).EndInit();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.pFindFrom.ResumeLayout(false);
            this.pFindFrom.PerformLayout();
            this.pFilters.ResumeLayout(false);
            this.pFilters.PerformLayout();
            this.pSortedBy.ResumeLayout(false);
            this.pSortedBy.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNav;
        private System.Windows.Forms.Panel pSearch;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.DateTimePicker dTPickerCurrDateTime;
        private System.Windows.Forms.ListBox lBoxSky;
        private System.Windows.Forms.NumericUpDown numLongtitudeSeconds;
        private System.Windows.Forms.NumericUpDown numLongtitudeMinutes;
        private System.Windows.Forms.NumericUpDown numLongtitudeDegree;
        private System.Windows.Forms.NumericUpDown numLatitudeSeconds;
        private System.Windows.Forms.NumericUpDown numLatitudeMinutes;
        private System.Windows.Forms.NumericUpDown numLatitudeDegree;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button bAddStar;
        private System.Windows.Forms.Button bAddConstellation;
        private System.Windows.Forms.PictureBox pBoxRightPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLPWay;
        private System.Windows.Forms.Label lblTitleEdit;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.Panel pFindFrom;
        private System.Windows.Forms.RadioButton rBOnlyStars;
        private System.Windows.Forms.RadioButton rBOnlyConstellations;
        private System.Windows.Forms.Panel pFilters;
        private System.Windows.Forms.CheckBox chBoxOnlyVisible;
        private System.Windows.Forms.Panel pSortedBy;
        private System.Windows.Forms.Label lblSortedBy;
        private System.Windows.Forms.ComboBox cBoxSortedBy;
        private System.Windows.Forms.Button bSave;
    }
}

