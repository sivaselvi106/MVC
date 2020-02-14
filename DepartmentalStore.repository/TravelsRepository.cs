using System;
using Travels.entity;
using System.Collections.Generic;

namespace Travel.repository
{
    public class TravelsRepository
    {
        public static List<TravelsProperty> travels = new List<TravelsProperty>();
        static TravelsRepository()
        {
            travels.Add(new TravelsProperty { TravelsName="PS", TravelsId = 1, TravelsSource="Cbe", TravelsDestination="Chennai" });
            travels.Add(new TravelsProperty { TravelsName = "SS", TravelsId = 2, TravelsSource = "Cbe", TravelsDestination = "Chennai" });
            travels.Add(new TravelsProperty { TravelsName = "VN", TravelsId = 3, TravelsSource = "Cbe", TravelsDestination = "Chennai" });
        }
        public IEnumerable<TravelsProperty> GetAllDetails()
        {
            return travels;
        }
    }
}
