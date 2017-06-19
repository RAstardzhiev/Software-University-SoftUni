<h1>Problem 3 &ndash; NMS</h1>
<p>Furion has created the NMS &ndash; Natural Messaging Service, for all the flowers. They communicate through special messages which only they understand. You want to know what the flowers are saying to each other, that&rsquo;s why you&rsquo;ve decided to create a software program which translates the messages.</p>
<p>You will be given several input lines of random, <strong>upper case</strong> and <strong>lower case, English alphabet letters</strong>. You need to find <strong>all words</strong> in that message. A word in the Natural language is an <strong>increasing sequence of letters</strong>.</p>
<p>Тhe message <strong>&ldquo;abc&rdquo;</strong> is a <strong>single</strong> word, because <strong>&ldquo;b&rdquo;&gt;&ldquo;a&rdquo; </strong>and <strong>&ldquo;c&rdquo;&gt;&ldquo;b&rdquo;</strong>, therefore it <strong>IS</strong> an increasing sequence and it is counted as a word. The message <strong>&ldquo;abca&rdquo;</strong> consists of <strong>2</strong> words &ndash; <strong>&ldquo;abc&rdquo;</strong> and <strong>&ldquo;a&rdquo;</strong> because <strong>&ldquo;a&rdquo;&lt;&ldquo;c&rdquo; </strong>and it <strong>breaks </strong>the increasing sequence and <strong>begins a new one.</strong><strong> <br /> Equal letters</strong> do <strong>NOT</strong> break the subsequence. The <strong>comparison</strong> is <strong>case-insensitive</strong>.</p>
<p>The input <strong>ends</strong> when you receive the command <strong>&ldquo;---NMS SEND---&ldquo;</strong>. After it you will receive a <strong>specified delimiter</strong>. You need to <strong>break the whole message</strong> into <strong>words</strong> and print them as a text, each separated with <strong>the given delimiter</strong>. The delimiter can be a line of <strong>random ASCII characters</strong> with <strong>random length</strong>.</p>
<p>NOTE: The <strong>comparison</strong> is <strong>case-insensitive</strong>, as specified above, therefore <strong>&ldquo;B&rdquo;&gt;&ldquo;a&rdquo;</strong>, and <strong>&ldquo;A&rdquo;=&rdquo;a&rdquo;</strong>.</p>
<h3>Input</h3>
<ul>
<li>You will be receiving lines of input containing random English alphabet letters, until you receive the line &ndash; <br /> <strong>&ldquo;---NMS SEND---&ldquo;</strong>.</li>
<li>After you receive the ending command, you will receive the delimiter on the next line, as <strong>the last line of input</strong>.</li>
</ul>
<h3>Output</h3>
<ul>
<li>As output you need to print all the words you&rsquo;ve found, <strong>separated by the given delimiter</strong>.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>All of the input lines, except the input-terminating one and the delimiter, will consist only of uppercase and lowercase English alphabet letters.</li>
<li>The maximum lines of input you can receive is 1000.</li>
<li>The delimiter will be a string, which can consist of any ASCII character.</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="689">
<tbody>
<tr>
<td width="339">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="350">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="339">
<p><strong>Foxtrot</strong></p>
<p><strong>Uniform</strong></p>
<p><strong>Charlie<br /> Kilo</strong></p>
<p><strong>---NMS SEND---</strong></p>
<p><strong>(space)</strong></p>
</td>
<td width="350">
<p><strong>Fox t r otU n i for m Ch ar l i eK ilo</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="689">
<tbody>
<tr>
<td width="339">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="350">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="339">
<p><strong>abcdefghijklmnopqrstuvwxyz</strong></p>
<p><strong>ABCDEFGHIJKLMNOPQRSTUVWXYZ</strong></p>
<p><strong>---NMS SEND---</strong></p>
<p><strong>---NMS SEND---</strong></p>
</td>
<td width="350">
<p><strong>abcdefghijklmnopqrstuvwxyz---NMS SEND---ABCDEFGHIJKLMNOPQRSTUVWXYZ</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>