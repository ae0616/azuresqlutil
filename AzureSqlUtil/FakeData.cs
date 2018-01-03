using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSqlUtil
{
    public class FakeData
    {
        private static List<string> prodeids = new List<string>() { "e578ny", "e324zx", "e1994p", "ef21yk", "e940sy" };
        private static List<string> deveids = new List<string>() { "e578ny", "e320bx", "e145rn", "ef01ky", "e091ys", "e1234b" };
        private static Dictionary<string, List<string>> dbusers = new Dictionary<string, List<string>>()  {
            { "ds3devsqlsrv1", deveids }, {"ds3prodsqlsrv1", prodeids}
        };

        public static List<string> GetUsers(string databaseServerName)
        {
            if (dbusers.ContainsKey(databaseServerName))
            {
                return dbusers[databaseServerName];
            } else
            {
                return null;
            }
        }

        private static List<string> databaseServers = new List<string>() { "ds3prodsqlsrv1", "ds3devsqlsrv1" };
        public static List<string> GetDatabaseServers() => databaseServers;

        private static List<string> devDatabases = new List<string>() { "devempsls", "master" };
        private static List<string> prodDatabases = new List<string>() { "prodempsls", "master" };
        private static List<string> databaseNames = new List<string>() {"devempsls", "prodempsls" };
        private static Dictionary<string, List<string>> databases = new Dictionary<string, List<string>>() {
            { "ds3prodsqlsrv1", devDatabases }, {"ds3devsqlsrv1", prodDatabases}
        };
        public static List<string> GetDatabases(string servername) => databases[servername];

    }
}
