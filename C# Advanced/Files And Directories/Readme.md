<h1>Exercises: Files And Directories</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016">"CSharp Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Odd Lines</h2>
<p>Write a program that reads a text file and writes its every <strong>odd </strong>line in another file. Line numbers starts from 0.</p>
<h3>Examples</h3>
<table width="709">
<tbody>
<tr>
<td width="350">
<p><strong>Input.txt</strong></p>
</td>
<td width="359">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="350">
<p>Two households, both alike in dignity,<br /> In fair Verona, where we lay our scene,<br /> From ancient grudge break to new mutiny,<br /> Where civil blood makes civil hands unclean.<br /> From forth the fatal loins of these two foes<br /> A pair of star-cross'd lovers take their life;<br /> Whose misadventured piteous overthrows<br /> Do with their death bury their parents' strife.</p>
</td>
<td width="359">
<p>In fair Verona, where we lay our scene,</p>
<p>Where civil blood makes civil hands unclean.</p>
<p>A pair of star-cross&rsquo;d lovers take their life;</p>
<p>Do with their death bury their parents&rsquo; strife</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>Read <strong>01_OddLinesIn.txt </strong>and test your output against <strong>01_OddLinesOut.txt</strong>, then read <strong>02_OddLinesIn.txt </strong>and test against its respective output file and so on.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Line Numbers</h2>
<p>Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.</p>
<h3>Examples</h3>
<table width="709">
<tbody>
<tr>
<td width="350">
<p><strong>Input.txt</strong></p>
</td>
<td width="359">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="350">
<p>Two households, both alike in dignity,<br /> In fair Verona, where we lay our scene,<br /> From ancient grudge break to new mutiny,<br /> Where civil blood makes civil hands unclean.<br /> From forth the fatal loins of these two foes<br /> A pair of star-cross'd lovers take their life;<br /> Whose misadventured piteous overthrows<br /> Do with their death bury their parents' strife.</p>
</td>
<td width="359">
<p>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Two households, both alike in dignity,</p>
<p>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; In fair Verona, where we lay our scene,</p>
<p>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; From ancient grudge break to new mutiny,</p>
<p>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Where civil blood makes civil hands unclean.</p>
<p>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; From forth the fatal loins of these two foes</p>
<p>6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A pair of star-cross'd lovers take their life;</p>
<p>7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Whose misadventured piteous overthrows</p>
<p>8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Do with their death bury their parents' strife.</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>Read from <strong>01_LinesIn.txt </strong>and compare your output against <strong>01_LinesOut.txt</strong>, then read <strong>02_LinesIn.txt</strong> and compare to its respctive output file and so on.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Word Count</h2>
<p>Write a program that reads a list of words from the file <strong>words.txt</strong> and finds how many times each of the words is contained in another file <strong>text.txt</strong>. Matching should be <strong>case-insensitive</strong>.</p>
<p>Write the results in file <strong>results.txt</strong>. Sort the words by frequency in descending order.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>words.txt</strong></p>
</td>
<td width="258">
<p><strong>Input.txt</strong></p>
</td>
<td width="96">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>quick is fault</p>
<p>&nbsp;</p>
</td>
<td width="258">
<p>-I was quick to judge him, but it wasn't his fault.</p>
<p>-Is this some kind of joke?! Is it?</p>
<p>-Quick, hide here&hellip;It is safer.</p>
</td>
<td width="96">
<p>is - 3</p>
<p>quick - 2</p>
<p>fault - 1</p>
</td>
</tr>
</tbody>
</table>
<p>First read the <strong>words1.txt </strong>in order to retrieve the words you will be looking for, then read <strong>text1.txt </strong>to retrieve the text in which you will be searching for the words. Finally test your output against <strong>01_WordCount.txt</strong>. Then read <strong>words2.txt </strong>and so on</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Merging two files into third one</h2>
<p>Write a program that reads the contents of two text files and merges them together into a third one.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>Input1.txt</strong></p>
</td>
<td width="258">
<p><strong>Input2.txt</strong></p>
</td>
<td width="96">
<p><strong>Output.txt</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>1</p>
<p>3</p>
<p>5</p>
<p>&nbsp;</p>
</td>
<td width="258">
<p>2</p>
<p>4</p>
<p>6</p>
</td>
<td width="96">
<p>1</p>
<p>2</p>
<p>3</p>
<p>4</p>
<p>5</p>
<p>6</p>
</td>
</tr>
</tbody>
</table>
<p>First read <strong>01_FileOne.txt </strong>and <strong>01_FileTwo.txt</strong>, merge them and compare your output against <strong>01_Merged</strong>. Then read <strong>02_FileOne.txt </strong>and <strong>02_FileTwo.txt </strong>and compare it to <strong>02_Merged</strong>.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Get folder size</h2>
<p>You are given a folder named TestFolder. Get the size of all files in the folder, which are <strong>NOT directories.</strong> Print the result on the console in <strong>Megabytes</strong>.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>5.161738395690918</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Timer</h2>
<p>Write a program that determines how long does it take to read a file. You are given two files &ndash; &ldquo;File1&rdquo; and &ldquo;File2&rdquo;. Your task is to create a program, which determines the duration of reading them. On the output &ndash; print <strong>true if the first</strong> file is taking <strong>less</strong> time or <strong>print false if the second</strong> one does.</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Read from specified line</h2>
<p>Write a program that reads from the console an integer, which specifies the starting line from which you should start reading from. Print on the console the remaining text.</p>
<p>&nbsp;</p>