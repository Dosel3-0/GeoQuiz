namespace GeoQuiz
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            btnLand = new Button();
            btnHaupt = new Button();
            btnFlag = new Button();
            btnHigh = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 9);
            label1.Name = "label1";
            label1.Size = new Size(374, 78);
            label1.TabIndex = 0;
            label1.Text = "Geografie Quiz";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLand
            // 
            btnLand.BackColor = Color.DarkGreen;
            btnLand.FlatAppearance.BorderColor = Color.Black;
            btnLand.FlatAppearance.BorderSize = 0;
            btnLand.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnLand.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnLand.FlatStyle = FlatStyle.Flat;
            btnLand.ForeColor = SystemColors.ControlLightLight;
            btnLand.Location = new Point(455, 362);
            btnLand.Name = "btnLand";
            btnLand.Size = new Size(128, 49);
            btnLand.TabIndex = 1;
            btnLand.Text = "Ländern";
            btnLand.UseVisualStyleBackColor = false;
            btnLand.Click += btnLand_Click;
            // 
            // btnHaupt
            // 
            btnHaupt.BackColor = Color.DarkGreen;
            btnHaupt.FlatAppearance.BorderSize = 0;
            btnHaupt.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnHaupt.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnHaupt.FlatStyle = FlatStyle.Flat;
            btnHaupt.ForeColor = SystemColors.ControlLightLight;
            btnHaupt.Location = new Point(701, 362);
            btnHaupt.Name = "btnHaupt";
            btnHaupt.Size = new Size(128, 49);
            btnHaupt.TabIndex = 2;
            btnHaupt.Text = "Hauptstädten";
            btnHaupt.UseVisualStyleBackColor = false;
            btnHaupt.Click += btnHaupt_Click;
            // 
            // btnFlag
            // 
            btnFlag.BackColor = Color.DarkGreen;
            btnFlag.FlatAppearance.BorderSize = 0;
            btnFlag.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnFlag.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnFlag.FlatStyle = FlatStyle.Flat;
            btnFlag.ForeColor = SystemColors.ControlLightLight;
            btnFlag.Location = new Point(455, 444);
            btnFlag.Name = "btnFlag";
            btnFlag.Size = new Size(128, 49);
            btnFlag.TabIndex = 3;
            btnFlag.Text = "Flaggen";
            btnFlag.UseVisualStyleBackColor = false;
            btnFlag.Click += btnFlag_Click;
            // 
            // btnHigh
            // 
            btnHigh.BackColor = Color.DarkGreen;
            btnHigh.FlatAppearance.BorderSize = 0;
            btnHigh.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnHigh.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnHigh.FlatStyle = FlatStyle.Flat;
            btnHigh.ForeColor = SystemColors.ControlLightLight;
            btnHigh.Location = new Point(701, 444);
            btnHigh.Name = "btnHigh";
            btnHigh.Size = new Size(128, 49);
            btnHigh.TabIndex = 4;
            btnHigh.Text = "Highscore";
            btnHigh.UseVisualStyleBackColor = false;
            btnHigh.Click += btnHigh_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(582, 510);
            button1.Name = "button1";
            button1.Size = new Size(121, 51);
            button1.TabIndex = 5;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1264, 681);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnHigh);
            Controls.Add(btnFlag);
            Controls.Add(btnHaupt);
            Controls.Add(btnLand);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Geografie Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLand;
        private Button btnHaupt;
        private Button btnFlag;
        private Button btnHigh;
        private Button button1;
    }
}
