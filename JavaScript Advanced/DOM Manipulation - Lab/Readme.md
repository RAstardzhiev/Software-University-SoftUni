<h1>Lab: DOM Manipulation</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/640/">https://judge.softuni.bg/Contests/640/</a>.</p>
<h2>1.&nbsp;&nbsp; List of Items</h2>
<p>Write a JS function that <strong>read</strong> the text inside an input field and <strong>appends</strong> the specified text to a list inside an HTML page.</p>
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
<p>&lt;h1&gt;List of Items&lt;/h1&gt;</p>
<p>&lt;ul id="items"&gt;&lt;li&gt;First&lt;/li&gt;&lt;li&gt;Second&lt;/li&gt;&lt;/ul&gt;</p>
<p>&lt;input type="text" id="newItemText" /&gt;</p>
<p>&lt;input type="button" value="Add" onclick="addItem()"&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp; function addItem() {</p>
<p>&nbsp;&nbsp;&nbsp; // TODO: add new item to the list</p>
<p>&nbsp; }</p>
<p>&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&nbsp;&agrave; &nbsp;&agrave;</p>
<h2>2.&nbsp;&nbsp; Add and Delete</h2>
<p>Extend the previous problem to display a<strong> [Delete] link </strong>after each list item. <strong>Clicking</strong> it, should <strong>delete</strong> the item with no confirmation.</p>
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
<p>&lt;h1&gt;List of Items&lt;/h1&gt;</p>
<p>&lt;ul id="items"&gt;&lt;/ul&gt;</p>
<p>&lt;input type="text" id="newText" /&gt;</p>
<p>&lt;input type="button" value="Add"<br /> &nbsp; onclick="addItem()"&gt;</p>
<p>&lt;script&gt;</p>
<p>&nbsp; function addItem() { ...</p>
<p>&nbsp;&nbsp;&nbsp; function deleteItem() { ... }</p>
<p>&nbsp; }</p>
<p>&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&agrave;</p>
<h2>3.&nbsp;&nbsp; Delete from Table</h2>
<p>Write a JS program that <strong>takes</strong> an e-mail from an <strong>input field</strong> and <strong>deletes</strong> matching rows from a table. If no entry is found, an <strong>error</strong> should be displayed in a &lt;div&gt; with ID "<strong>results</strong>". The error should read "<strong>Not found</strong>."</p>
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
<p>&lt;table border="1" id="customers"&gt;</p>
<p>&nbsp;&lt;tr&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Email&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp;&lt;tr&gt;&lt;td&gt;Eve&lt;/td&gt;&lt;td&gt;eve@gmail.com&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&lt;tr&gt;&lt;td&gt;Nick&lt;/td&gt;&lt;td&gt;nick@yahooo.com&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&lt;tr&gt;&lt;td&gt;Didi&lt;/td&gt;&lt;td&gt;didi@didi.net&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&lt;tr&gt;&lt;td&gt;Tedy&lt;/td&gt;&lt;td&gt;tedy@tedy.com&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
<p>Email: &lt;input type="text" name="email" /&gt;</p>
<p>&lt;button onclick="deleteByEmail()"&gt;Delete&lt;/button&gt;</p>
<p>&lt;div id="result" /&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<p>&nbsp;&agrave;</p>
<h2>4.&nbsp;&nbsp; Stopwatch</h2>
<p>Write a JS program that <strong>implements </strong>a web timer that supports <strong>minutes</strong> and <strong>seconds</strong>. The user should be able to control it with <strong>buttons</strong>. Clicking <strong>[Start]</strong> <strong>resets</strong> the timer back to zero. Only one of the buttons should be enabled at a time (you cannot stop the timer if it&rsquo;s not running).</p>
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
<p>&lt;div id="time" style="border:3px solid blue; text-align:center; font-size:2em; margin-bottom:10px"&gt;00:00&lt;/div&gt;</p>
<p>&lt;button id="startBtn"&gt;Start&lt;/button&gt;</p>
<p>&lt;button id="stopBtn" disabled="true"&gt;Stop&lt;/button&gt;</p>
<p>&lt;script&gt;window.onload = function() { stopwatch(); }&lt;/script&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<h2>5.&nbsp;&nbsp; Mouse Gradient</h2>
<p>Write a JS program that <strong>detects</strong> and displays how far along a gradient the user has <strong>moved </strong>their<strong> mouse</strong> on a webpage. Use the provided HTML and stylesheet (CSS) to test locally. The resulting value should be <strong>rounded down</strong> and displayed as a <strong>percentage</strong> inside the <strong>&lt;div&gt;</strong> with ID "<strong>result</strong>".</p>
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
<p>&lt;html&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp; &lt;title&gt;Mouse in Gradient&lt;/title&gt;</p>
<p>&nbsp; &lt;link rel="stylesheet" href="gradient.css" /&gt;</p>
<p>&nbsp; &lt;script src="gradient.js"&gt;&lt;/script&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body onload="attachGradientEvents()"&gt;</p>
<p>&nbsp; &lt;div id="gradient-box"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;div id="gradient"&gt;Click me!&lt;/div&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&nbsp; &lt;div id="result"&gt;&lt;/div&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>gradient.css</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>#gradient-box {</p>
<p>&nbsp; width: 300px;</p>
<p>&nbsp; border: 2px solid lightgrey;</p>
<p>}</p>
<p>#gradient-box:hover {</p>
<p>&nbsp; border: 2px solid black;</p>
<p>}</p>
<p>#gradient {</p>
<p>&nbsp; height: 30px;</p>
<p>&nbsp; color: white;</p>
<p>&nbsp; text-shadow: 1px 1px 10px black;</p>
<p>&nbsp; text-align: center;</p>
<p>&nbsp; line-height: 30px;</p>
<p>&nbsp; background: linear-gradient(to right, black, white);</p>
<p>&nbsp; cursor: crosshair;</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<h2>6.&nbsp;&nbsp; Highlight Active</h2>
<p>Write a JS function to highlight the <strong>currently active</strong> section of a document. There will be <strong>multiple</strong> divs with <strong>inputs</strong> inside them &ndash; set the class of the div, that contains the currently focused input field to "<strong>focus</strong>". When focus is lost (<strong>blurred</strong>) <strong>remove the class</strong> from the element.</p>
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
<p>&lt;!DOCTYPE html&gt;&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp; &lt;meta charset="UTF-8"&gt;&lt;title&gt;Focus&lt;/title&gt;</p>
<p>&nbsp; &lt;style&gt;</p>
<p>&nbsp;&nbsp;&nbsp; div { width: 470px; }</p>
<p>&nbsp;&nbsp;&nbsp; div div {</p>
<p>&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;text-align: center;</p>
<p>&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;display: inline-block;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;width: 200px;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;height: 200px;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;margin: 15px;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;border: 1px solid #999;</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; .focused { background: #999999; }</p>
<p>&nbsp; &lt;/style&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body onload="focus()"&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;div&gt;&lt;h1&gt;Section 1&lt;/h1&gt;&lt;input type="text"/&gt;&lt;/div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;div&gt;&lt;h1&gt;Section 2&lt;/h1&gt;&lt;input type="text"/&gt;&lt;/div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;div&gt;&lt;h1&gt;Section 3&lt;/h1&gt;&lt;input type="text"/&gt;&lt;/div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;div&gt;&lt;h1&gt;Section 4&lt;/h1&gt;&lt;input type="text"/&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&nbsp; &lt;script&gt;</p>
<p>&nbsp;&nbsp;&nbsp; function focus() {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// TODO</em></p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; &lt;/script&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<p>&nbsp;&agrave;</p>
<h2>7.&nbsp;&nbsp; Dynamic Validation</h2>
<p>Write a JS function that dynamically validates an email input field when it is <strong>changed</strong>. If the input is invalid, apply to it the style "error". Do not validate on every keystroke, as it is annoying for the user, only watch of <strong>change</strong> events.</p>
<p>A valid email will be in format: <strong>&lt;name&gt;@&lt;domain&gt;.&lt;extension&gt;</strong></p>
<p>Only lowercase Latin characters are allowed for any of the parts of the email. If the input is valid, clear the style.</p>
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
<p>&lt;!DOCTYPE html&gt;&lt;html lang="en"&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp; &lt;meta charset="UTF-8"&gt;&lt;title&gt;Focus&lt;/title&gt;</p>
<p>&nbsp; &lt;style&gt;.error { border: 2px solid red; }&lt;/style&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body onload="validate()"&gt;</p>
<p>&nbsp; &lt;label for="email"&gt;Enter email:&lt;/label&gt;</p>
<p>&nbsp; &lt;input id="email" type="text"/&gt;</p>
<p>&nbsp; &lt;script&gt;</p>
<p>&nbsp;&nbsp;&nbsp; function validate() {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// TODO</em></p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; &lt;/script&gt;</p>
<p>&lt;/body&gt;</p>
<p>&lt;/html&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<p>&agrave;</p>