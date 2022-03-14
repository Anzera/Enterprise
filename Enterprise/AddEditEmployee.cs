using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enterprise
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employee>> _fileHelper =
           new FileHelper<List<Employee>>(Program.FilePath);
        private int _employeeId;
        private Employee _employee;
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;

            GetEmployeesData();

            tbFirstName.Select();
        }
        private void GetEmployeesData()
        {
            if (_employeeId != 0)
            {
                Text = "Edydowanie danych pracownika";
                var employees = _fileHelper.DeserializeFromFile();
                _employee = employees.FirstOrDefault(x => x.Id == _employeeId);

                if (_employee == null)
                    throw new Exception("Brak pracownika o podanym Id");

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _employee.Id.ToString();
            tbFirstName.Text = _employee.FirstName;
            tbLastName.Text = _employee.LastName;
            rtbComments.Text = _employee.Comments;
            tbEarnings.Text = _employee.Earnings;
            dtpEmployment.Value = _employee.DateOfEmployment;
            tbDateRelease.Text = _employee.DateOfRelease.ToString();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employees);


            AddNewEmployeeToLIst(employees);

            _fileHelper.SerializeToFile(employees);

            Close();
        }

        private void AddNewEmployeeToLIst(List<Employee> employees)
        {
            var employee = new Employee
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = rtbComments.Text,
                Earnings = tbEarnings.Text,
                DateOfEmployment = dtpEmployment.Value.Date
            };

            employees.Add(employee);
        }
        private void AssignIdToNewEmployee(List<Employee> employees)
        {
            var employeeWithHighestId = employees
                    .OrderByDescending(x => x.Id).FirstOrDefault();//sortowanie po polu Id

            _employeeId = employeeWithHighestId == null ?
                1 : employeeWithHighestId.Id + 1;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
