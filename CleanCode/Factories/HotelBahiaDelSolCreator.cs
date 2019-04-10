using CleanCode.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.Factories
{
    public class HotelBahiaDelSolCreator : HotelCreator
    {
        public override IHotel FactoryMethod()
        {
            return new HotelBahiaDelSol();
        }
    }
}
