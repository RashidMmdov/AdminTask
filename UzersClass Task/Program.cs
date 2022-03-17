using System;

namespace UzersClass_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("UserName:");
            string username = Convert.ToString(Console.ReadLine());
            Console.Write("PassWord:");
            string password = Convert.ToString(Console.ReadLine());
            Console.WriteLine("--------------------");
            User user = new User(username, password);


            bool TempAdmin = true;

            if (user.UserName== username  && user.PassWord==password)
            {
               TempAdmin = true;
            }
            else
            {
                TempAdmin = false;
            }
            Admin admin = new Admin("DeBuger", TempAdmin, username, password);
            admin.FullInfo();



        }
    }
}
