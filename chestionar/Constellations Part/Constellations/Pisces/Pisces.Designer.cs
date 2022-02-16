namespace chestionar
{
    partial class Pisces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pisces));
            this.PiscesText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.M74 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PiscesPicture = new System.Windows.Forms.PictureBox();
            this.PiscesArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiscesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiscesArt)).BeginInit();
            this.SuspendLayout();
            // 
            // PiscesText
            // 
            this.PiscesText.BackColor = System.Drawing.Color.Black;
            this.PiscesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PiscesText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiscesText.ForeColor = System.Drawing.Color.White;
            this.PiscesText.Location = new System.Drawing.Point(30, 0);
            this.PiscesText.Name = "PiscesText";
            this.PiscesText.Size = new System.Drawing.Size(804, 961);
            this.PiscesText.TabIndex = 0;
            this.PiscesText.Text = resources.GetString("PiscesText.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // M74
            // 
            this.M74.AutoSize = true;
            this.M74.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M74.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.M74.Location = new System.Drawing.Point(230, 325);
            this.M74.Name = "M74";
            this.M74.Size = new System.Drawing.Size(115, 27);
            this.M74.TabIndex = 4;
            this.M74.Text = "Messier 74";
            this.M74.Click += new System.EventHandler(this.M74_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::chestionar.Properties.Resources.Pisces;
            this.pictureBox1.Location = new System.Drawing.Point(216, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 232);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PiscesPicture
            // 
            this.PiscesPicture.BackgroundImage = global::chestionar.Properties.Resources.PiscesCC;
            this.PiscesPicture.Location = new System.Drawing.Point(522, 37);
            this.PiscesPicture.Name = "PiscesPicture";
            this.PiscesPicture.Size = new System.Drawing.Size(300, 402);
            this.PiscesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PiscesPicture.TabIndex = 3;
            this.PiscesPicture.TabStop = false;
            // 
            // PiscesArt
            // 
            this.PiscesArt.BackgroundImage = global::chestionar.Properties.Resources.PiscesArt;
            this.PiscesArt.Location = new System.Drawing.Point(167, 599);
            this.PiscesArt.Name = "PiscesArt";
            this.PiscesArt.Size = new System.Drawing.Size(500, 350);
            this.PiscesArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PiscesArt.TabIndex = 2;
            this.PiscesArt.TabStop = false;
            // 
            // Pisces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(834, 961);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.M74);
            this.Controls.Add(this.PiscesPicture);
            this.Controls.Add(this.PiscesArt);
            this.Controls.Add(this.PiscesText);
            this.Name = "Pisces";
            this.Text = "Pisces";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiscesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiscesArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PiscesText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox PiscesArt;
        private System.Windows.Forms.PictureBox PiscesPicture;
        private System.Windows.Forms.Label M74;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}