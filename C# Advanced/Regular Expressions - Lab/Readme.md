<p>Lab: Regular Expressions</p>
<p>Problems for exercises and homework for the &nbsp;<a href="https://softuni.bg/courses/csharp-advanced">&ldquo;C# Advanced&rdquo; course @ SoftUni".</a></p>
<p>Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/596/Regular-Expressions-Lab">https://judge.softuni.bg/Contests/596/Regular-Expressions-Lab</a>.</p>
<h1>Part I: Basic Regex</h1>
<h2>1.&nbsp;&nbsp; Match Count</h2>
<p>Find the <strong>count of occurrences</strong> of a word in a given text using regex.</p>
<p>The <strong>word</strong> to search for is given on the <strong>first line</strong>.</p>
<p>The <strong>text</strong> to search in is given on the <strong>second line</strong>.</p>
<h3>Examples</h3>
<table width="507">
<tbody>
<tr>
<td width="444">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="444">
<p>regex</p>
<p>A regular expression, regex or regexp (sometimes called a rational expression) is, in theoretical computer science and formal language theory, a sequence of characters that define a search pattern.</p>
</td>
<td width="62">
<p>2</p>
</td>
</tr>
<tr>
<td width="444">
<p>re</p>
<p>A regular expression, regex or regexp (sometimes called a rational expression) is, in theoretical computer science and formal language theory, a sequence of characters that define a search pattern.</p>
</td>
<td width="62">
<p>6</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read the input</li>
<li>Create Regex object with the provided pattern</li>
<li>Count the occurrences</li>
<li>Finally, print the result</li>
</ul>
<h2>2.&nbsp;&nbsp; Vowel Count</h2>
<p>Find the <strong>count</strong> of <strong>all vowels</strong> in a given <strong>text</strong> using a regex.</p>
<p>The vowels that you should be looking for are <strong>upper</strong> and <strong>lower</strong> <strong>a</strong>, <strong>e</strong>, <strong>i</strong>, <strong>o</strong>, <strong>u</strong> and <strong>y</strong>.</p>
<h3>Examples</h3>
<table width="501">
<tbody>
<tr>
<td width="401">
<p><strong>Input</strong></p>
</td>
<td width="100">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="401">
<p>Abraham Lincoln</p>
</td>
<td width="100">
<p>Vowels: 5</p>
</td>
</tr>
<tr>
<td width="401">
<p>In 1519 Leonardo da Vinci died at the age of 67.</p>
</td>
<td width="100">
<p>Vowels: 15</p>
</td>
</tr>
<tr>
<td width="401">
<p>n vwls.</p>
</td>
<td width="100">
<p>Vowels: 0</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read the input</li>
<li>Create Regex object with the pattern that finds all vowels</li>
<li>Count the occurrences</li>
<li>Finally, print the result</li>
</ul>
<h2>3.&nbsp;&nbsp; Non-Digit Count</h2>
<p>Find the count of all <strong>non-digit characters</strong> in a given text using regex.</p>
<h3>Examples</h3>
<table width="533">
<tbody>
<tr>
<td width="401">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="401">
<p>Abraham Lincoln</p>
</td>
<td width="132">
<p>Non-digits: 15</p>
</td>
</tr>
<tr>
<td width="401">
<p>In 1519 Leonardo da Vinci died at the age of 67.</p>
</td>
<td width="132">
<p>Non-digits: 42</p>
</td>
</tr>
<tr>
<td width="401">
<p>0</p>
</td>
<td width="132">
<p>Non-digits: 0</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read the input</li>
<li>Create Regex object that matches all non-digit characters</li>
<li>Count the occurrences and print the result</li>
</ul>
<h2>4.&nbsp;&nbsp; Extract Integer Numbers</h2>
<p>Extract all <strong>integer numbers</strong> from a given <strong>text</strong> using regex.</p>
<p>Ignore number signs or decimal separators (See the examples below).</p>
<p>If there are <strong>no numbers</strong>, don't print anything.</p>
<h3>Examples</h3>
<table width="533">
<tbody>
<tr>
<td width="401">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="401">
<p>In 1519 Leonardo da Vinci died at the age of 67.</p>
</td>
<td width="132">
<p>1519</p>
<p>67</p>
</td>
</tr>
<tr>
<td width="401">
<p>Decimals: 7.22, 3.14. Negative -25.</p>
</td>
<td width="132">
<p>7</p>
<p>22</p>
<p>3</p>
<p>14</p>
<p>25</p>
</td>
</tr>
<tr>
<td width="401">
<p>No integers.</p>
</td>
<td width="132">
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Extract Tags</h2>
<p>Extract all <strong>tags</strong> from a given HTML using regex.</p>
<p>Read lines until you get the <strong>"END"</strong> command.</p>
<p>If there are <strong>no tags</strong>, don&rsquo;t print anything.</p>
<h3>Examples</h3>
<table width="426">
<tbody>
<tr>
<td width="229">
<p><strong>Input</strong></p>
</td>
<td width="197">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="229">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;meta charset="UTF-8"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;title&gt;Title&lt;/title&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;/html&gt;</p>
<p>END</p>
</td>
<td width="197">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&lt;meta charset="UTF-8"&gt;</p>
<p>&lt;title&gt;</p>
<p>&lt;/title&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
<tr>
<td width="229">
<p>No tags.</p>
<p>END</p>
</td>
<td width="197">
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>
<h1>Part II: Regex Constructs</h1>
<h2>6.&nbsp;&nbsp; Valid Usernames</h2>
<p><strong>Scan</strong> through the lines for <strong>valid usernames</strong>.</p>
<p>A valid username:</p>
<ul>
<li>Has <strong>length</strong> between 3 and 16 characters</li>
<li><strong>Contains</strong> only letters, numbers, hyphens and underscores</li>
<li>Has <strong>no redundant symbols</strong> before, after or in between</li>
</ul>
<p>Read lines until you get the <strong>"END"</strong> command.</p>
<h3>Examples</h3>
<table width="265">
<tbody>
<tr>
<td width="157">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="157">
<p>sh</p>
<p>too_long_username</p>
<p>!lleg@l ch@rs</p>
<p>jeff_butt</p>
<p>END</p>
</td>
<td width="108">
<p>invalid</p>
<p>invalid</p>
<p>invalid</p>
<p>valid</p>
</td>
</tr>
<tr>
<td width="157">
<p>END</p>
</td>
<td width="108">
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use character classes [], quantifiers {} and anchors ^$</li>
</ul>
<h2>7.&nbsp;&nbsp; Valid Time</h2>
<p>Scan through the lines for valid times.</p>
<p>A <strong>valid time</strong>:</p>
<ul>
<li>Is <strong>in the interval</strong> 00:00:00 AM to 11:59:59 PM</li>
<li>Has <strong>no redundant symbols</strong> before, after or in between</li>
</ul>
<p>Read lines until you get the <strong>"END"</strong> command.</p>
<h3>Examples</h3>
<table width="249">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="108">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>11:33:24 AM</p>
<p>33:12:11 PM</p>
<p>inv 23:52:34 AM</p>
<p>00:13:23&nbsp;&nbsp;&nbsp;&nbsp; PM</p>
<p>9:3:12 АМ</p>
<p>END</p>
</td>
<td width="108">
<p>valid</p>
<p>invalid</p>
<p>invalid</p>
<p>invalid</p>
<p>invalid</p>
</td>
</tr>
<tr>
<td width="140">
<p>END</p>
</td>
<td width="108">
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Extract Quotations</h2>
<p><strong>Extract</strong> all <strong>quotations</strong> from a given text. The text will be on a single line.</p>
<p>A <strong>valid quotation</strong> should:</p>
<ul>
<li>Start and end with either single quotes (<strong>valid: 'quotation'</strong>) or double quotes (<strong>valid: "quotation"</strong>)</li>
<li>Not have mixed quotes (<strong>invalid: 'quotation"</strong>)</li>
</ul>
<p><strong>Skip nested</strong> quotations.</p>
<h3>Examples</h3>
<table width="481">
<tbody>
<tr>
<td width="340">
<p><strong>Input</strong></p>
</td>
<td width="140">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="340">
<p>&lt;a href='/' id="home"&gt;Home&lt;/a&gt;&lt;a class="selected"&lt;/a&gt;&lt;a href = '/forum'&gt;</p>
</td>
<td width="140">
<p>/</p>
<p>home</p>
<p>selected</p>
<p>/forum</p>
</td>
</tr>
<tr>
<td width="340">
<p>&lt;a href='/' id='home"&gt;</p>
</td>
<td width="140">
<p>/</p>
</td>
</tr>
<tr>
<td width="340">
<p>Skip "nested 'quotes'"</p>
</td>
<td width="140">
<p>nested 'quotes'</p>
</td>
</tr>
<tr>
<td width="340">
<p>No quotes.</p>
</td>
<td width="140">
<p><em>(no output)</em></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>