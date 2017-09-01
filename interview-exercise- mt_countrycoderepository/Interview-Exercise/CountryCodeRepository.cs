
using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview_Exercise
{


   /// <summary>
   /// Reposiotry  
   /// </summary>
    public class CountryCodeRepository: ICountry
    {

        public List<Country> lstCountries;
        public CountryCodeRepository()
        {

            lstCountries= new List<Country>()
            {
                new Country(){ Id="USA", Description="United States" },
                new Country(){ Id="UK", Description="United KingDom" },
                new Country(){ Id="IND", Description="India" },
                new Country(){ Id="AUS", Description="Australia" },
            };
        }
        public List<Country> GetAllCountry()
        {
            //Create DataContext Class object
            //CountryEntities dbcontext=new CountryEntities();
            //Linq query to query to database to get country objects
            //var countrylist= from country in dbcontext.Countries
            //select Country;
            //return countryList;

            //Hard coded values without database

            return lstCountries;


        }

        public bool Add(Country countobj)
        {

            //Create DataContext Class object
            //CountryEntities dbcontext=new CountryEntities();
            //Linq query to query to database to get country objects
            //dbcontext.countries.Add(countryobj);
            //dbcontext.savechanges();
            //return true/false
            //Hardcoded values without database
            lstCountries.Add(countobj);

            return true;

        }

        public bool Delete(string cntryId)
        {
            //Create DataContext Class object
            //CountryEntities dbcontext=new CountryEntities();
            //Linq query to find object from databse based on countryid
            //var countryobj=(from country in dbcontext.Countries
            //select country).FirstOrDefault();
            //dbcontext.countries.Remove(countryobj);
            //dbcontext.savechanges();

            //Hardcoded values without database
            lstCountries.RemoveAll(a => a.Id == cntryId);
            return true;
        }

        

    }
}
