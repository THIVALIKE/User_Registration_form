using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace User_Registration_form
{
    public class login_dictionary
    {
        public static Dictionary<int, USER_DETAILS> user_dic = new Dictionary<int, USER_DETAILS>();
        public static List<USER_DETAILS> user_list = new List<USER_DETAILS>();

        public static string path = "D:\\user registration\\users.txt";

        public static void Load_data()
        {
            string[] file_ctr = File.ReadAllLines(path);

            foreach (var item in file_ctr)
            {
                string[] my_user = item.Split('|');
                USER_DETAILS u = new USER_DETAILS(int.Parse(my_user[0]),my_user[1], my_user[2], my_user[3], my_user[4], (Gender)Enum.Parse(typeof(Gender), my_user[5]), (User_Activation)Enum.Parse(typeof(User_Activation), my_user[6]));
                user_dic.Add(int.Parse(my_user[0]), u);
                user_list.Add(u);
            }
        }

        public static void write_method(USER_DETAILS u)
        {
            string x = "";
            StreamWriter sr = new StreamWriter(path,append: true);
            x +=u.User_id +"|"+ u.Username + "|" + u.Age + "|" + u.E_mail + "|" + u.Password + "|" + u.Gender + "|" + u.Activation;           
                sr.WriteLine(x);
            sr.Close();
        }

        public static int get_id()
        {

            int temp = 0;
            foreach (USER_DETAILS item in user_list)
            {
                temp = item.User_id;
                
            }
            return temp;
        }

        public static string get_name()
        {
            string temb="";
            foreach (USER_DETAILS item in user_list)
            {
                temb = item.Username;
            }
            return temb;
        }

        public USER_DETAILS Get_account(USER_DETAILS u)
        {
            USER_DETAILS x = new USER_DETAILS();
            foreach (var item in user_list)
            {
                if (item.Username == u.Username && item.Password == u.Password)
                {
                    x = item;
                    break;
                }
            }
            return x;
        }

        public void resetpasswrd(USER_DETAILS u)
        {
           
            int temb =0;
            foreach (var item in user_list)
            {
                if (item.User_id==u.User_id)
                {
                    USER_DETAILS user = new USER_DETAILS(u.User_id,u.Username,u.Age,u.E_mail,u.Password,u.Gender,u.Activation);
                    user_list.RemoveAt(temb);
                    user_list.Insert(temb, user);
                    write_method(u);
                    list_to_file();
                    user_dic.Clear();
                    user_list.Clear();
                    Load_data();
                    break;
                }
                temb++;
            }
        }

        public  void list_to_file()
        {
            StreamWriter srr = new StreamWriter(path);
            foreach (USER_DETAILS item in user_list)
            {
                string user = "";
                user =item.User_id + "|" +  item.Username + "|" + item.Age + "|" + item.E_mail + "|"+ item.Password + "|" + item.Gender +"|"+ item.Activation;
                srr.WriteLine(user);
            }
            srr.Close();
        }

       }
    }
