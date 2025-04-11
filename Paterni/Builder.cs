using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    /*
     * Паттерн "Строитель" — это порождающий паттерн проектирования, который позволяет создавать сложные объекты пошагово. 
     * Он отделяет конструирование объекта от его представления, 
     * чтобы один и тот же процесс конструирования мог создавать разные представления.
     * 
     */

    public class Hero
    {
        public int Hp {  get; set; } = 0;
        public int Attack { get; set; } = 0;

        public List<string> wapons;

        public Hero() => wapons = new List<string>();

        public void Who()
        {
            Console.WriteLine($"" +
                $"hp: {this.Hp}\n" +
                $"attack: {this.Attack}\n" +
                $"wapons: {string.Join(",", this.wapons)}");
        }
    }

    public class Herobulder
    {
        Hero _hero = new Hero();

        public Herobulder att(int a)
        {
            _hero.Attack = a;
            return this;
        }

        public Herobulder hp(int a)
        {
            _hero.Hp = a;
            return this;
        }

        public Herobulder Wap(string a)
        {
            _hero.wapons.Add(a);
            return this;
        }
        public Hero buld()
        {
            return _hero;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Hero hero = new Herobulder()
              .hp(20)
              .Wap("меч")
              .Wap("sword")
              .buld();

            hero.Who();

        }
    }
}
