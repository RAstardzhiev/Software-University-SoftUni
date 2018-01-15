<h1>Exercises: Implement Circular Queue in C#</h1>
<p>This document defines the <strong>in-class exercises</strong> assignments the <a href="https://softuni.bg/opencourses/data-structures">"Data Structures" course @ Software University</a>. You can submit your code in the SoftUni Judge System - <a href="https://judge.softuni.bg/Contests/574/Linear-Data-Structures-Stacks-and-Queues-Lab">https://judge.softuni.bg/Contests/574/Linear-Data-Structures-Stacks-and-Queues-Lab</a>. <br /> <br /> You have to implement an <strong>array-based</strong> <strong>circular queue</strong> in C# &ndash; a data structure that holds <strong>elements</strong> and follows FIFO (<strong>F</strong>irst <strong>I</strong>n, <strong>F</strong>irst <strong>O</strong>ut) behavior, with fixed internal <strong>capacity </strong>that doubles its size when filled:</p>
<p>In the figure above, the queue elements {12, 5, -2, 3, 4} stay in an array with fixed capacity of 8. The queue <strong>capacity</strong> is 8, the elements <strong>count</strong> is 5 and 3 cells stay empty. The startIndex points the <strong>first</strong> non-empty element in the queue. The endIndex points just after the last non-empty element in the queue &ndash; the place where the next coming element will be enqueued. Note that the queue is <strong>circular</strong>: after the element at the last position 7 comes the element at the first position 0.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Learn about Circular Queue in Wikipedia</h2>
<p>Before starting, get familiar with the concept of circular queue: <a href="https://en.wikipedia.org/wiki/circular_buffer">https://en.wikipedia.org/wiki/circular_buffer</a>.</p>
<p>The typical <strong>operations</strong> over a circular queue are <strong>enqueue</strong> / <strong>dequeue</strong> and <strong>get</strong> <strong>count</strong>. Let's start coding!</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CircularQueue&lt;T&gt; &ndash; Project Skeleton</h2>
<p>You are given a <strong>Visual Studio project skeleton</strong> (unfinished project) holding the unfinished CircularQueue&lt;T&gt; class and <strong>unit tests</strong> for its functionality. The project holds the following assets:</p>
<p>The project skeleton opens correctly in <strong>Visual Studio 2017</strong> but can be open in other Visual Studio versions as well and also can run in <strong>SharpDevelop</strong> and <strong>Xamarin Studio</strong>.</p>
<p>The main class stays in the file CircularQueue.cs:</p>
<table>
<tbody>
<tr>
<td width="693">
<p>public class CircularQueue&lt;T&gt;</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; private const int DefaultCapacity = 4;</p>
<p>&nbsp;&nbsp;&nbsp; public int Count { get; private set; }</p>
<p>&nbsp;&nbsp;&nbsp; public CircularQueue(int capacity = DefaultCapacity) { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public void Enqueue(T element) { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T Dequeue() { &hellip; }</p>
<p>&nbsp;&nbsp;&nbsp; public T[] ToArray() { &hellip; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>The project comes with <strong>unit tests</strong> covering the entire functionality of the circular queue (see the class UnitTestsCircularQueue):</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests to Ensure All of Them Initially Fail</h2>
<p><strong>Run the unit tests</strong> from the CircularQueue.Tests project. Right click on the file "UnitTestsCircularQueue.cs" in Solution Explorer and select <strong>[Run Unit Tests]</strong>:</p>
<p>The results is like this:</p>
<p>This is quite normal. We have unit tests, but the code covered by these tests is missing. Let's write it.</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Define the Queue Internal Data</h2>
<p>The first step is to define the inner <strong>data</strong> that holds the queue elements and the start + end indexes:</p>
<ul>
<li>T[] elements &ndash; an array that holds the queue elements
<ul>
<li>Non-empty cells hold elements</li>
<li>Empty cells are free for adding new elements</li>
<li>The array <strong>Length</strong> holds the queue <strong>capacity</strong></li>
</ul>
</li>
<li>int startIndex &ndash; holds the queue start index (the index of the first entered element in the queue)</li>
<li>int endIndex &ndash; holds the queue end index (the index in the array that follows the last queue element)</li>
<li>int Count &ndash; holds the number of elements in the queue</li>
</ul>
<p>The code might look like this:</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Implement the Queue Constructor</h2>
<p>Now, let's implement the queue constructor. Its purpose is to allocate the specified capacity of elements in the underlying array in the CircularQueue&lt;T&gt; class. The queue constructor has two forms:</p>
<ul>
<li>Parameterless constructor &ndash; should allocate 16 elements (16 is the default initial queue capacity)</li>
<li>Constructor with parameter capacity &ndash; allocates the specified capacity in the underlying array</li>
</ul>
<p>The code might look like the sample below (note that we have combined the above described two constructors in a single constructor through default parameter value). We also introduced the constant InitialCapacity to hold the initial queue capacity (16 elements):</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Implement the Enqueue(&hellip;) Method</h2>
<p>Now, we are ready to implement the Enqueue(element) method that appends a new element at the queue end:</p>
<p>How it works? First, if the queue is full, <strong>grow</strong> it (resize its capacity to 2 times bigger capacity). Next, put the new element at position endIndex (the index, just after the last queue element) + move the end index to point the position on the right of it + increase the internal elements counter Count.</p>
<p>Note that the queue is circular, so the element after the last element (this.elements.Length-1) is 0.</p>
<p>Thus, we have a <strong>formula</strong>: the next element after p comes at position (p + 1) % capacity. In the code we have:</p>
<p>(this.endIndex + 1) % this.elements.Length</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Implement the Grow() Method</h2>
<p>The Grow() method is called when the queue has filled its capacity (capacity == Count) and we are trying to add a new element. The Grow() method should allocate a new underlying array with <strong>doubled capacity</strong> and move all elements from the old array to the new array:</p>
<p>The code to grow the queue capacity might look like this:</p>
<p>An important part of the "<strong>grow</strong>" process is to <strong>copy the old array elements to the new array</strong>. This might be implemented as follows:</p>
<p>We use the already mentioned formula for the <strong>next element after</strong> sourceIndex:</p>
<p>nextIndex = (sourceIndex + 1) % capacity.</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Implement Dequeue() Method</h2>
<p>Next comes the Dequeue() method. Its purpose is to return and remove from the queue its first added element (the element at position startIndex). The code might look as follows:</p>
<p>How it works? If the queue is empty, an exception is thrown. Otherwise, the first queue element is taken (the element at position startIndex); the startIndex is moved to its next position; the Count is decreased.</p>
<p>Again, we use the same formula for the next element after startIndex:</p>
<p>nextIndex = (startIndex + 1) % capacity.</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Run the Unit Tests</h2>
<p>Now we have implemented the queue <strong>constructor</strong>, Enqueue(element) and Dequeue() methods. We are ready to <strong>run the unit tests</strong> to ensure they are correctly implemented. Most of the <strong>unit tests</strong> create a queue, enqueue / dequeue elements and then check whether the elements in the queue are as expected. For example, let's examine the following unit test:</p>
<p>This unit test creates a queue of strings, add an element to the queue (enqueue), removes an element from the queue (dequeue) and checks whether the queue is empty at the end and the element from the queue is the same like the element added to the queue earlier.</p>
<p>If we <strong>run the unit tests</strong>, some of them will now pass and some of them will still fail:</p>
<p>All tests, except the test for the unimplemented ToArray() method, pass successfully. We are almost done.</p>
<h2>Problem 10. Implement ToArray() Method</h2>
<p>Next, implement the ToArray() method. It should allocate an array with capacity of this.Count and <strong>copy all queue elements</strong> to it. We already have a method to copy the queue element to an array, so the code will be very short and easy to write. The code below is intentionally blurred. Try to write it alone.</p>
<p>Now <strong>run the unit tests</strong> again. You should have all the tests passed (green):</p>
<p>Congratulations! You have implemented your circular queue.</p>
<p>&nbsp;</p>