<h1>Lab: Linear Data Structures</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments the <a href="https://softuni.bg/opencourses/data-structures">"Data Structures" course @ Software University</a>. You can submit your code in the SoftUni Judge System - <a href="https://judge.softuni.bg/Contests/574/Linear-Data-Structures-Stacks-and-Queues-Lab">https://judge.softuni.bg/Contests/574/Linear-Data-Structures-Stacks-and-Queues-Lab</a>.</p>
<h2>1.&nbsp;&nbsp; LinkedList&lt;T&gt;</h2>
<p>Implement a data structure LinekdList&lt;T&gt; that holds a sequence of elements of generic type T. It should hold a <strong>sequence of items in a sequence of linked nodes</strong>. The list should support the following operations:</p>
<ul>
<li>int Count &agrave; returns the number of elements in the structure</li>
<li>void AddFirst(Titem) &agrave; adds an element to the start of the sequence</li>
<li>void AddLast(Titem) &agrave; adds an element to the end of the sequence</li>
<li>T RemoveFirst() &agrave; removes an element from the start of the sequence and returns the element</li>
<li>T RemoveLast() &agrave; removes an element from the end of the sequence and returns the element</li>
<li>IEnumerable&lt;T&gt; &agrave; implement interface</li>
</ul>
<p>RemoveFirst() and RemoveLast() methods should throw InvalidOperationException if the list is empty</p>
<h3>Solution</h3>
<p>Start by defining the class LinkedList&lt;T&gt;, you can define the Node class inside (in which case it doesn't need to be generic, as you will use T from the LinkedList)</p>
<p>Also, note that we are going to keep a reference to both the head and the tail of the list</p>
<p>First, implement AddFirst(). The utility method IsEmpty() checks if the Count is 0</p>
<p>AddLast() is almost the same</p>
<p>Remove methods are a little bit more complicated. Start with RemoveFirst()</p>
<p>Method RemoveLast() uses a utility method GetSecondToLast() which gets the second to last element. Try to implement it yourself</p>
<p>The last thing to do is to implement IEnumerable&lt;T&gt;</p>
<p>You need to implement two methods. The first is the actual that will do the work. The second one calls the first and you need it only for compatibility reasons</p>