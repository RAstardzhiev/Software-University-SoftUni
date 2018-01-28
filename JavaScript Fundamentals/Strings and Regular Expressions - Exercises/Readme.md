<h1>Exercises: Strings and Regular Expressions</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/314/">https://judge.softuni.bg/Contests/314/</a>.</p>
<p>In this exercise you are supposed to <strong>write program logic</strong> using the basic operations between Strings and the built-in String functions, as well as regular expressions, in JavaScript. You will practice working with <strong>strings</strong>, <strong>regular expressions</strong> and using <strong>built-in</strong> <strong>functions</strong> (concat(), trim(), split()&hellip;). In some of the exercises you might need to combine both in order to find the best solution.</p>
<h1>Text Processing and String Manipulation</h1>
<h2>1.&nbsp;&nbsp; Split a String with a Delimiter</h2>
<p>Write a JS function that <strong>splits</strong> a <strong>string</strong> with a given <strong>delimiter</strong>.</p>
<p>The <strong>input</strong> comes as 2 string arguments. The<strong> first one is the string</strong> you need to split and the <strong>second</strong> <strong>one is the delimiter</strong>.</p>
<p>The <strong>output</strong> should consist of all elements you&rsquo;ve received, after you&rsquo;ve <strong>split</strong> <strong>the given string</strong> by <strong>the given delimiter</strong>. Each element should be printed on a new line.</p>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="208">
<p><strong>Input</strong></p>
</td>
<td width="61">
<p><strong>Output</strong></p>
</td>
<td width="17">
<p><strong>&nbsp;</strong></p>
</td>
<td width="222">
<p><strong>Input</strong></p>
</td>
<td width="180">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="208">
<p>One-Two-Three-Four-Five</p>
<p>-</p>
</td>
<td width="61">
<p>One</p>
<p>Two</p>
<p>Three</p>
<p>Four</p>
<p>Five</p>
<p>&nbsp;</p>
</td>
<td width="17">
<p>&nbsp;</p>
</td>
<td width="222">
<p>http://platform.softuni.bg</p>
<p>.</p>
<p>&nbsp;</p>
</td>
<td width="180">
<p>http://platform</p>
<p>softuni</p>
<p>bg</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>This &ldquo;main&rdquo; function will hold all of the code of our solution.<br /> </li>
<li>Now that we have the string and the delimiter, we can split the string and save the split elements we received as result to the action we did.</li>
<li>The split() function returns an array of elements, which we can iterate over. The last thing we need to do is print each of the elements on a new line.<br /> </li>
</ul>
<h2>2.&nbsp;&nbsp; &nbsp;Repeat a String N Times</h2>
<p>Write a JS function that repeats a given string, N times.</p>
<p>The <strong>input</strong> comes as 2 arguments. The <strong>first argument is a string that</strong> will represent <strong>the one you need to repeat</strong>. The second one is a number will represent <strong>the times you need to repeat it</strong>.</p>
<p>The <strong>output</strong> is a big string, containing the <strong>given one</strong>, <strong>repeated N times</strong>.</p>
<h3>Examples</h3>
<table width="448">
<tbody>
<tr>
<td width="118">
<p><strong>Input</strong></p>
</td>
<td width="330">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="118">
<p>repeat</p>
<p>5</p>
</td>
<td width="330">
<p>repeatrepeatrepeatrepeatrepeat</p>
</td>
</tr>
<tr>
<td colspan="2" width="448">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="118">
<p><strong>Input</strong></p>
</td>
<td width="330">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="118">
<p>magic is real</p>
<p>3</p>
</td>
<td width="330">
<p>magic is realmagic is realmagic is real</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>You can easily use <strong>string concatenation</strong> to solve this problem.</li>
<li>You could, however, see if there is a <strong>built-in function</strong> that does the same thing.</li>
</ul>
<h2>3.&nbsp;&nbsp; Check if String starts with a given Substring.</h2>
<p>Write a JS function that checks if a <strong>given string</strong>, <strong>starts with a given substring</strong>.</p>
<p>The <strong>input</strong> comes as 2 string arguments. The <strong>first string</strong> will represent <strong>the main one</strong>. The second one will represent <strong>the substring</strong>.</p>
<p>The <strong>output</strong> is either &ldquo;true&rdquo; or &ldquo;false&rdquo; based on the result of the check.<br /> The comparison is <strong>case-sensitive</strong>!</p>
<h3>Examples</h3>
<table width="678">
<tbody>
<tr>
<td colspan="2" width="264">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td colspan="2" width="270">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="264">
<p>How have you been?</p>
<p>how</p>
</td>
<td width="60">
<p>false</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td colspan="2" width="270">
<p>The quick brown fox&hellip;</p>
<p>The quick brown fox&hellip;</p>
</td>
<td width="60">
<p>true</p>
</td>
</tr>
<tr>
<td colspan="2" width="264">
<p>&nbsp;</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td colspan="2" width="270">
<p>&nbsp;</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="108">
<p>&nbsp;</p>
</td>
<td colspan="4" width="432">
<p><strong>Input</strong></p>
</td>
<td width="78">
<p><strong>Output</strong></p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="108">
<p>&nbsp;</p>
</td>
<td colspan="4" width="432">
<p>Marketing Fundamentals, starting 19/10/2016</p>
<p>Marketing Fundamentals, sta</p>
</td>
<td width="78">
<p>true</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="108">&nbsp;</td>
<td width="156">&nbsp;</td>
<td width="60">&nbsp;</td>
<td width="24">&nbsp;</td>
<td width="192">&nbsp;</td>
<td width="78">&nbsp;</td>
<td width="60">&nbsp;</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Check if String ends with given Substring.</h2>
<p>Write a JS function that checks if a <strong>given string</strong>, <strong>ends with a given substring</strong>.</p>
<p>The <strong>input</strong> comes as 2 string arguments. The <strong>first string</strong> will represent <strong>the main one</strong>. The second one will represent <strong>the substring</strong>.</p>
<p>The <strong>output</strong> is either &ldquo;true&rdquo; or &ldquo;false&rdquo; based on the result of the check.<br /> The comparison is <strong>case-sensitive</strong>!</p>
<h3>Examples</h3>
<table width="678">
<tbody>
<tr>
<td colspan="2" width="264">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td colspan="2" width="270">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td colspan="2" width="264">
<p>This sentence ends with fun?</p>
<p>fun?</p>
</td>
<td width="60">
<p>true</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td colspan="2" width="270">
<p>This is Houston, we have&hellip;</p>
<p>We have&hellip;</p>
</td>
<td width="60">
<p>false</p>
</td>
</tr>
<tr>
<td colspan="2" width="264">
<p>&nbsp;</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td colspan="2" width="270">
<p>&nbsp;</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="108">
<p>&nbsp;</p>
</td>
<td colspan="4" width="432">
<p><strong>Input</strong></p>
</td>
<td width="78">
<p><strong>Output</strong></p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="108">
<p>&nbsp;</p>
</td>
<td colspan="4" width="432">
<p>The new iPhone has no headphones jack.</p>
<p>o headphones jack.</p>
</td>
<td width="78">
<p>true</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="108">&nbsp;</td>
<td width="156">&nbsp;</td>
<td width="60">&nbsp;</td>
<td width="24">&nbsp;</td>
<td width="192">&nbsp;</td>
<td width="78">&nbsp;</td>
<td width="60">&nbsp;</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; *Capitalize the Words</h2>
<p>Write a JS function that capitalizes the given words. You need to make <strong>every word</strong>&rsquo;s <strong>first letter</strong> &ndash; <strong>uppercase</strong> and <strong>all</strong> <strong>other letters</strong> &ndash; <strong>lowercase</strong>.</p>
<p>The <strong>input</strong> comes as a <strong>single string</strong>, containing words, separated by a space.</p>
<p>The <strong>output</strong> is the same string, however with all of its words capitalized.</p>
<p>Note: The words can contain <strong>any ASCII character</strong>. You need to <strong>affect only the letters</strong>.</p>
<h3>Examples</h3>
<table width="624">
<tbody>
<tr>
<td width="312">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="312">
<p>Capitalize these words</p>
</td>
<td width="312">
<p>Capitalize These Words</p>
</td>
</tr>
<tr>
<td width="312">
<p>&nbsp;</p>
</td>
<td width="312">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="312">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="312">
<p>Was that Easy? tRY thIs onE for SiZe!</p>
</td>
<td width="312">
<p>Was That Easy? Try This One For Size!</p>
</td>
</tr>
</tbody>
</table>
<h1>&nbsp;</h1>
<h1>Working with Regular Expressions</h1>
<p>For the following tasks, it will be most appropriate, if you use regular expressions in your solutions.</p>
<h2>6.&nbsp;&nbsp; Capture the Numbers</h2>
<p>Write a JS function that <strong>finds all numbers</strong> in a sequence of strings.</p>
<p>The <strong>input</strong> comes as array of strings. Each element represents one of the strings.</p>
<p>The <strong>output</strong> is all the numbers, <strong>extracted</strong> and <strong>printed on a single line</strong> &ndash; each separated by a <strong>single space</strong>.</p>
<h3>Examples</h3>
<table width="624">
<tbody>
<tr>
<td width="234">
<p><strong>Input</strong></p>
</td>
<td width="390">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="234">
<p>The300</p>
<p>What is that?</p>
<p>I think it&rsquo;s the 3rd movie.</p>
<p>Lets watch it at 22:45</p>
</td>
<td width="390">
<p>300 3 22 45</p>
</td>
</tr>
<tr>
<td width="234">
<p>&nbsp;</p>
</td>
<td width="390">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="234">
<p><strong>Input</strong></p>
</td>
<td width="390">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="234">
<p>123a456</p>
<p>789b987</p>
<p>654c321</p>
<p>0</p>
</td>
<td width="390">
<p>123 456 789 987 654 321 0</p>
</td>
</tr>
<tr>
<td width="234">
<p><strong>Input</strong></p>
</td>
<td width="390">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="234">
<p>Let&rsquo;s go11!!!11!</p>
<p>Okey!1!</p>
</td>
<td width="390">
<p>11 11 1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>We can solve this problem in multiple ways; first let&rsquo;s see the more complex way in order to understand how the regex actually works:</p>
<ul>
<li>We receive several sentences in the form of an array of strings. Let&rsquo;s create a variable named text, and gather all the sentences into one big string. Also, we need to initialize our regex pattern, and an array that will hold the numbers we found.</li>
<li>We create the needed things. The regex is &ldquo;\d+&rdquo; which will catch <strong>one or more consecutive digits</strong>. We also give it a global modifier, &ldquo;g&rdquo;, which will prevent the regex from returning on the first match.</li>
<li>We can now proceed with combining all the strings into one big string.</li>
<li>Now that we have that, we can proceed to the main thing. The matching.</li>
<li>First we create a match variable which will hold our matches. The regex <strong>anchors itself</strong> every time, to the index of the match it has found, thus to iterate all matches we need a while Every time we <strong>match something</strong>, we <strong>push it</strong> to the array of numbers&hellip; The match variable represents an <strong>array of all groups it has found</strong>, so we just take the first element, which represents the <strong>whole match</strong>. Then we match again, to <strong>move the anchor</strong>.</li>
<li>Last but not least, we print the result:</li>
</ul>
<p>Now that we understand how the matching works underneath, we can actually write a simpler solution. Having learned the Array built-in functions we know we can group the input into one string using the <strong>Array.join()</strong> function:</p>
<p>The regex we&rsquo;ll use will be the same:</p>
<p>&nbsp;In case we don&rsquo;t need capturing subgroups, as it is in this problem, we can just use the <strong>String.match()</strong> function to get all matches from our string (the regex still has to have the global flag <strong>&ldquo;g&rdquo;</strong>).</p>
<p>Thus we managed to write the program in just a few lines:</p>
<h2>7.&nbsp;&nbsp; Find Variable Names in Sentences</h2>
<p>Write a JS function that finds all <strong>variable names</strong> in a given string. A variable name starts with an <strong>underscore</strong> (&ldquo;_&rdquo;) and contains<strong> only Capital and Non-Capital English Alphabet letters and digits</strong>. Extract only their names, <strong>without the underscore. </strong>Try to do this <strong>only with regular expressions</strong>.</p>
<p>The <strong>input</strong> comes as single string, on which you have to perform the matching.</p>
<p>The <strong>output</strong> consists of all variable names, <strong>extracted</strong> and <strong>printed on a single line</strong>, each <strong>separated </strong>by a <strong>comma</strong>.</p>
<table width="678">
<tbody>
<tr>
<td width="480">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p>The _id and _age variables are both integers.</p>
</td>
<td width="198">
<p>id,age</p>
</td>
</tr>
<tr>
<td width="480">
<p>&nbsp;</p>
</td>
<td width="198">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="480">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p>Calculate the _area of the _perfectRectangle object.</p>
</td>
<td width="198">
<p>area,perfectRectangle</p>
</td>
</tr>
<tr>
<td width="480">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p>__invalidVariable _evenMoreInvalidVariable_ _validVariable</p>
</td>
<td width="198">
<p>validVariable</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Think how to ensure that your match is a separate word (not part of a bigger word that may be invalid).</li>
<li>Think of a way to ensure your regex matches only the variable and not parts before/after it. Check the <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions">special characters</a> online to see if one of them fits your needs.</li>
</ul>
<h2>8.&nbsp;&nbsp; Find Occurrences of Word in Sentence</h2>
<p>Write a JS function that finds, <strong>how many times</strong> a <strong>given word</strong>, is <strong>used</strong> in a <strong>given sentence. </strong>Note that letter case does not matter &ndash; it is <strong>case-insensitive</strong>.</p>
<p>The <strong>input</strong> comes as 2 string arguments. The <strong>first one</strong> will be the <strong>sentence</strong>, and the <strong>second one</strong> &ndash; the <strong>word</strong>.</p>
<p>The <strong>output</strong> is a single number indicating the <strong>amount of times</strong> the sentence contains the word.</p>
<h3>Examples</h3>
<table width="672">
<tbody>
<tr>
<td width="612">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="612">
<p>The waterfall was so high, that the child couldn&rsquo;t see its peak.</p>
<p>the</p>
</td>
<td width="60">
<p>2</p>
</td>
</tr>
<tr>
<td width="612">
<p>&nbsp;</p>
</td>
<td width="60">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="612">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="612">
<p>How do you plan on achieving that? How? How can you even think of that?</p>
<p>how</p>
</td>
<td width="60">
<p>3</p>
</td>
</tr>
<tr>
<td width="612">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="612">
<p>There was one. Therefore I bought it. I wouldn&rsquo;t buy it otherwise.</p>
<p>there</p>
</td>
<td width="60">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Remember how we always used the global modifier <strong>&ldquo;g&rdquo;</strong>. There is also a modifier for case-insensitive matching. It might help you since the case does <strong>NOT</strong> matter in this problem.</li>
<li>Think how to create a regex that includes a string that will be known only at runtime. It is important to note that there is a Regex constructor that accepts a string representing the regex pattern.</li>
</ul>
<h2>9.&nbsp;&nbsp; *Extract the Links</h2>
<p>Write a JS function that <strong>extracts links</strong> from a <strong>given text</strong>. The text will come in the form of strings, each representing a sentence. You need to extract <strong>only the valid links</strong> from it. Example:</p>
<p><br /> &ldquo;www.internet.com&rdquo;</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Sub-Domain&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Domain</strong> <strong>name</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Domain extension</strong></p>
<p>&nbsp;</p>
<p>The <strong>Sub-Domain</strong> must always be &ldquo;www&rdquo;. The <strong>Domain name </strong>can consist of English alphabet letters (<strong>uppercase</strong> and <strong>lowercase</strong>), digits and dashes (&ldquo;&ndash;&ldquo;). The <strong>Domain extension </strong>consists of one or more <strong>domain blocks</strong>, a <strong>domain block</strong> consists of a <strong>dot</strong> followed by <strong>one or more lowercase </strong>English alphabet <strong>letters</strong>, a <strong>Domain extension</strong> must have at least <strong>one</strong> <strong>domain block</strong> in order to be <strong>valid</strong>. The Sub-Domain and Domain name must be separated by a single <strong>dot</strong>. Any link that <strong>does NOT follow</strong> the specified above rules should be treated as <strong>invalid</strong>.</p>
<p><strong>Example incorrect links:</strong> &nbsp;</p>
<ul>
<li>"<strong>ww</strong>.justASite.bg"</li>
<li>"<strong>lel</strong>.awesome.com"</li>
<li>"www.stamat<strong>_</strong>hit.bg"</li>
<li>"www.no-symb<strong>#^</strong>ols-allow<strong>%</strong>com"</li>
<li>"www.pesho<strong>.12</strong>"</li>
<li>"www.gosho-site<strong>.</strong>"</li>
<li>"www.example-site<strong>._*^#</strong>"</li>
</ul>
<p><strong>Example correct links:&nbsp; </strong></p>
<ul>
<li>"Some textsoftuni.bg"</li>
<li>"Just a link in a sea-of-text.bg-swimming around"</li>
<li>"Instruments Instruments.rom.com.trombone2000 Instrument here"</li>
<li>"All your ice cream flavors-scream.for.ice.cream(We also have squirrels)"</li>
</ul>
<p>The <strong>input</strong> comes as array of strings. Each element represents a sentence.</p>
<p>The <strong>output</strong> is all valid links you&rsquo;ve found, printed &ndash; each on a new line.</p>
<h3>Examples</h3>
<table width="672">
<tbody>
<tr>
<td width="462">
<p><strong>Input</strong></p>
</td>
<td width="210">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="462">
<p>Join WebStars now for free, at www.web-stars.com</p>
<p>You can also support our partners:</p>
<p>Internet - www.internet.com</p>
<p>WebSpiders - www.webspiders101.com</p>
<p>Sentinel - www.sentinel.-ko</p>
</td>
<td width="210">
<p>www.web-stars.com</p>
<p>www.internet.com</p>
<p>www.webspiders101.com</p>
</td>
</tr>
<tr>
<td width="462">
<p>&nbsp;</p>
</td>
<td width="210">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="462">
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
<td width="210">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="462">
<p><strong>Input</strong></p>
</td>
<td width="210">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="462">
<p>Need information about cheap hotels in London?</p>
<p>You can check us at www.london-hotels.co.uk!</p>
<p>We provide the best services in London.</p>
<p>Here are some reviews in some blogs:</p>
<p>"London Hotels are awesome!" - www.indigo.bloggers.com</p>
<p>"I am very satisfied with their services" - ww.ivan.bg</p>
<p>"Best Hotel Services!" - www.rebel21.sedecrem.moc</p>
</td>
<td width="210">
<p>www.london-hotels.co.uk</p>
<p>www.indigo.bloggers.com</p>
<p>www.rebel21.sedecrem.moc</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Sites such as <a href="https://regex101.com/">https://regex101.com/</a> can be very helpful, when designing regular expressions.</li>
</ul>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; **Secret Data</h2>
<p>Write a JS function that hides essential client data from secret documents that went public. You have to hide people&rsquo;s names, phone numbers, ids and secret base names.</p>
<ul>
<li>The <strong>names of the clients</strong> will be preceded by a single <strong>asterisk</strong> (&ldquo;*&rdquo;), they will always be <strong>exactly one word</strong>, they will contain <strong>only English alphabet letters</strong>, they will <strong>start with a capital letter </strong>and they will always be followed by either a <strong>space, </strong>a<strong> tabulation </strong>or the <strong>end of the string</strong>. Anything else is <strong>NOT</strong> <strong>to be considered</strong> as a name.</li>
</ul>
<p>&nbsp;</p>
<ul>
<li>The <strong>phone numbers</strong> of the clients will be preceded by a single <strong>plus sign</strong> (&ldquo;+&rdquo;) and will consist of exactly 10 symbols. The phone numbers can consist only of <strong>digits</strong> and <strong>dashes </strong>and they will always be followed by a <strong>space, tabulation </strong>or the <strong>end of the string</strong>. Anything else is <strong>NOT to be considered</strong> as a phone number.</li>
</ul>
<p>&nbsp;</p>
<ul>
<li>The <strong>ID</strong>s of the clients will be preceded by a single <strong>exclamation mark</strong> (&ldquo;!&rdquo;). The IDs of the clients will consist only of <strong>Lowercase</strong> and <strong>Uppercase English alphabet letters</strong> and <strong>digits </strong>and they will always be followed by a <strong>space, tabulation </strong>or the <strong>end of the string</strong>. Anything else is <strong>NOT to be considered</strong> as an ID.</li>
</ul>
<p>&nbsp;</p>
<ul>
<li>The <strong>names of the secret bases</strong> will be preceded by a single <strong>underscore </strong>(&ldquo;_&rdquo;) and will consist only of <strong>Uppercase</strong> and <strong>Lowercase English alphabet letters</strong> and <strong>digits </strong>and they will always be followed by a <strong>space, tabulation </strong>or the <strong>end of the string</strong>. Anything else is <strong>NOT to be considered</strong> as a secret base name.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>Usernames, phone numbers, IDs and names of secret bases</strong> can start glued to other text.</li>
<li><strong>Usernames, phone numbers, IDs and names of secret bases</strong> will never be split given across 2 lines.</li>
<li><strong>Usernames, phone numbers, IDs and names of secret bases</strong> will always have a <strong>space, tabulation </strong>or the<strong> end of the string </strong>after them.</li>
</ul>
<p>The <strong>input</strong> comes as an array of strings. Each string represents a sentence of the secret document. You need to find every <strong>client data element</strong> that is supposed to be secret, and <strong>hide it</strong>, by <strong>replacing it</strong> with a <strong>string of</strong> <strong>vertical bars</strong> (&ldquo;|&rdquo;) with the <strong>same length</strong>, as the <strong>discovered element</strong>.</p>
<p><strong>NOTE: The preceding symbol counts towards the discovered element&rsquo;s length when deciding how many pipes to use to cover it.</strong></p>
<p>The <strong>output</strong> should be the same document, with the sensitive <strong>client</strong> <strong>data replaced by pipes</strong>. &nbsp;See the example for more info.</p>
<h3>Example</h3>
<table width="712">
<tbody>
<tr>
<td width="352">
<p><strong>Input</strong></p>
</td>
<td width="360">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="352">
<p>Agent *Ivankov was in the room when it all happened.</p>
<p>The person in the room was heavily armed.</p>
<p>Agent *Ivankov had to act quick in order.</p>
<p>He picked up his phone and called some unknown number.</p>
<p>I think it was +555-49-796</p>
<p>I can't really remember...</p>
<p>He said something about "finishing work" with subject !2491a23BVB34Q and returning to Base _Aurora21</p>
<p>Then after that he disappeared from my sight.</p>
<p>As if he vanished in the shadows.</p>
<p>A moment, shorter than a second, later, I saw the person flying off the top floor.</p>
<p>I really don't know what happened there.</p>
<p>This is all I saw, that night.</p>
<p>I cannot explain it myself...</p>
</td>
<td width="360">
<p>Agent |||||||| was in the room when it all happened.</p>
<p>The person in the room was heavily armed.</p>
<p>Agent |||||||| had to act quick in order.</p>
<p>He picked up his phone and called some unknown number.</p>
<p>I think it was |||||||||||</p>
<p>I can't really remember...</p>
<p>He said something about "finishing work" with subject |||||||||||||| and returning to Base |||||||||</p>
<p>Then after that he disappeared from my sight.</p>
<p>As if he vanished in the shadows.</p>
<p>A moment, shorter than a second, later, I saw the person flying off the top floor.</p>
<p>I really don't know what happened there.</p>
<p>This is all I saw, that night.</p>
<p>I cannot explain it myself...</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>