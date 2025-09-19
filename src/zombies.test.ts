import { equal } from "node:assert";
import { ok } from "node:assert/strict";
import { test } from "node:test";

const createRoom = (capacity: number) => {
  const _capacity = capacity;
  var _zombies = 0;

  return {
    isFull: () => _capacity == 0 ? true : false,
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

test.skip("one-roomer becomes full when a zombie is added", () => {});

test.skip("two-roomer is not full when a zombie is added", () => {});

test.skip("second zombie consumes first zombie when added to a one-roomer", () => {});

// You are free to add more tests that you think are relevant!
