namespace chestionar
{
    partial class PlanetQuizSad
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonTryAgain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1, 431);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 50);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonTryAgain
            // 
            this.buttonTryAgain.BackColor = System.Drawing.Color.Transparent;
            this.buttonTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTryAgain.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTryAgain.ForeColor = System.Drawing.Color.White;
            this.buttonTryAgain.Location = new System.Drawing.Point(292, 431);
            this.buttonTryAgain.Name = "buttonTryAgain";
            this.buttonTryAgain.Size = new System.Drawing.Size(210, 50);
            this.buttonTryAgain.TabIndex = 1;
            this.buttonTryAgain.Text = "Try Again!";
            this.buttonTryAgain.UseVisualStyleBackColor = false;
            this.buttonTryAgain.Click += new System.EventHandler(this.ButtonTryAgain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your score: 100";
            // 
            // PlanetQuizSad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chestionar.Properties.Resources.Sad;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTryAgain);
            this.Controls.Add(this.buttonClose);
            this.Name = "PlanetQuizSad";
            this.Text = "PlanetQuizSad";
            this.Load += new System.EventHandler(this.PlanetQuizSad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonTryAgain;
        private System.Windows.Forms.Label label1;
    }
}