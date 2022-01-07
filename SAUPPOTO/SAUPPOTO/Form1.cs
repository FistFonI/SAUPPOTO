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
    public partial class MainForm : Form
    {
       
        

            public int A1 = 0;
            public int A2 = 0;

            public MainForm()
            {
                InitializeComponent();
                this.BackColor = Color.FromArgb(82, 183, 139);
            }

            private void button1_Click(object sender, EventArgs e)
            {

                if (A1 == 0)
                {
                    var form1 = new Form3();
                    A1++;
                    form1.Show();

                }

                else
                {
                    var form3 = Application.OpenForms[1];
                    form3.Show();
                }

                this.Hide();
            }



            



            private void button2_Click_1(object sender, EventArgs e)
            {

                if (A2 == 0)
                {
                    var form1 = new Form2();
                    A2++;
                    form1.Show();

                }

                else
                {
                    var form3 = Application.OpenForms[2];
                    form3.Show();
                }
                this.Hide();
            }


        


    }
}
