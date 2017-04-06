<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
    <?php
        $drowing = "";
        $drowing .= GeberateEqualDigits(1, 5) . "<br />\n";
        $drowing .= MixedDigits(1, 3);
        $drowing .= GeberateEqualDigits(1, 5) . "<br />\n";
        $drowing .= MixedDigits(0, 3);
        $drowing .= GeberateEqualDigits(1, 5) . "<br />\n";
        echo $drowing;

        function MixedDigits($firstDigit, $rows) {
            $btnsCode = "";
            while ($rows > 0) {
                if ($firstDigit == 1) {
                    $btnsCode .= "<button style='background-color: blue;'>1</button>";
                }
                $btnsCode .= GeberateEqualDigits(0, 4);
                if ($firstDigit != 1) {
                    $btnsCode .= "<button style='background-color: blue;'>1</button>";
                }
                $btnsCode .= "<br />\n";
                $rows--;
            }
            return $btnsCode;
        }
        function GeberateEqualDigits($buttonText, $btns) {
            $backGColor = "";
            $btnsCode = "";
            if ($buttonText == 1)
                $backGColor = " style='background-color: blue;'";
            while ($btns > 0) {
                $btnsCode .= "<button$backGColor>$buttonText</button>";
                $btns--;
            }
            return $btnsCode;
        }
    ?>
</body>
</html>