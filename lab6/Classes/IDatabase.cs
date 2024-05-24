using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes
{
    public interface IDatabase
    {
        void OpenConnection();
        void CloseConnection();
        MySqlConnection GetConnection();
    }
}
