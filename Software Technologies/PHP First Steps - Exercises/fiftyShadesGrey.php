<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Fifty Shades of Grey</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<!-- Judge Accepts ONLY PHP code !!! Without HTML !!! And Judge wants the result on ONE LINE -->
    <?php
    $grayShades = "";
    for ($row = 0; $row < 255; $row += 51) {
        for ($i = 0, $col = $row; $i < 10; $i++, $col += 5) {
            $grayShades .= "<div style=\"background-color: rgb($col, $col, $col);\"></div>";
        }
        $grayShades .= "<br>";
    }
    echo $grayShades;
    ?>
</body>
</html>