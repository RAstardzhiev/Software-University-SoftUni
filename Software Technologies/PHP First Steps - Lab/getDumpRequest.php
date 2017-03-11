<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Dump a HTTP GET Request</title>
</head>
<body>
    <form>
        <div>Name:</div>
        <input type="text" name="name" />
        <div>Age:</div>
        <input type="number" name="age" />
        <div>Town:</div>
        <div>
            <select>
                <option value="10">Sofia</option>
                <option value="20">Burgas</option>
                <option value="30">Varna</option>
                <option value="40">Plovdiv</option>
                <option value="50">Stara Zagora</option>
            </select>
        </div>
        <div>
            <input type="submit" />
        </div>
    </form>
    <?php
        var_dump($_GET);
    ?>
</body>
</html>