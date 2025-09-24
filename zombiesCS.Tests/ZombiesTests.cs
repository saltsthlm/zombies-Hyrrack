using zombiesCS;

public class ZombiesTests
{
    [Fact]
    public void RoomIsFull()
    {
        //arrange
        var room = new Room(0);

        //act
        var isRoomFull = room.IsFull();

        //assert
        Assert.True(isRoomFull);
    }

    [Fact]
    public void EmptyRoomThatFitsOneZombie_IsNotFull()
    {
        var room = new Room(1);

        var isRoomFull = room.IsFull();

        Assert.False(isRoomFull);

    }

    [Fact]
    public void RoomWithNoCapacity_CannotFitAnyZombies()
    {
        try
        {
            var room = new Room(0);

            room.AddZombie(1);
        }
        catch (System.Exception ex)
        {
            Assert.Equal("Cannot add zombies to room with zero capacity", ex.Message);
            return;
        }
        Assert.True(false, "No exception when adding zombie to empty room");
    }

    [Fact]
    public void OneRoomerBecomesFull_WhenAZombieIsAdded()
    {
        var room = new Room(1);
        room.AddZombie(1);

        var number_of_zombies = room.Queue.Count();
        var isRoomFull = room.IsFull();

        Assert.Equal(number_of_zombies, 1);
        Assert.True(isRoomFull);
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



