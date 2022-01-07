using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUPPOTO
{
    /// <summary>
    /// Зарплата.
    /// </summary>
    public class Salary
    {
        /// <summary>
        /// Размер почасовой оплаты труда.
        /// </summary>
        private decimal hourlyPayValue;

        /// <summary>
        /// Свойство для поля почасовой оплаты труда.
        /// </summary>  
        /// <exception cref="ArgumentException">Размер почасовой оплаты труда должен быть больше 0</exception>
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

        /// <summary>
        /// Размер премии.
        /// </summary> 
        private decimal premiumValue;

        /// <summary>
        /// Свойство для размера премии.
        /// </summary> 
        /// /// <exception cref="ArgumentException">Размер премии должен быть больше 0</exception>
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

        /// <summary>
        /// Количество рабочих часов в месяц.
        /// </summary> 
        private int workingHours;

        /// <summary>
        /// Свойство для поля количества рабочих часов в месяц.
        /// </summary> 
        /// /// /// <exception cref="ArgumentException">Количество рабочих часов должно быть больше 0</exception>
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

        /// <summary>
        /// Возвращает зарплату размером: размер почасовой оплаты труда * кол-во рабочих часов + размер премии.
        /// </summary> 
        public decimal SalaryValue 
        {
            get { return hourlyPayValue * workingHours + premiumValue; }
        }
    }
}