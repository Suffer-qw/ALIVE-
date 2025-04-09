using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Observer
{

    /*
     * Паттерн "Наблюдатель" (Observer) представляет поведенческий шаблон проектирования, который использует отношение "один ко многим".
     * В этом отношении есть один наблюдаемый объект и множество наблюдателей.
     * И при изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.
     * 
     * ++++++++
     * Уменьшает связанность между объектами.
     * Позволяет динамически добавлять и удалять наблюдателей.
     * Реализует принцип открытости/закрытости.
     * --------
     * Наблюдатели могут получать уведомления в случайном порядке.
     * Если уведомления обрабатываются долго, это может затормозить систему.
     */


    public interface IShopObserver
    {
        void Update(Product tmp);
    }

    public class Product
    {
        public string Name { get; set; }
        public int Count { get; set; }
        List<IShopObserver> _obse = new List<IShopObserver>();
        public Product(string Name, int Count) 
        {
            this.Name = Name;
            this.Count = Count;
        }
        public void Up()
        {
            Count += 10;
            Console.WriteLine($"\n////наличие up {Name} : {Count} \n");
            NotificationObs();
        }
        public void Down()
        {
            Count -= 10;
            Console.WriteLine($"\n////наличие down {Name} : {Count} \n");
            NotificationObs();
        }
        public void NewObs( IShopObserver data )
        {
            _obse.Add( data );
        }

        public void NotificationObs()
        {
            foreach (var item in _obse)
            {
                item.Update(this);
            }
        }
    }
    //Warehouse
    class Visitor : IShopObserver
    {
        public void Update(Product tmp)
        {
            if(tmp.Count > 0)
            {
                Console.WriteLine($"\nТовар {tmp.Name} появился в наличии \n");
            }
        }
    }
    class Warehouse : IShopObserver
    {
        public void Update(Product tmp)
        {
            if (tmp.Count < 3)
            {
                Console.WriteLine($"\nТовар {tmp.Name} счезает нужно пополнение \n");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product gloves = new Product("Перчатки без пальцев", 10);
            Product bear = new Product("медыедь", 2);

            Warehouse warehouse = new Warehouse();
            Visitor visitor = new Visitor();
            gloves.NewObs( visitor );
            gloves.NewObs( warehouse );

            bear.NewObs(visitor);
            bear.NewObs(warehouse);

            gloves.Up();
            bear.Up();
            bear.Down();
            gloves.Down();
            gloves.Down();
            gloves.Down();


        }
    }
}
