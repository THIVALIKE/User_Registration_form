using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration_form
{
    public class USER_DETAILS
    {
        int _user_id;

        public int User_id
        {
            get { return _user_id; }
            
        }

        string _username;

        public string Username
        {
            get { return _username; }
            //set { _username = value; }
        }

        string _age;

        public string Age
        {
            get { return _age; }
            //set { _age = value; }
        }

        string e_mail;

        public string E_mail
        {
            get { return e_mail; }
            //set { e_mail = value; }
        }

        string _password;

        public string Password
        {
            get { return _password; }
            //set { _password = value; }
        }

        Gender _gender;

        public Gender Gender
        {
            get { return _gender; }
            //set { _gender = value; }
        }

        User_Activation _activation;

        public User_Activation Activation
        {
            get { return _activation; }
            //set { _activation = value; }
        }

        public USER_DETAILS(int uID,string _Name,string _Age,string E_mail,string _Password,Gender _Gender,User_Activation Activation)
        {
            this._user_id = uID;
            this._username = _Name;
            this._age = _Age;
            this.e_mail = E_mail;
            this._password = _Password;
            this._gender = _Gender;
            this._activation = Activation;
        }

        public USER_DETAILS(string _name,string _passwrd)
        {
            this._username = _name;
            this._password = _passwrd;
        }

        public USER_DETAILS()
        {
            
        }

        public override string ToString()
        {
            return string.Format("UserID: {0}\n Username: {1}\n Age: {2}\n E_mail: {3}\n Gender: {4}\n Activation: {5}",this.User_id,this.Username,this.Age,this.E_mail,this.Gender,this._activation);
        }
    }

    public enum Gender
    {
        Male=0,
        Female=1
    }

    public enum User_Activation
    {
        Active=0,
        discontinued=1
    }

   
}
