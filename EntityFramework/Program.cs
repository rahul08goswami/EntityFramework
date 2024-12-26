using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read 
            CustomerDBEntities context = new CustomerDBEntities();
            List<Country> countryList = context.Countries.ToList<Country>();
            //countryList.ForEach(country =>
            //{
            //    Console.WriteLine("Country Name: " + country.CountryName + " Country Code: " + country.CountryCode);
            //});

            //Insert
            //Country country1 = new Country();
            //country1.CountryName = "India";
            //country1.CountryCode = 9872;
            //context.Countries.Add(country1); //Inmemory Save
            //context.SaveChanges(); //Actual commit

            //Update
            //Country country1 = countryList.First();
            //country1.CountryName = "USA";
            //context.SaveChanges();

            //Delete
            Country country1 = countryList.Find(c => c.CountryName.Trim() == "PAK");
            context.Countries.Remove(country1);
            context.SaveChanges();

        
        }
    }
}
