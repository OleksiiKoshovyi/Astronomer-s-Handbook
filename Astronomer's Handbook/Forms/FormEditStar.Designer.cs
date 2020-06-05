namespace Astronomer_s_Handbook
{
    partial class FormEditStar
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
            this.pHeader = new System.Windows.Forms.Panel();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pBoxPhoto = new System.Windows.Forms.PictureBox();
            this.pLeft = new System.Windows.Forms.Panel();
            this.bDel = new System.Windows.Forms.Button();
            this.flowLPParams = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPConstellation = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleConstellation = new System.Windows.Forms.Label();
            this.cBoxCons = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleDist = new System.Windows.Forms.Label();
            this.tBoxDist = new System.Windows.Forms.TextBox();
            this.cBoxUnit = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleMagn = new System.Windows.Forms.Label();
            this.tBoxMagn = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleRA = new System.Windows.Forms.Label();
            this.numRADegree = new System.Windows.Forms.NumericUpDown();
            this.numRAMinutes = new System.Windows.Forms.NumericUpDown();
            this.numRASeconds = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleDecl = new System.Windows.Forms.Label();
            this.numDeclDegree = new System.Windows.Forms.NumericUpDown();
            this.numDeclMinutes = new System.Windows.Forms.NumericUpDown();
            this.numDeclSeconds = new System.Windows.Forms.NumericUpDown();
            this.fLPVisibility = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleUrl = new System.Windows.Forms.Label();
            this.tBoxUrl = new System.Windows.Forms.TextBox();
            this.bCheck = new System.Windows.Forms.Button();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).BeginInit();
            this.pLeft.SuspendLayout();
            this.flowLPParams.SuspendLayout();
            this.fLPConstellation.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRADegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRAMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRASeconds)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclSeconds)).BeginInit();
            this.fLPVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHeader.Controls.Add(this.tBoxName);
            this.pHeader.Controls.Add(this.bSave);
            this.pHeader.Controls.Add(this.lblName);
            this.pHeader.Controls.Add(this.pBoxPhoto);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(840, 199);
            this.pHeader.TabIndex = 2;
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxName.Location = new System.Drawing.Point(362, 147);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(416, 44);
            this.tBoxName.TabIndex = 3;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.Location = new System.Drawing.Point(786, 12);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(40, 40);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(202, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(154, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название";
            // 
            // pBoxPhoto
            // 
            this.pBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxPhoto.Image = global::Astronomer_s_Handbook.Properties.Resources.star;
            this.pBoxPhoto.Location = new System.Drawing.Point(12, 12);
            this.pBoxPhoto.Name = "pBoxPhoto";
            this.pBoxPhoto.Size = new System.Drawing.Size(175, 175);
            this.pBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxPhoto.TabIndex = 0;
            this.pBoxPhoto.TabStop = false;
            // 
            // pLeft
            // 
            this.pLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLeft.Controls.Add(this.bDel);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 199);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(196, 252);
            this.pLeft.TabIndex = 3;
            // 
            // bDel
            // 
            this.bDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDel.Location = new System.Drawing.Point(12, 191);
            this.bDel.Margin = new System.Windows.Forms.Padding(5);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(175, 45);
            this.bDel.TabIndex = 3;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Visible = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // flowLPParams
            // 
            this.flowLPParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLPParams.Controls.Add(this.fLPConstellation);
            this.flowLPParams.Controls.Add(this.flowLayoutPanel1);
            this.flowLPParams.Controls.Add(this.flowLayoutPanel2);
            this.flowLPParams.Controls.Add(this.flowLayoutPanel5);
            this.flowLPParams.Controls.Add(this.flowLayoutPanel4);
            this.flowLPParams.Controls.Add(this.fLPVisibility);
            this.flowLPParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLPParams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLPParams.Location = new System.Drawing.Point(196, 199);
            this.flowLPParams.Name = "flowLPParams";
            this.flowLPParams.Size = new System.Drawing.Size(644, 252);
            this.flowLPParams.TabIndex = 7;
            // 
            // fLPConstellation
            // 
            this.fLPConstellation.Controls.Add(this.lblTitleConstellation);
            this.fLPConstellation.Controls.Add(this.cBoxCons);
            this.fLPConstellation.Location = new System.Drawing.Point(3, 3);
            this.fLPConstellation.Name = "fLPConstellation";
            this.fLPConstellation.Size = new System.Drawing.Size(593, 34);
            this.fLPConstellation.TabIndex = 1;
            // 
            // lblTitleConstellation
            // 
            this.lblTitleConstellation.AutoSize = true;
            this.lblTitleConstellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleConstellation.Location = new System.Drawing.Point(5, 5);
            this.lblTitleConstellation.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleConstellation.Name = "lblTitleConstellation";
            this.lblTitleConstellation.Size = new System.Drawing.Size(120, 24);
            this.lblTitleConstellation.TabIndex = 0;
            this.lblTitleConstellation.Text = "Созвездие :";
            // 
            // cBoxCons
            // 
            this.cBoxCons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxCons.FormattingEnabled = true;
            this.cBoxCons.Location = new System.Drawing.Point(135, 5);
            this.cBoxCons.Margin = new System.Windows.Forms.Padding(5);
            this.cBoxCons.Name = "cBoxCons";
            this.cBoxCons.Size = new System.Drawing.Size(444, 26);
            this.cBoxCons.TabIndex = 1;
            this.cBoxCons.SelectedIndexChanged += new System.EventHandler(this.cBoxCons_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTitleDist);
            this.flowLayoutPanel1.Controls.Add(this.tBoxDist);
            this.flowLayoutPanel1.Controls.Add(this.cBoxUnit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(593, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblTitleDist
            // 
            this.lblTitleDist.AutoSize = true;
            this.lblTitleDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleDist.Location = new System.Drawing.Point(5, 5);
            this.lblTitleDist.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleDist.Name = "lblTitleDist";
            this.lblTitleDist.Size = new System.Drawing.Size(126, 24);
            this.lblTitleDist.TabIndex = 0;
            this.lblTitleDist.Text = "Расстояние :";
            // 
            // tBoxDist
            // 
            this.tBoxDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxDist.Location = new System.Drawing.Point(141, 5);
            this.tBoxDist.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxDist.Name = "tBoxDist";
            this.tBoxDist.Size = new System.Drawing.Size(159, 24);
            this.tBoxDist.TabIndex = 2;
            this.tBoxDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDouble_KeyPress);
            // 
            // cBoxUnit
            // 
            this.cBoxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxUnit.FormattingEnabled = true;
            this.cBoxUnit.Location = new System.Drawing.Point(310, 5);
            this.cBoxUnit.Margin = new System.Windows.Forms.Padding(5);
            this.cBoxUnit.Name = "cBoxUnit";
            this.cBoxUnit.Size = new System.Drawing.Size(109, 26);
            this.cBoxUnit.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblTitleMagn);
            this.flowLayoutPanel2.Controls.Add(this.tBoxMagn);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(593, 34);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // lblTitleMagn
            // 
            this.lblTitleMagn.AutoSize = true;
            this.lblTitleMagn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleMagn.Location = new System.Drawing.Point(5, 5);
            this.lblTitleMagn.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleMagn.Name = "lblTitleMagn";
            this.lblTitleMagn.Size = new System.Drawing.Size(73, 24);
            this.lblTitleMagn.TabIndex = 0;
            this.lblTitleMagn.Text = "Блеск :";
            // 
            // tBoxMagn
            // 
            this.tBoxMagn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxMagn.Location = new System.Drawing.Point(88, 5);
            this.tBoxMagn.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxMagn.Name = "tBoxMagn";
            this.tBoxMagn.Size = new System.Drawing.Size(159, 24);
            this.tBoxMagn.TabIndex = 3;
            this.tBoxMagn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDouble_KeyPress);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.lblTitleRA);
            this.flowLayoutPanel5.Controls.Add(this.numRADegree);
            this.flowLayoutPanel5.Controls.Add(this.numRAMinutes);
            this.flowLayoutPanel5.Controls.Add(this.numRASeconds);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 123);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(593, 34);
            this.flowLayoutPanel5.TabIndex = 6;
            // 
            // lblTitleRA
            // 
            this.lblTitleRA.AutoSize = true;
            this.lblTitleRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleRA.Location = new System.Drawing.Point(5, 5);
            this.lblTitleRA.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleRA.Name = "lblTitleRA";
            this.lblTitleRA.Size = new System.Drawing.Size(217, 24);
            this.lblTitleRA.TabIndex = 0;
            this.lblTitleRA.Text = "Прямое восхождение :";
            // 
            // numRADegree
            // 
            this.numRADegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numRADegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numRADegree.Location = new System.Drawing.Point(230, 7);
            this.numRADegree.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numRADegree.Name = "numRADegree";
            this.numRADegree.Size = new System.Drawing.Size(44, 24);
            this.numRADegree.TabIndex = 6;
            // 
            // numRAMinutes
            // 
            this.numRAMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numRAMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numRAMinutes.Location = new System.Drawing.Point(280, 7);
            this.numRAMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numRAMinutes.Name = "numRAMinutes";
            this.numRAMinutes.Size = new System.Drawing.Size(44, 24);
            this.numRAMinutes.TabIndex = 7;
            // 
            // numRASeconds
            // 
            this.numRASeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numRASeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numRASeconds.Location = new System.Drawing.Point(330, 7);
            this.numRASeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numRASeconds.Name = "numRASeconds";
            this.numRASeconds.Size = new System.Drawing.Size(44, 24);
            this.numRASeconds.TabIndex = 8;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lblTitleDecl);
            this.flowLayoutPanel4.Controls.Add(this.numDeclDegree);
            this.flowLayoutPanel4.Controls.Add(this.numDeclMinutes);
            this.flowLayoutPanel4.Controls.Add(this.numDeclSeconds);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 163);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(593, 34);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // lblTitleDecl
            // 
            this.lblTitleDecl.AutoSize = true;
            this.lblTitleDecl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleDecl.Location = new System.Drawing.Point(5, 5);
            this.lblTitleDecl.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleDecl.Name = "lblTitleDecl";
            this.lblTitleDecl.Size = new System.Drawing.Size(218, 24);
            this.lblTitleDecl.TabIndex = 0;
            this.lblTitleDecl.Text = "Склонение :                    ";
            // 
            // numDeclDegree
            // 
            this.numDeclDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numDeclDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDeclDegree.Location = new System.Drawing.Point(231, 7);
            this.numDeclDegree.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numDeclDegree.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numDeclDegree.Name = "numDeclDegree";
            this.numDeclDegree.Size = new System.Drawing.Size(44, 24);
            this.numDeclDegree.TabIndex = 6;
            // 
            // numDeclMinutes
            // 
            this.numDeclMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numDeclMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDeclMinutes.Location = new System.Drawing.Point(281, 7);
            this.numDeclMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numDeclMinutes.Name = "numDeclMinutes";
            this.numDeclMinutes.Size = new System.Drawing.Size(44, 24);
            this.numDeclMinutes.TabIndex = 7;
            // 
            // numDeclSeconds
            // 
            this.numDeclSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numDeclSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numDeclSeconds.Location = new System.Drawing.Point(331, 7);
            this.numDeclSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numDeclSeconds.Name = "numDeclSeconds";
            this.numDeclSeconds.Size = new System.Drawing.Size(44, 24);
            this.numDeclSeconds.TabIndex = 8;
            // 
            // fLPVisibility
            // 
            this.fLPVisibility.Controls.Add(this.lblTitleUrl);
            this.fLPVisibility.Controls.Add(this.tBoxUrl);
            this.fLPVisibility.Controls.Add(this.bCheck);
            this.fLPVisibility.Location = new System.Drawing.Point(3, 203);
            this.fLPVisibility.Name = "fLPVisibility";
            this.fLPVisibility.Size = new System.Drawing.Size(593, 34);
            this.fLPVisibility.TabIndex = 7;
            // 
            // lblTitleUrl
            // 
            this.lblTitleUrl.AutoSize = true;
            this.lblTitleUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleUrl.Location = new System.Drawing.Point(5, 5);
            this.lblTitleUrl.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleUrl.Name = "lblTitleUrl";
            this.lblTitleUrl.Size = new System.Drawing.Size(94, 24);
            this.lblTitleUrl.TabIndex = 0;
            this.lblTitleUrl.Text = "Url фото :";
            // 
            // tBoxUrl
            // 
            this.tBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxUrl.Location = new System.Drawing.Point(109, 5);
            this.tBoxUrl.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxUrl.Name = "tBoxUrl";
            this.tBoxUrl.Size = new System.Drawing.Size(387, 24);
            this.tBoxUrl.TabIndex = 1;
            // 
            // bCheck
            // 
            this.bCheck.Location = new System.Drawing.Point(506, 5);
            this.bCheck.Margin = new System.Windows.Forms.Padding(5);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(75, 24);
            this.bCheck.TabIndex = 2;
            this.bCheck.Text = "Проверить";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // FormEditStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 451);
            this.Controls.Add(this.flowLPParams);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pHeader);
            this.MaximumSize = new System.Drawing.Size(856, 490);
            this.MinimumSize = new System.Drawing.Size(856, 490);
            this.Name = "FormEditStar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditStar";
            this.TopMost = true;
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).EndInit();
            this.pLeft.ResumeLayout(false);
            this.flowLPParams.ResumeLayout(false);
            this.fLPConstellation.ResumeLayout(false);
            this.fLPConstellation.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRADegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRAMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRASeconds)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeclSeconds)).EndInit();
            this.fLPVisibility.ResumeLayout(false);
            this.fLPVisibility.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pBoxPhoto;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.FlowLayoutPanel flowLPParams;
        private System.Windows.Forms.FlowLayoutPanel fLPConstellation;
        private System.Windows.Forms.Label lblTitleConstellation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTitleDist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblTitleMagn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label lblTitleDecl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label lblTitleRA;
        private System.Windows.Forms.ComboBox cBoxCons;
        private System.Windows.Forms.TextBox tBoxDist;
        private System.Windows.Forms.ComboBox cBoxUnit;
        private System.Windows.Forms.TextBox tBoxMagn;
        private System.Windows.Forms.FlowLayoutPanel fLPVisibility;
        private System.Windows.Forms.Label lblTitleUrl;
        private System.Windows.Forms.TextBox tBoxUrl;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.NumericUpDown numRADegree;
        private System.Windows.Forms.NumericUpDown numRAMinutes;
        private System.Windows.Forms.NumericUpDown numRASeconds;
        private System.Windows.Forms.NumericUpDown numDeclDegree;
        private System.Windows.Forms.NumericUpDown numDeclMinutes;
        private System.Windows.Forms.NumericUpDown numDeclSeconds;
    }
}