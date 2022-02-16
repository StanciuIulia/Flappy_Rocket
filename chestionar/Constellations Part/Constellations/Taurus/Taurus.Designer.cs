namespace chestionar
{
    partial class Taurus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taurus));
            this.TaurusText = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.M1 = new System.Windows.Forms.Label();
            this.M45 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TaurusText
            // 
            this.TaurusText.BackColor = System.Drawing.Color.Black;
            this.TaurusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaurusText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaurusText.ForeColor = System.Drawing.Color.White;
            this.TaurusText.Location = new System.Drawing.Point(30, 0);
            this.TaurusText.Name = "TaurusText";
            this.TaurusText.Size = new System.Drawing.Size(804, 960);
            this.TaurusText.TabIndex = 0;
            this.TaurusText.Text = resources.GetString("TaurusText.Text");
            this.TaurusText.TextChanged += new System.EventHandler(this.TaurusText_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::chestionar.Properties.Resources.Taurus;
            this.pictureBox3.Location = new System.Drawing.Point(288, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(201, 193);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::chestionar.Properties.Resources.TaurusCC;
            this.pictureBox2.Location = new System.Drawing.Point(521, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 282);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.TaurusArt;
            this.pictureBox1.Location = new System.Drawing.Point(521, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 211);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M1.Location = new System.Drawing.Point(412, 352);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(103, 27);
            this.M1.TabIndex = 4;
            this.M1.Text = "Messier 1";
            this.M1.Click += new System.EventHandler(this.M1_Click);
            // 
            // M45
            // 
            this.M45.AutoSize = true;
            this.M45.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M45.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M45.Location = new System.Drawing.Point(374, 379);
            this.M45.Name = "M45";
            this.M45.Size = new System.Drawing.Size(115, 27);
            this.M45.TabIndex = 5;
            this.M45.Text = "Messier 45";
            this.M45.Click += new System.EventHandler(this.M45_Click);
            // 
            // Taurus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.M45);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TaurusText);
            this.Name = "Taurus";
            this.Text = "Taurus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TaurusText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label M1;
        private System.Windows.Forms.Label M45;
    }
}