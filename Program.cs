using System.Windows.Forms;

namespace Cockfight_Betting_System
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Keeping the old methods for future reference or expansion
        static void Jumpstart()
        {
            do // Simple Menu must convert to UI
            {
                Console.WriteLine("1. Login Bettor\n" +
                "2. Register Bettor\n" +
                "3. Exit\n" +
                "Enter Choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Login();
                    break;
                    case "2":
                        Register();
                    break;
                    case "3":
                        Environment.Exit(0);
                    break;
                    default:
                        Console.WriteLine("Please enter a valid input!");
                    break;
                }

            } while(true);
        }

        static void Login()
        {
            //Login here
        }

        static void Register()
        {
            //Register here
        }
    }
}

