namespace chestionar
{
    partial class Aquarius
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aquarius));
            this.AquariusText = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M2 = new System.Windows.Forms.Label();
            this.M72 = new System.Windows.Forms.Label();
            this.M73 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AquariusText
            // 
            this.AquariusText.BackColor = System.Drawing.Color.Black;
            this.AquariusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AquariusText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AquariusText.ForeColor = System.Drawing.Color.White;
            this.AquariusText.Location = new System.Drawing.Point(30, 0);
            this.AquariusText.Name = "AquariusText";
            this.AquariusText.Size = new System.Drawing.Size(804, 985);
            this.AquariusText.TabIndex = 0;
            this.AquariusText.Text = resources.GetString("AquariusText.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::chestionar.Properties.Resources.AquariusCC;
            this.pictureBox2.Location = new System.Drawing.Point(496, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 198);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.AquariusArt;
            this.pictureBox1.Location = new System.Drawing.Point(445, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 245);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M2.Location = new System.Drawing.Point(248, 379);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(103, 27);
            this.M2.TabIndex = 3;
            this.M2.Text = "Messier 2";
            this.M2.Click += new System.EventHandler(this.M2_Click);
            // 
            // M72
            // 
            this.M72.AutoSize = true;
            this.M72.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M72.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M72.Location = new System.Drawing.Point(248, 406);
            this.M72.Name = "M72";
            this.M72.Size = new System.Drawing.Size(115, 27);
            this.M72.TabIndex = 4;
            this.M72.Text = "Messier 72";
            this.M72.Click += new System.EventHandler(this.M72_Click);
            // 
            // M73
            // 
            this.M73.AutoSize = true;
            this.M73.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M73.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M73.Location = new System.Drawing.Point(248, 433);
            this.M73.Name = "M73";
            this.M73.Size = new System.Drawing.Size(115, 27);
            this.M73.TabIndex = 5;
            this.M73.Text = "Messier 73";
            this.M73.Click += new System.EventHandler(this.M73_Click);
            // 
            // Aquarius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.M73);
            this.Controls.Add(this.M72);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AquariusText);
            this.Name = "Aquarius";
            this.Text = "Aquarius";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AquariusText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label M2;
        private System.Windows.Forms.Label M72;
        private System.Windows.Forms.Label M73;
    }
}