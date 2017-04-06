<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML Buttons</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $result = [];
            for ($i = 1; $i <= $num; $i++) {
                $result[$i - 1] = "<button>$i</button>";
            }
            echo implode(" ", $result);
        }
    ?>
</body>
</html>