using Country.Model;
using Country.Services;
using NPoco;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Country
{
    internal class DbCall
    {
        private string v;

        public DbCall(string v)
        {
            this.v = ConfigurationManager.ConnectionStrings["BusinessListing"].ConnectionString;
        }

        internal void InsertEntries(string item, string city)
        {
            using (IDatabase db = new Databasem(v))
            {
               
                var _city = db.FirstOrDefault<Cities>("Select * from cities where LOWER(city) = @city", new { city = city.ToLower()});

                var town = new Towns()
                {
                    CityId = _city.Id,
                    DateCreated = DateTime.Now,
                    Town =item
                };

               db.Insert<Towns>(town);
            }
        }
    }
}