using System;
using System.Collections.Generic;
using System.Text;

namespace UzersClass_Task
{
    internal class Admin : User
    {
        public bool isSuperAdmin = true;
        public string Section;
        public Admin(string Section, string username, string password) : base(username, password)
        {
            this.Section = Section;
        }
        

        public void Info()
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
