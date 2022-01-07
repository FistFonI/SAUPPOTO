using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAUPPOTO
{
    /// <summary>
    /// Окно редактирования сотрудника.
    /// </summary>
    public partial class EmployeeEditForm : Form
    {
        /// <summary>
        /// Сотрудник.
        /// </summary>
        private Employee Employee;

        /// <summary>
        /// Поле, которое сохраняет данное окно.
        /// </summary>
        private static EmployeeEditForm inst;

        /// <summary>
        /// Свойство, которое позволяет получить данное окно.
        /// </summary>
        public static EmployeeEditForm GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new EmployeeEditForm();
                return inst;
            }
        }

        /// <summary>
        /// Инициализация окна редактирования сотрудника.
        /// </summary>
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку «Возврат к списку сотрудников».
        /// Скрытие данного окна и показ окна меню сотрудников.
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeMenuForm.GetForm.Show();
            EmployeeMenuForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку «Редактировать».
        /// Создание сотрудника и заполнение его данных. Замена указанного сотрудника в таблице на указанного.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            Employee.ID = Guid.Parse(EmployeeMenuForm.GetForm.SelectedRow.Cells[0].Value.ToString());
            Employee.FullName = FullNameTextBox.Text;
            Employee.Position = PositionTextBox.Text;
            Employee.Salary.HourlyPayValue = decimal.Parse(HourlyPaymentTextBox.Text);
            Employee.Salary.WorkingHours = int.Parse(WorkHoursTextBox.Text);
            Employee.Salary.PremiumValue = decimal.Parse(PremiumTextBox.Text);
            EmployeeMenuForm.GetForm.Employees[EmployeeMenuForm.GetForm.SelectedRow.Index] = Employee;
            EmployeeMenuForm.GetForm.Show();
            EmployeeMenuForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Отправление информации в базу данных. Закрытие приложения.
        /// </summary>
        private void EmployeeEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeMenuForm.GetForm.LoadingDataIntoDatabase();
            Application.Exit();
        }

        /// <summary>
        /// Проверка текста в текстовом поле размера почасовой оплаты труда на допустимые символы. 
        /// Удаление всех недопустимых символов.
        /// </summary>
        private void HourlyPaymentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(HourlyPaymentTextBox.Text) <= 0)
                    throw new Exception();
            }
            catch
            {
                HourlyPaymentTextBox.Text = "";
            }

        }

        /// <summary>
        /// Проверка текста в текстовом поле количества рабочих часов на допустимые символы.
        /// Удаление всех недопустимых символов.
        /// </summary>
        private void WorkHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(WorkHoursTextBox.Text) <= 0)
                    throw new Exception();
            }
            catch
            {
                WorkHoursTextBox.Text = "";
            }
        }

        /// <summary>
        /// Проверка текста в текстовом поле размера премии на допустимые символы.
        /// Удаление всех недопустимых символов.
        /// </summary>
        private void PremiumTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(PremiumTextBox.Text) <= 0)
                    throw new Exception();
            }
            catch
            {
                PremiumTextBox.Text = "";
            }
        }

        /// <summary>
        /// Заполнение текстовых полей данными указанного сотрудника при открытии окна.
        /// </summary>
        private void EmployeeEditForm_Activated(object sender, EventArgs e)
        {
            Employee = new Employee();
            EmployeeMenuForm.GetForm.Employees.Remove(Employee);
            var row = EmployeeMenuForm.GetForm.SelectedRow;
            var cells = row.Cells;
            FullNameTextBox.Text = cells["FullName"].Value.ToString();
            PositionTextBox.Text = cells["Position"].Value.ToString();
            HourlyPaymentTextBox.Text = cells["HourlyPayment"].Value.ToString();
            WorkHoursTextBox.Text = cells["WorkingHours"].Value.ToString();
            PremiumTextBox.Text = cells["PremiumValue"].Value.ToString();
        }
    }
}