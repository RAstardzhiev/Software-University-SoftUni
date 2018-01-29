<h1>Lab: Objects and Associative Arrays</h1>
<p>Problems for in-class lab for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/315/">https://judge.softuni.bg/Contests/315/</a>.</p>
<h2>1.&nbsp;&nbsp; Towns to JSON</h2>
<p>You&rsquo;re tasked to create and print a JSON from a text table. You will receive input as an array of strings, where each string represents a row of a table, with values on the row encompassed by pipes <strong>"|" </strong>and optionally spaces. The table will consist of exactly 3 columns <strong>&ldquo;Town&rdquo;</strong>,<strong> &ldquo;Latitude&rdquo; </strong>and<strong> &ldquo;Longitude&rdquo;</strong>. The <strong>latitude</strong> and <strong>longitude</strong> columns will always contain <strong>valid numbers</strong>. Check the examples to get a better understanding of your task.</p>
<p>The <strong>input</strong> comes as an array of strings &ndash; the first string contains the table&rsquo;s headings, each next string is a row from the table.</p>
<p>The <strong>output</strong> should be printed on the console &ndash; for each entry row in the input print the object representing it.</p>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="706">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>['| Town | Latitude | Longitude |',</p>
<p>'| Sofia | 42.696552 | 23.32601 |',</p>
<p>'| Beijing | 39.913818 | 116.363625 |'];</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>[{"Town":"Sofia","Latitude":42.69,"Longitude":23.32},<br /> {"Town":"Beijing","Latitude":39.91,"Longitude":116.36}]</p>
</td>
</tr>
<tr>
<td width="706">
<p>Input</p>
</td>
</tr>
<tr>
<td width="706">
<p>['| Town | Latitude | Longitude |',</p>
<p>'| Veliko Turnovo | 43.0757 | 25.6172 |',</p>
<p>'| Monatevideo | 34.50 | 56.11 |']</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>[{"Town":"Veliko Turnovo","Latitude":43.0757,"Longitude":25.6172},<br /> {"Town":"Monatevideo","Latitude":34.5,"Longitude":56.11}]</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Score to HTML</h2>
<p>You are given a JSON string representing an array of objects, parse the JSON and create a table using the supplied objects. The table should have 2 columns <strong>"name"</strong> and <strong>"score"</strong>, each object in the array will also have these keys.</p>
<p>Any text elements must also be <strong>escaped</strong> in order to ensure no dangerous code can be passed.</p>
<p>You can either write the HTML escape function yourself or use the one from the Strings and Regular Expressions Lab.</p>
<p>The <strong>input</strong> comes as a single string argument &ndash; the array of objects as a JSON.</p>
<p>The <strong>output</strong> should be printed on the console &ndash; a table with 2 columns - <strong>"name"</strong> and <strong>"score"</strong>, containing the values from the objects as rows.</p>
<table width="706">
<tbody>
<tr>
<td width="706">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>'[{"name":"Pesho","score":479},{"name":"Gosho","score":205}]'</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>&lt;table&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;th&gt;name&lt;/th&gt;&lt;th&gt;score&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;Pesho&lt;/td&gt;&lt;td&gt;479&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;Gosho&lt;/td&gt;&lt;td&gt;205&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="706">
<p>Input</p>
</td>
</tr>
<tr>
<td width="706">
<p>'[{"name":"Pesho &amp; Kiro","score":479},{"name":"Gosho, Maria &amp; Viki","score":205}]'</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>&lt;table&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;th&gt;name&lt;/th&gt;&lt;th&gt;score&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;Pesho &amp;amp; Kiro&lt;/td&gt;&lt;td&gt;479&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp; &lt;tr&gt;&lt;td&gt;Gosho, Maria &amp;amp; Viki&lt;/td&gt;&lt;td&gt;205&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; From JSON to HTML Table</h2>
<p>You&rsquo;re tasked with creating an HTML table of students and their scores. You will receive a single string representing an <strong>array of objects</strong>, the <strong>table&rsquo;s headings</strong> should be equal to the <strong>objects&rsquo; keys</strong>, while <strong>each object&rsquo;s values</strong> should be a <strong>new entry</strong> in the table. Any <strong>text values</strong> in an object should be <strong>escaped</strong>, in order to avoid introducing dangerous code into the HTML.</p>
<p>Object&rsquo;s keys will always be the<strong> same. </strong></p>
<p>The <strong>input</strong> comes as single string argument &ndash; the array of objects.</p>
<p>The <strong>output</strong> should be printed on the console &ndash; for each entry row in the input print the object representing it.</p>
<h3>HTML</h3>
<p>You are provided with an HTML file to test your table in the browser.</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>index.html</p>
</td>
</tr>
<tr>
<td width="664">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;FromJSONToHTMLTable&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>table</strong>,<strong>th</strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border</strong>: <strong>groove</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border-collapse</strong>: <strong>collapse</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>td</strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid black</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>td</strong>,<strong>th</strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 5<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"wrapper"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>function </strong><em>fromJSONToHTMLTable</em>(input){<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>//Write your code here<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </em>}<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>window</strong>.onload = <strong>function</strong>(){<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>let </strong>container = <strong>document</strong>.getElementById(<strong>'wrapper'</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; container.<strong>innerHTML </strong>= <em>fromJSONToHTMLTable</em>([<strong>'[{"Name":"Tomatoes &amp; Chips","Price":2.35},{"Name":"J&amp;B Chocolate","Price":0.96}]'</strong>]);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; };<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="706">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>'[{"Name":"Tomatoes &amp; Chips","Price":2.35},{"Name":"J&amp;B Chocolate","Price":0.96}]'</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>&lt;table&gt;</p>
<p>&nbsp;&nbsp; &lt;tr&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Price&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Tomatoes &amp;amp; Chips&lt;/td&gt;&lt;td&gt;2.35&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;J&amp;amp;B Chocolate&lt;/td&gt;&lt;td&gt;0.96&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
<tr>
<td width="706">
<p>Input</p>
</td>
</tr>
<tr>
<td width="706">
<p>'[{"Name":"Pesho &lt;div&gt;-a","Age":20,"City":"Sofia"},<br /> {"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}]'</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>&lt;table&gt;</p>
<p>&nbsp;&nbsp; &lt;tr&gt;&lt;th&gt;Name&lt;/th&gt;&lt;th&gt;Age&lt;/th&gt;&lt;th&gt;City&lt;/th&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Pesho &amp;lt;div&amp;gt;-a&lt;/td&gt;&lt;td&gt;20&lt;/td&gt;&lt;td&gt;Sofia&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Gosho&lt;/td&gt;&lt;td&gt;18&lt;/td&gt;&lt;td&gt;Plovdiv&lt;/td&gt;&lt;/tr&gt;</p>
<p>&nbsp;&nbsp; &lt;tr&gt;&lt;td&gt;Angel&lt;/td&gt;&lt;td&gt;18&lt;/td&gt;&lt;td&gt;Veliko Tarnovo&lt;/td&gt;&lt;/tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Sum by Town</h2>
<p>You&rsquo;re tasked with calculating the total sum of income for a number of Towns. You will receive an array of strings representing towns and their incomes, every <strong>even</strong> index will be a <strong>town</strong> and every <strong>odd</strong> index will be an <strong>income</strong> belonging to that town. Create an object that will hold all the <strong>towns as keys</strong> and their <strong>total income</strong> (the sum of their incomes) <strong>as values </strong>to those keys and print it as a JSON.</p>
<p>The <strong>input</strong> comes as an array of strings - each even index is the name of a town and each odd index is an income belonging to that town.</p>
<p>The <strong>output</strong> should be printed on the console - JSON representation of the object containing all towns and their total incomes.</p>
<h3>Examples</h3>
<table width="552">
<tbody>
<tr>
<td width="161">
<p><strong>Input</strong></p>
</td>
<td width="391">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="161">
<p>Sofia</p>
<p>20</p>
<p>Varna</p>
<p>3</p>
<p>Sofia</p>
<p>5</p>
<p>Varna</p>
<p>4</p>
</td>
<td width="391">
<p>{"Sofia":25,"Varna":7}</p>
</td>
</tr>
<tr>
<td width="161">
<p>Sofia</p>
<p>20</p>
<p>Varna</p>
<p>3</p>
<p>sofia</p>
<p>5</p>
<p>varna</p>
<p>4</p>
</td>
<td width="391">
<p>{"Sofia":20,"Varna":3,"sofia":5,"varna":4}</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Count Words in a Text</h2>
<p>You are tasked to count the number of words in a text using an object as an associative array, any combination of letters, digits and _ (underscore) should be counted as a word. The words should be stored in the object as properties - the <strong>key</strong> being the <strong>word</strong> and the <strong>value</strong> being the<strong> amount of times the word is contained</strong> <strong>in the text</strong>.</p>
<p>The <strong>input</strong> comes as an array of strings containing one entry - the text whose words should be counted. The text may consist of more than one sentence.</p>
<p>The <strong>output</strong> should be printed on the console - the JSON representation of the object containing the words.</p>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="706">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>Far too slow, you're far too slow.</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>{"Far":1,"too":2,"slow":2,"you":1,"re":1,"far":1}</p>
</td>
</tr>
<tr>
<td width="706">
<p>Input</p>
</td>
</tr>
<tr>
<td width="706">
<p>JS devs use Node.js for server-side JS.-- JS for devs</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>{"JS":3,"devs":2,"use":1,"Node":1,"js":1,"for":2,"server":1,"side":1}</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Count Words with Maps</h2>
<p>You are tasked to count the number of words in a text using a Map, any combination of letters, digits and _ (underscore) should be counted as a word. The words should be stored in a Map - the <strong>key</strong> being the <strong>word</strong> and the <strong>value</strong> being the<strong> amount of times the word is contained</strong> <strong>in the text</strong>. The matching should be <strong>case insensitive</strong>. Print the words in a <strong>sorted order</strong>.</p>
<p>The <strong>input</strong> comes as an array of strings containing one entry - the text whose words should be counted. The text may consist of more than one sentence.</p>
<p>The <strong>output</strong> should be printed on the console - print each word in the map in the format <strong>"'&lt;word&gt;' -&gt; &lt;count&gt; times"</strong>, each on a new line.</p>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="706">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>Far too slow, you're far too slow.</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>'far' -&gt; 2 times</p>
<p>'re' -&gt; 1 times</p>
<p>'slow' -&gt; 2 times</p>
<p>'too' -&gt; 2 times</p>
<p>'you' -&gt; 1 times</p>
</td>
</tr>
<tr>
<td width="706">
<p>Input</p>
</td>
</tr>
<tr>
<td width="706">
<p>JS devs use Node.js for server-side JS. JS devs use JS. -- JS for devs --</p>
</td>
</tr>
<tr>
<td width="706">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="706">
<p>'devs' -&gt; 3 times</p>
<p>'for' -&gt; 2 times</p>
<p>'js' -&gt; 6 times</p>
<p>'node' -&gt; 1 times</p>
<p>'server' -&gt; 1 times</p>
<p>'side' -&gt; 1 times</p>
<p>'use' -&gt; 2 times</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Populations in Towns</h2>
<p>You have been tasked to create a register for different <strong>towns</strong> and their <strong>population</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element will contain data for a town and its population in the following format:</p>
<p>&ldquo;{townName} &lt;-&gt; {townPopulation}&rdquo;</p>
<p>If you receive the same town twice, <strong>you should add</strong> the <strong>given population</strong> to the <strong>current one</strong>.</p>
<p>As<strong> output</strong>, you must print all the towns, and their population.</p>
<h3>Examples</h3>
<table width="703">
<tbody>
<tr>
<td width="165">
<p><strong>Input</strong></p>
</td>
<td width="176">
<p><strong>Output</strong></p>
</td>
<td width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="170">
<p><strong>Input</strong></p>
</td>
<td width="179">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="165">
<p>Sofia &lt;-&gt; 1200000</p>
<p>Montana &lt;-&gt; 20000</p>
<p>New York &lt;-&gt; 10000000</p>
<p>Washington &lt;-&gt; 2345000</p>
<p>Las Vegas &lt;-&gt; 1000000</p>
</td>
<td width="176">
<p>Sofia : 1200000</p>
<p>Montana : 20000</p>
<p>New York : 10000000</p>
<p>Washington : 2345000</p>
<p>Las Vegas : 1000000</p>
</td>
<td width="13">
<p>&nbsp;</p>
</td>
<td width="170">
<p>Istanbul &lt;-&gt; 100000</p>
<p>Honk Kong &lt;-&gt; 2100004</p>
<p>Jerusalem &lt;-&gt; 2352344</p>
<p>Mexico City &lt;-&gt; 23401925</p>
<p>Istanbul &lt;-&gt; 1000</p>
</td>
<td width="179">
<p>Istanbul : 101000</p>
<p>Honk Kong : 2100004</p>
<p>Jerusalem : 2352344</p>
<p>Mexico City : 23401925</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; City Markets</h2>
<p>You have been tasked to follow the sales of products in the different towns. For every town you need to keep track of all the products sold, and for every product, the amount of total income.</p>
<p>The <strong>input</strong> comes as array of strings. Each element will represent data about a product and its sales. The format of input is:</p>
<p>{town} -&gt; {product} -&gt; {amountOfSales} : {priceForOneUnit}</p>
<p>The <strong>town</strong> and <strong>product</strong> are both <strong>strings</strong>. The <strong>amount of sales</strong> and <strong>price for one unit</strong> will be <strong>numbers</strong>. Store all towns, for every town, store its products, and for every product, its amount of <strong>total income</strong>. The total income is calculated with the following formula - <strong>amount of sales * price for one unit</strong>. If you receive as input a town you already have, you should just <strong>add</strong> the <strong>new product</strong> to it.</p>
<p>As <strong>output</strong> you must print every town, its products and their total income in the following format:</p>
<p>&ldquo;Town &ndash; {townName}</p>
<p>&nbsp;$$${product1Name} : {productTotalIncome}</p>
<p>&nbsp;$$${product2Name} : {productTotalIncome}</p>
<p>&nbsp;...&rdquo;</p>
<p>The <strong>order of output</strong> for each of those entries is &ndash; by <strong>order of entrance</strong>.</p>
<h3>Examples</h3>
<table width="713">
<tbody>
<tr>
<td width="354">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="354">
<p>Sofia -&gt; Laptops HP -&gt; 200 : 2000</p>
<p>Sofia -&gt; Raspberry -&gt; 200000 : 1500</p>
<p>Sofia -&gt; Audi Q7 -&gt; 200 : 100000</p>
<p>Montana -&gt; Portokals -&gt; 200000 : 1</p>
<p>Montana -&gt; Qgodas -&gt; 20000 : 0.2</p>
<p>Montana -&gt; Chereshas -&gt; 1000 : 0.3</p>
</td>
<td width="359">
<p>Town - Sofia</p>
<p>$$$Laptops HP : 400000</p>
<p>$$$Raspberry : 300000000</p>
<p>$$$Audi Q7 : 20000000</p>
<p>Town - Montana</p>
<p>$$$Portokals : 200000</p>
<p>$$$Qgodas : 4000</p>
<p>$$$Chereshas : 300</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Lowest Prices in Cities</h2>
<p>You will be given several towns, with products and their price. You need to find <strong>the lowest price</strong> for <strong>every product</strong> and <strong>the town it is sold at</strong> for that price.</p>
<p>The <strong>input</strong> comes as array of strings. Each element will hold data about a <strong>town</strong>, <strong>product</strong>, and <strong>its price</strong> at that town. The <strong>town</strong> and <strong>product</strong> will be <strong>strings</strong>; the <strong>price</strong> will be a <strong>number</strong>. The input will come in the following format:</p>
<p>{townName} | {productName} | {productPrice}</p>
<p>If you receive the same <strong>town</strong> and <strong>product</strong> <strong>more than once, </strong>you should <strong>update</strong> the <strong>old value</strong> with the <strong>new one</strong>.</p>
<p>As <strong>output</strong> you must print <strong>each</strong> <strong>product</strong> with its <strong>lowest price</strong> and <strong>the town</strong> at which the product is <strong>sold at that</strong> <strong>price</strong>. If <strong>two towns share</strong> the <strong>same lowest price</strong>, print the one that was <strong>entered first</strong>. <br /> The output, for every product, should be in the following format:</p>
<p>{productName} -&gt; {productLowestPrice} ({townName})</p>
<p>The <strong>order of output</strong> is &ndash; <strong>order of entrance</strong>. See the examples for more info.</p>
<h3>Examples</h3>
<table width="713">
<tbody>
<tr>
<td width="354">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="354">
<p>Sample Town | Sample Product | 1000</p>
<p>Sample Town | Orange | 2</p>
<p>Sample Town | Peach | 1</p>
<p>Sofia | Orange | 3</p>
<p>Sofia | Peach | 2</p>
<p>New York | Sample Product | 1000.1</p>
<p>New York | Burger | 10</p>
</td>
<td width="359">
<p>Sample Product -&gt; 1000 (Sample Town)</p>
<p>Orange -&gt; 2 (Sample Town)</p>
<p>Peach -&gt; 1 (Sample Town)</p>
<p>Burger -&gt; 10 (New York)</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Extract Unique Words</h2>
<p>Write a JS function that <strong>extracts</strong> all <strong>UNIQUE</strong> words from a <strong>valid text</strong>, and <strong>stores them</strong>. Ensure that there are <strong>NO duplicates</strong> in the stored words. Once you find a word, there is no need for you to store it again if you meet it again in the text. You also need to make all characters from the words you&rsquo;ve stored &ndash; <strong>lowercase</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element will represent a sentence.</p>
<p>The <strong>output</strong> is all of the unique words you&rsquo;ve found, each with each, <strong>separated</strong> by a <strong>coma and a space</strong>, printed in the order in which you&rsquo;ve found them.</p>
<h3>Examples</h3>
<table width="713">
<tbody>
<tr>
<td width="382">
<p><strong>Input</strong></p>
</td>
<td width="331">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="382">
<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque quis hendrerit dui.</p>
<p>Quisque fringilla est urna, vitae efficitur urna vestibulum fringilla.</p>
<p>Vestibulum dolor diam, dignissim quis varius non, fermentum non felis.</p>
<p>Vestibulum ultrices ex massa, sit amet faucibus nunc aliquam ut.</p>
<p>Morbi in ipsum varius, pharetra diam vel, mattis arcu.</p>
<p>Integer ac turpis commodo, varius nulla sed, elementum lectus.</p>
<p>Vivamus turpis dui, malesuada ac turpis dapibus, congue egestas metus.</p>
</td>
<td width="331">
<p>lorem, ipsum, dolor, sit, amet, consectetur, adipiscing, elit, pellentesque, quis, hendrerit, dui, quisque, fringilla, est, urna, vitae, efficitur, vestibulum, diam, dignissim, varius, non, fermentum, felis, ultrices, ex, massa, faucibus, nunc, aliquam, ut, morbi, in, pharetra, vel, mattis, arcu, integer, ac, turpis, commodo, nulla, sed, elementum, lectus, vivamus, malesuada, dapibus, congue, egestas, metus</p>
</td>
</tr>
<tr>
<td width="382">
<p>&nbsp;</p>
</td>
<td width="331">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="382">
<p><strong>Input</strong></p>
</td>
<td width="331">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="382">
<p>Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>
<p>Vestibulum volutpat lacinia blandit.</p>
<p>Pellentesque dignissim odio in hendrerit lacinia.</p>
<p>Vivamus placerat porttitor purus nec hendrerit.</p>
<p>Aliquam erat volutpat. Donec ac augue ligula.</p>
<p>Praesent venenatis sapien vitae libero ornare, nec pulvinar velit finibus.</p>
<p>Proin dui neque, rutrum vel dolor ut, placerat blandit sapien.</p>
<p>Pellentesque at est arcu.</p>
<p>Nullam eget orci laoreet, feugiat nisi vitae, egestas libero.</p>
<p>Pellentesque pulvinar aliquet felis.</p>
<p>Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>
<p>Etiam sit amet nisl ex.</p>
<p>Sed lacinia pretium metus quis fermentum.</p>
<p>Praesent a ante suscipit, efficitur risus cursus, scelerisque risus.</p>
</td>
<td width="331">
<p>interdum, et, malesuada, fames, ac, ante, ipsum, primis, in, faucibus, vestibulum, volutpat, lacinia, blandit, pellentesque, dignissim, odio, hendrerit, vivamus, placerat, porttitor, purus, nec, aliquam, erat, donec, augue, ligula, praesent, venenatis, sapien, vitae, libero, ornare, pulvinar, velit, finibus, proin, dui, neque, rutrum, vel, dolor, ut, at, est, arcu, nullam, eget, orci, laoreet, feugiat, nisi, egestas, aliquet, felis, etiam, sit, amet, nisl, ex, sed, pretium, metus, quis, fermentum, a, suscipit, efficitur, risus, cursus, scelerisque</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>