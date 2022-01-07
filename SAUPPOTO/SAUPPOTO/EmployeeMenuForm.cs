using MySql.Data.MySqlClient;
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
    /// Окно меню сотрудников.
    /// </summary>
    public partial class EmployeeMenuForm : Form
    {
        /// <summary>
        /// Список сотрудников.
        /// </summary>
        /// 
        public List<Employee> Employees;

        /// <summary>
        /// Выбранная в таблице строка.
        /// </summary>
        public DataGridViewRow SelectedRow;

        /// <summary>
        /// Поле, которое сохраняет данное окно.
        /// </summary>
        private static EmployeeMenuForm inst;

        /// <summary>
        /// Свойство, которое позволяет получить данное окно.
        /// </summary>
        public static EmployeeMenuForm GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new EmployeeMenuForm();
                return inst;
            }
        }

        /// <summary>
        /// Получение информации из базы данных и занесение её в список сотрудников.
        /// </summary>
        public void RetrievingDataFromDatabase()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM employees", db.GetConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                var s = new Employee();
                s.ID = Guid.Parse(row["ID"].ToString());
                s.FullName = row["FullName"].ToString();
                s.Position = row["Position"].ToString();
                s.Salary.HourlyPayValue = decimal.Parse(row["HourlyPayValue"].ToString());
                s.Salary.PremiumValue = decimal.Parse(row["PremiumValue"].ToString());
                s.Salary.WorkingHours= int.Parse(row["WorkingHours"].ToString());
                Employees.Add(s);
            }
        }

        /// <summary>
        /// Загрузка информации из списка сотрудников в базу данных.
        /// </summary>
        public void LoadingDataIntoDatabase()
        {
            DataBase db = new DataBase();
            MySqlCommand command2 = new MySqlCommand("DELETE FROM employees ", db.GetConnection());
            db.OpenConnection();
            command2.ExecuteNonQuery();
            db.CloseConnection();
            foreach (var c in Employees)
            {
                db.OpenConnection();
                MySqlCommand command = new MySqlCommand("", db.GetConnection());
                command.CommandText = ("INSERT INTO `employees` (`ID`, `FullName`, `Position`, `Salary`, `HourlyPayValue`, `PremiumValue`, `WorkingHours`) VALUES (@ID, @Fullname, @Position, @Salary, @HourlyPayValue, @PremiumValue, @WorkingHours);");
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = c.ID;
                command.Parameters.Add("@FullName", MySqlDbType.VarChar).Value = c.FullName;
                command.Parameters.Add("@Position", MySqlDbType.VarChar).Value = c.Position;
                command.Parameters.Add("@Salary", MySqlDbType.Decimal).Value = c.Salary.SalaryValue;
                command.Parameters.Add("@HourlyPayValue", MySqlDbType.Decimal).Value = c.Salary.HourlyPayValue;
                command.Parameters.Add("@PremiumValue", MySqlDbType.Decimal).Value = c.Salary.PremiumValue;
                command.Parameters.Add("@WorkingHours", MySqlDbType.Int32).Value = c.Salary.WorkingHours;
                command.ExecuteNonQuery();
                db.CloseConnection();
            }
        }

        /// <summary>
        /// Инициализация окна меню сотрудников.
        /// </summary>
        public EmployeeMenuForm()
        {
            InitializeComponent();
            Employees = new List<Employee>();
            RetrievingDataFromDatabase();
        }

        /// <summary>
        /// Отправление информации в базу данных. Закрытие приложения.
        /// </summary>
        private void EmployeeMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadingDataIntoDatabase();
            Application.Exit();
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
        /// Нажатие на кнопку «Добавить нового сотрудника».
        /// Скрытие данного окна и показ окна добавления сотрудника.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            EmployeeAddForm.GetForm.Show();
            EmployeeAddForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку «Редактировать сотрудника».
        /// Скрытие данного окна и показ окна редактирования сотрудника.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            SelectedRow = EmployeeTable.SelectedRows[0];
            EmployeeEditForm.GetForm.Show();
            EmployeeEditForm.GetForm.Location = this.Location;
            this.Hide();
        }

        /// <summary>
        /// Нажатие на кнопку «Удалить сотрудника».
        /// Удаление выделенного сотрудника из списка сотрудников и таблицы.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Employees.RemoveAt(EmployeeTable.SelectedRows[0].Index);
            EmployeeTable.Rows.RemoveAt(EmployeeTable.SelectedRows[0].Index);
        }

        /// <summary>
        /// Нажатие на кнопку «Искать».
        /// Выделение сотрудника в таблице по ФИО, указанного в текстовом поле рядом с кнопкой.
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < EmployeeTable.Rows.Count; i++)
            {
                EmployeeTable.Rows[i].Selected = false;
                if (EmployeeTable.Rows[i].Cells[1].Value.ToString().Contains(SearchTextBox.Text))
                {
                    EmployeeTable.CurrentCell = EmployeeTable.Rows[i].Cells[1];
                    EmployeeTable.Rows[i].Selected = true;
                    break;
                }
            }
        }

        /// <summary>
        /// Нумерация строк таблицы.
        /// </summary>
        private void EmployeeTable_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            object head = EmployeeTable.Rows[e.RowIndex].HeaderCell.Value;
            if (head == null || !head.Equals((e.RowIndex + 1).ToString()))
                EmployeeTable.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        /// <summary>
        /// Обновление данных в таблице при открытии окна.
        /// </summary>
        private void EmployeeMenuForm_Activated(object sender, EventArgs e)
        {
            EmployeeTable.Rows.Clear();
            foreach (var emp in Employees)
            {
                EmployeeTable.Rows.Add(emp.ID, emp.FullName, emp.Position, emp.Salary.HourlyPayValue, 
                    emp.Salary.WorkingHours, emp.Salary.PremiumValue, emp.Salary.SalaryValue);
            }
        }
    }
}