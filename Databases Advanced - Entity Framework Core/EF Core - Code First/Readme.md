<h1>Exercises: Code First</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hospital Database</h2>
<p>You went to your GP for your annual exam and you told him that you&rsquo;ve started work as a Junior Database App Developer. It turned out he was looking for someone to make an app, which he could use to manage and store data about his patients.</p>
<p>Your task is to design a database using the <strong>Code</strong> <strong>First</strong> approach. The GP needs to keep information about his <strong>patients</strong>. Each patient has <strong>first name</strong>, <strong>last name</strong>, <strong>address</strong>, <strong>email</strong>, <strong>date</strong> <strong>of</strong> <strong>birth</strong>, information whether he has <strong>medical</strong> <strong>insurance</strong> or not and should keep history about all his <strong>visitations</strong>, <strong>diagnoses</strong> and <strong>prescribed</strong> <strong>medicaments</strong>. Each visitation has <strong>date</strong> and <strong>comments</strong>. Each <strong>diagnose</strong> has <strong>name</strong> and <strong>comments</strong> for it. Each <strong>medicament</strong> has <strong>name</strong>. <strong>Validate</strong> all data before inserting it in the database.</p>
<p>Your Database should look something like this:<br /> Remember! With Entity Framework Core you can have <strong>different</strong> <strong>column</strong> <strong>names</strong> from your <strong>classes&rsquo;</strong> <strong>property</strong> <strong>names</strong>!</p>
<h3>Constraints</h3>
<p>Your <strong>namespaces</strong> should be:</p>
<ul>
<li>P01_HospitalDatabase &ndash; for your Startup class, if you have one</li>
<li>Data &ndash; for your DbContext</li>
<li>Data.Models &ndash; for your models</li>
</ul>
<p>Your <strong>classes</strong> should be:</p>
<ul>
<li>HospitalContext &ndash; your DbContext</li>
<li>Patient:
<ul>
<li>PatientId</li>
<li>FirstName (up to 50 characters, unicode)</li>
<li>LastName (up to 50 characters, unicode)</li>
<li>Address (up to 250 characters, unicode)</li>
<li>Email (up to 80 characters, not unicode)</li>
<li>HasInsurance</li>
</ul>
</li>
<li>Visitation:
<ul>
<li>VisitationId</li>
<li>Date</li>
<li>Comments (up to 250 characters, unicode)</li>
<li>Patient</li>
</ul>
</li>
<li>Diagnose:
<ul>
<li>DiagnoseId</li>
<li>Name (up to 50 characters, unicode)</li>
<li>Comments (up to 250 characters, unicode)</li>
<li>Patient</li>
</ul>
</li>
<li>Medicament:
<ul>
<li>MedicamentId</li>
<li>Name (up to 50 characters, unicode)</li>
</ul>
</li>
<li>PatientMedicament &ndash; mapping class between Patients and Medicaments</li>
</ul>
<p>The <strong>collections</strong> of mapping classes (ICollection&lt;PatientMedicament&gt;) must be named <strong>Prescriptions</strong>!</p>
<p>Don&rsquo;t forget to remove the <strong>Tools </strong>package before uploading your project to Judge, if you have used it!</p>
<h3>Bonus Task</h3>
<p>Make a console-based user interface, so the doctor can easily use the database.</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Hospital Database Modification</h2>
<p>Your GP bragged around in the hospital about the cool software you made for him. Now the hospital administration wants to modify your program so they can use it too. They want to store information about the <strong>doctors</strong> (<strong>name</strong> and <strong>specialty</strong>). Each doctor can perform <strong>many</strong> <strong>visitations</strong>. Make the necessary changes in the <strong>database</strong> to satisfy the new needs of the hospital administration. When <strong>migrating</strong> to the new database schema make sure, no <strong>data</strong> is lost. If you have created an interface, change it as well.</p>
<h3>Constraints</h3>
<p>Keep the <strong>namespaces </strong>from the previous task and only add the class <strong>Doctor </strong>and change the class <strong>Visitation </strong>accordingly. The doctor&rsquo;s <strong>name</strong> and <strong>specialty</strong> should be up to 100 <strong>characters</strong> long, <strong>unicode</strong>.</p>
<h3>**Bonus Task</h3>
<p>Make an authentication system for doctors. Each <strong>doctor</strong> should be able to log in with his <strong>email</strong> and <strong>password</strong>. Choose what information each doctor should have access to and hide the rest.</p>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sales Database</h2>
<h3>Create a database for storing data about sales using the Code First approach. The database should look like this:<br /> <br /> Constraints</h3>
<p>Your <strong>namespaces</strong> should be:</p>
<ul>
<li>P03_SalesDatabase</li>
<li>Data</li>
<li>Data.Models</li>
</ul>
<p>Your <strong>classes</strong> should be:</p>
<ul>
<li>SalesContext &ndash; your DbContext</li>
<li>Product:
<ul>
<li>ProductId</li>
<li>Name (up to 50 characters, unicode)</li>
<li>Quantity (real number)</li>
<li>Price</li>
<li>Sales</li>
</ul>
</li>
<li>Customer:
<ul>
<li>CustomerId</li>
<li>Name (up to 100 characters, unicode)</li>
<li>Email (up to 80 characters, not unicode)</li>
<li>CreaditCardNumber (string)</li>
<li>Sales</li>
</ul>
</li>
<li>Store:
<ul>
<li>StoreId</li>
<li>Name (up to 80 characters, unicode)</li>
<li>Sales</li>
</ul>
</li>
<li>Sale:
<ul>
<li>SaleId</li>
<li>Date</li>
<li>Product</li>
<li>Customer</li>
<li>Store</li>
</ul>
</li>
</ul>
<h3>Bonus Task</h3>
<p>Write a <strong>seed method</strong> that fills the database with sample data (randomly generated).</p>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Products Migration</h2>
<p>For table Products add string column Description, up to 250 symbols. Use migrations. The migration should be named: "ProductsAddColumnDescription". Add a default value for the description property: "No description".</p>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Sales Migration</h2>
<p>For table Sales make Date column with default value GETDATE() function, called from the database, not the application. Use explicit migration. Do <strong>not</strong> use DateTime.Now! Name the migration &ldquo;SalesAddDateDefault&rdquo;.</p>
<p>After that, open your table data and see if the default value is applied or not.</p>
<p>Keep your <strong>namespaces</strong> from <strong>Task</strong> <strong>3</strong> and do both <strong>Task</strong> <strong>4</strong> and <strong>Task</strong> <strong>5</strong> before testing your project in <strong>Judge</strong>. Make sure to upload your <strong>migrations</strong> too!</p>