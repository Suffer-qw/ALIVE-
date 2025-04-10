using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     * Singleton — это порождающий паттерн проектирования, который гарантирует, что у класса есть только один экземпляр,
     * и предоставляет глобальную точку доступа к этому экземпляру.
     * 
     * Когда использовать?
     * 
     * Когда в системе должен быть только один экземпляр класса (например, логгер, конфигурация, подключение к БД).
     * 
     * Когда нужно контролировать доступ к общему ресурсу.
     */

    public class CashBasket
    {
        private static CashBasket _instance;

        public int Money;

        private CashBasket() 
        {
            Money = 0;
            Console.WriteLine("basket open");
        }

        public static CashBasket GetInstance()
        {
            if (_instance == null)
                _instance = new CashBasket();
            return _instance;
        }

        public void AddMoney(int num)
        {
            Money += num;
            Console.WriteLine($"Money changed: {Money}");
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {

            CashBasket one = CashBasket.GetInstance();
            one.AddMoney(100);
            one.AddMoney(200);
            CashBasket two = CashBasket.GetInstance();
            two.AddMoney(-300);

        }
    }
}
