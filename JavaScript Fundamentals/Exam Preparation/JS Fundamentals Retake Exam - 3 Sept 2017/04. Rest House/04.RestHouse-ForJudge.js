function orderGuests(rooms, guestPairs) {
    for (let i = 0; i < rooms.length; i++) {
        rooms[i].guests = [];
    }

    let teaHouse = 0;

    while (guestPairs.length > 0) {
        let pair = guestPairs.shift();

        let isPairSettled = false;
        if (pair.first.gender === pair.second.gender) {
            let room = getAppropriateRoom(r => r.type === 'triple' && r.guests.length < 3 && (r.guests.length === 0 || r.guests[0].gender === pair.first.gender));
            if (room) {
                room.guests.push(pair.first);

                if (room.guests.length === 3) {
                    room = getAppropriateRoom(r => r.type === 'triple' && r.guests.length < 3 && (r.guests.length === 0 || r.guests[0].gender === pair.second.gender));
                    if (room) {
                        room.guests.push(pair.second);
                    } else {
                        teaHouse++;
                    }
                } else {
                    room.guests.push(pair.second);
                }

                isPairSettled = true;
            }
        } else {
            let room = getAppropriateRoom(r => r.type === 'double-bedded' && r.guests.length === 0);
            if (room) {
                room.guests = [pair.first, pair.second];
                isPairSettled = true;
            } 
        }

        if (!isPairSettled) {
            teaHouse += 2;
        }
    }

    // Print Rooms
    let result = '';
    for (const r of rooms.sort((a, b) => a.number < b.number ? -1 : a.number > b.number ? 1 : 0)) {
        result += `Room number: ${r.number}\n`;

        for (const g of r.guests.sort((a, b) => a.name < b.name ? -1 : a.name > b.name ? 1 : 0)) {
            result += `--Guest Name: ${g.name}\n`;
            result += `--Guest Age: ${g.age}\n`;
        }

        let emptyBeds = r.type === 'triple'
            ? 3 - r.guests.length
            : 2 - r.guests.length;

        result += `Empty beds in the room: ${emptyBeds}\n`;
    }

    result += `Guests moved to the tea house: ${teaHouse}`;
    console.log(result);

    function getAppropriateRoom(func) {
        for (const r of rooms) {
            if (func(r)) {
                return r;
            }
        }

        return null;
    }
}

orderGuests(
    [{ number: '206', type: 'double-bedded' },
    { number: '311', type: 'triple' }],

    [{
        first: { name: 'Tanya Popova', gender: 'female', age: 24 },
        second: { name: 'Miglena Yovcheva', gender: 'female', age: 23 }
    },
    {
        first: { name: 'Katerina Stefanova', gender: 'female', age: 23 },
        second: { name: 'Angel Nachev', gender: 'male', age: 22 }
    },
    {
        first: { name: 'Tatyana Germanova', gender: 'female', age: 23 },
        second: { name: 'Boryana Baeva', gender: 'female', age: 22 }
    }]
);

console.log();

orderGuests(
    [{ number: '101A', type: 'double-bedded' },
    { number: '104', type: 'triple' },
    { number: '101B', type: 'double-bedded' },
    { number: '102', type: 'triple' }],

    [{
        first: { name: 'Sushi & Chicken', gender: 'female', age: 15 },
        second: { name: 'Salisa Debelisa', gender: 'female', age: 25 }
    },
    {
        first: { name: 'Daenerys Targaryen', gender: 'female', age: 20 },
        second: { name: 'Jeko Snejev', gender: 'male', age: 18 }
    },
    {
        first: { name: 'Pesho Goshov', gender: 'male', age: 20 },
        second: { name: 'Gosho Peshov', gender: 'male', age: 18 }
    },
    {
        first: { name: 'Conor McGregor', gender: 'male', age: 29 },
        second: { name: 'Floyd Mayweather', gender: 'male', age: 40 }
    }]
);

console.log();

// Test 3
orderGuests(
    [{ "number": "428", "type": "triple" },
    { "number": "161", "type": "triple" },
    { "number": "242", "type": "double-bedded" },
    { "number": "537", "type": "triple" }],

    [{ "first": { "name": "Nina Diaz", "gender": "female", "age": 29 }, "second": { "name": "Carol Hansen", "gender": "female", "age": 6 } },
    { "first": { "name": "Georgia Thomas", "gender": "female", "age": 38 }, "second": { "name": "Freddie Harmon", "gender": "male", "age": 46 } },
    { "first": { "name": "Freddie Harmon", "gender": "male", "age": 30 }, "second": { "name": "Jesus Terry", "gender": "male", "age": 64 } },
    { "first": { "name": "Tracy Reid", "gender": "male", "age": 41 }, "second": { "name": "Jordan Garner", "gender": "male", "age": 16 } },
    { "first": { "name": "Kara Burns", "gender": "female", "age": 7 }, "second": { "name": "Marjorie Butler", "gender": "female", "age": 28 } }]
);