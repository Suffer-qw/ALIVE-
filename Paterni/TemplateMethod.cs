using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{

    /*
     * 
     * Шаблонный метод — это поведенческий паттерн проектирования, который определяет скелет алгоритма в базовом классе, 
     * позволяя подклассам переопределять некоторые шаги алгоритма, не меняя его структуру в целом.
     * 
     * 
     * Когда нужно однократно использовать инвариантную часть алгоритма, оставляя реализацию изменяющегося поведения подклассам.
     * 
     * Когда нужно вынести общее поведение в базовый класс, чтобы избежать дублирования кода.
     */

    public abstract class Game
    {
        public abstract void Start();

        public void Playing() => Console.WriteLine("игра идёт 2 часа\n") ;
        public abstract void End();

        public void Play()
        {
            Start();
            Playing();
            End();
        }

    }

    public class Socccer : Game
    {
        public override void End() => Console.WriteLine("https://youtu.be/7ai8YX2y1Rw?si=Eucdx9XV0mio4O1C\n");
        public override void Start() => Console.WriteLine("хз челы стоят втыкают\n");
    }

    public class Chess : Game
    {
        public override void End() => Console.WriteLine("теперь можно и в доту\n");
        public override void Start() => Console.WriteLine("сидят руки жмут\n");
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Socccer socccer = new Socccer();
            socccer.Play();
            Console.WriteLine("\n");

            Chess chess = new Chess();
            chess.Play();
            Console.WriteLine("\n");
        }
    }
}
