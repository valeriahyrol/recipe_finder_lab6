using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Classes
{
    public interface ISearchStrategy
    {
        List<Recipe> Search(db database, string query);
    }

}
