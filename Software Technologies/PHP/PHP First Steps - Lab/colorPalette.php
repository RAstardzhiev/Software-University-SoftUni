<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Color Palette</title>
</head>
<body>
<!-- Judge accepts it when deleting -> display: inline-block; width: 19%; margin: 0.25%; padding: 0.25%; -->
<?php
    for ($red = 0; $red <= 255; $red += 51) {
        for ($green = 0; $green <= 255; $green += 51) {
            for ($blue = 0; $blue <= 255; $blue += 51) {
                $color = "rgb($red, $green, $blue)";
                echo "<div style='background: $color; display: inline-block; width: 19%; margin: 0.25%; padding: 0.25%;'>$color</div>";
            }
        }
    }
?>
</body>
</html>
