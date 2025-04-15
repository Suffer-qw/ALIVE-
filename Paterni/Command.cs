using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Command
{

    public interface ICommand
    {
        void oneCommand();

    }

    public class TextComm
    {
        public static string txt;
    }

    public class AddCommand : ICommand
    {

        public void oneCommand()
        {
            TextComm.txt = Console.ReadLine();
        }
    }
    public class RemuveCommand : ICommand
    {
        public void oneCommand()
        {
            TextComm.txt = TextComm.txt.Substring(0, TextComm.txt.Length - 1);
        }

    }

    public class ViewCommand : ICommand
    {
        public void oneCommand()
        {
            Console.WriteLine($"ваш текст {TextComm.txt}\n");
        }


    }

    public class MainEditor
    {
        ICommand _command;
        public MainEditor(ICommand command) => _command = command;

        public void SwitchCommand(ICommand command) => _command = command;

        public void OneButton() => _command.oneCommand() ;

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            ICommand addComand = new AddCommand();


            MainEditor me = new MainEditor(addComand);

            me.OneButton();

            me.SwitchCommand(new RemuveCommand());

            me.OneButton();

            MainEditor mep = new MainEditor(new ViewCommand());

            mep.OneButton();


        }
    }
}
