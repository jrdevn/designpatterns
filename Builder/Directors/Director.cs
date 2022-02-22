using Builder.Builders;
using Builder.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Directors
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructSedanCar()
        {
            _builder.SetVehicleType(VehicleType.SEDAN);
            _builder.SetEngine(new Engine(2000));
            _builder.SetSeats(5);
            _builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            _builder.SetVehicleType(VehicleType.TRUCK);
            _builder.SetEngine(new Engine(4000));
            _builder.SetSeats(2);
            _builder.SetTransmission(Transmission.MANUAL);
        }

        public void ConstructSUV()
        {
            _builder.SetVehicleType(VehicleType.SUV);
            _builder.SetEngine(new Engine(8000));
            _builder.SetSeats(6);
            _builder.SetTransmission(Transmission.AUTOMATIC_SEQUENCIAL);
            _builder.SetAirBag(Airbag.FRONTAL);
        }
    }
}
