using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using ModelData.Models;

namespace ModelData
{
    public static class Hex
    {
        public static string ShowImage(this byte[] source , string Type = "*")
        {
            if (source != null)
                return $"data:image/{Type};base64,{Convert.ToBase64String(source)}";

            return string.Empty;
        }

        public static string ToMonye(this decimal source)
        {
            return $"{Math.Round(source, 2)} - EGP" ;
        }
    }


   
}
