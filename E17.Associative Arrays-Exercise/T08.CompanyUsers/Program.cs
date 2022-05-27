using System;
using System.Collections.Generic;

namespace T08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] companyInformations = input.Split(" -> ");

                string companyName = companyInformations[0];
                string employeeId = companyInformations[1];

                if (output.ContainsKey(companyName))
                {
                    if (!output[companyName].Contains(employeeId))
                    {
                        output[companyName].Add(employeeId);
                    }
                }
                else
                {
                    output.Add(companyName, new List<string>() { employeeId });
                }

                input = Console.ReadLine();
            }

            foreach (var company in output)
            {
                Console.WriteLine(company.Key);

                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
