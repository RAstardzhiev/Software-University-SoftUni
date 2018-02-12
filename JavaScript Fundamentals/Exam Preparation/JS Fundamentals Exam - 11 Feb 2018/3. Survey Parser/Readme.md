<h1>Problem 3 &ndash; Survey Parser</h1>
<p>Write a JavaScript program that <strong>parses</strong> a given <strong>document</strong> that may contain the results of a <strong>rating survey</strong> and outputs a <strong>summary</strong> of the votes. You will receive a <strong>string</strong> that contains XML-formatted data. From this data, you must extract a <strong>valid label</strong> and <strong>average rating</strong> (sum of ratings, divided by their count). Input, containing valid survey data will follow these rules:</p>
<ul>
<li>The document may contain <strong>any symbol</strong> <strong>before and after</strong> the survey data</li>
<li>The survey data <strong>always</strong> begins with &lt;svg&gt; and ends with &lt;/svg&gt;:</li>
</ul>
<p><em>&nbsp;Any text </em>&lt;svg&gt;<em> Survey data </em>&lt;/svg&gt;<em> Any text&nbsp;</em></p>
<ul>
<li>Each valid survey will contain <strong>exactly two</strong> <strong>sections</strong> beginning with &lt;cat&gt; and ending with &lt;/cat&gt;</li>
<li>There may be <strong>whitespace</strong> <strong>between</strong> the sections</li>
</ul>
<p>&lt;cat&gt;<em> Survey heading and label </em>&lt;/cat&gt;&lt;cat&gt;<em> Ratings </em>&lt;/cat&gt;</p>
<ul>
<li>The contents of the first cat section must begin with &lt;text&gt; and end with &lt;/text&gt;; it may contain <strong>any text</strong>, but needs to have a <strong>valid label</strong>, inside brackets []</li>
</ul>
<p>&lt;text&gt;<em> Survey heading </em>[<em> Survey Label </em>]&lt;/text&gt;</p>
<ul>
<li>The second cat section contains all of the <strong>ratings</strong> with each vote beginning with &lt;g&gt; and ending with &lt;/g&gt;</li>
<li>A <strong>valid rating</strong> contains a <strong>value</strong> and <strong>count</strong>, with the <strong>value</strong> surrounded by &lt;val&gt; and &lt;/val&gt; and the <strong>count</strong> right <strong>after the value</strong></li>
<li>There may be any number of <strong>valid</strong> and <strong>invalid ratings</strong> inside the second cat; you should <strong>only</strong> <strong>process</strong> the valid ones, and <strong>ignore</strong> the invalid ratings</li>
</ul>
<p>&lt;g&gt;&lt;val&gt;<em> Rating value </em>&lt;/val&gt;<em> Vote count </em>&lt;/g&gt;</p>
<ul>
<li><strong>Valid</strong> rating: &lt;g&gt;&lt;val&gt;1&lt;/val&gt;0&lt;/g&gt;</li>
<li><strong>Invalid</strong> rating (<strong>ignore</strong> and continue): &lt;g&gt;&lt;val&gt;Seafood&lt;/val&gt;1&lt;/g&gt;</li>
</ul>
<ul>
<li>The <strong>value</strong> must be a number between <strong>1</strong> and <strong>10</strong></li>
<li>The <strong>count</strong> must be a number <strong>0</strong> or larger</li>
</ul>
<p>If the document <strong>does not</strong> contain survey data (no opening and closing svg tags), print on the console "<strong>No survey found</strong>". If there is survey data, but the rest of the rules aren&rsquo;t followed, print on the console "<strong>Invalid format</strong>".</p>
<p>At the <strong>end</strong> of the program, print on the <strong>console</strong> the <strong>label</strong> of the survey and the <strong>average rating</strong>, <strong>rounded</strong> to two decimal places.</p>
<h3>Input</h3>
<p>You will receive a single <strong>string</strong>, containing a document to be parsed.</p>
<h3>Output</h3>
<p>Depending on outcome, print on the <strong>console </strong><strong>a single line</strong>:</p>
<ul>
<li><strong>No survey found</strong></li>
<li><strong>Invalid format</strong></li>
<li><strong>{label}: {average rating}</strong></li>
</ul>
<p><strong>&nbsp;</strong></p>
<h3>Constraints</h3>
<ul>
<li>There will never be more than one valid survey</li>
<li>Rating <strong>value</strong> will be in range <strong>[1&hellip;10]</strong></li>
<li>Rating <strong>count</strong> will be in range <strong>[1&hellip;1 000&nbsp;000]</strong></li>
</ul>
<h3>Examples</h3>
<table width="696">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>&lt;p&gt;Some random text&lt;/p&gt;&lt;svg&gt;&lt;cat&gt;&lt;text&gt;How do you rate our food? [Food - General]&lt;/text&gt;&lt;/cat&gt;&lt;cat&gt;&lt;g&gt;&lt;val&gt;1&lt;/val&gt;0&lt;/g&gt;&lt;g&gt;&lt;val&gt;2&lt;/val&gt;1&lt;/g&gt;&lt;g&gt;&lt;val&gt;3&lt;/val&gt;3&lt;/g&gt;&lt;g&gt;&lt;val&gt;4&lt;/val&gt;10&lt;/g&gt;&lt;g&gt;&lt;val&gt;5&lt;/val&gt;7&lt;/g&gt;&lt;/cat&gt;&lt;/svg&gt;&lt;p&gt;Some more random text&lt;/p&gt;</p>
</td>
</tr>
<tr>
<td width="140">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>Food - General: 4.1</p>
</td>
</tr>
<tr>
<td width="140">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>The survey data is surrounded by &lt;svg&gt; and &lt;/svg&gt;, the remaing data is discarded. The first cat contains our label, surrounded by brackets: Food &ndash; General.</p>
<p>The second cat contains five ratings, all surrounded with &lt;g&gt; and &lt;/g&gt;, and when parsed we get the following:</p>
<p>0 votes with value 1 = 0</p>
<p>1 votes with value 2 = 2</p>
<p>3 votes with value 3 = 9</p>
<p>10 votes with value 4 = 40</p>
<p>7 votes with value 5 = 35</p>
<p>The sum of all ratings is 86, divided by their count 21 gives us the average rating <strong>4.095&hellip;</strong>, which we round to the second decimal &ndash; <strong>4.1</strong>.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;svg&gt;&lt;cat&gt;&lt;text&gt;How do you rate the special menu? [Food - Special]&lt;/text&gt;&lt;/cat&gt; &lt;cat&gt;&lt;g&gt;&lt;val&gt;1&lt;/val&gt;5&lt;/g&gt;&lt;g&gt;&lt;val&gt;5&lt;/val&gt;13&lt;/g&gt;&lt;g&gt;&lt;val&gt;10&lt;/val&gt;22&lt;/g&gt;&lt;/cat&gt;&lt;/svg&gt;</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="696">
<p>Food - Special: 7.25</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="696">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>&lt;p&gt;How do you suggest we improve our service?&lt;/p&gt;&lt;p&gt;More tacos.&lt;/p&gt;&lt;p&gt;It's great, don't mess with it!&lt;/p&gt;&lt;p&gt;I'd like to have the option for delivery&lt;/p&gt;</p>
</td>
</tr>
<tr>
<td width="140">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>No survey found</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="696">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>&lt;svg&gt;&lt;cat&gt;&lt;text&gt;Which is your favourite meal from our selection?&lt;/text&gt;&lt;/cat&gt;&lt;cat&gt;&lt;g&gt;&lt;val&gt;Fish&lt;/val&gt;15&lt;/g&gt;&lt;g&gt;&lt;val&gt;Prawns&lt;/val&gt;31&lt;/g&gt;&lt;g&gt;&lt;val&gt;Crab Langoon&lt;/val&gt;12&lt;/g&gt;&lt;g&gt;&lt;val&gt;Calamari&lt;/val&gt;17&lt;/g&gt;&lt;/cat&gt;&lt;/svg&gt;</p>
</td>
</tr>
<tr>
<td width="140">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>Invalid format</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>