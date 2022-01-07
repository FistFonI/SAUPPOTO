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
    /// Окно главного меню.
    /// </summary>
    public partial class MainMenuForm : Form
    {
        /// <summary>
        /// Поле, которое сохраняет данное окно.
        /// </summary>
        private static MainMenuForm inst;

        /// <summary>
        /// Свойство, которое позволяет получить данное окно.
        /// </summary>
        public static MainMenuForm GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new MainMenuForm();
                return inst;
            }
        }

        /// <summary>
        ///  Инициализация окна главного меню.
        /// </summary>
        public MainMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку «Перейти к меню сотрудников».
        /// Скрытие данного окна и показ окна меню сотрудников.
        /// </summary>
        private void EmpMenuButton_Click(object sender, EventArgs e)
        {
            EmployeeMenuForm.GetForm.Show();
            EmployeeMenuForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку «Перейти к статистике».
        /// Скрытие данного окна и показ окна статистики.
        /// </summary>
        private void StatButton_Click(object sender, EventArgs e)
        {
            StatisticForm.GetForm.Show();
            StatisticForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку «Справка».
        /// Скрытие данного окна и показ окна справки.
        /// </summary>
        private void Help_Button_Click(object sender, EventArgs e)
        {
            HelpForm.GetForm.Show();
        }

        /// <summary>
        /// Отправление информации в базу данных. Закрытие приложения.
        /// </summary>
        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeMenuForm.GetForm.LoadingDataIntoDatabase();
            Application.Exit();
        }
    }
}