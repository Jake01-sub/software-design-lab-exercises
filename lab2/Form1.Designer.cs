namespace lab2
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
            txtInput = new TextBox();
            btnCalculateFactorial = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.None;
            txtInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(273, 241);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(255, 29);
            txtInput.TabIndex = 0;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Anchor = AnchorStyles.None;
            btnCalculateFactorial.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateFactorial.Location = new Point(333, 305);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(134, 57);
            btnCalculateFactorial.TabIndex = 1;
            btnCalculateFactorial.Text = "Calculate";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.None;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(273, 118);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(266, 50);
            lblResult.TabIndex = 2;
            lblResult.Text = "Enter Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(txtInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Factorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculateFactorial;
        private Label lblResult;
    }
}
