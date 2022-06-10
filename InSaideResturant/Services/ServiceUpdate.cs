
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using ModelData;
using ModelData.Models;
using ModelData.UnitWork;



namespace InSaideResturant.Services
{
    public sealed class ServiceUpdate 
    {
        private readonly IUnitAll db;

        public ServiceUpdate(IUnitAll DB)
        {
            db = DB;
        }

        public Reservation? Reservation { get; set; }


        public void Updateing()
        {
            List<Product> Productupdate = new List<Product>();
            var Dishfood = Reservation.DishFoods.Where(x => !x.ISDone);
            var DistinctProduct = Dishfood.Select(x => x.Dish).SelectMany(z => z.DetailsDishes)
            .Select(a => a.IdProduct).Distinct();
            foreach (var ID in DistinctProduct)
            {
                var product = db.Products.FindSingel(x => x.Id == ID);
                product.TotalWeightIN -= Dishfood.Select(d => d.Dish).SelectMany(q => q.DetailsDishes)
                                         .Where(x => x.IdProduct == ID).Sum(ss => ss.CountWeight);
                Productupdate.Add(product);
            }
            db.Products.Update(Productupdate);
        }
       
    }
}
