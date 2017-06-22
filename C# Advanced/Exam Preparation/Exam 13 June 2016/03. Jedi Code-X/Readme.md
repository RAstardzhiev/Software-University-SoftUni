<h1>Problem 3 &ndash; Jedi Code-X</h1>
<p>The Jedi and the Sith warfare is ruthless, and every leak of information could be lethal to the Light side&rsquo;s revolution, that is why encoded messages were created. You need to write a program that decodes the incoming messages and the names of those that sent them.</p>
<p>On the first line of input you will receive <strong>n</strong>, an integer. On the next <strong>n</strong> lines you will be receiving strings of <strong>random ASCII characters</strong> with <strong>random length</strong>, which will represent the encoded text.</p>
<p>After that you will receive <strong>2</strong> lines. They will contain <strong>patterns</strong>. You must <strong>extract all names</strong> that consist <strong>of English alphabet letters</strong>, with <strong>length equal to the length of the pattern</strong> given on the <strong>first line</strong>, and <strong>prefix</strong> the given pattern itself. Then you must extract all messages which consist of <strong>English alphabet letters and digits</strong>, with <strong>length equal to the length of the pattern</strong> given on the second line, and <strong>prefix</strong> the given pattern itself. A <strong>character</strong> which <strong>does not</strong> follow the <strong>content conditions</strong> specified above <strong>denotes the end</strong> of a particular Jedi name / message.</p>
<p>On the <strong>last line</strong> of input you will get<strong> integers</strong> separated by a space. <strong>Every integer is an index of a message</strong>. The<strong> first Jedi found</strong> in the encoded text corresponds to<strong> the first index </strong>and<strong> the message at that index</strong>, the second Jedi to the second index and so on&hellip; If a <strong>particular message&rsquo;s index</strong> is <strong>non-existent</strong> you <strong>ignore </strong>it and assign the next message with a <strong>valid</strong> <strong>index</strong> to the <strong>current</strong> Jedi, if such a message does not exist the Jedi is left with no message. In the situation that a Jedi&rsquo;s message has an invalid index and he skips through the messages to find a valid one, the Jedi after him (if one exists) will take the message after the one the first Jedi took. If there are <strong>more indexes</strong> than needed,<strong> ignore</strong> the extra indexes.</p>
<h3>Input</h3>
<ul>
<li>On the first line you will get the integer <strong>n</strong>.</li>
<li>On the next n lines you will get random amounts of random ASCII characters.</li>
<li>After that you will get the two patterns each on a new line.</li>
<li>On the last line you will get integers separated by a single space.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output is simple. You must print the Jedi, if the messages are less than the Jedi, print only those Jedi that have messages.</li>
<li>Jedi must be printed in the following format:</li>
<li>{Jedi name} &ndash; {Jedi message}</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>N will be a valid integer in the range [0, 1000].</li>
<li>The encoded text will consist of ASCII characters.</li>
<li>The prefix patterns can consist of any ASCII character.</li>
<li>The integers (indexes of messages) will be valid integers in range [0, 1000].</li>
<li>Allowed time / memory: 100ms /</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="683">
<tbody>
<tr>
<td width="545">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="138">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="545">
<p><strong>4</strong></p>
<p><strong>1-02948091jeknm,a sd,nbjwhu3hroLKjahefkljalsj#=#=#pesho</strong></p>
<p><strong>1gjq&amp;&amp;&amp;geo*nhvjsfbsbdkfjq.311/.24/3.4,l2</strong></p>
<p><strong>3u827582929@@@@#=#=#gosho</strong></p>
<p><strong>&amp;&amp;&amp;ped-&amp;&amp;&amp;eraeesmdfjbdfspefkowekf</strong></p>
<p><strong>#=#=#</strong></p>
<p><strong>&amp;&amp;&amp;</strong></p>
<p><strong>2 1</strong></p>
</td>
<td width="138">
<p><strong>pesho</strong><strong> -</strong><strong> ped</strong></p>
<p><strong>gosho</strong><strong> -</strong><strong> geo</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="599">
<tbody>
<tr>
<td width="339">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="260">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="339">
<p><strong>5</strong></p>
<p><strong>asdasdasd------Petkan123asdasd sasd </strong></p>
<p><strong>------Goshko-asdasdfddfgasdada 1r23</strong></p>
<p><strong>------Lilqna564!3876876429</strong></p>
<p><strong>*)(@*#)(&amp;$%*^&amp;------Stamat+as</strong></p>
<p><strong>:-@-@-ONIGH u305uvwoenh N{-@-@-OAIHF </strong></p>
<p><strong>------</strong></p>
<p><strong>-@-@-</strong></p>
<p><strong>2 1 1 3</strong></p>
</td>
<td width="260">
<p><strong>Petkan</strong><strong> -</strong><strong> OAIHF</strong></p>
<p><strong>Goshko</strong><strong> -</strong><strong> ONIGH</strong></p>
<p><strong>Lilqna</strong><strong> -</strong><strong> ONIGH</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>