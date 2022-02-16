namespace chestionar
{
    partial class Gemini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gemini));
            this.GeminiText = new System.Windows.Forms.RichTextBox();
            this.M35 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GeminiArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeminiArt)).BeginInit();
            this.SuspendLayout();
            // 
            // GeminiText
            // 
            this.GeminiText.BackColor = System.Drawing.Color.Black;
            this.GeminiText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeminiText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeminiText.ForeColor = System.Drawing.Color.White;
            this.GeminiText.Location = new System.Drawing.Point(30, 0);
            this.GeminiText.Name = "GeminiText";
            this.GeminiText.Size = new System.Drawing.Size(804, 960);
            this.GeminiText.TabIndex = 0;
            this.GeminiText.Text = resources.GetString("GeminiText.Text");
            // 
            // M35
            // 
            this.M35.AutoSize = true;
            this.M35.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M35.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M35.Location = new System.Drawing.Point(225, 325);
            this.M35.Name = "M35";
            this.M35.Size = new System.Drawing.Size(115, 27);
            this.M35.TabIndex = 4;
            this.M35.Text = "Messier 35";
            this.M35.Click += new System.EventHandler(this.M35_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::chestionar.Properties.Resources.GeminiCC;
            this.pictureBox2.Location = new System.Drawing.Point(434, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 282);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.Gemini;
            this.pictureBox1.Location = new System.Drawing.Point(240, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 237);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GeminiArt
            // 
            this.GeminiArt.BackgroundImage = global::chestionar.Properties.Resources.GeminiArt;
            this.GeminiArt.Location = new System.Drawing.Point(167, 599);
            this.GeminiArt.Name = "GeminiArt";
            this.GeminiArt.Size = new System.Drawing.Size(500, 350);
            this.GeminiArt.TabIndex = 1;
            this.GeminiArt.TabStop = false;
            // 
            // Gemini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.M35);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GeminiArt);
            this.Controls.Add(this.GeminiText);
            this.Name = "Gemini";
            this.Text = "Gemini";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeminiArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox GeminiText;
        private System.Windows.Forms.PictureBox GeminiArt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label M35;
    }
}