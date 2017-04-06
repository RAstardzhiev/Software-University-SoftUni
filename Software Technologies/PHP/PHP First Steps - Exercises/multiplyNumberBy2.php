<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Multiply a Number by 2</title>

</head>
<body>
    <?php
        $result = "";
        if (isset($_GET['num'])) {
            $result = floatval($_GET['num']) * 2;
        }
    ?>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" /><br />
        <?= $result ?>
    </form>
</body>
</html>