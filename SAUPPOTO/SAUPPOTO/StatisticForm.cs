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
    /// Окно статистики.
    /// </summary>
    public partial class StatisticForm : Form
    {
        /// <summary>
        /// Поле, которое сохраняет данное окно.
        /// </summary>
        private static StatisticForm inst;

        /// <summary>
        /// Свойство, которое позволяет получить данное окно.
        /// </summary>
        public static StatisticForm GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new StatisticForm();
                return inst;
            }
        }

        /// <summary>
        /// Инициализация окна главного меню.
        /// </summary>
        public StatisticForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку «Возврат в главное меню».
        /// Скрытие данного окна и показ окна главного меню.
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm.GetForm.Show();
            MainMenuForm.GetForm.StartPosition = FormStartPosition.Manual;
            MainMenuForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Отправление информации в базу данных. Закрытие приложения.
        /// </summary>
        private void StatisticForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeMenuForm.GetForm.LoadingDataIntoDatabase();
            Application.Exit();
        }

        /// <summary>
        /// Вывод количества сотрудников и общей суммы выплат.
        /// </summary>
        private void StatisticForm_Activated(object sender, EventArgs e)
        {
            EmpCountLabel.Text = EmployeeMenuForm.GetForm.Employees.Count.ToString();
            decimal sum = 0;
            foreach (var employee in EmployeeMenuForm.GetForm.Employees)
                sum += employee.Salary.SalaryValue;
            SumLabel.Text = sum.ToString();
        }
    }
}