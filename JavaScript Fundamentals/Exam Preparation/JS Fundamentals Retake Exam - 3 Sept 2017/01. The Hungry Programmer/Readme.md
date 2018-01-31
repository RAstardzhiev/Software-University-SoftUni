<h1>Problem 1 &ndash; The Hungry Programmer</h1>
<p><em>You and your colleagues are on a teambuilding in the mountains. You have reached the closest mountain peak and now it is time to refresh with a meal. Unfortunately, the rest house is experiencing staff shortage so a helping hand with the serving is needed. You see an opportunity for abundant overeating and lend your help willingly.</em></p>
<p>Write a JavaScript program to help you calculate how many meals have you managed to snatch from the kitchen without being seen. The input is an array of strings containing the portions of meals for serving and a series of commands. In case you receive the command "<strong>Serve</strong>", you must serve the last portion in the line, removing it from the array and printing on the console <strong>"{meal name} served!"</strong>. Upon receiving the "<strong>Eat</strong>" command, you must eat the first portion and print <strong>"{meal name} eaten"</strong> to the console. "<strong>Add</strong>" places the given portion at the beginning of the line. "<strong>Consume</strong>" &ndash; eat all portions in the given index range and print <strong>"Burp!"</strong> to the console. "<strong>Shift</strong>" &ndash; swap the portions at the given indexes. Upon receiving the command "<strong>End</strong>" the serving of plates is finished and you head over to consume your own portion of meal. Check if given indexes are <strong>valid</strong>.</p>
<p>The input consists of the commands <strong>described</strong> <strong>above</strong>, in the following format:</p>
<ul>
<li>Serve</li>
<li>Add {meal}</li>
<li>Shift {index} {index}</li>
<li>Eat</li>
<li>Consume {start index} {end index}</li>
</ul>
<p>If a command does not match the pattern (unrecognized keyword, missing argument) it should be <strong>ignored</strong>.</p>
<p><strong>Input</strong></p>
<p>The input comes as two arrays. The <strong>first</strong> argument is an array of <strong>strings</strong>, containing <strong>portions of meals</strong>. The second argument is and array of <strong>strings,</strong> holding the <strong>commands </strong>that need to be parsed.</p>
<p><strong>Output</strong></p>
<p>On the <strong>first line</strong> print the remaining portions of meals in the array in the following format:</p>
<p>"Meals left: {meal1}, {meal2}, {meal3}, &hellip;"</p>
<p>&nbsp;In case there are <strong>no meals left</strong>, print <strong>"The food is gone"</strong>. On the <strong>second line</strong> print the number of the <strong>eaten</strong> meals in the following format:</p>
<p><strong>"</strong><strong>Meals eaten: {count}"</strong></p>
<p><strong><br /> </strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Examples</strong></p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>['chicken', 'steak', 'eggs'],</p>
<p>['Serve',</p>
<p>&nbsp;'Eat',</p>
<p>&nbsp;'End',</p>
<p>&nbsp;'Consume 0 1']</p>
</td>
<td width="294">
<p>eggs served!</p>
<p>chicken eaten</p>
<p>Meals left: steak</p>
<p>Meals eaten: 1</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>['fries', 'fish', 'beer', 'chicken', 'beer', 'eggs'],</p>
<p>['Add spaghetti',</p>
<p>&nbsp;'Shift 0 1',</p>
<p>&nbsp;'Consume 1 4',</p>
<p>&nbsp;'End']</p>
</td>
<td width="294">
<p>Burp!</p>
<p>Meals left: fries, beer, eggs</p>
<p>Meals eaten: 4</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>['carrots', 'apple', 'beet'],</p>
<p>['Consume 0 2',</p>
<p>&nbsp;'End',]</p>
</td>
<td width="294">
<p>Burp!</p>
<p>The food is gone</p>
<p>Meals eaten: 3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>