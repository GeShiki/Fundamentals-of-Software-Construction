namespace assignment1._1
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.answer = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(368, 181);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(75, 23);
            this.answer.TabIndex = 0;
            this.answer.Text = "answer";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(192, 97);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 23);
            this.number1.TabIndex = 1;
            // 
            // operation
            // 
            this.operation.Location = new System.Drawing.Point(360, 97);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(100, 23);
            this.operation.TabIndex = 2;
            this.operation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(526, 97);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 23);
            this.number2.TabIndex = 3;
            this.number2.TextChanged += new System.EventHandler(this.number2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "请输入数字:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "请输入数字:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "请输入运算符:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 469);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.answer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Button answer;
        private TextBox number1;
        private TextBox operation;
        private TextBox number2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}