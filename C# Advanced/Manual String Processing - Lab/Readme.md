<h1>Lab: Manual String Processing</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/trainings/1633/csharp-advanced-may-2017">&ldquo;C# Advanced&rdquo; course @ SoftUni".</a></p>
<p>Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/595/Manual-String-Processing-Lab">https://judge.softuni.bg/Contests/595/Manual-String-Processing-Lab</a>.</p>
<h2>1.&nbsp;&nbsp; Students Results</h2>
<p>Write a program that reads number <strong>N</strong> from the console. After that read <strong>N</strong> lines with students with their results in format <strong>{name} - {firstResult}, {secondResult}, {thirdResult}</strong></p>
<p>Print <strong>table</strong> on console. Each row must contain:</p>
<ul>
<li><strong>CAdv</strong> - first result, align right with <strong>precision of 2</strong></li>
<li><strong>COOP</strong> - second result, align right with <strong>precision of 2</strong></li>
<li><strong>AdvOOP</strong> - third result, align right with <strong>precision of 2</strong></li>
<li><strong>Average</strong> &ndash; average result with <strong>precision of 4</strong></li>
<li>Columns must be <strong>separated</strong> with <strong>"|"</strong></li>
<li>Don't forget <strong>heading row</strong></li>
</ul>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="254">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="254">
<p>1</p>
<p>Gosho - 3.33333, 4.4444, 5.555</p>
</td>
<td width="378">
<p>Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp; CAdv|&nbsp;&nbsp; COOP| AdvOOP|Average|</p>
<p>Gosho&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp; 3,33|&nbsp;&nbsp; 4,44|&nbsp;&nbsp; 5,56| 4,4442|</p>
</td>
</tr>
<tr>
<td width="254">
<p>2</p>
<p>Mara - 5, 4, 3</p>
<p>Gosho - 3, 4, 5</p>
</td>
<td width="378">
<p>Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp; CAdv|&nbsp;&nbsp; COOP| AdvOOP|Average|</p>
<p>Mara&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp; 5,00|&nbsp;&nbsp; 4,00|&nbsp;&nbsp; 3,00| 4,0000|</p>
<p>Gosho&nbsp;&nbsp;&nbsp;&nbsp; |&nbsp;&nbsp; 3,00|&nbsp;&nbsp; 4,00|&nbsp;&nbsp; 5,00| 4,0000|</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>It is up to you what type of data structures you will use to solve this problem</p>
<p>First row is <strong>easy</strong>, but long.</p>
<p>Data rows are something terrible:</p>
<h2>2.&nbsp;&nbsp; Parse URLs</h2>
<p>Write a program that parses an URL address given in the format: <strong>[protocol]://[server]/[resource]</strong> and extracts from it the <strong>[protocol]</strong>, <strong>[server]</strong> and <strong>[resource]</strong> elements.</p>
<p>URL is invalid if:</p>
<ul>
<li>The protocol separator (<strong>://</strong>) or the resource separator is missing (<strong>/</strong>)</li>
<li>Contains second time the protocol separator <strong>://</strong></li>
</ul>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="342">
<p><strong>Input</strong></p>
</td>
<td width="346">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="342">
<p><a href="https://softuni.bg/courses/csharp-advanced">https://softuni.bg/courses/csharp-advanced</a></p>
</td>
<td width="346">
<p>Protocol = https</p>
<p>Server = softuni.bg</p>
<p>Resources = courses/csharp-advance</p>
</td>
</tr>
<tr>
<td width="342">
<p>https://www.google.bg/search?q=google&amp;oq=goo&amp;aqs=chrome.0.0j69i60l2://j0j69i57j69i65.2112j0j7&amp;sourceid=chrome&amp;ie=UTF-8</p>
</td>
<td width="346">
<p>Invalid URL</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>In URL standard you can read that <strong>"://"</strong> is used to show where protocol name end. If you have this second time <strong>"://", </strong>it will be <strong>invalid</strong> URL</p>
<p>Server name ends with <strong>"/"</strong>, but it is <strong>not</strong> part of <strong>resourses</strong>.</p>
<p>Resources use same symbol <strong>"/"</strong> to show when we go deeper in <strong>folders tree</strong>, so be careful.</p>
<p>Think for proper operations over input:</p>
<ul>
<li>.Split()</li>
<li>.Substring()</li>
<li>.IndexOf()</li>
</ul>
<h2>3.&nbsp;&nbsp; Parse Tags</h2>
<p>You are given a text. Write a program that changes the text in all regions surrounded by the tags &lt;<strong>upcase</strong>&gt; and &lt;/<strong>upcase</strong>&gt; to upper-case.</p>
<p>The tags cannot be nested.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="295">
<p><strong>Input</strong></p>
</td>
<td width="393">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="295">
<p>We are living in a &lt;upcase&gt;yellow submarine&lt;/upcase&gt;. We don't have &lt;upcase&gt;anything&lt;/upcase&gt; else.</p>
</td>
<td width="393">
<p>We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.</p>
</td>
</tr>
<tr>
<td width="295">
<p>&lt;upcase&gt;StringBuilder&lt;/upcase&gt; is &lt;upcase&gt;awesome&lt;/upcase&gt;</p>
</td>
<td width="393">
<p>STRINGBUILDER is AWESOME</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Be careful with <strong>replacing</strong> <strong>tags</strong> with <strong>empty</strong> strings.</p>
<p>After replacing tag with empty string, <strong>indexes</strong> in string are <strong>not</strong> the <strong>same</strong>.</p>
<h2>4.&nbsp;&nbsp; Special Words</h2>
<p>Read a string containing a <strong>list of special word</strong>s and a <strong>text</strong> containing some of these words.</p>
<p>Write a program <strong>count special words</strong> in text and <strong>print</strong> their count.</p>
<p>A word separator can be ( ) [ ] &lt; &gt; , - ! ? and space (&lsquo; &rsquo;)</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="408">
<p><strong>Input</strong></p>
</td>
<td width="280">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="408">
<p>.NET Microsoft runs framework</p>
<p>.NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows.</p>
</td>
<td width="280">
<p>.NET &ndash; 1</p>
<p>Microsoft &ndash; 2</p>
<p>runs &ndash; 1</p>
<p>framework - 1</p>
</td>
</tr>
<tr>
<td width="408">
<p>.NET Microsoft run</p>
<p>.NET Framework (pronounced dot net) is a software framework developed by Microsoft that runs primarily on Microsoft Windows.</p>
</td>
<td width="280">
<p>.NET - 1</p>
<p>Microsoft - 2</p>
<p>run - 0</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Concatenate Strings</h2>
<p>Write a program that read number <strong>N</strong> on first line. And on next <strong>N</strong> lines read single words and concatenate them like single line <strong>text</strong> with <strong>" " separator</strong> after each word.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="181">
<p><strong>Input</strong></p>
</td>
<td width="506">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="181">
<p>3</p>
<p>StringBuilder</p>
<p>is</p>
<p>awesome</p>
</td>
<td width="506">
<p>StringBuilder is awesome</p>
</td>
</tr>
<tr>
<td width="181">
<p>92</p>
<p>Lorem</p>
<p>ipsum</p>
<p>dolor</p>
<p>sit</p>
<p>amet,</p>
<p>consectetur</p>
<p>adipiscing</p>
<p>elit.</p>
<p>Curabitur</p>
<p>ac</p>
<p>sagittis</p>
<p>purus.</p>
<p>Praesent</p>
<p>rhoncus</p>
<p>tellus</p>
<p>id</p>
<p>felis</p>
<p>dignissim,</p>
<p>vel</p>
<p>gravida</p>
<p>felis</p>
<p>ultricies.</p>
<p>Nunc</p>
<p>ac</p>
<p>mollis</p>
<p>velit.</p>
<p>Pellentesque</p>
<p>tincidunt</p>
<p>ipsum</p>
<p>lectus,</p>
<p>quis</p>
<p>euismod</p>
<p>velit</p>
<p>elementum</p>
<p>malesuada.</p>
<p>Vestibulum</p>
<p>non</p>
<p>tristique</p>
<p>leo,</p>
<p>non</p>
<p>ullamcorper</p>
<p>nunc.</p>
<p>Ut</p>
<p>et</p>
<p>luctus</p>
<p>augue.</p>
<p>Morbi</p>
<p>efficitur</p>
<p>enim</p>
<p>sed</p>
<p>tristique</p>
<p>accumsan.</p>
<p>Sed</p>
<p>ante</p>
<p>augue,</p>
<p>pharetra</p>
<p>quis</p>
<p>leo</p>
<p>vel,</p>
<p>dapibus</p>
<p>pellentesque</p>
<p>lorem.</p>
<p>Vivamus</p>
<p>tincidunt</p>
<p>mauris</p>
<p>odio,</p>
<p>nec</p>
<p>ullamcorper</p>
<p>ipsum</p>
<p>accumsan</p>
<p>id.</p>
<p>Nulla</p>
<p>facilisi.</p>
<p>Sed</p>
<p>id</p>
<p>scelerisque</p>
<p>nibh,</p>
<p>eu</p>
<p>tempor</p>
<p>metus.</p>
<p>Proin</p>
<p>sit</p>
<p>amet</p>
<p>efficitur</p>
<p>ex,</p>
<p>eget</p>
<p>vestibulum</p>
<p>ipsum.</p>
<p>Quisque</p>
<p>malesuada</p>
<p>consequat</p>
<p>semper.</p>
</td>
<td width="506">
<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur ac sagittis purus. Praesent rhoncus tellus id felis dignissim, vel gravida felis ultricies. Nunc ac mollis velit. Pellentesque tincidunt ipsum lectus, quis euismod velit elementum malesuada. Vestibulum non tristique leo, non ullamcorper nunc. Ut et luctus augue. Morbi efficitur enim sed tristique accumsan. Sed ante augue, pharetra quis leo vel, dapibus pellentesque lorem. Vivamus tincidunt mauris odio, nec ullamcorper ipsum accumsan id. Nulla facilisi. Sed id scelerisque nibh, eu tempor metus. Proin sit amet efficitur ex, eget vestibulum ipsum. Quisque malesuada consequat semper.<br /> </p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Hints</h3>
<p>Here we are not only look for <strong>correct</strong> results, but for <strong>time</strong> too.</p>