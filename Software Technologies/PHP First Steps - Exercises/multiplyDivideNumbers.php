<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Multiply / Divide Numbers</title>

</head>
<body>
<!--
    * Multiplies num1 * num2 if num2 is greater than or equal to num1
    * Divides num1 / num2 if num1 is greater than num2
-->
    <form>
        N: <input type="text" name="num1" />
        M: <input type="text" name="num2" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num1']) && isset($_GET['num2'])) {
            $num1 = floatval($_GET['num1']);
            $num2 = floatval($_GET['num2']);
            if ($num2 >= $num1) {
                echo $num1 * $num2;
            } else {
                echo $num1 / $num2;
            }
        }
    ?>
</body>
</html>