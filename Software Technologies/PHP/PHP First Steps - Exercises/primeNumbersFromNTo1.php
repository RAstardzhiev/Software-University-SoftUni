<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Prime Numbers from N to 1</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $primes = [];
            while ($num > 2) {
                $isPrime = true;
                for ($i = 2; $i <= $num  / 2; $i++) {
                    if ($num % $i == 0) {
                        $isPrime = false;
                        break;
                    }
                }
                if ($isPrime) {
                    array_push($primes, $num);
                }
                $num--;
            }
            echo implode(" ", $primes);
        }
    ?>
</body>
</html>