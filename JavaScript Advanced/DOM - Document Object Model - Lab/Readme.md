<h1>Lab: Document Object Model</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/328/">https://judge.softuni.bg/Contests/328/</a>.</p>
<h2>1.&nbsp;&nbsp; Sum Numbers</h2>
<p>Write a JS function that <strong>reads</strong> two numbers from input fields in a <strong>web page</strong> and puts their <strong>sum </strong><strong>in another field</strong> when the user <strong>clicks</strong> on a button.</p>
<h3>Input/Output</h3>
<p>There will be no input/output, your program should instead <strong>modify</strong> the DOM of the given HTML document.</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Sample HTML</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;input type="text" id="num1" /&gt; +</p>
<p>&lt;input type="text" id="num2" /&gt; =</p>
<p>&lt;input type="text" id="sum" readonly="readonly" /&gt;</p>
<p>&lt;input type="button" value="Calc" onclick="calc()" /&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp;&nbsp;&nbsp; function calc() {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // TODO: sum = num1 + num2</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<h3>&nbsp;</h3>
<h2>2.&nbsp;&nbsp; Show More</h2>
<p>Write a JS function that <strong>expands</strong> a hidden section of text when a link is <strong>clicked</strong>. The link should <strong>disappear</strong> as the rest of the text shows up.</p>
<h3>Input/Output</h3>
<p>There will be no input/output, your program should instead <strong>modify</strong> the DOM of the given HTML document.</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Sample HTML</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>Welcome to the "Show More Text Example".</p>
<p>&lt;a href="#" id="more" onclick= "showText()"&gt;Read more &hellip;&lt;/a&gt;</p>
<p>&lt;span id="text" style= "display:none"&gt;Welcome to JavaScript and DOM.&lt;/span&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp; function showText() {</p>
<p>&nbsp;&nbsp;&nbsp; // TODO</p>
<p>&nbsp; }</p>
<p>&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&nbsp;&agrave;</p>
<h2>3.&nbsp;&nbsp; Collect List Items</h2>
<p>Write a JS function that scans a given <strong>HTML list</strong> and <strong>appends</strong> all collected list items&rsquo; text to a <strong>text area</strong> on the same page when the user <strong>clicks</strong> on a button.</p>
<h3>Input/Output</h3>
<p>There will be no input/output, your program should instead <strong>modify</strong> the DOM of the given HTML document.</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Sample HTML</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;ul id="items"&gt;</p>
<p>&nbsp; &lt;li&gt;first item&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;second item&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;third item&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
<p>&lt;textarea id="result"&gt;&lt;/textarea&gt;</p>
<p>&lt;br&gt;</p>
<p>&lt;button onclick="extractText()"&gt;Extract Text&lt;/button&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp; function extractText() {</p>
<p>&nbsp; &nbsp;&nbsp;// TODO</p>
<p>&nbsp; }</p>
<p>&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&nbsp;&agrave;</p>
<h2>4.&nbsp;&nbsp; Colorize Table</h2>
<p>Write a JS function that <strong>changes the color </strong>of all <strong>even</strong> rows when the user <strong>clicks</strong> a button. Apply the color "<strong>Teal</strong>" to the target rows.</p>
<h3>Input/Output</h3>
<p>There will be no input/output, your program should instead <strong>modify</strong> the DOM of the given HTML document.</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Sample HTML</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;table&gt;</p>
<p>&nbsp;&nbsp;&lt;tr&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Town&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&lt;tr&gt;&lt;td&gt;Eve&lt;/td&gt;&lt;td&gt;Sofia&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&lt;tr&gt;&lt;td&gt;Nick&lt;/td&gt;&lt;td&gt;Varna&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&lt;tr&gt;&lt;td&gt;Didi&lt;/td&gt;&lt;td&gt;Ruse&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&lt;tr&gt;&lt;td&gt;Tedy&lt;/td&gt;&lt;td&gt;Varna&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
<p>&lt;button onclick="colorize()"&gt;Colorize&lt;/button&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp; function colorize() {</p>
<p>&nbsp;&nbsp;&nbsp; // TODO</p>
<p>&nbsp; }</p>
<p>&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&nbsp; &nbsp;&agrave;</p>
<h2>5.&nbsp;&nbsp; Countdown</h2>
<p>Write a JS program that <strong>implements </strong>a web countdown timer that supports <strong>minutes</strong> and <strong>seconds</strong>. The user should be able to set the time by calling you function with the number of seconds required. The time begins to count down as soon as the function is called. Using the sample code, your function will be called as soon as the page finishes loading and will begin to count down from 10 minutes.</p>
<h3>Input</h3>
<p>Your function will receive a <strong>number parameter</strong>, representing the starting number of <strong>seconds</strong>.</p>
<h3>Output</h3>
<p>There will be no output, your program should instead <strong>modify</strong> the DOM of the given HTML document.</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Sample HTML</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;input type="text" id="time" style="border:3px solid blue; text-align:center; font-size:2em;" disabled="true"/&gt;</p>
<p>&lt;script&gt;window.onload = function() { countdown(600); }&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<h2>6.&nbsp;&nbsp; Extract Parenthesis</h2>
<p>Write a JS function that when <strong>executed</strong>, extracts all parenthesized text from a target paragraph by given element ID. The result is a string, joined by "; " (semicolon, space).</p>
<h3>Input</h3>
<p>Your function will receive a <strong>string parameter</strong>, representing the target element ID, from which text must be extracted. The text should be extracted from the DOM.</p>
<h3>Output</h3>
<p><strong>Return a string</strong> with all matched text, separated by "; " (semicolon, space).</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Sample call</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>let text = extract("content");</p>
</td>
</tr>
<tr>
<td width="680">
<p><strong>Result (stored in variable text)</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>Bulgarian brandy; alcoholic drink; even apples</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>7.&nbsp;&nbsp; * Sum Table</h2>
<p>Write a JS function that finds the first table in a document and sums the values in the last column. The result is then displayed in an element with ID "sum".</p>
<h3>Input/Output</h3>
<p>There will be no input/output, your program should instead <strong>modify</strong> the DOM of the given HTML document.</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Sample HTML</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;table&gt;</p>
<p>&nbsp; &lt;tbody&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;tr&gt;&lt;th&gt;Product&lt;/th&gt;&lt;th&gt;Cost&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Beer&lt;/td&gt;&nbsp;&nbsp; &lt;td&gt;2.88&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Fries&lt;/td&gt;&nbsp; &lt;td&gt;2.15&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Burger&lt;/td&gt; &lt;td&gt;4.59&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Total:&lt;/td&gt; &lt;td id="sum"&gt;&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;/tbody&gt;</p>
<p>&lt;/table&gt;</p>
<p>&lt;button onclick="sum()"&gt;Sum&lt;/button&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<p>&agrave;</p>