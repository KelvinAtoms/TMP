namespace Quyen_Project
{
    partial class Form3
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
            txtInput = new TextBox();
            txtShow = new TextBox();
            txtSum = new TextBox();
            txtOdd = new TextBox();
            txtEven = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(214, 69);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(150, 31);
            txtInput.TabIndex = 0;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // txtShow
            // 
            txtShow.Location = new Point(214, 114);
            txtShow.Name = "txtShow";
            txtShow.Size = new Size(150, 31);
            txtShow.TabIndex = 1;
            // 
            // txtSum
            // 
            txtSum.Location = new Point(371, 160);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(150, 31);
            txtSum.TabIndex = 2;
            // 
            // txtOdd
            // 
            txtOdd.Location = new Point(371, 213);
            txtOdd.Name = "txtOdd";
            txtOdd.Size = new Size(150, 31);
            txtOdd.TabIndex = 3;
            // 
            // txtEven
            // 
            txtEven.Location = new Point(214, 213);
            txtEven.Name = "txtEven";
            txtEven.Size = new Size(150, 31);
            txtEven.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(409, 69);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtEven);
            Controls.Add(txtOdd);
            Controls.Add(txtSum);
            Controls.Add(txtShow);
            Controls.Add(txtInput);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtShow;
        private TextBox txtSum;
        private TextBox txtOdd;
        private TextBox txtEven;
        private Button button1;
    }
}