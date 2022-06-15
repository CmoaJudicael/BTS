namespace My_Médiathèque_Online.inc.view
{
    partial class page_gestion_livres
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
            this.layoutHeaderAccueil = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.nomAdministre = new System.Windows.Forms.Label();
            this.idAdministre0 = new System.Windows.Forms.Label();
            this.btn_add_gestUsers = new System.Windows.Forms.Button();
            this.layoutHeaderAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
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
            this.layoutHeaderAccueil.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.layoutHeaderAccueil.Controls.Add(this.label2, 2, 0);
            this.layoutHeaderAccueil.Controls.Add(this.pictureBox1, 1, 0);
            this.layoutHeaderAccueil.Controls.Add(this.pictureBox2, 4, 0);
            this.layoutHeaderAccueil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.layoutHeaderAccueil.Location = new System.Drawing.Point(0, 0);
            this.layoutHeaderAccueil.Name = "layoutHeaderAccueil";
            this.layoutHeaderAccueil.RowCount = 1;
            this.layoutHeaderAccueil.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutHeaderAccueil.Size = new System.Drawing.Size(1286, 89);
            this.layoutHeaderAccueil.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(450, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "MY MEDIATHEQUE ONLINE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::My_Médiathèque_Online.Properties.Resources.deco1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1190, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 624);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1286, 83);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(70, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 68);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTE DES LIVRES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // containerPanel
            // 
            this.containerPanel.AutoScroll = true;
            this.containerPanel.AutoScrollMinSize = new System.Drawing.Size(300, 200);
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(174)))), ((int)(((byte)(186)))));
            this.containerPanel.Controls.Add(this.panelUser);
            this.containerPanel.Location = new System.Drawing.Point(32, 184);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.containerPanel.Size = new System.Drawing.Size(1210, 400);
            this.containerPanel.TabIndex = 11;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.Gainsboro;
            this.panelUser.Controls.Add(this.nomAdministre);
            this.panelUser.Controls.Add(this.idAdministre0);
            this.panelUser.Location = new System.Drawing.Point(600, 294);
            this.panelUser.Margin = new System.Windows.Forms.Padding(5);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(140, 80);
            this.panelUser.TabIndex = 9;
            // 
            // nomAdministre
            // 
            this.nomAdministre.AutoSize = true;
            this.nomAdministre.Location = new System.Drawing.Point(3, 33);
            this.nomAdministre.Name = "nomAdministre";
            this.nomAdministre.Size = new System.Drawing.Size(57, 15);
            this.nomAdministre.TabIndex = 1;
            this.nomAdministre.Text = "nom livre";
            // 
            // idAdministre0
            // 
            this.idAdministre0.AutoSize = true;
            this.idAdministre0.Location = new System.Drawing.Point(3, 0);
            this.idAdministre0.Name = "idAdministre0";
            this.idAdministre0.Size = new System.Drawing.Size(54, 15);
            this.idAdministre0.TabIndex = 0;
            this.idAdministre0.Text = "isbn livre";
            // 
            // btn_add_gestUsers
            // 
            this.btn_add_gestUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.btn_add_gestUsers.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_gestUsers.ForeColor = System.Drawing.Color.White;
            this.btn_add_gestUsers.Location = new System.Drawing.Point(1119, 585);
            this.btn_add_gestUsers.Name = "btn_add_gestUsers";
            this.btn_add_gestUsers.Size = new System.Drawing.Size(104, 35);
            this.btn_add_gestUsers.TabIndex = 22;
            this.btn_add_gestUsers.Text = "RETOURNER";
            this.btn_add_gestUsers.UseVisualStyleBackColor = false;
            // 
            // page_gestion_livres
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
            this.Name = "page_gestion_livres";
            this.Text = "page_gestion_livres";
            this.layoutHeaderAccueil.ResumeLayout(false);
            this.layoutHeaderAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutHeaderAccueil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label nomAdministre;
        private System.Windows.Forms.Label idAdministre0;
        private System.Windows.Forms.Button btn_add_gestUsers;
    }
}