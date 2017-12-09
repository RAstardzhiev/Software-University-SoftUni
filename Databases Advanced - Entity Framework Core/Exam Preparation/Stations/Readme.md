<h1>Entity Framework Core: Exam Preparation 2</h1>
<p>Exam problems for the <a href="https://softuni.bg/courses/databases-advanced-entity-framework">Databases Advanced - Entity Framework course @ SoftUni</a>. Submit your solutions in the SoftUni judge system (delete all "bin"/"obj" folders alongside with the "packages" folder).</p>
<p>Your task is to create a database application using <strong>Entity Framework Core</strong> using the <strong>Code First</strong> approach. Design the <strong>domain models</strong> and <strong>methods</strong> for manipulating the data, as described below.</p>
<h1>Stations</h1>
<p>Create an application which models a <strong>train transport system</strong>. The main idea is to have <strong>stations</strong> between which <strong>trains</strong> travel. Each <strong>travel</strong> between two stations is called a <strong>trip</strong>. People can buy <strong>tickets</strong> for a specific <strong>trip</strong>. Some people might not be registered while others may have a <strong>personal card</strong> (in other words &ndash; some tickets may have <strong>buyer&rsquo;s information</strong> while others will not). For more details about the <strong>models</strong> and their <strong>relations</strong> read further.</p>
<h2>Project Skeleton Overview</h2>
<p>You are given a <strong>project skeleton</strong>, which includes the following items:</p>
<ul>
<li>App &ndash; contains the Startup class, which is the <strong>entry point of the application</strong>. Also contains an AutoMapper profile, which you can configure if you choose to use AutoMapper in your app.</li>
<li>Data &ndash; contains the StationsDbContext class and the <strong>connection string</strong></li>
<li>Models &ndash; contains the <strong>entity classes</strong></li>
<li>DataProcessor &ndash; contains the Serializer and Deserializer classes, which are used for <strong>importing </strong>and <strong>exporting </strong>data</li>
</ul>
<h2>Problem 1. Model Definition (50 pts)</h2>
<p>Every <strong>trip</strong> has an origin <strong>station</strong> and destination <strong>station</strong>, it also includes information about which <strong>train</strong> travelled between those two stations. Each train may have <strong>seats</strong>, which are grouped in <strong>seating classes</strong> (<strong>First class</strong>, <strong>Second class</strong> and so on). For each trip, you may buy a <strong>ticket</strong>. the <strong>ticket</strong> keeps information about the trip and <strong>may</strong> include information about the <strong>customer</strong> who bought it through their <strong>customer card </strong>(<strong>if</strong> they have one). The <strong>customer</strong> <strong>card</strong> contains basic person data.</p>
<p><strong><em>Note: Foreign key navigation properties are required! </em></strong></p>
<p>The application needs to store the following data:</p>
<h3>Station</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>max length</strong> <strong>50</strong> (<strong>required, unique</strong>)</li>
<li>Town &ndash; text with <strong>max length</strong> <strong>50</strong> (<strong>required</strong>)</li>
<li>TripsTo &ndash; Collection of type Trip</li>
<li>TripsFrom &ndash; Collection of type Trip</li>
</ul>
<h3>Train</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>TrainNumber<strong> &ndash; text with max length 10 (required, unique) </strong></li>
<li>Type<strong> &ndash; </strong>TrainType<strong> enumeration with possible values: "HighSpeed", "LongDistance" or "Freight" (optional)</strong></li>
<li>TrainSeats &ndash; Collection of type TrainSeat</li>
<li>Trips &ndash; Collection of type Trip</li>
</ul>
<h3>SeatingClass</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>max length 30</strong> (<strong>required, unique</strong>)</li>
<li>Abbreviation &ndash; text with an <strong>exact </strong>length of <strong>2</strong> (<strong>no more, no less</strong>), (<strong>required, unique</strong>)</li>
</ul>
<h3>TrainSeat</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>TrainId <strong>&ndash;</strong> integer (required)</li>
<li>Train<strong> &ndash; train whose seats will be described (required)</strong></li>
<li>SeatingClassId<strong> &ndash; integer (required)</strong></li>
<li>SeatingClass<strong> &ndash; class of the seats (required)</strong></li>
<li>Quantity<strong> &ndash; how many seats of given class total for the given train (required, non-negative)</strong></li>
</ul>
<h3>Trip</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>OriginStationId &ndash; integer <strong>(required)</strong></li>
<li>OriginStation &ndash; station from which the trip begins (<strong>required</strong>)</li>
<li>DestinationStationId &ndash; integer <strong>(required)</strong></li>
<li>DestinationStation<strong> &ndash; </strong>station <strong>where the trip ends (required)</strong></li>
<li>DepartureTime &ndash; date and time of departure from origin station (<strong>required</strong>)</li>
<li>ArrivalTime &ndash; date and time of arrival at destination station, must be after departure time (<strong>required</strong>)</li>
<li>TrainId &ndash; integer <strong>(required)</strong></li>
<li>Train &ndash; train used for that particular trip (<strong>required</strong>)</li>
<li>Status &ndash; TripStatus<strong>enumeration</strong> with possible values: "<strong>OnTime</strong>", "<strong>Delayed</strong>" and "<strong>Early</strong>" (<strong>default</strong>: "<strong>OnTime</strong>")</li>
<li>TimeDifference<strong> &ndash; time(span) representing how late or early a given train was (optional)</strong></li>
</ul>
<h3>Ticket</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Price &ndash; decimal value of the ticket (<strong>required, non-negative</strong>)</li>
<li>SeatingPlace<strong> &ndash; text with max length of 8 which combines seating class abbreviation plus a positive integer (required)</strong></li>
<li>TripId &ndash; integer <strong>(required)</strong></li>
<li>Trip &ndash; the trip for which the ticket is for (<strong>required</strong>)</li>
<li>CustomerCardId&ndash;<strong> integer (optional)</strong></li>
<li>CustomerCard<strong> &ndash; reference to the ticket&rsquo;s buyer</strong></li>
</ul>
<h3>CustomerCard</h3>
<ul>
<li>Id &ndash; integer, <strong>Primary Key</strong></li>
<li>Name &ndash; text with <strong>max length</strong> <strong>128</strong> (<strong>required</strong>)</li>
<li>Age &ndash; integer <strong>between</strong> <strong>0 and 120</strong></li>
<li>Type &ndash; CardType enumeration with values: "<strong>Pupil</strong>", "<strong>Student</strong>", "<strong>Elder</strong>", "<strong>Debilitated</strong>", "<strong>Normal</strong>" (default: <strong>Normal</strong>)</li>
<li><strong>BoughtTickets </strong>&ndash; Collection of type Ticket</li>
</ul>
<p>Any information which has additional requirements needs to be <strong>validated</strong>.</p>
<h2>Problem 2. Data Import (35pts)</h2>
<p>For the functionality of the application, you need to create several methods that manipulate the database. The <strong>project skeleton</strong> already provides you with these methods, inside the Stations.DataProcessor project inside your solution. Use <strong>Data Transfer Objects</strong> as needed.</p>
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
<h3>JSON Import (15 pts)</h3>
<h4>Import Stations</h4>
<p>Using the file <strong>stations.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<ul>
<li>If the town name is not given, insert it with the same value as the station name.</li>
<li>If a station with the same name <strong>already exists</strong>, <strong>ignore </strong>the entity.</li>
<li>If any other validation error occurs (such as <strong>long</strong> <strong>station</strong> <strong>or</strong> <strong>town name</strong>) proceed as described above.</li>
</ul>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>stations.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Sofia"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Name": "Sofia Sever",</p>
<p>&nbsp;&nbsp;&nbsp; "Town": "Sofia"</p>
<p>&nbsp; },</p>
<p>&nbsp; &hellip;</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Record Sofia successfully imported.</p>
<p>Record Sofia Sever successfully imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h4>Import Seating Classes</h4>
<p>Using the file <strong>classes.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<p>If a seating class with the same <strong>name</strong> or <strong>abbreviation</strong> already exists, <strong>ignore</strong> the entity.</p>
<p>If any validation error occurs (such as <strong>long name</strong> or <strong>incorrect</strong> <strong>abbreviation</strong> <strong>length</strong>), proceed as described above.</p>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>classes.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Name:"First class", <br /> &nbsp;&nbsp;&nbsp;&nbsp; Abbreviation: "FC",</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; Name:"Second class", <br /> &nbsp;&nbsp;&nbsp;&nbsp; Abbreviation: "SC",</p>
<p>&nbsp; },</p>
<p>&nbsp; &hellip;</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Record First class successfully imported.</p>
<p>Record Second class successfully imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h4>Import Trains</h4>
<p>Using the file <strong>trains.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<h5>Constraints</h5>
<ul>
<li>Train type will always be a valid type (if not null). If it&rsquo;s <strong>null</strong>, use the <strong>default type</strong> (HighSpeed).</li>
<li>If there is no <strong>seat class</strong> with given <strong>name</strong> and <strong>abbreviation </strong>in any of the train&rsquo;s <strong>seats</strong> &ndash; <strong>skip </strong>the whole entity.</li>
<li>If there is seat class with same name but different abbreviation <strong>or the quantity is negative</strong> &ndash; <strong>ignore</strong> the whole entity.</li>
<li><strong>Any</strong> of the properties <strong>may</strong> <strong>be</strong> not given (null) in the json file (including the <strong>quantity</strong> of seats per train) &ndash; if the specific property is <strong>required</strong> and it has <strong>null value</strong> the whole entity is considered <strong>invalid</strong>.</li>
<li>If any <strong>validation error</strong> occurs (such as <strong>long train number</strong>), proceed as described above.</li>
<li>There will be <strong>only one</strong> seat class with same name <strong>per</strong> train:</li>
</ul>
<table width="514">
<tbody>
<tr>
<td width="514">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Seats": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name:"First class", <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &hellip;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name:" First class", <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &hellip;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; }</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<p><strong>The input above will not be presented!</strong></p>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>trains</strong><strong>.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "TrainNumber": "KB20012",</p>
<p>&nbsp;&nbsp;&nbsp; "Type": "HighSpeed",</p>
<p>&nbsp;&nbsp;&nbsp; "Seats": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name:"First class", <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Abbreviation: "FC",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantity:50</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Name:"Business class", <br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Abbreviation: "BC",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Quantity:44</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; &hellip;</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Record KB20012 successfully imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h4>Import Trips</h4>
<p>Using the file <strong>trips.json</strong>, import the data from that file into the database. Print information about each imported object in the format described below.</p>
<p>If there is any violation of the requirements mentioned in the first section or some of the stations/trains do not exist <strong>ignore</strong> the whole entity and <strong>continue</strong> with next one.</p>
<p>If status is not specified use the <strong>default</strong> one.</p>
<h5>Constraints</h5>
<ul>
<li>Status will always be a valid value or null</li>
<li>Time Difference may be null or be represented in format &ldquo;hh\:mm&rdquo;</li>
<li>Arrival/Departure date may be null or in format &ldquo;dd/MM/yyyy HH:mm&rdquo;</li>
<li>Always check for the existence of trains and stations.</li>
<li>Always check if <strong>departure time</strong> is before the <strong>arrival </strong></li>
<li>Any of the properties might be null &ndash; if the property is considered required consider the <strong>whole entity</strong> as invalid.</li>
</ul>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>trips.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Train": "KB20012",</p>
<p>&nbsp;&nbsp;&nbsp; "OriginStation": "Sofia",</p>
<p>&nbsp;&nbsp;&nbsp; "DestinationStation": "Sofia Sever",</p>
<p>&nbsp;&nbsp;&nbsp; "DepartureTime": "27/12/2016 12:00",</p>
<p>&nbsp;&nbsp;&nbsp; "ArrivalTime": "27/12/2016 12:30",</p>
<p>&nbsp;&nbsp;&nbsp; "Status": "OnTime",</p>
<p>&nbsp; },</p>
<p>&nbsp; &hellip;</p>
<p>]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Trip from Sofia to Sofia Sever imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h3>XML Import (5 pts)</h3>
<h4>Import Person Cards</h4>
<p>Using the file <strong>cards.xml</strong>, import the data from the file into the database. Print information about each imported object in the format described below.</p>
<p>If any of the model requirements is violated continue with the next entity.</p>
<h5>Constraints</h5>
<ul>
<li>Card type will be valid value or null (if null set default value)</li>
<li>There will be no any other missing(null) elements</li>
</ul>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>cards</strong><strong>.xml</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;Cards&gt;</p>
<p>&nbsp; &lt;Card&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;John Levit&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Age&gt;25&lt;/Age&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;CardType&gt;Normal&lt;/CardType&gt;</p>
<p>&nbsp; &lt;/Card&gt;</p>
<p>&nbsp; &lt;Card&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Name&gt;Ana Keanig&lt;/Name&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Age&gt;19&lt;/Age&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;CardType&gt;Student&lt;/CardType&gt;</p>
<p>&nbsp; &lt;/Card&gt;</p>
<p>&nbsp; &hellip;</p>
<p>&lt;/Cards&gt;</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Record John Levit successfully imported.</p>
<p>Record Ana Keanig successfully imported.</p>
</td>
</tr>
</tbody>
</table>
<h4>Import Tickets</h4>
<p>Using the file <strong>tickets.xml</strong>, import the data from the file into the database.</p>
<p>Find the trip with the specified data (by origin/destination station and departure time). Assume there will be exactly one or zero trips available (there will be no trips with same departure time and origin/destination station).&nbsp; If there is existing trip use the train referenced there for the next part.</p>
<p>The <strong>seat</strong> must be a combination between seating class <strong>abbreviation</strong> and <strong>integer</strong> number (e.g: &ldquo;<strong>FC42</strong>&rdquo; - where &ldquo;<strong>FC</strong>&rdquo; stands for &ldquo;<strong>First Class</strong>&rdquo; and &ldquo;<strong>42</strong>&rdquo; is <strong>number</strong> of the specific <strong>seat</strong>) &ndash; this means that you should check if there is a <strong>class</strong> with same abbreviation and then check <strong>if</strong> the <strong>train</strong> has <strong>any</strong> <strong>seats</strong> from that class. Last, the seat number must be positive and <strong>below</strong> <strong>or</strong> <strong>equal</strong> to the <strong>quantity</strong> of seats specified for that train.</p>
<p>If the format of the seat doesn&rsquo;t match the above criteria, the entity is invalid.</p>
<h5>Constraints</h5>
<ul>
<li>Ticket&rsquo;s price will always be a valid number (<strong>not null</strong>)</li>
<li>Ticket&rsquo;s seat will not be null</li>
<li>If there is no existing trip with matching properties or there is <strong>no card</strong> with matching name in the database, <strong>ignore</strong> the whole entity.</li>
<li>Departure time will be a valid datetime in the format: &ldquo;dd/MM/yyyy HH:mm&rdquo;</li>
<li>Cards will not have duplicate names</li>
<li>If any validation error occurs, proceed as described above.</li>
</ul>
<h5>Example</h5>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>tickets.xml</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;Tickets&gt;</p>
<p>&nbsp; &lt;Ticket price="3.53" seat="SC12"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Trip&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Sofia Sever&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;27/12/2016 12:00&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Trip&gt;</p>
<p>&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp; &lt;Ticket price="3.28" seat="FC1"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Trip&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Sofia Sever&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;27/12/2016 12:00&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Trip&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Card Name="Amber Hosh" /&gt;</p>
<p>&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp; &lt;/Tickets&gt;</p>
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
<p>Ticket from Sofia to Sofia Sever departing at 27/12/2016 12:00 imported.</p>
<p>Ticket from Sofia to Sofia Sever departing at 27/12/2016 12:00 imported.</p>
<p>&hellip;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3. Data Export (15pts)</h2>
<p>For the functionality of the application, you need to create several methods that manipulate the database. Create these methods inside the <strong>data layer</strong> of your solution. <strong>Database query methods will be assessed separately from export functionality. </strong>Use <strong>Data Transfer Objects</strong> as needed.</p>
<p>Create a <strong>new project</strong> inside your solution that would handle data <strong>export (where serialization would happen)</strong>.</p>
<h3>JSON Export (5 pts)</h3>
<h4>Export All Delayed Trains</h4>
<p>The given method in the project skeleton receives a <strong>date</strong> as string in format "<strong>dd/MM/yyyy</strong>". Export all trains which were part of trip with status: "<strong>Delayed</strong>" and also the trip&rsquo;s departure time is <strong>smaller or equal</strong> to the given date. Display only unique trains alongside with how many times they have been late and their highest delay in format: "<strong>HH:mm:ss</strong>" (the <strong>default</strong> Timespan format). Order the trains by: count of how many times they have been late (descending), highest delay time (descending) and train number (ascending).</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>delayed-trains-by-01-01-2017.json</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "Tra1inNumber": "PU17333",</p>
<p>&nbsp;&nbsp;&nbsp; "DelayedTimes": 2,</p>
<p>&nbsp;&nbsp;&nbsp; "MaxDelayedTime": "23:02:00"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "TrainNumber": "VT08003",</p>
<p>&nbsp;&nbsp;&nbsp; "DelayedTimes": 2,</p>
<p>&nbsp;&nbsp;&nbsp; "MaxDelayedTime": "15:51:00"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "TrainNumber": "BQ877549",</p>
<p>&nbsp;&nbsp;&nbsp; "DelayedTimes": 1,</p>
<p>&nbsp;&nbsp;&nbsp; "MaxDelayedTime": "21:39:00"</p>
<p>&nbsp; },</p>
<p>&nbsp; &hellip;</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h3>XML Export (5 pts)</h3>
<h4>Export Cards by Type</h4>
<p>Use the method provided in the project skeleton, which receives a <strong>card type</strong>. Your task is to export all tickets bought by people with the same card type. Order by <strong>card name</strong> in ascending order.</p>
<h4>Example</h4>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>tickets-bought-with-card-type-Debilitated.xml</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;Cards&gt;</p>
<p>&nbsp; &lt;Card name="George Powell" type="Debilitated"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Tickets&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Varna&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;24/05/2017 12:00&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Sagay&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;02/12/2016 12:20&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Tickets&gt;</p>
<p>&nbsp; &lt;/Card&gt;</p>
<p>&nbsp; &lt;Card name="Henry Moreno" type="Debilitated"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Tickets&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Ajjah&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;San Isidro&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;02/04/2016 12:33&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Tickets&gt;</p>
<p>&nbsp; &lt;/Card&gt;</p>
<p>&lt;/Cards&gt;</p>
</td>
</tr>
</tbody>
</table>
<h4>Other case</h4>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>tickets-bought-with-card-type-Elder.xml</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;Cards&gt;</p>
<p>&nbsp; &lt;Card name="Jeremy Carroll" type="Elder"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Tickets&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Varna&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;24/05/2017 22:00&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Huaian&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Chysky&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;13/08/2011 12:33&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Varna&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;24/05/2017 12:00&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Varna&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;24/05/2017 12:00&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Tickets&gt;</p>
<p>&nbsp; &lt;/Card&gt;</p>
<p>&nbsp; &lt;Card name="Michelle Sanders" type="Elder"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Tickets&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Matriz de Camaragibe&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Chysky&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;23/11/2016 15:09&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Tickets&gt;</p>
<p>&nbsp; &lt;/Card&gt;</p>
<p>&nbsp; &lt;Card name="Wanda Ward" type="Elder"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;Tickets&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;OriginStation&gt;Sofia&lt;/OriginStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DestinationStation&gt;Sofia Sever&lt;/DestinationStation&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;DepartureTime&gt;27/12/2016 12:00&lt;/DepartureTime&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/Ticket&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/Tickets&gt;</p>
<p>&nbsp; &lt;/Card&gt;</p>
<p>&lt;/Cards&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>