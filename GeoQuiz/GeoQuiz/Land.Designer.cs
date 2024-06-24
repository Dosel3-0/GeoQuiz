namespace GeoQuiz
{
    partial class Land
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Land));
            btnMainL = new Button();
            SuspendLayout();
            // 
            // btnMainL
            // 
            btnMainL.BackColor = Color.DarkGreen;
            btnMainL.FlatAppearance.BorderSize = 0;
            btnMainL.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnMainL.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnMainL.FlatStyle = FlatStyle.Flat;
            btnMainL.ForeColor = SystemColors.ControlLightLight;
            btnMainL.Location = new Point(12, 12);
            btnMainL.Name = "btnMainL";
            btnMainL.Size = new Size(85, 39);
            btnMainL.TabIndex = 0;
            btnMainL.Text = "Zurück";
            btnMainL.UseVisualStyleBackColor = false;
            btnMainL.Click += btnMainL_Click;
            // 
            // Land
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnMainL);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Land";
            Text = "Länder Quiz";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainL;
    }
}