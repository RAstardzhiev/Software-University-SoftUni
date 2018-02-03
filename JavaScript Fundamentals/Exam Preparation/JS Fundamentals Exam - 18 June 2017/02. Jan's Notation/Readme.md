<h1>Problem 2 &ndash; Jan&rsquo;s Notation</h1>
<p><em>Jan is a brilliant mathematician. With brilliance though comes bizzarity, and Jan has invented his own mathematic notation &ndash; he writes the operator after his operands, so he can save space by not writing any parenthesis. He asked from you to create an automated calculator that works with his notation, so he can prove to the world it&rsquo;s the better way to do math!</em></p>
<p>Write a JS program that parses a series of instructions written in <strong>postfix notation</strong> and executes them (postfix means the operator is written <strong>after</strong> the operands). You will receive a <strong>series of instructions</strong> &ndash; if the instruction is a <strong>number</strong>, <strong>save it</strong>; otherwise, the instruction is an <strong>arithmetic operator</strong> (+-*/) and you must apply it to the most two <strong>most recently saved</strong> numbers. <strong>Discard</strong> these two numbers and in their place, <strong>save the result</strong> of the operation &ndash; this number is now eligible to be an <strong>operand</strong> in a subsequent operation. Keep going until all input instructions have been exhausted, or you encounter an error.</p>
<p>In the end, if you&rsquo;re left with a <strong>single saved number</strong>, this is the <strong>result</strong> of the calculation and you must <strong>print</strong> it. If there are more numbers saved, then the user supplied <strong>too many instructions</strong> and you must print "Error: too many operands!". If at any point during the calculation you <strong>don&rsquo;t have</strong> two number saved, the user supplied <strong>too few instructions</strong> and you must print "Error: not enough operands!". <strong><em>See the examples for more details.</em></strong></p>
<h3>Input</h3>
<p>You will receive an array with numbers <strong>and</strong> strings &ndash; the numbers will be <strong>operands</strong> and must be saved; the strings will be <strong>arithmetic operators</strong> that must be applied to the operands.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> on a single line the <strong>final result</strong> of the calculation or an <strong>error message</strong>, as instructed above.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>numbers</strong> (operands) will be integers</li>
<li>The <strong>strings</strong> (operators) will always be one of +-*/</li>
<li>The result of each operation will be in range [-2<sup>53</sup>&hellip;2<sup>53</sup>-1] (MAX_SAFE_INTEGER will <strong>never</strong> be exceeded)</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="544">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>[3,</p>
<p>&nbsp;4,</p>
<p>&nbsp;'+']</p>
</td>
<td width="76">
<p>7</p>
</td>
<td width="544">
<p>The first instruction is a <strong>number</strong>, therefor we <strong>save</strong> it. The next one is also a <strong>number</strong>, we <strong>save</strong> it too.</p>
<p>The third instruction is a <strong>string</strong>, so it must be an <strong>operator</strong> &ndash; we <strong>remove the last two</strong> numbers we saved, and perform the operation: 3+4=7. The result of this operation is then <strong>saved</strong> where the two operands <strong>used to be</strong>.</p>
<p>We&rsquo;ve ran out of instructions, so we check the saved values &ndash; we only have <strong>one</strong>, so this must be <strong>final result</strong>. We <strong>print</strong> it on the console.</p>
</td>
</tr>
<tr>
<td width="76">
<p>[5,</p>
<p>&nbsp;3,</p>
<p>&nbsp;4,</p>
<p>&nbsp;'*',</p>
<p>&nbsp;'-']</p>
</td>
<td width="76">
<p>-7</p>
</td>
<td width="544">
<p>We save in order <strong>5</strong>, <strong>3</strong> and <strong>4</strong>. The result of the operation 3*4 is <strong>12</strong>, which we <strong>save in place</strong> of <strong>3</strong> and <strong>4</strong>.</p>
<p>Currently we have <strong>5</strong> and <strong>12</strong> saved. The result of the operation 5-12 is <strong>-7</strong>, which we <strong>save in place</strong> of <strong>5</strong> and <strong>12</strong>.</p>
<p>We have no more instructions and <strong>only one</strong> value saved, which we <strong>print</strong>.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="53">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>[7,</p>
<p>&nbsp;33,</p>
<p>&nbsp;8,</p>
<p>&nbsp;'-']</p>
</td>
<td width="246">
<p>Error: too many operands!</p>
</td>
<td width="76">
<p>[15,</p>
<p>&nbsp;'/']</p>
</td>
<td width="246">
<p>Error: not enough operands!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="94">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="151">
<p><strong>Explanation</strong></p>
</td>
<td rowspan="2" width="53">
<p><strong>&nbsp;</strong></p>
</td>
<td width="94">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
<td width="151">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="94">
<p>[31,</p>
<p>&nbsp;2,</p>
<p>&nbsp;'+',</p>
<p>&nbsp;11,</p>
<p>&nbsp;'/']</p>
</td>
<td width="76">
<p>3</p>
</td>
<td width="151">
<p>(31+2)/11</p>
</td>
<td width="94">
<p>[-1,</p>
<p>&nbsp;1,</p>
<p>&nbsp;'+',</p>
<p>&nbsp;101,</p>
<p>&nbsp;'*',</p>
<p>&nbsp;18,</p>
<p>&nbsp;'+',</p>
<p>&nbsp;3,</p>
<p>&nbsp;'/']</p>
</td>
<td width="76">
<p>6</p>
</td>
<td width="151">
<p>(-1+1)*101+18/3</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>