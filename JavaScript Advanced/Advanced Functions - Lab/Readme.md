<h1>Lab: Advanced Functions</h1>
<p>Problems for in-class lab for the
    <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/330/">https://judge.softuni.bg/Contests/330/</a>.</p>
<h2>1.&nbsp;&nbsp; Aggregates</h2>
<p>Write a JS program that uses a
    <strong>reducer</strong> function to
    <strong>display</strong> information about an
    <strong>input array</strong>.</p>
<h3>Input</h3>
<p>You will receive an
    <strong>array</strong> of
    <strong>numeric </strong>values.</p>
<h3>Output</h3>
<p>The output should be the
    <strong>printed</strong> on the console. Display the
    <strong>sum</strong> of all elements in the array, the value of the
    <strong>smallest</strong>, the value of the
    <strong>biggest</strong>, the
    <strong>product</strong> of all elements and a string of all elements
    <strong>joined</strong> together.</p>
<h3>Examples</h3>
<table width="696">
    <tbody>
        <tr>
            <td width="302">
                <p>Sample Input</p>
            </td>
            <td width="302">
                <p>Output</p>
            </td>
        </tr>
        <tr>
            <td width="302">
                <p>[2,3,10,5]</p>
            </td>
            <td width="302">
                <p>Sum = 20</p>
                <p>Min = 2</p>
                <p>Max = 10</p>
                <p>Product = 300</p>
                <p>Join = 23105</p>
            </td>
        </tr>
        <tr>
            <td width="302">
                <p>[5, -3, 20, 7, 0.5]</p>
            </td>
            <td width="302">
                <p>Sum = 29.5</p>
                <p>Min = -3</p>
                <p>Max = 20</p>
                <p>Sum = -1050</p>
                <p>Join = 5-32070.5</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>2.&nbsp;&nbsp; Currency Format</h2>
<p>Write a higher-order JS function that fixes some of the parameters of another function. Your program will receive a function
    that takes 4 parameters and returns a formatted string (a monetary value with currency symbol). Your task is to return
    another function that only takes one parameter and returns the same formatted string.</p>
<p>This is the function you will receive:</p>
<table width="695">
    <tbody>
        <tr>
            <td width="695">
                <p>currencyFormatter</p>
            </td>
        </tr>
        <tr>
            <td width="695">
                <p>function currencyFormatter(separator, symbol, symbolFirst, value) {</p>
                <p>&nbsp;&nbsp;&nbsp; let result = Math.trunc(value) + separator;</p>
                <p>&nbsp;&nbsp;&nbsp; result += value.toFixed(2).substr(-2,2);</p>
                <p>&nbsp;&nbsp;&nbsp; if (symbolFirst) return symbol + ' ' + result;</p>
                <p>&nbsp;&nbsp;&nbsp; else return result + ' ' + symbol;</p>
                <p>}</p>
            </td>
        </tr>
    </tbody>
</table>
<p>Set the following parameters to fixed values:</p>
<p>separator: ","</p>
<p>symbol: "$"</p>
<p>symbolFirst: true</p>
<p>The final parameter value is the one that the returned function will receive.</p>
<h3>Input</h3>
<p>You will receive a
    <strong>function</strong> parameter.</p>
<h3>Output</h3>
<p>You need to
    <strong>return a function</strong> that takes one parameter &ndash; value.</p>
<h3>Examples</h3>
<table width="695">
    <tbody>
        <tr>
            <td width="695">
                <p>Sample Input</p>
            </td>
        </tr>
        <tr>
            <td width="695">
                <p>let dollarFormatter = result(currencyFormatter);</p>
                <p>console.log(dollarFormatter(5345));&nbsp;&nbsp;
                    <em>// $ 5345,00</em>
                </p>
                <p>console.log(dollarFormatter(3.1429));
                    <em>// $ 3,14</em>
                </p>
                <p>console.log(dollarFormatter(2.709));&nbsp;
                    <em>// $ 2,71</em>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<h2>3.&nbsp;&nbsp; Command Processor</h2>
<p>Write a JS program that keeps a string
    <strong>inside it&rsquo;s context</strong> and can execute different
    <strong>commands</strong> that modify or output the string on the console.</p>
<p>append(str) &ndash; add
    <strong>str</strong> to the end of the internal string</p>
<p>removeStart(n) &ndash;
    <strong>remove</strong> the
    <strong>first</strong>
    <strong>n</strong> characters from the string,
    <strong>n</strong> is an integer</p>
<p>removeEnd(n) &ndash;
    <strong>remove</strong> the
    <strong>last n</strong> characters from the string,
    <strong>n</strong> is an integer</p>
<p>print &ndash;
    <strong>output</strong> the stored string to the
    <strong>console</strong>
</p>
<h3>Input</h3>
<p>You will receive an
    <strong>array</strong> of
    <strong>strings</strong>. Each element is a command that may be a single word or contain an argument, separated by space.</p>
<h3>Output</h3>
<p>Whenever you receive the command
    <strong>print</strong>, output should be the
    <strong>printed</strong> on the console. Any other operations are carried onto the
    <strong>internal</strong> storage of the function.</p>
<h3>Examples</h3>
<table width="696">
    <tbody>
        <tr>
            <td width="302">
                <p>Sample Input</p>
            </td>
            <td width="302">
                <p>Output</p>
            </td>
        </tr>
        <tr>
            <td width="302">
                <p>['append hello',</p>
                <p>&nbsp;'append again',</p>
                <p>&nbsp;'removeStart 3',</p>
                <p>&nbsp;'removeEnd 4',</p>
                <p>&nbsp;'print']</p>
            </td>
            <td width="302">
                <p>loa</p>
            </td>
        </tr>
        <tr>
            <td width="302">
                <p>['append 123',</p>
                <p>&nbsp;'append 45',</p>
                <p>&nbsp;'removeStart 2',</p>
                <p>&nbsp;'removeEnd 1',</p>
                <p>&nbsp;'print']</p>
            </td>
            <td width="302">
                <p>34</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>4.&nbsp;&nbsp; Max Element</h2>
<p>Write a JS program that takes an
    <strong>array</strong> of
    <strong>numeric elements</strong> as input and
    <strong>returns</strong> the
    <strong>largest</strong> element of the array.</p>
<h3>Input</h3>
<p>You will receive an
    <strong>array</strong> of
    <strong>numbers</strong>.</p>
<h3>Output</h3>
<p>The
    <strong>output</strong> should be the
    <strong>return</strong> value of your function. It represents the
    <strong>largest element</strong> of the array.</p>
<h3>Examples</h3>
<table width="696">
    <tbody>
        <tr>
            <td width="302">
                <p>Sample Input</p>
            </td>
            <td width="302">
                <p>Output</p>
            </td>
        </tr>
        <tr>
            <td width="302">
                <p>[10, 20, 5]</p>
            </td>
            <td width="302">
                <p>20</p>
            </td>
        </tr>
        <tr>
            <td width="302">
                <p>[1, 44, 123, 33]</p>
            </td>
            <td width="302">
                <p>123</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>5.&nbsp;&nbsp; Next Article</h2>
<p>Write a JS program that sequentially
    <strong>displays articles</strong> on a web page when the user
    <strong>clicks</strong> a button. You will receive an
    <strong>array of strings</strong> that will initialize the program. You need to return a function that keeps the initial array
    in its closure and every time it&rsquo;s called, it takes the first element from the array and displays it on the web
    page, inside a div with ID "
    <strong>content</strong>". If there are no more elements left, your function should do nothing.</p>
<h3>HTML and JavaScript Code</h3>
<p>You are given the following
    <strong>HTML</strong> code:</p>
<table width="695">
    <tbody>
        <tr>
            <td width="695">
                <p>article.html</p>
            </td>
        </tr>
        <tr>
            <td width="695">
                <p>&lt;!DOCTYPE
                    <strong>html</strong>&gt;
                    <br /> &lt;
                    <strong>html </strong>
                    <strong>lang=</strong>
                    <strong>"en"</strong>&gt;
                    <br /> &lt;
                    <strong>head</strong>&gt;
                    <br /> &nbsp; &lt;
                    <strong>meta </strong>
                    <strong>charset=</strong>
                    <strong>"UTF-8"</strong>&gt;
                    <br /> &nbsp; &lt;
                    <strong>title</strong>&gt;Next Article&lt;/
                    <strong>title</strong>&gt;
                    <br /> &nbsp; &lt;
                    <strong>style</strong>&gt;
                    <strong>div</strong>{
                    <strong>width</strong>:600
                    <strong>px</strong>;
                    <strong>text-align</strong>:
                    <strong>center</strong>;
                    <strong>font-size</strong>: 1.5
                    <strong>em</strong>}
                    <strong>article</strong>{
                    <strong>border</strong>: 2
                    <strong>px solid blue</strong>;
                    <strong>padding</strong>: 2
                    <strong>em</strong>;
                    <strong>margin</strong>: 1
                    <strong>em</strong>}&lt;/
                    <strong>style</strong>&gt;
                    <br /> &nbsp; &lt;
                    <strong>script </strong>
                    <strong>src=</strong>
                    <strong>"https://code.jquery.com/jquery-3.1.1.min.js" </strong>
                    <strong>integrity=</strong>
                    <strong>"sha256-hVVnYaiADRTO2PzUGmuLJr8BLUSjGIZsDYGmIJLv2b8=" </strong>
                    <strong>crossorigin=</strong>
                    <strong>"anonymous"</strong>&gt;&lt;/
                    <strong>script</strong>&gt;
                    <br /> &nbsp; &lt;
                    <strong>script </strong>
                    <strong>src=</strong>
                    <strong>"next-article.js"</strong>&gt;&lt;/
                    <strong>script</strong>&gt;
                    <br /> &lt;/
                    <strong>head</strong>&gt;
                    <br /> &lt;
                    <strong>body</strong>&gt;
                    <br /> &lt;
                    <strong>div </strong>
                    <strong>id=</strong>
                    <strong>"content"</strong>&gt;&lt;/
                    <strong>div</strong>&gt;
                    <br /> &lt;
                    <strong>div</strong>&gt;&lt;
                    <strong>button </strong>
                    <strong>onclick=</strong>
                    <strong>"</strong>
                    <strong>
                        <em>showNext</em>
                    </strong>()
                    <strong>"</strong>&gt;Show Next Article&lt;/
                    <strong>button</strong>&gt;&lt;/
                    <strong>div</strong>&gt;
                    <br /> &lt;
                    <strong>script</strong>&gt;
                    <br /> &nbsp; let
                    <strong>
                        <em>articles </em>
                    </strong>=[
                    <br /> &nbsp;&nbsp;&nbsp;
                    <strong>"Cats are the most popular pet in the United States: There are 88 million pet cats and 74 million dogs."</strong>,
                    <br
                    /> &nbsp;&nbsp;&nbsp;
                    <strong>"A group of cats is called a clowder."</strong>,
                    <br /> &nbsp;&nbsp;&nbsp;
                    <strong>"Cats have over 20 muscles that control their ears."</strong>,
                    <br /> &nbsp;&nbsp;&nbsp;
                    <strong>"A cat has been mayor of Talkeetna, Alaska, for 15 years. His name is Stubbs."</strong>,
                    <br /> &nbsp;&nbsp;&nbsp;
                    <strong>"The world's largest cat measured 48.5 inches long."
                        <br /> &nbsp; </strong>];
                    <br /> &nbsp; let
                    <strong>
                        <em>showNext </em>
                    </strong>=
                    <em>getArticleGenerator</em>(
                    <strong>
                        <em>articles</em>
                    </strong>);
                    <br /> &lt;/
                    <strong>script</strong>&gt;
                    <br /> &lt;/
                    <strong>body</strong>&gt;
                    <br /> &lt;/
                    <strong>html</strong>&gt;</p>
            </td>
        </tr>
    </tbody>
</table>
<p>It comes together with the following
    <strong>JavaScript</strong> code:</p>
<table width="695">
    <tbody>
        <tr>
            <td width="695">
                <p>next-article.js</p>
            </td>
        </tr>
        <tr>
            <td width="695">
                <p>
                    <strong>function </strong>
                    <em>getArticleGenerator</em>(articles) {
                    <br /> &nbsp;&nbsp;&nbsp;
                    <em>// </em>
                    <strong>
                        <em>TODO</em>
                    </strong>
                    <br /> }</p>
            </td>
        </tr>
    </tbody>
</table>
<p>Your function will be called automatically, there is
    <strong>no need</strong> to attach any event listeners.</p>
<h3>Input</h3>
<p>You will receive and
    <strong>array</strong> of strings.</p>
<h3>Output</h3>
<p>Return a
    <strong>function</strong> that displays the array elements on the web page.</p>
<h3>Examples</h3>
<p>&nbsp; &nbsp;</p>