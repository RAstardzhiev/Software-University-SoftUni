<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Sub-Lists</title>

</head>
<body>
<form>
    N: <input type="text" name="num1" />
    M: <input type="text" name="num2" />
    <input type="submit" />
</form>
<ul>
    <?php
    if (isset($_GET['num1']) && isset($_GET['num2'])) {
        $num1 = intval($_GET['num1']);
        $num2 = intval($_GET['num2']);
        $listOfElements = "";
        for ($list = 1; $list <= $num1; $list++) {
            $listOfElements .= "\t<li>List $list\n";
            $listOfElements .= "\t\t<ul>\n";
            for ($element = 1; $element <= $num2; $element++) {
                $listOfElements .= "\t\t\t<li>Element $list.$element</li>\n";
            }
            $listOfElements .= "\t\t</ul>\n";
            $listOfElements .= "\t</li>\n";
        }
        echo $listOfElements;
    }
    ?>
</ul>
</body>
</html>