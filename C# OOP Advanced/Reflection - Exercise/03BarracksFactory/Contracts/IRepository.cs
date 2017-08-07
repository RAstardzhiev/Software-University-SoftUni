namespace _03BarracksFactory.Contracts
{
    public interface IRepository
    {
        string Statistics { get; }

        void RemoveUnit(string unitType);

        void AddUnit(IUnit unit);
    }
}
