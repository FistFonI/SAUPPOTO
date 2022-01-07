using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SAUPPOTO
{
    /// <summary>
    /// Сотрудник.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Уникальный идентификатор сотрудника.
        /// </summary>
        public Guid ID;

        /// <summary>
        /// Фамилия Имя Отчетство.
        /// </summary>
        public string FullName;

        /// <summary>
        /// Должность.
        /// </summary>
        public string Position;

        /// <summary>
        /// Зарплата.
        /// </summary>
        public Salary Salary;

        /// <summary>
        /// Конструктор объявления Employee.
        /// </summary>
        public Employee()
        {
            Salary = new Salary();
        }
    }
}