namespace ViewWin
{
    partial class AddEmps
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.PositionBox = new System.Windows.Forms.TextBox();
            this.NameEmp = new System.Windows.Forms.Label();
            this.AgeEmp = new System.Windows.Forms.Label();
            this.SalaryEmp = new System.Windows.Forms.Label();
            this.PositionEmp = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(151, 86);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(153, 22);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(151, 140);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(153, 22);
            this.AgeBox.TabIndex = 1;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(151, 190);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(153, 22);
            this.SalaryBox.TabIndex = 2;
            // 
            // PositionBox
            // 
            this.PositionBox.Location = new System.Drawing.Point(151, 230);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(153, 22);
            this.PositionBox.TabIndex = 3;
            // 
            // NameEmp
            // 
            this.NameEmp.AutoSize = true;
            this.NameEmp.Location = new System.Drawing.Point(34, 86);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.Size = new System.Drawing.Size(35, 17);
            this.NameEmp.TabIndex = 4;
            this.NameEmp.Text = "Имя";
            // 
            // AgeEmp
            // 
            this.AgeEmp.AutoSize = true;
            this.AgeEmp.Location = new System.Drawing.Point(34, 140);
            this.AgeEmp.Name = "AgeEmp";
            this.AgeEmp.Size = new System.Drawing.Size(62, 17);
            this.AgeEmp.TabIndex = 5;
            this.AgeEmp.Text = "Возраст";
            // 
            // SalaryEmp
            // 
            this.SalaryEmp.AutoSize = true;
            this.SalaryEmp.Location = new System.Drawing.Point(34, 190);
            this.SalaryEmp.Name = "SalaryEmp";
            this.SalaryEmp.Size = new System.Drawing.Size(72, 17);
            this.SalaryEmp.TabIndex = 6;
            this.SalaryEmp.Text = "Зарплата";
            // 
            // PositionEmp
            // 
            this.PositionEmp.AutoSize = true;
            this.PositionEmp.Location = new System.Drawing.Point(34, 233);
            this.PositionEmp.Name = "PositionEmp";
            this.PositionEmp.Size = new System.Drawing.Size(81, 17);
            this.PositionEmp.TabIndex = 7;
            this.PositionEmp.Text = "Должность";
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(163, 331);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(97, 33);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(275, 331);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(101, 33);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Отменить";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddEmps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 400);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PositionEmp);
            this.Controls.Add(this.SalaryEmp);
            this.Controls.Add(this.AgeEmp);
            this.Controls.Add(this.NameEmp);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.NameBox);
            this.Name = "AddEmps";
            this.Text = "AddEmps";
            this.Load += new System.EventHandler(this.AddEmps_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameEmp;
        private System.Windows.Forms.Label AgeEmp;
        private System.Windows.Forms.Label SalaryEmp;
        private System.Windows.Forms.Label PositionEmp;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox AgeBox;
        public System.Windows.Forms.TextBox SalaryBox;
        public System.Windows.Forms.TextBox PositionBox;
    }
}