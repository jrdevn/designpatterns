using FactoryMethod.Vehicles;
using FactoryMethod.Factories;

namespace FactoryMethod.Factories
{
    class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motocycle();
        }
    }
}
