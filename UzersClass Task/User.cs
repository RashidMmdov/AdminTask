using System;
using System.Collections.Generic;

using System.Text;

namespace UzersClass_Task
{
    internal class User
    {
        private string _username;
        private string _password;
        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    
                    _username = value;
                }
                else
                {
                     Console.WriteLine("UserNameni duzgun formatda daxil edin(Heriflerin sayi 6 dan cox olmalidir)...");
                    
                }
            }
        }
        public string PassWord
        {
            get
            {
                return _password;
            }
            set
            {
                
                int CheckOut = 0;
                bool FinfBigLateer = false;
                for (int i = 0; i < value.Length; i++)
                {
                    CheckOut = (int)value[i];
                    if (CheckOut >= 65 && CheckOut < 90)
                    {
                        FinfBigLateer = true;
                    }
                }
                
                bool FindNumber = false;
                for (int i = 0; i < value.Length; i++)
                {
                    CheckOut = (int)value[i];
                    if (CheckOut >= 48 && CheckOut <= 57)
                    {
                        FindNumber = true;
                    }
                }
                
                if (FinfBigLateer == true && FindNumber == true)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Minimum 1 Boyuk herf ve 1 Eded yazmaq lazimdir!!!");
                }
            }
        }

        public User(string username, string password)
        {
            UserName = username;
            PassWord = password;
        }
    }
}
