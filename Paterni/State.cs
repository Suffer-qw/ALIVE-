using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Threading;

namespace State
{
    /*
     * Состояние (State) - шаблон проектирования, который позволяет объекту изменять свое поведение в зависимости от внутреннего состояния.
     * (и немного таймера)
     * Когда поведение объекта должно зависеть от его состояния и может изменяться динамически во время 
     * Когда в коде методов объекта используются многочисленные условные конструкции, выбор которых зависит от текущего состояния объекта
     */

    public interface Color
    {
        void changeColor(TrafficLight item);
        void WhyColor(TrafficLight item);
    }


    public class TrafficLight
    {
        public Color Liht = new RedColor();
        public int time = 0;


        public void Work()
        {
            while (true)
            {
                switch (time)
                {
                    case 0:
                        Liht.changeColor(this);
                        break;
                    case 10:
                        Liht.changeColor(this);
                        break;
                    case 12:
                        Liht.changeColor(this);
                        break;
                    case 18:
                        time = -1;
                        break;
                }
                time++;
                Liht.WhyColor(this);
                Thread.Sleep(100);
            }
        }
    }

    public class GreenColor : Color
    {
        public void WhyColor(TrafficLight item)
        {
            Console.WriteLine($"сейчас Зелёный {item.time}");
        }
        public void changeColor(TrafficLight item)
        {
            item.Liht = new YelloColor();
        }
    }

    public class YelloColor : Color
    {
        public void WhyColor(TrafficLight item)
        {
            Console.WriteLine($"сейчас Жёлтый {item.time}");
        }
        public void changeColor(TrafficLight item)
        {
            item.Liht = new RedColor();
        }
    }
    public class RedColor : Color
    {
        public void WhyColor(TrafficLight item)
        {
            Console.WriteLine($"сейчас Красный {item.time}");
        }
        public void changeColor(TrafficLight item)
        {
            item.Liht = new GreenColor();

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight svetofor = new TrafficLight();
            svetofor.Work();
        }
    }
}
