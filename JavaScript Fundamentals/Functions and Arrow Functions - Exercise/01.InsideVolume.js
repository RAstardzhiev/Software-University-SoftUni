function insideOrOutside(params) {
    function isInside(x, y, z) {
        let x1 = 10, x2 = 50;
        let y1 = 20, y2 = 80;
        let z1 = 15, z2 = 50;

        return ((x >= x1 && x <= x2) && (y >= y1 && y <= y2) && (z >= z1 && z <= z2))
            ? true
            : false;
    }

    for (let i = 0; i < params.length; i++) {
        let x = params[i++];
        let y = params[i++];
        let z = params[i];

        console.log(isInside(x, y, z)
            ? 'inside'
            : 'outside');
    }
}

insideOrOutside([13.1, 50, 31.5, 50, 80, 50, -5, 18, 43]);