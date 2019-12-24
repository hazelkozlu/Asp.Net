using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager(12);
            //customerManager.List();
            Product product = new Product { Id = 1, Name = "hazelkozlu" };
            Console.WriteLine("{0}", product.Name);
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
            PersonManeger personManeger = new PersonManeger("Hazel Hakan Bozcu");
            personManeger.Add();
            Console.ReadLine();
        }
        class CustomerManager
        {
            //ctor tab a iki kez tıkla constructor oluşrutdum
            //private bir field _count mesela bir değişken tanımladım
            private int _count = 25;
            //parantez içindeki parametre ile constructor a parametre gönderdim.
            //bir sınıfın ihtiyaç duyduğu parametreleri constructor ile set ettim.
            public CustomerManager(int count)
            {
                //değişkenime parametreden gelen değeri atadım.
                _count = count;
            }
            public CustomerManager()
            {

            }
            //bunlar normal method listeleme metodu
            public void List()
            {
                Console.WriteLine("Listed {0} items", _count);
            }
            //bunlar normal method ekleme metodu
            public void Add()
            {
                Console.WriteLine("Added!");
            }
        }
        class Product
        {
            //Constructor ctor tab tab
            public Product()
            {

            }
            private int _id;
            private string _name;
            public Product(int id, string name)
            {
                _id = id;
                _name = name;

            }
            //prop tab tab property özellik tanımlar.bu özellikleri sınıftan nesne üretip, paramete
            //gönderirken kullanıyorum
            public int Id { get; set; }
            public string Name
            {

                get { return _name; }
                set { _name = value.ToUpper(); }
            }

        }
        interface ILogger
        {
            void Log();
        }
        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to Database!");
            }

        }
        class SmsLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to Sms!");
            }

        }
        class EmployeeManager
        {
            private ILogger _logger;
            public EmployeeManager(ILogger logger)
            {
                _logger = logger;
            }
            public void Add()
            {
                _logger.Log();
                Console.WriteLine("Added!");
            }
        }

        class BaseClass
        {
            private string _entity;
            public BaseClass(string entity)
            {
                _entity = entity;
            }
            public void Message()
            {
                Console.WriteLine("{0} Message",_entity);
            }

        }
        class PersonManeger : BaseClass
        {
            public PersonManeger(string entity):base(entity)
            {

            }
            public void Add()
            {
                Message();
                Console.WriteLine("constructor example");
              
            }
        }
             

    }
}
