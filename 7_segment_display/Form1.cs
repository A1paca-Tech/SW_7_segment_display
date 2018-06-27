using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_segment_display
{
    public partial class Form1 : Form
    {

        bool[] bt_ck = new bool[7] ;

        public Form1()
        {
            InitializeComponent();
        }

        void my_reset()
        {
            Control my_reset_cont = new Control();
            for (int i = 0; i < 7; i++) {
                bt_ck[i] = false;
                my_reset_cont = (Button)this.Controls["bt_" + (i + 1)];
                my_reset_cont.Text = "";
                my_reset_cont.BackColor = Color.White;
            }   //All buttons are unchecked

            lb_show.Text = "數字：";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            my_reset();
        }

        private void bt_rand_Click(object sender, EventArgs e)
        {
            Random my_rand = new Random();
            my_reset();
            Control my_rand_cont = new Control();
            int my_rand_ck = my_rand.Next(1, 8);

            for (int i = 0; i< my_rand.Next(2, 8); i++)
            {
            alpaca_rand:
                my_rand_ck = my_rand.Next(1, 8);
                if (bt_ck[(my_rand_ck-1)] == true) { goto alpaca_rand; }
                my_set_f(my_rand_ck);
            }

            if (my_sc_f() == -1) { lb_show.Text = "數字：非數字!"; }
            else { lb_show.Text = "數字：" + my_sc_f().ToString(); }
        }

        private void bt_sc_Click(object sender, EventArgs e)
        {
            if(my_sc_f() == -1) { lb_show.Text = "數字：非數字!"; }
            else { lb_show.Text = "數字：" + my_sc_f().ToString(); }
        }

        void my_set_f(int bt_num)
        {
            try
            {
                Control my_cont = new Control();
                my_cont = (Button)this.Controls["bt_" + bt_num];

                if(bt_ck[bt_num - 1] == true) { bt_ck[bt_num - 1] = false; my_cont.BackColor = Color.White; }
                else { bt_ck[bt_num - 1] = true; my_cont.BackColor = Color.Black; }
            }
            catch { MessageBox.Show("Error!", "Error!"); }
            
        }

        int my_sc_f()
        {
            int my_num = -1;
            string my_sc="";

            for (int i=0; i<7; i++)
            {
                if (bt_ck[i] == true) { my_sc += "1"; }
                else { my_sc += "0"; }
            }

            switch (my_sc)
            {
                case "1111110":     //0
                    my_num = 0; break;

                case "0110000":     //1
                case "0000110":
                    my_num = 1; break;

                case "1101101":     //2
                    my_num = 2; break;

                case "1111001":     //3
                    my_num = 3; break;

                case "0110011":     //4
                    my_num = 4; break;

                case "1011011":     //5
                    my_num = 5; break;

                case "1011111":     //6
                case "0011111":
                    my_num = 6; break;

                case "1110000":     //7
                    my_num = 7; break;

                case "1111111":     //8
                    my_num = 8; break;

                case "1110011":     //9
                case "1111011":
                    my_num = 9; break;

                default:
                    my_num = -1; break;
            }

            return my_num;
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            my_set_f(1);
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            my_set_f(2);
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            my_set_f(3);
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            my_set_f(4);
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            my_set_f(5);
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            my_set_f(6);
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            my_set_f(7);
        }
    }
}
