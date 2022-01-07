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
    public partial class Form3 : Form
    {
        public int A1 = 0;
        public Form3()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(82, 183, 139);
        }


        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* if (A1 == 0)
            {
                var form = new Form4();
                A1++;
                form.Show();
            }
            else
            {
                Form ifrm = Application.OpenForms[3];
                ifrm.Show();
            }
            this.Visible = false;*/
        }
    }
}
