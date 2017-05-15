<h1>Exercises: Sets And Dictionaries</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016">"CSharp Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Unique Usernames</h2>
<p>Write a simple program that reads from the console a sequence of usernames and keeps a collection with only the unique ones. Print the collection on the console in order of insertion:</p>
<h3>Examples</h3>
<table width="620">
<tbody>
<tr>
<td width="312">
<p><strong>Input</strong></p>
</td>
<td width="308">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="312">
<p>6</p>
<p>Ivan</p>
<p>Ivan</p>
<p>Ivan</p>
<p>SemoMastikata</p>
<p>Ivan</p>
<p>Hubaviq1234</p>
</td>
<td width="308">
<p>Ivan</p>
<p>SemoMastikata</p>
<p>Hubaviq1234</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sets of Elements</h2>
<p>On the first line you are given the length of two sets n and m. On the next n + m lines there are n numbers that are in the first set and m numbers that are in the second one. Find all non-repeating element that appears in both of them, and print them at the console:</p>
<p>Set with length n = 4: {1, <strong>3</strong>, <strong>5</strong>, 7}</p>
<p>Set with length m = 3: {<strong>3</strong>, 4, <strong>5</strong>}</p>
<p>Set that contains all repeating elements -&gt; {<strong>3</strong>, <strong>5</strong>}</p>
<h3>Examples</h3>
<table width="606">
<tbody>
<tr>
<td width="295">
<p><strong>Input</strong></p>
</td>
<td width="311">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="295">
<p>4 3</p>
<p>1</p>
<p>3</p>
<p>5</p>
<p>7</p>
<p>3</p>
<p>4</p>
<p>5</p>
</td>
<td width="311">
<p>3 5</p>
</td>
</tr>
<tr>
<td width="295">
<p>2 2</p>
<p>1</p>
<p>3</p>
<p>1</p>
<p>5</p>
</td>
<td width="311">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Periodic Table</h2>
<p>You are given an n number of chemical compounds. You need to keep track of all chemical elements used in the compounds and at the end print all unique ones in ascending order:</p>
<h3>Examples</h3>
<table width="617">
<tbody>
<tr>
<td width="300">
<p><strong>Input</strong></p>
</td>
<td width="316">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="300">
<p>4</p>
<p>Ce O</p>
<p>Mo O Ce</p>
<p>Ee</p>
<p>Mo</p>
</td>
<td width="316">
<p>Ce Ee Mo O</p>
</td>
</tr>
<tr>
<td width="300">
<p>3</p>
<p>Ge Ch O Ne</p>
<p>Nb Mo Tc</p>
<p>O Ne</p>
</td>
<td width="316">
<p>Ch Ge Mo Nb Ne O Tc</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Count Symbols</h2>
<p>Write a program that reads some text from the console and counts the occurrences of each character in it. Print the results in <strong>alphabetical</strong> (lexicographical) order.</p>
<h3>Examples</h3>
<table width="629">
<tbody>
<tr>
<td width="132">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td width="31">
<p><strong>&nbsp;</strong></p>
</td>
<td width="233">
<p><strong>Input</strong></p>
</td>
<td width="120">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="132">
<p>SoftUni rocks</p>
</td>
<td width="113">
<p>&nbsp;: 1 time/s</p>
<p>S: 1 time/s</p>
<p>U: 1 time/s</p>
<p>c: 1 time/s</p>
<p>f: 1 time/s</p>
<p>i: 1 time/s</p>
<p>k: 1 time/s</p>
<p>n: 1 time/s</p>
<p>o: 2 time/s</p>
<p>r: 1 time/s</p>
<p>s: 1 time/s</p>
<p>t: 1 time/s</p>
</td>
<td width="31">
<p>&nbsp;</p>
</td>
<td width="233">
<p>Did you know Math.Round rounds to the nearest even integer?</p>
</td>
<td width="120">
<p>: 9 time/s</p>
<p>.: 1 time/s</p>
<p>?: 1 time/s</p>
<p>D: 1 time/s</p>
<p>M: 1 time/s</p>
<p>R: 1 time/s</p>
<p>a: 2 time/s</p>
<p>d: 3 time/s</p>
<p>e: 7 time/s</p>
<p>g: 1 time/s</p>
<p>h: 2 time/s</p>
<p>i: 2 time/s</p>
<p>k: 1 time/s</p>
<p>n: 6 time/s</p>
<p>o: 5 time/s</p>
<p>r: 3 time/s</p>
<p>s: 2 time/s</p>
<p>t: 5 time/s</p>
<p>u: 3 time/s</p>
<p>v: 1 time/s</p>
<p>w: 1 time/s</p>
<p>y: 1 time/s</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Phonebook</h2>
<p>Write a program that receives some info from the console about <strong>people</strong> and their <strong>phone numbers</strong>.</p>
<p>You are free to choose the manner in which the data is entered; each <strong>entry</strong> should have just <strong>one name</strong> and <strong>one number</strong> (both of them strings). If you receive a name that <strong>already exists</strong> in the phonebook, simply update its number.</p>
<p>After filling this simple phonebook, upon receiving the <strong>command</strong> "<strong>search</strong>", your program should be able to perform a search of a contact by name and print her details in format "<strong>{name} -&gt; {number}</strong>". In case the contact isn't found, print "<strong>Contact {name} does not exist.</strong>" Examples:</p>
<h3>Examples</h3>
<p>&nbsp;</p>
<table width="639">
<tbody>
<tr>
<td width="311">
<p><strong>Input</strong></p>
</td>
<td width="328">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="311">
<p>Nakov-0888080808</p>
<p><strong>search</strong></p>
<p>Mariika</p>
<p>Nakov</p>
<p>Stop</p>
</td>
<td width="328">
<p>Contact Mariika does not exist.</p>
<p>Nakov -&gt; 0888080808</p>
</td>
</tr>
<tr>
<td width="311">
<p>Nakov-+359888001122</p>
<p>RoYaL(Ivan)-666</p>
<p>Gero-5559393</p>
<p>Simo-02/987665544</p>
<p><strong>search</strong></p>
<p>Simo</p>
<p>simo</p>
<p>RoYaL</p>
<p>RoYaL(Ivan)</p>
<p>stop</p>
</td>
<td width="328">
<p>Simo -&gt; 02/987665544</p>
<p>Contact simo does not exist.</p>
<p>Contact RoYaL does not exist.</p>
<p>RoYaL(Ivan) -&gt; 666</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A miner task</h2>
<p>You are given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) , and every even &ndash; quantity. Your task is to collect the resources and print them each on a new line.</p>
<p><strong>Print the resources and their quantities in format:</strong></p>
<p><strong>{resource} &ndash;&gt; {quantity}</strong></p>
<p>The quantities inputs will be in the range [1 &hellip; 2 000 000 000]</p>
<h3>Examples</h3>
<table width="586">
<tbody>
<tr>
<td width="274">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="274">
<p>Gold</p>
<p>155</p>
<p>Silver</p>
<p>10</p>
<p>Copper</p>
<p>17</p>
<p>stop</p>
</td>
<td width="312">
<p>Gold -&gt; 155</p>
<p>Silver -&gt; 10</p>
<p>Copper -&gt; 17</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fix emails</h2>
<p>You are given a sequence of strings, each on a new line, <strong>unitll you receive &ldquo;stop&rdquo; command</strong>. First string is a name of a person. On the second line you receive his email. Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive). Print:</p>
<p><strong>{name} &ndash; &gt; {email}</strong></p>
<h3>Examples</h3>
<table width="600">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="343">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>Ivan</p>
<p><a href="mailto:ivanivan@abv.bg">ivanivan@abv.bg</a></p>
<p>Petar Ivanov</p>
<p>petartudjarov@abv.bg</p>
<p>Mike Tyson</p>
<p><a href="mailto:myke@gmail.us">myke@gmail.us</a></p>
<p>stop</p>
</td>
<td width="343">
<p>Ivan -&gt; <a href="mailto:ivanivan@abv.bg">ivanivan@abv.bg</a></p>
<p>Petar Ivanov -&gt; petartudjarov@abv.bg</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hands of cards</h2>
<p>You are given a sequence of people and for every person what cards he draws from the deck. The input will be separate lines in the format:</p>
<p><strong>{personName}: {PT, PT, PT,&hellip; PT}</strong></p>
<p>Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. The input ends when a <strong>"JOKER"</strong> is drawn. The name can contain any ASCII symbol except <strong>':'</strong>. The input will always be valid and in the format described, there is no need to check it.</p>
<p>A single person <u>cannot have more than one</u> card with the same power and type, if he draws such a card he discards it. The people are playing with <u>multiple decks</u>. Each card has a value that is calculated by the power multiplied by the type. Powers <strong>2 to 10</strong> have the same value and <strong>J to A</strong> are <strong>11 to 14</strong>. Types are mapped to multipliers the following way (<strong>S -&gt; 4, H-&gt; 3, D -&gt; 2, C -&gt; 1</strong>).</p>
<p>Finally print out the total value each player has in his hand in the format:</p>
<p><strong>{personName}: {value}</strong></p>
<h3>Examples</h3>
<table width="600">
<tbody>
<tr>
<td width="272">
<p><strong>Input</strong></p>
</td>
<td width="327">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="272">
<p>Pesho: 2C, 4H, 9H, AS, QS</p>
<p>Slav: 3H, 10S, JC, KD, 5S, 10S</p>
<p>Peshoslav: QH, QC, QS, QD</p>
<p>Slav: 6H, 7S, KC, KD, 5S, 10C</p>
<p>Peshoslav: QH, QC, JS, JD, JC</p>
<p>Pesho: JD, JD, JD, JD, JD, JD</p>
<p>JOKER</p>
</td>
<td width="327">
<p>Pesho: 167</p>
<p>Slav: 175</p>
<p>Peshoslav: 197</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * User Logs</h2>
<p>Marian is a famous system administrator. The person to overcome the security of his servers has not yet been born. However, there is a new type of threat where users flood the server with messages and are hard to be detected since they change their IP address all the time. Well, Marian is a system administrator and is not so into programming. Therefore, he needs a skillful programmer to track the user logs of his servers. You are the chosen one to help him!</p>
<p>You are given an input in the format:</p>
<p><strong>IP=(IP.Address) message=(A&amp;sample&amp;message) user=(username)</strong></p>
<p>Your task is to parse the ip and the username from the input and for <strong>every user</strong>, you have to display <strong>every ip</strong> from which the corresponding user has sent a message and the <strong>count of the messages</strong> sent with the corresponding ip. In the output, the usernames must be <strong>sorted alphabetically</strong> while their IP addresses should be displayed in the <strong>order of their first appearance. </strong>The output should be in the following format:</p>
<p><strong>username: </strong></p>
<p><strong>IP =&gt; count, IP =&gt; count.</strong></p>
<p>For example, given the following input - <strong>IP=192.23.30.40 message='Hello&amp;derps.' user=destroyer</strong>, you have to get the username <strong>destroyer</strong> and the IP <strong>192.23.30.40</strong> and display it in the following format:</p>
<p><strong>destroyer: </strong></p>
<p><strong>192.23.30.40 =&gt; 1.</strong></p>
<p>The username destroyer has sent a message from ip 192.23.30.40 once.</p>
<p>Check the examples below. They will further clarify the assignment.</p>
<h3>Input</h3>
<p>The input comes from the console as <strong>varying number</strong> of lines. You have to parse every command until the command that follows is <strong>end.</strong> The input will be in the format displayed above, there is no need to check it explicitly.</p>
<h3>Output</h3>
<p>For every user found, you have to display each log in the format:</p>
<p><strong>username: </strong></p>
<p><strong>IP =&gt; count, IP =&gt; count&hellip;</strong></p>
<p>The IP addresses must be split with a comma, and each line of IP addresses must end with a dot.</p>
<h3>Constraints</h3>
<ul>
<li>The number of commands will be in the range [1..50]</li>
<li>The IP addresses will be in the format of either<strong> IPv4</strong> or <strong>IPv6.</strong></li>
<li>The messages will be in the format: <strong>This&amp;is&amp;a&amp;message</strong></li>
<li>The username will be a string with length in the range [3..50]</li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="501">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="501">
<p>IP=192.23.30.40 message='Hello&amp;derps.' user=destroyer</p>
<p>IP=192.23.30.41 message='Hello&amp;yall.' user=destroyer</p>
<p>IP=192.23.30.40 message='Hello&amp;hi.' user=destroyer</p>
<p>IP=192.23.30.42 message='Hello&amp;Dudes.' user=destroyer</p>
<p>end</p>
</td>
<td width="189">
<p>destroyer:</p>
<p>192.23.30.40 =&gt; 2, 192.23.30.41 =&gt; 1, 192.23.30.42 =&gt; 1.</p>
</td>
</tr>
<tr>
<td width="501">IP=FE80:0000:0000:0000:0202:B3FF:FE1E:8329 message='Hey&amp;son' user=mother
<p>IP=192.23.33.40 message='Hi&amp;mom!' user=child0</p>
<p>IP=192.23.30.40 message='Hi&amp;from&amp;me&amp;too' user=child1</p>
<p>IP=192.23.30.42 message='spam' user=destroyer</p>
<p>IP=192.23.30.42 message='spam' user=destroyer</p>
<p>IP=192.23.50.40 message='' user=yetAnotherUsername</p>
<p>IP=192.23.50.40 message='comment' user=yetAnotherUsername</p>
<p>IP=192.23.155.40 message='Hello.' user=unknown</p>
<p>end</p>
</td>
<td width="189">
<p>child0:</p>
<p>192.23.33.40 =&gt; 1.</p>
<p>child1:</p>
<p>192.23.30.40 =&gt; 1.</p>
<p>destroyer:</p>
<p>192.23.30.42 =&gt; 2.</p>
<p>mother:</p>
<p>FE80:0000:0000:0000:0202:B3FF:FE1E:8329 =&gt; 1.</p>
<p>unknown:</p>
<p>192.23.155.40 =&gt; 1.</p>
<p>yetAnotherUsername:</p>
<p>192.23.50.40 =&gt; 2.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Population Counter</h2>
<p>So many people! It&rsquo;s hard to count them all. But that&rsquo;s your job as a statistician. You get raw data for a given city and you need to aggregate it.</p>
<p>On each input line you&rsquo;ll be given data in format: <strong>"city|country|population"</strong>. There will be <strong>no redundant whitespaces anywhere</strong> in the input. Aggregate the data <strong>by country and by city</strong> and print it on the console. For each country, print its <strong>total population</strong> and on separate lines the data for each of its cities. <strong>Countries should be ordered by their total population in descending order</strong> and within each country, the <strong>cities should be ordered by the same criterion</strong>. If two countries/cities have the same population, keep them <strong>in the order in which they were entered.</strong> Check out the examples; follow the output format strictly!</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>It consists of a variable number of lines and ends when the command "<strong>report</strong>" is received.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console.</li>
<li>Print the aggregated data for each country and city in the format shown below.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The name of the city, country and the population count will be separated from each other by <strong>a pipe ('|')</strong>.</li>
<li>The <strong>number of input lines</strong> will be in the range [2 &hellip; 50].</li>
<li>A city-country pair will not be repeated.</li>
<li>The <strong>population count</strong> of each city will be an integer in the range [0 &hellip; 2 000 000 000].</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="456">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>Sofia|Bulgaria|1000000</p>
<p>report</p>
</td>
<td width="456">
<p>Bulgaria (total population: 1000000)</p>
<p>=&gt;Sofia: 1000000</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="677">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="456">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>Sofia|Bulgaria|1</p>
<p>Veliko Tarnovo|Bulgaria|2</p>
<p>London|UK|4</p>
<p>Rome|Italy|3</p>
<p>report</p>
</td>
<td width="456">
<p>UK (total population: 4)</p>
<p>=&gt;London: 4</p>
<p>Bulgaria (total population: 3)</p>
<p>=&gt;Veliko Tarnovo: 2</p>
<p>=&gt;Sofia: 1</p>
<p>Italy (total population: 3)</p>
<p>=&gt;Rome: 3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Logs Aggregator</h2>
<p>You are given a sequence of access logs in format <strong>&lt;IP&gt; &lt;user&gt; &lt;duration&gt;</strong>. For example:</p>
<ul>
<li>168.0.11 peter 33</li>
<li>10.17.33 alex 12</li>
<li>10.17.35 peter 30</li>
<li>10.17.34 peter 120</li>
<li>10.17.34 peter 120</li>
<li>50.118.81 alex 46</li>
<li>50.118.81 alex 4</li>
</ul>
<p>Write a program to aggregate the logs data and print <strong>for each user</strong> the <strong>total duration</strong> of his sessions and a <strong>list of unique IP addresses</strong> in format "<strong>&lt;user&gt;: &lt;duration&gt; [&lt;IP<sub>1</sub>&gt;, &lt;IP<sub>2</sub>&gt;, &hellip;]</strong>". Order the <strong>users alphabetically</strong>. Order the <strong>IPs alphabetically</strong>. In our example, the output should be the following:</p>
<ul>
<li>alex: 62 [10.10.17.33, 212.50.118.81]</li>
<li>peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]</li>
</ul>
<h3>Input</h3>
<p>The input comes from the console. At the first line a number <strong>n</strong> stays which says how many log lines will follow. Each of the next n lines holds a log information in format <strong>&lt;IP&gt; &lt;user&gt; &lt;duration&gt;</strong>. The input data will always be valid and in the format described. There is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print <strong>one line for each user</strong> (order users alphabetically). For each user print its sum of durations and all of his sessions' IPs, ordered alphabetically in format <strong>&lt;user&gt;: &lt;duration&gt; [&lt;IP<sub>1</sub>&gt;, &lt;IP<sub>2</sub>&gt;, &hellip;]</strong>. Remove any duplicated values in the IP addresses and order them alphabetically (like we order strings).</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>count</strong> of the order lines <strong>n</strong> is in the range [1&hellip;1000].</li>
<li>The <strong>&lt;IP&gt;</strong> is a standard IP address in format <strong>a.b.c.d</strong> where <strong>a</strong>, <strong>b</strong>, <strong>c</strong> and <strong>d</strong> are integers in the range [0&hellip;255].</li>
<li>The <strong>&lt;user&gt;</strong> consists of only of <strong>Latin characters</strong>, with length of [1&hellip;20].</li>
<li>The <strong>&lt;duration&gt;</strong> is an integer number in the range [1&hellip;1000].</li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="635">
<tbody>
<tr>
<td width="205">
<p><strong>Input</strong></p>
</td>
<td width="430">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="205">
<p>7</p>
<p>192.168.0.11 peter 33</p>
<p>10.10.17.33 alex 12</p>
<p>10.10.17.35 peter 30</p>
<p>10.10.17.34 peter 120</p>
<p>10.10.17.34 peter 120</p>
<p>212.50.118.81 alex 46</p>
<p>212.50.118.81 alex 4</p>
</td>
<td width="430">
<p>alex: 62 [10.10.17.33, 212.50.118.81]</p>
<p>peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11]</p>
</td>
</tr>
<tr>
<td width="205">
<p>2</p>
<p>84.238.140.178 nakov 25</p>
<p>84.238.140.178 nakov 35</p>
</td>
<td width="430">
<p>nakov: 60 [84.238.140.178]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Legendary Farming</h2>
<p>You&rsquo;ve beaten all the content and the last thing left to accomplish is own a legendary item. However, it&rsquo;s a tedious process and requires quite a bit of farming. Anyway, you are not too pretentious &ndash; any legendary will do. The possible items are:</p>
<ul>
<li><strong>Shadowmourne</strong> &ndash; requires <strong>250 Shards</strong>;</li>
<li><strong>Valanyr</strong> &ndash; requires <strong>250 Fragments</strong>;</li>
<li><strong>Dragonwrath </strong>&ndash; requires <strong>250 Motes</strong>;</li>
</ul>
<p><strong>Shards, Fragments </strong>and<strong> Motes </strong>are the <strong>key materials</strong>, all else is <strong>junk. </strong>You will be given lines of input, such as <br /> <strong>2 motes 3 ores 15 stones. </strong>Keep track of the <strong>key materials - </strong>the <strong>first</strong> that reaches the <strong>250 mark</strong> <strong>wins</strong> the <strong>race</strong>. At that point, print the corresponding legendary obtained. Then, print the <strong>remaining</strong> shards, fragments, motes, ordered by <strong>quantity</strong> in <strong>descending</strong> order, each on a new line. Finally, print the collected <strong>junk</strong> items, in <strong>alphabetical </strong>order.</p>
<h3>Input</h3>
<ul>
<li>Each line of input is in format <strong>{quantity} {material} {quantity} {material} &hellip; {quantity} {material}</strong></li>
</ul>
<h3>Output</h3>
<ul>
<li>On the first line, print the obtained item in format <strong>{Legendary item} obtained!</strong></li>
<li>On the next three lines, print the remaining key materials in descending order by quantity
<ul>
<li>If two key materials have the same quantity, print them in alphabetical order</li>
</ul>
</li>
<li>On the final several lines, print the junk items in alphabetical order
<ul>
<li>All materials are printed in format <strong>{material}: {quantity}</strong></li>
<li>All output should be <strong>lowercase</strong>, except the first letter of the legendary</li>
</ul>
</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The quantity-material pairs are between 1 and 25 per line.</li>
<li>The number of lines is in range [1..10]</li>
<li>All materials are case-insensitive.</li>
<li>Allowed working time: 0.25s</li>
<li>Allowed memory: 16 MB</li>
</ul>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="299">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="299">
<p>3 Motes 5 stones 5 Shards</p>
<p>6 leathers 255 fragments 7 Shards</p>
</td>
<td width="378">
<p>Valanyr obtained!</p>
<p>fragments: 5</p>
<p>shards: 5</p>
<p>motes: 3</p>
<p>leathers: 6</p>
<p>stones: 5</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>123 silver 6 shards 8 shards 5 motes</p>
<p>9 fangs 75 motes 103 MOTES 8 Shards</p>
<p>86 Motes 7 stones 19 silver</p>
</td>
<td width="372">
<p>Dragonwrath obtained!</p>
<p>shards: 22</p>
<p>motes: 19</p>
<p>fragments: 0</p>
<p>fangs: 9</p>
<p>silver: 123</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 13. ** Сръбско Unleashed</h2>
<p>Admit it &ndash; the СРЪБСКО is your favorite sort of music. You never miss a concert and you have become quite the geek concerning everything involved with СРЪБСКО. You can&rsquo;t decide between all the singers you know who your favorite one is. One way to find out is to keep a statistics of how much money their concerts make. Write a program that does all the boring calculations for you.</p>
<p>On each input line you&rsquo;ll be given data in format: <strong>"singer @venue ticketsPrice ticketsCount"</strong>. There will be <strong>no redundant whitespaces anywhere</strong> in the input. Aggregate the data <strong>by venue and by singer</strong>. For each venue, print the singer and the total amount of money his/her concerts have made on a separate line. <strong>Venues </strong>should be kept in the <strong>same order </strong>they were entered, the <strong>singers </strong>should be<strong> sorted by how much money </strong>they have made in<strong> descending order</strong>. If two singers have made the same amount of money, keep them <strong>in the order </strong>in which<strong> they were entered.</strong></p>
<p>Keep in mind that if a line is in incorrect format, it should be skipped and its data should not be added to the output. Each of the four tokens must be separated by <strong>a space</strong>, everything else is invalid. The venue should be denoted with <strong>@</strong> in front of it, such as @Sunny Beach</p>
<p><strong>SKIP THOSE</strong>: Ceca@Belgrade125 12378, Ceca @Belgrade12312 123</p>
<p>The singer and town name may consist of one to three words.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console.</li>
<li>It consists of a variable number of lines and ends when the command &ldquo;<strong>End</strong>" is received.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console.</li>
<li>Print the aggregated data for each venue and singer in the format shown below.</li>
<li>Format for singer lines is <strong>#{2*space}{singer}{space}-&gt;{space}{total money}</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The <strong>number of input lines</strong> will be in the range [2 &hellip; 50].</li>
<li>The <strong>ticket price</strong> will be an integer in the range [0 &hellip; 200].</li>
<li>The <strong>ticket count </strong>will be an integer in the range [0 &hellip; 100 000]</li>
<li><strong>Singers</strong> and <strong>venues</strong> are case sensitive</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>Lepa Brena @Sunny Beach 25 3500</p>
<p>Dragana @Sunny Beach 23 3500</p>
<p>Ceca @Sunny Beach 28 3500</p>
<p>Mile Kitic @Sunny Beach 21 3500</p>
<p>Ceca @Sunny Beach 35 3500</p>
<p>Ceca @Sunny Beach 70 15000</p>
<p>Saban Saolic @Sunny Beach 120 35000</p>
<p>End</p>
</td>
<td width="372">
<p>Sunny Beach</p>
<p>#&nbsp; Saban Saolic -&gt; 4200000</p>
<p>#&nbsp; Ceca -&gt; 1270500</p>
<p>#&nbsp; Lepa Brena -&gt; 87500</p>
<p>#&nbsp; Dragana -&gt; 80500</p>
<p>#&nbsp; Mile Kitic -&gt; 73500</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>Lepa Brena @Sunny Beach 25 3500</p>
<p>Dragana@Belgrade23 3500</p>
<p>Ceca @Sunny Beach 28 3500</p>
<p>Mile Kitic @Sunny Beach 21 3500</p>
<p>Ceca @Belgrade 35 3500</p>
<p>Ceca @Sunny Beach 70 15000</p>
<p>Saban Saolic @Sunny Beach 120 35000</p>
<p>End</p>
</td>
<td width="372">
<p>Sunny Beach</p>
<p>#&nbsp; Saban Saolic -&gt; 4200000</p>
<p>#&nbsp; Ceca -&gt; 1148000</p>
<p>#&nbsp; Lepa Brena -&gt; 87500</p>
<p>#&nbsp; Mile Kitic -&gt; 73500</p>
<p>Belgrade</p>
<p>#&nbsp; Ceca -&gt; 122500</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *** Dragon Army</h2>
<p>Heroes III is the best game ever. Everyone loves it and everyone plays it all the time. Stamat is no exclusion to this rule. His favorite units in the game are all <strong>types</strong> of dragons &ndash; black, red, gold, azure etc&hellip; He likes them so much that he gives them <strong>names</strong> and keeps logs of their <strong>stats</strong>: <strong>damage, health </strong>and<strong> armor</strong>. The process of aggregating all the data is quite tedious, so he would like to have a program doing it. Since he is no programmer, it&rsquo;s your task to help him</p>
<p>You need to categorize dragons by their <strong>type</strong>. For each dragon, identified by <strong>name, </strong>keep information about his <strong>stats. </strong>Type is <strong>preserved </strong>as in the order of input, but dragons are <strong>sorted</strong> alphabetically by name. For each type, you should also print the average <strong>damage</strong>, <strong>health</strong> and <strong>armor</strong> of the dragons. For each dragon, print his own stats.</p>
<p>There <strong>may</strong> be <strong>missing</strong> stats in the input, though. If a stat is missing you should assign it default values. Default values are as follows: health <strong>250</strong>, damage <strong>45</strong>, and armor <strong>10</strong>. Missing stat will be marked by <strong>null</strong>.</p>
<p>The input is in the following format <strong>{type} {name} {damage} {health} {armor}. </strong>Any of the integers may be assigned null value. See the examples below for better understanding of your task.</p>
<p>If the same dragon is added a second time, the new stats should <strong>overwrite</strong> the previous ones. Two dragons are considered <strong>equal</strong> if they match by <strong>both</strong> name and type.</p>
<h3>Input</h3>
<ul>
<li>On the first line, you are given number N -&gt; the number of dragons to follow</li>
<li>On the next N lines you are given input in the above described format. There will be single space separating each element.</li>
</ul>
<h3>Output</h3>
<ul>
<li>Print the aggregated data on the console</li>
<li>For each type, print average stats of its dragons in format <strong>{Type}::({damage}/{health}/{armor})</strong></li>
<li>Damage, health and armor should be rounded to two digits after the decimal separator</li>
<li>For each dragon, print its stats in format <strong>-{Name} -&gt; damage: {damage}, health: {health}, armor: {armor}</strong></li>
</ul>
<h3>Constraints</h3>
<ul>
<li>N is in range [1&hellip;100]</li>
<li>The dragon type and name are one word only, starting with capital letter.</li>
<li>Damage health and armor are integers in range [0 &hellip; 100000] or <strong>null</strong></li>
</ul>
<h3>Examples</h3>
<table width="616">
<tbody>
<tr>
<td width="274">
<p><strong>Input</strong></p>
</td>
<td width="342">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="274">
<p>5</p>
<p>Red Bazgargal 100 2500 25</p>
<p>Black Dargonax 200 3500 18</p>
<p>Red Obsidion 220 2200 35</p>
<p>Blue Kerizsa 60 2100 20</p>
<p>Blue Algordox 65 1800 50</p>
</td>
<td width="342">
<p>Red::(160.00/2350.00/30.00)</p>
<p>-Bazgargal -&gt; damage: 100, health: 2500, armor: 25</p>
<p>-Obsidion -&gt; damage: 220, health: 2200, armor: 35</p>
<p>Black::(200.00/3500.00/18.00)</p>
<p>-Dargonax -&gt; damage: 200, health: 3500, armor: 18</p>
<p>Blue::(62.50/1950.00/35.00)</p>
<p>-Algordox -&gt; damage: 65, health: 1800, armor: 50</p>
<p>-Kerizsa -&gt; damage: 60, health: 2100, armor: 20</p>
</td>
</tr>
<tr>
<td width="274">
<p><strong>Input</strong></p>
</td>
<td width="342">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="274">
<p>4</p>
<p>Gold Zzazx null 1000 10</p>
<p>Gold Traxx 500 null 0</p>
<p>Gold Xaarxx 250 1000 null</p>
<p>Gold Ardrax 100 1055 50</p>
</td>
<td width="342">
<p>Gold::(223.75/826.25/17.50)</p>
<p>-Ardrax -&gt; damage: 100, health: 1055, armor: 50</p>
<p>-Traxx -&gt; damage: 500, health: 250, armor: 0</p>
<p>-Xaarxx -&gt; damage: 250, health: 1000, armor: 10</p>
<p>-Zzazx -&gt; damage: 45, health: 1000, armor: 10</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h1>IV.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Problems with Matrices</h1>
<h2>Problem 15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Rubik&rsquo;s Matrix</h2>
<p>Rubik&rsquo;s cube &ndash; everyone&rsquo;s favorite head-scratcher. Writing a program to solve it will be quite a difficult task for an exam, though. Instead, we have a Rubik&rsquo;s matrix prepared for you. You will be given a pair of dimensions: <strong>R</strong> and <strong>C. </strong>To prepare the matrix, fill each row with increasing integers, starting from one. For example, <strong>2 x 4</strong> matrix must look like this:</p>
<table>
<tbody>
<tr>
<td width="22">
<p>1</p>
</td>
<td width="22">
<p>2</p>
</td>
<td width="22">
<p>3</p>
</td>
<td width="22">
<p>4</p>
</td>
</tr>
<tr>
<td width="22">
<p>5</p>
</td>
<td width="22">
<p>6</p>
</td>
<td width="22">
<p>7</p>
</td>
<td width="22">
<p>8</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Next, you will receive series of commands, indicating which row or column you must move, in which direction, and how many times. For example, <strong>1 up 1</strong> means: column 1, direction: up, 1 move. After executing it, the matrix should look like:</p>
<table>
<tbody>
<tr>
<td width="22">
<p>1</p>
</td>
<td width="22">
<p>6</p>
</td>
<td width="22">
<p>3</p>
</td>
<td width="22">
<p>4</p>
</td>
</tr>
<tr>
<td width="22">
<p>5</p>
</td>
<td width="22">
<p>2</p>
</td>
<td width="22">
<p>7</p>
</td>
<td width="22">
<p>8</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Directions <strong>left</strong> and <strong>right</strong> mean you must move the corresponding <strong>row</strong>, while <strong>up</strong> and <strong>down</strong> and related to the <strong>columns. </strong>After shuffling the Rubik&rsquo;s matrix, you have to <strong>rearrange</strong> it (meaning that the <strong>values in each cell</strong> should be in <strong>increasing order</strong>, such as the ones in the original matrix). The rearranging process should start at <strong>top-left</strong> and end at <strong>bottom-right</strong>. Find the <strong>position</strong> of the value you need, and print the <strong>swap</strong> <strong>command</strong> on the console, in the format described below.</p>
<h3>Input</h3>
<ul>
<li>On the first line, you are given the integers <strong>R</strong> and <strong>C</strong>, separated by a space.</li>
<li>On the second line, you are given an integer <strong>N</strong>, indicating the number of commands to follow</li>
<li>On the next N lines, you are given commands in format <strong>{row/col} {direction} {moves}</strong></li>
</ul>
<h3>Output</h3>
<ul>
<li>On <strong>R</strong> * <strong>C</strong> number of lines, print the <strong>swap commands </strong>needed to rearrange the matrix, either:
<ul>
<li><strong>Swap ({row}, {col}) with ({row}, {col}) </strong>or</li>
<li><strong>No swap required</strong></li>
</ul>
</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>R, C, N</strong> are integers in range [1 &hellip; 100]</li>
<li>{<strong>row</strong>} and {<strong>col</strong>} will always be inside the matrix</li>
<li>{<strong>moves</strong>} is in range [0 &hellip; 2<sup>31</sup>-1]</li>
<li>Allowed time and memory: 0.25s / 16 MB</li>
</ul>
<h3>Examples</h3>
<table width="624">
<tbody>
<tr>
<td width="156">
<p><strong>Input</strong></p>
</td>
<td width="156">
<p><strong>Output</strong></p>
</td>
<td width="156">
<p><strong>Input</strong></p>
</td>
<td width="156">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="156">
<p>3 3</p>
<p>2</p>
<p>1 down 1</p>
<p>1 left 1</p>
</td>
<td width="156">
<p>No swap required</p>
<p>Swap (0, 1) with (1, 0)</p>
<p>No swap required</p>
<p>Swap (1, 0) with (1, 2)</p>
<p>Swap (1, 1) with (2, 1)</p>
<p>Swap (1, 2) with (2, 1)</p>
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
</td>
<td width="156">
<p>3 3</p>
<p>2</p>
<p>0 down 3</p>
<p>0 left 3</p>
</td>
<td width="156">
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
<p>No swap required</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Target Practice</h2>
<p>Cotton-eye Gosho has a problem. Snakes! An infestation of snakes! Gosho is a red-neck which means he doesn&rsquo;t really care about animal rights, so he bought some ammo, loaded his shotgun and started shooting at the poor creatures. He has a favorite spot &ndash; rectangular stairs which the snakes like to climb in order to reach Gosho&rsquo;s stash of whiskey in the attic. You&rsquo;re tasked with the horrible cleanup of the aftermath.</p>
<p>A <strong>snake</strong> is represented by <strong>a string</strong>. The <strong>stairs</strong> are a <strong>rectangular matrix of size NxM</strong>. A snake starts climbing the stairs from the <strong>bottom-right corner</strong> and slithers its way up in a <strong>zigzag</strong> &ndash; first it moves left until it reaches the left wall, it climbs on the next row and starts moving right, then on the third row, moving left again and so on. The first cell (bottom-right corner) is filled with the first symbol of the snake, the second cell (to the left of the first) is filled with the second symbol, etc. The snake is as long as it takes in order to <strong>fill the stairs completely</strong> &ndash; if you reach the end of the string representing the snake, start again at the beginning. Gosho is patient and a sadist, he&rsquo;ll wait until the stairs are completely covered with snake and will then fire a shot.</p>
<p>The shot has three parameters &ndash; <strong>impact row, impact column and radius</strong>. When the projectile lands on the specified coordinates of the matrix it <strong>destroys all symbols in the given radius (turns them into a space)</strong>. You can check whether a cell is inside the blast radius using the Pythagorean Theorem (very similar to the "point inside a circle" problem).</p>
<p>The symbols above the impact area start <strong>falling down until they land on other symbols (meaning a symbol moves down a row as long as there is a space below)</strong>. When the horror ends, print on the console the <strong>resulting staircase, each row on a new line</strong>. You should really check out the examples at this point.</p>
<h3>Input</h3>
<ul>
<li>The input data should be read from the console. It consists of exactly three lines.</li>
<li>On the first line, you&rsquo;ll receive the <strong>dimensions</strong> of the stairs in format: <strong>"N M"</strong>, where <strong>N</strong> is the number of <strong>rows</strong>, and <strong>M</strong> is the number of <strong>columns</strong>. They&rsquo;ll be separated by a single space.</li>
<li>On the second line you&rsquo;ll receive the string representing the <strong>snake</strong>.</li>
<li>On the third line, you&rsquo;ll receive the <strong>shot parameters (impact row, impact column and radius)</strong>, all separated by a <strong>single space</strong>.</li>
<li>The input data will always be valid and in the format described. There is no need to check it explicitly.</li>
</ul>
<p>&nbsp;</p>
<h3>Output</h3>
<ul>
<li>The output should be printed on the console. It should consist of <strong>N lines</strong>.</li>
<li>Each line should contain a string representing the respective row of the final matrix.</li>
</ul>
<p>&nbsp;</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>dimensions</strong> N and M of the matrix will be integers in the range [1 &hellip; 12].</li>
<li>The <strong>snake</strong> will be a string with length in the range [1 &hellip; 20] and <strong>will not contain any whitespace characters</strong>.</li>
<li>The shot&rsquo;s <strong>impact row and column</strong> will always be <strong>valid coordinates</strong> in the matrix &ndash; they will be integers in the range [0 &hellip; N &ndash; 1] and [0 &hellip; M &ndash; 1] respectively.</li>
<li>The shot&rsquo;s <strong>radius</strong> will be an integer in the range [0 &hellip; 4].</li>
<li>Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.</li>
</ul>
<p>&nbsp;</p>
<p>Examples</p>
<table width="668">
<tbody>
<tr>
<td width="71">
<p><strong>Input</strong></p>
</td>
<td width="60">
<p><strong>Output</strong></p>
</td>
<td width="537">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="71">
<p>5 6</p>
<p>SoftUni</p>
<p>2 3 2</p>
</td>
<td width="60">
<p>o</p>
<p>US&nbsp;&nbsp; t</p>
<p>tn&nbsp;&nbsp; f</p>
<p>iSi UU</p>
<p>nUt oS</p>
</td>
<td width="537">
<p>The matrix has 5 rows and 6 columns. Fill it in the described pattern:</p>
<table>
<tbody>
<tr>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
</tr>
<tr>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>f</p>
</td>
</tr>
<tr>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>f</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>n</p>
</td>
</tr>
<tr>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>f</p>
</td>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>U</p>
</td>
</tr>
<tr>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>f</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
</tr>
</tbody>
</table>
<p>The shot lands on cell (2,3). It has a radius of 2 cells. The impact cell is shaded black and the other cells within the shot radius are shaded grey.</p>
<table>
<tbody>
<tr>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
</tr>
<tr>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>f</p>
</td>
</tr>
<tr>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>f</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>n</p>
</td>
</tr>
<tr>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>f</p>
</td>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>U</p>
</td>
</tr>
<tr>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>f</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Replace all characters in the blast area with a space:</p>
<table>
<tbody>
<tr>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
</tr>
<tr>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>f</p>
</td>
</tr>
<tr>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>U</p>
</td>
</tr>
<tr>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>All characters start falling down until they land on other characters:</p>
<table>
<tbody>
<tr>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
</tr>
<tr>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>f</p>
</td>
</tr>
<tr>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>U</p>
</td>
</tr>
<tr>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>The resulting matrix is:</p>
<table>
<tbody>
<tr>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>t</p>
</td>
</tr>
<tr>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>f</p>
</td>
</tr>
<tr>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>S</p>
</td>
<td width="19">
<p>i</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>U</p>
</td>
</tr>
<tr>
<td width="19">
<p>n</p>
</td>
<td width="19">
<p>U</p>
</td>
<td width="19">
<p>t</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="19">
<p>o</p>
</td>
<td width="19">
<p>S</p>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>Problem 17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lego Blocks</h2>
<p>You are given two <strong>jagged arrays</strong>. Each array represents a <strong>Lego block </strong>containing integers. Your task is first to <strong>reverse</strong> the second jagged array and then check if it would <strong>fit perfectly</strong> in the first jagged array.</p>
<p>The picture above shows exactly what fitting arrays mean. If the arrays fit perfectly you should <strong>print out</strong> the newly made rectangular matrix. If the arrays do not match (they do not form a rectangular matrix) you should print out the <strong>number of cells</strong> in the first array and in the second array combined. The examples below should help you understand more the assignment.</p>
<h3>Input</h3>
<p>The first line of the input comes as an <strong>integer</strong> <strong>number n </strong>saying how many rows are there in both arrays. Then you have <strong>2 * n</strong> lines of numbers separated by whitespace(s). The first <strong>n </strong>lines are the rows of the first jagged array; the next <strong>n </strong>lines are the rows of the second jagged array. There might be leading and/or trailing whitespace(s).</p>
<h3>Output</h3>
<p>You should print out the combined matrix in the format:<br /> <strong>[<em>elem, elem, &hellip;, elem</em>]<br /> [<em>elem, elem, &hellip;, elem</em>]<br /> [<em>elem, elem, &hellip;, elem</em>]</strong><strong><br /> </strong>If the two arrays do not fit you should print out : <strong>The total number of cells is: <em>count</em></strong></p>
<h3>Constraints</h3>
<ul>
<li>The number n will be in the range [2&hellip;10].</li>
</ul>
<ul>
<li>Time limit: 0.3 sec. Memory limit: 16</li>
</ul>
<h3>Examples</h3>
<table width="690">
<tbody>
<tr>
<td width="501">
<p><strong>Input</strong></p>
</td>
<td width="189">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="501">
<p>2</p>
<p>1 1 1 1 1 1</p>
<p>2 1 1 3</p>
<p>1 1</p>
<p>2 2 2 3</p>
</td>
<td width="189">
<p>[1, 1, 1, 1, 1, 1, 1, 1]</p>
<p>[2, 1, 1, 3, 3, 2, 2, 2]</p>
</td>
</tr>
<tr>
<td width="501">
<p>2</p>
<p>1 1 1 1 1</p>
<p>1 1 1</p>
<p>1</p>
<p>1 1 1 1 1</p>
</td>
<td width="189">
<p>The total number of cells is: 14</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Radioactive Mutant Vampire Bunnies</h2>
<p>Browsing through GitHub, you come across an old JS Basics teamwork game. It is about very nasty bunnies that multiply extremely fast. There&rsquo;s also a player that has to escape from their lair. You really like the game so you decide to port it to C# because that&rsquo;s your language of choice. The last thing that is left is the algorithm that decides if the player will escape the lair or not.</p>
<p>The <strong>bunnies</strong> are marked with <strong>B,</strong> the <strong>player</strong> is marked with P, and <strong>everything</strong> else is free space, marked with a dot (.) First, you will receive a line holding integers <strong>N</strong> and <strong>M</strong>, which represent the rows and columns in the lair. Then you receive <strong>N</strong> strings that can <strong>only</strong> consist of dots (.), bunnies (B), and the player (P). They represent the initial state of the lair. There will be <strong>only </strong>one player. Then you will receive a string with <strong>commands</strong> such as <strong>LLRRUUDD</strong> &ndash; where each letter represents the next <strong>step</strong> of the player (Left, Right, Up, Down).</p>
<p><strong>After</strong> each step of the player, the bunnies spread to the up, down, left and right (neighboring cells marked as &ldquo;.&rdquo; <strong>change</strong> their value to B). If the player <strong>moves</strong> to a bunny cell or a bunny <strong>reaches</strong> the player, the player has died. If the player goes <strong>out</strong> of the lair <strong>without</strong> encountering a bunny, the player has won.</p>
<p>If the player <strong>dies</strong> or <strong>wins</strong>, the game ends. All the activities for <strong>this</strong> turn continue (e.g. all the bunnies spread normally), but there are no more turns. There will be <strong>no</strong> stalemates where the moves of the player end before he dies or escapes.</p>
<p>Print the final state of the lair with every row on a separate line. On the last line, print either <strong>&ldquo;dead: {row} {col}&rdquo;</strong> or <strong>&ldquo;won: {row} {col}&rdquo;</strong>. Row and col are the coordinates of the cell where the player has died or the last cell he has been in before escaping the lair.</p>
<h3>Input</h3>
<ul>
<li>On the first line of input, the number N and M are received &ndash; the number of rows and columns in the lair</li>
<li>On the next N lines, each row is received in the form of a string. The string will contain only &ldquo;.&rdquo;, &ldquo;B&rdquo;, &ldquo;P&rdquo;. All strings will be the same length. There will be only one &ldquo;P&rdquo; for all the input</li>
<li>On the last line, the directions are received in the form of a string, containing &ldquo;R&rdquo;, &ldquo;L&rdquo;, &ldquo;U&rdquo;, &ldquo;D&rdquo;</li>
</ul>
<h3>Output</h3>
<ul>
<li>On the first N lines, print the final state of the bunny lair</li>
<li>On the last line, print the outcome &ndash; &ldquo;won:&rdquo; or &ldquo;dead:&rdquo; + {row} {col}</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The dimensions of the lair are in range [3&hellip;20]</li>
<li>The directions string length is in range [1..20]</li>
</ul>
<h3>Examples</h3>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>5 8</p>
<p>.......B</p>
<p>...B....</p>
<p>....B..B</p>
<p>........</p>
<p>..P.....</p>
<p>ULLL</p>
</td>
<td width="372">
<p>BBBBBBBB</p>
<p>BBBBBBBB</p>
<p>BBBBBBBB</p>
<p>.BBBBBBB</p>
<p>..BBBBBB</p>
<p>won: 3 0</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>4 5</p>
<p>.....</p>
<p>.....</p>
<p>.B...</p>
<p>...P.</p>
<p>LLLLLLLL</p>
</td>
<td width="372">
<p>.B...</p>
<p>BBB..</p>
<p>BBBB.</p>
<p>BBB..</p>
<p>dead: 3 1</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Crossfire</h2>
<p>You will receive two integers which represent the dimensions of a matrix. Then, you must fill the matrix with increasing integers starting from 1, and continuing on every row, like this:<br /> first row: 1, 2, 3&hellip; n<br /> second row: n+1, n+2, n+3&hellip; n + n.</p>
<p>You will also receive several commands in the form of 3 integers separated by a space. Those 3 integers will represent a row in the matrix, a column and a radius. You must then <strong>destroy</strong> the cells which correspond to those arguments <strong>cross-like.</strong></p>
<p><strong>Destroying</strong> a cell means that, <strong>that</strong> cell becomes completely<strong> nonexistent</strong> in the matrix. Destroying cells <strong>cross-like</strong> means that you form a <strong>cross figure</strong>, with center point - equal to the cell with coordinates &ndash; the <strong>given row</strong> and <strong>column</strong>, and <strong>lines </strong>with length equal to the <strong>given radius</strong>. See the examples for more info.</p>
<p>The input ends when you receive the command &ldquo;Nuke it from orbit&rdquo;. When that happens, you must print what has remained from the initial matrix.</p>
<p>&nbsp;</p>
<h3>Input</h3>
<ul>
<li>On the first line you will receive the dimensions of the matrix. You must then fill the matrix according to those dimensions.</li>
<li>On the next several lines you will begin receiving 3 integers separated by a single <strong>space</strong>, which represent the row, col and radius. You must then destroy cells according to those coordinates.</li>
<li>When you receive the command &ldquo;Nuke it from orbit&rdquo; the input ends.</li>
</ul>
<p>&nbsp;</p>
<h3>Output</h3>
<ul>
<li>The output is simple. You must print what is left from the matrix.</li>
<li>Every row must be printed on a new line and every column of a row - separated by a space.</li>
</ul>
<p>&nbsp;</p>
<h3>Constraints</h3>
<ul>
<li>The dimensions of the matrix will be integers in the range [2, 100].</li>
<li>The given rows and columns will be valid integers in the range [-2<sup>31 </sup>+ 1, 2<sup>31</sup> - 1].</li>
<li>The radius will be in range [0, 2<sup>31</sup> - 1].</li>
<li>Allowed time/memory: 250ms/16MB.</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<p>&nbsp;</p>
<table width="604">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="104">
<p><strong>Output</strong></p>
</td>
<td width="302">
<p><strong>Comment</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>5 5</p>
<p>3 3 2</p>
<p>4 3 2</p>
<p>Nuke it from orbit</p>
</td>
<td width="104">
<p>1 2 3 4 5</p>
<p>6 7 8 10</p>
<p>11 12 13</p>
<p>16</p>
<p>21</p>
</td>
<td width="302">
<p>Initial matrix:</p>
<p>1&nbsp; 2&nbsp; 3&nbsp; 4&nbsp; 5</p>
<p>6&nbsp; 7&nbsp; 8&nbsp; 9&nbsp; 10</p>
<p>11 12 13 14 15</p>
<p>16 17 18 19 20</p>
<p>21 22 23 24 25</p>
<p>Result from first destruction:</p>
<p>1&nbsp; 2&nbsp; 3&nbsp; 4&nbsp; 5</p>
<p>6&nbsp; 7&nbsp; 8&nbsp; 10</p>
<p>11 12 13 15</p>
<p>16&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>21 22 23 25</p>
<p>Result from second destruction:</p>
<p>1&nbsp; 2&nbsp; 3&nbsp; 4&nbsp; 5</p>
<p>6&nbsp; 7&nbsp; 8&nbsp; 10</p>
<p>11 12 13</p>
<p>16</p>
<p>21</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="604">
<tbody>
<tr>
<td width="301">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="301">
<p>5 5</p>
<p>4 4 4</p>
<p>Nuke it from orbit</p>
</td>
<td width="302">
<p>1 2 3 4</p>
<p>6 7 8 9</p>
<p>11 12 13 14</p>
<p>16 17 18 19</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>Problem 20.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * The Heigan Dance</h2>
<p>At last, level 80. And what do level eighties do? Go raiding. This is where you are now &ndash; trying not to be wiped by the famous dance boss, Heigan the Unclean. The fight is pretty straightforward - dance around the Plague Clouds and Eruptions, and you&rsquo;ll be just fine.</p>
<p>Heigan&rsquo;s chamber is a 15-by-15 two-dimensional array. The player always starts at the <strong>exact center. </strong>For each turn, Heigan uses a spell that hits a certain cell and the neighboring <strong>rows/columns</strong>. For example, if he hits (1,1), he also hits (0,0, 0,1, 0,2, 1,0 &hellip; 2,2). If the player&rsquo;s current position is within the area of damage, the player tries to move. First he tries to move <strong>up</strong>, if there&rsquo;s <strong>damage/wall</strong>, he tries to move <strong>right</strong>, then <strong>down</strong>, then <strong>left</strong>. If he <strong>cannot move</strong> in any direction, because<strong> the cell is damaged </strong>or there is<strong> a wall</strong>, the player <strong>stays</strong> in place and takes the damage.</p>
<p><strong>Plague cloud</strong> does 3500 damage <strong>when it hits</strong>, and 3500 damage <strong>the next turn</strong>. Then it <strong>expires. Eruption</strong> does 6000 damage <strong>when it hits. </strong>If a spell will hit a player that also has an active Plague Cloud from the previous turn, the <strong>cloud</strong> damage is applied <strong>first</strong>. <strong>Both</strong> Heigan and the player <strong>may</strong> die in the same turn. If Heigan is <strong>dead</strong>, the spell he <strong>would</strong> have casted is <strong>ignored</strong>.</p>
<p>The player always starts at <strong>18500</strong> hit points; Heigan starts at <strong>3,000,000</strong> hit points. <strong>Each</strong> turn, the player does damage to Heigan. The fight is over either when the player is <strong>killed</strong>, or Heigan is <strong>defeated</strong>.</p>
<h3>Input</h3>
<ul>
<li>On the first line you receive a floating-point number <strong>D &ndash; </strong>the damage done to Heigan each turn</li>
<li>On the next several lines &ndash; you receive input in format <strong>{spell} {row} {col}</strong> &ndash; <strong>{spell}</strong> is either <strong>Plague</strong> or <strong>Eruption</strong></li>
</ul>
<h3>Output</h3>
<ul>
<li>On the first line &nbsp;
<ul>
<li>If Heigan is defeated: &ldquo;<strong>Heigan:</strong> <strong>Defeated!</strong>&rdquo;</li>
<li>Else: &ldquo;<strong>Heigan: {remaining</strong>}&rdquo;, where remaining is rounded to two digits after the decimal separator</li>
</ul>
</li>
<li>On the second line:
<ul>
<li>If the player is killed: &ldquo;<strong>Player:</strong> <strong>Killed by {spell}</strong>&rdquo;</li>
<li>Else &ldquo;<strong>Player: {remaining}&rdquo;</strong></li>
</ul>
</li>
<li>On the third line: &ldquo;<strong>Final position: {row, col}</strong>&rdquo; -&gt; the last coordinates of the player.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>D </strong>is a floating-point number in range [0 &hellip; 500000]</li>
<li>A damaging spell will always affect at least one cell</li>
<li>Allowed memory: 16 MB</li>
<li>Allowed working time: 0.25s</li>
</ul>
<h3>Examples</h3>
<table width="598">
<tbody>
<tr>
<td width="299">
<p><strong>Input</strong></p>
</td>
<td width="299">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="299">
<p>10000</p>
<p>Cloud 7 7</p>
<p>Eruption 6 7</p>
<p>Eruption 8 7</p>
<p>Eruption 8 7</p>
</td>
<td width="299">
<p>Heigan: 2960000.00</p>
<p>Player: Killed by Eruption</p>
<p>Final position: 8, 7</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="598">
<tbody>
<tr>
<td width="299">
<p><strong>Input</strong></p>
</td>
<td width="299">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="299">
<p>500000</p>
<p>Cloud 7 6</p>
<p>Eruption 7 8</p>
<p>Eruption 7 7</p>
<p>Cloud 7 8</p>
<p>Eruption 7 9</p>
<p>Eruption 6 14</p>
<p>Eruption 7 11</p>
</td>
<td width="299">
<p>Heigan: Defeated!</p>
<p>Player: 12500</p>
<p>Final position: 7, 11</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="598">
<tbody>
<tr>
<td width="299">
<p><strong>Input</strong></p>
</td>
<td width="299">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="299">
<p>12500.66</p>
<p>Cloud 7 7</p>
<p>Cloud 7 7</p>
<p>Cloud 7 7</p>
<p>Cloud 7 7</p>
</td>
<td width="299">
<p>Heigan: 2949997.36</p>
<p>Player: Killed by Plague Cloud</p>
<p>Final position: 7, 7</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>Problem 21.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Parking System</h2>
<p>The parking lot in front of SoftUni is one of the busiest in the country, and it&rsquo;s a common cause for conflicts between the doorkeeper Bai Tzetzo and the students. The SoftUni team wants to proactively resolve all conflicts, so an automated parking system should be implemented. They are organizing a competition &ndash; Parkoniada &ndash; and the author of the best parking system will win a romantic dinner with RoYaL. That&rsquo;s <strong>exactly</strong> what you&rsquo;ve been dreaming of, so you decide to join in.</p>
<p>The parking lot is a <strong>rectangular</strong> matrix where the <strong>first</strong> column is <strong>always</strong> free and all other cells are parking spots. A car can enter from any cell of the first column and then decides to go to a specific spot. If that spot is <strong>not </strong>free, the car searches for the <strong>closest </strong>free spot on the <strong>same </strong>row. If <strong>all</strong> the cells on that specific row are used, the car cannot park and leaves. If <strong>two</strong> free cells are located at the <strong>same</strong> distance from the <strong>initial</strong> parking spot, the cell which is <strong>closer</strong> to the entrance is preferred. A car can <strong>pass </strong>through a used parking spot.</p>
<p>Your task is to calculate the distance travelled by each car to its parking spot.</p>
<p>A car enters the parking at row 1. It wants to go to cell 2, 2 so it moves through <strong>exactly four</strong> cells to reach its parking spot.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Input</h3>
<ul>
<li>On the first line of input, you are given the integers <strong>R</strong> and <strong>C</strong>, defining the dimensions of the parking lot.</li>
<li>On the next several lines, you are given the integers <strong>Z, X,</strong> <strong>Y</strong> where <strong>Z</strong> is the entry row and <strong>X, Y</strong> are the coordinates of the desired parking spot.</li>
<li>The input stops with the command &lsquo;<strong>stop</strong>&rsquo;. All integers are separated by a <strong>single</strong></li>
</ul>
<h3>Output</h3>
<ul>
<li>For each car, print the distance travelled to the desired spot or the first free spot.</li>
<li>If a car cannot park on its desired row, print the message &lsquo;<strong>Row {row number} full</strong>&rsquo;</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>2 &le; R,C &le; 10000</li>
<li>Z, X, Y are inside the dimensions of the matrix. Y is never on the first column.</li>
<li>There are no more than 1000 input lines</li>
<li>Allowed time/space: 0.1s (C#) 0.25s (Java)/16MB</li>
</ul>
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
<p>4 4</p>
<p>1 2 2</p>
<p>2 2 2</p>
<p>2 2 2</p>
<p>3 2 2</p>
<p>stop</p>
</td>
<td width="294">
<p>4</p>
<p>2</p>
<p>4</p>
<p>Row 2 full</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>