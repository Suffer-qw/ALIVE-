using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Flyweight
{

    /*
     * 
     * Назначение:
     * Паттерн "Легковес" позволяет эффективно работать с большим количеством объектов,
     * разделяя общее состояние между ними вместо хранения одинаковых данных в каждом объекте.
     * Это помогает экономить память.
     * 
     * Когда использовать:
     * 
     * Когда в приложении создается много объектов, часть которых можно сделать общими.
     * 
     * Когда память является критическим ресурсом.
     * 
     */

    public class HeroType
    {
        public string Name { get; set; }
        public ConsoleColor Color { get; set; }

        public HeroType(string name, ConsoleColor color)
        {
            this.Name = name;
            this.Color = color;
        }

        public void Spawn(int x, int y) => Console.WriteLine($"spawn {Name} command {Color} in {x}, {y}");

    }

    public class HeroFactroy
    {
        public static Dictionary<string, HeroType> Army = new Dictionary<string, HeroType>();

        public HeroType GetHero(string name, ConsoleColor color)
        {
            string key = $"{name}_{color}";
            if (!Army.ContainsKey(key) )
            {
                Army[key] = new HeroType(name,color);
                Console.WriteLine($"new hero {name} {color}");
            }
            return Army[key];
        }
    }
    public class Hero
    {
        public int _x;
        public int _y;

        public HeroType _hero;

        public Hero(int x, int y, HeroType hero)
        {
            _x = x; _y = y; _hero = hero;
        }

        public void Spawn()
        {
            _hero.Spawn( _x, _y );
        }
    
    }

    internal class Program
    {
        static void Main(string[] args)
        {


            HeroFactroy herofact = new HeroFactroy();

            List<Hero> list = new List<Hero>();
            for(int i = 0; i < 100; i++)
            {
                HeroType type = (i < 50) ? herofact.GetHero("Warrior", ConsoleColor.Red) : herofact.GetHero("Wizard", ConsoleColor.Blue);
                if (i == 62)
                    Console.WriteLine();
                list.Add(new Hero(i,i*2 ,type));
            }
            foreach (Hero hero in list)
            {
                hero.Spawn();
            }
            Console.WriteLine($"count { HeroFactroy.Army.Count()}");

        }
    }
}
