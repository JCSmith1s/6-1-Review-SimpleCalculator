namespace SimpleCalculator
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
            txtOper1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtOperator = new TextBox();
            label3 = new Label();
            txtOper2 = new TextBox();
            label4 = new Label();
            txtResult = new TextBox();
            btn_Calculate = new Button();
            btn_Exit = new Button();
            SuspendLayout();
            // 
            // txtOper1
            // 
            txtOper1.BorderStyle = BorderStyle.FixedSingle;
            txtOper1.Location = new Point(130, 22);
            txtOper1.Name = "txtOper1";
            txtOper1.Size = new Size(100, 23);
            txtOper1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Operand 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 68);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Operator:";
            // 
            // txtOperator
            // 
            txtOperator.BorderStyle = BorderStyle.FixedSingle;
            txtOperator.Location = new Point(130, 60);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(100, 23);
            txtOperator.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 109);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 5;
            label3.Text = "Operand 2:";
            // 
            // txtOper2
            // 
            txtOper2.BorderStyle = BorderStyle.FixedSingle;
            txtOper2.Location = new Point(130, 101);
            txtOper2.Name = "txtOper2";
            txtOper2.Size = new Size(100, 23);
            txtOper2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 151);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Result:";
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.LightGray;
            txtResult.BorderStyle = BorderStyle.FixedSingle;
            txtResult.Location = new Point(130, 143);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 6;
            // 
            // btn_Calculate
            // 
            btn_Calculate.Location = new Point(40, 200);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(75, 23);
            btn_Calculate.TabIndex = 8;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = true;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(155, 200);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(75, 23);
            btn_Exit.TabIndex = 9;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Form1
            // 
            AcceptButton = btn_Calculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Exit;
            ClientSize = new Size(296, 245);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Calculate);
            Controls.Add(label4);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(txtOper2);
            Controls.Add(label2);
            Controls.Add(txtOperator);
            Controls.Add(label1);
            Controls.Add(txtOper1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOper1;
        private Label label1;
        private Label label2;
        private TextBox txtOperator;
        private Label label3;
        private TextBox txtOper2;
        private Label label4;
        private TextBox txtResult;
        private Button btn_Calculate;
        private Button btn_Exit;
    }
}
