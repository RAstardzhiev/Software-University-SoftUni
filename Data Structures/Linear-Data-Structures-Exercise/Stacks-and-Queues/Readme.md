<h1>Exercises: Linear Data Structures &ndash; Stacks and Queues</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1857/data-structures-january-2018">"Data Structures" course @ Software University</a>. You can submit your code in the SoftUni Judge System - <a href="https://judge.softuni.bg/Contests/567/Linear-Data-Structures-Stacks-and-Queues-CSharp-Exercise">https://judge.softuni.bg/Contests/567/Linear-Data-Structures-Stacks-and-Queues-CSharp-Exercise</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reverse Numbers with a Stack</h2>
<p>Write a program that reads <strong>N integers</strong> from the console and <strong>reverses them using a stack</strong>. Use the Stack&lt;int&gt; class from .NET Framework. Just put the input numbers in the stack and pop them. Examples:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Input</strong></p>
</td>
<td width="92">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1 2 3 4 5</p>
</td>
<td width="92">
<p>5 4 3 2 1</p>
</td>
</tr>
<tr>
<td width="92">
<p>1</p>
</td>
<td width="92">
<p>1</p>
</td>
</tr>
<tr>
<td width="92">
<p>(empty)</p>
</td>
<td width="92">
<p>(empty)</p>
</td>
</tr>
<tr>
<td width="92">
<p>1 -2</p>
</td>
<td width="92">
<p>-2 1</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Calculate Sequence with a Queue</h2>
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
<p>Using the Queue&lt;T&gt; class, write a program to print its first 50 members for given N. Examples:</p>
<table>
<tbody>
<tr>
<td width="51">
<p><strong>Input</strong></p>
</td>
<td width="366">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="51">
<p>2</p>
</td>
<td width="366">
<p>2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, &hellip;</p>
</td>
</tr>
<tr>
<td width="51">
<p>-1</p>
</td>
<td width="366">
<p>-1, 0, -1, 1, 1, 1, 2, &hellip;</p>
</td>
</tr>
<tr>
<td width="51">
<p>1000</p>
</td>
<td width="366">
<p>1000, 1001, 2001, 1002, 1002, 2003, 1003, &hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Implement an Array-Based Stack</h2>
<p>Implement the "<strong>stack</strong>" data structure Stack&lt;T&gt; that holds its elements in an array:</p>
<table>
<tbody>
<tr>
<td width="693">
<p>public class ArrayStack&lt;T&gt;</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; private T[] elements;</p>
<p>&nbsp;&nbsp;&nbsp; public int Count { get; private set; }</p>
<p>&nbsp;&nbsp;&nbsp; private const int InitialCapacity = 16;</p>
<p>&nbsp;&nbsp;&nbsp; public ArrayStack(int capacity = InitialCapacity) { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public void Push(T element) { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T Pop() { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T[] ToArray() { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; private void Grow() { &hellip; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>Follow the concepts from the CircularQueue&lt;T&gt; class from the exercises in class. The stack is simpler than the circular queue, so you will need to follow the same logic, but more simplified. Some hints:</p>
<ul>
<li>The stack <strong>capacity</strong> is elements.Length</li>
<li>Keep the stack <strong>size</strong> (number of elements) in Count</li>
<li>Push(element) just saves the element in elements[this.Count] and increases Count</li>
<li>Push(element) should invoke Grow() in case of Count == this.elements.Length</li>
<li>Pop() decreases Count and returns this.elements[this.Count]</li>
<li>Grow() allocates a new array newElements of size 2 * this.elements.Length and copies the first Count elements from this.elements to newElements. Finally, assign this.elements=newElements</li>
<li>ToArray() just creates and returns a <a href="http://stackoverflow.com/questions/943635/c-sharp-arrays-getting-a-sub-array-from-an-existing-array"><strong>sub-array</strong></a> of elements[0&hellip;this.Count-1]</li>
<li>Pop() should throw InvalidOperationException (or IllegalArgumentException) if the stack is empty</li>
</ul>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Linked Stack</h2>
<p>Implement a stack by a "<strong>linked list</strong>" as underlying data structure:</p>
<p>Use the following code as start:</p>
<table>
<tbody>
<tr>
<td width="693">
<p>public class LinkedStack&lt;T&gt;</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; private Node&lt;T&gt; firstNode;</p>
<p>&nbsp;&nbsp;&nbsp; public int Count { get; private set; }</p>
<p>&nbsp;&nbsp;&nbsp; public void Push(T element) { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T Pop() { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T[] ToArray() { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; private class Node&lt;T&gt;</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; private T value;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public Node&lt;T&gt; NextNode { get; set; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public Node(T value, Node&lt;T&gt; nextNode = null) { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>The Push(element) operation should create a new Node&lt;T&gt; and put it as firstNode, followed by the old value of the firstNode, e.g. this.firstNode = new Node&lt;T&gt;(element, this.firstNode).</p>
<p>The Pop() operation should return the firstNode and replace it with firstNode.NextNode. If the stack is empty, it should throw InvalidOperationException.</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Linked Queue</h2>
<p>Implement a queue by a "<strong>doubly-linked list</strong>" as underlying data structure:</p>
<p>Use the following code as start:</p>
<table>
<tbody>
<tr>
<td width="693">
<p>public class LinkedQueue&lt;T&gt;</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; public int Count { get; private set; }</p>
<p>&nbsp;&nbsp;&nbsp; public void Enqueue(T element) { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T Dequeue() { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T[] ToArray() { &hellip; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp; private class QueueNode&lt;T&gt;</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public T Value { get; private set; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public QueueNode&lt;T&gt; NextNode { get; set; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public QueueNode&lt;T&gt; PrevNode { get; set; }</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>You may modify and adjust the code from the DoublyLinkedList&lt;T&gt; class from the last lesson. If the queue is empty, the Dequeue() should throw InvalidOperationException.</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Sequence N &agrave; M</h2>
<p>We are given numbers <strong>n</strong> and <strong>m</strong>, and the following operations:</p>
<ol>
<li>n &agrave; n + 1</li>
<li>n &agrave; n + 2</li>
<li>n &agrave; n * 2</li>
</ol>
<p>Write a program that <strong>finds the shortest sequence of operations</strong> from the list above that <strong>starts from n and finishes in m</strong>. If several shortest sequences exist, find the first one of them. Examples:</p>
<table>
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="275">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>3 10</p>
</td>
<td width="275">
<p>3 -&gt; 5 -&gt; 10</p>
</td>
</tr>
<tr>
<td width="76">
<p>5 -5</p>
</td>
<td width="275">
<p>(no solution)</p>
</td>
</tr>
<tr>
<td width="76">
<p>10 30</p>
</td>
<td width="275">
<p>10 -&gt; 11 -&gt; 13 -&gt; 15 -&gt; 30</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Hint</strong>: use a <strong>queue</strong> and the following algorithm:</p>
<ol>
<li>create a queue of numbers</li>
<li>queue &szlig; n</li>
<li>while (queue not empty)
<ol>
<li>queue &agrave; e</li>
<li>if (e &lt; m)
<ol>
<li>queue &szlig; e + 1</li>
<li>queue &szlig; e + 2</li>
</ol>
</li>
</ol>
</li>
</ol>
<ul>
<li>queue &szlig; e * 2</li>
</ul>
<ol start="3">
<li>if (e == m) Print-Solution; exit</li>
</ol>
<p>The above algorithm either will find a solution, or will find that it does not exist. It cannot print the numbers comprising the sequence n &agrave; m.</p>
<p>To print the sequence of steps to reach <strong>m</strong>, starting from <strong>n</strong>, you will need to keep the previous item as well. Instead using a queue of numbers, use a queue of items. Each item will keep a number and a pointer to the previous item. The algorithms changes like this:</p>
<p><strong>Algorithm Find-Sequence (n, m)</strong>:</p>
<ol>
<li>create a queue of items { value, previous item }</li>
<li>queue &szlig; { n, <strong>null</strong> }</li>
<li>while (queue not empty)
<ol>
<li>queue &agrave; item</li>
<li>if (item.value &lt; m)
<ol>
<li>queue &szlig; { item.value + 1, item }</li>
<li>queue &szlig; { item.value + 2, item }</li>
</ol>
</li>
</ol>
</li>
</ol>
<ul>
<li>queue &szlig; { item.value * 2, item }</li>
</ul>
<ol start="3">
<li>if (item.value == m) Print-Solution; exit</li>
</ol>
<p><strong>Algorithm Print-Solution (item)</strong>:</p>
<ol>
<li>while (item not null)
<ol>
<li>print item.value</li>
<li>item = item.previous</li>
</ol>
</li>
</ol>
<p>&nbsp;</p>
<p>&nbsp;</p>