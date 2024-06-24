namespace GeoQuiz
{
    partial class Haupt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Haupt));
            btnMainH = new Button();
            SuspendLayout();
            // 
            // btnMainH
            // 
            btnMainH.BackColor = Color.DarkGreen;
            btnMainH.FlatAppearance.BorderSize = 0;
            btnMainH.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnMainH.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMainH.FlatStyle = FlatStyle.Flat;
            btnMainH.ForeColor = SystemColors.ControlLightLight;
            btnMainH.Location = new Point(12, 12);
            btnMainH.Name = "btnMainH";
            btnMainH.Size = new Size(85, 39);
            btnMainH.TabIndex = 1;
            btnMainH.Text = "Zurück";
            btnMainH.UseVisualStyleBackColor = false;
            btnMainH.Click += btnMainH_Click;
            // 
            // Haupt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnMainH);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Haupt";
            Text = "Hauptstädten Quiz";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainH;
    }
}