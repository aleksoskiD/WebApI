using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApIHomework.Models;
using RestSharp;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
           // GetAllAuthors().Wait();
            GetAuthorById().Wait();
        }

        private static async Task GetAllAuthors()
        {      
            var client = new RestClient("http://localhost:50316/");
            var request = new RestRequest("api/Authors/GetAuthors", Method.GET);
            var queryResult = client.Execute<List<Author>>(request).Data;

            if (queryResult != null)
            {
                foreach (var author in queryResult)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", author.Name, author.Surname, author.Books.Count);
                }                
            }
        }

        private static async Task GetAuthorById()
        {
            Console.WriteLine("Enter id of author");
            int id = int.Parse(Console.ReadLine());

            var client = new RestClient("http://localhost:50316/");
            var request = new RestRequest("api/Authors/GetById/" + id, Method.GET);
            var queryResult = client.Execute<Author>(request).Data;

            IRestResponse res = client.Execute(request);
            if (queryResult != null && res.StatusCode.ToString().Equals("OK"))
            {
                Console.WriteLine("{0}\t{1}\t{2}", queryResult.ID, queryResult.Name, queryResult.Surname);

                Console.ReadLine();
            }

            //Console.ReadLine();
        }
    }
}
