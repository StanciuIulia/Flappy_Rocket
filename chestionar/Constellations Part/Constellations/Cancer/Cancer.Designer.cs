namespace chestionar
{
    partial class Cancer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancer));
            this.CancerText = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M44 = new System.Windows.Forms.Label();
            this.M67 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancerText
            // 
            this.CancerText.BackColor = System.Drawing.Color.Black;
            this.CancerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CancerText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancerText.ForeColor = System.Drawing.Color.White;
            this.CancerText.Location = new System.Drawing.Point(30, 0);
            this.CancerText.Name = "CancerText";
            this.CancerText.Size = new System.Drawing.Size(804, 976);
            this.CancerText.TabIndex = 0;
            this.CancerText.Text = resources.GetString("CancerText.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::chestionar.Properties.Resources.CancerCC;
            this.pictureBox2.Location = new System.Drawing.Point(499, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 202);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.CancerArt1;
            this.pictureBox1.Location = new System.Drawing.Point(573, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 338);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // M44
            // 
            this.M44.AutoSize = true;
            this.M44.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M44.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M44.Location = new System.Drawing.Point(420, 380);
            this.M44.Name = "M44";
            this.M44.Size = new System.Drawing.Size(115, 27);
            this.M44.TabIndex = 3;
            this.M44.Text = "Messier 44";
            this.M44.Click += new System.EventHandler(this.M44_Click);
            // 
            // M67
            // 
            this.M67.AutoSize = true;
            this.M67.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M67.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M67.Location = new System.Drawing.Point(225, 405);
            this.M67.Name = "M67";
            this.M67.Size = new System.Drawing.Size(115, 27);
            this.M67.TabIndex = 4;
            this.M67.Text = "Messier 67";
            this.M67.Click += new System.EventHandler(this.M67_Click);
            // 
            // Cancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.M67);
            this.Controls.Add(this.M44);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancerText);
            this.Name = "Cancer";
            this.Text = "Cancer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CancerText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label M44;
        private System.Windows.Forms.Label M67;
    }
}