using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Factories
{
    public class HolidayInnCreator : HotelCreator
    {
        public override IHotel FactoryMethod()
        {
            throw new NotImplementedException();
        }
    }
}
