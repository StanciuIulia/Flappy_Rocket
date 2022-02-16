namespace chestionar
{
    partial class Pagina_Planete
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
            this.RoundButtonTeorie = new WindowsFormsApplication1.RoundButton();
            this.RoundButtonChestionar = new WindowsFormsApplication1.RoundButton();
            this.RoundButtonJoc = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // RoundButtonTeorie
            // 
            this.RoundButtonTeorie.BackColor = System.Drawing.Color.Black;
            this.RoundButtonTeorie.BackgroundImage = global::chestionar.Properties.Resources.buton1;
            this.RoundButtonTeorie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoundButtonTeorie.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundButtonTeorie.ForeColor = System.Drawing.Color.DarkBlue;
            this.RoundButtonTeorie.Location = new System.Drawing.Point(700, 50);
            this.RoundButtonTeorie.Name = "RoundButtonTeorie";
            this.RoundButtonTeorie.Size = new System.Drawing.Size(120, 120);
            this.RoundButtonTeorie.TabIndex = 0;
            this.RoundButtonTeorie.Text = "Learn more!";
            this.RoundButtonTeorie.UseVisualStyleBackColor = false;
            this.RoundButtonTeorie.Click += new System.EventHandler(this.buttonTeorie_Click);
            // 
            // RoundButtonChestionar
            // 
            this.RoundButtonChestionar.BackColor = System.Drawing.Color.Transparent;
            this.RoundButtonChestionar.BackgroundImage = global::chestionar.Properties.Resources.buton3;
            this.RoundButtonChestionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoundButtonChestionar.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundButtonChestionar.ForeColor = System.Drawing.Color.DarkBlue;
            this.RoundButtonChestionar.Location = new System.Drawing.Point(1400, 480);
            this.RoundButtonChestionar.Name = "RoundButtonChestionar";
            this.RoundButtonChestionar.Size = new System.Drawing.Size(160, 160);
            this.RoundButtonChestionar.TabIndex = 1;
            this.RoundButtonChestionar.Text = "Test your knowledge!";
            this.RoundButtonChestionar.UseVisualStyleBackColor = false;
            this.RoundButtonChestionar.Click += new System.EventHandler(this.RoundButtonChestionar_Click);
            // 
            // RoundButtonJoc
            // 
            this.RoundButtonJoc.BackColor = System.Drawing.Color.Black;
            this.RoundButtonJoc.BackgroundImage = global::chestionar.Properties.Resources.buton2;
            this.RoundButtonJoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoundButtonJoc.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundButtonJoc.ForeColor = System.Drawing.Color.DarkBlue;
            this.RoundButtonJoc.Location = new System.Drawing.Point(860, 530);
            this.RoundButtonJoc.Name = "RoundButtonJoc";
            this.RoundButtonJoc.Size = new System.Drawing.Size(100, 100);
            this.RoundButtonJoc.TabIndex = 2;
            this.RoundButtonJoc.Text = "Play and learn!";
            this.RoundButtonJoc.UseVisualStyleBackColor = false;
            this.RoundButtonJoc.Click += new System.EventHandler(this.buttonJoc_Click);
            // 
            // Pagina_Planete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::chestionar.Properties.Resources.fundal_planete;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.RoundButtonJoc);
            this.Controls.Add(this.RoundButtonChestionar);
            this.Controls.Add(this.RoundButtonTeorie);
            this.Name = "Pagina_Planete";
            this.Text = "Pagina_Planete";
            this.Load += new System.EventHandler(this.Pagina_Planete_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApplication1.RoundButton RoundButtonTeorie;
        private WindowsFormsApplication1.RoundButton RoundButtonChestionar;
        private WindowsFormsApplication1.RoundButton RoundButtonJoc;
    }
}