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
            btnStart = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label1 = new Label();
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
            // btnStart
            // 
            btnStart.BackColor = Color.DarkGreen;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(515, 425);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(128, 49);
            btnStart.TabIndex = 4;
            btnStart.Text = "Test start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(474, 327);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(617, 327);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(474, 367);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(617, 367);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(94, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(571, 231);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // Haupt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1264, 681);
            Controls.Add(label1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(btnStart);
            Controls.Add(btnMainH);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Haupt";
            Text = "Hauptstädten Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainH;
        private Button btnStart;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label1;
    }
}