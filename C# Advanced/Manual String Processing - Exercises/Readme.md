<h1>Exercises: Manual String Processing</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016">"CSharp Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reverse String</h2>
<p>Write a program that reads a string from the console, reverses it and prints the result back at the console.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>Input</strong></p>
</td>
<td width="89">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>sample</p>
</td>
<td width="89">
<p>elpmas</p>
</td>
</tr>
<tr>
<td width="84">
<p>24tvcoi92</p>
</td>
<td width="89">
<p>29iocvt42</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; String Length</h2>
<p>Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *. Print the resulting string on the console.</p>
<h3>Examples</h3>
<table width="688">
<tbody>
<tr>
<td width="514">
<p><strong>Input</strong></p>
</td>
<td width="174">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="514">
<p>Welcome to SoftUni!</p>
</td>
<td width="174">
<p>Welcome to SoftUni!*</p>
</td>
</tr>
<tr>
<td width="514">
<p>a regular expression (abbreviated regex or regexp and sometimes called a rational expression) is a sequence of characters that forms a search pattern</p>
</td>
<td width="174">
<p>a regular expression</p>
</td>
</tr>
<tr>
<td width="514">
<p>C#</p>
</td>
<td width="174">
<p>C#******************</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Formatting Numbers</h2>
<p>Write a program that reads 3 numbers (separated by whitespace): an integer a (0 &le; a &le; 2222), a floating-point b and a floating-point c and <strong>prints them in 4 virtual columns</strong>&nbsp;on the console. Each column should have a width of 10 characters. The number a should be printed in&nbsp;<strong>hexadecimal, left aligned</strong>; then the number a should be printed in binary form, padded with zeroes (if it is bigger than 10 bits remove the least significant ones), then the number b should be&nbsp;<strong>printed with 2 digits after the decimal point, right aligned</strong>; the number c should be <strong>printed with 3 digits after the decimal point, left aligned</strong>.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="74">
<p><strong>a</strong></p>
</td>
<td width="76">
<p><strong>b</strong></p>
</td>
<td width="75">
<p><strong>c</strong></p>
</td>
<td width="382">
<p><strong>result</strong></p>
</td>
</tr>
<tr>
<td width="74">
<p>254</p>
</td>
<td width="76">
<p>11.6</p>
</td>
<td width="75">
<p>0.5</p>
</td>
<td width="382">
<p>|FE&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |0011111110|&nbsp;&nbsp;&nbsp;&nbsp; 11.60|0.500&nbsp;&nbsp;&nbsp;&nbsp; |</p>
</td>
</tr>
<tr>
<td width="74">
<p>499</p>
</td>
<td width="76">
<p>-0.5559</p>
</td>
<td width="75">
<p>10000</p>
</td>
<td width="382">
<p>|1F3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |0111110011|&nbsp;&nbsp;&nbsp;&nbsp; -0.56|10000.000 |</p>
</td>
</tr>
<tr>
<td width="74">
<p>0</p>
</td>
<td width="76">
<p>3</p>
</td>
<td width="75">
<p>-0.1234</p>
</td>
<td width="382">
<p>|0&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |0000000000|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3.00|-0.123&nbsp;&nbsp;&nbsp; |</p>
</td>
</tr>
<tr>
<td width="74">
<p>444</p>
</td>
<td width="76">
<p>-7.5</p>
</td>
<td width="75">
<p>7.5</p>
</td>
<td width="382">
<p>|1BC&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |0110111100|&nbsp;&nbsp;&nbsp;&nbsp; -7.50|7.500&nbsp;&nbsp;&nbsp;&nbsp; |</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Convert from base-10 to base-N</h2>
<p>Write a program that takes a base-10 number (0 to 10<sup>50</sup>) and converts it to a base-N number, where 2 &lt;= N &lt;= 10.<br /> The input consists of 1 line containing two numbers separated by a single space. The first number is the base N to which you have to convert. The second one is the base 10 number to be converted. <strong>Do not use any built in converting functionality, try to write your own algorithm.</strong></p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="74">
<p><strong>Base-10</strong></p>
</td>
<td width="76">
<p><strong>Base-N</strong></p>
</td>
</tr>
<tr>
<td width="74">
<p>7 10</p>
</td>
<td width="76">
<p>13</p>
</td>
</tr>
<tr>
<td width="74">
<p>3 154</p>
</td>
<td width="76">
<p>12201</p>
</td>
</tr>
<tr>
<td width="74">
<p>5 123</p>
</td>
<td width="76">
<p>443</p>
</td>
</tr>
<tr>
<td width="74">
<p>4 1000</p>
</td>
<td width="76">
<p>33220</p>
</td>
</tr>
<tr>
<td width="74">
<p>9 3487</p>
</td>
<td width="76">
<p>4704</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Convert from base-N to base-10</h2>
<p>Write a program that takes a base-N number and converts it to a base-10 number (0 to 10<sup>50</sup>), where 2 &lt;= N &lt;= 10.<br /> The input consists of 1 line containing two numbers separated by a single space. The first number is the base N to which you have to convert. The second one is the base N number to be converted. <strong>Do not use any built in converting functionality, try to write your own algorithm.</strong></p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="74">
<p><strong>Base-N</strong></p>
</td>
<td width="76">
<p><strong>Base-10</strong></p>
</td>
</tr>
<tr>
<td width="74">
<p>7 13</p>
</td>
<td width="76">
<p>10</p>
</td>
</tr>
<tr>
<td width="74">
<p>3 12201</p>
</td>
<td width="76">
<p>154</p>
</td>
</tr>
<tr>
<td width="74">
<p>5 443</p>
</td>
<td width="76">
<p>123</p>
</td>
</tr>
<tr>
<td width="74">
<p>4 33220</p>
</td>
<td width="76">
<p>1000</p>
</td>
</tr>
<tr>
<td width="74">
<p>9 4704</p>
</td>
<td width="76">
<p>3487</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Count Substring Occurrences</h2>
<p>Write a program to <strong>find how many times a given string appears in a given text as substring</strong>. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the <strong>character casing</strong>. <strong>Overlapping</strong> between occurrences is <strong>allowed</strong>.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="616">
<p><strong>Input</strong></p>
</td>
<td width="71">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="616">
<p><strong>Wel</strong>come to the Software University (SoftUni)! <strong>Wel</strong>come to programming. Programming is <strong>wel</strong>lness for developers, said Max<strong>wel</strong>l.</p>
<p>wel</p>
</td>
<td width="71">
<p>4</p>
</td>
</tr>
<tr>
<td width="616">
<p><strong>aaaaaa</strong></p>
<p>aa</p>
</td>
<td width="71">
<p>5</p>
</td>
</tr>
<tr>
<td width="616">
<p><strong>ababa</strong> c<strong>aba</strong></p>
<p>aba</p>
</td>
<td width="71">
<p>3</p>
</td>
</tr>
<tr>
<td width="616">
<p>Welcome to SoftUni</p>
<p>Java</p>
</td>
<td width="71">
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sum big numbers</h2>
<p>You are given two lines - each can be a really big number (0 to 10<sup>50</sup>). You must display the sum of these numbers.</p>
<p>Note: do not use the <strong>BigInteger</strong> or <strong>BigDecimal</strong> classes for solving this problem.</p>
<h3>Examples</h3>
<table width="555">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="57">
<p><strong>Output</strong></p>
</td>
<td width="74">
<p><strong>Input</strong></p>
</td>
<td width="83">
<p><strong>Output</strong></p>
</td>
<td width="277">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="64">
<p>23</p>
<p>23</p>
</td>
<td width="57">
<p>46</p>
</td>
<td width="74">
<p>9999</p>
<p>1</p>
</td>
<td width="83">
<p>10000</p>
</td>
<td width="277">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td colspan="4" width="277">
<p><strong>Input</strong></p>
</td>
<td width="277">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td colspan="4" width="277">
<p>923847238931983192462832102</p>
<p>934572893617836459843471846187346</p>
</td>
<td width="277">
<p>934573817465075391826664309019448</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Multiply big number</h2>
<p>You are given two lines - the first one can be a really big number (0 to 10<sup>50</sup>). The second one will be a single digit number (0 to 9). You must display the product of these numbers.</p>
<p>Note: do not use the <strong>BigInteger</strong> or <strong>BigDecimal</strong> classes for solving this problem.</p>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="44">
<p><strong>Input</strong></p>
</td>
<td width="55">
<p><strong>Output</strong></p>
</td>
<td width="44">
<p><strong>Input</strong></p>
</td>
<td width="55">
<p><strong>Output</strong></p>
</td>
<td width="230">
<p><strong>Input</strong></p>
</td>
<td width="277">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="44">
<p>23</p>
<p>2</p>
</td>
<td width="55">
<p>46</p>
</td>
<td width="44">
<p>9999</p>
<p>9</p>
</td>
<td width="55">
<p>89991</p>
</td>
<td width="230">
<p>923847238931983192462832102</p>
<p>4</p>
</td>
<td width="277">
<p>934573817465075391826664309019448</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Text Filter</h2>
<p>Write a program that takes a <strong>text</strong> and a <strong>string of banned words</strong>. All words included in the ban list should be replaced with <strong>asterisks</strong> "<strong>*</strong>", equal to the word's length. The entries in the ban list will be separated by a <strong>comma</strong> and <strong>space</strong> "<strong>, </strong>".</p>
<p>The ban list should be entered on the first input line and the text on the second input line.</p>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="348">
<p><strong>Input</strong></p>
</td>
<td width="342">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="348">
<p>Linux, Windows</p>
<p>It is not <strong>Linux</strong>, it is GNU/<strong>Linux</strong>. <strong>Linux</strong> is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/<strong>Linux</strong>! Sincerely, a <strong>Windows</strong> client</p>
</td>
<td width="342">
<p>It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Unicode Characters</h2>
<p>Write a program that converts a string to a sequence of Unicode character literals.</p>
<h3>Examples</h3>
<table width="396">
<tbody>
<tr>
<td width="99">
<p><strong>Input</strong></p>
</td>
<td width="297">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="99">
<p>Hi!</p>
</td>
<td width="297">
<p>\u0048\u0069\u0021</p>
</td>
</tr>
<tr>
<td width="99">
<p>What?!?</p>
</td>
<td width="297">
<p>\0057\0068\0061\0074\003f\0021\003f</p>
</td>
</tr>
<tr>
<td width="99">
<p>SoftUni</p>
</td>
<td width="297">
<p>\0053\006f\0066\0074\0055\006e\0069</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Palindromes</h2>
<p>Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only <strong>unique</strong> palindromes, <strong>sorted</strong> lexicographically (small letters are before big ones).</p>
<h3>Examples</h3>
<table width="635">
<tbody>
<tr>
<td width="408">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="408">
<p>Hi,exe? ABBA! Hog fully a string. Bob</p>
</td>
<td width="227">
<p>[a, ABBA, exe]</p>
</td>
</tr>
<tr>
<td width="408">
<p>aibohphobia is fear of palindromes ahahaha</p>
</td>
<td width="227">
<p>[ahahaha, aibohphobia]</p>
</td>
</tr>
<tr>
<td width="408">
<p>aSantAAtnaSa is a rare sight</p>
</td>
<td width="227">
<p>[a, aSantAAtnaSa]</p>
</td>
</tr>
</tbody>
</table>
<p>TIP: if you have problems with the sorting - take a look at the Collator class</p>
<h2>Problem 12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Character Multiplier</h2>
<p>Create a <strong>method</strong> that takes two strings as arguments and returns the sum of their character codes multiplied (multiply str1.charAt (0) with str2.charAt (0) and add to the total sum). Then continue with the next two characters. If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="112">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="112">
<p>Gosho Pesho</p>
</td>
<td width="66">
<p>53253</p>
</td>
</tr>
<tr>
<td width="112">
<p>123 522</p>
</td>
<td width="66">
<p>7647</p>
</td>
</tr>
<tr>
<td width="112">
<p>a aaaa</p>
</td>
<td width="66">
<p>9700</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>Problem 13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Magic exchangeable words</h2>
<p>Write a <strong>method </strong>that takes as input two strings, and returns Boolean if they are exchangeable or not. Exchangeable are words where the characters in the first string can be replaced to get the second string. Example: "<strong>egg"</strong> and "<strong>add" </strong>are exchangeable, but "<strong>aabbccbb"</strong> and "<strong>nnooppzz"</strong> are not. (First '<strong>b'</strong> corresponds to '<strong>o'</strong>, but then it also corresponds to '<strong>z'</strong>). The two words may not have the same length, if such is the case they are exchangeable only if the longer one doesn't have more types of characters then the shorter one ("<strong>Clint" </strong>and<strong> "Eastwaat"</strong> are exchangeable because '<strong>a' </strong>and<strong> 't'</strong> are already mapped as '<strong>l' </strong>and<strong> 'n'</strong>, but "<strong>Clint" </strong>and<strong> "Eastwood</strong>" aren't exchangeable because '<strong>o'</strong> and '<strong>d'</strong> are not contained in "<strong>Clint"</strong>).</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>gosho hapka</p>
</td>
<td width="76">
<p>true</p>
</td>
</tr>
<tr>
<td width="140">
<p>aabbaa ddeedd</p>
</td>
<td width="76">
<p>true</p>
</td>
</tr>
<tr>
<td width="140">
<p>foo bar</p>
</td>
<td width="76">
<p>false</p>
</td>
</tr>
<tr>
<td width="140">
<p>Clint Eastwood</p>
</td>
<td width="76">
<p>false</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Letters Change Numbers</h2>
<p><strong>This problem is from the Java Basics exam (8 February 2015). You may check your solution </strong><a href="https://judge.softuni.bg/Contests/Practice/Index/69#1">here</a><strong>.</strong></p>
<p>Nakov likes Math. But he also likes the English alphabet a lot. He invented a game with numbers and letters from the <strong>English</strong> alphabet. The game was simple. You get a string consisting of a <strong>number between two letters</strong>. Depending on whether the letter was in front of the number or after it you would perform different mathematical operations on the number to achieve the result.</p>
<p><strong>First</strong> you start with the letter <strong>before </strong>the number. If it's <strong>Uppercase</strong> you <strong>divide</strong> the number by the letter's <strong>position</strong> in the alphabet. If it's <strong>lowercase</strong> you <strong>multiply</strong> the number with the letter's position. <strong>Then</strong> you move to the <strong>letter after</strong> the number. If it's <strong>Uppercase</strong> you <strong>subtract</strong> its position from the resulted number. If it's <strong>lowercase</strong> you <strong>add</strong> its position to the resulted number. But the game became too easy for Nakov really quick. He decided to complicate it a bit by doing the same but with <strong>multiple</strong> strings keeping track of only the <strong>total sum</strong> of all results. Once he started to solve this with more strings and bigger numbers it became quite hard to do it only in his mind. So he kindly asks you to write a program that <strong>calculates the sum of all numbers after the operations on each number have been done</strong>.</p>
<p><strong>For example</strong>, you are given the sequence "<strong>A12b s17G</strong>". We have two strings &ndash; <strong>"A12b"</strong> and <strong>"s17G"</strong>. We do the operations on each and sum them. We start with the letter before the number on the first string. <strong>A is Uppercase</strong> and its position in the alphabet is <strong>1</strong>. So we divide the number 12 with the position 1 (<strong>12/1 = 12)</strong>. Then we move to the letter after the number. <strong>b is lowercase</strong> and its position is 2. So we add 2 to the resulted number (<strong>12+2=14)</strong>. Similarly for the second string <strong>s is lowercase</strong> and its position is 19 so we multiply it with the number (<strong>17*19 = 323)</strong>. Then we have Uppercase G with position 7, so we subtract it from the resulted number&nbsp;(<strong>323 &ndash; 7 = 316)</strong>. Finally we sum the 2 results and we get <strong>14 + 316=330</strong>;</p>
<h3>Input</h3>
<p>The input comes from the console as a <strong>single line, holding the sequence of strings</strong>. Strings are separated by <strong>one or more white spaces</strong>.</p>
<p>The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print at the console a single number: the <strong>total sum of all processed numbers </strong>rounded up to<strong> two digits </strong>after the decimal separator.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>count</strong> of the strings will be in the range <strong>[1 &hellip; 10].</strong></li>
<li>The numbers between the letters will be integers in range <strong>[1 &hellip; 2 147 483 647].</strong></li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="707">
<tbody>
<tr>
<td width="206">
<p><strong>Input</strong></p>
</td>
<td width="85">
<p><strong>Output</strong></p>
</td>
<td width="416">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="206">
<p>A12b s17G</p>
</td>
<td width="85">
<p>330.00</p>
</td>
<td width="416">
<p>12/1=12, 12+2=14, 17*19=323, 323&ndash;7=316, <strong>14+316=330</strong></p>
</td>
</tr>
<tr>
<td width="206">
<p>P34562Z q2576f&nbsp;&nbsp; H456z</p>
</td>
<td width="85">
<p>46015.13</p>
</td>
<td width="416">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="206">
<p>a1A</p>
</td>
<td width="85">
<p>0.00</p>
</td>
<td width="416">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Melrah Shake</h2>
<p>You are given a <strong>string</strong> of random characters, and a <strong>pattern</strong> of random characters. You need to &ldquo;shake off&rdquo; (<strong>remove</strong>) all of the <strong>border</strong> occurrences of that pattern, in other words, the <strong>very</strong> <strong>first</strong> <strong>match</strong> and the <strong>very last match </strong>of the pattern you find in the string.</p>
<p>When you successfully shake off a match, you <strong>remove</strong> from the pattern the character which corresponds to the <strong>index</strong> equal to <strong>the pattern&rsquo;s length / 2</strong>. Then you continue to shake off the border occurrences of the new pattern until the pattern becomes <strong>empty</strong> or until there is <strong>less </strong>than the - needed for shake, matches in the remaining string.</p>
<p>In case you have found at least <strong>two</strong> matches, and you have successfully shaken them off, you print &ldquo;Shaked it.&rdquo; on the console. Otherwise you print &ldquo;No shake.&rdquo;, the remains of the main string, and you end the program. See the examples for more info.</p>
<h3>Input</h3>
<ul>
<li>The input will consist only of two lines.</li>
<li>On the first line you will get a string of random characters.</li>
<li>On the second line you will receive the pattern and that ends the input sequence.</li>
</ul>
<h3>Output</h3>
<ul>
<li>You must print &ldquo;Shaked it.&rdquo; for every time you successfully do the melrah shake.</li>
<li>If the melrah shake fails, you print &ldquo;No shake.&rdquo;, and on the next line you print what has remained of the main string.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The two strings may contain <strong>ANY </strong>ASCII character.</li>
<li>Allowed time/memory: 250ms/16MB.</li>
</ul>
<h3>Examples</h3>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>astalavista baby</p>
<p>sta</p>
</td>
<td width="294">
<p>Shaked it.</p>
<p>No shake.</p>
<p>alavi baby</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>##mtm!!mm.mm*mtm.#</p>
<p>mtm</p>
</td>
<td width="294">
<p>Shaked it.</p>
<p>Shaked it.</p>
<p>No shake.</p>
<p>##!!.*.#</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *** Extract Hyperlinks</h2>
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
<table width="698">
<tbody>
<tr>
<td width="484">
<p><strong>Input</strong></p>
</td>
<td width="213">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="484">
<p>&lt;a href="http://softuni.bg" class="new"&gt;&lt;/a&gt;</p>
<p>END</p>
</td>
<td width="213">
<p>http://softuni.bg</p>
</td>
</tr>
<tr>
<td width="484">
<p>&lt;p&gt;This text has no links&lt;/p&gt;</p>
<p>END</p>
</td>
<td width="213">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="484">
<p>&lt;!DOCTYPE html&gt;</p>
<p>&lt;html&gt;</p>
<p>&lt;head&gt;</p>
<p>&lt;title&gt;Hyperlinks&lt;/title&gt;</p>
<p>&lt;link href="theme.css" rel="stylesheet" /&gt;</p>
<p>&lt;/head&gt;</p>
<p>&lt;body&gt;</p>
<p>&lt;ul&gt;&lt;li&gt;&lt;a&nbsp;&nbsp; <strong>href="/"</strong>&nbsp; id="home"&gt;Home&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;a</p>
<p>class="selected" <strong>href=/courses</strong>&gt;Courses&lt;/a&gt;</p>
<p>&lt;/li&gt;&lt;li&gt;&lt;a <strong>href =</strong></p>
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
<p>&lt;a href="#commented"&gt;commentex hyperlink&lt;/a&gt; --&gt;</p>
<p>&lt;/body&gt;</p>
<p>END</p>
</td>
<td width="213">
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
<p>&nbsp;</p>
<p>&nbsp;</p>