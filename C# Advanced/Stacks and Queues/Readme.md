<h1 style="text-align: center;">Exercises: Stacks and Queues</h1>
<p style="text-align: center;">This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016">"CSharp Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h1 style="text-align: left;"><strong>Problem 1. Reverse Numbers with a Stack</strong></h1>
<p>Write a program that reads <strong>N integers</strong> from the console and <strong>reverses them using a stack</strong>. Use the <strong>Stack&lt;int&gt;</strong> class. Just put the input numbers in the stack and pop them. Examples:</p>
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
<p>1 2 3 4 5</p>
</td>
<td width="372">
<p>5 4 3 2 1</p>
</td>
</tr>
<tr>
<td width="305">
<p>1</p>
</td>
<td width="372">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 2.&nbsp;<strong>Basic Stack Operations</strong></h1>
<p>Play around with a stack. You will be given an integer <strong>N </strong>representing the amount of elements to push onto the stack, an integer <strong>S </strong>representing the amount of elements to pop from the stack and finally an integer <strong>X</strong>, an element that you should check whether is present in the stack. If it is print <strong>true </strong>on the console, if it&rsquo;s not print the smallest element currently present in the stack.</p>
<p><strong>Input Format: </strong>On the first line you will be given <strong>N</strong>, <strong>S</strong> and <strong>X </strong>separated by a single space. On the next line you will be given <strong>N</strong> amount of integers.</p>
<p><strong>Output Format: </strong>On a single line print either <strong>true </strong>if <strong>X </strong>is present in the stack otherwise print <strong>smallest </strong>element in the stack. If the stack is empty print 0.</p>
<p><strong>Examples</strong></p>
<table width="695">
<tbody>
<tr>
<td width="141">
<p><strong>Input</strong></p>
</td>
<td width="132">
<p><strong>Output</strong></p>
</td>
<td width="422">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="141">
<p>5 2 13</p>
<p>1 13 45 32 4</p>
</td>
<td width="132">
<p>true</p>
</td>
<td width="422">
<p>We have to <strong>push 5 </strong>elements. Then we <strong>pop 2 </strong>of them. Finally, we have to check whether 13 is present in the stack. Since it is we print <strong>true</strong>.</p>
</td>
</tr>
<tr>
<td width="141">
<p>4 1 666</p>
<p>420 69 13 666</p>
</td>
<td width="132">
<p>13</p>
</td>
<td width="422">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 3.&nbsp;<strong>Maximum Element</strong></h1>
<p>You have an empty sequence, and you will be given&nbsp;N&nbsp;queries. Each query is one of these three types:</p>
<p>1 x - Push the element x into the stack.</p>
<p>2&nbsp;&nbsp;&nbsp; - Delete the element present at the top of the stack.</p>
<p>3&nbsp;&nbsp;&nbsp; - Print the maximum element in the stack.</p>
<p><strong>Input Format: </strong>The first line of input contains an integer,&nbsp;N. The next&nbsp;N lines each contain an above mentioned query.&nbsp;<em>(It is guaranteed that each query is valid.)</em></p>
<p><strong>Output Format: </strong>For each type&nbsp;3&nbsp;query, print the maximum element in the stack on a new line.</p>
<p><strong>Constraints</strong>:<br /> 1 &le; N &le; 10<sup>5</sup>&nbsp;<br /> 1 &le; x &le; 10<sup>9</sup><br /> 1 &le; type &le; 3</p>
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
<p>9</p>
<p>1 97</p>
<p>2</p>
<p>1 20</p>
<p>2</p>
<p>1 26</p>
<p>1 20</p>
<p>3</p>
<p>1 91</p>
<p>3</p>
</td>
<td width="372">
<p>26</p>
<p>91</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 4.&nbsp;<strong>Basic Queue Operations</strong></h1>
<p>Play around with a queue. You will be given an integer <strong>N </strong>representing the amount of elements to enqueue (add), an integer <strong>S </strong>representing the amount of elements to dequeue (remove/poll) from the queue and finally an integer <strong>X</strong>, an element that you should check whether is present in the queue. If it is print <strong>true </strong>on the console, if it&rsquo;s not print the smallest element currently present in the queue.</p>
<p><strong>Examples</strong></p>
<table width="688">
<tbody>
<tr>
<td width="140">
<p><strong>Input</strong></p>
</td>
<td width="142">
<p><strong>Output</strong></p>
</td>
<td width="406">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="140">
<p>5 2 32</p>
<p>1 13 45 32 4</p>
</td>
<td width="142">
<p>true</p>
<p>&nbsp;</p>
</td>
<td width="406">
<p>We have to <strong>push 5 </strong>elements. Then we <strong>pop 2 </strong>of them. Finally, we have to check whether 13 is present in the stack. Since it is we print <strong>true</strong>.</p>
</td>
</tr>
<tr>
<td width="140">
<p>4 1 666</p>
<p>666 69 13 420</p>
</td>
<td width="142">
<p>13</p>
</td>
<td width="406">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="140">
<p>3 3 90</p>
<p>90 90 90</p>
</td>
<td width="142">
<p>0</p>
</td>
<td width="406">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 5.&nbsp;<strong>Calculate Sequence with Queue</strong></h1>
<p>We are given the following sequence of numbers:</p>
<ul>
<li>S<sub>1</sub> = N</li>
<li>S<sub>2</sub> = S<sub>1</sub> + 1</li>
<li>S<sub>3</sub> = 2*S<sub>1</sub> + 1</li>
<li>S<sub>4</sub> = S<sub>1</sub> + 2</li>
<li>S<sub>5</sub> = S<sub>2</sub> + 1</li>
<li>S<sub>6</sub> = 2*S<sub>2</sub> + 1</li>
<li>S<sub>7</sub> = S<sub>2</sub> + 2</li>
<li>&hellip;</li>
</ul>
<p>Using the <strong>ArrayDeque&lt;E&gt;</strong> class, write a program to print its first 50 members for given N.</p>
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
<p>2</p>
</td>
<td width="372">
<p>2 3 5 4 4 7 5 6 11 7 5 9 6 &hellip;</p>
</td>
</tr>
<tr>
<td width="305">
<p>-1</p>
</td>
<td width="372">
<p>-1 0 -1 1 1 1 2 &hellip;</p>
</td>
</tr>
<tr>
<td width="305">
<p>1000</p>
</td>
<td width="372">
<p>1000 1001 2001 1002 1002 2003 1003 &hellip;</p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 6.&nbsp;<strong>* Truck Tour</strong></h1>
<p>Suppose there is a circle. There are&nbsp;<strong>N</strong>&nbsp;petrol pumps on that circle. Petrol pumps are numbered&nbsp;0&nbsp;to&nbsp;(N&minus;1)&nbsp;(both inclusive). You have <strong>two pieces of information</strong> corresponding to each of the petrol pump: (1) the <strong>amount of petrol</strong> that particular petrol pump will give, and (2) the <strong>distance from that petrol pump</strong> to the next petrol pump.</p>
<p>Initially, you have a tank of infinite capacity carrying no petrol. You can start the tour at <strong>any</strong> of the petrol pumps. Calculate the <strong>first point</strong> from where the truck will be able to complete the circle. Consider that the truck will stop at <strong>each of the petrol pumps</strong>. The truck will move one kilometer for each liter of the petrol.</p>
<p><strong>Input Format: </strong>The first line will contain the value of&nbsp;<strong>N</strong>.<br /> The next&nbsp;<strong>N</strong>&nbsp;lines will contain a pair of integers each, i.e. the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump.</p>
<p><strong>Output Format: </strong>An integer which will be the smallest index of the petrol pump from which we can start the tour.</p>
<p><strong>Constraints: </strong><br /> 1 &le; N &le; 1000001<br /> 1 &le; Amount of petrol, Distance &le; 1000000000</p>
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
<p>3</p>
<p>1 5</p>
<p>10 3</p>
<p>3 4</p>
</td>
<td width="372">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h1>Problem 7.&nbsp;<strong>Balanced Parentheses</strong></h1>
<p>Given a sequence consisting of parentheses, determine whether the expression is balanced. A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closed parenthesis that occurs after the former. Also, the interval between them must be balanced. You will be given three types of parentheses:&nbsp;(,&nbsp;{, and&nbsp;[.</p>
<p>{[()]} - This is a balanced parenthesis.</p>
<p>{[(])} - This is not a balanced parenthesis.</p>
<p><strong>Input Format: </strong>Each input consists of a single line,&nbsp;S, the sequence of parentheses.</p>
<p><strong>Constraints:</strong>&nbsp;<br /> 1 &le; len<sub>s </sub>&le; 1000, where&nbsp;len<sub>s</sub>&nbsp;is the length of the sequence.&nbsp;<br /> Each character of the sequence will be one of&nbsp;{, },&nbsp;(,&nbsp;),&nbsp;[,&nbsp;].</p>
<p><strong>Output Format: </strong>For each test case, print on a new line "<em>YES</em>" if the parentheses are balanced. Otherwise, print "<em>NO</em>". Do not print the quotes.</p>
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
<p>{[()]}</p>
</td>
<td width="372">
<p>YES</p>
</td>
</tr>
<tr>
<td width="305">
<p>{[(])}</p>
</td>
<td width="372">
<p>NO</p>
</td>
</tr>
<tr>
<td width="305">
<p>{{[[(())]]}}</p>
</td>
<td width="372">
<p>YES</p>
</td>
</tr>
</tbody>
</table>
<h1>Problem 8.&nbsp;<strong>Recursive Fibonacci</strong></h1>
<p>The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is calculated from the sum of the two previous elements. The first two elements are 1, 1. Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34&hellip; <br /> The following sequence can be generated with an array, but that&rsquo;s easy, so your task is to implement recursively.</p>
<p>So if the function getFibonacci(n) returns the n&rsquo;th Fibonacci number we can express it using getFibonacci(n) = getFibonacci(n-1) + getFibonacci(n-2)</p>
<p>However, this will never end and in a few seconds a StackOverflow Exception is thrown. In order for the recursion to stop it has to have a &ldquo;bottom&rdquo;. The bottom of the recursion is getFibonacci(1) should return 1 and getFibonacci(0) should return 1.</p>
<p><strong>Input Format: </strong>On the only line in the input the user should enter the wanted Fibonacci number.</p>
<p><strong>Output Format: </strong>The output should be the n&rsquo;th Fibonacci number counting from 0</p>
<p><strong>Constraints: </strong></p>
<p>1 &le; N &le; 49</p>
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
<p>5</p>
</td>
<td width="372">
<p>8</p>
</td>
</tr>
<tr>
<td width="305">
<p>10</p>
</td>
<td width="372">
<p>89</p>
</td>
</tr>
<tr>
<td width="305">
<p>21</p>
</td>
<td width="372">
<p>17711</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>For the Nth Fibonacci number, we calculate the N-1th and the N-2th number, but for the calculation of N-1th number we calculate the N-1-1th(N-2th) and the N-1-2th number, so we have a lot of repeated calculations.</p>
<p>&nbsp;</p>
<p>If you want to figure out how to skip those unnecessary calculations, you can search for a technique called <a href="https://en.wikipedia.org/wiki/Memoization">memoization</a>.</p>
<h1>Problem 9.&nbsp;<strong>Stack Fibonacci </strong></h1>
<p>There is another way of calculating the Fibonacci sequence using a stack. It is non recursive, so it does not make any unnecessary calculations. Try implementing it. First push 1 and 1 and them use popping peeking and pushing to generate every consecutive number.</p>
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
<p>7</p>
</td>
<td width="372">
<p>21</p>
</td>
</tr>
<tr>
<td width="305">
<p>15</p>
</td>
<td width="372">
<p>987</p>
</td>
</tr>
<tr>
<td width="305">
<p>33</p>
</td>
<td width="372">
<p>5702887</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h1>Problem 10.&nbsp;<strong>*Simple Text Editor</strong></h1>
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
<p>There are&nbsp;8&nbsp;operations. Initially,&nbsp;the text&nbsp;is empty.&nbsp;<br /> In the first operation, we append&nbsp;<strong>abc</strong> to&nbsp;the text.&nbsp;<br /> Then, we print its&nbsp;3rd&nbsp;character, which is&nbsp;<strong>c</strong>&nbsp;at this point.&nbsp;<br /> Next, we erase its last&nbsp;3&nbsp;characters,&nbsp;<strong>abc</strong>.&nbsp;<br /> After that, we append&nbsp;<strong>xy</strong> to the text.&nbsp;<br /> The text&nbsp;becomes&nbsp;<strong>xy</strong>&nbsp;after these previous two modifications.&nbsp;<br /> Then, we are asked to return the&nbsp;2nd&nbsp;character of&nbsp;the text, which is&nbsp;<strong>y</strong>.<br /> After that, we have to undo the last update to&nbsp;the text, so&nbsp;it&nbsp;becomes empty.<br /> The next operation asks us to undo the update before that, so&nbsp;the text&nbsp;becomes&nbsp;<strong>abc</strong>&nbsp;again.&nbsp;<br /> Finally, we are asked to print its&nbsp;1st&nbsp;character, which is&nbsp;<strong>a</strong>&nbsp;at this point.</p>
<h1>Problem 11.&nbsp;<strong>**Poisonous Plants</strong></h1>
<p>You are given&nbsp;<strong>N</strong>&nbsp;plants in a garden. Each of these plants has been added with some amount of pesticide. After each day, if any plant has <strong>more pesticide</strong> than the plant at <strong>its left</strong>, being weaker(more GMO) than the left one, <strong>it dies</strong>. You are given the initial values of the pesticide and position of each plant. Print the number of days <strong>after</strong> which no plant dies, i.e. the time after which there are no plants with more pesticide content than the plant to their left.</p>
<p><strong>Input Format: </strong>The input consists of an integer&nbsp;<strong>N</strong> representing the number of plants. The next <strong>single line</strong> consists of&nbsp;<strong>N</strong>&nbsp;integers where every integer represents the position and amount of pesticides of each plant.</p>
<p><strong>Constraints</strong>: 1 &le; N &le; 100000<br /> Pesticides amount on a plant is between 0 and 1000000000</p>
<p><strong>Output Format: </strong>Output a single value equal to the number of days after which no plants die</p>
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
<p>7</p>
<p>6 5 8 4 7 10 9</p>
</td>
<td width="372">
<p>2</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<p><strong>Explanation</strong></p>
<p>Initially all plants are alive.&nbsp;<br /> Plants = {(6,1), (5,2), (8,3), (4,4), (7,5), (10,6), (9,7)}&nbsp;<br /> Plants[k] = (i,j) =&gt; j<sup>th</sup>&nbsp;plant has pesticide amount = i.&nbsp;<br /> After the 1<sup>st</sup>&nbsp;day, 4 plants remain as plants 3, 5, and 6 die.&nbsp;<br /> Plants = {(6,1), (5,2), (4,4), (9,7)}&nbsp;<br /> After the 2<sup>nd</sup>&nbsp;day, 3 plants survive as plant 7 dies. Plants = {(6,1), (5,2), (4,4)}&nbsp;<br /> After the 3<sup>rd</sup>&nbsp;day, 3 plants survive and no more plants die.&nbsp;<br /> Plants = {(6,1), (5,2), (4,4)}&nbsp;<br /> After the 2<sup>nd</sup>&nbsp;day the plants stop dying.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>