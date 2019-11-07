namespace P05_ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var firstLine = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < firstLine.Length; i++)
            {
                var currentPerson = firstLine[i].Split('=');
                string name = currentPerson[0];
                int money = int.Parse(currentPerson[1]);
                var bag = new List<string>();

                var person = new Person(name, money, bag);
                people.Add(person);
            }

            var secondLine = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < secondLine.Length; i++)
            {
                var currentProduct = secondLine[i].Split('=');
                string name = currentProduct[0];
                int price = int.Parse(currentProduct[1]);

                var product = new Product(name, price);
                products.Add(product);
            }

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    foreach (var person in people)
                    {
                        if (person.Bag.Count == 0)
                        {
                            Console.WriteLine($"{person.Name} - Nothing bought");
                        }

                        else
                        {
                            Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag)}");
                        }
                    }

                    break;
                }

                string personName = command[0];
                string productName = command[1];

                BuyProduct(personName, productName, people, products);
            }
        }

        public static void BuyProduct(string personName, string productName,
            List<Person> people, List<Product> products)
        {
            var person = people.Find(x => x.Name == personName);
            var product = products.Find(x => x.Name == productName);

            if (person.Money >= product.Price)
            {
                person.Money -= product.Price;
                person.Bag.Add(productName);
                Console.WriteLine($"{personName} bought {productName}");
            }

            else
            {
                Console.WriteLine($"{personName} can't afford {productName}");
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Money { get; set; }

        public List<string> Bag { get; set; }

        public Person(string name, int money, List<string> bag)
        {
            Name = name;
            Money = money;
            Bag = bag;
        }
    }

    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
