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
    /// Окно добавления сотрудника.
    /// </summary>
    public partial class EmployeeAddForm : Form
    {
        /// <summary>
        /// Сотрудник.
        /// </summary>
        private Employee Employee;

        /// <summary>
        /// Поле, которое сохраняет данное окно.
        /// </summary>
        private static EmployeeAddForm inst;

        /// <summary>
        /// Свойство, которое позволяет получить данное окно.
        /// </summary>
        public static EmployeeAddForm GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new EmployeeAddForm();
                return inst;
            }
        }

        /// <summary>
        /// Инициализация окна добавления сотрудника.
        /// </summary>
        public EmployeeAddForm()
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
        /// Нажатие на кнопку «Создать». Создание сотрудника и заполнение его данных. 
        /// Добавление данного сотрудника в общий список сотрудников.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Employee = new Employee();
            Employee.ID = Guid.NewGuid();
            Employee.FullName = FullNameTextBox.Text;
            Employee.Position = PositionTextBox.Text;
            Employee.Salary.HourlyPayValue = decimal.Parse(HourlyPaymentTextBox.Text);
            Employee.Salary.WorkingHours = int.Parse(WorkHoursTextBox.Text);
            Employee.Salary.PremiumValue = decimal.Parse(PremiumTextBox.Text);
            FullNameTextBox.Text = "";
            PositionTextBox.Text = "";
            HourlyPaymentTextBox.Text = "";
            WorkHoursTextBox.Text = "";
            PremiumTextBox.Text = "";
            EmployeeMenuForm.GetForm.Employees.Add(Employee);
            EmployeeMenuForm.GetForm.Show();
            EmployeeMenuForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Отправление информации в базу данных. Закрытие приложения.
        /// </summary>
        private void EmployeeAddForm_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}