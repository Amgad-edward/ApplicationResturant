
using ModelData.Models;



namespace InSaideResturant.Data
{
    public class UserLog
    {

        public string? UserName { get; set; }

        public bool ISAdmin { get; set; }

        public bool Kitchen { get; set; }

        public bool Cacher { get; set; }

        public bool Garson { get; set; }

        public bool DataEntry { get; set; }

        public bool TelSales { get; set; }

        public int restourantId { get; set; }

        public string? RestourantName { get; set; }

        public byte[]? Imagelogo { get; set; }

        public int EmplyeeID { get; set; }

        public bool Islog { get; set; }

        public string? NameUser { get; set; }

        public IEnumerable<Service>? Services { get; set; }



        public static implicit operator UserLog(Logins logins)
        {
            return new UserLog
            {
                NameUser = logins.emp.Name,
                UserName = logins.Username,
                EmplyeeID = logins.emp.Id,
                Islog = true,
                ISAdmin = logins.ISAdmin,
                restourantId = logins.emp.Restaurant.Id,
                RestourantName = logins.emp.Restaurant.NameAndBranch,
                Imagelogo = logins.emp.Restaurant.Photo,
                Cacher = logins.Cacher, DataEntry = logins.DataEntry,
                Garson = logins.Garson, TelSales = logins.TelSales,
                Kitchen = logins.Kitchen,
                Services = logins.emp.Restaurant.Services
            };
        }
    }
}
