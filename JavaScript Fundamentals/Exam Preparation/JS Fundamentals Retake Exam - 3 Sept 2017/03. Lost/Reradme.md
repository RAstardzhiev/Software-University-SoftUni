<h1>Problem 3 &ndash; Lost in the Mountains</h1>
<p><em>The expedition is over and everyone has returned successfully to the rest house. It turns out, however, that one from the group has fallen behind. He has sent a message to the leader but his device is broken and his message contains unwanted symbols, which prevent it from being read. Since the leader does not understand anything from programming, he has assigned the task of decrypting to you.</em></p>
<p>You will receive a text (<strong>string</strong>), which can contain <strong>all of the ASCII symbols</strong>, <strong>including</strong> <strong>new lines</strong> and <strong>tabs</strong>. The location of the lost person and his message must be retrieved from this string. The text contains a <strong>keyword</strong> that indicates the <strong>beginning</strong> and the <strong>end</strong> of the <strong>message</strong>. The geographical coordinates come as <strong>a</strong> <strong>pair</strong> of longitude ("<strong>east</strong>") and latitude ("<strong>north</strong>") and each coordinate should meet the following conditions:</p>
<ol>
<li>It should start with "<strong>north</strong>"/"<strong>east</strong>", <strong>case-insensitive</strong>;</li>
<li>Next come <strong>2 digits</strong>, which form the <strong>whole part of the degrees</strong>;</li>
<li>The whole part of the degrees is separated from the decimal part by "<strong>,</strong>" and there may be any number of characters between them, <strong>except</strong> ","</li>
<li>The <strong>decimal part</strong> consists of <strong>6 digits</strong></li>
</ol>
<p>In case there is <strong>more than one</strong> longitude or latitude in the text, take <strong>the latter</strong>. The message is surrounded by the <strong>keyword</strong>, which will be the <strong>first argument</strong> from the input. The second argument from the input will be the <strong>text</strong>, containing <strong>both the location</strong> and <strong>the message</strong> of the lost person. See the examples below to understand how it works.</p>
<p><strong>Input</strong></p>
<p>The first argument contains the keyword and the second argument contains the text. There will always be <strong>at least one pair of coordinates</strong>.</p>
<p><strong>Output</strong></p>
<p>Print the latitude on the first line of the output in the following format:</p>
<p><strong>&lt;<em>degrees</em>&gt;.&lt;<em>decimal part</em>&gt; N</strong></p>
<p>On the second line of the output print the longitude in the following format:</p>
<p><strong>&lt;<em>degrees</em>&gt;.&lt;<em>decimal part</em>&gt; E</strong></p>
<p>On the last line print the message:</p>
<p><strong>Message:<em> &lt;message&gt;</em></strong></p>
<p>&nbsp;</p>
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
<p>&lt;&gt;&nbsp;</p>
<p>o u%&amp;lu43t&amp;^ftgv&gt;&lt;nortH4276hrv756dcc,&nbsp; jytbu64574655k &lt;&gt;ThE sanDwich is iN the refrIGErator&lt;&gt;yl i75evEAsTer23,lfwe 987324tlblu6b</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>42.645746 N</p>
<p>23.987324 E</p>
<p>Message: ThE sanDwich is iN the refrIGErator</p>
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
<p>4ds</p>
<p>eaSt 19,432567noRt north east 53,123456north 43,3213454dsNot all those who wander are lost.4dsnorth 47,874532</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>47.874532 N</p>
<p>19.432567 E</p>
<p>Message: Not all those who wander are lost.</p>
</td>
</tr>
</tbody>
</table>
<p>Note there are three instances of north coordinates &ndash; the first two are ignored and only the last one is counted.</p>