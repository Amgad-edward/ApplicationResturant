
using Microsoft.EntityFrameworkCore;


namespace ModelData.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }



        public virtual DbSet<Logins>? Logins { get; set; }//1

        public virtual DbSet<Product>? Products { get; set; }//2

        public virtual DbSet<DishFood>? DishFoods { get; set; }//3

        public virtual DbSet<CategoryFood>? CategoryFoods { get; set; }//4

        public virtual DbSet<DetailsDish>? DetailsDishes { get; set; }//5

        public virtual DbSet<WeightProduct>? Weights { get; set; }//6

        public virtual DbSet<Emplyees>? Emplyees { get; set; }//7

        public virtual DbSet<Reservation>? Reservations { get; set; }//8

        public virtual DbSet<DishRequired>? DishRequireds { get; set; }//9

        public virtual DbSet<PayMoney>? PayMoney { get; set; }//10

        public virtual DbSet<TablesReservation>? TablesReservations { get; set; }//11

        public virtual DbSet<TheTable>? TheTables { get; set; }//12

        public virtual DbSet<Area>? Areas { get; set; }//1-3s

        public virtual DbSet<Customer>? Customers { get; set; }//14

        public DbSet<RestaurantAndBranches>? Restaurants { get; set; }//15

        public virtual DbSet<Delivery>? Deliveries { get; set; }//16

        public virtual DbSet<NameProduct>? NameProducts { get; set; }//17

        public virtual DbSet<WorkTable>? WorkTables { get; set; }//18

        public virtual DbSet<Receipt>? Receipts { get; set; }//19

        public virtual DbSet<ReceiptItems>? ReceiptItems { get; set; }//20

        public virtual DbSet<Supplier>? Suppliers { get; set; }//21

        public virtual DbSet<BarCode>? BarCodes { get; set; }//22

        public virtual DbSet<AccountReceipt>? AccountReceipts { get; set; }//23

        public virtual DbSet<Service>? Services { get; set; }//24

        public virtual DbSet<ServiceReservation>? ServiceReservations { get; set; }//25




    }
}
