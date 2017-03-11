<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Sum Two Numbers</title>
</head>
<body>
    <h1>Sum Two Numbers</h1>
    <form>
        <div>First Number:</div>
        <input type="number" name="firstNumber" placeholder="First Number" />
        <div>Second Number:</div>
        <input type="number" name="secondNumber" placeholder="Second Number" />
        <div>
            <input type="submit" value="Sum" />
        </div>
    </form>
    <?php
    if (isset($_GET['firstNumber']) && isset($_GET['secondNumber'])) {
        $firstN = intval($_GET['firstNumber']);
        $secondN = intval($_GET['secondNumber']);
        $sum = $firstN + $secondN;
        echo "<p>$firstN + $secondN = $sum</p>";
    }
    ?>
</body>
</html>