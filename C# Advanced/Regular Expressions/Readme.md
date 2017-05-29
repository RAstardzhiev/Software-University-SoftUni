<h1>Exercises: Regular Expressions</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016">"CSharp Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Match Full Name</h2>
<p>Write a regular expression to match a valid full name. A valid full name consists of <strong>two words</strong>, each word <strong>starts</strong> with a <strong>capital letter</strong> and contains <strong>only lowercase letters afterwards</strong>; each word should be <strong>at least two letters long</strong>; the two words should be <strong>separated by a single space</strong>.</p>
<p>To help you out, we've outlined several steps:</p>
<ul>
<li>Use an online regex tester like <a href="https://regex101.com/">https://regex101.com/</a></li>
<li>Check out how to use <strong>character sets</strong> (denoted with square brackets - "[]")</li>
<li>Specify that you want two words with a space between them (the <strong>space character ' '</strong>, and not any whitespace symbol)</li>
<li>For each word, specify that it should begin with an uppercase letter using a <strong>character set</strong>. The desired characters are in a range &ndash; <strong>from 'A' to 'Z'</strong>.</li>
<li>For each word, specify that what follows the first letter are only <strong>lowercase letters</strong>, one or more &ndash; use another character set and the correct <strong>quantifier</strong>.</li>
<li>To prevent capturing of letters across new lines, put "\b" at the beginning and at the end of your regex. This will ensure that what precedes and what follows the match is a word boundary (like a new line).</li>
</ul>
<p>In order to check your regex, use these values for reference (paste all of them in the Test String field):</p>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="221">
<p><strong>Match ALL of these</strong></p>
</td>
<td width="469">
<p><strong>Match NONE of these</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>Ivan Ivanov</p>
</td>
<td width="469">
<p>ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ivanov</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="692">
<tbody>
<tr>
<td width="220">
<p><strong>Input</strong></p>
</td>
<td width="471">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="220">
<p>ivan ivanov</p>
<p>Ivan Ivanov</p>
<p>end</p>
</td>
<td width="471">
<p>Ivan Ivanov</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Match Phone Number</h2>
<p>Write a regular expression to match a valid phone number from Sofia. A valid number will start with "+359" followed by the area code (2) and then the number itself, consisting of 7 digits (separated in two group of 3 and 4 digits respectively). The different parts of the number are separated by <strong>either a space or a hyphen</strong> ('-'). Refer to the examples to get the idea.</p>
<ul>
<li>Use quantifiers to match a specific number of digits</li>
<li>Use a capturing group to make sure the delimiter is <strong>only one of the allowed characters</strong> <strong>(space or hyphen)</strong> and not a combination of both. Use the group number to achieve this</li>
<li>Add a word boundary at the end of the match to avoid partial matches (the last example on the right-hand side)</li>
<li>Ensure that before the '+' sign there is either a space or the beginning of the string</li>
</ul>
<h3>Examples</h3>
<table width="654">
<tbody>
<tr>
<td width="162">
<p><strong>Match ALL of these</strong></p>
</td>
<td width="492">
<p><strong>Match NONE of these</strong></p>
</td>
</tr>
<tr>
<td width="162">
<p>+359 2 222 2222</p>
<p>+359-2-222-2222</p>
</td>
<td width="492">
<p>359-2-222-2222, +359/2/222/2222, +359-2 222 2222</p>
<p>+359 2-222-2222, +359-2-222-222, +359-2-222-22222</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="654">
<tbody>
<tr>
<td width="163">
<p><strong>Input</strong></p>
</td>
<td width="491">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="163">
<p>+359 2 222 2222</p>
<p>+3591345123</p>
<p>end</p>
</td>
<td width="491">
<p>+359 2 222 2222</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="163">
<p>+359 2 234 5678</p>
<p>+359-2-234-5678</p>
<p>+359-2 234-5678</p>
<p>end</p>
</td>
<td width="491">
<p>+359 2 234 5678</p>
<p>+359-2-234-5678</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Series of Letters</h2>
<p>Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.</p>
<h3>Examples</h3>
<table width="340">
<tbody>
<tr>
<td width="220">
<p><strong>Input</strong></p>
</td>
<td width="120">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="220">
<p>aaaaabbbbbcdddeeeedssaa</p>
</td>
<td width="120">
<p>abcdedsa</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Replace &lt;a&gt; tag</h2>
<p>Write a program that replaces in a HTML document given as string <strong>all the tags &lt;a href=&hellip;&gt;&hellip;&lt;/a&gt;</strong> with corresponding <strong>tags [URL href=&hellip;&gt;&hellip;[/URL]</strong>. Read an input, until you receive <strong>&ldquo;end&rdquo; command</strong>. Print the result on the console.</p>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="330">
<p><strong>Input</strong></p>
</td>
<td width="358">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="330">
<p>&lt;ul&gt; &lt;li&gt; &lt;a href=<strong>"http://softuni.bg"</strong>&gt;SoftUni&lt;/a&gt;</p>
<p>&nbsp;&lt;/li&gt; &lt;/ul&gt;</p>
<p><strong>end</strong></p>
</td>
<td width="358">
<p>&lt;ul&gt; &lt;li&gt;</p>
<p>&nbsp; [URL href=<strong>http://softuni.bg</strong>&gt;SoftUni[/URL]</p>
<p>&nbsp;&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Note</strong>: The input may be read on a single line (unlike the example above) or from a file. Remove all new lines if you choose the first approach.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Extract Emails</h2>
<p>Write a program to <strong>extract all email addresses from a given text</strong>. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format <strong>&lt;user&gt;@&lt;host&gt;</strong>, where:</p>
<ul>
<li><strong>&lt;user&gt; </strong>is a sequence of letters and digits, where '<strong>.</strong>', '<strong>-</strong>' and '<strong>_</strong>' can appear between them. Examples of valid users: "<strong>stephan</strong>", "<strong>mike03</strong>", "<strong>johnson</strong>", "<strong>st_steward</strong>", "<strong>softuni-bulgaria</strong>", "<strong>12345</strong>". Examples of invalid users: ''<strong>--123</strong>", ".....", "<strong>nakov_-</strong>", "<strong>_steve</strong>", "<strong>.info</strong>".</li>
<li><strong>&lt;host&gt; </strong>is a sequence of at least two words, separated by dots '<strong>.</strong>'. Each word is sequence of letters and can have hyphens '<strong>-</strong>' between the letters. Examples of hosts: "<strong>bg</strong>", "<strong>software-university.com</strong>", "<strong>intoprogramming.info</strong>", "<strong>mail.softuni.org</strong>". Examples of invalid hosts: "<strong>helloworld</strong>", "<strong>.unknown.soft.</strong>", "<strong>invalid-host-</strong>", "<strong>invalid-</strong>".</li>
<li>Examples of <strong>valid emails</strong>: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, <a href="mailto:info-bg@software-university.software.academy">info-bg@software-university.software.academy</a>.</li>
<li>Examples of <strong>invalid emails</strong>: <a href="mailto:--123@gmail.com">--123@gmail.com</a>, &hellip;@mail.bg, <a href="mailto:.info@info.info">.info@info.info</a>, <a href="mailto:_steve@yahoo.cn">_steve@yahoo.cn</a>, mike@helloworld, <a href="mailto:mike@.unknown.soft">mike@.unknown.soft</a>., <a href="mailto:s.johnson@invalid-">johnson@invalid-</a>.</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="694">
<tbody>
<tr>
<td width="496">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="496">
<p>Please contact us at: support@github.com.</p>
</td>
<td width="198">
<p><em>support@github.com</em></p>
</td>
</tr>
<tr>
<td width="496">
<p>Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.</p>
</td>
<td width="198">
<p><em>s.miller@mit.edu</em></p>
<p><em>j.hopking@york.ac.uk</em></p>
</td>
</tr>
<tr>
<td width="496">
<p>Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. &ndash;- steve.parker@softuni.de.</p>
</td>
<td width="198">
<p><em>steve.parker@softuni.de</em></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sentence Extractor</h2>
<p>Write a program that reads a <strong>keyword</strong> and some <strong>text</strong> from the console and prints <strong>all sentences from the text, containing that word</strong>. A sentence is any sequence of words ending with '<strong>.'</strong>, '<strong>!'</strong> or '<strong>?'</strong>.</p>
<h3>Examples</h3>
<table width="694">
<tbody>
<tr>
<td width="197">
<p><strong>Input</strong></p>
</td>
<td width="498">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="197">
<p>is</p>
<p>This <strong>is</strong> my cat! And this <strong>is</strong> my dog. We happily live in Paris &ndash; the most beautiful city in the world! Isn&rsquo;t it great? Well it is :)</p>
</td>
<td width="498">
<p>This is my cat!</p>
<p>&nbsp;And this is my dog.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Valid Usernames</h2>
<p><strong>This problem is from the Java Basics Exam (21 September 2014 Evening). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/34#2"><strong>here</strong></a><strong>.</strong></p>
<p>You are part of the back-end development team of the next Facebook. You are given <strong>a line of usernames</strong>, between one of the following symbols<strong>: space, &ldquo;/&rdquo;, &ldquo;\&rdquo;, &ldquo;(&ldquo;, &ldquo;)&rdquo;.</strong> First you have to export all <strong>valid </strong>usernames. A valid username <strong>starts with a letter</strong> and can contain <strong>only letters, digits and &ldquo;_&rdquo;</strong>. It cannot be <strong>less than 3 or more than 25 symbols</strong> long. Your task is to <strong>sum</strong> the length of <strong>every</strong> <strong>2 consecutive</strong> <strong>valid </strong>usernames and print on the console the 2 valid usernames with <strong>biggest</strong> <strong>sum</strong> of their <strong>lengths, </strong>each on a separate line.</p>
<h3>Input</h3>
<p>The input comes from the console. One line will hold all the data. It will hold <strong>usernames, </strong>divided by the symbols:<strong> space, &ldquo;/&rdquo;, &ldquo;\&rdquo;, &ldquo;(&ldquo;, &ldquo;)&rdquo;.</strong></p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print at the console the 2 <strong>consecutive</strong> <strong>valid usernames</strong> with the <strong>biggest</strong> <strong>sum</strong> of their lengths each on a separate line. If there are <strong>2 or more couples</strong> of usernames with the same sum of their lengths, print he <strong>left most</strong>.</p>
<h3>Constraints</h3>
<ul>
<li>The input line will hold characters in the range [0 &hellip; 9999].</li>
<li>The usernames should <strong>start with a letter</strong> and can contain <strong>only letters, digits and &ldquo;_&rdquo;</strong>.</li>
<li>The username cannot be <strong>less than 3 or</strong> <strong>more than 25 symbols</strong> long.</li>
</ul>
<ul>
<li>Time limit: 0.5 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="594">
<tbody>
<tr>
<td width="405">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="405">
<p>ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref</p>
</td>
<td width="189">
<p>wfsdg</p>
<p>ds2c_vbg</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="594">
<tbody>
<tr>
<td width="406">
<p><strong>Input</strong></p>
</td>
<td width="188">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="406">
<p>min23/ace hahah21 (&nbsp;&nbsp;&nbsp; sasa&nbsp; )&nbsp; att3454/a/a2/abc</p>
</td>
<td width="188">
<p>hahah21</p>
<p>sasa</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="594">
<tbody>
<tr>
<td width="406">
<p><strong>Input</strong></p>
</td>
<td width="188">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="406">
<p>chico/ gosho \ sapunerka (3sas) mazut&nbsp; lelQ_Van4e</p>
</td>
<td width="188">
<p>mazut</p>
<p>lelQ_Van4e</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Extract Hyperlinks</h2>
<p><strong>This problem is originally from the JavaScript Basics Exam (27 July 2014). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/84#2"><strong>here</strong></a><strong>.</strong></p>
<p>Write a program to <strong>extract all hyperlinks</strong> (<strong>&lt;href=&hellip;&gt;</strong>) from a given text. The text comes from the console on a variable number of lines and ends with the command "END". Print at the console the <strong>href</strong> values in the text.</p>
<p>The input text is <strong>standard HTML code</strong>. It may hold many tags and can be formatted in many different forms (with or without whitespace). The <strong>&lt;a&gt;</strong> elements may have many attributes, not only <strong>href</strong>. You should extract only the values of the <strong>href</strong> attributes of all <strong>&lt;a&gt;</strong> elements.</p>
<h3>Input</h3>
<p>The input data comes from the console. It ends when the "END" command is received.</p>
<h3>Output</h3>
<p>Print at the console the <strong>href</strong> values in the text, each at a separate line, in the order they come from the input.</p>
<h3>Constraints</h3>
<ul>
<li>The input will be <strong>well formed HTML fragment</strong> (all tags and attributes will be correctly closed).</li>
<li>Attribute values will never hold tags and hyperlinks, e.g. "<strong>&lt;img alt='&lt;a href="hello"&gt;' /&gt;</strong>" is invalid.</li>
<li>Commented links are also extracted.</li>
<li>The number of input lines will be in the range [1 ... 100].</li>
<li>Allowed working time: 0.1 seconds. Allowed memory: 16</li>
</ul>
<h3>Examples</h3>
<table width="664">
<tbody>
<tr>
<td width="436">
<p><strong>Input</strong></p>
</td>
<td width="228">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="436">
<p>&lt;a href="http://softuni.bg" class="new"&gt;&lt;/a&gt;</p>
<p>END</p>
</td>
<td width="228">
<p>http://softuni.bg</p>
</td>
</tr>
<tr>
<td width="436">
<p>&lt;p&gt;This text has no links&lt;/p&gt;</p>
<p>END</p>
</td>
<td width="228">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="436">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html&gt;</p>
<p>&lt;head&gt;</p>
<p>&nbsp; &lt;title&gt;Hyperlinks&lt;/title&gt;</p>
<p>&nbsp; &lt;link href="theme.css" rel="stylesheet" /&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body&gt;</p>
<p>&lt;ul&gt;&lt;li&gt;&lt;a&nbsp;&nbsp; <strong>href="/"</strong>&nbsp; id="home"&gt;Home&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;a</p>
<p>&nbsp;class="selected" <strong>href=/courses</strong>&gt;Courses&lt;/a&gt;</p>
<p>&lt;/li&gt;&lt;li&gt;&lt;a <strong>href = </strong></p>
<p><strong>'/forum' </strong>&gt;Forum&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;a class="href"</p>
<p>onclick="go()" <strong>href= "#"</strong>&gt;Forum&lt;/a&gt;&lt;/li&gt;</p>
<p>&lt;li&gt;&lt;a id="js" <strong>href =</strong></p>
<p><strong>"javascript:alert('hi yo')"</strong> class="new"&gt;click&lt;/a&gt;&lt;/li&gt;</p>
<p>&lt;li&gt;&lt;a id='nakov' <strong>href =</strong></p>
<p><strong>http://www.nakov.com</strong> class='new'&gt;nak&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;</p>
<p>&lt;a <strong>href="#empty"</strong>&gt;&lt;/a&gt;</p>
<p>&lt;a id="href"&gt;href='fake'&lt;img src='http://abv.bg/i.gif'</p>
<p>alt='abv'/&gt;&lt;/a&gt;&lt;a <strong>href="#"</strong>&gt;&amp;lt;a href='hello'&amp;gt;&lt;/a&gt;</p>
<p>&lt;!-- This code is commented:</p>
<p>&nbsp; &lt;a href="#commented"&gt;commentex hyperlink&lt;/a&gt; --&gt;</p>
<p>&lt;/body&gt;</p>
<p>END</p>
</td>
<td width="228">
<p>/</p>
<p>/courses</p>
<p>/forum</p>
<p>#</p>
<p>javascript:alert('hi yo')</p>
<p>http://www.nakov.com</p>
<p>#empty</p>
<p>#</p>
<p>#commented</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Query Mess</h2>
<p><strong>This problem is originally from the JavaScript Basics Exam (22 November 2014). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/84#3"><strong>here</strong></a><strong>.</strong></p>
<p><strong>Ivancho</strong> participates in a team <strong>project</strong> with colleagues at <strong>SoftUni</strong>.&nbsp; They have to develop <strong>an application</strong>, but something <em>mysterious</em> happened &ndash; at the last moment all team members&hellip; disappeared!&nbsp; And guess what? He is left <strong>alone</strong> to finish the project.&nbsp; All that is left to do is to parse the input data and store it in a special way, but Ivancho has no idea how to do that! Can you help him?</p>
<h3>Input</h3>
<p>The input comes from the console on a variable number of lines and ends when the keyword "END" is received.&nbsp;</p>
<p>For each row of the input, the query string contains pairs field=value. Within each pair, the field name and value are separated by an equals sign, '='. The series of pairs are separated by an ampersand, '&amp;'. The question mark is used as a separator and is not part of the query string. A URL query string may contain another URL as value. The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p><strong>For each input line, print</strong> on the console a line containing the <strong>processed string as follows</strong>:&nbsp; key=[value]nextkey=[another&nbsp; value] &hellip; etc.</p>
<p><strong>Multiple whitespace</strong> characters should be reduced to one inside value/key names, but there shouldn&rsquo;t be any whitespaces before/after extracted <strong>keys</strong> and <strong>values</strong>. If a key <strong>already exists</strong>, the value is added with comma and space after other values of the existing key in the current string.&nbsp; See the <strong>examples</strong> below.&nbsp;</p>
<h3>Constraints</h3>
<ul>
<li>SPACE is encoded as '+' or "%20". Letters (A-Z&nbsp;and a-z), numbers (0-9), the characters '*', '-', '.', '_' and <em>other non-special symbols</em> are left as-is.</li>
<li>Allowed working time: 0.1 seconds. Allowed memory: 16</li>
</ul>
<h3>Examples</h3>
<table width="699">
<tbody>
<tr>
<td width="340">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="340">
<p>login=student&amp;password=student</p>
<p>END</p>
</td>
<td width="359">
<p>login=[student]password=[student]</p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p>field=value1&amp;field=value2&amp;field=value3</p>
<p><a href="http://example.com/over/there?name=ferret">http://example.com/over/there?name=ferret</a></p>
<p>END</p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p>field=[value1, value2, value3]</p>
<p>name=[ferret]</p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p>foo=%20foo&amp;value=+val&amp;foo+=5+%20+203</p>
<p>foo=poo%20&amp;value=valley&amp;dog=wow+</p>
<p>url=https://softuni.bg/trainings/coursesinstances/details/1070</p>
<p><a href="https://softuni.bg/trainings.asp?trainer=nakov&amp;course=oop&amp;course=php">https://softuni.bg/trainings.asp?trainer=nakov&amp;course=oop&amp;course=php</a></p>
<p>END</p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="699">
<p>foo=[foo, 5 203]value=[val]</p>
<p>foo=[poo]value=[valley]dog=[wow]</p>
<p>url=[https://softuni.bg/trainings/coursesinstances/details/1070]</p>
<p>trainer=[nakov]course=[oop, php]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 10. * Use Your Chains, Buddy</h2>
<p><strong>This problem is from the JavaScript Basics Exam (9 January 2015). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/56#2"><strong>here</strong></a><strong>.</strong></p>
<p>You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut. You need to get there by car. But there is so much snow that you need to use car chains. In order to put them on the wheels correctly, you need to read the manual. But it is encrypted&hellip;</p>
<p>As input you will receive <strong>an HTML document</strong> as a <strong>single string</strong>. You need to get the text from <strong>all the &lt;p&gt; tags </strong>and replace all characters which are <strong>not small letters and numbers</strong> with a space <strong>" "</strong>. After that you must decrypt the text &ndash; all letters <strong>from a to m</strong> are <strong>converted</strong> to letters <strong>from n to z</strong> (a &agrave; n; b &agrave; o; &hellip; m &agrave; z). The letters <strong>from n to z</strong> are <strong>converted</strong> to letters <strong>from a to m</strong> (n &agrave; a; o &agrave; b; &hellip; z &agrave; m). All <strong>multiple</strong> spaces should then be replaced by only <strong>one space</strong>.</p>
<p>For example, if we have <strong>"&lt;div&gt;Santa&lt;/div&gt;&lt;p&gt;znahny # grkg ()&amp;^^^&amp;12&lt;/p&gt;"</strong> we extract <strong>"znahny # grkg ()&amp;^^^&amp;12"</strong>. Every <strong>character</strong> that is <strong>not a small letter or a number</strong> is replaced with a space (<strong>"znahny grkg&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 12"</strong>). We convert each small letter as described above (<strong>"znahny grkg&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 12" </strong><strong>&agrave;</strong><strong> "manual text&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 12"</strong>) and replace all multiple spaces with only <strong>one space</strong> (<strong>"manual text 12"</strong>). Finally, we concatenate the decrypted text from all <strong>&lt;p&gt;&lt;/p&gt;</strong> tags (in this case, it's only one). And there you go &ndash; you have the manual ready to read!</p>
<h3>Input</h3>
<p>The input is read from the console and consists of just one line &ndash; the <strong>string</strong> with the <strong>HTML document</strong>.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p><strong>Print</strong> on a single line the decrypted text of the manual. See the given <strong>examples</strong> below.</p>
<h3>Constraints</h3>
<ul>
<li>Allowed working time: 0.2 seconds. Allowed memory: 16</li>
</ul>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="576">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="576">
<p>&lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;hello&lt;/h1&gt;&lt;p&gt;<strong>znahny!@#%&amp;&amp;&amp;&amp;****</strong>&lt;/p&gt;&lt;div&gt;&lt;button&gt;dsad&lt;/button&gt;&lt;/div&gt;&lt;p&gt;<strong>grkg^^^^%%%)))([]12</strong>&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;</p>
</td>
</tr>
<tr>
<td width="576">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="576">
<p>manual text 12</p>
</td>
</tr>
<tr>
<td width="576">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="576">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="576">
<p>&lt;html&gt;&lt;head&gt;&lt;title&gt;&lt;/title&gt;&lt;/head&gt;&lt;body&gt;&lt;h1&gt;Intro&lt;/h1&gt;&lt;ul&gt;&lt;li&gt;Item01&lt;/li&gt;&lt;li&gt;Item02&lt;/li&gt;&lt;li&gt;Item03&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;<strong>jura qevivat va jrg fyvccrel fabjl</strong>&lt;/p&gt;&lt;div&gt;&lt;button&gt;Click me, baby!&lt;/button&gt;&lt;/div&gt;&lt;p&gt; <strong>pbaqvgvbaf fabj&nbsp; qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx</strong> &lt;/p&gt;&lt;span&gt;This manual is false, do not trust it! The illuminati wrote it down to trick you!&lt;/span&gt;&lt;p&gt;<strong>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</strong>&lt;/p&gt;&lt;p&gt;<strong> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</strong>&lt;/p&gt;&lt;/body&gt;</p>
</td>
</tr>
<tr>
<td width="576">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="576">
<p>when driving in wet slippery snowy conditions snow dchains are absolutely essential for safe handling although snow chains may look intimidating the basic idea is really simple fit them over your tires drive forward slowly and tighten them up in cold wet conditions this is easier said than done but if you put on your tires</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 11. &nbsp;** Semantic HTML</h2>
<p><strong>This problem is originally from the PHP Basics Exam (31 August 2014). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/84#4"><strong>here</strong></a><strong>.</strong></p>
<p>You are given an <strong>HTML code</strong>, written in the old <strong>non-semantic</strong> style using tags like <strong>&lt;div id="header"&gt;</strong>, <strong>&lt;div class="section"&gt;</strong>, etc. Your task is to write a program that <strong>converts this HTML to semantic HTML</strong> by changing tags like <strong>&lt;div id="header"&gt;</strong> to their semantic equivalent like <strong>&lt;header&gt;</strong>.</p>
<p>The non-semantic tags that should be converted are <strong>always &lt;div&gt;</strong>s and have either <strong>id</strong> or <strong>class</strong> with one of the following values: "<strong>main</strong>", "<strong>header</strong>", "<strong>nav</strong>", "<strong>article</strong>", "<strong>section</strong>", "<strong>aside</strong>" or "<strong>footer</strong>". Their corresponding closing tags are always followed by a comment like <strong>&lt;!-- header --&gt;</strong>, <strong>&lt;!-- nav --&gt;</strong>, etc. staying at the same line, after the tag.</p>
<h3>Input</h3>
<p>The input will be read from the console. It will contain a variable number of lines and will end with the keyword "<strong>END</strong>".</p>
<h3>Output</h3>
<p>The output is the semantic version of the input HTML. In all converted tags you should <strong>replace multiple spaces</strong> (like <strong>&lt;header&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; style="color:red"&gt;</strong>) with a single space and remove excessive spaces at the end (like <strong>&lt;footer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &gt;</strong>). See the examples.</p>
<h3>Constraints</h3>
<ul>
<li>Each line from the input holds either an HTML <strong>opening tag</strong> or an HTML <strong>closing tag</strong> or HTML <strong>text content</strong>.</li>
<li>There will be no tags that span several lines and no lines that hold multiple tags.</li>
<li>Attributes values will always be enclosed in <strong>double quotes</strong> <strong>"</strong>.</li>
<li>Tags will never have <strong>id</strong> and <strong>class</strong> at the same time.</li>
<li>The HTML will be <strong>valid</strong>. Opening and closing tags will match correctly.</li>
<li><strong>Whitespace</strong> may occur between attribute names, values and around comments (see the examples).</li>
<li>Allowed working time: 0.1 seconds. Allowed memory: 16</li>
</ul>
<h3>Examples</h3>
<table width="692">
<tbody>
<tr>
<td width="382">
<p><strong>Input</strong></p>
</td>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="382">
<p>&lt;div id="header"&gt;</p>
<p>&lt;/div&gt; &lt;!-- header --&gt;</p>
<p>END</p>
</td>
<td width="310">
<p>&lt;header&gt;</p>
<p>&lt;/header&gt;</p>
</td>
</tr>
<tr>
<td width="382">
<p>&lt;div style="color:red" id="header"&gt;</p>
<p>&lt;/div&gt; &lt;!-- header --&gt;</p>
<p>END</p>
</td>
<td width="310">
<p>&lt;header style="color:red"&gt;</p>
<p>&lt;/header&gt;</p>
</td>
</tr>
<tr>
<td width="382">
<p>&lt;div class="header" style="color:blue"&gt;</p>
<p>&lt;/div&gt; &lt;!-- header --&gt;</p>
<p>END</p>
</td>
<td width="310">
<p>&lt;header style="color:blue"&gt;</p>
<p>&lt;/header&gt;</p>
</td>
</tr>
<tr>
<td width="382">
<p>&lt;div align="left" id="nav" style="color:blue"&gt;</p>
<p>&nbsp; &lt;ul class="header"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;li id="main"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hi, I have id="main".</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/li&gt;</p>
<p>&nbsp; &lt;/ul&gt;</p>
<p>&lt;/div&gt; &lt;!-- nav --&gt;</p>
<p>END</p>
</td>
<td width="310">
<p>&lt;nav align="left" style="color:blue"&gt;</p>
<p>&nbsp; &lt;ul class="header"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;li id="main"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hi, I have id="main".</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/li&gt;</p>
<p>&nbsp; &lt;/ul&gt;</p>
<p>&lt;/nav&gt;</p>
</td>
</tr>
<tr>
<td width="382">
<p>&nbsp; &lt;p class = "section" &gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;div style = "border: 1px" id = "header" &gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Header</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;div id = "nav" &gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nav</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/div&gt;&nbsp;&nbsp; &lt;!--&nbsp;&nbsp; nav&nbsp;&nbsp; --&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/div&gt;&nbsp; &lt;!--header--&gt;</p>
<p>&nbsp; &lt;/p&gt; &lt;!-- end paragraph section --&gt;</p>
<p>END</p>
</td>
<td width="310">
<p>&nbsp; &lt;p class = "section" &gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;header style = "border: 1px"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Header</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;nav&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nav</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/nav&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/header&gt;</p>
<p>&nbsp; &lt;/p&gt; &lt;!-- end paragraph section --&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>