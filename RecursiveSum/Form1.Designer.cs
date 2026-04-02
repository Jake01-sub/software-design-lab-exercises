namespace RecursiveSum
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
            lblSumResult = new Label();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            SuspendLayout();
            // 
            // lblSumResult
            // 
            lblSumResult.Anchor = AnchorStyles.None;
            lblSumResult.AutoSize = true;
            lblSumResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSumResult.Location = new Point(309, 103);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(164, 50);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "Sum: ---";
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Anchor = AnchorStyles.None;
            btnCalculateSum.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateSum.Location = new Point(327, 290);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(134, 57);
            btnCalculateSum.TabIndex = 4;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Anchor = AnchorStyles.None;
            txtArrayInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArrayInput.Location = new Point(267, 226);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(255, 29);
            txtArrayInput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Sum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSumResult;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
    }
}
