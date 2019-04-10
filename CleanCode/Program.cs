using CleanCode.Factories;
using System;

namespace CleanCode
{
    class Program
    {

        static void Main(string[] args)

        {

            HotelCreator hotelFactory = new HotelIntercontinentalCreator();
            IHotel hotel = hotelFactory.FactoryMethod();
            hotel.BuildHotel();

            HotelCreator hotelcreator2 = new HotelBahiaDelSolCreator();
            IHotel hotel2 = hotelcreator2.FactoryMethod();
            hotel2.BuildHotel();
           

        }



     }
}

