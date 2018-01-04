<h1>Entity Framework Core: Exam</h1>
<p>Exam problems for the <a href="https://softuni.bg/courses/databases-advanced-entity-framework">Databases Advanced - Entity Framework course @ SoftUni</a>. Submit your solutions in the SoftUni judge system (delete all "bin"/"obj" folders alongside with the "packages" folder).</p>
<p>Your task is to create a database application using <strong>Entity Framework Core</strong> using the <strong>Code First</strong> approach. Design the <strong>domain models</strong> and <strong>methods</strong> for manipulating the data, as described below.</p>
<h1>Fast Food</h1>
<p>Create an application which models a <strong>fast food point of sale system</strong>. Employees process orders for customers. Orders have items inside them. Each category has zero or more items. For more details about the <strong>models</strong> and their <strong>relations</strong> read further.</p>
<h2>Project Skeleton Overview</h2>
<p>You are given a <strong>project skeleton</strong>, which includes the following items:</p>
<ul>
<li>App &ndash; contains the Startup class, which is the <strong>entry point of the application</strong>. Also contains an AutoMapper profile, which you can configure if you choose to use AutoMapper in your app.</li>
<li>Data &ndash; contains the FastFoodDbContext class and the <strong>connection string</strong></li>
<li>Models &ndash; contains the <strong>entity classes</strong></li>
<li>DataProcessor &ndash; contains the Serializer and Deserializer classes, which are used for <strong>importing </strong>and <strong>exporting </strong>data</li>
</ul>
<h2>Problem 1. Model Definition (50 pts)</h2>
<p>Every employee has a <strong>position</strong> and <strong>orders</strong>, which they need to process. Every <strong>order</strong> has a <strong>customer</strong>,<strong> order date</strong> and a <strong>list of items</strong>. Every item has a <strong>category</strong>, a <strong>name </strong>and a <strong>price</strong>. <strong>Categories</strong> have a <strong>list of items</strong>.</p>
<p><strong><em>Note: Foreign key navigation properties are required! </em></strong></p>
<p>The application needs to store the following data:</p>
<h3>Employee</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>min length</strong> <strong>3 </strong>and <strong>max length 30</strong> (<strong>required</strong>)</li>
<li>Age &ndash; integer <strong>in the</strong> <strong>range</strong> <strong>[15, 80]</strong> (<strong>required</strong>)</li>
<li>PositionId &shy;&ndash; integer, <strong>foreign key</strong></li>
<li>Position &ndash; the employee&rsquo;s <strong>position</strong> (<strong>required</strong>)</li>
<li>Orders &ndash; the <strong>orders</strong> the employee has processed</li>
</ul>
<h3>Position</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>min length</strong> <strong>3 </strong>and<strong> max length 30</strong> (<strong>required, unique</strong>)</li>
<li>Employees &ndash; Collection of type Employee</li>
</ul>
<h3>Category</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>min length 3 </strong>and <strong>max length 30</strong> (<strong>required</strong>)</li>
<li>Items &ndash; collection of type Item</li>
</ul>
<h3>Item</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>min length 3 </strong>and <strong>max length 30</strong> (<strong>required, unique</strong>)</li>
<li>CategoryId &ndash; integer, foreign key</li>
<li>Category &ndash; the item&rsquo;s <strong>category </strong>(<strong>required</strong>)</li>
<li>Price &ndash; decimal (<strong>non-negative, minimum value: 0.01</strong>, <strong>required</strong>)</li>
<li>OrderItems &ndash; collection of type OrderItem</li>
</ul>
<h3>Order</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Customer &ndash; <strong>text (</strong><strong>required</strong><strong>)</strong></li>
<li>DateTime &ndash; <strong>date and time of the order (</strong><strong>required</strong><strong>)</strong></li>
<li>Type<strong> &ndash; </strong>OrderType <strong>enumeration with possible values: &ldquo;</strong>ForHere<strong>, </strong>ToGo<strong> (default: </strong>ForHere<strong>)&rdquo; (</strong><strong>required</strong><strong>)</strong></li>
<li>TotalPrice &ndash; decimal value (calculated property, <strong>(not mapped to database)</strong>, <strong>required</strong>)</li>
<li>EmployeeId &ndash; integer, <strong>foreign key</strong></li>
<li>Employee &ndash; The employee who will process the order (<strong>required</strong>)</li>
<li>OrderItems &ndash; collection of type OrderItem</li>
</ul>
<h3>OrderItem</h3>
<ul>
<li>OrderId &ndash; integer, <strong>Primary Key</strong></li>
<li>Order &ndash; the item&rsquo;s <strong>order</strong> (<strong>required</strong>)</li>
<li>ItemId &ndash; integer, Primary Key</li>
<li>Item &ndash; the order&rsquo;s item (<strong>required</strong>)</li>
<li>Quantity &ndash; the quantity of the <strong>item</strong> in the <strong>order</strong> (<strong>required</strong>, <strong>non-negative</strong> and <strong>non-zero</strong>)</li>
</ul>
<h2>Problem 2. Data Import (30pts)</h2>
<p>For the functionality of the application, you need to create several methods that manipulate the database. The <strong>project skeleton</strong> already provides you with these methods, inside the FastFood.DataProcessor project inside your solution. Use <strong>Data Transfer Objects</strong> as needed.</p>
<p>Use the provided <strong>JSON</strong> and <strong>XML</strong> files to populate the database with data. Import all the information from those files into the database.</p>
<p>You are <strong>not allowed</strong> to modify the provided JSON and XML files.</p>
<p><strong>If a record does not meet the requirements from the first section, print an error message:</strong></p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid data format.</p>
</td>
</tr>
</tbody>
</table>
<h3>JSON Import (20 pts)</h3>
<h4>Import Employees</h4>
<p>Using the file <strong>employees.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<h5>Constraints</h5>
<ul>
<li>If any validation errors occur (such as if their <strong>name</strong> <strong>or position are too long/short </strong>or their <strong>age </strong>is out of range) proceed as described above</li>
<li>If a position <strong>doesn&rsquo;t exist yet</strong> (and the position and rest of employee data is <strong>valid</strong>), <strong>create it</strong>.</li>
<li>If an employee is <strong>invalid</strong>, <strong>do not </strong>import their <strong>position</strong>.</li>
</ul>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>employees.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "N",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 20,</p>
<p>&nbsp;&nbsp;&nbsp; "Position": "Invalid"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Too Young",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 14,</p>
<p>&nbsp;&nbsp;&nbsp; "Position": "Invalid"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Too Old",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 81,</p>
<p>&nbsp;&nbsp;&nbsp; "Position": "Invalid"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Invalid Position",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 20,</p>
<p>&nbsp;&nbsp;&nbsp; "Position": ""</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "InvalidPosition",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 20,</p>
<p>&nbsp;&nbsp;&nbsp; "Position": "Invaliddddddddddddddddddddddddd"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp; &nbsp;"Name": "Magda&nbsp;Bjork",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 44,</p>
<p>&nbsp;&nbsp;&nbsp; "Position": "CEO"</p>
<p>&nbsp; },</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Record Magda&nbsp;Bjork successfully imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h4>Import Items</h4>
<p>Using the file <strong>items.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<h5>Constraints</h5>
<ul>
<li>If any validation errors occur (such as invalid item name or invalid category name), <strong>ignore </strong>the entity and <strong>print an error message</strong>.</li>
<li>If an item with the same name <strong>already exists</strong>, <strong>ignore </strong>the entity and <strong>do not import it</strong>.</li>
<li>If an item&rsquo;s category <strong>doesn&rsquo;t exist</strong>, <strong>create it</strong> along with the item.</li>
</ul>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>items.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Hamburger",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 0.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Invalid"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Hamburger",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": -5.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Invalid"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "x",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 1.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Invalid"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Invaliddddddddddddddddddddddddd",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 1.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Invalid"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Invalid",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 1.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "x"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Invalid",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 1.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Invaliddddddddddddddddddddddddd"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Hamburger",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 5.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Beef"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Hamburger",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 1.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Beef"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Cheeseburger",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 6.00,</p>
<p>&nbsp;&nbsp;&nbsp; "Category": "Beef"</p>
<p>&nbsp; },</p>
<p>&hellip;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Invalid data format.</p>
<p>Record Hamburger successfully imported.</p>
<p>Invalid data format.</p>
<p>Record Cheeseburger successfully imported.</p>
</td>
</tr>
</tbody>
</table>
<h3>XML Import (10 pts)</h3>
<h4>Import Orders</h4>
<p>Using the file <strong>orders.xml</strong>, import the data from the file into the database. Print information about each imported object in the format described below.</p>
<p>If any of the model requirements is violated continue with the next entity.</p>
<h5>Constraints</h5>
<ul>
<li>The order dates will be in the format &ldquo;dd/MM/yyyy HH:mm&rdquo;. Make sure you use InvariantCulture.</li>
<li>If the order&rsquo;s <strong>employee</strong> doesn&rsquo;t exist, <strong>do not </strong>import the order.</li>
<li>If <strong>any</strong> of the <strong>order&rsquo;s</strong> <strong>items </strong>do not exist, <strong>do not </strong>import the order.</li>
<li>If there are any other validation errors (such as <strong>negative</strong> or <strong>non-zero price</strong>), proceed as described above.</li>
<li>Every employee will have a <strong>unique name</strong></li>
</ul>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>orders</strong><strong>.xml</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;Orders&gt;</p>
<p>&nbsp; &lt;Order&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Customer&gt;Garry&lt;/Customer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Employee&gt;Maxwell Shanahan&lt;/Employee&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;DateTime&gt;21/08/2017 13:22&lt;/DateTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Type&gt;ForHere&lt;/Type&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Items&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Quarter Pounder&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Quantity&gt;2&lt;/Quantity&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Premium chicken sandwich&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Quantity&gt;2&lt;/Quantity&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Chicken Tenders&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Quantity&gt;4&lt;/Quantity&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Just Lettuce&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Quantity&gt;4&lt;/Quantity&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Item&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Items&gt;</p>
<p>&nbsp; &lt;/Order&gt;</p>
<p>...</p>
<p>&lt;/Orders&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Order for Garry on 21/08/2017 13:22 added</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3. Data Export (20 pts)</h2>
<p><strong>Use the provided methods in the </strong>FastFood.DataProcessor <strong>project.</strong> Usage of <strong>Data Transfer Objects</strong> is <strong>optional</strong>.</p>
<h3>JSON Export (10 pts)</h3>
<h4>Export All Orders by Employee</h4>
<p>The given method in the project skeleton receives an <strong>employee name</strong> and an <strong>order type </strong>as <strong>strings</strong>. Export all <strong>orders</strong> that were processed by the <strong>employee</strong> with that <strong>name</strong>, which have <strong>that order type</strong>. For each order, get the customer&rsquo;s <strong>name</strong> and the <strong>order&rsquo;s</strong> <strong>items</strong> with their <strong>name</strong>, <strong>price </strong>and <strong>quantity</strong>. Apart from that, for every order, also list the <strong>total price</strong> of the order. Sort the orders by their <strong>total price</strong> (<strong>descending</strong>), then by the <strong>number of items </strong>in the order (<strong>descending</strong>). Finally, also export the <strong>total money made </strong>from all the orders.</p>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Serializer.ExportOrdersByEmployee(context, "Avery Rush", "ToGo")</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>{</p>
<p>&nbsp; "Name": "Avery&nbsp;Rush",</p>
<p>&nbsp; "Orders": [</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Customer": "Stacey",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Items": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Cheeseburger",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 6.00,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 5</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Double Cheeseburger",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 6.50,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 3</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Luigi",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 2.10,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 5</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Bacon Deluxe",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 9.00,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 1</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TotalPrice": 69.00</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Customer": "Pablo",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Items": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Double Cheeseburger",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 6.50,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 3</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;},</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Bacon Deluxe",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 9.00,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 5</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TotalPrice": 64.50</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Customer": "Bobbie",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Items": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Tuna Salad",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 3.00,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 2</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Crispy Fries",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 2.00,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 5</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Fries",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 1.50,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 2</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;}</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TotalPrice": 19.00</p>
<p>&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Customer": "Joann",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Items": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Minion",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 2.20,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 2</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Name": "Bacon Deluxe",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Price": 9.00,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Quantity": 1</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "TotalPrice": 13.40</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; ],</p>
<p>&nbsp; "TotalMade": 165.90</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>XML Export (10 pts)</h3>
<h4>Export Categories with their Most Popular Item</h4>
<p>Use the method provided in the project skeleton, which receives a string of <strong>comma-separated category names</strong>. Export the <strong>categories</strong>: for each <strong>category</strong>, export its <strong>most popular item</strong>. The most popular item is the item from the category, which made the <strong>most money</strong> in <strong>orders</strong>. <strong>Sort</strong> the categories by <strong>the amount of money the most popular item made (descending)</strong>, then by <strong>the times the item was sold</strong> (<strong>descending</strong>).</p>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Serializer.ExportCategoryStatistics(context, "Chicken,Drinks,Toys")</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;Categories&gt;</p>
<p>&nbsp; &lt;Category&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Chicken&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;MostPopularItem&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Chicken Tenders&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;TotalMade&gt;44.00&lt;/TotalMade&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;TimesSold&gt;11&lt;/TimesSold&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/MostPopularItem&gt;</p>
<p>&nbsp; &lt;/Category&gt;</p>
<p>&nbsp; &lt;Category&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Toys&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;MostPopularItem&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Minion&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;TotalMade&gt;24.20&lt;/TotalMade&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;TimesSold&gt;11&lt;/TimesSold&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/MostPopularItem&gt;</p>
<p>&nbsp; &lt;/Category&gt;</p>
<p>&nbsp; &lt;Category&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Drinks&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;MostPopularItem&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Purple Drink&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;TotalMade&gt;9.10&lt;/TotalMade&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;TimesSold&gt;7&lt;/TimesSold&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/MostPopularItem&gt;</p>
<p>&nbsp; &lt;/Category&gt;</p>
<p>&lt;/Categories&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4. Bonus Task (10 pts)</h2>
<p><strong>Implement the bonus method in the </strong>FastFood.DataProcessor <strong>project for an </strong><strong>additional amount</strong><strong> of points</strong>.</p>
<h3>Update Item Price</h3>
<p>Implement the method DataProcessor.Bonus.UpdateItemPrice, which receives an item&rsquo;s <strong>name</strong> and a <strong>new</strong> <strong>price</strong>. Your task is to <strong>find the item</strong> by that name and <strong>update its price</strong>.</p>
<p>After the price is updated, return the message &ldquo;{item.Name} Price updated from ${oldPrice:F2} to ${newPrice:F2}&rdquo;.</p>
<p>If the item is not found, return &ldquo;Item {item.Name} not found!&rdquo;</p>
<h4>Examples</h4>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>DataProcessor.Bonus.UpdateItemPrice(context, "Cheeseburger", 6.50m)</p>
</td>
</tr>
<tr>
<td width="695">
<p>Cheeseburger Price updated from $6.00 to $6.50</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>DataProcessor.Bonus.UpdateItemPrice(context, "Ribs", 8.00m)</p>
</td>
</tr>
<tr>
<td width="695">
<p>Item Ribs not found!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>