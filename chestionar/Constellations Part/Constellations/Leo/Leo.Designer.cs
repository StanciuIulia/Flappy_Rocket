namespace chestionar
{
    partial class Leo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leo));
            this.LeoText = new System.Windows.Forms.RichTextBox();
            this.Mleo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeoText
            // 
            this.LeoText.BackColor = System.Drawing.Color.Black;
            this.LeoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeoText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeoText.ForeColor = System.Drawing.Color.White;
            this.LeoText.Location = new System.Drawing.Point(30, 0);
            this.LeoText.Name = "LeoText";
            this.LeoText.Size = new System.Drawing.Size(804, 978);
            this.LeoText.TabIndex = 0;
            this.LeoText.Text = resources.GetString("LeoText.Text");
            // 
            // Mleo
            // 
            this.Mleo.AutoSize = true;
            this.Mleo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mleo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Mleo.Location = new System.Drawing.Point(25, 324);
            this.Mleo.Name = "Mleo";
            this.Mleo.Size = new System.Drawing.Size(172, 27);
            this.Mleo.TabIndex = 1;
            this.Mleo.Text = "Messier Objects:";
            this.Mleo.Click += new System.EventHandler(this.Mleo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::chestionar.Properties.Resources.Leo;
            this.pictureBox3.Location = new System.Drawing.Point(265, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 213);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::chestionar.Properties.Resources.LeoArt;
            this.pictureBox2.Location = new System.Drawing.Point(510, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 351);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.LeoCC;
            this.pictureBox1.Location = new System.Drawing.Point(510, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 252);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Leo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mleo);
            this.Controls.Add(this.LeoText);
            this.Name = "Leo";
            this.Text = "Leo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LeoText;
        private System.Windows.Forms.Label Mleo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}