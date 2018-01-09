<h1>Lab: Linear Data Structures</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/data-structures">"Data Structures" course @ SoftUni</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/Compete/Index/550#0">https://judge.softuni.bg/Contests/Compete/Index/550#0</a>.</p>
<h2>1.&nbsp;&nbsp; ArrayList&lt;T&gt;</h2>
<p>Implement a data structure ArrayList&lt;T&gt; that holds a sequence of elements of generic type T. It should hold a <strong>sequence of items in an array</strong>. The structure should have <strong>capacity</strong> that <strong>grows twice</strong> when it is filled,<strong> always starting at 2</strong>. The list should support the following operations:</p>
<ul>
<li>int Count &agrave; returns the number of elements in the structure</li>
<li>T this[int index] &agrave; the indexer should access the elements by <strong>index</strong> (in range 0 &hellip; Count-1) in the reverse order of adding</li>
<li>void Add(Titem) &agrave; adds an element to the sequence (grow twice the underlying array to extend its capacity in case the capacity is full)</li>
<li>T RemoveAt(int index) &agrave; removes an element by <strong>index</strong> (in range 0 &hellip; Count-1) and returns the element</li>
</ul>
<p>Be sure to <strong>test implemented operations</strong> whenever possible before moving to the next</p>