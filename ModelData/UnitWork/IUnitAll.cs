using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelData.Repositorys;
using ModelData.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ModelData.UnitWork
{
    public interface IUnitAll : IDisposable
    {

        IRepository<Logins>? Logins { get;  }//1
        IRepository<Product>? Products { get;  }//2
        IRepository<DishFood>? DishFoods { get;  }//3
        IRepository<CategoryFood>? CategoryFoods { get;  }//4
        IRepository<DetailsDish>? DetailsDishes { get;  }//5
        IRepository<WeightProduct>? Weights { get;  }//6
        IRepository<Emplyees>? Emplyees { get;  }//7
        IRepository<Reservation>? Reservations { get;  }//8
        IRepository<DishRequired>? DishRequireds { get;  }//9
        IRepository<PayMoney>? PayMoney { get;  }//10
        IRepository<TablesReservation>? TablesReservations { get;  }//11
        IRepository<TheTable>? TheTables { get; }//12
        IRepository<Area>? Areas { get; }//1-3s
        IRepository<Customer>? Customers { get; }//14
        IRepository<RestaurantAndBranches>? Restaurants { get;}//15
        IRepository<Delivery>? Deliveries { get; }//16
        IRepository<NameProduct>? NameProducts { get;  }//17
        IRepository<WorkTable>? WorkTables { get; }//18
        IRepository<Receipt>? Receipts { get;  }//19
        IRepository<ReceiptItems>? ReceiptItems { get;  }//20
        IRepository<Supplier>? Suppliers { get;  }//21
        IRepository<BarCode>? BarCodes { get;  }//22
        IRepository<AccountReceipt>? AccountReceipts { get;  }//23
        IRepository<Service>? Services { get; }//24

        IRepository<ServiceReservation>? ServiceReservation { get; }//25
        DatabaseFacade Database { get; }

        void Saved();
    }
}
