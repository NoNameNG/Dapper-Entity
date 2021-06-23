using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Model;
using EF;
using Ninject;

namespace ViewWin
{
    public partial class MainForm : Form
    {

        static IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
        BusinessLogical businessLogical = ninjectKernel.Get<BusinessLogical>();
        public MainForm()
        {
            
            InitializeComponent();

            UpdateTable();
            
            
        }

        private void ListEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            if (form.ShowDialog() == DialogResult.OK)
            {
                businessLogical.AddEmployeer(form.NameBox.Text, Int32.Parse(form.AgeBox.Text), Int32.Parse(form.SalaryBox.Text), form.PositionBox.Text);
            }

            UpdateTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(GridEmp.Rows[GridEmp.CurrentRow.Index].Cells[0].Value.ToString());
           // int selectedId = GridEmp.CurrentRow.Index;
            businessLogical.RemoveEmp(id);
            UpdateTable();
        }

        private void UpdateTable()
        {
            GridEmp.ColumnCount = 5;
            GridEmp.ColumnHeadersVisible = true;
            GridEmp.Columns[0].Name = "Id";
            GridEmp.Columns[1].Name = "Name";
            GridEmp.Columns[2].Name = "Age";
            GridEmp.Columns[3].Name = "Salary";
            GridEmp.Columns[4].Name = "Position";
            GridEmp.Rows.Clear();
            foreach (var emp in businessLogical.GetEmployeer())
            {
                string[] Row = new string[] { emp.id.ToString(), emp.Name, (emp.Age).ToString(), (emp.Salary).ToString(), emp.Position };
                GridEmp.Rows.Add(Row);
            } 
        }

        private void ChangePosition_Click(object sender, EventArgs e)
        {
            int id = GridEmp.CurrentRow.Index;
            var form = new ChangePos();
           // form.PositionBox.Text = businessLogical.Employees.ElementAt(id).Position;
           // form.SalaryBox.Text = businessLogical.Employees.ElementAt(id).Salary.ToString();
            if (form.ShowDialog() == DialogResult.OK)
            {
            //    businessLogical.Employees.ElementAt(id).Position = form.PositionBox.Text;
            //    businessLogical.Employees.ElementAt(id).Salary = int.Parse(form.SalaryBox.Text);
            }

            UpdateTable();

        }

        private void AgeButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Средний возраст сотрудников:" + businessLogical.AverageAge().ToString());
        }

        private void ShowEquipment_Click(object sender, EventArgs e)
        {
            GridEmp.ColumnCount = 3;
            GridEmp.ColumnHeadersVisible = true;
            GridEmp.Columns[0].Name = "Id";
            GridEmp.Columns[1].Name = "Title";
            GridEmp.Columns[2].Name = "IdEmp";
            GridEmp.Rows.Clear();
            foreach (var eq in businessLogical.GetEquipment())
            {
                string[] Row = new string[] { eq.id.ToString(), eq.Title, eq.EmployeeId.ToString() };
                GridEmp.Rows.Add(Row);
            }
        }

        private void AddEquipment_Click(object sender, EventArgs e)
        {
            var form = new AddEquips();
            var idemps = 0;
            foreach (var emps in businessLogical.GetEmployeer())
            {
                idemps = form.IdEmps.Items.Add(emps.id);
            }
            if (form.ShowDialog() == DialogResult.OK)
            {
                businessLogical.AddEquipment(form.TitleEqipTextBox.Text.ToString(), int.Parse(form.IdEmps.SelectedItem.ToString()));
            }

            
        }

        private void ShowEmployers_Click(object sender, EventArgs e)
        {
            GridEmp.ColumnCount = 5;
            GridEmp.ColumnHeadersVisible = true;
            GridEmp.Columns[0].Name = "Id";
            GridEmp.Columns[1].Name = "Name";
            GridEmp.Columns[2].Name = "Age";
            GridEmp.Columns[3].Name = "Salary";
            GridEmp.Columns[4].Name = "Position";
            GridEmp.Rows.Clear();
            foreach (var emp in businessLogical.GetEmployeer())
            {
                string[] Row = new string[] { emp.id.ToString(), emp.Name, (emp.Age).ToString(), (emp.Salary).ToString(), emp.Position };
                GridEmp.Rows.Add(Row);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void DeleteEqButton_Click(object sender, EventArgs e)
        {
            int ideq = Int32.Parse(GridEmp.Rows[GridEmp.CurrentRow.Index].Cells[0].Value.ToString());
            businessLogical.RemoveEq(ideq);
        }

        private void AddEmpDAP_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            if (form.ShowDialog() == DialogResult.OK)
            {
                businessLogical.AddEmployeerDAP(form.NameBox.Text, Int32.Parse(form.AgeBox.Text), Int32.Parse(form.SalaryBox.Text), form.PositionBox.Text);
            }

            UpdateTable();
        }

        private void AddEqDAP_Click(object sender, EventArgs e)
        {
            var form = new AddEquips();
            var idemps = 0;
            foreach (var emps in businessLogical.GetDapperEmp())
            {
                idemps = form.IdEmps.Items.Add(emps.id);
            }
            if (form.ShowDialog() == DialogResult.OK)
            {
                businessLogical.AddEquipmentDAP(form.TitleEqipTextBox.Text.ToString(), int.Parse(form.IdEmps.SelectedItem.ToString()));
            }
        }

        private void ShowEmpDAP_Click(object sender, EventArgs e)
        {
            GridEmp.ColumnCount = 5;
            GridEmp.ColumnHeadersVisible = true;
            GridEmp.Columns[0].Name = "Id";
            GridEmp.Columns[1].Name = "Name";
            GridEmp.Columns[2].Name = "Age";
            GridEmp.Columns[3].Name = "Salary";
            GridEmp.Columns[4].Name = "Position";
            GridEmp.Rows.Clear();
            foreach (var emp in businessLogical.GetDapperEmp())
            {
                string[] Row = new string[] { emp.id.ToString(), emp.Name, (emp.Age).ToString(), (emp.Salary).ToString(), emp.Position };
                GridEmp.Rows.Add(Row);
            }
        }

        private void ShowEqDAP_Click(object sender, EventArgs e)
        {
            GridEmp.ColumnCount = 3;
            GridEmp.ColumnHeadersVisible = true;
            GridEmp.Columns[0].Name = "Id";
            GridEmp.Columns[1].Name = "Title";
            GridEmp.Columns[2].Name = "IdEmp";
            GridEmp.Rows.Clear();
            foreach (var eq in businessLogical.GetDapperEq())
            {
                string[] Row = new string[] { eq.id.ToString(), eq.Title, eq.EmployeeId.ToString() };
                GridEmp.Rows.Add(Row);
            }
        }

        private void DelEmpDAP_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(GridEmp.Rows[GridEmp.CurrentRow.Index].Cells[0].Value.ToString());
            businessLogical.DapperRemoveEmp(id);
        }

        private void DelEqDAP_Click(object sender, EventArgs e)
        {
            int ideq = Int32.Parse(GridEmp.Rows[GridEmp.CurrentRow.Index].Cells[0].Value.ToString());
            businessLogical.DapperRemoveEq(ideq);
        }

        private void AddTest_Click(object sender, EventArgs e)
        {
            var form = new AddEmps();
            if (form.ShowDialog() == DialogResult.OK)
            {
                businessLogical.AddEmployeer(form.NameBox.Text, Int32.Parse(form.AgeBox.Text), Int32.Parse(form.SalaryBox.Text), form.PositionBox.Text);
            }

            UpdateTable();
        }
    }
}
