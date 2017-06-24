<h1>Problem 3 &ndash; Basic Mark-up Language</h1>
<p>HTML is old and clumsy so a group of highly motivated Softuni students decided to create a new language for the web. It&rsquo;s basically the same in terms of clumsiness, but supports several revolutionary tags:</p>
<ul>
<li><strong>Inverse &ndash; </strong>transforms its content&rsquo;s lowercase letters to uppercase and vice-versa.
<ul>
<li>&lt;inverse content="<strong>HelloWorlD</strong>"/&gt; outputs <strong>hELLOwORLd</strong></li>
</ul>
</li>
<li><strong>Reverse &ndash; </strong>reverses its content
<ul>
<li><strong>&lt;</strong>reverse content="<strong>helloworld</strong>"/&gt; outputs <strong>dlrowolleh</strong></li>
</ul>
</li>
<li><strong>Repeat &ndash; </strong>repeats its content a specified amount of times
<ul>
<li><strong>&lt;</strong>repeat value="<strong>2</strong>" content="<strong>helloworld</strong>"/&gt; outputs <strong>helloworldhelloworld</strong></li>
</ul>
</li>
<li><strong>Stop &ndash; </strong>&lt;stop/&gt; - marks the end of the <strong>BML</strong></li>
</ul>
<p>Your task is to write a program that correctly parses all currently supported BML tags and outputs the result to the console.</p>
<p>You should <strong>not</strong> output empty lines. For the content tag to be considered non-empty, it must contain <strong>at least one character</strong>.</p>
<h3>Input</h3>
<ul>
<li>Until the <strong>stop</strong> tag is reached you receive <strong>one</strong> basic mark-up language tag per line</li>
<li>There are <strong>no invalid</strong> tags or attributes. There may be whitespace <strong>anywhere</strong> in the input</li>
</ul>
<h3>Output</h3>
<ul>
<li>Print the correctly formatted output to the console according to the above described rules.</li>
<li>Each line must have a number, starting from 1, in format &ldquo;&lt;number&gt;. &lt;output&gt;&rdquo;</li>
<li>The &lt;repeat/&gt; tag outputs each string on a new line</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>There are no more than 15 lines of input</li>
<li>The <strong>content</strong> length is in range [0 &hellip; 50]. It will not contain double quotes &lsquo; " &lsquo;</li>
<li>The <strong>value</strong> attribute is in range [0 &hellip; 10]</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<table width="599">
<tbody>
<tr>
<td width="341">
<p><strong>Input</strong></p>
</td>
<td width="258">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="341">
<p>&lt;inverse content="HelloWorlD"/&gt;</p>
<p><strong>&lt;</strong>reverse content="helloworld"<strong>/&gt;</strong></p>
<p><strong>&lt;</strong>reverse content="helloworld"<strong>/&gt;</strong></p>
<p><strong>&lt;</strong>repeat value="2" content="helloworld"/&gt;</p>
<p>&lt;stop/&gt;</p>
</td>
<td width="258">
<p>1. hELLOwORLd</p>
<p>2. dlrowolleh</p>
<p>3. dlrowolleh</p>
<p>4. helloworld</p>
<p>5. helloworld</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="341">
<p><strong>Input</strong></p>
</td>
<td width="258">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="341">
<p><strong>&lt;</strong>repeat value="2" content="12345"/&gt;</p>
<p><strong>&lt;</strong>repeat value="5" content="12346"/&gt;</p>
<p>&lt;stop/&gt;</p>
</td>
<td width="258">
<p>1. 12345</p>
<p>2. 12345</p>
<p>3. 12346</p>
<p>4. 12346</p>
<p>5. 12346</p>
<p>6. 12346</p>
<p>7. 12346</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>