namespace Astronomer_s_Handbook
{
    partial class FormEditConstellation
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
            this.components = new System.ComponentModel.Container();
            this.pHeader = new System.Windows.Forms.Panel();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pBoxPhoto = new System.Windows.Forms.PictureBox();
            this.pLeft = new System.Windows.Forms.Panel();
            this.bDel = new System.Windows.Forms.Button();
            this.flowLPParams = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPVisibility = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleUrl = new System.Windows.Forms.Label();
            this.tBoxUrl = new System.Windows.Forms.TextBox();
            this.bCheck = new System.Windows.Forms.Button();
            this.pStars = new System.Windows.Forms.Panel();
            this.lBoxStars = new System.Windows.Forms.ListBox();
            this.lblTitleStars = new System.Windows.Forms.Label();
            this.contextMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolSM = new System.Windows.Forms.ToolStripMenuItem();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).BeginInit();
            this.pLeft.SuspendLayout();
            this.flowLPParams.SuspendLayout();
            this.fLPVisibility.SuspendLayout();
            this.pStars.SuspendLayout();
            this.contextMS.SuspendLayout();
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
            this.pHeader.Size = new System.Drawing.Size(804, 199);
            this.pHeader.TabIndex = 1;
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
            this.bSave.Location = new System.Drawing.Point(750, 12);
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
            this.pBoxPhoto.Image = global::Astronomer_s_Handbook.Properties.Resources.conses;
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
            this.pLeft.Size = new System.Drawing.Size(196, 356);
            this.pLeft.TabIndex = 2;
            // 
            // bDel
            // 
            this.bDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bDel.Location = new System.Drawing.Point(12, 295);
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
            this.flowLPParams.Controls.Add(this.fLPVisibility);
            this.flowLPParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLPParams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLPParams.Location = new System.Drawing.Point(196, 199);
            this.flowLPParams.Name = "flowLPParams";
            this.flowLPParams.Size = new System.Drawing.Size(608, 51);
            this.flowLPParams.TabIndex = 3;
            // 
            // fLPVisibility
            // 
            this.fLPVisibility.Controls.Add(this.lblTitleUrl);
            this.fLPVisibility.Controls.Add(this.tBoxUrl);
            this.fLPVisibility.Controls.Add(this.bCheck);
            this.fLPVisibility.Location = new System.Drawing.Point(3, 3);
            this.fLPVisibility.Name = "fLPVisibility";
            this.fLPVisibility.Size = new System.Drawing.Size(593, 34);
            this.fLPVisibility.TabIndex = 0;
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
            // pStars
            // 
            this.pStars.Controls.Add(this.lBoxStars);
            this.pStars.Controls.Add(this.lblTitleStars);
            this.pStars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStars.Location = new System.Drawing.Point(196, 250);
            this.pStars.Name = "pStars";
            this.pStars.Size = new System.Drawing.Size(608, 305);
            this.pStars.TabIndex = 4;
            // 
            // lBoxStars
            // 
            this.lBoxStars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxStars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lBoxStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBoxStars.FormattingEnabled = true;
            this.lBoxStars.ItemHeight = 18;
            this.lBoxStars.Location = new System.Drawing.Point(0, 53);
            this.lBoxStars.Name = "lBoxStars";
            this.lBoxStars.Size = new System.Drawing.Size(608, 252);
            this.lBoxStars.TabIndex = 2;
            this.lBoxStars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lBoxStars_MouseDown);
            // 
            // lblTitleStars
            // 
            this.lblTitleStars.AutoSize = true;
            this.lblTitleStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleStars.Location = new System.Drawing.Point(3, 12);
            this.lblTitleStars.Name = "lblTitleStars";
            this.lblTitleStars.Size = new System.Drawing.Size(80, 24);
            this.lblTitleStars.TabIndex = 1;
            this.lblTitleStars.Text = "Звёзды";
            // 
            // contextMS
            // 
            this.contextMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSM});
            this.contextMS.Name = "contextMS";
            this.contextMS.Size = new System.Drawing.Size(119, 26);
            // 
            // toolSM
            // 
            this.toolSM.Name = "toolSM";
            this.toolSM.Size = new System.Drawing.Size(118, 22);
            this.toolSM.Text = "Удалить";
            this.toolSM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolSM_MouseDown);
            // 
            // FormEditConstellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 555);
            this.Controls.Add(this.pStars);
            this.Controls.Add(this.flowLPParams);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pHeader);
            this.MaximumSize = new System.Drawing.Size(820, 594);
            this.MinimumSize = new System.Drawing.Size(820, 594);
            this.Name = "FormEditConstellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание созвездия";
            this.TopMost = true;
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).EndInit();
            this.pLeft.ResumeLayout(false);
            this.flowLPParams.ResumeLayout(false);
            this.fLPVisibility.ResumeLayout(false);
            this.fLPVisibility.PerformLayout();
            this.pStars.ResumeLayout(false);
            this.pStars.PerformLayout();
            this.contextMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pBoxPhoto;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLPParams;
        private System.Windows.Forms.FlowLayoutPanel fLPVisibility;
        private System.Windows.Forms.Label lblTitleUrl;
        private System.Windows.Forms.Panel pStars;
        private System.Windows.Forms.ListBox lBoxStars;
        private System.Windows.Forms.Label lblTitleStars;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxUrl;
        private System.Windows.Forms.ContextMenuStrip contextMS;
        private System.Windows.Forms.ToolStripMenuItem toolSM;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Button bDel;
    }
}