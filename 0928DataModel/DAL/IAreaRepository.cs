using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace DAL
{
    public interface IAreaRepository
    {
        bool Add(ActivityViewModel model);
        bool Delete(string mc_code);
        bool Update(ActivityViewModel model);
        ActivityViewModel GetByCode(string mc_code);

    }
}
