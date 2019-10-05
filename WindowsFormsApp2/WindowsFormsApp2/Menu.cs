using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            Login login = new Login();
            login.ShowDialog();

            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Fail_prod fail = new Fail_prod();               //생성자 함수로 fail만듬
            fail.Show();                                        // Show 함수 불러옴
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Finish_m fin = new Finish_m();
            fin.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Line line = new Line();
            line.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Lot_direct model = new Lot_direct();
            model.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_set M1 = new User_set();
            M1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Model_set M2 = new Model_set();
            M2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User_set login = new User_set();
            login.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Model_set mo2 = new Model_set();
            mo2.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
