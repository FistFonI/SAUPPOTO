using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUPPOTO
{
    class Salary
    {
        private decimal hourlyPayValue; //размер почасовой оплаты труда
        public decimal HourlyPayValue //свойство для поля hourlyPayValue
        {
            get { return hourlyPayValue; }
            set
            {
                if (value > 0)
                    hourlyPayValue = value;
                else throw new ArgumentException("Размер почасовой оплаты труда должен быть больше 0.");
            }
        }

        private decimal premiumValue; //размер премии
        public decimal PremiumValue //свойство для поля premiumValue
        {
            get { return premiumValue; }
            set
            {
                if (value > 0)
                    premiumValue = value;
                else throw new ArgumentException("Размер премии должен быть больше 0.");
            }
        }

        private int workingHours; //количество рабочих часов в месяц
        public int WorkingHours //свойство для поля workingHours
        {
            get { return workingHours; }
            set
            {
                if (value > 0)
                    workingHours = value;
                else throw new ArgumentException("Количество рабочих часов должно быть больше 0.");
            }
        }

        public decimal SalaryValue //свойство размера зарплаты, которое только возвращает значение по формуле: размер почасовой оплаты труда * кол-во рабочих часов + размер премии
        {
            get { return hourlyPayValue * workingHours + premiumValue; }
        }
    }
}
