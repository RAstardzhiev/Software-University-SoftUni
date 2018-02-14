<h1>Exercises: DOM Manipulation</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/641/">https://judge.softuni.bg/Contests/641/</a> .</p>
<h2>1.&nbsp;&nbsp; Subtraction</h2>
<p>A HTML page holds <strong>two text fields</strong> "firstNumber" and "secondNumber". Write a JS function to <strong>subtract</strong> the values from these text fields and display the result in a div named "result".</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>subtract.html</p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Subtraction&lt;/<strong>title</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"wrapper"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"firstNumber" </strong><strong>value=</strong><strong>"13.33" </strong><strong>disabled</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"secondNumber" </strong><strong>value=</strong><strong>"22.18" </strong><strong>disabled</strong>&gt;<br /> <br /> &nbsp;&nbsp;&nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"result"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script </strong><strong>src=</strong><strong>"subtract.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>window</strong>.onload = <strong>function </strong>() {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>subtract</em>();<br /> &nbsp;&nbsp;&nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>It comes together with the following <strong>JavaScript</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>subtract.js</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>function </strong><em>subtract</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>Implement the above to provide the following functionality:</p>
<ul>
<li>Your function should take the values of "<strong>firstNumber</strong>" and "<strong>secondNumber</strong>", <strong>convert</strong> them to numbers, <strong>subtract</strong> the second number from the first and then write the result in the <strong>&lt;div&gt;</strong> with <strong>id="result"</strong></li>
<li>Your function should be able to work with <strong>any 2 numbers</strong> in the inputs, not only the ones given in the example.</li>
</ul>
<p>Submit in the judge the JS code (implementation) of the above function. It may hold other functions in its body.</p>
<h3>Example</h3>
<h3>Hints</h3>
<p>We see that the <strong>textboxes</strong> and <strong>div</strong> have <strong>id</strong> attributes on them.</p>
<p>We can take the numbers directly from the input field by using the <strong>getElementById() </strong>function. After we have taken the elements from the DOM it&rsquo;s time to do the actual work. We get the values of the two <strong>textboxes</strong>, the value of a textbox as one would expect is <strong>text</strong>, in order to get a <strong>number</strong> we need to use a function to <strong>parse</strong> <strong>them</strong>.</p>
<p>All that&rsquo;s left now is to write the result in the div. We use the same function to get the <strong>result </strong>element by id and change it&rsquo;s <strong>text content</strong> to the resulting <strong>subtraction.</strong></p>
<p>Our code is ready for submitting now, paste the contents of the <strong>.js</strong> file in the judge.</p>
<h2>2.&nbsp;&nbsp; Fill Dropdown</h2>
<p>Your task is to take values from <strong>input</strong> fields with <strong>id</strong>&rsquo;s <strong>&ldquo;newItemText&rdquo; </strong>and <strong>&ldquo;newItemValue&rdquo; </strong>and create and append an <strong>&lt;option&gt; </strong>to the &lt;select&gt; with <strong>id</strong> <strong>&ldquo;menu&rdquo;.</strong></p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>dropdown.html</p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>title</strong>&gt;Fill Dropdown&lt;/<strong>title</strong>&gt;</p>
&nbsp;&nbsp;&nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"dropdown.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>h1</strong>&gt;Dropdown Menu&lt;/<strong>h1</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>select </strong><strong>id=</strong><strong>"menu"</strong>&gt;&lt;/<strong>select</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"newItemText"</strong>&gt;Text: &lt;/<strong>label</strong>&gt;&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"newItemText" </strong>/&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"newItemValue"</strong>&gt;Value: &lt;/<strong>label</strong>&gt;&lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"newItemValue" </strong>/&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Add" </strong><strong>onclick=</strong><strong>"</strong><em>addItem</em>()<strong>"</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</td>
</tr>
</tbody>
</table>
<p>Again you should create a separate <strong>js</strong> file called <strong>dropdown.js. </strong>In it you should have the following function</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>dropdown.js</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>function </strong><em>addItem</em>() {<br /> &nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<h3>Hints</h3>
<ul>
<li>Your function should take the values of <strong>newItemText</strong> and <strong>newItemValue</strong>. After that you should create a new <strong>option </strong>element and set it&rsquo;s <strong>textContent</strong> and it&rsquo;s <strong>value</strong> to the newly taken ones.</li>
<li>Once you have done all of that you should <strong>append</strong> the newly created <strong>option</strong> as a <strong>child</strong> to the select item with id <strong>&ldquo;menu&rdquo;.</strong></li>
<li>Finally you should <strong>clear</strong> the value of the two <strong>input</strong></li>
</ul>
<h2>3.&nbsp;&nbsp; Accordion</h2>
<p>An <strong>html</strong> file is given and your task is to show <strong>more</strong>/show <strong>less</strong> information by clicking a <strong>button </strong>(it is not an actual button, but a <strong>span</strong> that has an <strong>onlick</strong> event attached to it). When <strong>More</strong> link is clicked, it <strong>reveals</strong> the contents of a <strong>hidden</strong> div and change the text of the link to <strong>Less</strong>. When the same link is clicked <strong>again</strong> (now reading Less), <strong>hide</strong> the div and <strong>change</strong> the text of the link back. Link action should be <strong>toggleable</strong> (you should be able to click the button infinite amount of times).</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="738">
<tbody>
<tr>
<td width="738">
<p>accordion.html</p>
</td>
</tr>
<tr>
<td width="738">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Accordion&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>#accordion </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>border</strong>: 1<strong>px solid black</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>inline-block</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>width</strong>: 400<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>#accordion p </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin</strong>: 1<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; .<strong>button </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>float</strong>: <strong>right</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#5555ff</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 0.1<strong>em </strong>1<strong>em </strong>0.1<strong>em </strong>1<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>white</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>cursor</strong>: <strong>pointer</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>#extra </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>none</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; .<strong>head </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#ccccff</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 1<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"accordion"</strong>&gt;<br /> &nbsp; &lt;<strong>div </strong><strong>class=</strong><strong>"head"</strong>&gt;DOM Manipulations Exercise &lt;<strong>span </strong><strong>class=</strong><strong>"button" </strong><strong>onclick=</strong><strong>"</strong><em>toggle</em>()<strong>"</strong>&gt;More&lt;/<strong>span</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"extra"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>p</strong>&gt;Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.&lt;/<strong>p</strong>&gt;<br /> &nbsp; &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>script</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>function </strong><em>toggle</em>() {<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <em>// </em><strong><em>TODO<br /> &nbsp;&nbsp;&nbsp; </em></strong>}<br /> &nbsp; &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<h3>Hints</h3>
<ul>
<li>To <strong>change</strong> the text content of a button you could use <strong>getElementsByClassName</strong>. Which however returns a <strong>collection</strong> and we need only <strong>one</strong> element from it so the correct way is to <strong>use</strong> it like this: <strong>getElementsByClassName</strong>(&lsquo;button&rsquo;)[0] and it will return the needed span element.</li>
<li>After that we should change the <strong>display style</strong> of the div with id &ldquo;<strong>extra</strong>&rdquo;. If the display style is &ldquo;<strong>none</strong>&rdquo; we should <strong>change</strong> it to &ldquo;<strong>block</strong>&rdquo; and the <strong>opposite</strong>.</li>
<li>Alongside all of this we should <strong>change</strong> the text content of the <strong>button</strong> to Less/More.</li>
</ul>
<h2>4.&nbsp;&nbsp; Sections</h2>
<p>You will receive an array of strings. For each string, create a <strong>div</strong> with a <strong>paragraph</strong> with the <strong>string</strong> in it. Each paragraph is initially <strong>hidden (display:none)</strong>. Add a <strong>click</strong> event listener to <strong>each div</strong> that <strong>displays</strong> the hidden paragraph. Finally you should <strong>append</strong> all divs to the element with id &ldquo;<strong>content</strong>&rdquo;.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>sections.html</p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Sections&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>#content </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>width</strong>: 1000<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>#content div </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>float</strong>: <strong>left</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>width</strong>: 300<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>height</strong>: 300<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin</strong>: 2<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#5555ff</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>text-align</strong>: <strong>center</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>#content div p </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>white</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin</strong>: 6<strong>em </strong>3<strong>em </strong>6<strong>em </strong>3<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"content"</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>body </strong><strong>onload=</strong><strong>"</strong><em>create</em>([<strong>'Section 1'</strong>, <strong>'Section 2'</strong>, <strong>'Section 3'</strong>, <strong>'Section 4'</strong>]);<strong>"</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp; <strong>function </strong><em>create</em>(sentences) {<br /> &nbsp;&nbsp;&nbsp; // TODO:<br /> &nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<p>&nbsp;&agrave;</p>
<h2>5.&nbsp;&nbsp; Notification</h2>
<p>Write a JS function that receives a string <strong>message</strong> and <strong>displays</strong> it inside a div with id "<strong>notification</strong>" for 2 seconds. The div starts <strong>hidden</strong> and when the function is called, <strong>reveal</strong> it. After 2 seconds, <strong>hide</strong> the div. In the example document, a notification is shown when you click the button.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>notification.html</p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Notification&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>body </strong>{ <strong>width</strong>: 600<strong>px</strong>; <strong>text-align</strong>: <strong>center</strong>; }<br /> &nbsp;&nbsp;&nbsp; .<strong>header </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background-color</strong>: <strong>#5555ff</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>white</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>position</strong>: <strong>relative</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>left</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>top</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 0.5<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>#container </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>position</strong>: <strong>relative</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; .<strong>post </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin</strong>: 48<strong>px</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>text-align</strong>: <strong>left</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>#notification </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>float</strong>: <strong>right</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>background</strong>: <strong>#119911</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>color</strong>: <strong>#ffffff</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>padding</strong>: 0.5<strong>em </strong>2<strong>em </strong>0.5<strong>em </strong>2<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>margin</strong>: 1<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>none</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>position</strong>: <strong>absolute</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>top</strong>: 0;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>right</strong>: 0;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body</strong>&gt;<br /> &lt;<strong>div </strong><strong>id=</strong><strong>"container"</strong>&gt;<br /> &nbsp; &lt;<strong>header </strong><strong>class=</strong><strong>"header"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>h1</strong>&gt;Welcome to our site&lt;/<strong>h1</strong>&gt;<br /> &nbsp; &lt;/<strong>header</strong>&gt;<br /> &nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"content"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>article </strong><strong>class=</strong><strong>"post"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>p</strong>&gt;Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.&lt;/<strong>p</strong>&gt;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;<strong>p</strong>&gt;Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.&lt;/<strong>p</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;/<strong>article</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>button </strong><strong>onclick=</strong><strong>"</strong><em>notify</em>(<strong>'Something happened!'</strong>)<strong>"</strong>&gt;Get notified&lt;/<strong>button</strong>&gt;<br /> &nbsp; &lt;/<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>div </strong><strong>id=</strong><strong>"notification"</strong>&gt;&lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>script</strong>&gt;<br /> &nbsp; <strong>function </strong><em>notify</em>(message) {<br /> &nbsp;&nbsp;&nbsp; // TODO:<br /> &nbsp; }<br /> &lt;/<strong>script</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<p>When we click the &ldquo;Get notified&rdquo; <strong>button</strong> a div appears in our upper-right corner. It should <strong>disappear</strong> in 2 seconds.</p>
<h2>6.&nbsp;&nbsp; Time Converter</h2>
<p>Create a JS app to convert between diferent time units. Your task is to add a <strong>click</strong> event listener to <strong>all</strong> buttons. When a button is <strong>clicked</strong>, read the <strong>corresponding</strong> input field and <strong>convert</strong> the value to the <strong>three other</strong> units of time and <strong>display</strong> it in the input fields.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>timeConverter.html</p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Time Converter&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"timeConverter.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>label</strong>, <strong>input </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>inline-block</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>width</strong>: 5<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp;&nbsp;&nbsp; <strong>label </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>text-align</strong>: <strong>right</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body </strong><strong>onload=</strong><strong>"</strong><em>attachEventsListeners</em>()<strong>"</strong>&gt;<br /> &lt;<strong>h1</strong>&gt;Time Converter&lt;/<strong>h1</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"days"</strong>&gt;Days: &lt;/<strong>label</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"days"</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>id=</strong><strong>"daysBtn" </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Convert"</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"hours"</strong>&gt;Hours: &lt;/<strong>label</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"hours"</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>id=</strong><strong>"hoursBtn" </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Convert"</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"minutes"</strong>&gt;Minutes: &lt;/<strong>label</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"minutes"</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>id=</strong><strong>"minutesBtn" </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Convert"</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"seconds"</strong>&gt;Seconds: &lt;/<strong>label</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"seconds"</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>id=</strong><strong>"secondsBtn" </strong><strong>type=</strong><strong>"button" </strong><strong>value=</strong><strong>"Convert"</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>You should have the following <strong>timeConverter.js</strong> file:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>timeConverter.js</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>function </strong><em>attachEventsListeners</em>() {<br /> &nbsp; <em>// </em><strong><em>TODO: attach click events to all buttons<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<p>One day is equal to 24 hours/1440 minutes/86400 seconds. Whichever button we <strong>click</strong> the input fields should change depending on the added value on the left. (If we make it 48 hours and click convert the days field should change to 2 and etc.).</p>
<h2>7.&nbsp;&nbsp; * Distance Converter</h2>
<p>Your task is to convert from <strong>one</strong> distance unit to <strong>another</strong> by adding a <strong>click</strong> event listener to a button. When it is clicked, <strong>read</strong> the value in the input field, <strong>get</strong> the selected option from the input and output units drop downs and <strong>calculate</strong> and <strong>display</strong> the converted value in the disabled output field.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following <strong>HTML</strong> code:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>distanceConverter.html</p>
</td>
</tr>
<tr>
<td width="696">
<p>&lt;!DOCTYPE <strong>html</strong>&gt;<br /> &lt;<strong>html </strong><strong>lang=</strong><strong>"en"</strong>&gt;<br /> &lt;<strong>head</strong>&gt;<br /> &nbsp; &lt;<strong>meta </strong><strong>charset=</strong><strong>"UTF-8"</strong>&gt;<br /> &nbsp; &lt;<strong>title</strong>&gt;Distance Converter&lt;/<strong>title</strong>&gt;<br /> &nbsp; &lt;<strong>script </strong><strong>src=</strong><strong>"distanceConverter.js"</strong>&gt;&lt;/<strong>script</strong>&gt;<br /> &nbsp; &lt;<strong>style</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; <strong>label</strong>, <strong>input </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>display</strong>: <strong>inline-block</strong>;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>width</strong>: 5<strong>em</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> <br /> &nbsp;&nbsp;&nbsp; <strong>label </strong>{<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>text-align</strong>: <strong>right</strong>;<br /> &nbsp;&nbsp;&nbsp; }<br /> &nbsp; &lt;/<strong>style</strong>&gt;<br /> &lt;/<strong>head</strong>&gt;<br /> &lt;<strong>body </strong><strong>onload=</strong><strong>"</strong><em>attachEventsListeners</em>()<strong>"</strong>&gt;<br /> &lt;<strong>h1</strong>&gt;Distance Converter&lt;/<strong>h1</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"inputDistance"</strong>&gt;From:&lt;/<strong>label</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"inputDistance"</strong>&gt;<br /> &nbsp; &lt;<strong>select </strong><strong>id=</strong><strong>"inputUnits"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"km"</strong>&gt;Kilometers&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"m"</strong>&gt;Meters&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"cm"</strong>&gt;Centimeters&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"mm"</strong>&gt;Millimeters&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"mi"</strong>&gt;Miles&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"yrd"</strong>&gt;Yards&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"ft"</strong>&gt;Feet&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"in"</strong>&gt;Inches&lt;/<strong>option</strong>&gt;<br /> &nbsp; &lt;/<strong>select</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"button" </strong><strong>id=</strong><strong>"convert" </strong><strong>value=</strong><strong>"Convert"</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;<strong>div</strong>&gt;<br /> &nbsp; &lt;<strong>label </strong><strong>for=</strong><strong>"outputDistance"</strong>&gt;To:&lt;/<strong>label</strong>&gt;<br /> &nbsp; &lt;<strong>input </strong><strong>type=</strong><strong>"text" </strong><strong>id=</strong><strong>"outputDistance" </strong><strong>disabled=</strong><strong>"disabled"</strong>&gt;<br /> &nbsp; &lt;<strong>select </strong><strong>id=</strong><strong>"outputUnits"</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"km"</strong>&gt;Kilometers&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"m"</strong>&gt;Meters&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"cm"</strong>&gt;Centimeters&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"mm"</strong>&gt;Millimeters&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"mi"</strong>&gt;Miles&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"yrd"</strong>&gt;Yards&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"ft"</strong>&gt;Feet&lt;/<strong>option</strong>&gt;<br /> &nbsp;&nbsp;&nbsp; &lt;<strong>option </strong><strong>value=</strong><strong>"in"</strong>&gt;Inches&lt;/<strong>option</strong>&gt;<br /> &nbsp; &lt;/<strong>select</strong>&gt;<br /> &lt;/<strong>div</strong>&gt;<br /> &lt;/<strong>body</strong>&gt;<br /> &lt;/<strong>html</strong>&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>You should have the following <strong>distanceConverter.js</strong> file:</p>
<table width="696">
<tbody>
<tr>
<td width="696">
<p>distanceConverter.js</p>
</td>
</tr>
<tr>
<td width="696">
<p><strong>function </strong><em>attachEventsListeners</em>() {<br /> &nbsp; <em>// </em><strong><em>TODO: attach click event to convert button<br /> </em></strong>}</p>
</td>
</tr>
</tbody>
</table>
<p>Multiply the incoming distance by the following conversion rates to convert to meters. Divide to convert from meters to the required output unit.</p>
<p>1 km = 1000 m</p>
<p>1 m = 1 m</p>
<p>1 cm = 0.01 m</p>
<p>1 mm = 0.001 m</p>
<p>1 mi = 1609.34 m</p>
<p>1 yrd = 0.9144 m</p>
<p>1 ft = 0.3048 m</p>
<p>1 in = 0.0254 m</p>
<h3>Example</h3>
<h3>Hint</h3>
<p>To see which option is selected, read the properties of its parent: value gives you the value of the selected option (as displayed in the HTML), selectedIndex gives you the 0-based index of the selected option. E.g. if miles are selected, #inputUnits.value is "<strong>mi</strong>", #inputUnits.selectedIndex is <strong>4</strong>. Option text is irrelevant.</p>