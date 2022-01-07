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
    /// Справка.
    /// </summary>
    public partial class HelpForm : Form
    {
        /// <summary>
        /// Поле, которое сохраняет данное окно.
        /// </summary>
        private static HelpForm inst;

        /// <summary>
        /// Свойство, которое позволяет получить данное окно.
        /// </summary>
        public static HelpForm GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new HelpForm();
                return inst;
            }
        }

        /// <summary>
        /// Инициализация окна справки.
        /// </summary>
        public HelpForm()
        {
            InitializeComponent();
        }
    }
}