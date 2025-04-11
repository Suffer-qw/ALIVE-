using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    /*
     * Декоратор — это структурный паттерн проектирования, который позволяет динамически добавлять объектам новые функциональности, 
     * оборачивая их в специальные классы-декораторы.
     * 
     * Позволяет расширять поведение объектов без изменения их кода.
     * 
     * Альтернатива наследованию, но с большей гибкостью.
     * 
     * Декораторы имеют тот же интерфейс, что и исходный объект, поэтому клиентский код не замечает разницы.
     * 
     * Можно оборачивать объекты в несколько декораторов, добавляя функциональность "слоями".
     * 
     * 
     * Недостатки:
     *  
     * Много мелких классов в коде.
     *   
     * Может усложнить чтение кода из-за вложенности декораторов.
     */

    public interface Icharter
    {
        int Attack();
        string ClassHero();
    }

    public class SimpleCharter : Icharter
    {
        public int Attack() => 10;
        public string ClassHero() => "base";
        public void All()
        {
            Console.WriteLine($"Class{this.ClassHero()}\nAttack{this.Attack()}\n\n");
        }
    }
    public abstract class CharterDecorator : Icharter
    {

        public Icharter _charter;

        public CharterDecorator(Icharter charter)
        {
            _charter = charter;
        }

        public virtual string ClassHero() => "";

        public virtual int Attack() => _charter.Attack();

    }

    public class Warrior : CharterDecorator
    {
        public Warrior(Icharter charter) : base(charter) { }

        public override int Attack() => _charter.Attack() + 90;
        public void UpAtt()
        {
            Warrior one = new Warrior(_charter);
            _charter = one;
        }
        public override string ClassHero() => ClassHero()+"Warrior";

    }

    public class Wizard : CharterDecorator
    {
        public Wizard(Icharter charter) : base(charter) { }

        public override int Attack() => _charter.Attack() + 35;

        public override string ClassHero() => "Wizard";

    }




    internal class Program
    {
        static void Main(string[] args)
        {

            SimpleCharter charter = new SimpleCharter();
            charter.All();

            Warrior warrior = new Warrior(charter);

            Warrior warriortwo = new Warrior(warrior);

            Console.WriteLine($"Class {warrior.ClassHero()}\nAttack {warrior.Attack()}\n\n");

            warrior.UpAtt();
            warrior.UpAtt();
            warrior.UpAtt();
            warrior.UpAtt();

            Console.WriteLine($"Class {warrior.ClassHero()}\nAttack {warrior.Attack()}\n\n");




        }
    }
}
