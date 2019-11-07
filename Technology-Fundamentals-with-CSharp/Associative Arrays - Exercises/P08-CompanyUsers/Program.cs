namespace P08_CompanyUsers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "End")
                {
                    companies = companies
                        .OrderBy(x => x.Key)
                        .ToDictionary(x => x.Key, x => x.Value);

                    foreach (var course in companies)
                    {
                        Console.WriteLine(course.Key);

                        for (int i = 0; i < course.Value.Count; i++)
                        {
                            Console.WriteLine($"-- " + course.Value[i]);
                        }
                    }

                    break;
                }

                string currentCompany = input[0];
                string currentEmployee = input[1];

                if (!companies.ContainsKey(currentCompany))
                {
                    companies[currentCompany] = new List<string>();
                }

                if (!companies[currentCompany].Contains(currentEmployee))
                {
                    companies[currentCompany].Add(currentEmployee);
                }
            }
        }
    }
}
