import { equal } from "node:assert";
import { ok } from "node:assert/strict";
import { test } from "node:test";

const createRoom = (capacity: number) => {
  const _capacity = capacity;
  var _zombies = 0;

  return {
    isFull: () => _zombies < _capacity? false : true,
    getCapacity: () => _capacity,
    addZombie: () => { if(_capacity > 0) { _zombies += 1} },
    getZombies: () => _zombies,
  };
};

test("room is full", () => {
  const room = createRoom(0);

  const isRoomFull = room.isFull();

  ok(isRoomFull);
});

test("empty room that fits one zombie is not full", () => {
  const room = createRoom(1);

  const size = room.getCapacity()
  const isRoomFull = room.isFull();
  
  equal(size, 1);

  ok(!isRoomFull);
});

test("room with no capacity cannot fit any zombies", () => {
  const room = createRoom(0);

  room.addZombie();

  equal(room.getCapacity(), 0)
  equal(room.getZombies(), 0);

});

test("one-roomer becomes full when a zombie is added", () => {
  const room = createRoom(1);

  room.addZombie();

  const isRoomFull = room.isFull();

  equal(room.getCapacity(), 1);
  ok(isRoomFull);

});

test("two-roomer is not full when a zombie is added", () => {
  const room = createRoom(2);

  room.addZombie();

  const isRoomFull = room.isFull();

  equal(room.getCapacity(), 2);
  ok(!isRoomFull);
});

test("second zombie consumes first zombie when added to a one-roomer", () => {
  const room = createRoom(1);

  room.addZombie();
  room.addZombie();

  equal(room.getCapacity(), 1);
  equal(room.getZombies(), 1);

});

// You are free to add more tests that you think are relevant!
