using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForDelegate
{
   public class BankAccount
    {

        public delegate void AccountMessageHandler(string message);
        public int Sum { get; private set; }

        private AccountMessageHandler _messageHandler;

        public void DelegateRegister(AccountMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }


        //int _sum; пример внутреннего объявления поля
        public void Add(int sum)
        {
            Sum = Sum + sum;
            _messageHandler.Invoke($"На ваш счет пришла {sum}");
            
        }
    }
}
