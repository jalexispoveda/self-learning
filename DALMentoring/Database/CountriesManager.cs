using Data.Mentoring;
using Data.Mentoring.Models;
using System.Collections.Generic;
using System.Linq;

namespace DALMentoring.Database
{
    public class CountriesManager
    {
        private static readonly DataContextTest contextTest = new DataContextTest();

        public IQueryable<AspNetUser> GetCountryQueryableEquals(string Id)
        {
            IQueryable<AspNetUser> data = contextTest.AspNetUsers.Where(x => x.Id.Equals(Id) && x.Email.Equals("00DEF5E6-F085-4081-B4AE-2D81EF5405DB@mailinator.com"));
            //var prueba =  data.Take<AspNetUser>(100);
            return data;
        }

        public IEnumerable<AspNetUser> GetCountryEnumerableEquals(string Id)
        {
            IEnumerable<AspNetUser> data = contextTest.AspNetUsers.Where(x => x.Id.Equals(Id) && x.Email.Equals("00DEF5E6-F085-4081-B4AE-2D81EF5405DB@mailinator.com"));
            var prueba = data.Take<AspNetUser>(100);
            return data;
        }

        public IQueryable<AspNetUser> GetCountryQueryableNotEquals(string Id)
        {
            IQueryable<AspNetUser> data = contextTest.AspNetUsers.Where(x => x.Id.Equals(Id) && x.Email == "00DEF5E6-F085-4081-B4AE-2D81EF5405DB@mailinator.com");
            //var prueba =  data.Take<AspNetUser>(100);
            return data;
        }

        public IEnumerable<AspNetUser> GetCountryEnumerableNotEquals(string Id)
        {
            IEnumerable<AspNetUser> data = contextTest.AspNetUsers.Where(x => x.Id.Equals(Id) && x.Email == "00DEF5E6-F085-4081-B4AE-2D81EF5405DB@mailinator.com");
            var prueba = data.Take<AspNetUser>(100);
            return data;
        }

    }
}
