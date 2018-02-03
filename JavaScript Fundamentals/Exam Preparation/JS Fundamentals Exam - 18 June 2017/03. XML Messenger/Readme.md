<h1>Problem 3 &ndash; XML Messenger</h1>
<p><em>XML may not see much use these days, but there is legacy software out there that needs maintenance. You are tasked by your boss to add an HTML parser to an old messaging app. The catch &ndash; it has to support all of its versions!</em></p>
<p>Write a JavaScript program that parses messages from XML format to HTML for display on a web page. A message has a body (the text) and attributes, which contain metadata &ndash; who sent the message, and who it is targeted at. This is the general format:</p>
<p>&lt;message to="Alice" from="Bob"&gt;This is a test&lt;/message&gt;</p>
<p>A valid message will <strong>always be enclosed</strong> in an opening and closing &lt;message&gt; tags and will have <strong>no extra characters</strong> before the opening and after the closing tag. Inside the opening tag, there will be only valid attributes. If the message does not match this format or not all characters belong to an attribute, print "Invalid message format".</p>
<p>The opening tag contains the <strong>attributes</strong>. An attribute is in the form key="value", where the <strong>key</strong> will only contain <strong>lowercase Latin letters</strong> and the <strong>value</strong> will contain <strong>Latin alphanumeric characters, spaces and dots</strong>. Both key and value must be <strong>at least one character long</strong>. Characters which do not belong to a valid attribute must not be accepted &ndash; such messages are <strong>invalid</strong>. If the message format is valid, but it doesn&rsquo;t have both valid to and from attributes, print "Missing attributes".</p>
<p>Messages come from different versions of the software, so they <strong>may have additional attributes</strong>, but we only care about the sender and recipient. The to and from attributes <strong>may appear in</strong> <strong>different order</strong> along with other attributes, which we ignore &ndash; the message is still <strong>valid</strong>.</p>
<p>The body of the message <strong>may contain any character</strong>, including line breaks (\n control symbol) &ndash; there is no need to validate it. Every time you encounter a line break, you must print the following text in a new paragraph. <strong>See the examples for details</strong>.</p>
<p>The following message are <strong>all valid</strong>:</p>
<p>&lt;message to="Bob" from="Alice" timestamp="1497254092"&gt;Hey man, what's up?&lt;/message&gt;</p>
<p>&lt;message from="Ivan Ivanov" to="Grace"&gt;Not much, just chillin. How about you?&lt;/message&gt;</p>
<p>&lt;message to="MasterBlaster" from="TheAnimal" timestamp="1497254114"&gt;Same old, same old\nLet's go out for a beer&lt;/message&gt;</p>
<p>&lt;message version="2.0" to="Alice" from="Charlie"&gt;TGIF!&lt;/message&gt;</p>
<p>The sender of the message is highlighted in green, while the recipient is in blue. Note the order may be mixed and the additional attributes are just ignored (but are still in valid key-value format).</p>
<p>The following messages are <strong>all invalid</strong> and an <strong>error message</strong> must be printed, as instructed above:</p>
<table width="695">
<tbody>
<tr>
<td width="469">
<p><strong>Message</strong></p>
</td>
<td width="227">
<p><strong>Reason</strong></p>
</td>
</tr>
<tr>
<td width="469">
<p>&lt;message from="Alice" timestamp="1497254112"&gt;This is a test&lt;/message&gt;</p>
</td>
<td width="227">
<p>missing to attribute</p>
</td>
</tr>
<tr>
<td width="469">
<p>&lt;message to="Matilda" from="Charlie"&gt;&lt;media type="image" src="slyfox.jpg"/&gt;&lt;/message&gt;&lt;meta version="2.0"/&gt;</p>
</td>
<td width="227">
<p>extra characters after closing tag</p>
</td>
</tr>
<tr>
<td width="469">
<p>&lt;message from="MasterBlaster" to="TheAnimal" color="#FF340B"&gt;FWD: Funny stuff&lt;/message&gt;</p>
</td>
<td width="227">
<p>invalid characters in attribute (don&rsquo;t form a valid attribute)</p>
</td>
</tr>
<tr>
<td width="469">
<p>&lt;message from="Hillary" to="Edward" secret:true&gt;VGhpcyBpcyBhIHRlc3Q&lt;/message&gt;</p>
</td>
<td width="227">
<p>invalid characters in opening tag (don&rsquo;t form a valid attribute)</p>
</td>
</tr>
</tbody>
</table>
<p>After you parse the message and extract the sender, recipient and message body, print the HTML-formatted result:</p>
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Bob&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Same old, same old&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
<p>Note that if there is a <strong>line break</strong> in the message body, you have to add an additional <strong>paragraph</strong>. Nested elements are <strong>indented</strong> by two spaces for each level. <strong>See the examples for more details</strong>.</p>
<h3>Input</h3>
<p>You will receive a <strong>single string</strong> as input &ndash; a message that needs to be <strong>validated</strong>.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> the HTML-formatted <strong>result</strong> or an <strong>error message</strong>, depending on the validation.</p>
<h3>Constraints</h3>
<ul>
<li>The message body will not contain XML brackets (&lt;&gt;), there is no need to validate it</li>
<li>There may be any number of spaces before and after an attribute</li>
<li>An attribute will <strong>not</strong> contain spaces before or after the equal sign</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;message to="Bob" from="Alice" timestamp="1497254092"&gt;Hey man, what's up?&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Bob&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Hey man, what's up?&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;message from="John Doe" to="Alice"&gt;Not much, just chillin. How about you?&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;John Doe&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Not much, just chillin. How about you?&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;message from="Alice" timestamp="1497254112"&gt;Same old, same old&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Missing attributes</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;message to="Bob" from="Alice" timestamp="1497254114"&gt;Same old, same old</p>
<p>Let's go out for a beer&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;article&gt;</p>
<p>&nbsp; &lt;div&gt;From: &lt;span class="sender"&gt;Alice&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;To: &lt;span class="recipient"&gt;Bob&lt;/span&gt;&lt;/div&gt;</p>
<p>&nbsp; &lt;div&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Same old, same old&lt;/p&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;p&gt;Let's go out for a beer&lt;/p&gt;</p>
<p>&nbsp; &lt;/div&gt;</p>
<p>&lt;/article&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Note</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Note the line break in the input message &ndash; the body has an extra paragraph! To test locally, place a \n control symbol in the string.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;message to="Alice" from="Charlie"&gt;&lt;img src="fox.jpg"/&gt;&lt;/message&gt;&lt;meta version="2"/&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid message format</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;message from="Hillary" to="Edward" secret:true&gt;VGhpcyBpcyBhIHRlc3Q&lt;/message&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid message format</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>