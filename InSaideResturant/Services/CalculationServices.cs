
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ModelData;
using ModelData.UnitWork;
using ModelData.Models;



namespace InSaideResturant.Services
{
    public sealed class CalculationServices
    {
        private Reservation _reservation;

        public CalculationServices(Reservation reservation)
        {
            this._reservation = reservation;
            total();
            
        }

        private void total()
        {
            var Total = 0m;
           if(_reservation.ServiceReservations != null)
            {
                foreach(var s in _reservation.ServiceReservations)
                {
                    
                    var Service = s.Service;
                    if (Service.PaymentService == PaymentService.ByTime)
                    {
                        TimeSpan calcu = TimeOnly.FromDateTime(DateTime.Now) - _reservation.Timestart.Value;
                        var Money = (decimal)calcu.TotalHours * Service.MoneyConst;
                        Total+= Money;
                    }
                    else if(Service.PaymentService == PaymentService.OnlyFixed)
                    {
                        Total += Service.MoneyConst;
                    }
                    else
                    {
                        var Account = Math.Round(_reservation.Totals * Service.Rate / 100,2);
                        Total += Account;
                    }
                }
                _reservation.TotalServices = Total;
            }

        }

        public decimal CalcuServices(Service service)
        {
            if (service.PaymentService == PaymentService.ByTime)
            {
                TimeSpan calcu = TimeOnly.FromDateTime(DateTime.Now) - _reservation.Timestart.Value;
                var Money = (decimal)calcu.TotalHours * service.MoneyConst;
                return Money;
            }
            else if (service.PaymentService == PaymentService.OnlyFixed)
            {
                return service.MoneyConst;
            }
            else
            {
                var Account = Math.Round(_reservation.Totals * service.Rate / 100, 2);
                return Account;
            }
        }

    }
}
