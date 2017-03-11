<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Hello Person</title>
</head>
<body>
    <?php
        if (isset($_GET["name"])) {
            $name = $_GET["name"];
            echo "Hello, <u><b>$name</b></u>";
        } else {
    ?>
    <form>
        Name: <input type="text" name="name" />
        <input type="submit" />
    </form>
    <?php } ?>
</body>
</html>