<h1>Exercises: Algorithm Complexity and Linear Data Structures</h1>
<p>This document defines the <strong>homework assignments</strong> for the <a href="https://softuni.bg/trainings/1857/data-structures-january-2018">"Data Structures" course @ Software University</a>. You can submit your code in the SoftUni Judge System - <a href="https://judge.softuni.bg/Contests/Practice/Index/551#0">https://judge.softuni.bg/Contests/Practice/Index/551</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sum and Average</h2>
<p>Write a program that reads from the console a sequence of integer numbers (on a single line, separated by a space). Calculate and print the <strong>sum</strong> and <strong>average</strong> of the elements of the sequence. Keep the sequence in List&lt;int&gt;. Round the average to second digit after the decimal separator.</p>
<table>
<tbody>
<tr>
<td width="84">
<p><strong>Input</strong></p>
</td>
<td width="284">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="84">
<p>4 5 6</p>
</td>
<td width="284">
<p>Sum=15; Average=5.00</p>
</td>
</tr>
<tr>
<td width="84">
<p>1 1</p>
</td>
<td width="284">
<p>Sum=2; Average=1.00</p>
</td>
</tr>
<tr>
<td width="84">
<p>&nbsp;</p>
</td>
<td width="284">
<p>Sum=0; Average=0.00</p>
</td>
</tr>
<tr>
<td width="84">
<p>10</p>
</td>
<td width="284">
<p>Sum=10; Average=10.00</p>
</td>
</tr>
<tr>
<td width="84">
<p>2 2 1</p>
</td>
<td width="284">
<p>Sum=5; Average=1.67</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sort Words</h2>
<p>Write a program that reads from the console a <strong>sequence of words</strong> (strings on a single line, separated by a space). <strong>Sort</strong> them alphabetically. Keep the sequence in List&lt;string&gt;.</p>
<table>
<tbody>
<tr>
<td width="282">
<p><strong>Input</strong></p>
</td>
<td width="261">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="282">
<p>wow softuni alpha</p>
</td>
<td width="261">
<p>alpha softuni wow</p>
</td>
</tr>
<tr>
<td width="282">
<p>hi</p>
</td>
<td width="261">
<p>hi</p>
</td>
</tr>
<tr>
<td width="282">
<p>rakiya beer wine vodka whiskey</p>
</td>
<td width="261">
<p>beer rakiya vodka whiskey wine</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Longest Subsequence</h2>
<p>Write a method that finds the <strong>longest subsequence of equal numbers</strong> in given List&lt;int&gt; and returns the result as new List&lt;int&gt;. If several sequences has the same longest length, return the leftmost of them. Write a program to test whether the method works correctly.</p>
<table>
<tbody>
<tr>
<td width="150">
<p><strong>Input</strong></p>
</td>
<td width="85">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="150">
<p>12 2 7 4 <strong>3 3</strong> 8</p>
</td>
<td width="85">
<p>3 3</p>
</td>
</tr>
<tr>
<td width="150">
<p><strong>2 2 2</strong> 3 3 3</p>
</td>
<td width="85">
<p>2 2 2</p>
</td>
</tr>
<tr>
<td width="150">
<p>4 4 <strong>5 5 5</strong></p>
</td>
<td width="85">
<p>5 5 5</p>
</td>
</tr>
<tr>
<td width="150">
<p><strong>1 </strong>2 3</p>
</td>
<td width="85">
<p>1</p>
</td>
</tr>
<tr>
<td width="150">
<p><strong>0</strong></p>
</td>
<td width="85">
<p>0</p>
</td>
</tr>
<tr>
<td width="150">
<p>4 2 3<strong> 4 4</strong></p>
</td>
<td width="85">
<p>4 4</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Remove Odd Occurrences</h2>
<p>Write a program that <strong>removes</strong> from given sequence all numbers that occur <strong>odd number of times</strong>.</p>
<table>
<tbody>
<tr>
<td width="187">
<p><strong>Input</strong></p>
</td>
<td width="74">
<p><strong>Output</strong></p>
</td>
<td width="439">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="187">
<p>1 <strong>2 3 4</strong> 1</p>
</td>
<td width="74">
<p>1 1</p>
</td>
<td width="439">
<p>2, 3 and 4 occur odd number of times (once). 1 occurs 2 times</p>
</td>
</tr>
<tr>
<td width="187">
<p><strong>1 2</strong> 3 <strong>4 5 </strong>3 <strong>6</strong> 7 <strong>6</strong> 7 <strong>6</strong></p>
</td>
<td width="74">
<p>3 3 7 7</p>
</td>
<td width="439">
<p>1, 2, 4, 5 and 6 occurs odd number of times &agrave; removed</p>
</td>
</tr>
<tr>
<td width="187">
<p>1 2 1 2 1 2</p>
</td>
<td width="74">
<p>&nbsp;</p>
</td>
<td width="439">
<p>All numbers occur odd number of times &agrave; removed</p>
</td>
</tr>
<tr>
<td width="187">
<p><strong>3</strong> 7 <strong>3 3</strong> 4 <strong>3</strong> 4 <strong>3</strong> 7</p>
</td>
<td width="74">
<p>7 4 4 7</p>
</td>
<td width="439">
<p>3 occurs odd number of times (5) &agrave; removed</p>
</td>
</tr>
<tr>
<td width="187">
<p>1 1</p>
</td>
<td width="74">
<p>1 1</p>
</td>
<td width="439">
<p>All numbers occur even number of times &agrave; sequence stays unchanged</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Count of Occurrences</h2>
<p>Write a program that finds in given array of integers <strong>how many times each of them occurs</strong>. The input sequence holds numbers in range [0&hellip;1000]. The output should hold all numbers that occur at least once along with their number of occurrences.</p>
<table>
<tbody>
<tr>
<td width="159">
<p><strong>Input</strong></p>
</td>
<td width="142">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="159">
<p>3 4 4 2 3 3 4 3 2</p>
</td>
<td width="142">
<p>2 -&gt; 2 times</p>
<p>3 -&gt; 4 times</p>
<p>4 -&gt; 3 times</p>
</td>
</tr>
<tr>
<td width="159">
<p>1000</p>
</td>
<td width="142">
<p>1000 -&gt; 1 times</p>
</td>
</tr>
<tr>
<td width="159">
<p>0 0 0</p>
</td>
<td width="142">
<p>0 -&gt; 3 times</p>
</td>
</tr>
<tr>
<td width="159">
<p>7 6 5 5 6</p>
</td>
<td width="142">
<p>5 -&gt; 2 times</p>
<p>6 -&gt; 2 times</p>
<p>7 -&gt; 1 times</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Implement the Data Structure ReversedList&lt;T&gt;</h2>
<p>Implement a data structure ReversedList&lt;T&gt; that holds a sequence of elements of generic type T. It should hold a <strong>sequence of items in reversed order</strong>. The structure should have some <strong>capacity</strong> that <strong>grows twice</strong> when it is filled,<strong> always starting at 2</strong>. The reversed list should support the following operations:</p>
<ul>
<li>Add(Titem) &agrave; adds an element to the sequence (grow twice the underlying array to extend its capacity in case the capacity is full)</li>
<li>Count &agrave; returns the number of elements in the structure</li>
<li>Capacity &agrave; returns the capacity of the underlying array holding the elements of the structure</li>
<li>this[index] &agrave; the indexer should access the elements by <strong>index</strong> (in range 0 &hellip; Count-1) in the reverse order of adding</li>
<li>RemoveAt(index) &agrave; removes an element by <strong>index</strong> (in range 0 &hellip; Count-1) in the reverse order of adding</li>
<li>IEnumerable&lt;T&gt; &agrave; implement an enumerator to allow iterating over the elements in a foreach loop in a reversed order of their addition</li>
</ul>
<p><strong>Note:</strong> For Java, instead of indexer, create methods get(int index) and set(int index, T element). All methods should be with the same names but lowercase.</p>
<p><strong>Hint:</strong> you can keep the elements in the order of their adding, by access them in reversed order (from end to start).</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; * Distance in Labyrinth</h2>
<p>We are given a labyrinth of size N x N. Some of its cells are empty (0) and some are full (x). We can move from an empty cell to another empty cell if they share common wall. Given a starting position (*) calculate and fill in the array the minimal distance from this position to any other cell in the array. Use "u" for all unreachable cells.</p>
<table>
<tbody>
<tr>
<td width="68">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="68">
<p>2</p>
<p>x0</p>
<p>*x</p>
</td>
<td width="76">
<p>xu</p>
<p>*x</p>
</td>
</tr>
<tr>
<td width="68">
<p>3</p>
<p>000</p>
<p>0*0</p>
<p>000</p>
</td>
<td width="76">
<p>212</p>
<p>1*1</p>
<p>212</p>
</td>
</tr>
<tr>
<td width="68">
<p>6</p>
<p>000x0x</p>
<p>0x0x0x</p>
<p>0*x0x0</p>
<p>0x0000</p>
<p>000xx0</p>
<p>000x0x</p>
</td>
<td width="76">
<p>345xux</p>
<p>2x6xux</p>
<p>1*x8x10</p>
<p>2x6789</p>
<p>345xx10</p>
<p>456xux</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ** Implement a DoublyLinkedList&lt;T&gt;</h2>
<p>You are given a project skeleton that contains unit tests for a DoublyLinkedList&lt;T&gt; data structure.</p>
<p>You have to implement a <strong>doubly linked list</strong> in C# or Java &ndash; a data structure that holds <strong>nodes</strong>, where each node knows its <strong>next</strong> and <strong>previous</strong> nodes:</p>
<p>Before starting, get familiar with the concept of doubly linked list: <a href="https://en.wikipedia.org/wiki/Doubly_linked_list">https://en.wikipedia.org/wiki/Doubly_linked_list</a>.</p>
<p>The typical operations over a doubly linked list are <strong>add</strong> / <strong>remove</strong> element at <strong>both ends</strong> and <strong>traverse</strong>. By definition, the doubly linked list has a head (list start) and a tail (list end). Let's start coding!</p>
<h2>Implement ListNode&lt;T&gt;</h2>
<p>The first step when implementing a linked / doubly linked list is to understand that we need <strong>two classes</strong>:</p>
<ul>
<li>ListNode&lt;T&gt; class to hold a single list node (its value + next node + previous node)</li>
<li>DoublyLinkedList&lt;T&gt; to hold the entire list (its head + tail + operations)</li>
</ul>
<p>Now, let's write the <strong>list node class</strong>. It should hold a Value and a reference to its previous and next node. It can be inner class, because we will need it only internally from the doubly linked list class:</p>
<p>The class ListNode&lt;T&gt; is called <strong>recursive data structure</strong>, because it references itself recursively. It uses the <strong>generic argument </strong>T to avoid later specialization for any data type, e.g. int, string or DateTime. The <strong>generic classes in C#</strong> work similarly to <strong>templates in C++</strong> and <strong>generic types in Java</strong>.</p>
<h2>Implement Head, Tail and Count</h2>
<p>Now, let's define the head and tail of the doubly linked list:</p>
<h2>Implement AddFirst(T) Method</h2>
<p>Next, implement the AddFirst(T element) method:</p>
<p>Adding an element at the start of the list (before its head) has <strong>two scenarios </strong>(considered in the above code):</p>
<ul>
<li><strong>Empty list</strong> &agrave; add the new element as head and tail in the same time.</li>
<li><strong>Non-empty list</strong> &agrave; add the new element as <strong>new head</strong> and redirect the <strong>old head</strong> as second element, just after the new head.</li>
</ul>
<p>The above graphic visualizes the process of inserting a new node at the start (head) of the list. The <strong>red</strong> arrows denote the removed pointers from the old head. The <strong>green</strong> arrows denote the new pointers to the new head.</p>
<h2>Implement ForEach(Action) Method</h2>
<p>We have a doubly linked list. We can add elements to it. But we cannot see what's inside, because the list still does not have a method to traverse its elements (pass through each of them, one by one). Now let's define the ForEach(Action&lt;T&gt;) method. In programming such a method is known as <a href="https://en.wikipedia.org/wiki/Visitor_pattern">"<strong>visitor</strong>" pattern</a>. It takes as an argument a function (action) to be invoked for each of the elements of the list. The algorithm behind this method is simple: start from head and pass to the next element until the last element is reached (its next element is null). A sample implementation is given below:</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests</h2>
<p>Now we have the methods AddFirst(T) and ForEach(Action&lt;T&gt;). We are ready to run the unit tests to ensure they are correctly implemented. Most of the <strong>unit tests</strong> create a doubly linked list, add / remove elements from it and then check whether the elements in the list are as expected. For example, let's examine this unit test:</p>
<p>If we <strong>run the unit tests</strong>, some of them will now pass:</p>
<h2>Implement AddLast(T) Method</h2>
<p>Next, implement the AddLast(T element) method for appending a new element as the list tail. It should be very similar to the AddFirst(T element) method. The logic inside it exactly the same, but we append the new element at the tail instead of at the head. The code below is intentionally blurred. Write it yourself!</p>
<p>Now <strong>run the unit tests</strong> again. You should have several more passed (green) tests:</p>
<h2>Implement RemoveFirst() Method</h2>
<p>Next, let's implement the method RemoveFirst() &agrave; T. It should <strong>remove the first element</strong> from the list and move its head to point to the second element. The removed element should be returned as a result from the method. In case of empty list, the method should throw an exception. We have to consider the following three cases:</p>
<ul>
<li><strong>Empty list</strong> &agrave; throw and exception.</li>
<li><strong>Single element in the list</strong> &agrave; make the list empty (head == tail == null).</li>
<li><strong>Multiple elements in the list</strong> &agrave; remove the first element and redirect the head to point to the second element (head = NextNode).</li>
</ul>
<p>A sample implementation of RemoveFirst() method is given below:</p>
<p>Run the <strong>unit tests</strong> to ensure the method is correctly implemented:</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>Problem 10. Implement RemoveLast() Method</h2>
<p>Next, let's implement the method RemoveLast() &agrave; T. It should <strong>remove the last element</strong> from the list and move its tail to point to the element before the last. It is very similar to the method RemoveFirst(), so you are free to implement it yourself. The code below is intentionally blurred:</p>
<p>&nbsp;</p>
<h2>Problem 11. Implement ToArray() Method</h2>
<p>Now, implement the next method: ToArray() &agrave; T[]. It should copy all elements of the linked list to an array of the same size. You could use the following steps to implement this method:</p>
<ul>
<li>Allocate an array T[] of size Count.</li>
<li>Pass through all elements of the list (from head to tail) and fill them to T[0], T[1], &hellip;, T[Count-1].</li>
<li>Return the array as result.</li>
</ul>
<p>Write yourself the blurred code in the method ToArray():</p>
<p>&nbsp;</p>
<h2>Implement IEnumerable&lt;T&gt;</h2>
<p>Collection classes in C# and .NET Framework (like arrays, lists and sets) implement the system interface IEnumerable&lt;T&gt; to enable the foreach iteration over their elements. The C# keyword foreach calls internally the following method:</p>
<p>This method returns IEnumerator&lt;T&gt;, which can move to the next element and read the current element. In programming, this is known <a href="https://en.wikipedia.org/wiki/Iterator_pattern">as "<strong>iterator</strong>" pattern</a> (<strong>enumerator</strong>).</p>
<p>We will use <a href="https://msdn.microsoft.com/en-us/library/9k7k7cf0.aspx">the "<strong>yield </strong><strong>return</strong>" C# statement</a> to simplify the implementation of the iterator:</p>
<p>The above code will enable using the DoublyLinkedList&lt;T&gt; in foreach loops.</p>
<p>The last unimplemented method is the <strong>non-generic enumerator</strong>:</p>
<p>Finally, <strong>run the unit tests</strong> to ensure all of them pass correctly:</p>
<p>Congratulations! You have implemented your doubly linked list.</p>