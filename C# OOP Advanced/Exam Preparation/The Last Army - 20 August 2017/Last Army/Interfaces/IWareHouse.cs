public interface IWareHouse
{
    void EquipArmy(IArmy army);

    void AddAmmunitions(string name, int count);

    bool TryEquipSoldier(ISoldier sildier);
}