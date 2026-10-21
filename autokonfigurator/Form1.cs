using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace autokonfigurator
{
    public partial class Form1 : Form


    {

        private int osszeg = 0;
        private int alapar = 0;
        private int extras = 0;
        public Form1()
        {
            InitializeComponent();


        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int benzin = 100;
            osszeg = benzin + alapar;
            label1.Text = osszeg.ToString();
            checkBox2.Enabled = !checkBox1.Checked;
            checkBox3.Enabled = !checkBox1.Checked;
            if (!checkBox1.Checked)
            {
                label1.Text = alapar.ToString();
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.vw;
            alapar = 300;
            label1.Text = alapar.ToString();
            if (radioButton1.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.honda;
            alapar = 200;
            label1.Text = alapar.ToString();
            if (radioButton2.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.audi;
            alapar = 100;
            label1.Text = (alapar.ToString());
            if (radioButton3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int hibrid = 200;



            osszeg = hibrid + alapar;
            label1.Text = osszeg.ToString();
            checkBox1.Enabled = !checkBox2.Checked;
            checkBox3.Enabled = !checkBox2.Checked;
            label1.Text = osszeg.ToString();
            if (!checkBox2.Checked)
            {
                label1.Text = alapar.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int elektromos = 500;
            osszeg = elektromos + alapar;
            label1.Text = osszeg.ToString();
            checkBox1.Enabled = !checkBox3.Checked;
            checkBox2.Enabled = !checkBox3.Checked;
            if (!checkBox3.Checked)
            {
                label1.Text = alapar.ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            int ulesf = 300;
            extras = osszeg + ulesf;
            label1.Text = extras.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
                int klima = 700;
                extras = osszeg + klima;
                label1.Text = extras.ToString();
            


        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            int metal = 600;
            extras = osszeg + metal; 
            label1.Text = extras .ToString();
        }
    }
}