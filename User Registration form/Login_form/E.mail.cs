using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using User_Registration_form;

namespace Login_form
{
    public partial class FORGOT_PASSWORD : Form
    {
        string Randomcode;
        public static string To;

        public FORGOT_PASSWORD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              string from, pass, messagebody;
            Random rand = new Random();
            Randomcode = (rand.Next(999999)).ToString();
            MailMessage msg = new MailMessage();
            To = (textBox1.Text).ToString();
            from = "thivajm007@gmail.com";
            pass = "zvdy uhff kjup jfdj";
            messagebody = "your reset code is" + Randomcode;
            msg.To.Add(To);
            msg.From = new MailAddress(from);
            msg.Body = messagebody;
            msg.Subject = "password reseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port=587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
             smtp.Send(msg);
             MessageBox.Show("Code Send Sucessfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }
         
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (Randomcode == (textBox2.Text).ToString())
            {
                To = textBox1.Text;
                Reset_password Rp = new Reset_password();
                this.Hide();
                Rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong code is generated");
            }
        }
        
    }
}
