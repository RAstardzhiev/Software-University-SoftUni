<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Not Divisor Numbers</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            // prints all the numbers from num to 1, which are not divisors of num
            $result = [];
            for ($i = 0, $j = $num; $j > 0; $j--, $i++) {
                if ($num % $j != 0) {
                    $result[$i] = $j;
                }
            }
            echo implode(" ", $result);
        }
    ?>
</body>
</html>