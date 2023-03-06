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
    public partial class Reset_password : Form
    {
        
        public Reset_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_id=Convert.ToInt32(textBox1.Text);
            string passwrd = textBox2.Text;
            USER_DETAILS u = new USER_DETAILS();
            login_dictionary ld = new login_dictionary();
            foreach (USER_DETAILS item in login_dictionary.user_list)
            {
                if (user_id == item.User_id)
                {
                    u = ld.Get_account(item);
                }
            }
            login_dictionary user_dtnry = new login_dictionary();
            USER_DETAILS ud = new USER_DETAILS(user_id,u.Username,u.Age,u.E_mail,passwrd,u.Gender,u.Activation);
            user_dtnry.resetpasswrd(ud);

            //MessageBox.Show();
        }
    }
}
