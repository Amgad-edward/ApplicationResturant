
using System;



namespace ModelData
{

    [Flags]
    public enum DayWeek
    {
        Sunday  = 0b_0000_0001,
        Monday  = 0b_0000_0010,
        Tuesday = 0b_0000_0100,
        Wednesday = 0b_0000_1000,
        Thursday = 0b_0001_0000,
        Friday = 0b_0010_0000,
        Saturday = 0b_0100_0000,
        WeekEnd = Sunday | Friday | Saturday,
    }

    [Flags]
    public enum PaymentBy
    {
        None = 0,
        Cash = 1,
        Visa = 2,
        Sheek = 4
    }

    [Flags]
    public enum PaymentService
    {
        None = 0,
        OnlyFixed = 1,
        ByTime = 2,
        ByAccount = 4,
    }

}