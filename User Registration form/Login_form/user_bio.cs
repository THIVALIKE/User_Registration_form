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
    public partial class user_bio : Form
    {
        public user_bio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //USER_DETAILS u = new USER_DETAILS();
            //label1.Text = u.ToString();
            //login_dictionary l = new login_dictionary();
            //l.get_account(u);
        }

        private void user_bio_Load(object sender, EventArgs e)
        {
            USER_DETAILS u = new USER_DETAILS();
            login_dictionary l = new login_dictionary();
            
            foreach (var item in login_dictionary.user_list)
            {
                if (item.Username == Form1.name && item.Password == Form1.password)
                {
                    label1.Text = item.ToString();
                }
            }
        }
    }
}
