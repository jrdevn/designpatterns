using Builder.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Products
{
    public class Vehicle
    {
        private VehicleType vehicleType;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private Airbag airbag;

        public VehicleType VehicleType
        {
            get => vehicleType;
            set => vehicleType = value;
        }

        public int Seats
        {
            get => seats;
            set => seats = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Transmission Transmission
        {
            get => transmission;
            set => transmission = value;
        }

        public Airbag AirBag
        {
            get => airbag;
            set => airbag = value;
        }
    }
}
