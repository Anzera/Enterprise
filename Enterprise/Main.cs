using Enterprise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise
{
    public partial class Main : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
            new FileHelper<List<Employee>>(Program.FilePath);

        public bool IsMaximaze
        {
            get
            {
                return Settings.Default.IsMaximaze;
            }
            set
            {
                Settings.Default.IsMaximaze = value;
            }
        }
        public Main()
        {
            InitializeComponent();
            RefreshEmployeeList();
            SetColumnHeader();

            if (IsMaximaze)
                WindowState = FormWindowState.Maximized;
        }
        private void SetColumnHeader()
        {
            dgvEmployee.Columns[0].HeaderText = "Numer";
            dgvEmployee.Columns[1].HeaderText = "Imię";
            dgvEmployee.Columns[2].HeaderText = "Nazwisko";
            dgvEmployee.Columns[3].HeaderText = "Uwagi";
            dgvEmployee.Columns[4].HeaderText = "Zarobki";
            dgvEmployee.Columns[5].HeaderText = "Data zatrudnienia";
            dgvEmployee.Columns[6].HeaderText = "Data zwolnienia";
        }
        private void RefreshEmployeeList()
        {
            var employees = _fileHelper.DeserializeFromFile();
            dgvEmployee.DataSource = employees;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addeditemployee = new AddEditEmployee();
            addeditemployee.FormClosing += AddEditEmployee_FormClosing;
            addeditemployee.ShowDialog();
        }

        private void AddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshEmployeeList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego dane chcesz edytować");
                return;
            }

            var addEditStudent = new AddEditEmployee(Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells[0].Value));
            addEditStudent.FormClosing += AddEditEmployee_FormClosing;
            addEditStudent.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego chcesz zwolnić");
                return;
            }

            var selectedEmployee = dgvEmployee.SelectedRows[0];
            var confirmDelete = MessageBox.Show($"Czy na pewno chcesz cwolnić {(selectedEmployee.Cells[1].Value.ToString() + " " + selectedEmployee.Cells[2].Value.ToString()).Trim()}", "Zwalnianie pracownika", MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK)
            {
                ReleaseEmployee(Convert.ToInt32(selectedEmployee.Cells[0].Value));
                RefreshEmployeeList();
            }
        }

        private void ReleaseEmployee(int id)
        {
            var employees = _fileHelper.DeserializeFromFile();
            var employee = employees.Find(x => x.Id == id);
            employee.DateOfRelease = DateTime.Now.Date;  
            _fileHelper.SerializeToFile(employees);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                IsMaximaze = true;
            else
                IsMaximaze = false;

            Settings.Default.Save();
        }
    }
}
