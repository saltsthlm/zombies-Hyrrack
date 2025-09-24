using zombiesCS;

public class ZombiesTests
{
    [Fact]
    public void RoomIsFull()
    {
        //arrange
        var room = new Room(0);

        //act
        var isRoomFull = room.isFull();

        //assert
        Assert.True(isRoomFull);
    }

    [Fact]
    public void EmptyRoomThatFitsOneZombie_IsNotFull()
    {

    }

    [Fact]
    public void RoomWithNoCapacity_CannotFitAnyZombies()
    {
    }

    [Fact]
    public void OneRoomerBecomesFull_WhenAZombieIsAdded()
    {
    }

    [Fact]
    public void TwoRoomerIsNotFull_WhenAZombieIsAdded()
    {
    }

    [Fact]
    public void SecondZombieConsumesFirstZombie_WhenAddedToAOneRoomer()
    {
    }
}



