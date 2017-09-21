using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupportLibrary;
namespace UIConsoel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Constraints> constraints = DataSource.GetInformation();
                SearchData.AddUpdateLuceneIndex(constraints);
                Console.WriteLine("Enter the Search Result");
                List<Constraints> reply = SearchData.Search(Console.ReadLine()).ToList();
                if (reply[0] != null)
                {
                    Console.WriteLine($"ID = {reply[0].UniqueID} \n Name = {reply[0].Name} \n Type : {reply[0].Type}");
                }
                else
                {
                    Console.WriteLine("Please enter another search");
                }
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
