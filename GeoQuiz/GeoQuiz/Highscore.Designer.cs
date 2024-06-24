namespace GeoQuiz
{
    partial class Highscore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Highscore));
            btnMainHi = new Button();
            SuspendLayout();
            // 
            // btnMainHi
            // 
            btnMainHi.BackColor = Color.DarkGreen;
            btnMainHi.FlatAppearance.BorderSize = 0;
            btnMainHi.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnMainHi.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMainHi.FlatStyle = FlatStyle.Flat;
            btnMainHi.ForeColor = SystemColors.ControlLightLight;
            btnMainHi.Location = new Point(12, 12);
            btnMainHi.Name = "btnMainHi";
            btnMainHi.Size = new Size(85, 39);
            btnMainHi.TabIndex = 1;
            btnMainHi.Text = "Zurück";
            btnMainHi.UseVisualStyleBackColor = false;
            btnMainHi.Click += btnMainHi_Click;
            // 
            // Highscore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnMainHi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Highscore";
            Text = "Highscore";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainHi;
    }
}