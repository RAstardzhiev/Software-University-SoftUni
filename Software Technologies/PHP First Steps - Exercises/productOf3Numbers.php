<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Product of 3 Numbers</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
        Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
            $negativeCount = 0;
            $num1 = floatval($_GET['num1']);
            $num2 = floatval($_GET['num2']);
            $num3 = floatval($_GET['num3']);
            if ($num1 == 0 || $num2 == 0 || $num3 == 0) {
                echo "Positive";
            } else {
                if ($num1 < 0) $negativeCount++;
                if ($num2 < 0) $negativeCount++;
                if ($num3 < 0) $negativeCount++;
                echo ($negativeCount % 2 == 0) ? "Positive" : "Negative";
            }
        }
    ?>
</body>
</html>