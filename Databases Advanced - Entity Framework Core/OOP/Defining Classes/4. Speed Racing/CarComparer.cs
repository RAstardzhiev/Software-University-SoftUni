namespace _4.Speed_Racing
{
    using System.Collections.Generic;

    class CarComparer : IEqualityComparer<Car>
    {
        public bool Equals(Car x, Car y) => x.Model == y.Model;

        public int GetHashCode(Car obj) => obj.Model.GetHashCode();
    }
}
