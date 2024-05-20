namespace CookBook.UI
{
    partial class AmountForm
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
            label1 = new Label();
            OkBtn = new Button();
            CancelBtn = new Button();
            AmountNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 65);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter Amount";
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(63, 252);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(180, 47);
            OkBtn.TabIndex = 1;
            OkBtn.Text = "Ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(450, 252);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(180, 47);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(63, 148);
            AmountNum.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(567, 36);
            AmountNum.TabIndex = 3;
            // 
            // AmountForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 363);
            Controls.Add(AmountNum);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AmountForm";
            Text = "AmountForm";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OkBtn;
        private Button CancelBtn;
        private NumericUpDown AmountNum;
    }
}