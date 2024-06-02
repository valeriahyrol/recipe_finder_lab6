using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab6.Classes.DataBase;

namespace lab6.Classes.Strategies
{
    public interface ISearchStrategy
    {
        List<Recipe> Search(IDatabase database, string query);
    }

}
