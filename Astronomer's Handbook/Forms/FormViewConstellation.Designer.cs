namespace Astronomer_s_Handbook
{
    partial class FormViewConstellation
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
            this.bEdit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pBoxPhoto = new System.Windows.Forms.PictureBox();
            this.pLeft = new System.Windows.Forms.Panel();
            this.flowLPParams = new System.Windows.Forms.FlowLayoutPanel();
            this.fLPVisibility = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleVisibility = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.fLPSumarMagnitude = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitleSumarMgnitude = new System.Windows.Forms.Label();
            this.lblSumarMagnitude = new System.Windows.Forms.Label();
            this.pStars = new System.Windows.Forms.Panel();
            this.lBoxStars = new System.Windows.Forms.ListBox();
            this.lblTitleStars = new System.Windows.Forms.Label();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).BeginInit();
            this.flowLPParams.SuspendLayout();
            this.fLPVisibility.SuspendLayout();
            this.fLPSumarMagnitude.SuspendLayout();
            this.pStars.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHeader.Controls.Add(this.bEdit);
            this.pHeader.Controls.Add(this.lblName);
            this.pHeader.Controls.Add(this.pBoxPhoto);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(804, 199);
            this.pHeader.TabIndex = 0;
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bEdit.Location = new System.Drawing.Point(750, 12);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(40, 40);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(202, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Созвездие";
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
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 199);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(196, 392);
            this.pLeft.TabIndex = 1;
            // 
            // flowLPParams
            // 
            this.flowLPParams.Controls.Add(this.fLPVisibility);
            this.flowLPParams.Controls.Add(this.fLPSumarMagnitude);
            this.flowLPParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLPParams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLPParams.Location = new System.Drawing.Point(196, 199);
            this.flowLPParams.Name = "flowLPParams";
            this.flowLPParams.Size = new System.Drawing.Size(608, 85);
            this.flowLPParams.TabIndex = 2;
            // 
            // fLPVisibility
            // 
            this.fLPVisibility.Controls.Add(this.lblTitleVisibility);
            this.fLPVisibility.Controls.Add(this.lblVisibility);
            this.fLPVisibility.Location = new System.Drawing.Point(3, 3);
            this.fLPVisibility.Name = "fLPVisibility";
            this.fLPVisibility.Size = new System.Drawing.Size(593, 34);
            this.fLPVisibility.TabIndex = 0;
            // 
            // lblTitleVisibility
            // 
            this.lblTitleVisibility.AutoSize = true;
            this.lblTitleVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleVisibility.Location = new System.Drawing.Point(5, 5);
            this.lblTitleVisibility.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleVisibility.Name = "lblTitleVisibility";
            this.lblTitleVisibility.Size = new System.Drawing.Size(121, 24);
            this.lblTitleVisibility.TabIndex = 0;
            this.lblTitleVisibility.Text = "Видимость :";
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVisibility.Location = new System.Drawing.Point(136, 10);
            this.lblVisibility.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(172, 18);
            this.lblVisibility.TabIndex = 1;
            this.lblVisibility.Text = "В созвездии нет звёзд.";
            // 
            // fLPSumarMagnitude
            // 
            this.fLPSumarMagnitude.Controls.Add(this.lblTitleSumarMgnitude);
            this.fLPSumarMagnitude.Controls.Add(this.lblSumarMagnitude);
            this.fLPSumarMagnitude.Location = new System.Drawing.Point(3, 43);
            this.fLPSumarMagnitude.Name = "fLPSumarMagnitude";
            this.fLPSumarMagnitude.Size = new System.Drawing.Size(593, 34);
            this.fLPSumarMagnitude.TabIndex = 1;
            // 
            // lblTitleSumarMgnitude
            // 
            this.lblTitleSumarMgnitude.AutoSize = true;
            this.lblTitleSumarMgnitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleSumarMgnitude.Location = new System.Drawing.Point(5, 5);
            this.lblTitleSumarMgnitude.Margin = new System.Windows.Forms.Padding(5);
            this.lblTitleSumarMgnitude.Name = "lblTitleSumarMgnitude";
            this.lblTitleSumarMgnitude.Size = new System.Drawing.Size(180, 24);
            this.lblTitleSumarMgnitude.TabIndex = 2;
            this.lblTitleSumarMgnitude.Text = "Суммарный блеск :";
            // 
            // lblSumarMagnitude
            // 
            this.lblSumarMagnitude.AutoSize = true;
            this.lblSumarMagnitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumarMagnitude.Location = new System.Drawing.Point(195, 10);
            this.lblSumarMagnitude.Margin = new System.Windows.Forms.Padding(5, 10, 10, 10);
            this.lblSumarMagnitude.Name = "lblSumarMagnitude";
            this.lblSumarMagnitude.Size = new System.Drawing.Size(172, 18);
            this.lblSumarMagnitude.TabIndex = 3;
            this.lblSumarMagnitude.Text = "В созвездии нет звёзд.";
            // 
            // pStars
            // 
            this.pStars.Controls.Add(this.lBoxStars);
            this.pStars.Controls.Add(this.lblTitleStars);
            this.pStars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pStars.Location = new System.Drawing.Point(196, 284);
            this.pStars.Name = "pStars";
            this.pStars.Size = new System.Drawing.Size(608, 307);
            this.pStars.TabIndex = 3;
            // 
            // lBoxStars
            // 
            this.lBoxStars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBoxStars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lBoxStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBoxStars.FormattingEnabled = true;
            this.lBoxStars.ItemHeight = 18;
            this.lBoxStars.Location = new System.Drawing.Point(0, 55);
            this.lBoxStars.Name = "lBoxStars";
            this.lBoxStars.Size = new System.Drawing.Size(608, 252);
            this.lBoxStars.TabIndex = 2;
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
            // FormViewConstellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 591);
            this.Controls.Add(this.pStars);
            this.Controls.Add(this.flowLPParams);
            this.Controls.Add(this.pLeft);
            this.Controls.Add(this.pHeader);
            this.MinimumSize = new System.Drawing.Size(820, 630);
            this.Name = "FormViewConstellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Описание созвездия";
            this.TopMost = true;
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPhoto)).EndInit();
            this.flowLPParams.ResumeLayout(false);
            this.fLPVisibility.ResumeLayout(false);
            this.fLPVisibility.PerformLayout();
            this.fLPSumarMagnitude.ResumeLayout(false);
            this.fLPSumarMagnitude.PerformLayout();
            this.pStars.ResumeLayout(false);
            this.pStars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pBoxPhoto;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLPParams;
        private System.Windows.Forms.Panel pStars;
        private System.Windows.Forms.FlowLayoutPanel fLPVisibility;
        private System.Windows.Forms.Label lblTitleVisibility;
        private System.Windows.Forms.Label lblVisibility;
        private System.Windows.Forms.FlowLayoutPanel fLPSumarMagnitude;
        private System.Windows.Forms.Label lblTitleSumarMgnitude;
        private System.Windows.Forms.Label lblSumarMagnitude;
        private System.Windows.Forms.ListBox lBoxStars;
        private System.Windows.Forms.Label lblTitleStars;
    }
}