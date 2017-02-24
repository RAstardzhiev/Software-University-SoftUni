<h1>Problem 2 &ndash; Command Interpreter</h1>
<p>Jagged arrays, regular expressions, asynchronous programming&hellip; Tough stuff. But simple structures like arrays are piece of cake, right? Let&rsquo;s see how well you can manipulate data in a collection.</p>
<p>You will be given a series of strings on a single line, separated by one or more whitespaces. These represent the collection you&rsquo;ll be working with.</p>
<p>On the next input lines, until you receive the command <strong>"end"</strong>, you&rsquo;ll receive a series of commands in one of the following formats:</p>
<ul>
<li><strong>"reverse from [start] count [count]"</strong> &ndash; this instructs you to reverse a <strong>portion</strong> of the array &ndash; just [count] elements starting at index [start];</li>
<li><strong>"sort from [start] count [count]"</strong> &ndash; this instructs you to sort a <strong>portion</strong> of the array - [count] elements starting at index [start];</li>
<li><strong>"rollLeft [count] times"</strong> &ndash; this instructs you to move <strong>all</strong> elements in the array to the left [count] times. On each roll, the first element is placed at the end of the array;</li>
<li><strong>"rollRight [count] times"</strong> &ndash; this instructs you to move <strong>all</strong> elements in the array to the right [count] times. On each roll, the last element is placed at the beginning of the array;</li>
</ul>
<p>If any of the provided indices or counts is <strong>invalid</strong> (non-existent or negative), you should print a message on the console &ndash; <strong>"Invalid input parameters." </strong>and<strong> keep the collection unchanged.</strong></p>
<p>After you&rsquo;re done, print the resulting array in the following format: <strong>"[arr0, arr1 &hellip; arrN]"</strong>. The examples should help you understand the task better.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>The first input line will hold <strong>a series of strings</strong>, separated by <strong>one or more whitespaces</strong>.</li>
<li>The next lines will hold <strong>commands</strong> in the described formats (exactly).</li>
<li>The input ends with the keyword <strong>"end".</strong></li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console.</li>
<li>Each time an invalid command is received (containing an invalid index or count parameter), print the following line: <strong>"Invalid input parameters."</strong></li>
<li>After receiving the "<strong>end</strong>" command, print the <strong>resulting array</strong> on the console in the format specified above.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The <strong>count of strings</strong> in the collection will be in the range [1 &hellip; 50].</li>
<li>The <strong>number of commands</strong> will be in the range [1 &hellip; 20].</li>
<li>All commands will be in the described format; an invalid command is a command containing invalid [start] or [count], <strong>there won&rsquo;t be any missing or misspelled words</strong>.</li>
<li>[<strong>start</strong>] and [<strong>count</strong>] will be integers in the range [-2<sup>31</sup> &hellip; 2<sup>31 </sup>- 1].</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="437">
<tbody>
<tr>
<td width="191">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="191">
<p>1 2 <strong>5 8 7 3</strong> 10 6 4 9</p>
<p>reverse from 2 count 4</p>
<p>end</p>
</td>
<td width="246">
<p>[1, 2, <strong>3, 7, 8, 5</strong>, 10, 6, 4, 9]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>