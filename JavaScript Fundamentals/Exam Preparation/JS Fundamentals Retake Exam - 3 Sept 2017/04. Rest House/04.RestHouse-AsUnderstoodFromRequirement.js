function orderGuests(stringRooms, stringGuests) {
    let rooms = parseRooms();
    let guestPairs = parseGuests();
    let teaHouse = [];
    
    while (guestPairs.length > 0) {
        let pair = guestPairs.shift();

        let isPairSettled = false;
        if (pair.first.gender === pair.second.gender) {
            let room = getAppropriateRoom(r => r.guests.length === 0 && r.type === 'triple');
            if (room) {
                room.guests = [pair.first, pair.second];
                isPairSettled = true;
            }
        } else {
            let room = getAppropriateRoom(r => r.guests.length === 0 && r.type === 'double-bedded');
            if (room) {
                room.guests = [pair.first, pair.second];
                isPairSettled = true;
            }
        }

        if (!isPairSettled) {
            settleGuest(pair.first);
            settleGuest(pair.second);
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

    result += `Guests moved to the tea house: ${teaHouse.length}`;
    console.log(result);    

    function settleGuest(guest) {
        let room = getAppropriateRoom(r => r.type === 'triple' && r.guests.length === 0);
        if (room) {
            room.guests.push(guest);
        } else {
            room = getAppropriateRoom(r => r.type === 'triple' && r.guests.length < 3 && r.guests[0].gender === guest.gender);
            if (room) {
                room.guests.push(guest);
            } else {
                teaHouse.push(guest);
            }
        }
    }

    function getAppropriateRoom(func) {
        for (const r of rooms) {
            if (func(r)) {
                return r;
            }
        }

        return null;
    }

    function parseRooms() {
        let pattern = /number:\s+([`'"])([0-9A-Z]+)\1,\s+type:\s+\1(double-bedded|triple)\1/gmi;

        let rooms = [];
        let currentmatch = pattern.exec(stringRooms);

        while (currentmatch) {
            rooms.push({
                number: currentmatch[2],
                type: currentmatch[3],
                guests: []
            });

            currentmatch = pattern.exec(stringRooms);
        }

        return rooms;
    }

    function parseGuests() {
        let pattern = /name:\s+(['`"])([\s\S]+?)\1,\s+gender:\s+\1(male|female)\1,\s+age:\s+([0-9]+)/gmi;

        let pairs = [];
        let currentMatch = pattern.exec(stringGuests);

        while (currentMatch) {
            let currentPair = { first: null, second: null };
            pairs.push(currentPair);

            currentPair.first = parseMatchToGuest(currentMatch);

            currentMatch = pattern.exec(stringGuests);
            if (currentMatch) {
                currentPair.second = parseMatchToGuest(currentMatch);
                currentMatch = pattern.exec(stringGuests);
            }
        }

        return pairs;

        function parseMatchToGuest(match) {
            return { name: match[2], gender: match[3], age: Number(match[4]) };
        }
    }
}

// orderGuests(
//     `[ { number: '206', type: 'double-bedded' },
//         { number: '311', type: 'triple' } ],`,

//     `[ { first: { name: 'Tanya Popova', gender: 'female', age: 24 }, 
//           second: { name: 'Miglena Yovcheva', gender: 'female', age: 23 } },
//         { first: { name: 'Katerina Stefanova', gender: 'female', age: 23 }, 
//           second: { name: 'Angel Nachev', gender: 'male', age: 22 } },
//         { first: { name: 'Tatyana Germanova', gender: 'female', age: 23 }, 
//           second: { name: 'Boryana Baeva', gender: 'female', age: 22 } } ]`
// );

// console.log();

orderGuests(
    `[ { number: '101A', type: 'double-bedded' },
        { number: '104', type: 'triple' },
        { number: '101B', type: 'double-bedded' },
        { number: '102', type: 'triple' } ],`, 

    `[ { first: { name: 'Sushi & Chicken', gender: 'female', age: 15 }, 
        second: { name: 'Salisa Debelisa', gender: 'female', age: 25 } },
      { first: { name: 'Daenerys Targaryen', gender: 'female', age: 20 }, 
        second: { name: 'Jeko Snejev', gender: 'male', age: 18 } },
      { first: { name: 'Pesho Goshov', gender: 'male', age: 20 }, 
        second: { name: 'Gosho Peshov', gender: 'male', age: 18 } },    
      { first: { name: 'Conor McGregor', gender: 'male', age: 29 }, 
        second: { name: 'Floyd Mayweather', gender: 'male', age: 40 } } ]`
);