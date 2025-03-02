using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            label1.BackColor = Color.Transparent;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form = new Form2();
            form.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form = new Form3();
            form.ShowDialog();

            this.Close();
        }
    }
}