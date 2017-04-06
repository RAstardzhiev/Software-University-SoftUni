<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Tribonacci Sequence</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $tribonacci = [1, 1, 2];
            for ($i = 3; $i < $num; $i++) {
                $tribonacci[$i] = $tribonacci[$i - 1] + $tribonacci[$i - 2] + $tribonacci[$i - 3];
            }
            if ($num < 3) {
                $tribonacci = array_slice($tribonacci, 0, $num);
            }
            echo implode(" ", $tribonacci);
        }
    ?>
</body>
</html>