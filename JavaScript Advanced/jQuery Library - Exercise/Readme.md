<h1>Exercises: jQuery, DOM and Events</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/278/jQuery-and-DOM">https://judge.softuni.bg/Contests/278/jQuery-and-DOM</a>.</p>
<h2>1.&nbsp;&nbsp; Increment Counter</h2>
<p>You are tasked with creating a piece of <strong>HTML</strong> dynamically using JavaScript and <strong>appending</strong> it to a given element using a passed in <strong>selector</strong>.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>incrementCounter.html</p>
</td>
</tr>
<tr>
<td width="664">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Increment Counter&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.0.min.js"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>integrity=</strong><strong>"sha256-cCueBR6CsyA4/9szpPfrX3s49M9vUU5BgtiJj06wt/s="<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"wrapper"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"incrementCounter.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>window</strong>.onload = <strong>function</strong>(){<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>increment</em>(<strong>"#wrapper"</strong>);<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>incrementCounter.js</p>
</td>
</tr>
<tr>
<td width="664">
<p><strong>function </strong><em>increment</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>Your function will receive a <strong>string </strong>value representing a <strong>selector</strong> (for example "#wrapper" or ".root"), all elements created should be appended to the <strong>selector</strong>.&nbsp;</p>
<p>The HTML you create should contain 4 elements:</p>
<ul>
<li>&lt;textarea&gt; with class="counter", value="0" and the disabled</li>
<li>&lt;button&gt; with class="btn", id="incrementBtn" and text "<strong>Increment</strong>".</li>
<li>&lt;button&gt; with class="btn", id="addBtn" and text "<strong>Add</strong>".</li>
<li>Unordered list &lt;ul&gt; with class="results".</li>
</ul>
<p>When the [Increment] is clicked the value of the <strong>textarea</strong> should go up by <strong>one</strong> (if it was 0 it should become 1 e.t.c.). When the [Add] is clicked a new list item (&lt;li&gt;) with text equal to the current value of the textarea should be added to the unordered list.</p>
<p>Submit in the judge the JS code (implementation) of the above function. It may hold other functions in its body.</p>
<h3>Screenshots</h3>
<h3>Hints</h3>
<p>We&rsquo;ll start off by creating the needed elements and parsing the <strong>selector</strong>, we can do it easily with <strong>jQuery</strong> like this:</p>
<p>Adding multiple elements to the DOM can be expensive, instead of repeatedly adding to the DOM we can create a DocumentFragment and <strong>add</strong> the elements to it instead. When we have built our hierarchy we can <strong>append the</strong> DocumentFragment to the DOM, which will add all of the fragment&rsquo;s elements to the specified selector.<br /> <br /> The next step is to <strong>add values</strong>, and <strong>attributes</strong> to the <strong>elements</strong> and <strong>events</strong> to the <strong>buttons</strong>:</p>
<p>The last step is to <strong>add</strong> our elements to the DOM:</p>
<p>Our code is now ready to be submitted to Judge.</p>
<h2>2.&nbsp;&nbsp; Timer</h2>
<p>You will be given an <strong>HTML</strong> file, containing the markup of a<strong> timer</strong> with spans for <strong>seconds</strong>, <strong>minutes</strong> and <strong>hours</strong> and buttons to [Start] and [Pause] the timer. Your task is to create a JavaScript application that <strong>starts</strong> the timer whenever the [Start] button is pressed and <strong>pauses</strong> it when the [Pause] button is pressed.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>timer.html</p>
</td>
</tr>
<tr>
<td width="664">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Timer&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.0.min.js"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>integrity=</strong><strong>"sha256-cCueBR6CsyA4/9szpPfrX3s49M9vUU5BgtiJj06wt/s="<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>#timer </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>font-size</strong>: 5<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"timer"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>span </strong><strong>id=</strong><strong>"hours" </strong><strong>class=</strong><strong>"timer"</strong>&gt;00&lt;/<strong>span</strong>&gt;:<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>span </strong><strong>id=</strong><strong>"minutes" </strong><strong>class=</strong><strong>"timer"</strong>&gt;00&lt;/<strong>span</strong>&gt;:<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>span </strong><strong>id=</strong><strong>"seconds" </strong><strong>class=</strong><strong>"timer"</strong>&gt;00&lt;/<strong>span</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>id=</strong><strong>"start-timer"</strong>&gt;Start&lt;/<strong>button</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>id=</strong><strong>"stop-timer"</strong>&gt;Stop&lt;/<strong>button</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"timer.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>window</strong>.onload=<strong>function</strong>(){<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>timer</em>();<br /> &nbsp;&nbsp;&nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="51">
<p>timer.js</p>
</td>
</tr>
<tr>
<td width="51">
<p><strong>function </strong><em>timer</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>Submit in the judge the JS code (implementation) of the above function. It may hold other functions in its body.</p>
<h3>Constraints</h3>
<ul>
<li>The initial value of the timer must always be <strong>00:00:00</strong></li>
</ul>
<h3>Hints</h3>
<p>Note the spans have unique id values &ndash; we can use these to select and modify the elements with <strong>jQuery</strong>.</p>
<p>JavaScript has a built-in function setInterval() for executing and repeating an action after a set period of time. It returns an object which can later be used to stop the execution with clearInterval().</p>
<p>The <strong>first argument</strong> can be an inline declaration or a <strong>named function</strong>. The <strong>second argument</strong> is the <strong>time interval</strong>, specified in <strong>milliseconds</strong>. We can easily attach these two functions to the click event of a button.</p>
<p>To get and set the text of a markup element you can either use its textContent property, or jQuery&rsquo;s text() function.</p>
<p>Keep in mind that that you should only have one setInterval() function active when the the timer is working, multiple presses of the [Start] button should not attach more setInterval() functions as that would break the correct operation of the timer.</p>
<h2>3.&nbsp;&nbsp; Book Generator</h2>
<p>Create a function that accepts a selector, a title, an author and an ISBN and <strong>uses</strong> them to <strong>create</strong> the <strong>HTML code</strong> for a <strong>book</strong> and <strong>inserts it</strong> into the <strong>selector</strong>.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>book-generator.html</p>
</td>
</tr>
<tr>
<td width="664">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Book Generator&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.0.min.js"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>integrity=</strong><strong>"sha256-cCueBR6CsyA4/9szpPfrX3s49M9vUU5BgtiJj06wt/s="<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"wrapper"</strong>&gt;<br /> <br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"book</strong><strong>-g</strong><strong>enerator.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; window.onload = <strong>function </strong>() {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>createBook</em>(<strong>"#wrapper"</strong>, <strong>"Alice in Wonderland"</strong>, <strong>"Lewis Carroll"</strong>, 1111);<br /> &nbsp;&nbsp;&nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>book-generator.js</p>
</td>
</tr>
<tr>
<td width="664">
<p><strong>function </strong><em>createBook</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>Your function will receive <strong>4 parameters</strong> - a <strong>string value</strong> representing a selector (for example "#wrapper" or ".root"), a <strong>string value</strong> representing the title of the book, a <strong>string value</strong> representing the author of the book and a <strong>number</strong> representing the ISBN of the book. <strong>After</strong> the book is <strong>created</strong> it should be <strong>attached</strong> to the passed in <strong>selector</strong>.</p>
<p>The <strong>number</strong> in the Id of the containing div should be <strong>incremented</strong> by <strong>one</strong> <strong>for each successive book created</strong> (i.e. first book should have id = "book1", second id = "book2" and so on&hellip;). The title, author and ISBN should be <strong>paragraphs</strong> with a class equal to their <strong>respective role</strong> - class="title" for the <strong>title paragraph</strong>, class="author" for the <strong>author paragraph</strong> and class="isbn" for the <strong>ISBN paragraph</strong>. A book should also contain <strong>2 buttons</strong> &ndash; [Select] and [Deselect], when the [Select] button is pressed the border of the div element should be set to "2px solid blue". When the [Deselect] button is pressed it should be set to "none".</p>
<h3>Screenshots</h3>
<p>The HTML code for a book should have the following structure:</p>
<p>Selected book:</p>
<h3>Hints</h3>
<p>You can use what is known as an <strong>IIFE</strong> (Immediately Invoked Function Expression) to declare and instantly execute a function that will keep the id variable in its scope. This way you will receive the inner function and for it the variable id will be <strong>shared between all calls</strong>, essentially becoming like a <strong>static variable</strong> for the function:</p>
<p>An <strong>element&rsquo;s</strong> <strong>css properties</strong> can easily be changed with <strong>jQuery</strong> in the following way:</p>
<h2>4.&nbsp;&nbsp; Form Validation</h2>
<p>You are given the task to write <strong>validation</strong> for the fields of a simple form.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are provided a <strong>skeleton</strong> containing the necessary files for your program.</p>
<p>The validations should be as follows:</p>
<ul>
<li>The username needs to be between <strong>3</strong> and <strong>20</strong> symbols <strong>inclusively</strong> and only <strong>letters</strong> and <strong>numbers</strong> are allowed.</li>
<li>The password and confirm-password must be between <strong>5</strong> and <strong>15</strong> <strong>inclusively</strong> symbols and only <strong>word characters</strong> are allowed (<strong>letters</strong>, <strong>numbers</strong> and <strong>_</strong>).</li>
<li>The <strong>inputs</strong> of the password and confirm-password field <strong>must match</strong>.</li>
<li>The email field must contain the &ldquo;<strong>@</strong>&rdquo; symbol and <strong>at least one</strong> "<strong>.</strong>"(<strong>dot</strong>) after it.</li>
</ul>
<p>If the "Is company?" checkbox is checked, the CompanyInfo fieldset should become <strong>visible</strong> and the Company Number field must also be <strong>validated</strong>, if it isn&rsquo;t checked the Company fieldset should have the style "display: none;" and the <strong>value</strong> of the Company Number field shouldn&rsquo;t matter.</p>
<ul>
<li>The Company Number field must be a number between <strong>1000</strong> and <strong>9999</strong>.</li>
</ul>
<p>Every field with an <strong>incorrect</strong> value when the [Submit] button is <strong>pressed</strong> should have the following style applied border-color: red;, alternatively if it&rsquo;s correct it should have style border: none;. If there are <strong>required fields</strong> with an incorrect value when the [Submit] button is pressed, the div with id="valid" should become <strong>hidden</strong> (<strong>"</strong>display: none;"), <strong>alternatively</strong> if all fields are correct the div should become <strong>visible</strong>.</p>
<h3>Constraints</h3>
<ul>
<li><strong>You are NOT allowed to change the HTML or CSS files provided.</strong></li>
</ul>
<h3>Screenshots</h3>
<h3>Hints</h3>
<ul>
<li>Use addEventListener() or jQuery&rsquo;s on() function to <strong>attach</strong> an <strong>event listener</strong> for the "change" event to the <strong>checkbox</strong>.</li>
<li>All buttons within a &lt;form&gt; automatically work as <strong>submit</strong> buttons, unless their type is <strong>manually</strong> <strong>assigned</strong> to something else, in order to avoid <strong>reloading</strong> <strong>the page</strong> upon <strong>clicking</strong> the [Submit] button you can add the following code in the function that handles the on click event:</li>
<li>The validation for the separate fields can be done using <strong>regex</strong>.</li>
</ul>
<h2>5.&nbsp;&nbsp; DOM Search</h2>
<p>Write a JS function that <strong>generates a form</strong> for managing a list of items and inserts it in an HTML document by given <strong>selector</strong> (e.g. by div id).</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>dom-search.html</p>
</td>
</tr>
<tr>
<td width="664">&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;DOM Search&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.0.min.js"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>integrity=</strong><strong>"sha256-cCueBR6CsyA4/9szpPfrX3s49M9vUU5BgtiJj06wt/s="<br /> </strong><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>add-controls</strong>, .<strong>search-controls </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>width</strong>: 20<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>height</strong>: 2<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>input </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>position</strong>: <strong>absolute</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>left</strong>:6<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>button </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>darkgrey</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>white</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>font-weight</strong>: <strong>bold</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>position</strong>: <strong>absolute</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>left</strong>: 15<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid black</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 0 5<strong>px </strong>0 5<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>result-controls </strong>.<strong>button </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>position</strong>: <strong>relative</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>left</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>font-size</strong>: 50%;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin-right</strong>:1<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>bottom</strong>: 3<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>li </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>list-style-type</strong>: <strong>none</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"content"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"</strong><strong>dom</strong><strong>-search</strong><strong>.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <em>domSearch</em>(<strong>"#content"</strong>,<strong>false</strong>);<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>dom-search.js</p>
</td>
</tr>
<tr>
<td width="664">
<p><strong>function </strong><em>domSearch</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Your function will receive <strong>two arguments</strong> &ndash; the <strong>first</strong> is a <strong>selector</strong> to an HTML element, the <strong>second</strong> is a <strong>Boolean value</strong>, indicating whether the search function is <strong>case-sensitive</strong>. If set to true, searches are case sensitive, if set to false, or not set, searches ignore casing.</p>
<p>The user must be able to:</p>
<ul>
<li>Add a new item with specified string content.</li>
<li>Delete an existing element.</li>
<li>Search for all elements containing a given string.</li>
</ul>
<p>Each of the controls must be in a separate div. Place the add controls inside a div with a class add-controls, and provide a label with the text &ldquo;Enter text:&rdquo;, an <strong>empty input field</strong> and an anchor with the class button applied to it. The anchor acts as an <strong>add button</strong> and when the user presses it, a <strong>new item must be added to the list</strong>, using the string in the <strong>input field</strong> as its <strong>name</strong>.</p>
<p>Place the search controls inside a div with a class search-controls, and provide a label with the text "<strong>Search:</strong>" and an empty input field. When the user starts typing, the list of items should display <strong>only the items</strong> that <strong>contain</strong> the given string. The search <strong>is case-sensitive only if specified with an argument</strong>. When nothing is entered, the list will contain all elements.</p>
<p>Place the result controls inside a div with a class result-controls and in a list of class items-list. Each element has the class list-item. When the list is filtered with a search, all elements that need to be left out must be applied a style of display:none;. Don&rsquo;t forget to <strong>remove the style</strong> after the search string is <strong>removed</strong>!</p>
<p>Every element is composed of an anchor with inner text "X" functioning as a <strong>delete button</strong> and its name wrapped in a &lt;strong&gt; tag. The anchor has the class button. When the button is clicked, the element is <strong>deleted</strong> from the list.</p>
<h3>Screenshots</h3>
<h3>Hints</h3>
<p>Take a look at the following screenshot &ndash; it contains the HTML hierarchy for the form you see in the previous images. Note the last three elements in the list are set to style display:none;, which will hide them from view.</p>
<h2>6.&nbsp;&nbsp; *Calendar</h2>
<p>Write a program that <strong>generates</strong> a monthly calendar by given date. It should be formatted as an <strong>HTML table</strong> with a <strong>caption</strong> for the month and year and headings for each column for the days of the week. The current date must be <strong>highlighted</strong> with a <strong>different style</strong> than the rest of the table cells.</p>
<h3>Screenshots</h3>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<p>&nbsp;</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>calendar.html</p>
</td>
</tr>
<tr>
<td width="664">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Calendar&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.0.min.js"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>integrity=</strong><strong>"sha256-cCueBR6CsyA4/9szpPfrX3s49M9vUU5BgtiJj06wt/s="<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>table</strong>, <strong>th</strong>, <strong>td </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid black</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 0.25<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border-collapse</strong>: <strong>collapse</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border-spacing</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>th</strong>, <strong>td </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>width</strong>: 2.5<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .<strong>today </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>orange</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>white</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"content"</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"</strong><strong>calendar</strong><strong>.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>window</strong>.onload = <strong>function</strong>(){<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>calendar</em>([15,1,2017]);<br /> &nbsp;&nbsp;&nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>calendar.js</p>
</td>
</tr>
<tr>
<td width="664">
<p><strong>function </strong><em>calendar</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>Your script needs to insert the generated calendar in the #content div. The resulting table should have the following format:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>HTML</p>
</td>
</tr>
<tr>
<td width="664">
<p>&lt;<strong>table</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>caption</strong>&gt;January 2017&lt;/<strong>caption</strong>&gt; <em>&lt;!-- Table caption --&gt;<br /> &nbsp;&nbsp;&nbsp; </em>&lt;<strong>tbody</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>th</strong>&gt;Mon&lt;/<strong>th</strong>&gt; <em>&lt;!-- Heading --&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </em>&hellip;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;&lt;/<strong>td</strong>&gt; <em>&lt;!-- Empty element --&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </em>&hellip;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td</strong>&gt;1&lt;/<strong>td</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &hellip;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>td </strong><strong>class=</strong><strong>"today"</strong>&gt;15&lt;/<strong>td</strong>&gt; <em>&lt;!-- Current date is highlighted --&gt;<br /> &nbsp;&nbsp;&nbsp; </em>&lt;/<strong>tr</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &hellip;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>tbody</strong>&gt;<br /> &lt;/<strong>table</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>Your function will receive an array of three numbers representing a date as follows: [day, month, year]</p>
<h3>Requirements</h3>
<ul>
<li>Current <strong>month</strong> and <strong>year</strong> are listed in a &lt;caption&gt; element with the month displayed as a <strong>full capitalized name</strong> and the <strong>year</strong> with <strong>all digits</strong>;</li>
<li>The <strong>first row</strong> contains <strong>headings</strong> for the <strong>days</strong> <strong>of the week</strong>, <strong>shortened</strong> to <strong>3 letters</strong>: <strong>Mon</strong>, <strong>Tue</strong>, <strong>Wed</strong>, etc.;</li>
<li>Each week is a complete row &ndash; <strong>pad</strong> the week with <strong>empty cells</strong> (empty string as cell content) if the month <strong>doesn&rsquo;t start on a Monday</strong> or <strong>end on a Sunday</strong>;</li>
<li>The table should contain <strong>only as many rows as needed</strong> &ndash; some months may need 6 weeks, others just 5.</li>
</ul>
<h3>Hints</h3>
<ul>
<li>JavaScript has a built-in Date object, which can be used to construct a date with arguments and then extract the current day of the week using the getDay() You can familiarize yourself with the object properties here: <a href="http://www.w3schools.com/jsref/jsref_obj_date.asp">http://www.w3schools.com/jsref/jsref_obj_date.asp</a></li>
<li>Try setting the day of the <strong>month</strong> to <strong>0</strong> and see what the result will be.</li>
<li>Notice that the passed in arguments in the example <strong>[15, 1, 2017]</strong> correspond to <strong>15<sup>th</sup> January 2017</strong></li>
</ul>
<h2>7.&nbsp;&nbsp; **Wiki Parser</h2>
<p>You are tasked by Wikipedia to write a JS program that parses text according to their internal markup in the browser. Your program will receive a <strong>selector</strong> to a <strong>paragraph</strong> of text and has to scan it for special symbol combinations that denote specific style for the text that is enclosed in them. For instance, text surrounded by double single quotes (''text'') must be displayed in italics. Look bellow for a full list of features.</p>
<h3>Screenshots</h3>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>wiki-parser.html</p>
</td>
</tr>
<tr>
<td width="664">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Wiki Parser&lt;/<strong>title</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"https://code.jquery.com/jquery-3.1.0.min.js"<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>integrity=</strong><strong>"sha256-cCueBR6CsyA4/9szpPfrX3s49M9vUU5BgtiJj06wt/s="<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>crossorigin=</strong><strong>"anonymous"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>p </strong><strong>id=</strong><strong>"wiki"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;=Document title=<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ==First segment==<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; '''bold 1''' word ''italics 1'' '''bold2'''<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [[hyper first]] '''Bold three''' ''italics2'''<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; word [[hyper2]] [[hyperlink2|with Label]]<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ==Second segment==<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ===Third segment===<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; word '''word'''[[pipe|bomb]]<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>p</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"</strong><strong>wiki-parser</strong><strong>.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>window</strong>.onload = <strong>function</strong>(){<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>wikiParser</em>(<strong>'#wiki'</strong>);<br /> &nbsp;&nbsp;&nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="664">
<tbody>
<tr>
<td width="664">
<p>wiki-parser.js</p>
</td>
</tr>
<tr>
<td width="664">
<p><strong>function </strong><em>wikiParser</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>Your function will receive a selector to an HTML element.</p>
<h3>Markup</h3>
<p>The following symbols must be recognized and parsed:</p>
<ul>
<li>''text'' becomes &lt;i&gt;text&lt;/i&gt; (two single quotes)</li>
<li>'''text''' becomes &lt;b&gt;text&lt;/b&gt; (three single quotes)</li>
<li>=text=, ==text== and ===text=== become &lt;h1&gt;text&lt;/h1&gt;, &lt;h2&gt;text&lt;/h2&gt; and &lt;h3&gt;text&lt;/h3&gt;</li>
<li>[[link]] becomes an anchor to /wiki/link with the same text, &lt;a href="/wiki/link"&gt;link&lt;/a&gt;</li>
<li>[[link|Text]] becomes an anchor to /wiki/link with the argument after the pipe as text, &lt;a&nbsp;href="/wiki/link"&gt;Text&lt;/a&gt;</li>
</ul>
<p>Note all resulting hyperlinks are relative to /wiki</p>
<h3>Constraints</h3>
<ul>
<li>There will be no overlapping markup, i.e. there won&rsquo;t be bold text inside a heading or a link</li>
<li>All hyperlinks will only consist of valid characters</li>
</ul>