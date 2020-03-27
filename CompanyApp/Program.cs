using CompanyApp.Controller;
using System;

namespace CompanyApp
{
    class Program
    {
        public void Menu()
        {
            CompanyController companyController = new CompanyController();
            Console.WriteLine("************     Welcome To Company Project  **************");
            Console.WriteLine("1. Company Handle");
            Console.WriteLine("2. Exit");
            Console.Write("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    companyController.Welcome();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            Program program= new Program();
            program.Menu();
        }
    }
}
