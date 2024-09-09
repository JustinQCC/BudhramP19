namespace BudhramP19
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtAnimalName = new TextBox();
            label3 = new Label();
            t = new TextBox();
            LstOutput = new ListBox();
            btnCalcBMI = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(517, 45);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Animal BMI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(72, 111);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Animal Name";
            // 
            // txtAnimalName
            // 
            txtAnimalName.AccessibleName = "";
            txtAnimalName.Location = new Point(365, 109);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.Size = new Size(256, 23);
            txtAnimalName.TabIndex = 2;
            txtAnimalName.TextChanged += txtAnimalName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(72, 179);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Animal BMI";
            // 
            // t
            // 
            t.AccessibleName = "";
            t.Location = new Point(365, 176);
            t.Name = "t";
            t.Size = new Size(256, 23);
            t.TabIndex = 4;
            // 
            // LstOutput
            // 
            LstOutput.FormattingEnabled = true;
            LstOutput.ItemHeight = 15;
            LstOutput.Location = new Point(72, 241);
            LstOutput.Name = "LstOutput";
            LstOutput.Size = new Size(1045, 184);
            LstOutput.TabIndex = 5;
            // 
            // btnCalcBMI
            // 
            btnCalcBMI.Location = new Point(83, 453);
            btnCalcBMI.Name = "btnCalcBMI";
            btnCalcBMI.Size = new Size(75, 95);
            btnCalcBMI.TabIndex = 9;
            btnCalcBMI.Text = "Calculate the &BMI";
            btnCalcBMI.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(473, 453);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 95);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(837, 453);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 95);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 604);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalcBMI);
            Controls.Add(LstOutput);
            Controls.Add(t);
            Controls.Add(label3);
            Controls.Add(txtAnimalName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Justin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAnimalName;
        private Label label3;
        private TextBox t;
        private ListBox LstOutput;
        private Button btnCalcBMI;
        private Button btnClear;
        private Button btnQuit;
    }
}
