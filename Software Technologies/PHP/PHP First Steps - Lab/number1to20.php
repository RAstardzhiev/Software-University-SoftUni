<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Number 1 to 20</title>
</head>
<body>
<h1>Number 1 to 20</h1>
<ul>
    <?php
    for ($i = 1; $i <= 20; $i++) {
        if ($i % 2 == 0)
            $color = 'green';
        else $color ='blue';
        echo "\t<li><span style='color:$color'>$i</span></li>\n";
    } ?>
</ul>
</body>
</html>