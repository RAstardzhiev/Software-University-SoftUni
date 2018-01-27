<h1>Lab: Strings and Regular Expressions</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/312">https://judge.softuni.bg/Contests/312</a>.</p>
<h2>1.&nbsp;&nbsp; Print Letters</h2>
<p>Write a JS function that prints all the symbols of a string, each on a new line.</p>
<p>The <strong>input</strong> comes as a single string argument.</p>
<p>The <strong>output</strong> is printed on the console, each letter on a new line.</p>
<h3>Examples</h3>
<table width="302">
<tbody>
<tr>
<td width="161">
<p><strong>Input</strong></p>
</td>
<td width="142">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="161">
<p>'Hello, World!'</p>
</td>
<td width="142">
<p>str[0] -&gt; H</p>
<p>str[1] -&gt; e</p>
<p>str[2] -&gt; l</p>
<p>str[3] -&gt; l</p>
<p>str[4] -&gt; o</p>
<p>str[5] -&gt; ,</p>
<p>str[6] -&gt;&nbsp;</p>
<p>str[7] -&gt; W</p>
<p>str[8] -&gt; o</p>
<p>str[9] -&gt; r</p>
<p>str[10] -&gt; l</p>
<p>str[11] -&gt; d</p>
<p>str[12] -&gt; !</p>
</td>
</tr>
<tr>
<td width="161">
<p>'SoftUni'</p>
</td>
<td width="142">
<p>str[0] -&gt; S</p>
<p>str[1] -&gt; o</p>
<p>str[2] -&gt; f</p>
<p>str[3] -&gt; t</p>
<p>str[4] -&gt; U</p>
<p>str[5] -&gt; n</p>
<p>str[6] -&gt; i</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Concatenate Reversed</h2>
<p>Write a JS function that reverses a series of strings and prints them concatenated from last to first.</p>
<p>The <strong>input</strong> comes as an array of strings.</p>
<p>The <strong>output</strong> is printed on the console. Print all strings concatenated on a single line, starting from the last input string, going to the first. Reverse each individual string&rsquo;s letters.</p>
<h3>Examples</h3>
<table width="321">
<tbody>
<tr>
<td width="208">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="208">
<p>['I', 'am', 'student']</p>
</td>
<td width="113">
<p>tnedutsmaI</p>
</td>
</tr>
<tr>
<td width="208">
<p>['race', 'car']</p>
</td>
<td width="113">
<p>racecar</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Count Occurrences</h2>
<p>Write a JS function that counts how many times a string occurs in a given text. Overlapping strings are allowed.</p>
<p>The <strong>input</strong> comes as two string arguments. The first element is the target string and the second element is the text in which to search for occurrences.</p>
<p>The <strong>output</strong> should be a number, printed on the console.</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="614">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="614">
<p>'the', 'The quick brown fox jumps over the lay dog.'</p>
</td>
<td width="66">
<p>1</p>
</td>
</tr>
<tr>
<td width="614">
<p>'ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.'</p>
</td>
<td width="66">
<p>7</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Extract Text</h2>
<p>You will be given a text as a string. Write a JS function that extracts and prints only the text that&rsquo;s surrounded by parentheses.</p>
<p>The <strong>input</strong> comes as a single string argument.</p>
<p>The <strong>output</strong> is printed on the console on a single line, in the form of a comma-separated list.</p>
<h3>Examples</h3>
<table width="567">
<tbody>
<tr>
<td width="567">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>'Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)'</p>
</td>
</tr>
<tr>
<td width="567">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="567">
<p>Bulgarian brandy, alcoholic drink</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Aggregate Table</h2>
<p>You will be given a list of towns and incomes for each town, formatted in a table, separated by pipes (|). Write a JS function that extracts the names of all towns and produces a sum of the incomes. Note that splitting may result in empty string elements and the number of spaces may be different in every table.</p>
<p>The <strong>input</strong> comes as array of string elements. Each element is one row in a formatted table.</p>
<p>The <strong>output</strong> is printed on the console on two lines. On the first line, print a comma-separated list of all towns and on the second, the sum of all incomes.</p>
<h3>Examples</h3>
<table width="601">
<tbody>
<tr>
<td width="601">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="601">
<p>['| Sofia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; | 300',</p>
<p>&nbsp;'| Veliko Tarnovo&nbsp; | 500',</p>
<p>&nbsp;'| Yambol&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; | 275']</p>
</td>
</tr>
<tr>
<td width="601">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="601">
<p>Sofia, Veliko Tarnovo, Yambol</p>
<p>1075</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Restaurant Bill</h2>
<p>You are tasked to write a JS function that receives an array of purchases and their prices and prints all your purchases and their total sum.</p>
<p>The <strong>input</strong> comes as an array of string elements &ndash; the elements on even indexes (0, 2, 4&hellip;) are the product names, while the elements on odd indexes (1, 3, 5&hellip;) are the corresponding prices.</p>
<p>The <strong>output</strong> should be printed on the console - a single sentence containing all products and their total sum in the format &ldquo;<strong>You purchased {all products separated by comma + space} for a total sum of {total sum of products}</strong>&rdquo;.</p>
<h3>Examples</h3>
<table width="676">
<tbody>
<tr>
<td width="676">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']</p>
</td>
</tr>
<tr>
<td width="676">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>You purchased Beer Zagorka, Tripe soup, Lasagna for a total sum of 16.14</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="676">
<tbody>
<tr>
<td width="676">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>['Cola', '1.35', 'Pancakes', '2.88']</p>
</td>
</tr>
<tr>
<td width="676">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>You purchased Cola, Pancakes for a total sum of 4.23</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Usernames</h2>
<p>Write a JS function that parses a list of emails and returns a list of usernames, generated from them. Each username is composed from the name of the email address, a period and the first letter of every element in the domain name. See the examples for more information.</p>
<p>The <strong>input</strong> comes as array of string elements. Each element is an email address.</p>
<p>The <strong>output</strong> is printed on the console on a single line as a comma-formatted list.</p>
<h3>Examples</h3>
<table width="601">
<tbody>
<tr>
<td width="601">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="601">
<p>['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com']</p>
</td>
</tr>
<tr>
<td width="601">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="601">
<p>peshoo.gc, todor_43.mdb, foo.bc</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Censorship</h2>
<p>The thought police are at it again and they need your help! Write a JS function that would <strong>censor news articles</strong>. You will be given a text and then a list of strings that need to be blacked out from the text. Replace all occurrences of the strings with dashes of the same length as the string. The strings will <strong>not overlap</strong>, so order of processing is not important. See the examples for more information.</p>
<p>The <strong>input</strong> comes as two arguments &ndash; one string and one array of strings. The first element is the text to scan and the array contains the strings to be censored.</p>
<p>The <strong>output</strong> is the return value of your functions. Save the censored results in a string and return it.</p>
<h3>Examples</h3>
<table width="689">
<tbody>
<tr>
<td width="689">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="689">
<p>'roses are red, violets are blue', ['<strong>, violets are</strong>', '<strong>red</strong>']</p>
</td>
</tr>
<tr>
<td width="689">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="689">
<p>roses are ---------------- blue</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="689">
<tbody>
<tr>
<td width="689">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="689">
<p>'David Ruben Piqtoukun (born 1950) is an Inuit artist from Paulatuk, Northwest Territories. His output includes sculpture and prints; the sculptural work is innovative in its use of mixed media. His materials and imagery bring together modern and traditional Inuit stylistic elements in a personal vision. An example of this is his work "The Passage of Time" (1999), which portrays a shaman in the form of a salmon moving through a hole in a hand. While shamanic imagery is common in much of Inuit art, the hand in this work is sheet metal, not a traditional material such as walrus ivory, caribou antler or soapstone. Ruben\'s brother, Abraham Apakark Anghik Ruben, is also a sculptor. Fellow Inuit artist Floyd Kuptana learned sculpting techniques as an apprentice to David Ruben.', ['<strong>Inuit</strong>']</p>
</td>
</tr>
<tr>
<td width="689">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="689">
<p>David Ruben Piqtoukun (born 1950) is an ----- artist from Paulatuk, Northwest Territories. His output includes sculpture and prints; the sculptural work is innovative in its use of mixed media. His materials and imagery bring together modern and traditional ----- stylistic elements in a personal vision. An example of this is his work "The Passage of Time" (1999), which portrays a shaman in the form of a salmon moving through a hole in a hand. While shamanic imagery is common in much of ----- art, the hand in this work is sheet metal, not a traditional material such as walrus ivory, caribou antler or soapstone. Ruben's brother, Abraham Apakark Anghik Ruben, is also a sculptor. Fellow ----- artist Floyd Kuptana learned sculpting techniques as an apprentice to David Ruben.</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Escaping</h2>
<p>You will be given a list of strings, containing user-submitted data. Write a JS function that prints an HTML list from the data. The strings, however, may contain special HTML characters, which is an oft-used method for injection attacks. To prevent unwanted behavior or harmful content, all special characters need to be replaced with their encoded counterparts &ndash; they will look the same to the user, but will not pose a security risk. Use the following table to compose your function:</p>
<table width="185">
<tbody>
<tr>
<td width="71">
<p><strong>Raw</strong></p>
</td>
<td width="113">
<p><strong>Encoded</strong></p>
</td>
</tr>
<tr>
<td width="71">
<p>&lt;&nbsp;</p>
</td>
<td width="113">
<p>&amp;lt;</p>
</td>
</tr>
<tr>
<td width="71">
<p>&gt;&nbsp;</p>
</td>
<td width="113">
<p>&amp;gt;</p>
</td>
</tr>
<tr>
<td width="71">
<p>&amp;</p>
</td>
<td width="113">
<p>&amp;amp;</p>
</td>
</tr>
<tr>
<td width="71">
<p>"</p>
</td>
<td width="113">
<p>&amp;quot;</p>
</td>
</tr>
</tbody>
</table>
<p>Use the provided HTML template to visually test your code &ndash; if you don&rsquo;t escape the control characters, formatted HTML will show up. Don&rsquo;t care how the HTML template works. Your job is to write the JS escaping function only.</p>
<p>The <strong>input</strong> comes as array of string elements.</p>
<p>The <strong>output</strong> is the return value of your function. Compose the list in a string and return it. See the examples for formatting details.</p>
<table width="690">
<tbody>
<tr>
<td width="690">
<p><strong>HTML</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Escaping&lt;/<strong>title</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div</strong>&gt;&lt;<strong>label </strong><strong>for=</strong><strong>"userInput"</strong>&gt;Paste test input here:&lt;/<strong>label</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>textarea </strong><strong>rows=</strong><strong>"12" </strong><strong>cols=</strong><strong>"40" </strong><strong>id=</strong><strong>"userInput"</strong>&gt;&lt;/<strong>textarea</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Escape"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>onclick=</strong><strong>"</strong><strong>document</strong>.getElementById(<strong>'result'</strong>).<strong>innerHTML </strong>= html<em>Escape</em>(<strong>JSON</strong>.parse(<strong>document</strong>.getElementById(<strong>'userInput'</strong>).<strong>value</strong>.replace(/'/g, String.fromCharCode(34))));<strong>"</strong>/&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div</strong>&gt;&lt;<strong>label </strong><strong>for=</strong><strong>"result"</strong>&gt;Results will show up here:&lt;/<strong>label</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"result"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>function html</strong><em>Escape</em>(input) {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="690">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>['&lt;b&gt;unescaped text&lt;/b&gt;', 'normal text']</p>
</td>
</tr>
<tr>
<td width="690">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>&lt;ul&gt;</p>
<p>&nbsp; &lt;li&gt;&amp;lt;b&amp;gt;unescaped text&amp;lt;/b&amp;gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;normal text&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="690">
<tbody>
<tr>
<td width="690">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>['&lt;div style=\"color: red;\"&gt;Hello, Red!&lt;/div&gt;', '&lt;table&gt;&lt;tr&gt;&lt;td&gt;Cell 1&lt;/td&gt;&lt;td&gt;Cell 2&lt;/td&gt;&lt;tr&gt;']</p>
</td>
</tr>
<tr>
<td width="690">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>&lt;ul&gt;</p>
<p>&nbsp; &lt;li&gt;&amp;lt;div style=\&amp;quot;color: red;\&amp;quot;&amp;gt;Hello, Red!&amp;lt;/div&amp;gt;&lt;/li&gt;</p>
<p>&nbsp; &lt;li&gt;&amp;lt;table&amp;gt;&amp;lt;tr&amp;gt;&amp;lt;td&amp;gt;Cell 1&amp;lt;/td&amp;gt;&amp;lt;td&amp;gt;Cell 2&amp;lt;/td&amp;gt;&amp;lt;tr&amp;gt;&lt;/li&gt;</p>
<p>&lt;/ul&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Match All Words</h2>
<p>Write a JS function that matches all words in a text, a word is anything that consists of letters, numbers or underscores (_).</p>
<p>The <strong>input</strong> comes as single string argument &ndash; the text from which to extract the words.</p>
<p>The <strong>output</strong> should be printed on the console and should consist of all words concatenated with a <strong>&ldquo;|&ldquo;</strong>(pipe), check the examples bellow to better understand the format.</p>
<h3>Examples</h3>
<table width="676">
<tbody>
<tr>
<td width="676">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>'A Regular Expression needs to have the global flag in order to match all occurrences in the text'</p>
</td>
</tr>
<tr>
<td width="676">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>A|Regular|Expression|needs|to|have|the|global|flag|in|order|to|match|all|occurrences|in|the|text</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="676">
<tbody>
<tr>
<td width="676">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>'_(Underscores) are also word characters'</p>
</td>
</tr>
<tr>
<td width="676">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>_|Underscores|are|also|word|characters</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Read about the special characters in Regular Expressions at MDN to find some that can ease your task <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions">https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions</a></li>
</ul>
<h2>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Simple Email Validation</h2>
<p>Write a JS function that validates simple emails. The emails should have a <strong>username</strong>, which consists only of <strong>English alphabet letters</strong> and <strong>digits</strong>, <strong>a &ldquo;@&rdquo; sign</strong>, and a domain name after it. The domain should consist <strong>only of</strong> <strong>2 strings</strong> <strong>separated</strong> by a <strong>single dot</strong>. The 2 strings should contain <strong>NOTHING</strong> but <strong>lowercase English alphabet letters</strong>.</p>
<p>The <strong>input</strong> comes as single string argument which is an email.</p>
<p>The <strong>output</strong> should be printed on the console. If the given email is valid, print &ldquo;Valid&rdquo;, if it is not, print &ldquo;Invalid&rdquo;.</p>
<h3>Examples</h3>
<table width="638">
<tbody>
<tr>
<td width="298">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="298">
<p>valid@email.bg</p>
</td>
<td width="340">
<p>Valid</p>
</td>
</tr>
<tr>
<td width="298">
<p>invalid@emai1.bg</p>
</td>
<td width="340">
<p>Invalid</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Expression Split</h2>
<p>Write a JS function that splits a passed in JS code into separate parts. The passed in code will always have one or more spaces between operators and operands. Normal brackets (<strong>&lsquo;(&lsquo;</strong>,<strong>&rsquo;)&rsquo;</strong>), commas (<strong>,</strong>), semicolons (<strong>;</strong>) and the member access operator (<strong>&lsquo;.&rsquo;(dot)</strong>, as in &ldquo;console<strong>.</strong>log&rdquo;) should also be used for splitting. String literals will always be initialized with double quotes (") and will <strong>contain only letters</strong>. Make sure there are no empty entries in the output.</p>
<p>The <strong>input</strong> comes as a single string argument - the JS code that has to be split.</p>
<p>The <strong>output</strong> should be printed on the console, with each elements obtained from the split is printed on a new line.</p>
<h3>Examples</h3>
<table width="676">
<tbody>
<tr>
<td width="514">
<p><strong>Input</strong></p>
</td>
<td width="162">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="514">
<p>'let sum = 4 * 4,b = "wow";'</p>
</td>
<td width="162">
<p>let</p>
<p>sum</p>
<p>=</p>
<p>4</p>
<p>*</p>
<p>4</p>
<p>let</p>
<p>b</p>
<p>=</p>
<p>"wow"</p>
</td>
</tr>
<tr>
<td width="514">
<p>'let sum = 1 + 2;if(sum &gt; 2){\tconsole.log(sum);}'</p>
</td>
<td width="162">
<p>let</p>
<p>sum</p>
<p>=</p>
<p>1</p>
<p>+</p>
<p>2</p>
<p>if</p>
<p>sum</p>
<p>&gt;&nbsp;</p>
<p>2</p>
<p>{</p>
<p>console</p>
<p>log</p>
<p>sum</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Match the Dates</h2>
<p>Write a JS function that finds and extracts all the dates in the given sentences. The dates should be in format <br /> <strong>d-MMM-yyyy</strong>. <strong>Example: 12-Jun-1999</strong>, <strong>3-Dec-2017</strong>.</p>
<p>The <strong>input</strong> comes as an array of strings. Each string represents a sentence.</p>
<p>The <strong>output</strong> should be printed on the console. The output should consist of all extracted <strong>VALID</strong> dates. Each element should be printed on a new line.</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>I am born on 30-Dec-1994.</p>
<p>This is not date: 512-Jan-1996.<br /> My father is born on the 29-Jul-1955.</p>
</td>
</tr>
<tr>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>30-Dec-1994 (Day: 30, Month: Dec, Year: 1994)</p>
<p>29-Jul-1955 (Day: 29, Month: Jul, Year: 1955)</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>1-Jan-1999 is a valid date.<br /> So is 01-July-2000.<br /> I am an awful liar, by the way &ndash; Ivo, 28-Sep-2016.</p>
</td>
</tr>
<tr>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>1-Jan-1999 (Day: 1, Month: Jan, Year: 1999)</p>
<p>28-Sep-2016 (Day: 28, Month: Sep, Year: 2016)</p>
</td>
</tr>
</tbody>
</table>
<h2>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parse the Employee Data</h2>
<p>Write a JS function that <strong>validates employee data</strong>, and stores it <strong>if it is</strong> <strong>valid</strong>. The employee data consists of 3 elements &ndash; <strong>employee name</strong>, <strong>employee salary</strong> and <strong>employee position</strong>.</p>
<p>The <strong>input</strong> comes as an array of strings. Each element represents input employee data. You should capture only the valid from them. The input will have the following format:</p>
<p>{employeeName} - {employeeSalary} - {employeePosition}</p>
<p>The <strong>Employee name</strong> will be a <strong>string</strong>, which can contain only <strong>English alphabet letters</strong> and must <strong>start with a capital</strong>. The <strong>Employee salary</strong> should be a <strong>VALID</strong> <strong>number</strong>. The <strong>employee position</strong> can contain <strong>English alphabet letters</strong>, <strong>digits, dashes</strong>, <strong>and can consist of several words</strong>. Any input that <strong>does NOT follow</strong> the specified above rules, is to be treated as <strong>invalid, </strong>and is to<strong> be ignored</strong>.</p>
<p>The <strong>output</strong> should be printed on the console. For every <strong>valid employee data</strong> found, you should print each of its elements. Check the examples.</p>
<h3>Examples</h3>
<table width="676">
<tbody>
<tr>
<td width="676">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>Isacc - 1000 - CEO</p>
<p>Ivan - 500 - Employee</p>
<p>Peter - 500 - Employee</p>
</td>
</tr>
<tr>
<td width="676">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>Name: Isacc</p>
<p>Position: CEO</p>
<p>Salary: 1000</p>
<p>Name: Ivan</p>
<p>Position: Employee</p>
<p>Salary: 500</p>
<p>Name: Peter</p>
<p>Position: Employee</p>
<p>Salary: 500&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="676">
<tbody>
<tr>
<td width="676">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>Jonathan - 2000 - Manager</p>
<p>Peter- 1000- Chuck</p>
<p>George - 1000 - Team Leader</p>
</td>
</tr>
<tr>
<td width="676">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="676">
<p>Name: Jonathan</p>
<p>Position: Manager</p>
<p>Salary: 2000</p>
<p>Name: George</p>
<p>Position: Team Leader</p>
<p>Salary: 1000</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Use <strong>Groups</strong> for this problem, it would be a lot easier.</li>
</ul>
<h2>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Form Filler</h2>
<p>Write a JS function that automatically fills a form for a lazy client. The client will give you <strong>3 elements</strong> of <strong>data</strong> about himself &ndash; his <strong>username</strong>, his <strong>email</strong>, and his <strong>phone number</strong>. After those 3 elements you will be given the form, as text, with several placeholders in it. You must replace each <strong>valid placeholder</strong> with its corresponding value. The placeholders have special symbols and can <strong>contain only English alphabet letters</strong>. There are <strong>3 types</strong> of valid placeholders:</p>
<ul>
<li><strong>&lt;!{letters}!&gt;</strong> - put the given username in place of this</li>
<li><strong>&lt;@{letters}@&gt;</strong> - put the given email in place of this</li>
<li><strong>&lt;+{letters}+&gt;</strong> - put the given email in place of this</li>
</ul>
<p>The <strong>input</strong> comes as four string arguments and an array of strings. The <strong>first 3 arguments</strong> will represent the <strong>username</strong>, the <strong>email</strong> and the <strong>phone number</strong>. Each element of the array will represent a sentence, if you find a placeholder somewhere in those sentences you should replace it.</p>
<p>The <strong>output</strong> should be printed on the console. The output should consist of all sentences, printed again, this time with their placeholders replaced with the actual data.</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>'Pesho',<br /> 'pesho@softuni.bg',<br /> '90-60-90',<br /> ['Hello, &lt;!username!&gt;!',<br /> &nbsp;'Welcome to your Personal profile.',<br /> &nbsp;'Here you can modify your profile freely.',<br /> &nbsp;'Your current username is: &lt;!fdsfs!&gt;. Would you like to change that? (Y/N)',<br /> &nbsp;'Your current email is: &lt;@DasEmail@&gt;. Would you like to change that? (Y/N)',<br /> &nbsp;'Your current phone number is: &lt;+number+&gt;. Would you like to change that? (Y/N)']</p>
</td>
</tr>
<tr>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>Hello, Pesho! <br /> Welcome to your Personal profile. <br /> Here you can modify your profile freely. <br /> Your current username is: Pesho. Would you like to change that? (Y/N)<br /> Your current email is: pesho@softuni.bg. Would you like to change that? (Y/N)<br /> Your current phone number is: 90-60-90. Would you like to change that? (Y/N)</p>
</td>
</tr>
</tbody>
</table>
<h2>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Match Multiplication</h2>
<p>You are given a text with <strong>numbers</strong> multiplied by <strong>*</strong> in format <strong>{num1} * {num2}</strong>. Your job is to extract each two numbers in the above format, multiply them and replace them with their product. The <strong>first number</strong> is integer, can be negative. The <strong>second number</strong> is integer or floating-point and can be negative. There could be whitespace around the &ldquo;<strong>*</strong>&rdquo; symbol.</p>
<p>The <strong>input</strong> comes as a single string argument &ndash; the text holding the numbers.</p>
<p>The <strong>output</strong> should be printed on the console &ndash; it consists of the same text with the multiplied numbers replaced by their product.</p>
<h3>Examples</h3>
<table width="702">
<tbody>
<tr>
<td width="702">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p>My bill: <strong>2*2.50</strong> (beer); <strong>2* 1.20</strong> (kepab); <strong>-2&nbsp; * 0.5</strong> (deposit).</p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p>My bill: <strong>5</strong> (beer); <strong>2.4</strong> (kepab); <strong>-1</strong> (deposit).</p>
</td>
</tr>
<tr>
<td width="702">
<p>Input</p>
</td>
</tr>
</tbody>
</table>
<h3>Hint</h3>
<ul>
<li>Match the numbers to be multiplied by regex with groups. Check the overloads for the <strong>replace</strong> function, there may be an overload with a <strong>callback</strong> that can help you.</li>
</ul>
<p>&nbsp;</p>