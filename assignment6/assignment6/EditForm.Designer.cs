namespace assignment6
{
    partial class EditForm
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
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lCustomer = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lGoods = new System.Windows.Forms.Label();
            this.cbGoods = new System.Windows.Forms.ComboBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Items.AddRange(new object[] {
            "张三",
            "李四"});
            this.cbCustomer.Location = new System.Drawing.Point(61, 12);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 25);
            this.cbCustomer.TabIndex = 0;
            // 
            // lCustomer
            // 
            this.lCustomer.AutoSize = true;
            this.lCustomer.Location = new System.Drawing.Point(12, 12);
            this.lCustomer.Name = "lCustomer";
            this.lCustomer.Size = new System.Drawing.Size(32, 17);
            this.lCustomer.TabIndex = 1;
            this.lCustomer.Text = "客户";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "完成";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lGoods
            // 
            this.lGoods.AutoSize = true;
            this.lGoods.Location = new System.Drawing.Point(12, 40);
            this.lGoods.Name = "lGoods";
            this.lGoods.Size = new System.Drawing.Size(32, 17);
            this.lGoods.TabIndex = 7;
            this.lGoods.Text = "货物";
            // 
            // cbGoods
            // 
            this.cbGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.Items.AddRange(new object[] {
            "手机",
            "电脑",
            "服务器"});
            this.cbGoods.Location = new System.Drawing.Point(61, 40);
            this.cbGoods.Name = "cbGoods";
            this.cbGoods.Size = new System.Drawing.Size(121, 25);
            this.cbGoods.TabIndex = 6;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(188, 42);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 23);
            this.tbNumber.TabIndex = 8;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lGoods);
            this.Controls.Add(this.cbGoods);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lCustomer);
            this.Controls.Add(this.cbCustomer);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbCustomer;
        private Label lCustomer;
        private Button btnAdd;
        private Button btnUpdate;
        private Label lGoods;
        private ComboBox cbGoods;
        private TextBox tbNumber;
    }
}