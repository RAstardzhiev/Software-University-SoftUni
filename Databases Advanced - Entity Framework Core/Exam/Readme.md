<h1>Entity Framework Core: Exam</h1>
<p>Exam problems for the <a href="https://softuni.bg/courses/databases-advanced-entity-framework">Databases Advanced - Entity Framework course @ SoftUni</a>.</p>
<p>Download the provided <strong>skeleton</strong> and <strong>use it</strong> in your solutions.</p>
<p>You are <strong>not allowed</strong> to <strong>change the structure</strong> or the names of the provided <strong>classes</strong> and <strong>methods</strong> or <strong>delete them</strong>.<strong> It is very important to use only the pre-installed packages and not change their versions. </strong>Any usage of other packages is at your <strong>own</strong> <strong>risk</strong>.</p>
<p>Submit your project solutions in the SoftUni Judge system, as a <strong>zip</strong> archive file &ndash; excluding the <strong>bin</strong> and <strong>obj</strong> folders.</p>
<p>Your task is to create a database console application using <strong>Entity Framework Core</strong> using the <strong>Code First</strong> approach. Design the<strong> models</strong> and <strong>methods</strong> for manipulating the data, as described below.</p>
<h1>Pet Clinic</h1>
<p>Doctor John Dolittle&rsquo;s clinic is starting to drastically grow. He now has more clients, he has employed doctors and organizing his clinic&rsquo;s records on paper is becoming difficult. He has contacted you to help him with the changes he wants to make and wants you to design a database to keep track of the processes in the clinic.</p>
<h1>Project Skeleton Overview</h1>
<p>You are given a <strong>project skeleton</strong>, which includes the following folders:</p>
<ul>
<li>App &ndash; contains the Startup class, which is the <strong>entry point of the application</strong>. Also contains an AutoMapper profile, which you can configure if you choose to use AutoMapper in your app.</li>
<li>Data &ndash; contains the PetClinicContext class and the <strong>connection string</strong></li>
<li>Models &ndash; contains the <strong>entity classes</strong></li>
<li>DataProcessor &ndash; contains the Serializer and Deserializer classes, which are used for <strong>importing </strong>and <strong>exporting </strong>data</li>
</ul>
<h2>Problem 1. Model Definition (50 pts)</h2>
<p>In his clinic, Dr. Dolittle has employed <strong>different kinds of</strong> <strong>doctors</strong>, who serve patients &ndash; <strong>animals</strong>. Different <strong>procedures</strong> are performed on an animal, which have a pre-defined <strong>cost</strong>.</p>
<p>Design the following database models:</p>
<h3>Animal</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>min length 3 </strong>and <strong>max length 20</strong> (<strong>required</strong>)</li>
<li>Type &ndash; text with <strong>min length 3 </strong>and <strong>max length 20</strong> (<strong>required</strong>)</li>
<li>Age &ndash; integer, <strong>cannot be negative or 0 (required)</strong></li>
<li>PassportSerialNumber &shy;&ndash; string, <strong>foreign key</strong></li>
<li>Passport &ndash; the <strong>passport</strong> of the animal <strong>(required)</strong></li>
<li>Procedures &ndash; the <strong>procedures</strong>, performed on the animal</li>
</ul>
<h3>Passport</h3>
<ul>
<li>SerialNumber &ndash; a string consisting of <strong>exactly</strong> <strong>10 characters, starting with 7 letters</strong> and <strong>ending with 3 digits, Primary Key</strong></li>
<li>Animal &ndash; the <strong>animal</strong> to which the <strong>passport</strong> is registered <strong>(required)</strong></li>
<li>OwnerPhoneNumber &ndash; the phone number of the animal&rsquo;s owner, <strong>required</strong>, make sure it matches <strong>one</strong> of the following requirements:
<ul>
<li>either starts with <strong>+359</strong> and is <strong>followed by</strong> <strong>9 digits</strong></li>
<li>or consists of <strong>exactly</strong> <strong>10 </strong>digits, starting with <strong>0</strong></li>
</ul>
</li>
<li>OwnerName &ndash; the name of the animal&rsquo;s owner; text with <strong>min length 3 </strong>and <strong>max length 30</strong> (<strong>required</strong>)</li>
<li>RegistrationDate &ndash; the <strong>date and time</strong> on which the passport was registered <strong>(required)</strong></li>
</ul>
<h3>Vet</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>min length 3 </strong>and <strong>max length 40</strong> (<strong>required</strong>)</li>
<li>Profession &ndash; text with <strong>min length 3 </strong>and <strong>max length 50</strong> (<strong>required</strong>)</li>
<li>Age &ndash; integer number, minimum value of <strong>22</strong> years and maximum <strong>65 (required)</strong></li>
<li>PhoneNumber &ndash; <strong>required, unique</strong>, make sure it matches <strong>one</strong> of the following requirements:
<ul>
<li>either starts with <strong>+359</strong> and is <strong>followed by</strong> <strong>9 digits</strong></li>
<li>or consists of <strong>exactly</strong> <strong>10 </strong>digits, starting with <strong>0</strong></li>
</ul>
</li>
<li>Procedures &ndash; the <strong>procedures</strong>, performed by the vet</li>
</ul>
<h3>Procedure</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>AnimalId &shy;&ndash; integer, <strong>foreign key</strong></li>
<li>Animal &ndash; the <strong>animal</strong> on which the procedure is performed <strong>(required)</strong></li>
<li>VetId &shy;&ndash; integer, <strong>foreign key</strong></li>
<li>Vet &ndash; the clinic&rsquo;s employed doctor servicing the patient <strong>(required)</strong></li>
<li>ProcedureAnimalAids &ndash; <strong>collection of </strong>type <strong>ProcedureAnimalAid</strong></li>
<li>Cost &ndash; the <strong>cost of the procedure</strong>, <strong>calculated by summing the price of the different services performed; </strong>does not need to be inserted in the database</li>
<li>DateTime &ndash; the date and time on which the given procedure is performed <strong>(required)</strong></li>
</ul>
<h3>AnimalAid</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>min length 3 </strong>and <strong>max length 30</strong> (<strong>required, unique</strong>)</li>
<li>Price &ndash; decimal (<strong>non-negative, minimum value: 0.01</strong>, <strong>required</strong>)</li>
<li><strong>AnimalAidProcedures</strong> &ndash; <strong>collection of </strong>type <strong>ProcedureAnimalAid</strong></li>
</ul>
<h3>ProcedureAnimalAid</h3>
<ul>
<li>ProcedureId &ndash; integer, <strong>Primary Key</strong></li>
<li>Procedure &ndash; the animal aid&rsquo;s <strong>procedure</strong> <strong>(required)</strong></li>
<li>AnimalAidId &ndash; integer, <strong>Primary Key</strong></li>
<li><strong>AnimalAid</strong> &ndash; the procedure&rsquo;s <strong>animal aid</strong> <strong>(required)</strong></li>
</ul>
<h2>Problem 2. Data Import (30 pts)</h2>
<p>For the functionality of the application, you need to create several methods that manipulate the database. The <strong>project skeleton</strong> already provides you with these methods, inside the <strong>Deserializer</strong> <strong>class</strong>. Use <strong>Data Transfer Objects</strong> as needed.</p>
<p>Use the provided <strong>JSON</strong> and <strong>XML</strong> files to populate the database with data. Import all the information from those files into the database.</p>
<p><strong>You are </strong><strong>not allowed</strong><strong> to modify the provided JSON and XML files.</strong></p>
<h3>JSON Import</h3>
<h4>Import Animal Aids</h4>
<p>Start by importing the least dependent entity &ndash; the <strong>different types of animal aid </strong>that the clinic provides. Using the file <strong>animalAids.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<h5>Constraints</h5>
<ul>
<li>If any validation errors occur (such as if an animal aid <strong>name</strong> <strong>is too long/short</strong>), <strong>do not import the entity</strong></li>
<li>If an animal aid <strong>already</strong> <strong>exists, do not import it</strong></li>
</ul>
<p><strong>If a record does not meet the requirements from the first section, print an error message:</strong></p>
<table>
<tbody>
<tr>
<td>
<p><strong>Success message</strong></p>
</td>
<td>
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td>
<p>Record {animal aid name} successfully imported.</p>
</td>
<td>
<p>Error: Invalid data.</p>
</td>
</tr>
</tbody>
</table>
<h5>Example</h5>
<table width="415">
<tbody>
<tr>
<td width="415">
<p><strong>animalAids.json</strong></p>
</td>
</tr>
<tr>
<td width="415">
<p>[<br /> &nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Internal Deworming",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 8.00</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Fecal Test",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 7.50</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "H3N8",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 30.00</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Nasal Bordetella",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 5.60</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "External Deworming",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": -35.00</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Bordetella",</p>
<p>&nbsp;&nbsp;&nbsp; "Price": 7.50</p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&hellip;</strong></p>
<p><strong>]</strong></p>
</td>
</tr>
<tr>
<td width="415">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="415">
<p>Record Internal Deworming successfully imported.</p>
<p>Record Fecal Test successfully imported.</p>
<p>Record H3N8 successfully imported.</p>
<p>Record Nasal Bordetella successfully imported.</p>
<p>Error: Invalid data.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h4>Import Animals</h4>
<p>Using the file <strong>animals.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<h5>Constraints</h5>
<ul>
<li>If any validation errors occur (such as if a name, type or serial number is invalid) do not import the entity</li>
<li>If a passport with the same serial number <strong>exists, do not import the entity</strong></li>
</ul>
<p><strong>If a record does not meet the requirements from the first section, print an error message:</strong></p>
<table width="660">
<tbody>
<tr>
<td width="474">
<p><strong>Success message</strong></p>
</td>
<td width="186">
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td width="474">
<p>Record {animal name} Passport №: {passport serial number} successfully imported.</p>
</td>
<td width="186">
<p>Error: Invalid data.</p>
</td>
</tr>
</tbody>
</table>
<h5>Example</h5>
<table width="480">
<tbody>
<tr>
<td width="480">
<p><strong>animals.json</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p>[</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; "Name":"Bella",</p>
<p>&nbsp;&nbsp;&nbsp; "Type":"cat",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 2,</p>
<p>&nbsp;&nbsp;&nbsp; "Passport": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "SerialNumber": "etyhGgH678",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerName": "Sheldon Cooper",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerPhoneNumber": "0897556446",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "RegistrationDate": "12-03-2014"</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name":"Charlie",</p>
<p>&nbsp;&nbsp;&nbsp; "Type":"cat",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 3,</p>
<p>&nbsp;&nbsp;&nbsp; "Passport": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "SerialNumber": "anothev650",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerName": "Magda Bjork",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerPhoneNumber": "+35989776512",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "RegistrationDate": "15-04-2015"</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name":"Chester",</p>
<p>&nbsp;&nbsp;&nbsp; "Type":"dog",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 11,</p>
<p>&nbsp;&nbsp;&nbsp; "Passport": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "SerialNumber": "adoggoo451",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerName": "Adriana Lima",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerPhoneNumber": "35989776512",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "RegistrationDate": "31-12-2016"</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name":"Lucy",</p>
<p>&nbsp;&nbsp;&nbsp; "Type":"cat",</p>
<p>&nbsp;&nbsp;&nbsp; "Age": 6,</p>
<p>&nbsp;&nbsp;&nbsp; "Passport": {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "SerialNumber": "acattee321",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerName": "Ivan Ivanov",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "OwnerPhoneNumber": "0887446123",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "RegistrationDate": "10-06-2015"</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&hellip;</strong></p>
<p><strong>]</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p>Record Bella Passport №: etyhGgH678 successfully imported.</p>
<p>Error: Invalid data.</p>
<p>Error: Invalid data.</p>
<p>Record Lucy Passport №: acattee321 successfully imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>XML Import</h3>
<h4>Import Vets</h4>
<p>The next key figure in our app are the vets who take care of the patients. The info about them is given in the <strong>vets.xml</strong> file</p>
<h5>Constraints</h5>
<ul>
<li>Validate each row of information according to the first section. If the validation fails, <strong>do not import the vet</strong></li>
<li>If a vet with the same <strong>phone</strong> <strong>number</strong> already exists, <strong>do not import the vet</strong></li>
</ul>
<p><strong>If a record does not meet the requirements from the first section, print an error message:</strong></p>
<table>
<tbody>
<tr>
<td>
<p><strong>Success message</strong></p>
</td>
<td width="212">
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td>
<p>Record {vet name} successfully imported.</p>
</td>
<td width="212">
<p>Error: Invalid data.</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Example:</strong></p>
<table width="582">
<tbody>
<tr>
<td width="582">
<p><strong>vets.xml</strong></p>
</td>
</tr>
<tr>
<td width="582">
<p>&lt;?xml version="1.0" encoding="UTF-8"?&gt;</p>
<p>&lt;Vets&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Michael Jordan&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Profession&gt;Emergency and Critical Care&lt;/Profession&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Age&gt;45&lt;/Age&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;PhoneNumber&gt;0897665544&lt;/PhoneNumber&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Melanie Bennington&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Profession&gt;Surgery&lt;/Profession&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Age&gt;21&lt;/Age&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;PhoneNumber&gt;+359284566778&lt;/PhoneNumber&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Edmond Halley&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Profession&gt;Veterinary Nursing&lt;/Profession&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Age&gt;24&lt;/Age&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;PhoneNumber&gt;+359284566778&lt;/PhoneNumber&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Niels Bohr&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Profession&gt;Internal Medicine&lt;/Profession&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Age&gt;32&lt;/Age&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;PhoneNumber&gt;0879557712&lt;/PhoneNumber&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Werner Heisenberg&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Profession&gt;Pediatrics, Genetics and Reproduction&lt;/Profession&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Age&gt;55&lt;/Age&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;PhoneNumber&gt;0879535712&lt;/PhoneNumber&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Vet&gt;&hellip;</p>
<p>&lt;/Vets&gt;</p>
</td>
</tr>
<tr>
<td width="582">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="582">
<p>Record Michael Jordan successfully imported.</p>
<p>Error: Invalid data.</p>
<p>Record Edmond Halley successfully imported.</p>
<p>Record Niels Bohr successfully imported.</p>
<p>Record Werner Heisenberg successfully imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h4>Import Procedures</h4>
<p>Now it's time to import the records of the procedures done on the animals. Parse the information from the <strong>procedures.xml</strong> file.</p>
<h5>Constraints</h5>
<ul>
<li>Do not import a procedure if:
<ul>
<li>A <strong>vet</strong> with such <strong>name</strong> <strong>does</strong> <strong>not</strong> <strong>exist</strong></li>
<li>An <strong>animal</strong> with given <strong>serial</strong> <strong>number</strong> <strong>does</strong> <strong>not</strong> <strong>exist</strong></li>
<li>An <strong>animal</strong> <strong>aid</strong> with given <strong>name</strong> <strong>does</strong> <strong>not</strong> <strong>exist</strong></li>
<li>The <strong>same</strong> <strong>animal</strong> <strong>aid </strong>is given <strong>more</strong> <strong>than</strong> <strong>once</strong> in the <strong>same</strong> <strong>procedure</strong></li>
</ul>
</li>
</ul>
<p><strong>If a record does not meet the requirements and constraits, print an error message:</strong></p>
<table>
<tbody>
<tr>
<td>
<p><strong>Success message</strong></p>
</td>
<td>
<p><strong>Error message</strong></p>
</td>
</tr>
<tr>
<td>
<p>Record successfully imported.</p>
</td>
<td>
<p>Error: Invalid data.</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Example:</strong></p>
<table width="480">
<tbody>
<tr>
<td width="480">
<p><strong>procedures.xml</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p>&lt;?xml version="1.0" encoding="UTF-8"?&gt;</p>
<p>&lt;Procedures&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Procedure&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Vet&gt;Niels Bohr&lt;/Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Animal&gt;acattee321&lt;/Animal&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &lt;DateTime&gt;14-01-2016&lt;/DateTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Nasal Bordetella&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Internal Deworming&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Fecal Test&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Procedure&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Procedure&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Vet&gt;Jennifer Evans&lt;/Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&lt;Animal&gt;bernied355&lt;/Animal&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &lt;DateTime&gt;15-04-2016&lt;/DateTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Lyme Test&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Fecal Test&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Procedure&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Procedure&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Vet&gt;Michael Jordan&lt;/Vet&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Animal&gt;barkeer355&lt;/Animal&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &lt;DateTime&gt;03-02-2016&lt;/DateTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Injectable Bordetella&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Canine Heartworm Test&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAids&gt;</p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;/Procedure&gt;</strong></p>
<p><strong>&hellip;</strong></p>
<p>&lt;/Procedures&gt;</p>
</td>
</tr>
<tr>
<td width="480">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="480">
<p>Record successfully imported.</p>
<p>Record successfully imported.</p>
<p>Record successfully imported.</p>
<p>Record successfully imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2. Data Export (20 pts)</h2>
<h3>JSON Export</h3>
<p>Your task is to write logic in the provided <strong>ExportAnimalsByOwnerPhoneNumber</strong> method in the <strong>Serializer</strong> <strong>class</strong>. Export all <strong>animals</strong> by their <strong>owner's</strong> <strong>number</strong> sorted by <strong>age</strong> <strong>ascending</strong>, then by <strong>serial</strong> <strong>number</strong> <strong>alphabetically</strong>.</p>
<p><strong>Export dates in the format "dd-MM-yyyy", using </strong>CultureInfo.InvariantCulture<strong>!</strong></p>
<h4>Example:</h4>
<table width="480">
<tbody>
<tr>
<td width="480">
<p>ExportAnimalsByOwnerPhoneNumber(context, "0887446123")</p>
</td>
</tr>
<tr>
<td width="480">
<p><strong>[</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "OwnerName": "Ivan Ivanov",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "AnimalName": "Jessy",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Age": 3,</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "SerialNumber": "jessiii355",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "RegisteredOn": "05-11-2015"</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "OwnerName": "Ivan Ivanov",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "AnimalName": "Lucy",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Age": 6,</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "SerialNumber": "acattee321",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "RegisteredOn": "10-06-2015"</strong></p>
<p><strong>&nbsp; }</strong></p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>XML Export</h3>
<p>Implement the provided <strong>ExportAllProcedures</strong> method in the <strong>Serializer</strong>. Export all <strong>procedures</strong>: for each <strong>procedure</strong>, export the <strong>animal&rsquo;s</strong> <strong>serial</strong> <strong>number</strong>, the <strong>owner&rsquo;s</strong> <strong>phone</strong> <strong>number</strong>, the <strong>date</strong> of the <strong>procedure</strong> and the <strong>names</strong> and <strong>prices</strong> of the <strong>animal</strong> <strong>aids</strong> performed. In the end, export the <strong>total</strong> <strong>price</strong> of the <strong>procedure</strong>.</p>
<p><strong>Order the procedures by date ascending, then by passport serial number alphabetically.</strong></p>
<p><strong>Export dates in the format "dd-MM-yyyy", using </strong>CultureInfo.InvariantCulture<strong>!</strong></p>
<table width="576">
<tbody>
<tr>
<td width="576">
<p>ExportProcedures(context)</p>
</td>
</tr>
<tr>
<td width="576">
<p>&lt;Procedures&gt;</p>
<p>&nbsp; &lt;Procedure&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Passport&gt;acattee321&lt;/Passport&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;OwnerNumber&gt;0887446123&lt;/OwnerNumber&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;DateTime&gt;14-01-2016&lt;/DateTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Internal Deworming&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Price&gt;8.00&lt;/Price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Fecal Test&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Price&gt;7.50&lt;/Price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Nasal Bordetella&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Price&gt;5.60&lt;/Price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;TotalPrice&gt;21.10&lt;/TotalPrice&gt;</p>
<p>&nbsp; &lt;/Procedure&gt;</p>
<p>&nbsp; &lt;Procedure&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Passport&gt;kljsdfk325&lt;/Passport&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;OwnerNumber&gt;0899446676&lt;/OwnerNumber&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;DateTime&gt;19-01-2016&lt;/DateTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;H3N2&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Price&gt;28.00&lt;/Price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Name&gt;Lyme Test&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Price&gt;15.00&lt;/Price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/AnimalAid&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/AnimalAids&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;TotalPrice&gt;43.00&lt;/TotalPrice&gt;</p>
<p>&nbsp; &lt;/Procedure&gt;</p>
<p>&hellip;</p>
<p>&lt;/Procedures&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 4. Bonus Task (10 pts)</h2>
<p><strong>Implement the bonus method in the </strong>PetClinic.DataProcessor<strong> project for an additional amount of points</strong>.</p>
<h3>Update Vet Profession</h3>
<p>Implement the method DataProcessor.Bonus.UpdateVetProfession, which receives a vet&rsquo;s <strong>phone number </strong>and a <strong>new</strong> <strong>profession</strong>. Your task is to <strong>find the vet</strong> by that phone number and <strong>update their profession</strong>.</p>
<p>After the profession is updated, return the message &ldquo;{vet.Name}'s profession updated from {oldProfession} to {newProfession}.&rdquo;.</p>
<p>If the vet is not found, return &ldquo;Vet with phone number {phoneNumber} not found!&rdquo;</p>
<h4>Examples</h4>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>DataProcessor.Bonus.UpdateVetProfession(context, "+359284566778", "Primary Care")</p>
</td>
</tr>
<tr>
<td width="695">
<p>Edmond Halley's profession updated from Veterinary Nursing to Primary Care.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>DataProcessor.Bonus.UpdateVetProfession(context, "+359887123456", "Primary Care")</p>
</td>
</tr>
<tr>
<td width="695">
<p>Vet with phone number +359887123456 not found!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>