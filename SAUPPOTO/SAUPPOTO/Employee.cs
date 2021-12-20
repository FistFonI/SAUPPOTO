using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUPPOTO
{
    class Employee
    {
        public Guid ID; //уникальный идентификатор сотрудника

        public string FullName; //Фамилия Имя Отчетство

        public string Position; //Должность 

        public Salary Salary; //Зарплата
    }
}
