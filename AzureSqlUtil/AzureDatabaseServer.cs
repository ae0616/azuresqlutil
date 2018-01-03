using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSqlUtil
{
    public class AzureDatabaseServer
    {
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set;  }

        public AzureDatabaseServer(string serverName)
        {
            ServerName = serverName ?? throw new ArgumentNullException(nameof(serverName));
        }

        public AzureDatabaseServer(string serverName, string userName, string password) : this(serverName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public bool isValid()
        {
            // TODO: return true if able to connect to 'master' database on the server with username and password otherwise false
            return true;
        }
    }

    public class DbServers 
    {
        public ObservableCollection<AzureDatabaseServer> DbServersList = new ObservableCollection<AzureDatabaseServer>();

        public DbServers() 
        {
            foreach(var server in FakeData.GetDatabaseServers())
            {
                DbServersList.Add(new AzureDatabaseServer(server as string));
            }
        }
    }

    public class DbUsersCollection
    {
        public ObservableCollection<DbUsers> dbusercollection = new ObservableCollection<DbUsers>();
    }

    public class DbUsers
    {
        public string username { get; set; }
        public string fullname { get; set; }
    }
}
