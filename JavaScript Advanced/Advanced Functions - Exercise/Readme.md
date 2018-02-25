<h1>Exercises: Functions, Object Composition, Revealing Modules</h1>
<p>Problems for exercises and homework for the
    <a href="https://softuni.bg/courses/javascript-advanced">&ldquo;JavaScript Advanced&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at
    <a href="https://judge.softuni.bg/Contests/299/">https://judge.softuni.bg/Contests/299/</a>.</p>
<h2>1.&nbsp;&nbsp; Sort Array</h2>
<p>Write a function that
    <strong>sorts an array</strong> with
    <strong>numeric</strong> values in
    <strong>ascending</strong> or
    <strong>descending</strong> order, depending on an
    <strong>argument</strong> that&rsquo;s passed to it.</p>
<h3>Input</h3>
<p>You will receive a
    <strong>numeric array</strong> and a
    <strong>string</strong> as arguments to the first function in your code. If the second argument is asc, the array should be sorted
    in
    <strong>ascending order</strong> (smallest values first). If it is desc, then the array is sorted in
    <strong>descending order</strong> (largest first).</p>
<h3>Output</h3>
<p>The output should be the
    <strong>return value</strong> of your function and it is the
    <strong>sorted array</strong>.</p>
<h3>Examples</h3>
<table width="605">
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
                <p>solve([14, 7, 17, 6, 8], 'asc');</p>
            </td>
            <td width="302">
                <p>[6, 7, 8, 14, 17]</p>
            </td>
        </tr>
        <tr>
            <td width="302">
                <p>solve([14, 7, 17, 6, 8], 'desc');</p>
            </td>
            <td width="302">
                <p>[17, 14, 8, 7, 6]</p>
            </td>
        </tr>
    </tbody>
</table>
<h3>Hints</h3>
<p>Arrays in JavaScript are by default sorted alphabetically, which means if we have an array of numbers [3, 1, 2, 10] and we
    call sort() on it, the result will be [1, 10, 2, 3]. You can however pass a
    <strong>sorting criteria</strong> as an argument in the form of a
    <strong>function</strong>. This function can be anonymously defined inline or a named function, or even a variable that holds
    a reference to a function:</p>
<table width="664">
    <tbody>
        <tr>
            <td width="51">
                <p>JavaScript</p>
            </td>
        </tr>
        <tr>
            <td width="51">
                <strong>
                    <em>array</em>
                </strong>.sort(
                <strong>function </strong>(a, b) {
                <br /> &nbsp;&nbsp;&nbsp;
                <em>// </em>
                <strong>
                    <em>TODO
                        <br /> </em>
                </strong>});</td>
        </tr>
    </tbody>
</table>
<p>Let&rsquo;s start by building the body of our main function, which takes
    <strong>two arguments</strong> and returns a sorted array, using the default sorting strategy:</p>
<p>If you test this function, you&rsquo;ll see it uses the ASCII values to sort the objects inside the array. Next we need to
    pass an argument to the sort() function to get the desired result. It will consist of a
    <strong>special function</strong> which takes two arguments (
    <strong>current element</strong> and
    <strong>next element</strong> to be sorted), compares them and
    <strong>returns a value</strong>. If the value is
    <strong>zero</strong>, then they are equal. If it&rsquo;s
    <strong>greater than zero</strong>, the first element is larger. If it&rsquo;s
    <strong>less than zero</strong>, this means the second element is larger. In short, return a positive value to swap elements
    and zero or negative to keep the current order. Let&rsquo;s first implement ascending order:</p>
<p>What we did is define an anonymous function directly in the argument space. Note we could have explicitly written a conditional
    statement, which returns 1 if a is greater than b. However, we know that if this is true, the result of the expression
    above will be positive, so we can use this much shorter version. If we want descending order, all we have to do is swap
    a and b in the expression.</p>
<p>Let&rsquo;s use the functional nature of JavaScript and define the two comparator functions beforehand and assign them to
    variables:</p>
<p>We can now pass either of them to the sorting function, depending on what we need. We&rsquo;ll save those in an object and
    use a string as a key, which would match the input shown in the problem description:</p>
<p>Now whenever we need a new sorting method, we can just define it as a separate function and add it to this object with its
    corresponding key. No further change will be necessary. Finally, we modify our initial call to sort() to receive one
    of the stored functions, depending on the second argument of our main function:</p>
<p>We are ready to submit our solution to the Judge.</p>
<h2>2.&nbsp;&nbsp; Argument Info</h2>
<p>Write a function that displays
    <strong>information</strong> about the
    <strong>arguments</strong> which are passed to it &ndash;
    <strong>type</strong> and
    <strong>value</strong> &ndash; and a
    <strong>summary</strong> about the number of each type.</p>
<h3>Input</h3>
<p>You will receive a series of arguments
    <strong>passed</strong> to your function.</p>
<h3>Output</h3>
<p>Log to the
    <strong>console</strong> the
    <strong>type</strong> and
    <strong>value</strong> of each argument passed in the following format:</p>
<p>{argument type}: {argument value}</p>
<p>Place
    <strong>each</strong> argument description on a
    <strong>new line</strong>. At the end print a
    <strong>tally</strong> with counts for each type in
    <strong>descending order</strong>, each on a
    <strong>new line</strong> in format {type} = {count} If two types have the
    <strong>same count</strong>, use
    <strong>order of appearance</strong>. Don&rsquo;t print anything for types that do not appear in the list of arguments.</p>
<h3>Examples</h3>
<table width="643">
    <tbody>
        <tr>
            <td width="643">
                <p>Sample Input</p>
            </td>
        </tr>
        <tr>
            <td width="643">
                <p>result('cat', 42, function () { console.log('Hello world!'); });</p>
            </td>
        </tr>
        <tr>
            <td width="643">
                <p>Output</p>
            </td>
        </tr>
        <tr>
            <td width="643">
                <p>string: cat</p>
                <p>number: 42</p>
                <p>function: function () { console.log('Hello world!'); }</p>
                <p>string = 1</p>
                <p>number = 1</p>
                <p>function = 1</p>
            </td>
        </tr>
    </tbody>
</table>
<h3>Hints</h3>
<p>JavaScript functions have a special property arguments, which contains all parameters passed to a function, regardless of
    whether you&rsquo;ve specified them in the function declaration, or left the parenthesis empty.</p>
<table width="664">
    <tbody>
        <tr>
            <td width="51">
                <p>JavaScript</p>
            </td>
        </tr>
        <tr>
            <td width="51">
                <p>function myFunc() {</p>
                <p>&nbsp;&nbsp;&nbsp; var firstArgument = arguments[0];</p>
                <p>}</p>
            </td>
        </tr>
    </tbody>
</table>
<p>We can iterate this variable like an array to get access to every parameter in the order in which they were passed and inspect
    them:</p>
<p>We can use an object as an associative array to store the number of each type occurrence. Each type will be a property and
    its value will be the number of times it occurs in the arguments. We can access them just like we would the keys of an
    array:</p>
<p>Since object properties cannot be sorted, and even if they could, different JavaScript implementations iterate the order
    differently, we need to transfer the information to an array of key-value pairs. We could use a Map instead of an object,
    but this cannot be sorted either, so we&rsquo;ll end up with an array in the end anyway.</p>
<p>Note we are pushing an array with two values to the array which needs to be sorted. Later when we implement a sorting function,
    we&rsquo;ll use the second value of the key-value pair &ndash; the number of occurrences. All we need to do after the
    array is sorted is to output the information in the correct format.</p>
<h2>3.&nbsp;&nbsp; Functional Sum</h2>
<p>Write a function that
    <strong>adds</strong> a number passed to it to an
    <strong>internal sum</strong> and returns
    <strong>itself</strong> with its internal sum set to the
    <strong>new value</strong>, so it can be
    <strong>chained</strong> in a functional manner.</p>
<h3>Example</h3>
<table width="664">
    <tbody>
        <tr>
            <td width="338">
                <p>Sample Input</p>
            </td>
            <td width="326">
                <p>Sample Output</p>
            </td>
        </tr>
        <tr>
            <td width="338">
                <p>console.log(add(1));</p>
            </td>
            <td width="326">
                <p>1</p>
            </td>
        </tr>
        <tr>
            <td width="338">
                <p>console.log(add(1)(6)(-3));</p>
            </td>
            <td width="326">
                <p>4</p>
            </td>
        </tr>
    </tbody>
</table>
<h3>Input</h3>
<p>Your function needs to take one
    <strong>numeric</strong>
    <strong>argument</strong>.</p>
<h3>Output</h3>
<p>Your function needs to
    <strong>return</strong> itself with updated context.</p>
<h3>Hints</h3>
<p>Making a function return itself is easy enough, but to keep a sum that&rsquo;s shared across all instances requires some
    effort. You&rsquo;ll need to place it inside a closure and expose just the function. Finally, to get the stored value,
    you&rsquo;ll have to override the built-in toString() method that all JavaScript objects have so that it returns the
    internal sum &ndash; this will allow any other function to access it either for printing or to use it in an expression,
    without being able to modify it. You can attach it directly to your function from inside the closure:</p>
<p>&nbsp;</p>
<p>Note that NodeJS will not implicitly call toString() when you try to log a value to the console. Keep this in mind when testing
    your solution locally.</p>
<h2>4.&nbsp;&nbsp; Personal BMI</h2>
<p>A wellness clinic has contacted you with an offer &ndash; they want you to write for them a program that composes
    <strong>patient charts</strong> and performs some preliminary evaluation of their condition. The data comes in the form of
    <strong>several arguments</strong>, describing a person &ndash; their
    <strong>name</strong>,
    <strong>age</strong>,
    <strong>weight</strong> in kilograms and
    <strong>height</strong> in centimeters. Your program must compose this information into an
    <strong>object</strong> and
    <strong>return</strong> it for further processing.</p>
<p>The patient chart object must contain the following properties:</p>
<ul>
    <li>name</li>
    <li>personalInfo, which is an object holding their age, weight and height as properties</li>
    <li>BMI &ndash; body mass index. You can find information about how to calculate it here:
        <a href="https://en.wikipedia.org/wiki/Body_mass_index">https://en.wikipedia.org/wiki/Body_mass_index</a>
    </li>
    <li>status</li>
</ul>
<p>The status is one of the following:</p>
<ul>
    <li>underweight, for BMI less than 18.5;</li>
    <li>normal, for BMI less than 25;</li>
    <li>overweight, for BMI less than 30;</li>
    <li>obese, for BMI 30 or more;</li>
</ul>
<p>Once the BMI and status are calculated, you can make a recommendation. If the patient is obese, add an additional property
    called recommendation and set it to &ldquo;admission required&rdquo;.</p>
<h3>Input</h3>
<p>Your function needs to take four arguments &ndash; name, age, weight and height</p>
<h3>Output</h3>
<p>Your function needs to
    <strong>return</strong> an
    <strong>object with properties</strong> as described earlier. All numeric values should be
    <strong>rounded</strong> to the nearest whole number. All fields should be named
    <strong>exactly as described</strong>, their order is not important. Look at the sample output for more information.</p>
<table width="664">
    <tbody>
        <tr>
            <td width="253">
                <p>Sample Input</p>
            </td>
            <td width="411">
                <p>Sample Output</p>
            </td>
        </tr>
        <tr>
            <td width="253">
                <p>&ldquo;Peter&rdquo;, 29, 75, 182</p>
            </td>
            <td width="411">
                <p>{ name: 'Peter',</p>
                <p>&nbsp; personalInfo: {</p>
                <p>&nbsp;&nbsp;&nbsp; age: 29,</p>
                <p>&nbsp;&nbsp;&nbsp; weight: 75,</p>
                <p>&nbsp;&nbsp;&nbsp; height: 182</p>
                <p>&nbsp; }</p>
                <p>&nbsp; BMI: 23</p>
                <p>&nbsp; status: 'normal' }</p>
            </td>
        </tr>
        <tr>
            <td width="253">
                <p>&ldquo;Honey Boo Boo&rdquo;, 9, 57, 137</p>
            </td>
            <td width="411">
                <p>{ name: 'Honey Boo Boo', personalInfo: { age: 9, weight: 57, height: 137 }, BMI: 30, status: 'obese', recommendation:
                    'admission required' }</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>5.&nbsp;&nbsp; Vector Math</h2>
<p>Write several functions for preforming
    <strong>calculations</strong> with
    <strong>vectors</strong> in 2D space and collect them all in a
    <strong>single object</strong> (namespace), so they don&rsquo;t pollute the global scope. Implement the following functions:</p>
<ul>
    <li>add(vec1, vec2) &ndash; Addition of two vectors &ndash;</li>
    <li>multiply(vec1, scalar) &ndash; Scalar multiplication &ndash;</li>
    <li>length(vec1) &ndash; Vector length &ndash;</li>
    <li>dot(vec1, vec2) &ndash; Dot product of two vectors &ndash;</li>
    <li>cross(vec1, vec2) &ndash; Cross product of two vectors &ndash;</li>
</ul>
<p>The math-savvy may notice that the given cross product formula results in a scalar, instead of a vector &ndash; we&rsquo;re
    actually only measuring the length of the resulting vector, since cross product is not possible in 2D, it will exist
    purely in the z-dimension. If you don&rsquo;t know what this all means, ignore this paragraph, it&rsquo;s irrelevant
    to the solution.</p>
<h3>Input</h3>
<p>Each separate function in your namespace will be tested with individual values. It must expect
    <strong>one or two</strong>
    <strong>arguments</strong>, as described above, and
    <strong>return</strong> a value. Vectors will be 2D
    <strong>arrays</strong> with format [x, y].</p>
<h3>Output</h3>
<p>Your program needs to
    <strong>return</strong> an object, containing
    <strong>all functions</strong> described above. Each individual function must
    <strong>return</strong> a value, as required. Don&rsquo;t round any values.</p>
<table width="669">
    <tbody>
        <tr>
            <td width="272">
                <p>Sample Input</p>
            </td>
            <td width="113">
                <p>Output</p>
            </td>
            <td width="283">
                <p>Explanation</p>
            </td>
        </tr>
        <tr>
            <td width="272">
                <p>solution.add([1, 1], [1, 0]);</p>
            </td>
            <td width="113">
                <p>[2, 1]</p>
            </td>
            <td width="283">
                <p>[1 + 1, 1 + 0] = [2, 1]</p>
            </td>
        </tr>
        <tr>
            <td width="272">
                <p>solution.multiply([3.5, -2], 2);</p>
            </td>
            <td width="113">
                <p>[7, -4]</p>
            </td>
            <td width="283">
                <p>[3.5 * 2, (-2) * 2] = [7, -4]</p>
            </td>
        </tr>
        <tr>
            <td width="272">
                <p>solution.length([3, -4]);</p>
            </td>
            <td width="113">
                <p>5</p>
            </td>
            <td width="283">
                <p>sqrt(3 * 3 + (-4) * (-4)) = 5</p>
            </td>
        </tr>
        <tr>
            <td width="272">
                <p>solution.dot([1, 0], [0, -1]);</p>
            </td>
            <td width="113">
                <p>0</p>
            </td>
            <td width="283">
                <p>1 * 0 + 0 * (-1) = 0</p>
            </td>
        </tr>
        <tr>
            <td width="272">
                <p>solution.cross([3, 7], [1, 0]);</p>
            </td>
            <td width="113">
                <p>-7</p>
            </td>
            <td width="283">
                <p>3 * 0 &ndash; 7 * 1 = -7</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>6.&nbsp;&nbsp; Breakfast Robot</h2>
<p>
    <em>It&rsquo;s finally the future! Robots take care of everything and man has been freed from the mundane tasks of living.
        There is still work to be done though, since those robots need to be programmed first &ndash; we may have robot chefs,
        but we don&rsquo;t yet have robot software developers.</em>
</p>
<p>Your task is to write the management software for a breakfast chef robot &ndash; it needs to
    <strong>take orders</strong>, keep track of available
    <strong>ingredients</strong> and output an error if something&rsquo;s wrong. Someone else has already installed the cooking instructions,
    so your module needs to
    <strong>plug into</strong> the system and only take care of orders and ingredients. And since this is the future and food is
    printed with nano-particle beams, all ingredients are microelements &ndash;
    <strong>protein</strong>,
    <strong>carbohydrates</strong>,
    <strong>fat</strong> and
    <strong>flavours</strong>. The library of recipes includes the following meals:</p>
<ul>
    <li>Apple &ndash; made with
        <strong>1 carb</strong> and
        <strong>2 flavour</strong>
    </li>
    <li>Coke &ndash; made with
        <strong>10 carb</strong> and
        <strong>20 flavour</strong>
    </li>
    <li>Burger &ndash; made with
        <strong>5 carb</strong>,
        <strong>7 fat</strong> and
        <strong>3 flavour</strong>
    </li>
    <li>Omelet &ndash; made with
        <strong>5 protein</strong>,
        <strong>1 fat</strong> and
        <strong>1 flavour</strong>
    </li>
    <li>Cheverme &ndash; made with
        <strong>10 protein</strong>,
        <strong>10 carb</strong>,
        <strong>10 fat</strong> and
        <strong>10 flavour</strong>
    </li>
</ul>
<p>The robot receives instructions either to restock the supply, cook a meal or report statistics. The input consists of one
    of the following commands:</p>
<ul>
    <li>restock &lt;microelement&gt; &lt;quantity&gt; &ndash; increases the stored quantity of the given microelement</li>
    <li>prepare &lt;recipe&gt; &lt;quantity&gt; &ndash; use the available ingredients to prepare the given meal</li>
    <li>report &ndash; return information about the stored microelements, in the order described below, including zero elements</li>
</ul>
<p>The robot is equipped with a quantum field storage, so it can hold an
    <strong>unlimited quantity</strong> of ingredients, but there is no guarantee there will be enough available to prepare a recipe,
    in which case an
    <strong>error message</strong> should be returned. Their availability is checked in the
    <strong>order</strong> in which they
    <strong>appear</strong> in the recipe, so the error should reflect the first requirement which wasn&rsquo;t met.</p>
<p>Submit a
    <strong>closure</strong> that returns the management function. The management function must take one parameter.</p>
<h3>Input</h3>
<p>Instructions are passed as a
    <strong>string argument</strong> to your management function. It will be called
    <strong>several times</strong> per session, so internal state must be
    <strong>preserved</strong> throughout the entire session.</p>
<h3>Output</h3>
<p>The
    <strong>return</strong> value of each operation is one of the following strings:</p>
<ul>
    <li>Success &ndash; when restocking or completing cooking without errors</li>
    <li>Error: not enough &lt;ingredient&gt; in stock &ndash; when the robot couldn&rsquo;t muster enough microelements</li>
    <li>protein={qty} carbohydrate={qty} fat={qty} flavour={qty} &ndash; when a report is requested, in a single string</li>
</ul>
<h3>Constraints</h3>
<ul>
    <li>Recipes and ingredients in commands will always have valid names.</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="695">
    <tbody>
        <tr>
            <td width="695">
                <p>Sample Execution</p>
            </td>
        </tr>
        <tr>
            <td width="695">
                <p>let manager = solution();</p>
                <p>manager("restock flavour 50");
                    <em>// Success</em>
                </p>
                <p>manager("prepare coke 4");&nbsp;&nbsp;&nbsp;&nbsp;
                    <em>// Error: not enough carbohydrate in stock</em>
                </p>
            </td>
        </tr>
    </tbody>
</table>
<p>&nbsp;</p>
<table width="696">
    <tbody>
        <tr>
            <td width="234">
                <p>Sample Input</p>
            </td>
            <td width="430">
                <p>Sample Output</p>
            </td>
        </tr>
        <tr>
            <td width="234">
                <p>restock carbohydrate 10</p>
                <p>restock flavour 10</p>
                <p>prepare apple 1</p>
                <p>restock fat 10</p>
                <p>prepare burger 1</p>
                <p>report</p>
            </td>
            <td width="430">
                <p>Success</p>
                <p>Success</p>
                <p>Success</p>
                <p>Success</p>
                <p>Success</p>
                <p>protein=0 carbohydrate=4 fat=3 flavour=5</p>
            </td>
        </tr>
    </tbody>
</table>
<p>&nbsp;</p>
<table width="696">
    <tbody>
        <tr>
            <td width="234">
                <p>Sample Input</p>
            </td>
            <td width="430">
                <p>Sample Output</p>
            </td>
        </tr>
        <tr>
            <td width="234">
                <p>prepare cheverme 1</p>
                <p>restock protein 10</p>
                <p>prepare cheverme 1</p>
                <p>restock carbohydrate 10</p>
                <p>prepare cheverme 1</p>
                <p>restock fat 10</p>
                <p>prepare cheverme 1</p>
                <p>restock flavour 10</p>
                <p>prepare cheverme 1</p>
                <p>report</p>
            </td>
            <td width="430">
                <p>Error: not enough protein in stock</p>
                <p>Success</p>
                <p>Error: not enough carbohydrate in stock</p>
                <p>Success</p>
                <p>Error: not enough fat in stock</p>
                <p>Success</p>
                <p>Error: not enough flavour in stock</p>
                <p>Success</p>
                <p>Success</p>
                <p>protein=0 carbohydrate=0 fat=0 flavour=0</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>7.&nbsp;&nbsp; Monkey Patcher</h2>
<p>Your employer placed you in charge of an old forum management project. The client requests new functionality, but the legacy
    code has high coupling, so you don&rsquo;t want to change anything, for fear of breaking everything else. You know which
    values need to be accessed and modified, so it&rsquo;s time to monkey patch!</p>
<p>Write a program to extend a forum post record with voting functionality. It needs to have the options to
    <strong>upvote</strong>,
    <strong>downvote</strong> and tally the
    <strong>total</strong>
    <strong>score</strong> (positive minus negative votes). Furthermore, to prevent abuse, if a post has more than 50
    <strong>total</strong>
    <strong>votes</strong>, the numbers must be obfuscated &ndash; the stored values remains the same, but the
    <strong>reported</strong> amounts of upvotes and downvotes have a number
    <strong>added</strong> to them. This number is 25% of the
    <strong>greater number</strong> of votes (positive or negative), rounded up. The actual numbers should
    <strong>not be modified</strong>, just the reported amounts.</p>
<p>Every post also has a
    <strong>rating</strong>, depending on its score. If
    <strong>positive</strong> votes are the overwhelming majority (&gt;66%), the rating is hot. If there is no majority, but the
    balance is non-negative and
    <strong>either</strong> votes are more than 100, its rating is controversial. If the balance is negative, the rating becomes
    unpopular. If the post has less than 10
    <strong>total</strong> votes, or no other rating is met, it&rsquo;s rating is new regardless of balance. These calculations are
    performed on the actual numbers.</p>
<p>Your function will be invoked with call(object, arguments), so treat it as though it is internal for the object. A forum
    post, to which the function will be attached, has the following structure:</p>
<table width="696">
    <tbody>
        <tr>
            <td width="664">
                <p>JavaScript</p>
            </td>
        </tr>
        <tr>
            <td width="664">
                <p>{</p>
                <p>&nbsp; id: &lt;id&gt;,</p>
                <p>&nbsp; author: &lt;author name&gt;,</p>
                <p>&nbsp; content: &lt;text&gt;,</p>
                <p>&nbsp; upvotes: &lt;number&gt;,</p>
                <p>&nbsp; downvotes: &lt;number&gt;</p>
                <p>}</p>
            </td>
        </tr>
    </tbody>
</table>
<p>The arguments will be one of the following strings:</p>
<ul>
    <li>upvote &ndash; increase the positive votes by one</li>
    <li>downvote &ndash; increase the negative votes by one</li>
    <li>score &ndash; report positive and negative votes, balance and rating, in an array; obfuscation rules apply</li>
</ul>
<h3>Input</h3>
<p>Input will be passed as arguments to your function through a call() invocation.</p>
<h3>Output</h3>
<p>Output from the report command should be
    <strong>returned</strong> as a result of the function in the form of an
    <strong>array</strong> of three
    <strong>numbers</strong> and a
    <strong>string</strong>, as described above.</p>
<h3>Examples</h3>
<table width="696">
    <tbody>
        <tr>
            <td width="664">
                <p>Sample execution</p>
            </td>
        </tr>
        <tr>
            <td width="664">
                <p>let post = {</p>
                <p>&nbsp;&nbsp;&nbsp; id: '3',</p>
                <p>&nbsp;&nbsp;&nbsp; author: 'emil',</p>
                <p>&nbsp;&nbsp;&nbsp; content: 'wazaaaaa',</p>
                <p>&nbsp;&nbsp;&nbsp; upvotes: 100,</p>
                <p>&nbsp;&nbsp;&nbsp; downvotes: 100</p>
                <p>};</p>
                <p>solution.call(post, 'upvote');</p>
                <p>solution.call(post, 'downvote');</p>
                <p>let score = solution.call(post, 'score');
                    <em>// [127, 127, 0, 'controversial']</em>
                </p>
                <p>solution.call(post, 'downvote'); &hellip;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <em>// </em>
                    <em>(executed 50 times)</em>
                </p>
                <p>score = solution.call(post, 'score');&nbsp;&nbsp;&nbsp;&nbsp;
                    <em>// [139, 189, -50, 'unpopular']</em>
                </p>
            </td>
        </tr>
        <tr>
            <td width="664">
                <p>Explanation</p>
            </td>
        </tr>
        <tr>
            <td width="664">
                <p>The post begins at 100/100, we add one upvote and one downvote, bringing it to 101/101. The reported score
                    is inflated by 25% of the greater value, rounded up (26). The balance is 0, and at least one of the numbers
                    is greater than 100, so we return an array with rating 'controversial'.</p>
                <p>We downvote 50 times, bringing the score to 101/151, the reported values are inflated by 151*0.25=38 (rounded
                    up) and since the balance is negative with return an array with rating 'unpopular'.</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>8.&nbsp;&nbsp; * Euclid&rsquo;s Algorithm</h2>
<p>Write a program that receives
    <strong>two numbers</strong> as arguments and finds the
    <strong>greatest common divisor</strong> between them.</p>
<h3>Input</h3>
<p>Input will be passed as two
    <strong>numeric arguments</strong> to your function.</p>
<h3>Output</h3>
<p>
    <strong>Return</strong> the greatest common divisor as a result of the function.</p>
<h3>Examples</h3>
<table width="664">
    <tbody>
        <tr>
            <td width="301">
                <p>Sample Input</p>
            </td>
            <td width="364">
                <p>Sample Output</p>
            </td>
        </tr>
        <tr>
            <td width="301">
                <p>252, 105</p>
            </td>
            <td width="364">
                <p>21</p>
            </td>
        </tr>
    </tbody>
</table>
<h2>9.&nbsp;&nbsp; *** Kepler&rsquo;s Problem</h2>
<p>Write a function that, given the mean anomaly and orbital eccentricity of a celestial body, calculates its eccentric anomaly.
    The eccentric anomaly
    <strong>
        <em>E</em>
    </strong> is related to the mean anomaly
    <strong>
        <em>M</em>
    </strong> by Kepler&rsquo;s equation:</p>
<p>Where
    <strong>
        <em>e</em>
    </strong> is the eccentricity. Note this equation is transcendental, which means it cannot be solved for
    <strong>
        <em>E</em>
    </strong> algebraically. Use numerical analysis to approximate a root with accuracy 1x10
    <sup>-9</sup>. You can find information about Newton&rsquo;s Method here:
    <a href="https://en.wikipedia.org/wiki/Newton's_method">https://en.wikipedia.org/wiki/Newton&rsquo;s_method</a>. Try to implement it recursively.</p>
<p>The
    <strong>input</strong> comes as two number parameters. The first parameter is the current mean anomaly in radians and the second
    is the orbital eccentricity of the body.</p>
<p>The
    <strong>output</strong> is an approximation of the eccentric anomaly and should be printed on the console. Display only the significant
    digits.</p>
<h3>Examples</h3>
<table width="667">
    <tbody>
        <tr>
            <td width="208">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="113">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
            <td rowspan="2" width="24">
                <p>
                    <strong>&nbsp;</strong>
                </p>
            </td>
            <td width="208">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="113">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="208">
                <p>1, 0</p>
            </td>
            <td width="113">
                <p>1</p>
            </td>
            <td width="208">
                <p>3.1415926535, 0.75</p>
            </td>
            <td width="113">
                <p>3.141592654</p>
            </td>
        </tr>
    </tbody>
</table>
<p>&nbsp;</p>
<table width="667">
    <tbody>
        <tr>
            <td width="208">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="113">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
            <td rowspan="2" width="24">
                <p>
                    <strong>&nbsp;</strong>
                </p>
            </td>
            <td width="208">
                <p>
                    <strong>Input</strong>
                </p>
            </td>
            <td width="113">
                <p>
                    <strong>Output</strong>
                </p>
            </td>
        </tr>
        <tr>
            <td width="208">
                <p>0.25, 0.99</p>
            </td>
            <td width="113">
                <p>1.156077258</p>
            </td>
            <td width="208">
                <p>4.8, 0.2</p>
            </td>
            <td width="113">
                <p>4.601234265</p>
            </td>
        </tr>
    </tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Hints</h3>
<p>Newton&rsquo;s method works with functions that equal zero. We shift the variables around to arrive at the following form:</p>
<p>Not coincidentally, this is also our progress check &ndash; as we look for a closer approximation for
    <strong>
        <em>E</em>
    </strong>, the solution of this equation will be closer to zero. Once it&rsquo;s within the aforementioned
    <strong>
        <em>epsilon</em>
    </strong> (required accuracy), we stop iterating and print the result. When implementing recursively, this condition will be the
    bottom of our recursion. The last bit we need is the first derivative of the function:</p>
<p>And to plug it all into Newton&rsquo;s equation:</p>
<p>Where
    <strong>
        <em>E
            <sub>0</sub>
        </em>
    </strong> is the result of the previous iteration and
    <strong>
        <em>E
            <sub>1</sub>
        </em>
    </strong> will be the result of the current iteration. When beginning the iteration, pick an initial value for
    <strong>
        <em>E
            <sub>0</sub>
        </em>
    </strong> that might be close enough to our desired result (chose a value that is either zero or equal to the mean anomaly).</p>
<p>&nbsp;</p>