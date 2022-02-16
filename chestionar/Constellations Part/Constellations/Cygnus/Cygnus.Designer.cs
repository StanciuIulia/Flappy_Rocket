namespace chestionar
{
    partial class Cygnus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cygnus));
            this.CygnusText = new System.Windows.Forms.RichTextBox();
            this.M29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.M39 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CygnusText
            // 
            this.CygnusText.BackColor = System.Drawing.Color.Black;
            this.CygnusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CygnusText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CygnusText.ForeColor = System.Drawing.Color.White;
            this.CygnusText.Location = new System.Drawing.Point(18, 0);
            this.CygnusText.Name = "CygnusText";
            this.CygnusText.Size = new System.Drawing.Size(804, 984);
            this.CygnusText.TabIndex = 0;
            this.CygnusText.Text = resources.GetString("CygnusText.Text");
            // 
            // M29
            // 
            this.M29.AutoSize = true;
            this.M29.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M29.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M29.Location = new System.Drawing.Point(355, 351);
            this.M29.Name = "M29";
            this.M29.Size = new System.Drawing.Size(115, 27);
            this.M29.TabIndex = 1;
            this.M29.Text = "Messier 29";
            this.M29.Click += new System.EventHandler(this.M29_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // M39
            // 
            this.M39.AutoSize = true;
            this.M39.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M39.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M39.Location = new System.Drawing.Point(216, 380);
            this.M39.Name = "M39";
            this.M39.Size = new System.Drawing.Size(115, 27);
            this.M39.TabIndex = 3;
            this.M39.Text = "Messier 39";
            this.M39.Click += new System.EventHandler(this.M39_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::chestionar.Properties.Resources.Cygnus;
            this.pictureBox3.Location = new System.Drawing.Point(540, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(244, 211);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::chestionar.Properties.Resources.CygnusArt;
            this.pictureBox2.Location = new System.Drawing.Point(491, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 250);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.CygnusCC1;
            this.pictureBox1.Location = new System.Drawing.Point(242, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 220);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Cygnus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.M39);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.M29);
            this.Controls.Add(this.CygnusText);
            this.Name = "Cygnus";
            this.Text = "Cygnus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CygnusText;
        private System.Windows.Forms.Label M29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label M39;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}