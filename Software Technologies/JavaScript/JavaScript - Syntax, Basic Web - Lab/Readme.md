<h1>Lab: JavaScript Syntax and Basic Web</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/software-technologies">&ldquo;Software Technologies&rdquo; course @ SoftUni</a>.</p>
<p>You can submit your solutions here <a href="https://judge.softuni.bg/Contests/223/">https://judge.softuni.bg/Contests/223/</a>.</p>
<h2>1.&nbsp;&nbsp; Sum Numbers with HTML and JS</h2>
<p>Create an HTML form holding two text fields and a result field and write a JavaScript function to <strong>sum </strong>them.</p>
<h3>Examples</h3>
<table width="549">
<tbody>
<tr>
<td width="61">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="20">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="19">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="61">
<p>1 2</p>
</td>
<td width="62">
<p>3</p>
</td>
<td width="20">
<p>&nbsp;</p>
</td>
<td width="60">
<p>5 5</p>
</td>
<td width="62">
<p>10</p>
</td>
<td width="60">
<p>10 15</p>
</td>
<td width="62">
<p>25</p>
</td>
<td width="60">
<p>1 5</p>
</td>
<td width="62">
<p>6</p>
</td>
</tr>
</tbody>
</table>
<h3>Step by Step</h3>
<h4>1.&nbsp;&nbsp;&nbsp;&nbsp; Create WebStorm Project</h4>
<p>Open WebStorm and click Create New Project:</p>
<p>Give the folder a meaningful name, such as &ldquo;JS Syntax Lab&rdquo;:</p>
<h4>2.&nbsp;&nbsp;&nbsp;&nbsp; Create a New HTML File</h4>
<p><strong>Right click</strong> the folder in the <strong>Project view</strong>, which just appeared (if you can&rsquo;t see the project view, go to <strong>View-&gt;Tool Windows -&gt; Project</strong> to open it), hover over the &ldquo;<strong>New</strong>&rdquo; menu, and click &ldquo;<strong>HTML File</strong>&rdquo;:</p>
<p>Give the HTML file a meaningful name</p>
<h4>3.&nbsp;&nbsp;&nbsp;&nbsp; Create the Form</h4>
<p>After you create the file, it&rsquo;s time to make the form. Create a &lt;form&gt; tag with some &lt;input&gt; fields inside:</p>
<p>The input fields are as follows:</p>
<ul>
<li>A <strong>text</strong> input field, called <strong>num1</strong></li>
<li>A <strong>text</strong> input field, called <strong>num2</strong></li>
<li>A <strong>button </strong>input, which calls the &ldquo;sumNumbers()&rdquo; function upon being clicked, and has the text &ldquo;Calculate&rdquo; inside it.</li>
</ul>
<p>Apart from the form, we&rsquo;ve also created a <strong>div</strong>, which will hold the <strong>result</strong> of the calculation.</p>
<h4>4.&nbsp;&nbsp;&nbsp;&nbsp; Write the JavaScript Code</h4>
<p>Let&rsquo;s create a &lt;script&gt; tag after the form, which will hold our logic:</p>
<p>In order to perform the calculation, we need to <strong>access</strong> the <strong>num1</strong> and <strong>num2</strong> fields&rsquo; <strong>values</strong> and then sum them. Let&rsquo;s first create a function calculateResult(), which will be called on click:</p>
<p>After we create the script tag, we can get both the elements <strong>by id</strong>, and sum them:</p>
<p>We&rsquo;ve written the code, but WebStorm is showing us some errors. The reason it&rsquo;s showing errors with the <strong>let</strong> expression is because it <strong>didn&rsquo;t exist yet</strong> in <strong>ECMAScript 5.1</strong>, which WebStorm uses by <strong>default</strong>. We need to <strong>fix</strong> that.</p>
<p>Place the cursor over the <strong>let</strong> expression and press [Alt+Enter] to open the <strong>quick fix</strong> menu and <strong>change</strong> the <strong>JavaScript version</strong> to <strong>ECMAScript 6</strong>:</p>
<p>Afterwards, the errors should disappear. Let&rsquo;s continue writing the code. Next, we need to sum the numbers. We&rsquo;ll do that by creating a variable called <strong>sum</strong>, which will hold the result of num1 and num2, converted to the <strong>number</strong> data type:</p>
<p>Finally, we need to set the text of the #result element, which we&rsquo;ll access by its <strong>id</strong>, and set its <strong>inner HTML</strong> value to the sum:</p>
<h4>5.&nbsp;&nbsp;&nbsp;&nbsp; Open the HTML Page</h4>
<p>After we&rsquo;re done writing our logic, it&rsquo;s time to open the page and check if it works. We can do that by going to the <strong>top right</strong> corner of WebStorm and clicking our <strong>browser of choice</strong> to open the page in it:</p>
<p>Upon clicking the <strong>Calculate</strong> button, the sum should appear below:</p>
<p>Looks like it works!</p>
<h2>2.&nbsp;&nbsp; Calculate Expression</h2>
<p>Write a JavaScript program to print the value of the following expression:</p>
<ul>
<li>((30 + 25) * 1/3 * (35 - 14 - 12))<sup>2</sup></li>
</ul>
<h3>Examples</h3>
<table width="162">
<tbody>
<tr>
<td width="100">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="100">
<p><em>(no input)</em></p>
</td>
<td width="62">
<p>27225</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>This exercise has a <strong>Judge</strong> <strong>contest</strong> <strong>entry</strong>, so you need to create a <strong>JavaScript</strong> <strong>function</strong>, in order for the judge system to <strong>accept</strong> it as <strong>valid</strong>, and submit <strong>only</strong> that function</li>
<li>You can solve this problem by either using the pow() method or by multiplying the result by <strong>itself</strong>.</li>
</ul>
<h2>3.&nbsp;&nbsp; Sum Two Numbers</h2>
<p>Write a JavaScript program to sum <strong>two numbers</strong>, which are received as a <strong>string array</strong>.</p>
<h3>Examples</h3>
<table width="362">
<tbody>
<tr>
<td width="112">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="17">
<p><strong>&nbsp;</strong></p>
</td>
<td width="108">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="112">
<p>['10', '20']</p>
</td>
<td width="62">
<p>30</p>
</td>
<td width="17">
<p>&nbsp;</p>
</td>
<td width="108">
<p>['66', '4']</p>
</td>
<td width="62">
<p>70</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Since the input is received as a <strong>string array</strong>, you&rsquo;re going to have to do some conversion, in order to be able to sum them.</li>
</ul>
<h2>4.&nbsp;&nbsp; Three Integers Sum</h2>
<p>Write a JavaScript program, which receives <strong>three numbers</strong>, as a <strong>string array</strong>. Your task is to check whether there exists a number in the sequence, which is equal to the <strong>sum</strong> of the other two. If they are, print the numbers and their sum in the following format: &ldquo;`${num1} + ${num2} = ${sum}`&rdquo;. If there&rsquo;s no such element, print &ldquo;No&rdquo;.</p>
<h3>Examples</h3>
<table width="524">
<tbody>
<tr>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="98">
<p><strong>Output</strong></p>
</td>
<td width="14">
<p><strong>&nbsp;</strong></p>
</td>
<td width="84">
<p><strong>Input</strong></p>
</td>
<td width="116">
<p><strong>Output</strong></p>
</td>
<td width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="68">
<p>8 15 7</p>
</td>
<td width="98">
<p>7 + 8 = 15</p>
</td>
<td width="14">
<p>&nbsp;</p>
</td>
<td width="84">
<p>-5 -3 -2</p>
</td>
<td width="116">
<p>-3 + -2 = -5</p>
</td>
<td width="13">
<p>&nbsp;</p>
</td>
<td width="68">
<p>3 8 12</p>
</td>
<td width="62">
<p>No</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Symmetric Numbers</h2>
<p>Write a JavaScript program, which receives <strong>a number </strong>n, as a <strong>string array</strong> with a single element, and print all symmetrical numbers in the range [1&hellip;n].</p>
<h3>Examples</h3>
<table width="450">
<tbody>
<tr>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="382">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="68">
<p>100</p>
</td>
<td width="382">
<p>1 2 3 4 5 6 7 8 9 11 22 33 44 55 66 77 88 99</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="450">
<tbody>
<tr>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="382">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="68">
<p>750</p>
</td>
<td width="382">
<p>1 2 3 4 5 6 7 8 9 11 22 33 44 55 66 77 88 99 101 111 121 131 141 151 161 171 181 191 202 212 222 232 242 252 262 272 282 292 303 313 323 333 343 353 363 373 383 393 404 414 424 434 444 454 464 474 484 494 505 515 525 535 545 555 565 575 585 595 606 616 626 636 646 656 666 676 686 696 707 717 727 737 747</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Sums by Town</h2>
<p>You are given a sequence of <strong>JSON</strong> <strong>strings</strong> holding <strong>town</strong> + <strong>income</strong>. Write a JS function to <strong>sum</strong> and print the <strong>incomes</strong> for <strong>each town</strong>. Towns can appear <strong>multiple times</strong>. In the output, <strong>order</strong> the towns by <strong>name</strong>.</p>
<h3>Examples</h3>
<table width="450">
<tbody>
<tr>
<td width="262">
<p><strong>Input</strong></p>
</td>
<td width="188">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="262">
<p>{"town":"Sofia","income":200}</p>
<p>{"town":"Varna","income":120}</p>
<p>{"town":"Pleven","income":60}</p>
<p>{"town":"Varna","income":70}</p>
</td>
<td width="188">
<p>Pleven -&gt; 60</p>
<p>Sofia -&gt; 200</p>
<p>Varna -&gt; 190</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Largest 3 Numbers</h2>
<p>Write a program to read an <strong>array</strong> of <strong>numbers</strong> and find and print the <strong>largest 3</strong> of them, sorted in <strong>descending order</strong>.</p>
<h3>Examples</h3>
<table width="548">
<tbody>
<tr>
<td width="148">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="60">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
<td width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="116">
<p><strong>Input</strong></p>
</td>
<td width="62">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="148">
<p>10 30 15 20 50 5</p>
</td>
<td width="62">
<p>50</p>
<p>30</p>
<p>20</p>
</td>
<td width="24">
<p>&nbsp;</p>
</td>
<td width="60">
<p>20 30</p>
</td>
<td width="62">
<p>30</p>
<p>20</p>
</td>
<td width="13">
<p>&nbsp;</p>
</td>
<td width="116">
<p>10 5 20 3 20</p>
</td>
<td width="62">
<p>20</p>
<p>20</p>
<p>10</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Extract Capital-Case Words</h2>
<p>Write a <strong>JavaScript</strong> function to <strong>extract</strong> from array of strings all <strong>capital-case</strong> words. All <strong>non-letter chars</strong> are considered <strong>separators</strong>.</p>
<h3>Examples</h3>
<table width="718">
<tbody>
<tr>
<td width="448">
<p><strong>Input</strong></p>
</td>
<td width="270">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="448">
<p>We start by HTML, CSS, JavaScript, JSON and REST.</p>
<p>Later we touch some PHP, MySQL and SQL.</p>
<p>Later we play with C#, EF, SQL Server and ASP.NET MVC.</p>
<p>Finally, we touch some Java, Hibernate and Spring.MVC.</p>
</td>
<td width="270">
<p>HTML, CSS, JSON, REST, PHP, SQL, C, EF, SQL, ASP, NET, MVC, MVC</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>