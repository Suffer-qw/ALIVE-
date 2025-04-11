using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{



    /*
     * Стратегия — это поведенческий паттерн проектирования, который позволяет определять семейство алгоритмов, инкапсулировать каждый из них и делать их взаимозаменяемыми. 
     * Это позволяет изменять алгоритмы независимо от клиентского кода, который их использует.
     * 
     * 
     * Преимущества:
     * 
     * Замена наследования на композицию.
     * 
     * Изоляция кода алгоритмов от основного класса.
     * 
     * Возможность динамической смены алгоритмов.
     * 
     */

    public interface ITextCase
    {
        string TextcChange(string text);
    }

    public class UpperCase : ITextCase
    {
        public string TextcChange(string text)
        {
              return text = text.ToUpper();
        }
    }
    public class LowerCase : ITextCase
    {
        public string TextcChange(string text)
        {
            return text = text.ToLower();
        }
    }

    public class TextFormatter
    {

        public ITextCase _textCase;
        public TextFormatter(ITextCase textCase) => _textCase = textCase;
        public void SetCase (ITextCase textCase) => _textCase = textCase;

        public string Strategy(string text)
        {
            return text = _textCase.TextcChange(text);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TextFormatter texteditor = new TextFormatter(new UpperCase());

            string txt = "RyTpFhjkLOPРус";

            Console.WriteLine(txt + "\n");

            txt = texteditor.Strategy(txt);

            Console.WriteLine(txt + "\n"); 

            texteditor = new TextFormatter(new LowerCase());

            txt = texteditor.Strategy(txt);

            Console.WriteLine(txt + "\n");


        }
    }
}
