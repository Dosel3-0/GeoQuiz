namespace GeoQuiz
{
    partial class Flag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flag));
            btnMainF = new Button();
            SuspendLayout();
            // 
            // btnMainF
            // 
            btnMainF.BackColor = Color.DarkGreen;
            btnMainF.FlatAppearance.BorderSize = 0;
            btnMainF.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnMainF.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMainF.FlatStyle = FlatStyle.Flat;
            btnMainF.ForeColor = SystemColors.ControlLightLight;
            btnMainF.Location = new Point(12, 12);
            btnMainF.Name = "btnMainF";
            btnMainF.Size = new Size(85, 39);
            btnMainF.TabIndex = 1;
            btnMainF.Text = "Zurück";
            btnMainF.UseVisualStyleBackColor = false;
            btnMainF.Click += btnMainF_Click;
            // 
            // Flag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnMainF);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Flag";
            Text = "Flaggen Quiz";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainF;
    }
}