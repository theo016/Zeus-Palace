using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                this.Hide();
                Form4 form = new Form4();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                //Form4 form = new Form4();
                //form.ShowDialog();
            }

            }
        }
}
