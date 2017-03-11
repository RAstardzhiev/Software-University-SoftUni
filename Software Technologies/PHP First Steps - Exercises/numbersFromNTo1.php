<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Numbers from N to 1</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $result = [];
            for ($i = 0; $num > 0; $num--, $i++) {
                $result[$i] = $num;
            }
            echo implode(" ", $result);
        }
    ?>
</body>
</html>