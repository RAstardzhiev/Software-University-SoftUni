<h1>Problem 4 &ndash; Cubic&rsquo;s Messages</h1>
<p>Cubic is a veteran soldier from The Great Cubic Army. He has even participated in the Spherical Invasion as a Sergeant First Class. As a veteran, Cubic has some personal security issues &ndash; he communicates only trough text messages and sends them in a specific encrypted way, which you must decrypt in order to understand what he is saying.</p>
<p>You will begin receiving lines of input, which will consist of random ASCII characters &ndash; Cubic&rsquo;s encrypted lines. After each line you will receive a number &ndash; the length of the message he sent. Cubic might send false messages, in an act to confuse his &ldquo;enemies&rdquo;. You must capture only the messages that follow a certain format.</p>
<p>According to that format the <strong>valid</strong> messages:</p>
<ul>
<li>Consist of <strong>m </strong>characters, where <strong>m </strong>is the integer entered after each encrypted line.</li>
<li>Has only digits before itself in the encrypted line</li>
<li>Consists only of English alphabet letters</li>
<li>Has no English alphabet letters after itself in the encrypted line</li>
</ul>
<p><strong>Any</strong> message that <strong>does not follow</strong> the, specified above, rules, is <strong>invalid</strong>, and you must <strong>ignore it</strong>.</p>
<p>After you find <strong>all valid</strong> messages, you need to find their <strong>verification code</strong>. Every message has its own verification code, which Cubic gives in order to verify the message. <strong>Take all the digits before the message</strong> and all the digits <strong>after the message</strong> and consider them as <strong>indexes</strong>. If they are <strong>valid existing</strong> indexes <strong>in the message</strong>, <strong>form a string</strong> with those indexes <strong>taking characters from the message</strong>. If an index is <strong>nonexistent</strong>, put a <strong>space </strong>there. The string you form up is the verification code for the current message.</p>
<h3>Input</h3>
<ul>
<li>The input will always come in the form of 2 lines, except when it is the line terminating the input sequence.</li>
<li>The first input line will contain random ASCII characters, and the second &ndash; a number.</li>
<li>When the line &ldquo;<strong>Over!</strong>&rdquo; is entered, the input sequence ends.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output is simple. You must print all the valid messages you&rsquo;ve found, each on a new line, and their verification codes, if they have such.</li>
<li>The format of output is &ldquo;<strong>{message} == {verificationCode}</strong>&rdquo;.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The input lines can consist of <strong>ANY ASCII</strong></li>
<li>There will be <strong>NO </strong>such cases as an encrypted message without a number before it.</li>
<li>The number will be a valid integer in the range [0, 100].</li>
<li>Allowed time/memory: 100ms/16MB</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="294">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="305">
<p><strong>1234test4321</strong></p>
<p><strong>4</strong></p>
<p><strong>0000oooo0000</strong></p>
<p><strong>4</strong></p>
<p><strong>Over!</strong></p>
</td>
<td width="294">
<p><strong>test == est&nbsp; tse</strong></p>
<p><strong>oooo == oooooooo</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="305">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="294">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="305">
<p><strong>1wat!</strong></p>
<p><strong>3</strong></p>
<p><strong>#23asd33</strong></p>
<p><strong>3</strong></p>
<p><strong>333asd3a</strong></p>
<p><strong>3</strong></p>
<p><strong>100dun2</strong></p>
<p><strong>3</strong></p>
<p><strong>Over!</strong></p>
</td>
<td width="294">
<p><strong>wat == a</strong></p>
<p><strong>dun == uddn</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>