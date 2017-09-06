using Apttus.Assignment.MovieTicket;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Apttus.MovieTicket.DAL
{
    public class DataAccessor : IDataAccessor
    {
        public List<Person> GetMembersDetails()
        {
            List<Person> personList = new List<Person>();

            string sql = "SELECT * FROM Persons";
            using (IDbConnection connection = new SqlConnection("Server=L005485;Initial Catalog=DbPerson;Integrated Security=true;"))
            {
                var result = connection.Query<Person>(sql).AsList();
                return result;
            }
        }
    }
}