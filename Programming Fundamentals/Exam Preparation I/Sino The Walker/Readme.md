<h1>Problem 1. Sino The Walker</h1>
<p>Sino is one of those people that lives in SoftUni. He leaves every now and then, but when he leaves he always takes a different route, so he needs to know how much time it will take for him to go home. Your job is to help him with the calculations.</p>
<p>You will receive the <strong>time that Sino leaves</strong> SoftUni, the <strong>steps taken</strong> and <strong>time for each step in seconds</strong>.</p>
<p>You need to print the exact <strong>time</strong> that he will <strong>arrive at home in the format specified</strong>.</p>
<h2>Input / Constrains</h2>
<ul>
<li>The first line will be the time Sino leaves SoftUni in the following format: <strong>HH:mm:ss</strong></li>
<li>The second line will contain the <strong>number of steps</strong> that he needs to walk to his home. This number will be an integer in range <strong>[0&hellip;</strong><strong>2,147,483,647]</strong></li>
<li>On the final line you will receive the <strong>time in seconds</strong> for each <strong>step</strong>. This number will be an integer in range <strong>[0&hellip;</strong><strong>2,147,483,647]</strong></li>
</ul>
<h2>Output</h2>
<ul>
<li>Print the <strong>time of arrival</strong> at home in the following format:
<ul>
<li><strong>Time Arrival: {hours}:{minutes}:{seconds}</strong></li>
</ul>
</li>
<li>If hours, minutes or seconds are a single digit number, add a zero in front.</li>
<li>If, for example, hours are equal to zero, print a <strong>00</strong> in their place. The same is true for minutes or seconds.</li>
<li>Time of day starts at <strong>00:00:00</strong> and ends at <strong>23:59:59</strong></li>
</ul>
<h2>Examples</h2>
<table width="684">
<tbody>
<tr>
<td width="306">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="306">
<p>12:30:30</p>
<p>90</p>
<p>1</p>
</td>
<td width="378">
<p>Time Arrival: 12:32:00</p>
</td>
</tr>
<tr>
<td width="306">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="306">
<p>23:49:13</p>
<p>5424</p>
<p>2</p>
</td>
<td width="378">
<p>Time Arrival: 02:50:01</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>