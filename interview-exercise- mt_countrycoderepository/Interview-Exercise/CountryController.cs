using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Exercise
{
    //UI 
    public class CountryController
    {

        public ICountry icountryrepobj;

        //Construcotr interface injection using UNITY
        public CountryController(ICountry icountryrepobj2)
        {

            icountryrepobj = icountryrepobj2;

        }

        public List<Country> GetAllCountries()
        {
            var countryList = icountryrepobj.GetAllCountry();
            return countryList;

        }

        public bool Add(Country cntobj)
        {
            
            var result= icountryrepobj.Add(cntobj);

            return result;

        }

        public bool Delete(string countryid)
        {

            var result = icountryrepobj.Delete(countryid);

            return result;

        }


    }


}
