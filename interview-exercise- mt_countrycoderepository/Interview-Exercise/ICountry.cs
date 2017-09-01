using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Exercise
{
    /// <summary> 
    /// To Perfom CRUD operation on Country table .
    /// </summary>
    public interface ICountry
    {
        List<Country> GetAllCountry();
        bool Add(Country countobj);

        bool Delete(string cntryId);

    }
}
