using System;

namespace ViewWin
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddEmp = new System.Windows.Forms.Button();
            this.DeleteEmp = new System.Windows.Forms.Button();
            this.ChangePosition = new System.Windows.Forms.Button();
            this.GridEmp = new System.Windows.Forms.DataGridView();
            this.AgeButton = new System.Windows.Forms.Button();
            this.ShowEquipment = new System.Windows.Forms.Button();
            this.AddEquipment = new System.Windows.Forms.Button();
            this.ShowEmployers = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DeleteEqButton = new System.Windows.Forms.Button();
            this.AddEmpDAP = new System.Windows.Forms.Button();
            this.AddEqDAP = new System.Windows.Forms.Button();
            this.DelEmpDAP = new System.Windows.Forms.Button();
            this.DelEqDAP = new System.Windows.Forms.Button();
            this.ShowEmpDAP = new System.Windows.Forms.Button();
            this.ShowEqDAP = new System.Windows.Forms.Button();
            this.AddTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEmp
            // 
            this.AddEmp.Location = new System.Drawing.Point(704, 163);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(219, 31);
            this.AddEmp.TabIndex = 1;
            this.AddEmp.Text = "Добавить(ЕФ)";
            this.AddEmp.UseVisualStyleBackColor = true;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // DeleteEmp
            // 
            this.DeleteEmp.Location = new System.Drawing.Point(704, 319);
            this.DeleteEmp.Name = "DeleteEmp";
            this.DeleteEmp.Size = new System.Drawing.Size(219, 37);
            this.DeleteEmp.TabIndex = 2;
            this.DeleteEmp.Text = "Удалить(ЕФ)";
            this.DeleteEmp.UseVisualStyleBackColor = true;
            this.DeleteEmp.Click += new System.EventHandler(this.DeleteEmp_Click);
            // 
            // ChangePosition
            // 
            this.ChangePosition.Location = new System.Drawing.Point(410, 237);
            this.ChangePosition.Name = "ChangePosition";
            this.ChangePosition.Size = new System.Drawing.Size(148, 38);
            this.ChangePosition.TabIndex = 4;
            this.ChangePosition.Text = "Изменить ";
            this.ChangePosition.UseVisualStyleBackColor = true;
            this.ChangePosition.Click += new System.EventHandler(this.ChangePosition_Click);
            // 
            // GridEmp
            // 
            this.GridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridEmp.Location = new System.Drawing.Point(0, 0);
            this.GridEmp.Name = "GridEmp";
            this.GridEmp.RowTemplate.Height = 24;
            this.GridEmp.Size = new System.Drawing.Size(946, 157);
            this.GridEmp.TabIndex = 5;
            this.GridEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AgeButton
            // 
            this.AgeButton.Location = new System.Drawing.Point(410, 308);
            this.AgeButton.Name = "AgeButton";
            this.AgeButton.Size = new System.Drawing.Size(148, 38);
            this.AgeButton.TabIndex = 6;
            this.AgeButton.Text = "Средний возраст";
            this.AgeButton.UseVisualStyleBackColor = true;
            this.AgeButton.Click += new System.EventHandler(this.AgeButton_Click);
            // 
            // ShowEquipment
            // 
            this.ShowEquipment.Location = new System.Drawing.Point(704, 279);
            this.ShowEquipment.Name = "ShowEquipment";
            this.ShowEquipment.Size = new System.Drawing.Size(219, 35);
            this.ShowEquipment.TabIndex = 7;
            this.ShowEquipment.Text = "Показать оборудование(ЕФ)";
            this.ShowEquipment.UseVisualStyleBackColor = true;
            this.ShowEquipment.Click += new System.EventHandler(this.ShowEquipment_Click);
            // 
            // AddEquipment
            // 
            this.AddEquipment.Location = new System.Drawing.Point(704, 202);
            this.AddEquipment.Name = "AddEquipment";
            this.AddEquipment.Size = new System.Drawing.Size(219, 31);
            this.AddEquipment.TabIndex = 8;
            this.AddEquipment.Text = "Добавить оборудование(ЕФ)";
            this.AddEquipment.UseVisualStyleBackColor = true;
            this.AddEquipment.Click += new System.EventHandler(this.AddEquipment_Click);
            // 
            // ShowEmployers
            // 
            this.ShowEmployers.Location = new System.Drawing.Point(704, 239);
            this.ShowEmployers.Name = "ShowEmployers";
            this.ShowEmployers.Size = new System.Drawing.Size(219, 36);
            this.ShowEmployers.TabIndex = 9;
            this.ShowEmployers.Text = "Показать сотрудников(ЕФ)";
            this.ShowEmployers.UseVisualStyleBackColor = true;
            this.ShowEmployers.Click += new System.EventHandler(this.ShowEmployers_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Model.Employee);
            // 
            // DeleteEqButton
            // 
            this.DeleteEqButton.Location = new System.Drawing.Point(704, 362);
            this.DeleteEqButton.Name = "DeleteEqButton";
            this.DeleteEqButton.Size = new System.Drawing.Size(219, 44);
            this.DeleteEqButton.TabIndex = 10;
            this.DeleteEqButton.Text = "Удалить оборудование(ЕФ)";
            this.DeleteEqButton.UseVisualStyleBackColor = true;
            this.DeleteEqButton.Click += new System.EventHandler(this.DeleteEqButton_Click);
            // 
            // AddEmpDAP
            // 
            this.AddEmpDAP.Location = new System.Drawing.Point(12, 163);
            this.AddEmpDAP.Name = "AddEmpDAP";
            this.AddEmpDAP.Size = new System.Drawing.Size(222, 31);
            this.AddEmpDAP.TabIndex = 11;
            this.AddEmpDAP.Text = "Добавить(Дап)";
            this.AddEmpDAP.UseVisualStyleBackColor = true;
            this.AddEmpDAP.Click += new System.EventHandler(this.AddEmpDAP_Click);
            // 
            // AddEqDAP
            // 
            this.AddEqDAP.Location = new System.Drawing.Point(12, 200);
            this.AddEqDAP.Name = "AddEqDAP";
            this.AddEqDAP.Size = new System.Drawing.Size(222, 31);
            this.AddEqDAP.TabIndex = 12;
            this.AddEqDAP.Text = "Добавить оборудование(Дап)";
            this.AddEqDAP.UseVisualStyleBackColor = true;
            this.AddEqDAP.Click += new System.EventHandler(this.AddEqDAP_Click);
            // 
            // DelEmpDAP
            // 
            this.DelEmpDAP.Location = new System.Drawing.Point(12, 319);
            this.DelEmpDAP.Name = "DelEmpDAP";
            this.DelEmpDAP.Size = new System.Drawing.Size(222, 37);
            this.DelEmpDAP.TabIndex = 13;
            this.DelEmpDAP.Text = "Удалить работника(Дап)";
            this.DelEmpDAP.UseVisualStyleBackColor = true;
            this.DelEmpDAP.Click += new System.EventHandler(this.DelEmpDAP_Click);
            // 
            // DelEqDAP
            // 
            this.DelEqDAP.Location = new System.Drawing.Point(12, 362);
            this.DelEqDAP.Name = "DelEqDAP";
            this.DelEqDAP.Size = new System.Drawing.Size(222, 44);
            this.DelEqDAP.TabIndex = 14;
            this.DelEqDAP.Text = "Удалить оборудование(Дап)";
            this.DelEqDAP.UseVisualStyleBackColor = true;
            this.DelEqDAP.Click += new System.EventHandler(this.DelEqDAP_Click);
            // 
            // ShowEmpDAP
            // 
            this.ShowEmpDAP.Location = new System.Drawing.Point(12, 237);
            this.ShowEmpDAP.Name = "ShowEmpDAP";
            this.ShowEmpDAP.Size = new System.Drawing.Size(222, 38);
            this.ShowEmpDAP.TabIndex = 15;
            this.ShowEmpDAP.Text = "Показать сотрудников(Дап)";
            this.ShowEmpDAP.UseVisualStyleBackColor = true;
            this.ShowEmpDAP.Click += new System.EventHandler(this.ShowEmpDAP_Click);
            // 
            // ShowEqDAP
            // 
            this.ShowEqDAP.Location = new System.Drawing.Point(12, 279);
            this.ShowEqDAP.Name = "ShowEqDAP";
            this.ShowEqDAP.Size = new System.Drawing.Size(222, 31);
            this.ShowEqDAP.TabIndex = 16;
            this.ShowEqDAP.Text = "Показать оборудование(Дап)";
            this.ShowEqDAP.UseVisualStyleBackColor = true;
            this.ShowEqDAP.Click += new System.EventHandler(this.ShowEqDAP_Click);
            // 
            // AddTest
            // 
            this.AddTest.Location = new System.Drawing.Point(400, 170);
            this.AddTest.Name = "AddTest";
            this.AddTest.Size = new System.Drawing.Size(123, 41);
            this.AddTest.TabIndex = 17;
            this.AddTest.Text = "Add";
            this.AddTest.UseVisualStyleBackColor = true;
            this.AddTest.Click += new System.EventHandler(this.AddTest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 415);
            this.Controls.Add(this.AddTest);
            this.Controls.Add(this.ShowEqDAP);
            this.Controls.Add(this.ShowEmpDAP);
            this.Controls.Add(this.DelEqDAP);
            this.Controls.Add(this.DelEmpDAP);
            this.Controls.Add(this.AddEqDAP);
            this.Controls.Add(this.AddEmpDAP);
            this.Controls.Add(this.DeleteEqButton);
            this.Controls.Add(this.ShowEmployers);
            this.Controls.Add(this.AddEquipment);
            this.Controls.Add(this.ShowEquipment);
            this.Controls.Add(this.AgeButton);
            this.Controls.Add(this.GridEmp);
            this.Controls.Add(this.ChangePosition);
            this.Controls.Add(this.DeleteEmp);
            this.Controls.Add(this.AddEmp);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button AddEmp;
        private System.Windows.Forms.DataGridView GridEmp;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        public System.Windows.Forms.Button DeleteEmp;
        public System.Windows.Forms.Button ChangePosition;
        public System.Windows.Forms.Button AgeButton;
        private System.Windows.Forms.Button ShowEquipment;
        private System.Windows.Forms.Button AddEquipment;
        public System.Windows.Forms.Button ShowEmployers;
        public System.Windows.Forms.Button DeleteEqButton;
        public System.Windows.Forms.Button AddEmpDAP;
        public System.Windows.Forms.Button AddEqDAP;
        public System.Windows.Forms.Button DelEmpDAP;
        public System.Windows.Forms.Button DelEqDAP;
        public System.Windows.Forms.Button ShowEmpDAP;
        public System.Windows.Forms.Button ShowEqDAP;
        public System.Windows.Forms.Button AddTest;
    }
}

