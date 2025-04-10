using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{

    /*
     * Фабричный метод (Factory Method) — это порождающий паттерн проектирования, который определяет общий интерфейс для создания объектов в суперклассе,
     * позволяя подклассам изменять тип создаваемых объектов.
     * 
     * Паттерн предлагает создавать объекты не напрямую (используя оператор new),
     * а через вызов особого фабричного метода. Это позволяет подклассам изменять тип создаваемых объектов.
     * 
     */
    public class Charter
    {
        public string CharClass;
        public int hp;
        public int att;
        public void Info() => Console.WriteLine($" класс:{CharClass}\n хп:{hp}\n аттака:{att}\n\n");
    }

    public class Warrior : Charter
    {
        public Warrior()
        {
            CharClass = "воин";
            hp = 100;  
            att = 15;   
        }
    }

    public class Wizard : Charter
    {
        public Wizard()
        {
            CharClass = "маг";
            hp = 50;
            att = 45;
        }
    }

    //Главный кусок кода
    public abstract class CharterCreator
    {
        public abstract Charter CreateCharter();
        public void Create()
        {
            Charter tmp = CreateCharter();
            tmp.Info();
        }
    }

    public class WarriorCreate : CharterCreator
    {
        public override Charter CreateCharter() => new Warrior();
    }

    public class WizardCreate : CharterCreator
    {
        public override Charter CreateCharter() => new Wizard();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CharterCreator creator = new WarriorCreate();
            creator.Create();
            creator = new WizardCreate();
            creator.Create();
        }
    }
}
