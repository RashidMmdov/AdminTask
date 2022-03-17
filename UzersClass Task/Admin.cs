using System;
using System.Collections.Generic;
using System.Text;

namespace UzersClass_Task
{
    internal class Admin : User
    {
        public bool isSuperAdmin;
        public string Section;
        public Admin(string Section, bool isSuperAdmin, string username, string password) : base(username, password)
        {
            this.Section = Section;
            this.isSuperAdmin = isSuperAdmin;
        }
        public void FullInfo()
        {
            if (isSuperAdmin == true)
            {
                Console.WriteLine($"UserName: {UserName}");
                Console.WriteLine($"PassWord: {PassWord}");
                Console.WriteLine($"Section: {Section}");
            }
            else
            {
                Console.WriteLine(UserName);

            }


        }

    }
}

