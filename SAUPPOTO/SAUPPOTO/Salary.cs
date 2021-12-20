using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUPPOTO
{
    class Salary
    {
        private decimal hourlyPayValue;
        public decimal HourlyPayValue
        {
            get { return hourlyPayValue; }
            set
            {
                if (value > 0)
                    hourlyPayValue = value;
                else throw new ArgumentException("Размер почасовой оплаты труда должен быть больше 0.");
            }
        }

        private decimal premiumValue;
        public decimal PremiumValue
        {
            get { return premiumValue; }
            set
            {
                if (value > 0)
                    premiumValue = value;
                else throw new ArgumentException("Размер премии должен быть больше 0.");
            }
        }

        private int workingHours;
        public int WorkingHours
        {
            get { return workingHours; }
            set
            {
                if (value > 0)
                    workingHours = value;
                else throw new ArgumentException("Количество рабочих часов должно быть больше 0.");
            }
        }

        public decimal SalaryValue
        {
            get { return hourlyPayValue * workingHours + premiumValue; }
        }
    }
}
