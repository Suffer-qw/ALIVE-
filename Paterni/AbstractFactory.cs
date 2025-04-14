using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    /*
     * Абстрактная фабрика — это порождающий паттерн проектирования, который позволяет создавать семейства связанных объектов, 
     * не привязываясь к конкретным классам этих объектов.
     * 
     * Когда система не должна зависеть от способа создания и компоновки новых объектов
     * 
     * Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными
     */


    public interface IButton
    {
        void Clic();
    }

    public interface ITextFilder
    {
        void PrintText();
    }

    public class MacButton : IButton
    {
        public void Clic() => Console.WriteLine("Красивая скругдённая кнопка");
    }

    public class MacTextFilder : ITextFilder
    {
        public void PrintText() => Console.WriteLine("тоже типкрасивый текс");
    }

    public class WinButton : IButton
    {
        public void Clic() => Console.WriteLine("не красивая кнопка с острыми углами");
    }

    public class WinTextFilder : ITextFilder
    {
        public void PrintText() => Console.WriteLine("типикал шрифт ок");
    }

    public interface IUIElement
    {
        IButton CreateButton();
        ITextFilder CreateFilder();
    }

    public class MacFactory : IUIElement
    {
        public IButton CreateButton() => new MacButton();

        public ITextFilder CreateFilder() => new MacTextFilder();
    }

    public class WinFactory : IUIElement
    {
        public IButton CreateButton() => new WinButton();

        public ITextFilder CreateFilder() => new WinTextFilder();
    }

    public class AbsolutleFactory
    {
        public IButton _button;
        public ITextFilder _textFilder;

        public AbsolutleFactory( IUIElement UI)
        {
            _button = UI.CreateButton();
            _textFilder = UI.CreateFilder();
        }
       
        public void UseElemrnts()
        {
            _button.Clic();
            _textFilder.PrintText();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MacFactory factory = new MacFactory();

            AbsolutleFactory abs = new AbsolutleFactory(factory);

            abs.UseElemrnts();

            factory = null;

            Console.WriteLine("\n");

            WinFactory Winfact = new WinFactory();

            AbsolutleFactory Winabs = new AbsolutleFactory(Winfact);

            Winabs.UseElemrnts();

        }
    }
}
