using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
/*
 * Мост (Bridge) - структурный шаблон проектирования, который позволяет отделить абстракцию от реализации таким образом, чтобы и абстракцию, 
 * и реализацию можно было изменять независимо друг от друга
 * 
 * Даже если мы отделим абстракцию от конкретных реализаций, то у нас все равно все наследуемые классы будут жестко привязаны к интерфейсу,
 * определяемому в базовом абстрактном классе,
 * Для преодоления жестких связей и служит паттерн Мост
 * 
 * 
 */

    НЕМНОГО НЕ ПРАВИЛЬНАЯ РЕАЛТЗАЦИЯ

{
    public class lith
    {
        public bool OnOff = false;

        public string color = "белый";

        public int power = 10;
        public void Svet()
        {
            Console.WriteLine($"светит {this.color} c мощностью {this.power}");
        }
    }
    public abstract class Controller
    {
        public lith _lith;

        public Controller(lith lith) => _lith = lith;

        public void Power()
        {
            _lith.OnOff = !_lith.OnOff;
        }
    }

    public class ControllerNoob : Controller
    {
        public ControllerNoob(lith lith) : base(lith) { }

        public void UpPower(int power) => _lith.power += power;

    }

    public class ControllerPro : Controller
    {
        public ControllerPro(lith lith) : base(lith) { }

        public void Switch(string color) => _lith.color = color;

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            lith lith = new lith();

            ControllerNoob cn = new ControllerNoob(lith);
            cn.UpPower(10);
            lith.Svet();
            ControllerPro cp = new ControllerPro(lith);
            cp.Switch("красный");
            lith.Svet();
        }
    }
}
