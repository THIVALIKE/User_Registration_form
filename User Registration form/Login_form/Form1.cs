using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Registration_form;

namespace Login_form
{
    public partial class Form1 : Form
    {
        public static string name;
        public static string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            name = textBox1.Text;
            password = textBox2.Text;

            USER_DETAILS u = new USER_DETAILS();
            login_dictionary l=new login_dictionary();
            foreach (USER_DETAILS item in login_dictionary.user_list)
            {
               
                    if (textBox1.Text == item.Username && textBox2.Text == item.Password)
                    {
                        MessageBox.Show("login sucessfully");
                        u = l.Get_account(item);

                        user_bio k = new user_bio();
                        k.Show();
                        //break;
                    }
                
            }

            MessageBox.Show("NOT");
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            FORGOT_PASSWORD f = new FORGOT_PASSWORD();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sign_up s = new Sign_up();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login_dictionary.Load_data();
        }
    }
}
