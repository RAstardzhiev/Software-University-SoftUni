<h1>Exercises: Entity Framework Code First</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/courses/databases-advanced-entity-framework">"Databases Advanced &ndash; Entity Framework" course @ Software University.</a></p>
<h2>1.&nbsp;&nbsp; Local Store</h2>
<p>Imagine that you are hired by baba Gicka to create a database for her local store. The database should only have one table &ndash; it&rsquo;s called <strong>Products</strong>. Products should have name, distributor name, description and price. Insert some sample data in the products table (at least <strong>3 rows</strong>). Create the database using the Code First approach.</p>
<h2>2.&nbsp;&nbsp; Local Store Improvement</h2>
<p>Baba Gicka was satisfied with the <strong>database</strong> you have made, but she wants to make a <strong>change</strong> &ndash; now every product should have <strong>weight</strong> and <strong>quantity</strong>.</p>
<p>Everything was chill until you said that you have to make a migration in order to apply the new changes. Baba Gicka said that she hates birds and she is terrified from migrations. She <strong>forbids</strong> you to use any sort of <strong>migrations</strong>. Your task is to create a new up-to-date database. Keep in mind that you should not lose any data as well!</p>
<h3>Constraints/Hints</h3>
<p>You could delete (with <strong>MSSMS</strong>) and re-create the same database (with the updated table).</p>
<p>You could <strong>change</strong> the database <strong>initializer</strong> to more suitable (you could even implement your own one).</p>
<p>For saving the data you could <strong>script</strong> it to <strong>SQL</strong> file or <strong>save</strong> it in a <strong>CSV</strong> file (yes, you can <a href="https://support.discountasp.net/kb/a1179/how-to-import-a-csv-file-into-a-database-using-sql-server-management-studio.aspx">import</a>/<a href="http://stackoverflow.com/questions/17471994/export-from-sql-server-2012-to-csv-through-management-studio">export</a> data from <a href="http://www.computerhope.com/jargon/c/csv.htm">file</a>) and re-import it.</p>
<p>The above statements are just <strong>suggestions</strong> and you may not follow them but you are <strong>not</strong> <strong>allowed</strong> you use <strong>migrations</strong> in any form!</p>
<h2>3.&nbsp;&nbsp; Sales Database</h2>
<p>Create database for storing data about sales using the Code First approach. The database should have the following tables:</p>
<ul>
<li><strong>Product</strong> (Id, Name, Quantity, Price)</li>
<li><strong>Customer</strong> (Id, Name, Email, CreditCardNumber)</li>
<li><strong>StoreLocation</strong> (Id, LocationName)</li>
<li><strong>Sale</strong> (Id, ProductId, CustomerId, StoreLocationId, Date)</li>
</ul>
<p>The relationships between tables are as follows:</p>
<ul>
<li>Sale has one product and a product can be sold in many sales</li>
<li>Sale has one customer and a customer can participate in many sales</li>
<li>Sale has one store location and one store location can have many sales</li>
</ul>
<p>Write a <strong>seed method</strong> that fills the database with sample data (randomly generated). Configure Entity Framework to run the <strong>Seed()</strong> method after the database is created for the first time.</p>
<p>Run the application several times to ensure that it seeds sample data <strong>only</strong> <strong>once</strong>. Let the Seed() method insert 5 rows in every table.</p>
<h3>Hint</h3>
<p>You can use the following format to design your model classes</p>
<ul>
<li><strong>Product</strong>
<ul>
<li>int Id</li>
<li>string Name</li>
<li>double Quantity</li>
<li>decimal Price</li>
<li>ICollection&lt;Sale&gt; SalesOfProduct</li>
</ul>
</li>
<li><strong>Customer</strong>
<ul>
<li>int Id</li>
<li>string Name</li>
<li>string Email</li>
<li>string CreditCardNumber</li>
<li>ICollection&lt;Sale&gt; SalesForCustomer</li>
</ul>
</li>
<li><strong>StoreLocation</strong>
<ul>
<li>int Id</li>
<li>LocationName</li>
<li>ICollection&lt;Sale&gt; SalesInStore</li>
</ul>
</li>
<li><strong>Sale</strong>
<ul>
<li>int Id</li>
<li>Product Product</li>
<li>Customer Customer</li>
<li>StoreLocation StoreLocation</li>
<li>DateTime Date</li>
</ul>
</li>
</ul>
<p>Remember to initialize ICollection&lt;Sale&gt; in the constructor of the class to avoid null pointer exceptions. <br /> You could use <strong>&ldquo;</strong>CreateDatabaseIfNotExists<strong>&rdquo;</strong> as database initializing strategy.</p>
<h2>4.&nbsp;&nbsp; Products Migration</h2>
<p>For table Products add string column Description. You should use migrations. Current migration should be called: &ldquo;ProductsAddColumnDescription&rdquo;. Add default value for the description property: <br /> &ldquo;No description&rdquo;.</p>
<h2>5.&nbsp;&nbsp; Sales Migration</h2>
<p>For table Sales make Date column with default value GETDATE() function, called from the database &ndash; not the application. Use explicit Migration. Do <strong>not</strong> use DateTime.Now(). Name the migration: &ldquo;SalesAddDateDefault&rdquo;.</p>
<p>After that open your table data and see if the default value is applied or not.</p>
<h3>Hints</h3>
<p>Add new empty migration. In the Up() method we can paste the logic for the altering the table:</p>
<p>Make sure the Down() method to be adequate too:</p>
<p>Then simply update the database and check if new constraint is added (you can see in MSSMS).</p>
<h2>6.&nbsp;&nbsp; Customers Migration</h2>
<p>Enable automatic migrations and also enable data loss when migration is happening. Modify table Customers: remove Name column and add another two properties: FistName and LastName. Modify the Seed() method too in order to insert proper data. Then simply update database (without the Add-Migration command).</p>
<h3>Hints</h3>
<p>To enable automatic migrations change the constructor of the Configuration class:</p>
<p>Simply add the new properties in the Customer class:</p>
<p>After that run the update database command.</p>
<h2>7.&nbsp;&nbsp; Add Default Age</h2>
<p>In table Customers add new property Age. Set default value of 20. Do not change the Seed() method.</p>
<p>After that open your table data and see if the default value is applied or not.</p>
<h2>8.&nbsp;&nbsp; *Script Migration</h2>
<p>Your DBA asked you to present the SQL script (&ldquo;ALTER TABLE&hellip;&rdquo;) executed by <strong>EntityFramework</strong> from the last migration.</p>
<h3>Example</h3>
<p>In the end you should have script similar to this one:</p>
<p>The &ldquo;<strong>ALTER TABLE &hellip;</strong>&rdquo; statement makes the actual changes to the table while the &ldquo;<strong>INSERT &hellip;</strong>&rdquo; preserves migrations history.</p>
<p>Note that the query data in the second query is most likely to be <strong>different</strong>!</p>
<h3>Hints</h3>
<p>First rollback the changes made with the last migration:</p>
<ul>
<li>Find the name of the second last migration (you can see it in the MigrationsTable)</li>
<li>Then run<strong> &ldquo;</strong>Update-Database -TargetMigration &lt;migrationName&gt;&rdquo;</li>
</ul>
<p>Second update the database again but this time use the &ldquo;-Script&rdquo; command within. Query window should popup displaying script almost identical to the above one (in the picture).</p>
<p>Lastly see in your database if the migration has been applied (it should not). So what you need is again to run update database command, this time do not add anything specific.</p>