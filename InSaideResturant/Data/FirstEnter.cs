

using ModelData.Models;
using ModelData.UnitWork;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InSaideResturant.Data
{
    public class FirstEnter
    {
        private readonly IUnitAll unit;

        public FirstEnter(IUnitAll unit)
        {
            this.unit = unit;
        }

        public bool CreateDataBase => unit.Database.EnsureCreated();



        public bool CraeteAdmin(int restourant)
        {
            if (unit.Logins.INClude(x=>x.emp).Any(x=>x.emp.Idresetaurant == restourant))
                return true;

            return false;
        }

    }
}
