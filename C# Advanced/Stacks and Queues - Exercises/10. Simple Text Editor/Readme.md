<h1><strong>* Simple Text Editor</strong></h1>
<p>You are given an empty text. Your task is to implement 4 commands related to manipulating the text</p>
<ul>
<li>1 someString - <strong>append</strong>s someString to the end of the text</li>
<li>2 count - <strong>erases</strong> the last <em>count </em>elements from the text</li>
<li>3 index - <strong>returns</strong> the element at position <em>index </em>from the text</li>
<li>4 - <strong>undoes</strong> the last not undone command of type <em>1 / 2 </em>and returns the text to the state before that operation</li>
</ul>
<p><strong>Input format: </strong>The first line contains <strong><em>n</em></strong>, the number of operations. <br /> Each of the following <strong><em>n</em></strong> lines contains the name of the operation followed by the command argument, if any, separated by space in the following format <strong><em>CommandName Argument</em></strong>.</p>
<p>For example:</p>
<p>3</p>
<p>1 abc</p>
<p>2 2</p>
<p>4</p>
<p>&nbsp;</p>
<p><strong>Output Format: </strong>For each operation of type <strong><em>3 </em></strong>print a single line with the returned character of that operation.</p>
<p><strong>Constraints: </strong></p>
<p>1 &le; N &le; 105</p>
<p>The length of the text will not exceed 1000000 <br /> All input characters are English letters. <br /> It is guaranteed that the sequence of input operation is possible to perform</p>
<p><strong>Examples</strong></p>
<table width="677">
<tbody>
<tr>
<td width="305">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="305">
<p>8</p>
<p>1 abc</p>
<p>3 3</p>
<p>2 3</p>
<p>1 xy</p>
<p>3 2</p>
<p>4</p>
<p>4</p>
<p>3 1</p>
</td>
<td width="372">
<p>c</p>
<p>y</p>
<p>a</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Explanation</strong></p>
<p>There are&nbsp;8&nbsp;operations. Initially,&nbsp;the text&nbsp;is empty.&nbsp;<br /> In the first operation, we append&nbsp;<strong>abc</strong> to&nbsp;the text.&nbsp;<br /> Then, we print its&nbsp;3rd&nbsp;character, which is&nbsp;<strong>c</strong>&nbsp;at this point.&nbsp;<br /> Next, we erase its last&nbsp;3&nbsp;characters,&nbsp;<strong>abc</strong>.&nbsp;<br /> After that, we append&nbsp;<strong>xy</strong> to the text.&nbsp;<br /> The text&nbsp;becomes&nbsp;<strong>xy</strong>&nbsp;after these previous two modifications.&nbsp;<br /> Then, we are asked to return the&nbsp;2nd&nbsp;character of&nbsp;the text, which is&nbsp;<strong>y</strong>.<br /> After that, we have to undo the last update to&nbsp;the text, so&nbsp;it&nbsp;becomes empty.<br /> The next operation asks us to undo the update before that, so&nbsp;the text&nbsp;becomes&nbsp;<strong>abc</strong>&nbsp;again.&nbsp;<br /> Finally, we are asked to print its&nbsp;1st&nbsp;character</p>