using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Factories
{
    public class HotelIntercontinentalCreator : HotelCreator
    {
        public override IHotel FactoryMethod()
        {
            return new HotelIntercontinental(); 
        }
    }
}
