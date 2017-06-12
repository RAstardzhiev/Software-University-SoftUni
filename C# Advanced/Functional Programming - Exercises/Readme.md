<h1>Exercises: Functional Programming</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016">"CSharp Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Action Print</h2>
<p>Write a program that reads a collection of strings from the console and then prints them onto the console. Each name should be printed on a new line. Use <strong>Action&lt;T&gt;</strong>.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>Pesho Gosho Adasha</p>
</td>
<td width="270">
<p>Pesho</p>
<p>Gosho</p>
<p>Adasha</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Knights of Honor</h2>
<p>Write a program that reads a collection of names as strings from the console then appends &ldquo;Sir&rdquo; in front of every name and prints it back onto the console. Use <strong>Action&lt;T&gt;</strong>.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>Pesho Gosho Adasha StanleyRoyce</p>
</td>
<td width="270">
<p>Sir Pesho</p>
<p>Sir Gosho</p>
<p>Sir Adasha</p>
<p>Sir StanleyRoyce</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Custom Min Function</h2>
<p>Write a simple program that reads from the console a set of numbers and prints back onto the console the smallest number from the collection. Use <strong>Func&lt;T, T&gt;</strong>.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>1 4 3 2 1 7 13</p>
</td>
<td width="270">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Find Evens or Odds</h2>
<p>You are given a lower and an upper bound for a range of integer numbers. Then a command specifies if you need to list all even or odd numbers in the given range. Use <strong>Predicate&lt;T&gt;</strong>.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>1 10</p>
<p>odd</p>
</td>
<td width="270">
<p>1 3 5 7 9</p>
</td>
</tr>
<tr>
<td width="256">
<p>20 30</p>
<p>even</p>
</td>
<td width="270">
<p>20 22 24 26 28 30</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Applied Arithmetics</h2>
<p>Write a program that executes some mathematical operations on a given collection. On the first line you are given a list of numbers. On the next lines you are passed different commands that you need to apply to all numbers in the list: "add" -&gt; add 1 to each number; "multiply" -&gt; multiply each number by 2; "subtract" -&gt; subtract 1 from each number; &ldquo;print&rdquo; -&gt; print the collection. The input will end with and "end" command, after which you need to print the result. Use functions.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>1 2 3 4 5</p>
<p>add</p>
<p>add</p>
<p>print</p>
<p>end</p>
</td>
<td width="270">
<p>3 4 5 6 7</p>
</td>
</tr>
<tr>
<td width="256">
<p>5 10</p>
<p>multiply</p>
<p>subtract</p>
<p>print</p>
<p>end</p>
</td>
<td width="270">
<p>9 19</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reverse and exclude</h2>
<p>Write a program that reverses a collection and removes elements that are divisible by a given integer <strong>n</strong>. Use predicates/functions.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>1 2 3 4 5 6</p>
<p>2</p>
</td>
<td width="270">
<p>5 3 1</p>
</td>
</tr>
<tr>
<td width="256">
<p>20 10 40 30 60 50</p>
<p>3</p>
</td>
<td width="270">
<p>50 40 10 20</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Predicate for names</h2>
<p>Write a program that filters a list of names according to their length. On the first line you will be given integer <strong>n</strong> representing name length. On the second line you will be given some names as strings separated by space. Write a function that prints only the names whose length is <strong>less than or equal</strong> to <strong>n</strong>.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>4</p>
<p>Kurnelia Qnaki Geo Muk Ivan</p>
</td>
<td width="270">
<p>Geo</p>
<p>Muk</p>
<p>Ivan</p>
</td>
</tr>
<tr>
<td width="256">
<p>4</p>
<p>Karaman Asen Kiril Yordan</p>
</td>
<td width="270">
<p>Asen</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Custom Comparator</h2>
<p>Write a custom comparator that sorts all even numbers before all odd ones in ascending order. Pass it to an Array.sort() function and print the result.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>1 2 3 4 5 6</p>
</td>
<td width="270">
<p>2 4 6 1 3 5</p>
</td>
</tr>
<tr>
<td width="256">
<p>-3 2</p>
</td>
<td width="270">
<p>2 -3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; List of Predicates</h2>
<p>Find all numbers in the range 1..N that are divisible by the numbers of a given sequence. Use predicates/functions.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>10</p>
<p>1 1 1 2</p>
</td>
<td width="270">
<p>0 2 4 6 8 10</p>
</td>
</tr>
<tr>
<td width="256">
<p>100</p>
<p>2 5 10 20</p>
</td>
<td width="270">
<p>0 20 40 60 80 100</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 10. Predicate Party!</h2>
<p>Ivancho&rsquo;s parents are on a vacation for the holidays and he is planning an epic party at home. Unfortunately, his organizational skills are next to non-existent so you are given the task to help him with the reservations.</p>
<p>On the first line you get a list with all the people that are coming. On the next lines, until you get the "Party!" command, you may be asked to double or remove all the people that apply to given criteria. There are three different criteria are: 1. everyone that has a name starting with a given string; 2. everyone that has a name ending with a given string; 3. everyone that has a name with a given length. See the examples below:</p>
<h3>Examples</h3>
<table width="600">
<tbody>
<tr>
<td width="257">
<p>&nbsp;<strong>Input</strong></p>
</td>
<td width="343">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="257">
<p>Pesho Misho Stefan</p>
<p>Remove StartsWith P</p>
<p>Double Length 5</p>
<p>Party!</p>
</td>
<td width="343">
<p>Misho, Misho, Stefan are going to the party!</p>
</td>
</tr>
<tr>
<td width="257">
<p>Pesho</p>
<p>Double StartsWith Pesh</p>
<p>Double EndsWith esho</p>
<p>Party!</p>
</td>
<td width="343">
<p>Pesho, Pesho, Pesho, Pesho are going to the party!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 11. *Party Reservation Filter Module</h2>
<p>You are a young and talented developer. The first task you need to do is to implement a filtering module to a party reservation software. First, The Party Reservation Filter Module (TPRF Module for short) is passed a list with invitations. Next the TPRF receives a sequence of commands that specify if you need to add or remove a given filter.</p>
<p>TPRF Commands are in the given format <strong>{command;filter type;filter parameter}</strong></p>
<p>You can receive the following TPRF commands: "Add filter", "Remove filter" or "Print". The possible TPRF filter types are: "Starts with", "Ends with", "Length" and "Contains". All TPRF filter parameters will be a string (or an integer for the length filter).</p>
<p>The input will end with a "Print" command after which you should print all the party-goers that are left after the filtration. See the examples below:</p>
<h3>Examples</h3>
<table width="600">
<tbody>
<tr>
<td width="257">
<p><strong>Input</strong></p>
</td>
<td width="343">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="257">
<p>Pesho Misho Slav</p>
<p>Add filter;Starts with;P</p>
<p>Add filter;Starts with;M</p>
<p>Print</p>
</td>
<td width="343">
<p>Slav</p>
</td>
</tr>
<tr>
<td width="257">
<p>Pesho Misho Jica</p>
<p>Add filter;Starts with;P</p>
<p>Add filter;Starts with;M</p>
<p>Remove filter;Starts with;M</p>
<p>Print</p>
</td>
<td width="343">
<p>Misho Jica</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 12. *Inferno III</h2>
<p>Your game studio&rsquo;s next triple A big-budget-killer app is the Hack and Slash Action RPG Inferno III. The main purpose of the game is well, to hack and slash things. But the secondary purpose is to craft items and recently the main fan base has started complaining that once you craft an item you can&rsquo;t change it. So your next job is to implement a feature for one time reforging an item.</p>
<p>On the first line you are given the gems already inserted in the form of numbers, representing their power. On the next lines, until you receive the "Forge" command, you can receive commands in the following format <strong>{command;filter type;filter parameter}</strong>:</p>
<p>Commands can be: "Exclude", "Reverse" or "Forge". The possible filter types are: "Sum Left", "Sum Right" and "Sum Left Right". All filter parameters will be an integer.</p>
<p>"Exclude" marks a gem for exclusion from the set if it meets a given condition. "Reverse" deletes a previous exclusion.</p>
<p>"Sum Left" tests if a gems power summed with the gem standing to its right gives a certain value. "Sum Right" is the same but looks to a gems right peer. "Sum Left Right" sums the gems power with both its left and right neighbors. If a gem has no neighbor to its right or to its left (first or last element), then simply add 0 to the gem.</p>
<p>Note that changes on to the item are made only after forging. This means that the gems are fixed at their positions and every function occurs on the original set, so every gems power is considered, no matter if it is marked or not.</p>
<p>To better understand the problem, see the examples below:</p>
<h3>Examples</h3>
<table width="624">
<tbody>
<tr>
<td width="210">
<p><strong>Input</strong></p>
</td>
<td width="204">
<p><strong>Output</strong></p>
</td>
<td width="210">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="210">
<p>1 2 3 4 5</p>
<p>Exclude;Sum Left;1</p>
<p>Exclude;Sum Left Right;9</p>
<p>Forge</p>
</td>
<td width="204">
<p>2 4</p>
</td>
<td width="210">
<p>1. Marks for exclusion all gems for which the sum with neighbors to their left equals 1, e.g. 0 + <strong>1</strong> = 1</p>
<p>&nbsp;</p>
<p>2. Marks for exclusion all gems for which the sum with neighbors to their left and their right equals 9, e.g.</p>
<p>2 + <strong>3</strong> + 4 = 9</p>
<p>4 + <strong>5</strong> + 0 = 9</p>
</td>
</tr>
<tr>
<td width="210">
<p>1 2 3 4 5</p>
<p>Exclude;Sum Left;1</p>
<p>Reverse;Sum Left;1</p>
<p>Forge</p>
</td>
<td width="204">
<p>1 2 3 4 5</p>
</td>
<td width="210">
<p>1. Marks for exclusion all gems for which the sum with their gem peers to the left equals 1, e.g. 0 + 1 = 1</p>
<p>&nbsp;</p>
<p>2. Reverses the previous exclusion.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 13. **TriFunction</h2>
<p>Write a program that traverses a collection of names and returns the first name whose sum of characters is equal to or larger than a given number <strong>n</strong>. Use a function that accepts another function as one of its parameters. Start off by building a regular function to hold the basic logic of the program something along the lines of <strong>Func&lt;string, int, bool&gt;</strong>. Afterwards create your main function which should accept the first function as one of its parameters.</p>
<h3>Examples</h3>
<table width="526">
<tbody>
<tr>
<td width="256">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="256">
<p>800</p>
<p>Qvor Qnaki Petromir Sadam</p>
</td>
<td width="270">
<p>Petromir</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>