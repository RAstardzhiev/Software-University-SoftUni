<h1>Lab: jQuery</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/329">https://judge.softuni.bg/Contests/329</a>.</p>
<h2>1.&nbsp;&nbsp; Text from List</h2>
<p>A HTML page holding a <strong>list</strong> of items and an [Extract Text] button is given. Implement the extractText function which will be called when the button's onClick event is fired.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>text.html</p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Text from List&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js" </strong><strong>integrity=</strong><strong>"sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"extractText.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>ul </strong><strong>id=</strong><strong>"items"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;first item&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;second item&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;third item&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>ul</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>onclick=</strong><strong>"</strong><em>extractText</em>()<strong>"</strong>&gt;<br /> Extract Text&lt;/<strong>button</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"result"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>extract-text.js</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>function </strong><em>extractText</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Screenshot</h3>
<p>&nbsp;</p>
<h2>2.&nbsp;&nbsp; Search in List</h2>
<p>An HTML page holds a <strong>list</strong> of towns, a <strong>search</strong> box and a [Search] button. Implement the search function to <strong>bold</strong> the items from the list which include the text from the <strong>search</strong> box. Also print the amount of items the current search<strong> matches</strong> in the format <strong>"&lt;matches&gt; matches found."</strong></p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="701">
<tbody>
<tr>
<td width="701">
<p>list.html</p>
</td>
</tr>
<tr>
<td width="701">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Search in List&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js" </strong><strong>integrity=</strong><strong>"sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"search.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>ul </strong><strong>id=</strong><strong>"towns"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Sofia&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Pleven&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Varna&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Plovdiv&lt;/<strong>li</strong>&gt;<br /> &lt;/<strong>ul</strong>&gt;<br /> &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"searchText" </strong>/&gt;<br /> &lt;<strong>button </strong><strong>onclick=</strong><strong>"</strong><em>search</em>()<strong>"</strong>&gt;Search&lt;/<strong>button</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"result"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>search.js</p>
</td>
</tr>
<tr>
<td width="700">
<p><strong>function </strong><em>search</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Screenshots</h3>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Countries Table</h2>
<p>You are given and HTML table holding <strong>countries</strong> and their <strong>capitals</strong>. You need to implement a [Create] link to create a new country and for each existing country implement [Up], [Down] and [Delete] links to manipulate its position in the table.</p>
<p>The table needs to have the following entries when it&rsquo;s initialized (<strong>add them when your functions starts</strong>):</p>
<p>Bulgaria, Sofia</p>
<p>Germany, Berlin</p>
<p>Russia, Moscow</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>countries.html</p>
</td>
</tr>
<tr>
<td width="700">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Countries Table&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>td</strong>, <strong>th </strong>{ <strong>background</strong>: <strong>#DDD</strong>; <strong>padding</strong>: 5<strong>px </strong>10<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>input</strong>[<strong>type</strong>=<strong>'text'</strong>] { <strong>width</strong>: 60<strong>px </strong>}<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js" </strong><strong>integrity=</strong><strong>"sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8="&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"initialize-table.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>table </strong><strong>id=</strong><strong>"countriesTable"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Country&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Capital&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Action&lt;/<strong>th</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"newCountryText" </strong>/&gt;&lt;/<strong>td</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"newCapitalText" </strong>/&gt;&lt;/<strong>td</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;&lt;<strong>a </strong><strong>href=</strong><strong>"#" </strong><strong>id=</strong><strong>"createLink"</strong>&gt;[Create]&lt;/<strong>a</strong>&gt;&lt;/<strong>td</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>tr</strong>&gt;<br /> &lt;/<strong>table</strong>&gt;<br /> &lt;<strong>script</strong>&gt;$(() =&gt; <em>initializeTable</em>())&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>initialize-table.js</p>
</td>
</tr>
<tr>
<td width="700">
<p><strong>function </strong><em>initializeTable</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Screenshots</h3>
<h2>4.&nbsp;&nbsp; Link Buttons</h2>
<p>You are given HTML holding some buttons. Implement the attachEvents function which should attach click events on the buttons. When a button is <strong>clicked</strong> it should <strong>remove</strong> the class="selected" attribute from the button that currently holds it and <strong>add it to its own attributes</strong>.</p>
<h3>HTML, CSS and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>buttons.html</p>
</td>
</tr>
<tr>
<td width="700">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Title&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>link </strong><strong>rel=</strong><strong>"stylesheet" </strong><strong>href=</strong><strong>"link-buttons.css" </strong>/&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"link-buttons.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body </strong><strong>onload=</strong><strong>"</strong>attachEvents()<strong>"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>a </strong><strong>class=</strong><strong>"button"</strong>&gt;Sofia&lt;/<strong>a</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>a </strong><strong>class=</strong><strong>"button"</strong>&gt;Plovdiv&lt;/<strong>a</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>a </strong><strong>class=</strong><strong>"button"</strong>&gt;Varna&lt;/<strong>a</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes with this <strong>CSS</strong>:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>link-buttons.css</p>
</td>
</tr>
<tr>
<td width="700">
<p><strong>a</strong>.<strong>button </strong>{<br /> &nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid </strong><strong>#CCC</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#EEE</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>padding</strong>: 5<strong>px </strong>10<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>border-radius</strong>: 5<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>#333</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>text-decoration</strong>: <strong>none</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>inline-block</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>margin</strong>: 5<strong>px</strong>;<br /> }<br /> <br /> <strong>a</strong>.<strong>button</strong>.<strong>selected </strong>{<br /> &nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>#111</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>font-weight</strong>: <strong>bold</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid </strong><strong>#AAA</strong>;<br /> &nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#BBB</strong>;<br /> }<br /> <br /> <strong>a</strong>.<strong>button</strong>.<strong>selected</strong>::<strong>before </strong>{<br /> &nbsp;&nbsp;&nbsp; <strong>content</strong>: <strong>"\2713\20\20"</strong>;<br /> }<br /> <br /> <strong>a</strong>:<strong>hover </strong>{<br /> &nbsp;&nbsp;&nbsp; <strong>cursor</strong>: <strong>pointer</strong>;<br /> }</p>
</td>
</tr>
</tbody>
</table>
<p>and the following <strong>JavaScript</strong> code:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>link-buttons.js</p>
</td>
</tr>
<tr>
<td width="700">
<p><strong>function </strong><em>attachEvents</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Screenshots</h3>
<h3>Hints</h3>
<ul>
<li>Use the attachEventListener</li>
</ul>
<h2>5.&nbsp;&nbsp; Selectable Towns</h2>
<p>Create an HTML page listing <strong>towns</strong>, a town should be selectable. Clicking on a town should <strong>select/deselect</strong> it, a selected town should have the data-selected attribute added to it and its background color should be changed to #DDD. Also create a button [Show Towns] that prints the text <strong>"Selected towns: "</strong> followed by all selected towns joined with a <strong>", "</strong>.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>towns.html</p>
</td>
</tr>
<tr>
<td width="700">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Selectable Towns&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>li </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>inline-block</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>cursor</strong>: <strong>pointer</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 10<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>ul </strong>{ <strong>padding</strong>:0; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.1.min.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"select-towns.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>h2</strong>&gt;Towns&lt;/<strong>h2</strong>&gt;<br /> &lt;<strong>ul </strong><strong>id=</strong><strong>"items"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Sofia&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Varna&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Plovdiv&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Bourgas&lt;/<strong>li</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>li</strong>&gt;Rousse&lt;/<strong>li</strong>&gt;<br /> &lt;/<strong>ul</strong>&gt;<br /> &lt;<strong>button </strong><strong>id=</strong><strong>"showTownsButton"</strong>&gt;Show Towns&lt;/<strong>button</strong>&gt;</p>
<p>&lt;<strong>div</strong> <strong>id=</strong><strong>"selectedTowns"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script</strong>&gt;$(<em>attachEvents</em>())&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="700">
<tbody>
<tr>
<td width="700">
<p>select-towns.js</p>
</td>
</tr>
<tr>
<td width="700">
<p><strong>function </strong><em>attachEvents</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Screenshots</h3>