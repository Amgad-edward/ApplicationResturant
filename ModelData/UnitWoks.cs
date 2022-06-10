using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelData.UnitWork;
using ModelData.Repositorys;
using ModelData.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace ModelData
{
    public class UnitWoks<Data> : IUnitAll , IUnitWeb  where Data : DataContext
    {
        private readonly Data data;

        public UnitWoks(Data data)
        {
            this.data = data;
        }

        public DatabaseFacade Database => new DatabaseFacade(data);
        public IRepository<Logins>? Logins => new Repository<Logins>(data);

        public IRepository<Product>? Products => new Repository<Product>(data);

        public IRepository<DishFood>? DishFoods => new Repository<DishFood>(data);

        public IRepository<CategoryFood>? CategoryFoods => new Repository<CategoryFood>(data);

        public IRepository<DetailsDish>? DetailsDishes => new Repository<DetailsDish>(data);

        public IRepository<WeightProduct>? Weights => new Repository<WeightProduct>(data);

        public IRepository<Emplyees>? Emplyees => new Repository<Emplyees>(data);

        public IRepository<Reservation>? Reservations => new Repository<Reservation>(data);

        public IRepository<DishRequired>? DishRequireds => new Repository<DishRequired>(data);

        public IRepository<PayMoney>? PayMoney => new Repository<PayMoney>(data);

        public IRepository<TablesReservation>? TablesReservations => new Repository<TablesReservation>(data);

        public IRepository<TheTable>? TheTables => new Repository<TheTable>(data);

        public IRepository<Area>? Areas => new Repository<Area>(data);

        public IRepository<Customer>? Customers => new Repository<Customer>(data);

        public IRepository<RestaurantAndBranches>? Restaurants => new Repository<RestaurantAndBranches>(data);

        public IRepository<Delivery>? Deliveries => new Repository<Delivery>(data);

        public IRepository<NameProduct>? NameProducts => new Repository<NameProduct>(data);

        public IRepository<WorkTable>? WorkTables => new Repository<WorkTable>(data);

        public IRepository<Receipt>? Receipts => new Repository<Receipt>(data);
        public IRepository<ReceiptItems>? ReceiptItems => new Repository<ReceiptItems>(data);
        public IRepository<Supplier>? Suppliers => new Repository<Supplier>(data);
        public IRepository<BarCode>? BarCodes => new Repository<BarCode>(data);
        public IRepository<AccountReceipt>? AccountReceipts => new Repository<AccountReceipt>(data);
        public IRepository<Service>? Services => new Repository<Service>(data);

        public IRepository<ServiceReservation>? ServiceReservation => new Repository<ServiceReservation>(data);

        public void Dispose()
        {
            data.Dispose();
        }

        public void Saved()
        {
            data.SaveChanges();
        }
    }
}
