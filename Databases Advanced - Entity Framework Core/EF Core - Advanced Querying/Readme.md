<h1>Exercises: Advanced Querying</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h1>BookShop System</h1>
<p>For the following tasks, use the <a href="http://svn.softuni.org/admin/svn/csharp-databases/2017-Sept/DB-Advanced-EF-Core/06.%20DB-Advanced-EF-Core-Advanced-Querying/BookShop.zip">BookShop</a> database. You can download the complete project or create it yourself in <strong>task 0</strong>, but you should still use the pre-defined Seed() method from the project to have the same <strong>sample</strong> data.</p>
<h2>0.&nbsp;&nbsp; Book Shop Database</h2>
<p>You must create a <strong>database</strong> for a <strong>book</strong> <strong>shop</strong> <strong>system</strong>. It should look like this:</p>
<h3>Constraints</h3>
<p>Your <strong>namespaces</strong> should be:</p>
<ul>
<li>StartUp &ndash; for your <strong>StartUp</strong> class</li>
<li>Data &ndash; for your DbContext</li>
<li>Models &ndash; for your models</li>
</ul>
<p>Your <strong>models</strong> should be:</p>
<ul>
<li>BookShopContext &ndash; your DbContext</li>
<li>Author:
<ul>
<li>AuthorId</li>
<li>FirstName (up to 50 characters, unicode, not required)</li>
<li>LastName (up to 50 characters, unicode)</li>
</ul>
</li>
<li>Book:
<ul>
<li>BookId</li>
<li>Title (up to 50 characters, unicode)</li>
<li>Description (up to 1000 characters, unicode)</li>
<li>ReleaseDate (not required)</li>
<li>Copies (an integer)</li>
<li>Price</li>
<li>EditionType &ndash; enum (Normal, Promo, Gold)</li>
<li>AgeRestriction &ndash; enum (Minor, Teen, Adult)</li>
<li>Author</li>
<li>BookCategories</li>
</ul>
</li>
<li>Category:
<ul>
<li>CategoryId</li>
<li>Name (up to 50 characters, unicode)</li>
<li>CategoryBooks</li>
</ul>
</li>
<li>BookCategory &ndash; mapping class</li>
</ul>
<p>For the following tasks, you will be creating methods that accept a BookShopContext as a parameter and use it to run some queries. Create those methods inside your <strong>StartUp</strong> class and upload your whole solution to <strong>Judge</strong>.</p>
<h2>1.&nbsp;&nbsp; Age Restriction</h2>
<p>Create a <strong>method GetBooksByAgeRestriction</strong>(BookShopContext context, <strong>string</strong> <strong>command</strong>), that returns in a <strong>single</strong> <strong>string </strong>all book <strong>titles</strong>, each on a <strong>new line, </strong>that have<strong> age</strong> <strong>restriction</strong>, equal to the <strong>given</strong> <strong>command</strong>. Order the titles <strong>alphabetically</strong>.</p>
<p>Read <strong>input</strong> from the console in your <strong>main</strong> <strong>method</strong>, and call your <strong>method</strong> with the <strong>necessary</strong> <strong>arguments</strong>. Print the <strong>returned</strong> <strong>string</strong> to the console. <strong>Ignore</strong> casing of the input.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="286">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>miNor</p>
</td>
<td width="286">
<p>A Confederacy of Dunces</p>
<p>A Farewell to Arms</p>
<p>A Handful of Dust</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="64">
<p>teEN</p>
</td>
<td width="286">
<p>A Passage to India</p>
<p>A Scanner Darkly</p>
<p>A Swiftly Tilting Planet</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp; Golden Books</h2>
<p>Just like in task 1, write a method <strong>GetGoldenBooks</strong>(BookShopContext context), that returns in a <strong>single</strong> string <strong>titles of the golden edition books</strong> that have <strong>less than 5000 copies</strong>, each on a<strong> new line</strong>. Order them by <strong>book</strong> <strong>id</strong> ascending.</p>
<p>Call the <strong>GetGoldenBooks()</strong> method in your <strong>Main()</strong> and print the returned string to the console.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="313">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="313">
<p>Lilies of the Field</p>
<p>Look Homeward</p>
<p>The Mirror Crack'd from Side to Side</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp; Books by Price</h2>
<p>Write a <strong>GetBooksByPrice</strong>(BookShopContext context) method that returns in a single string all <strong>titles and prices</strong> <strong>of books</strong> with <strong>price higher than 40</strong>, each on a <strong>new</strong> <strong>row</strong> in the <strong>format</strong> given below. Order them by <strong>price</strong> descending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="284">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="284">
<p>O Pioneers! - $49.90</p>
<p>That Hideous Strength - $48.63</p>
<p>A Handful of Dust - $48.63</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Not Released In</h2>
<p>Write a <strong>GetBooksNotRealeasedIn</strong>(BookShopContext context<strong>, int year</strong>) method that returns in a <strong>single</strong> string all <strong>titles of books</strong> that are <strong>NOT released</strong> on a given year. Order them by <strong>book</strong> <strong>id</strong> ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="286">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>2000</p>
</td>
<td width="286">
<p>Absalom</p>
<p>Nectar in a Sieve</p>
<p>Nine Coaches Waiting</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="64">
<p>1998</p>
</td>
<td width="286">
<p>The Needle's Eye</p>
<p>No Country for Old Men</p>
<p>No Highway</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Book Titles by Category</h2>
<p>Write a <strong>GetBooksByCategory</strong>(BookShopContext context, string input) method that <strong>selects</strong> and <strong>returns </strong>in a single string the<strong> titles of books</strong> by a given <strong>list of categories</strong>. The list of <strong>categories</strong> will be given in a single line separated with one or more spaces. Ignore casing. Order by <strong>title</strong> alphabetically.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>horror mystery drama</p>
</td>
<td width="246">
<p>A Fanatic Heart</p>
<p>A Farewell to Arms</p>
<p>A Glass of Blessings</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp; Released Before Date</h2>
<p>Write a <strong>GetBooksReleasedBefore</strong>(BookShopContext context, string date) method that <strong>returns the title, edition type and price </strong>of all books that are <strong>released before a given date</strong>. The date will be a string <strong>in format dd-MM-yyyy</strong>.</p>
<p>Return all of the rows in a <strong>single</strong> string, ordered by <strong>release</strong> <strong>date</strong> <strong>descending</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="104">
<p><strong>Input</strong></p>
</td>
<td width="580">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>12-04-1992</p>
</td>
<td width="580">
<p>The Sun Also Rises - Normal - $20.40</p>
<p>Thrones - Promo - $21.41</p>
<p>Mr Standfast - Gold - $29.99</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="104">
<p>30-12-1989</p>
</td>
<td width="580">
<p>A Fanatic Heart - Normal - $9.41</p>
<p>The Curious Incident of the Dog in the Night-Time - Normal - $23.41</p>
<p>The Other Side of Silence - Gold - $46.26</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp; Author Search</h2>
<p>Write a <strong>GetAuthorNamesEndingIn</strong>(BookShopContext context, string input) method that returns the <strong>full</strong> <strong>names</strong> of <strong>authors</strong>, whose <strong>first</strong> <strong>name</strong> ends with a <strong>given</strong> <strong>string</strong>.</p>
<p>Return all <strong>names</strong> in a <strong>single</strong> <strong>string</strong>, each on a <strong>new</strong> <strong>row</strong>, ordered alphabetically.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="191">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>e</p>
</td>
<td width="191">
<p>George Powell</p>
<p>Jane Ortiz</p>
</td>
</tr>
<tr>
<td width="64">
<p>dy</p>
</td>
<td width="191">
<p>Randy Morales</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Book Search</h2>
<p>Write a <strong>GetBookTitlesContaining</strong>(BookShopContext context, string input) method that returns the <strong>titles</strong> of <strong>book</strong>, which contain a <strong>given</strong> <strong>string</strong>. Ignore casing.</p>
<p>Return all <strong>titles</strong> in a <strong>single</strong> <strong>string</strong>, each on a <strong>new</strong> <strong>row</strong>, ordered alphabetically.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="229">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>sK</p>
</td>
<td width="229">
<p>A Catskill Eagle</p>
<p>The Daffodil Sky</p>
<p>The Skull Beneath the Skin</p>
</td>
</tr>
<tr>
<td width="64">
<p>WOR</p>
</td>
<td width="229">
<p>Great Work of Time</p>
<p>Terrible Swift Sword</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp; Book Search by Author</h2>
<p>Write a <strong>GetBooksByAuthor</strong>(BookShopContext context, string input) method that <strong>returns all titles of books and their authors&rsquo; names </strong>for books, which are written by authors whose last names<strong> start with the given string</strong>.</p>
<p>Return a single string with each title on a new row. <strong>Ignore</strong> casing. Order by <strong>book</strong> <strong>id</strong> ascending.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="506">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>R</p>
</td>
<td width="506">
<p>The Heart Is Deceitful Above All Things (Bozhidara Rysinova)</p>
<p>His Dark Materials (Bozhidara Rysinova)</p>
<p>The Heart Is a Lonely Hunter (Bozhidara Rysinova)</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="64">
<p>po</p>
</td>
<td width="506">
<p>Postern of Fate (Stanko Popov)</p>
<p>Precious Bane (Stanko Popov)</p>
<p>The Proper Study (Stanko Popov)</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>10.&nbsp;&nbsp;&nbsp; Count Books</h2>
<p>Write a <strong>CountBooks</strong>(BookShopContext context, int lengthCheck) method that <strong>returns the number of books, </strong>which have a <strong>title longer than the number</strong> given as an input.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="66">
<p><strong>Output</strong></p>
</td>
<td width="446">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>12</p>
</td>
<td width="66">
<p>169</p>
</td>
<td width="446">
<p>There are 169 books with longer title than 12 symbols</p>
</td>
</tr>
<tr>
<td width="64">
<p>40</p>
</td>
<td width="66">
<p>2</p>
</td>
<td width="446">
<p>There are 2 books with longer title than 40 symbols</p>
</td>
</tr>
</tbody>
</table>
<h2>11.&nbsp;&nbsp;&nbsp; Total Book Copies</h2>
<p>Write a method <strong>CountCopiesByAuthor</strong>(BookShopContext context) that <strong>returns</strong> the <strong>total number of book copies</strong> <strong>for each author</strong>. Order the results <strong>descending by total book copies</strong>.</p>
<p>Return all results in a <strong>single</strong> <strong>string</strong>, each on a <strong>new</strong> <strong>line</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="208">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="208">
<p>Stanko Popov - 117778</p>
<p>Lyubov Ivanova - 107391</p>
<p>Jane Ortiz &ndash; 103673</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>12.&nbsp;&nbsp;&nbsp; Profit by Category</h2>
<p>Write a method <strong>GetTotalProfitByCategory</strong>(BookShopContext context) that <strong>returns</strong> the <strong>total profit of all books by category</strong>. Profit for a book can be calculated by multiplying its <strong>number of copies</strong> by the <strong>price per single book</strong>. Order the results by <strong>descending by total profit</strong> for category and <strong>ascending by category name</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="264">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="264">
<p>Art $6428917.79</p>
<p>Fantasy $5291439.71</p>
<p>Adventure $5153920.77</p>
<p>Children's $4809746.22</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>13.&nbsp;&nbsp;&nbsp; Most Recent Books</h2>
<p>Get the most recent books by categories in a <strong>GetMostRecentBooks</strong>(BookShopContext context) method. The <strong>categories</strong> should be ordered by <strong>total</strong> <strong>book count</strong>. Only take the <strong>top 3</strong> most recent books from each category - ordered by <strong>release date</strong> (descending). <strong>Select</strong> and <strong>print</strong> the <strong>category name</strong>, and for each <strong>book</strong> &ndash; its <strong>title</strong> and <strong>release year</strong>.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="434">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="434">
<p>--Action</p>
<p>Brandy of the Damned (2015)</p>
<p>Bonjour Tristesse (2013)</p>
<p>By Grand Central Station I Sat Down and Wept (2010)</p>
<p>--Adventure</p>
<p>The Cricket on the Hearth (2013)</p>
<p>Dance Dance Dance (2002)</p>
<p>Cover Her Face (2000)</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>14.&nbsp;&nbsp;&nbsp; Increase Prices</h2>
<p>Write a method <strong>IncreasePrices</strong>(BookShopContext context) that <strong>increases the prices of all books</strong> <strong>released before 2010 by 5</strong>.</p>
<h2>15.&nbsp;&nbsp;&nbsp; Remove Books</h2>
<p>Write a method <strong>RemoveBooks</strong>(BookShopContext context) that <strong>removes from the database</strong> those <strong>books</strong>, which have less than <strong>4200 copies</strong>. Return an <strong>int</strong> - the <strong>number of books that were deleted</strong> from the database.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="201">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="201">
<p>34 books were deleted</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>