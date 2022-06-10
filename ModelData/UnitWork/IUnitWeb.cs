using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelData.Repositorys;
using ModelData.Models;

namespace ModelData.UnitWork
{
    public interface IUnitWeb : IDisposable
    {
        IRepository<DishRequired>? DishRequireds { get; }//12
        IRepository<TheTable>? TheTables { get; }//12
        IRepository<Area>? Areas { get; }//1-3s
        IRepository<RestaurantAndBranches>? Restaurants { get; }//15
        IRepository<Customer>? Customers { get; }//14
        IRepository<DishFood>? DishFoods { get; }//3
        IRepository<Delivery>? Deliveries { get; }//16
        IRepository<Reservation>? Reservations { get; }//8
    }
}
