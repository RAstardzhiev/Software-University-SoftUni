namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string NamespaceAsString = "_03BarracksFactory.Models.Units";

        public IUnit CreateUnit(string unitType)
        {
            Type classType = Type.GetType($"{NamespaceAsString}.{unitType}");
            if (classType == null)
            {
                return null;
            }

            return (IUnit)Activator.CreateInstance(classType);
        }
    }
}
