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
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string name = textBox1.Text;
            //string age = textBox2.Text;
            //string email = textBox3.Text;
            //string password = textBox4.Text;
            //Gender gender=Enum.parse(textBox5.Text);

            USER_DETAILS u = new USER_DETAILS(login_dictionary.get_id()+1,textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,(Gender)Enum.Parse(typeof(Gender),comboBox1.Text),(User_Activation)Enum.Parse(typeof(User_Activation),comboBox2.Text));
            login_dictionary.write_method(u);
            MessageBox.Show("ADDING SUCESSFULLY");
           
        }
    }
}
