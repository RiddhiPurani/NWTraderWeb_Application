using System;
using System.Collections.Generic;
using System.Linq;

namespace NWTradersWeb.Models
{
    public class NWTradersUtilities
    {

        private static NorthwindEntities nwEntities = new NorthwindEntities();

        public static List<string> AllCountries()
        {
            List<string> allCountries = new List<string>();
            allCountries =
                nwEntities.
                Customers.
                Select(c => c.Country).
                Distinct().
                ToList();

            return allCountries;
        }

        public static List<string> AllCompanyNames()
        {
            return nwEntities.
                Customers.
                OrderBy(c => c.CompanyName).
                Select(c => c.CompanyName).
                Distinct().
                ToList();
        }

        public static List<String> AllTitles()
        {
            List<String> allTitles = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allTitles = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.ContactTitle) == false).
                Select(c => c.ContactTitle).
                Distinct().
                ToList();

            return allTitles;
        }

        // Riddhi's code
        public static List<String> AllCities()
        {
            List<String> AllCities = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            AllCities = nwEntities.Customers.
                Select(c => c.City).
                Distinct().
                ToList();

            return AllCities;
        }

        public static List<String> AllRegion()
        {
            List<String> AllRegion = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            AllRegion = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.Region) == false).
                Select(c => c.Region).
                Distinct().
                ToList();
            return AllRegion;
        }

        /*public static List<String> AllProductName()
        {
            List<String> allProductName = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allProductName = nwEntities.Products.
                Where(c => string.IsNullOrEmpty(c.ProductName) == false).
                Select(c => c.ProductName).
                Distinct().
                ToList();

            return allProductName;
        }*/

      /*  public static List<String> AllQuantityPerUnit()
        {
            List<String> allQuantityPerUnit = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allQuantityPerUnit = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.ContactTitle) == false).
                Select(c => c.ContactTitle).
                Distinct().
                ToList();

            return allQuantityPerUnit;
        }*/

        /*public static List<String> AllUnitInStock()
        {
            List<String> allUnitInStock = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allUnitInStock = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.ContactTitle) == false).
                Select(c => c.ContactTitle).
                Distinct().
                ToList();

            return allUnitInStock;
        }*/

        /*public static List<String> AllUnitInOrder()
        {
            List<String> allUnitInOrder = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allUnitInOrder = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.ContactTitle) == false).
                Select(c => c.ContactTitle).
                Distinct().
                ToList();

            return allUnitInOrder;
        }*/

        /*public static List<String> AllReorderLevel()
        {
            List<String> allReorderLevel = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allReorderLevel = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.ContactTitle) == false).
                Select(c => c.ContactTitle).
                Distinct().
                ToList();

            return allReorderLevel;
        }*/

        public static List<String> AllProductCategory()
        {
            List<String> allProductCategory = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allProductCategory = nwEntities.Products.
                Where(c => string.IsNullOrEmpty(c.Category.Description) == false).
                Select( c => c.Category.Description).
                Distinct().
                OrderBy(category => category).
                ToList();

            return allProductCategory;
        }

        /*public static List<String> AllProductSupplier()
        {
            List<String> allProductSupplier = new List<string>();

            // From the customers table, 
            // where the contact title is not null or empty, 
            // select every contact title 
            // keep only the distinct ones 
            // then convert it to a list.
            allProductSupplier = nwEntities.Customers.
                Where(c => string.IsNullOrEmpty(c.ContactTitle) == false).
                Select(c => c.ContactTitle).
                Distinct().
                ToList();

            return allProductSupplier;
        }*/

        /// <summary>
        /// Will generate 3 or specified number of random characters
        /// </summary>
        /// <param name="length"></param>
        public static string GenerateRandomUpperCaseCharacters( int length = 3)
        {
            const string possibleCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string randomString = "";
            int randomLocation;
            char randomCharacter;

            Random random = new Random();

            // run this "length" times.
            for (int i=0; i< length; i++)
            {
                // Get a random number no bigger than the number of possible characters A .. Z
                randomLocation = random.Next(possibleCharacters.Length);

                // Get the character at the random location in possible characters.
                randomCharacter = possibleCharacters.ToCharArray()[randomLocation];

                // Attach the random character to the randomString
                randomString += randomCharacter;

                // repeat "length" times.
            }

            // And return the random string.
            return randomString;
        }

        public static List<string> itemsPerPage
        {
            get { return (new List<string> { "10", "15", "25", "50", "All" }); }
        }

    }
}
