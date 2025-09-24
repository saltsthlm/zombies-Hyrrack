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
        Assert.Equal(1, room.Capacity);

    }

    [Fact]
    public void RoomWithNoCapacity_CannotFitAnyZombies()
    {
        try
        {
            var room = new Room(0);

            room.AddZombie("Z1");
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
        room.AddZombie("Z1");

        var number_of_zombies = room.GetZombies();
        var isRoomFull = room.IsFull();

        Assert.Equal(1, number_of_zombies);
        Assert.True(isRoomFull);
    }

    [Fact]
    public void TwoRoomerIsNotFull_WhenAZombieIsAdded()
    {
        var room = new Room(2);
        room.AddZombie("Z1");

        var number_of_zombies = room.GetZombies();
        var isRoomFull = room.IsFull();

        Assert.Equal(1, number_of_zombies);
        Assert.False(isRoomFull);
    }

    [Fact]
    public void SecondZombieConsumesFirstZombie_WhenAddedToAOneRoomer()
    {
        var room = new Room(1);
        room.AddZombie("Z1");
        room.AddZombie("Z2");

        var number_of_zombies = room.GetZombies();
        var first_zombie = room.GetFirstZombie();

        Assert.Equal(1, number_of_zombies);
        Assert.Equal("Z2", first_zombie);
    }

    [Fact]
    public void TestToSeeIfScaleable()
    {
        var room = new Room(2);
        room.AddZombie("Z1");
        room.AddZombie("Z2");
        room.AddZombie("Z3");
        room.AddZombie("Z4");

        var number_of_zombies = room.GetZombies();
        var first_zombie = room.GetFirstZombie();

        Assert.Equal(2, number_of_zombies);
        Assert.Equal("Z3", first_zombie);
    }
}



