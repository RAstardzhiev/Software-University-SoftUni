<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Celsius Fahrenheit Converter</title>
    <style>
        form span {
            display: inline-block;
            width: 80px;
            margin: 10px 3px 3px 8px;
        }
        form input {
            width: 250px;
            height: 20px;
            margin: 0px 5px;
        }
        form input[type='submit'] {
            margin: 10px 10px 12px 10px;
            width: 80px;
            height: 30px;
        }
    </style>
</head>
<body>
    <h1>Celsius Fahrenheit Converter</h1>
    <?php
        function celsiusToFahrenheit($celsius) {
            return $celsius * 1.8 + 32;
        }
        function fahrenheitToCelsius($fahrenheit) {
            return ($fahrenheit - 32) / 1.8;
        }
        $celsius = "&deg;C";
        $fahrenhrit = "&deg;F";
        $msgAfterFahrenheit = "";
        if (isset($_GET['fahrenheit'])) {
            $celsius = round(fahrenheitToCelsius(floatval($_GET['fahrenheit'])), 2);
            $fahrenhrit = $_GET['fahrenheit'];
            $msgAfterFahrenheit = "$fahrenhrit &deg;F = $celsius &deg;C";
        }
        $msgAfterCelsius = "";
        if (isset($_GET['celsius'])) {
            $celsius = $_GET['celsius'];
            $fahrenhrit = round(celsiusToFahrenheit(floatval($_GET['celsius'])), 2);;
            $msgAfterCelsius = "$celsius &deg;C = $fahrenhrit &deg;F";
        }
    ?>
    <form>
        <span>Celsius:</span>
        <input type="text" name="celsius" placeholder="<?= $celsius ?>" />
        <input type="submit" value="Convert" />
        <?= $msgAfterCelsius ?>
    </form>
    <form>
        <span>Fahrenheit:</span>
        <input type="text" name="fahrenheit" placeholder="<?= $fahrenhrit ?>" />
        <input type="submit" value="Convert" />
        <?= $msgAfterFahrenheit ?>
    </form>
</body>
</html>