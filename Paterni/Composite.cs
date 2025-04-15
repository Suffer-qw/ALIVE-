using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{

    public abstract class File
    {
        public string Name { get; set; }

        public virtual void View() => Console.WriteLine($"${this.Name}");
    }

    public class FilePro : File
    {
        public FilePro(string name) => this.Name = name;

        public void Function()
        {
            this.Name += "PRO";
            this.View();
        }
    }
    public class Folder : File
    {
        List<File> files;

        public Folder(string name)
        {
            files = new List<File>();
            this.Name = name;
        }

        public void Add(File file)
        {
            files.Add(file);
        }
        public void open(Folder file)
        {

            Console.WriteLine($"--{file.Name}--");
            Console.WriteLine("--------");
            file.All();
            Console.WriteLine("--------");
        }

        public void All()
        {
            foreach (File file in files)
            {

                file.View();
                if (file is Folder d3)
                    d3.open(d3);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var file = new FilePro("one");
            var file2 = new FilePro("two");
            var file3 = new FilePro("tri");
            var file4 = new FilePro("four");
            var file5 = new FilePro("five");
            var file6 = new FilePro("six");

            var filder = new Folder("main");

            var filder2 = new Folder("side");

            filder.Add(file);
            filder.Add(file2);
            filder.Add(file3);
            filder.Add(filder2);
            filder2.Add(file4);
            filder2.Add(file5);
            filder.Add(file6);

            filder.All();
        }
    }
}
