namespace chestionar
{
    partial class Start_Page
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
            this.Button_Planets = new WindowsFormsApplication1.RoundButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_Planets
            // 
            this.Button_Planets.BackgroundImage = global::chestionar.Properties.Resources.pamant;
            this.Button_Planets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Planets.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Planets.ForeColor = System.Drawing.Color.Linen;
            this.Button_Planets.Location = new System.Drawing.Point(140, 140);
            this.Button_Planets.Name = "Button_Planets";
            this.Button_Planets.Size = new System.Drawing.Size(250, 250);
            this.Button_Planets.TabIndex = 0;
            this.Button_Planets.Text = "Planets";
            this.Button_Planets.UseVisualStyleBackColor = true;
            this.Button_Planets.Click += new System.EventHandler(this.buttonPlanets_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackgroundImage = global::chestionar.Properties.Resources.stele;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundButton1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.Linen;
            this.roundButton1.Location = new System.Drawing.Point(1157, 141);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(250, 250);
            this.roundButton1.TabIndex = 1;
            this.roundButton1.Text = "Constellations";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.buttonConstelations_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 258);
            this.label1.TabIndex = 2;
            this.label1.Text = " Introduction\r\n         in \r\n  Astronomy";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::chestionar.Properties.Resources.extr;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(693, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 187);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FlappyAlienButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(822, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Play!";
            // 
            // Start_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chestionar.Properties.Resources.poza_principala21;
            this.ClientSize = new System.Drawing.Size(1584, 901);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.Button_Planets);
            this.Name = "Start_Page";
            this.Text = "Start_Page";
            this.Load += new System.EventHandler(this.Start_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.RoundButton Button_Planets;
        private WindowsFormsApplication1.RoundButton roundButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}