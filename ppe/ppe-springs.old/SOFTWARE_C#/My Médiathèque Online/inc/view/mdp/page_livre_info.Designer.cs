namespace My_Médiathèque_Online.inc.view.mdp
{
    partial class page_livre_info
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
            System.Windows.Forms.Label nomLbl_userRecord;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.layoutHeaderAccueil = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add_gestUsers = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.partageListBox_userRcord = new System.Windows.Forms.ListBox();
            this.nomTxtBox_userRcord = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            nomLbl_userRecord = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.layoutHeaderAccueil.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::My_Médiathèque_Online.Properties.Resources.deco1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1189, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::My_Médiathèque_Online.Properties.Resources.LogoMediatheque;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(68, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 79);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(449, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "MY MEDIATHEQUE ONLINE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutHeaderAccueil
            // 
            this.layoutHeaderAccueil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutHeaderAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.layoutHeaderAccueil.ColumnCount = 5;
            this.layoutHeaderAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.22351F));
            this.layoutHeaderAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.77649F));
            this.layoutHeaderAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 792F));
            this.layoutHeaderAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.layoutHeaderAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.layoutHeaderAccueil.Controls.Add(this.label2, 2, 0);
            this.layoutHeaderAccueil.Controls.Add(this.pictureBox1, 1, 0);
            this.layoutHeaderAccueil.Controls.Add(this.pictureBox2, 4, 0);
            this.layoutHeaderAccueil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.layoutHeaderAccueil.Location = new System.Drawing.Point(-1, 0);
            this.layoutHeaderAccueil.Name = "layoutHeaderAccueil";
            this.layoutHeaderAccueil.RowCount = 1;
            this.layoutHeaderAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutHeaderAccueil.Size = new System.Drawing.Size(1286, 89);
            this.layoutHeaderAccueil.TabIndex = 23;
            this.layoutHeaderAccueil.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutHeaderAccueil_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(-1, 624);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1286, 83);
            this.flowLayoutPanel2.TabIndex = 24;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // btn_add_gestUsers
            // 
            this.btn_add_gestUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.btn_add_gestUsers.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_gestUsers.ForeColor = System.Drawing.Color.White;
            this.btn_add_gestUsers.Location = new System.Drawing.Point(1118, 585);
            this.btn_add_gestUsers.Name = "btn_add_gestUsers";
            this.btn_add_gestUsers.Size = new System.Drawing.Size(104, 35);
            this.btn_add_gestUsers.TabIndex = 27;
            this.btn_add_gestUsers.Text = "RETOURN";
            this.btn_add_gestUsers.UseVisualStyleBackColor = false;
            this.btn_add_gestUsers.Click += new System.EventHandler(this.btn_add_gestUsers_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.AutoScroll = true;
            this.containerPanel.AutoScrollMinSize = new System.Drawing.Size(300, 200);
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(186)))));
            this.containerPanel.Controls.Add(label5);
            this.containerPanel.Controls.Add(this.textBox2);
            this.containerPanel.Controls.Add(label4);
            this.containerPanel.Controls.Add(this.textBox1);
            this.containerPanel.Controls.Add(label3);
            this.containerPanel.Controls.Add(this.nomTxtBox_userRcord);
            this.containerPanel.Controls.Add(nomLbl_userRecord);
            this.containerPanel.Controls.Add(this.partageListBox_userRcord);
            this.containerPanel.Location = new System.Drawing.Point(31, 184);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.containerPanel.Size = new System.Drawing.Size(1210, 400);
            this.containerPanel.TabIndex = 26;
            this.containerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.containerPanel_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(69, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 68);
            this.label1.TabIndex = 25;
            this.label1.Text = "INFORMATION LIVRE ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // partageListBox_userRcord
            // 
            this.partageListBox_userRcord.FormattingEnabled = true;
            this.partageListBox_userRcord.ItemHeight = 15;
            this.partageListBox_userRcord.Location = new System.Drawing.Point(576, 70);
            this.partageListBox_userRcord.Name = "partageListBox_userRcord";
            this.partageListBox_userRcord.Size = new System.Drawing.Size(361, 259);
            this.partageListBox_userRcord.TabIndex = 26;
            this.partageListBox_userRcord.SelectedIndexChanged += new System.EventHandler(this.partageListBox_userRcord_SelectedIndexChanged);
            // 
            // nomLbl_userRecord
            // 
            nomLbl_userRecord.AutoSize = true;
            nomLbl_userRecord.Location = new System.Drawing.Point(74, 51);
            nomLbl_userRecord.Name = "nomLbl_userRecord";
            nomLbl_userRecord.Size = new System.Drawing.Size(62, 15);
            nomLbl_userRecord.TabIndex = 27;
            nomLbl_userRecord.Text = "Nom Livre";
            nomLbl_userRecord.Click += new System.EventHandler(this.nomLbl_userRecord_Click);
            // 
            // nomTxtBox_userRcord
            // 
            this.nomTxtBox_userRcord.Location = new System.Drawing.Point(50, 70);
            this.nomTxtBox_userRcord.Name = "nomTxtBox_userRcord";
            this.nomTxtBox_userRcord.Size = new System.Drawing.Size(150, 23);
            this.nomTxtBox_userRcord.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(97, 109);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 29;
            label3.Text = "ISBN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 23);
            this.textBox1.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(97, 177);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(39, 15);
            label4.TabIndex = 31;
            label4.Text = "Status";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 23);
            this.textBox2.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(576, 37);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(67, 15);
            label5.TabIndex = 33;
            label5.Text = "Description";
            // 
            // page_livre_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 707);
            this.Controls.Add(this.btn_add_gestUsers);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.layoutHeaderAccueil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "page_livre_info";
            this.Text = "page_livre_info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.layoutHeaderAccueil.ResumeLayout(false);
            this.layoutHeaderAccueil.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel layoutHeaderAccueil;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btn_add_gestUsers;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox partageListBox_userRcord;
        private System.Windows.Forms.TextBox nomTxtBox_userRcord;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}