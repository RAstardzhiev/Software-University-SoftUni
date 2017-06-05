<h1>Exercise: Streams and Files</h1>
<p>This document defines the homework assignments from the <a href="https://softuni.bg/trainings/1633/csharp-advanced-may-2017">"C# Advanced" Course @ Software University</a>. Please submit as homework a single zip / rar / 7z archive holding the solutions (source code) of all below described problems. The solutions should be written in C#.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Odd Lines</h2>
<p>Write a program that reads a text file and prints on the console its odd lines. Line numbers starts from 0. Use <strong>StreamReader</strong>.</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Line Numbers</h2>
<p>Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file. Use <strong>StreamReader</strong> in combination with <strong>StreamWriter</strong>.</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Word Count</h2>
<p>Write a program that reads a list of words from the file <strong>words.txt</strong> and finds how many times each of the words is contained in another file <strong>text.txt</strong>. Matching should be <strong>case-insensitive</strong>.</p>
<p>Write the results in file <strong>results.txt</strong>. Sort the words by frequency in descending order. Use <strong>StreamReader</strong> in combination with <strong>StreamWriter</strong>.</p>
<table>
<tbody>
<tr>
<td width="114">
<p><strong>words.txt</strong></p>
</td>
<td width="258">
<p><strong>text.txt</strong></p>
</td>
<td width="96">
<p><strong>result.txt</strong></p>
</td>
</tr>
<tr>
<td width="114">
<p>quick</p>
<p>is</p>
<p>fault</p>
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
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Copy Binary File</h2>
<p>Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using <strong>FileStream</strong>. You are <strong>not allowed</strong> to use the <strong>File </strong>class or similar helper classes.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Slicing File</h2>
<p>Write a program that takes any file and slices it to <strong>n</strong> parts. Write the following methods:</p>
<ul>
<li><strong>Slice(string sourceFile, string destinationDirectory, int parts) </strong>- slices the given source file into <strong>n</strong> parts and saves them in <strong>destinationDirectory</strong>.</li>
</ul>
<table>
<tbody>
<tr>
<td width="165">
<p><strong>Source File</strong></p>
</td>
<td width="283">
<p><strong>Destination Directory</strong></p>
</td>
</tr>
<tr>
<td width="165">
<p>parts = 5</p>
</td>
<td width="283">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<ul>
<li><strong>Assemble(List&lt;string&gt; files, string destinationDirectory) </strong>- combines all files into one, in the order they are passed, and saves the result in <strong>destinationDirectory</strong>.</li>
</ul>
<table>
<tbody>
<tr>
<td width="283">
<p><strong>Source Files</strong></p>
</td>
<td width="197">
<p><strong>Destination Directory</strong></p>
</td>
</tr>
<tr>
<td width="283">&nbsp;</td>
<td width="197">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Use <strong>FileStreams</strong>. You are <strong>not allowed</strong> to use the <strong>File</strong> class or similar helper classes.</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Zipping Sliced Files</h2>
<p>Modify your previous program to also <strong>compress</strong> the bytes while slicing parts and <strong>decompress</strong> them when assembling them back to the original file. Use <strong>GzipStream</strong>.</p>
<p><strong>Tip</strong>: When getting files from directory, make sure you only get files with <strong>.gz</strong> extension (there might be hidden files).</p>
<table>
<tbody>
<tr>
<td width="228">
<p><strong>Source File</strong></p>
</td>
<td width="289">
<p><strong>Compressed &amp; Sliced</strong></p>
</td>
<td width="162">
<p><strong>Decompressed &amp; Assembled</strong></p>
</td>
</tr>
<tr>
<td width="228">
<p>parts = 5</p>
</td>
<td width="289">&nbsp;</td>
<td width="162">&nbsp;</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Directory Traversal</h2>
<p>Traverse a given directory for all files with the given extension. Search through the first level of the directory only and write information about each found file in <strong>report.txt</strong>.</p>
<p>The files should be <strong>grouped</strong> by their <strong>extension</strong>. Extensions should be ordered by the<strong> count of their files</strong> (from most to least). If two extensions have equal number of files, order them by <strong>name</strong>.</p>
<p>Files under an extension should be ordered by their <strong>size</strong>.</p>
<p><strong>report.txt</strong> should be saved on the <strong>Desktop</strong>. Ensure the desktop path is always valid, regardless of the user.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="102">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Directory View</strong></p>
</td>
<td width="331">
<p><strong>report.txt</strong></p>
</td>
</tr>
<tr>
<td width="102">
<p>../../</p>
</td>
<td width="246">&nbsp;</td>
<td width="331">
<p>.cs</p>
<p>--Mecanismo.cs - 0.994kb</p>
<p>--Program.cs - 1.108kb</p>
<p>--Nashmat.cs - 3.967kb</p>
<p>--Wedding.cs - 23.787kb</p>
<p>--Program - Copy.cs - 35.679kb</p>
<p>--Salimur.cs - 588.657kb</p>
<p>.txt</p>
<p>--backup.txt - 0.028kb</p>
<p>--log.txt - 6.72kb</p>
<p>.asm</p>
<p>--script.asm - 0.028kb</p>
<p>.config</p>
<p>--App.config - 0.187kb</p>
<p>.csproj</p>
<p>--01. Writing-To-Files.csproj - 2.57kb</p>
<p>.js</p>
<p>--controller.js - 1635.143kb</p>
<p>.php</p>
<p>--model.php - 0kb</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Full Directory Traversal</h2>
<p>Modify your previous program to <strong>recursively traverse</strong> the <strong>sub-directories</strong> of the starting directory as well.</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** HTTP Server</h2>
<p>Create simple HTTP server that should be able to <strong>receive requests</strong> and <strong>return appropriate responses</strong> accordingly to the <strong>request path</strong>. Read more in internet to see what HTTP request and response should look like. Create a web site of 3 pages:</p>
<ul>
<li><strong>1<sup>st</sup></strong> page should be accessible at localhost:{port}/ - (that is the root directory). That page holds just <strong>welcome message</strong> and <strong>link</strong> to the second page</li>
<li><strong>2<sup>nd</sup></strong> page should be accessible at localhost:{port}/info &ndash; that page shows the <strong>current time</strong> and the <strong>count of logical processors</strong> on the machine</li>
<li><strong>3<sup>rd</sup> </strong>page should be an <strong>error page</strong> if the user tries to access any other page return as response the error page.</li>
</ul>
<p>You are provided with some HTML files of the needed pages to make it easier for you.&nbsp; But you are free to modify them and even use your own HTML files.</p>
<h3>Examples</h3>
<p>&nbsp;</p>