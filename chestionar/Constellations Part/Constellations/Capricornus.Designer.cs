namespace chestionar
{
    partial class Capricornus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capricornus));
            this.CapricornusText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CapricornusText
            // 
            this.CapricornusText.BackColor = System.Drawing.Color.Black;
            this.CapricornusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CapricornusText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapricornusText.ForeColor = System.Drawing.Color.White;
            this.CapricornusText.Location = new System.Drawing.Point(30, 0);
            this.CapricornusText.Name = "CapricornusText";
            this.CapricornusText.Size = new System.Drawing.Size(804, 976);
            this.CapricornusText.TabIndex = 0;
            this.CapricornusText.Text = resources.GetString("CapricornusText.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.CapricornusCC;
            this.pictureBox1.Location = new System.Drawing.Point(487, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 185);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Capricornus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CapricornusText);
            this.Name = "Capricornus";
            this.Text = "Capricornus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CapricornusText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}