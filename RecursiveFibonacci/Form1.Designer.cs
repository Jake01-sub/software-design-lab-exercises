namespace RecursiveFibonacci
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
            lblFibonacciResult = new Label();
            btnCalculateFibonacci = new Button();
            txtFibonacciInput = new TextBox();
            SuspendLayout();
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.Anchor = AnchorStyles.None;
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFibonacciResult.Location = new Point(188, 99);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(406, 50);
            lblFibonacciResult.TabIndex = 8;
            lblFibonacciResult.Text = "Fibonacci Number: ---";
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Anchor = AnchorStyles.None;
            btnCalculateFibonacci.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateFibonacci.Location = new Point(333, 290);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(134, 57);
            btnCalculateFibonacci.TabIndex = 7;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Anchor = AnchorStyles.None;
            txtFibonacciInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFibonacciInput.Location = new Point(273, 226);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(255, 29);
            txtFibonacciInput.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFibonacciResult);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(txtFibonacciInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFibonacciResult;
        private Button btnCalculateFibonacci;
        private TextBox txtFibonacciInput;
    }
}
