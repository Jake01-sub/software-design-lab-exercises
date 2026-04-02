namespace RecursivePower
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
            lblPowerResult = new Label();
            btnCalculatePower = new Button();
            txtExponentInput = new TextBox();
            txtBaseInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblPowerResult
            // 
            lblPowerResult.Anchor = AnchorStyles.None;
            lblPowerResult.AutoSize = true;
            lblPowerResult.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPowerResult.Location = new Point(304, 101);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(193, 50);
            lblPowerResult.TabIndex = 11;
            lblPowerResult.Text = "Result: ---";
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Anchor = AnchorStyles.None;
            btnCalculatePower.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculatePower.Location = new Point(333, 315);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(134, 57);
            btnCalculatePower.TabIndex = 10;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Anchor = AnchorStyles.None;
            txtExponentInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExponentInput.Location = new Point(273, 257);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(255, 29);
            txtExponentInput.TabIndex = 12;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Anchor = AnchorStyles.None;
            txtBaseInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBaseInput.Location = new Point(273, 201);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(255, 29);
            txtBaseInput.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 204);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 14;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 260);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 15;
            label2.Text = "Exponent";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBaseInput);
            Controls.Add(txtExponentInput);
            Controls.Add(lblPowerResult);
            Controls.Add(btnCalculatePower);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recursive Power";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPowerResult;
        private Button btnCalculatePower;
        private TextBox txtExponentInput;
        private TextBox txtBaseInput;
        private Label label1;
        private Label label2;
    }
}
