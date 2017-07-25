<h1>Lab: Iterators and Comparators</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/java-oop-advanced">"C# OOP Advanced" course @ Software University</a>. You can check your solutions here: <a href="https://judge.softuni.bg/Contests/707/Iterators-and-Comparators-Lab">https://judge.softuni.bg/Contests/707/Iterators-and-Comparators-Lab</a></p>
<h2>1.&nbsp;&nbsp; Library</h2>
<p>Create a class <strong>Book</strong> which should have three public properties:</p>
<ul>
<li><strong>string Title</strong></li>
<li><strong>int Year</strong></li>
<li><strong>List&lt;string&gt; Authors</strong></li>
</ul>
<p>Authors can be <strong>anonymous, one or many</strong>. A Book should have only <strong>one</strong> <strong>constructor</strong>.</p>
<p>Create a class <strong>Library</strong> which should store a collection of books and implement the <strong>IEnumerable&lt;Book&gt;</strong> interface.</p>
<ul>
<li><strong>List&lt;Book&gt;</strong><strong> books</strong></li>
</ul>
<p>A Library should be could be intilized without books or with any number of books and should have only <strong>one</strong> <strong>constructor</strong>.</p>
<h3>Examples</h3>
<table width="709">
<tbody>
<tr>
<td width="709">
<p>Startup.cs</p>
</td>
</tr>
<tr>
<td width="709">
<p>&nbsp;public static void Main()</p>
<p>&nbsp;{</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookOne = new Book("Animal Farm", 2003, "George Orwell");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookThree = new Book("The Documents in the Case", 1930);</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Library libraryOne = new Library();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Library libraryTwo = new Library(bookOne, bookTwo, bookThree);</p>
<p>&nbsp;}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>&nbsp;</h2>
<h2>2.&nbsp;&nbsp; Library Iterator</h2>
<p>Extend your solution from the prevoius task. Inside the Library class create a <strong>nested class</strong> <strong>LibraryIterator</strong> which should implement the <strong>IEnumerator&lt;Book&gt;</strong> interface. Try to implement the bodies of the inherited methods by yourself. You will need two more members:</p>
<ul>
<li><strong>List&lt;Book&gt; books</strong></li>
<li><strong>int currentIndex</strong></li>
</ul>
<p>Now you should be able to iterate through a Library in the Main method.</p>
<h3>Examples</h3>
<table width="709">
<tbody>
<tr>
<td width="709">
<p>Startup.cs</p>
</td>
</tr>
<tr>
<td width="709">
<p>&nbsp;public static void Main()</p>
<p>&nbsp;{</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookOne = new Book("Animal Farm", 2003, "George Orwell");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookThree = new Book("The Documents in the Case", 1930);</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Library libraryOne = new Library();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Library libraryTwo = new Library(bookOne, bookTwo, bookThree);</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; foreach (var book in libraryFull)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Console.WriteLine(book.Title);</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="435">
<tbody>
<tr>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="435">
<p>Animal Farm</p>
<p>The Documents in the Case</p>
<p>The Documents in the Case</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Comparable Book</h2>
<p>Extend your solution from the prevoius task. Implement the <strong>IComparable&lt;Book&gt;</strong> interface in the existing class <strong>Book</strong>. The comparison between two books should happen in the following order:</p>
<ul>
<li>First sort them in <strong>ascending </strong><strong>chronological</strong> order (by year)</li>
<li>If two books are published in the <strong>same year</strong>, sort them <strong>alphabetically</strong></li>
</ul>
<p>Override the <strong>ToString()</strong> method in your Book class so it returns a string in the format:</p>
<ul>
<li>{<strong>title</strong>} - {<strong>year</strong>}</li>
</ul>
<p>Change your Library class so that it stores the books in the correct order.</p>
<p>You don&rsquo;t need to change anything in your <strong>Main</strong> method from the previous task except for the way to print a book on the Console.</p>
<h3>Examples</h3>
<table width="435">
<tbody>
<tr>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="435">
<p>The Documents in the Case - 1930</p>
<p>The Documents in the Case - 2002</p>
<p>Animal Farm - 2003</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>4.&nbsp;&nbsp; Book Comparator</h2>
<p>Extend your solution from the prevoius task. Create a class <strong>BookComparator</strong> which should implement the <strong>IComparer&lt;Book&gt;</strong> interface and thus include the following method:</p>
<ul>
<li><strong>int Compare(Book, Book) </strong></li>
</ul>
<p><strong>BookComparator</strong> must <strong>compare</strong> two books by:</p>
<ol>
<li>Book title - <strong>alphabetical order</strong></li>
<li>Year of publishing a book - <strong>from the newest to the oldest</strong></li>
</ol>
<p>Modify your Library class once again to implement the <strong>new sorting</strong>.</p>
<h3>Examples</h3>
<table width="709">
<tbody>
<tr>
<td width="709">
<p>Startup.cs</p>
</td>
</tr>
<tr>
<td width="709">
<p>&nbsp;public static void Main()</p>
<p>&nbsp;{</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookOne = new Book("Animal Farm", 2003, "George Orwell");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Book bookThree = new Book("The Documents in the Case", 1930);</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="435">
<tbody>
<tr>
<td width="435">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="435">
<p>Animal Farm - 2003</p>
<p>The Documents in the Case &ndash; 2002</p>
<p>The Documents in the Case - 1930</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>