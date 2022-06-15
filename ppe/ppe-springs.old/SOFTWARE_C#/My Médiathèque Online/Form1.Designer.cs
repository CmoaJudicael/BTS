
namespace My_Médiathèque_Online
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texteCode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listNom = new System.Windows.Forms.ListBox();
            this.connText = new System.Windows.Forms.Label();
            this.testModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texteCode
            // 
            this.texteCode.AutoSize = true;
            this.texteCode.Location = new System.Drawing.Point(29, 346);
            this.texteCode.Name = "texteCode";
            this.texteCode.Size = new System.Drawing.Size(0, 15);
            this.texteCode.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listNom
            // 
            this.listNom.FormattingEnabled = true;
            this.listNom.HorizontalScrollbar = true;
            this.listNom.ItemHeight = 15;
            this.listNom.Location = new System.Drawing.Point(56, 64);
            this.listNom.Name = "listNom";
            this.listNom.Size = new System.Drawing.Size(982, 94);
            this.listNom.TabIndex = 2;
            // 
            // connText
            // 
            this.connText.AutoSize = true;
            this.connText.Location = new System.Drawing.Point(296, 186);
            this.connText.Name = "connText";
            this.connText.Size = new System.Drawing.Size(38, 15);
            this.connText.TabIndex = 3;
            this.connText.Text = "label1";
            // 
            // testModel
            // 
            this.testModel.Location = new System.Drawing.Point(544, 225);
            this.testModel.Name = "testModel";
            this.testModel.Size = new System.Drawing.Size(75, 23);
            this.testModel.TabIndex = 4;
            this.testModel.Text = "test Model";
            this.testModel.UseVisualStyleBackColor = true;
            this.testModel.Click += new System.EventHandler(this.testModel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.testModel);
            this.Controls.Add(this.connText);
            this.Controls.Add(this.listNom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texteCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texteCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listNom;
        private System.Windows.Forms.Label connText;
        private System.Windows.Forms.Button testModel;
    }
}

