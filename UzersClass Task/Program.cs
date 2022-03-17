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
            //User user = new User(username, password);
            //Console.WriteLine($"UserName: { user.UserName}");
            //Console.WriteLine($"PassWord: {user.PassWord}");
            Admin admin = new Admin("DeBuger", username, password);
            //Console.WriteLine($"UserName: { admin.UserName}");
            //Console.WriteLine($"PassWord: {admin.PassWord}");
            //Console.WriteLine($"Section: {admin.Section}");
            admin.Info();

        }
    }
}
