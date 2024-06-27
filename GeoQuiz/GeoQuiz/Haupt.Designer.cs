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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label1 = new Label();
            btnNext = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(146, 211);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(270, 211);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(146, 267);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(270, 267);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 106);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 9;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DarkGreen;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.ForeColor = SystemColors.ControlLightLight;
            btnNext.Location = new Point(173, 332);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(128, 49);
            btnNext.TabIndex = 11;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(413, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 401);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // Haupt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1264, 681);
            Controls.Add(groupBox1);
            Controls.Add(btnMainH);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Haupt";
            Text = "Hauptstädten Quiz";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainH;
        private Button btnStart;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label1;
        private Button btnNext;
        private GroupBox groupBox1;
    }
}