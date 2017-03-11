<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Fibonacci Sequence</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            if ($num == 1) {
                echo "1";
            } else {
                $result = [1, 1];
                $fibonacci = 0;
                for ($i = 2; $i < $num; $i++) {
                    $result[$i] = $result[$i - 1] + $result[$i - 2];
                }
                echo implode(" ", $result);
            }
        }
    ?>
</body>
</html>