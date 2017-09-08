using NUnit.Framework;

[TestFixture]
public class MissionControllerTests
{
    private MissionController sut;
    private IArmy army;
    private IWareHouse warehouse;

    [SetUp]
    public void TestInit()
    {
        this.army = new Army();
        this.warehouse = new WareHouse();

        this.sut = new MissionController(this.army, warehouse);
    }

    [Test]
    public void PerformMissionEnqueuesMissionCorrectly()
    {
        //Act
        this.sut.PerformMission(new Easy(50));

        //Assert
        Assert.AreEqual(1, sut.Missions.Count);
    }

    [Test]
    public void PerformMissionWithoutEnoughSoldiersReturnsCorrectMessage()
    {
        // Arrange
        var mission = new Hard(20);

        // Act
        var message = this.sut.PerformMission(mission).Trim();

        // Assert
        Assert.AreEqual($"Mission on hold - {mission.Name}", message);
    }

    [Test]
    public void PerformMissionCannotEnqueMoreThanThreeMissionsOnHold()
    {
        // Arrange
        var mission1 = new Hard(20);
        var mission2 = new Hard(20);
        var mission3 = new Hard(20);
        var mission4 = new Hard(20);

        // Act
        this.sut.PerformMission(mission1);
        this.sut.PerformMission(mission2);
        this.sut.PerformMission(mission3);
        this.sut.PerformMission(mission4);

        // Assert
        Assert.AreEqual(3, this.sut.Missions.Count);
    }

    [Test]
    public void PerformMissionWithEnoughSoldiersReturnsCorrectMessage()
    {
        // Arrange
        var mission = new Easy(20);

        this.warehouse.AddAmmunitions("Gun", 10);
        this.warehouse.AddAmmunitions("AutomaticMachine", 10);
        this.warehouse.AddAmmunitions("Helmet", 10);

        var soldier3 = new Ranker("Soldier 3", 30, 50, 50);
        this.army.AddSoldier(soldier3);
        this.warehouse.EquipArmy(this.army);

        // Act
        var message = this.sut.PerformMission(mission).Trim();

        // Assert
        Assert.AreEqual($"Mission completed - {mission.Name}", message);
    }

    [Test]
    public void PerformMissionSuccessfullyIncreasesSucceededMissionsCounter()
    {
        // Arrange
        var mission = new Easy(20);

        this.warehouse.AddAmmunitions("Gun", 10);
        this.warehouse.AddAmmunitions("AutomaticMachine", 10);
        this.warehouse.AddAmmunitions("Helmet", 10);

        var soldier3 = new Ranker("Soldier 3", 30, 50, 50);
        this.army.AddSoldier(soldier3);
        this.warehouse.EquipArmy(this.army);

        // Act
        var message = this.sut.PerformMission(mission).Trim();

        // Assert
        Assert.AreEqual(1, this.sut.SuccessMissionCounter);
    }

    [Test]
    public void PerformMissionDeclinesFirstWaitingMissionWhenTheWaitingOnesAreMoreThanThree()
    {
        // Arrange
        var mission = new Hard(20);
        this.sut.PerformMission(mission).Trim();
        this.sut.PerformMission(mission).Trim();
        this.sut.PerformMission(mission).Trim();

        // Act
        var message = this.sut.PerformMission(mission).Trim();

        // Assert
        Assert.IsTrue(message.StartsWith($"Mission declined - {mission.Name}"));
    }

    [Test]
    public void FailMissionsOnHoldIncreasesFailedMissionCounterCorrectly()
    {
        // Arrange
        var mission = new Hard(20);
        this.sut.PerformMission(mission).Trim();

        // Act
        this.sut.FailMissionsOnHold();

        // Assert
        Assert.AreEqual(1, this.sut.FailedMissionCounter);
    }

    [Test]
    public void FailedMissionCounterDisplaysCorrectlyIfNone()
    {
        //Act
        this.sut.PerformMission(new Easy(0));

        //Assert
        Assert.AreEqual(0, this.sut.FailedMissionCounter);
    }

    [Test]
    public void FailIfMoreThanThreeMissions()
    {
        //Arrange
        this.sut.Missions.Enqueue(new Easy(0));
        this.sut.Missions.Enqueue(new Easy(0));
        this.sut.Missions.Enqueue(new Easy(0));

        //Act
        this.sut.PerformMission(new Easy(0));

        //Assert
        Assert.AreEqual(this.sut.FailedMissionCounter, 1);
    }
}
