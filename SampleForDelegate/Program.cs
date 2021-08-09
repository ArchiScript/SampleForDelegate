using System;

namespace SampleForDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            var messageHandler = new BankAccount.AccountMessageHandler(SendMessage);
           
            messageHandler += SendRedMessage;

            bankAccount.DelegateRegister(messageHandler);
            bankAccount.Add(100);
            //------------
            var test = new Test();
            for (int i = 0; i < 10; i++)
            {
                test.Devide(10, i);
            }
            
            }


        public static void SendRedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SendMessage(string message)
        {

            Console.ResetColor();
        }
    }
}
