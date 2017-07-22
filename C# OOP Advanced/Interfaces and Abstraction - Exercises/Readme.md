<h1>Exercises: Interfaces</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1361/advanced-c-sharp-may-2016">"CSharp OOP Advanced" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Define an Interface IPerson</h2>
<p>Define an interface<strong> IPerson</strong> with properties for <strong>Name</strong> and <strong>Age</strong>. Define a class <strong>Citizen </strong>which implements <strong>IPerson</strong> and has a constructor which takes a <strong>string</strong> name and an <strong>int</strong> age.</p>
<p>Add the following code to your main method and submit it to Judge.</p>
<table width="720">
<tbody>
<tr>
<td width="720">
<p>static void Main(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; Type personInterface = typeof(Citizen).GetInterface("IPerson");</p>
<p>&nbsp;&nbsp;&nbsp; PropertyInfo[] properties = personInterface.GetProperties();</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(properties.Length);</p>
<p>&nbsp;&nbsp;&nbsp; string name = Console.ReadLine();</p>
<p>&nbsp;&nbsp;&nbsp; int age = int.Parse(Console.ReadLine());</p>
<p>&nbsp;&nbsp;&nbsp; IPerson person = new Citizen(name, age);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(person.Name);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(person.Age);</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>If you defined the interface and implemented it correctly, the test should pass.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="196">
<p><strong>Input</strong></p>
</td>
<td width="210">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="196">
<p>2</p>
<p>Pesho</p>
<p>25</p>
</td>
<td width="210">
<p>2</p>
<p>Pesho</p>
<p>25</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Multiple Implementation</h2>
<p>Using the code from the previous task, define an interface <strong>IIdentifiable </strong>with a <strong>string</strong> property <strong>Id</strong> and an interface <strong>IBirthable</strong> with a <strong>string</strong> property <strong>Birthdate</strong> and implement them in the <strong>Citizen</strong> class. Rewrite the Citizen constructor to accept the new parameters.</p>
<p>Add the following code to your main method and submit it to Judge.</p>
<table width="721">
<tbody>
<tr>
<td width="721">
<p>static void Main(string[] args)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");</p>
<p>&nbsp;&nbsp;&nbsp; Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");</p>
<p>&nbsp;&nbsp;&nbsp; PropertyInfo[] properties = identifiableInterface.GetProperties();</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(properties.Length);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(properties[0].PropertyType.Name);</p>
<p>&nbsp;&nbsp;&nbsp; properties = birthableInterface.GetProperties();</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(properties.Length);</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(properties[0].PropertyType.Name);</p>
<p>&nbsp;&nbsp;&nbsp; string name = Console.ReadLine();</p>
<p>&nbsp;&nbsp;&nbsp; int age = int.Parse(Console.ReadLine());</p>
<p>&nbsp;&nbsp;&nbsp; string id = Console.ReadLine();</p>
<p>&nbsp;&nbsp;&nbsp; string birthdate = Console.ReadLine();</p>
<p>&nbsp;&nbsp;&nbsp; IIdentifiable identifiable = new Citizen(name, age,id, birthdate);</p>
<p>&nbsp;&nbsp;&nbsp; IBirthable birthable = new Citizen(name, age, id, birthdate);</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>If you defined the interfaces and implemented them, the test should pass.</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="196">
<p><strong>Input</strong></p>
</td>
<td width="210">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="196">
<p>Pesho</p>
<p>25</p>
<p>9105152287</p>
<p>15/05/1991</p>
</td>
<td width="210">
<p>1</p>
<p>String</p>
<p>1</p>
<p>String</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ferrari</h2>
<p>Model an application which contains a <strong>class Ferrari</strong> and an <strong>interface</strong>. Your task is simple, you have a <strong>car - Ferrari</strong>, its model is <strong>"488-Spider"</strong> and it has a <strong>driver</strong>. Your Ferrari should have functionality to <strong>use brakes</strong> and <strong>push the gas pedal</strong>. When the <strong>brakes</strong> are pushed down <strong>print "Brakes!"</strong>, and when the <strong>gas pedal</strong> is pushed down - <strong>"Zadu6avam sA!"</strong>. As you may have guessed this functionality is typical for all cars, so you should <strong>implement an interface</strong> to describe it.</p>
<p>Your task is to <strong>create a Ferrari</strong> and <strong>set the driver's name</strong> to the passed one in the input. After that, print the info. Take a look at the Examples to understand the task better.</p>
<h3>Input</h3>
<p>On the <strong>single input line</strong>, you will be given the <strong>driver's name</strong>.</p>
<h3>Output</h3>
<p>On the <strong>single output line</strong>, print the model, the messages from the brakes and gas pedal methods and the driver's name. In the following format:</p>
<p>&lt;<strong>model</strong>&gt;/&lt;<strong>brakes</strong>&gt;/&lt;<strong>gas</strong> <strong>pedal</strong>&gt;/&lt;<strong>driver's</strong> <strong>name</strong>&gt;</p>
<h3>Constraints</h3>
<p>The input will always be valid, no need to check it explicitly! The Driver's name may contain any ASCII characters.</p>
<h3>Example</h3>
<table width="624">
<tbody>
<tr>
<td width="191">
<p><strong>Input</strong></p>
</td>
<td width="433">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="191">
<p>Bat Giorgi</p>
</td>
<td width="433">
<p>488-Spider/Brakes!/Zadu6avam sA!/Bat Giorgi</p>
</td>
</tr>
<tr>
<td width="191">
<p>Dinko</p>
</td>
<td width="433">
<p>488-Spider/Brakes!/Zadu6avam sA!/Dinko</p>
</td>
</tr>
</tbody>
</table>
<h3>Note</h3>
<p>To check your solution, copy the code below and paste it to the bottom of the code in your main method.</p>
<table width="624">
<tbody>
<tr>
<td width="624">
<p><strong>Reflection</strong></p>
</td>
</tr>
<tr>
<td width="624">
<p>string ferrariName = typeof(Ferrari).Name;</p>
<p>string iCarInterfaceName = typeof(ICar).Name;</p>
<p>&nbsp;</p>
<p>bool isCreated = typeof(ICar).IsInterface;</p>
<p>if (!isCreated)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; throw new Exception("No interface ICar was created");</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telephony</h2>
<p>You have a business - <strong>manufacturing cell phones</strong>. But you have no software developers, so you call your friends and ask them to help you create a cell phone software. They agree and you start working on the project. The project consists of one main <strong>model - a Smartphone</strong>. Each of your smartphones should have functionalities of <strong>calling other phones</strong> and <strong>browsing in the world wide web.</strong></p>
<p>Your friends are very busy, so you decide to write the code on your own. Here is the mandatory assignment:</p>
<p>You should have a <strong>model</strong> - <strong>Smartphone</strong> and two separate functionalities which your smartphone has - to <strong>call other phones</strong> and to <strong>browse in the world wide web</strong>. You should end up with <strong>one class</strong> and <strong>two interfaces</strong>.</p>
<h3>Input</h3>
<p>The input comes from the console. It will hold two lines:</p>
<ul>
<li><strong>First line</strong>: <strong>phone numbers</strong> to call (String), separated by spaces.</li>
<li><strong>Second line: sites</strong> to visit (String), separated by spaces.</li>
</ul>
<h3>Output</h3>
<ul>
<li>First <strong>call all numbers</strong> in the order of input then <strong>browse all sites</strong> in order of input</li>
<li>The functionality of calling phones is printing on the console the number which are being called in the format:</li>
</ul>
<p><strong>Calling... &lt;number&gt;</strong></p>
<ul>
<li>The functionality of the browser should print on the console the site in format:</li>
</ul>
<p><strong>Browsing: &lt;site&gt;!</strong></p>
<ul>
<li>If there is a number in the input of the URLs, print:<strong> "Invalid URL!" </strong>and continue printing the rest of the URLs.</li>
<li>If there is a character different from a digit in a number, print: <strong>"Invalid number!"</strong> and continue to the next number.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>Each site's URL should consist only of letters and symbols (<strong>No digits are allowed </strong>in the URL address)</li>
</ul>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="699">
<tbody>
<tr>
<td width="450">
<p><strong>Input</strong></p>
</td>
<td width="249">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="450">
<p>0882134215 0882134333 08992134215 0558123 3333 1</p>
<p>http://softuni.bg http://youtube.com http://www.g00gle.com</p>
</td>
<td width="249">
<p>Calling... 0882134215</p>
<p>Calling... 0882134333</p>
<p>Calling... 08992134215</p>
<p>Calling... 0558123</p>
<p>Calling... 3333</p>
<p>Calling... 1</p>
<p>Browsing: http://softuni.bg!</p>
<p>Browsing: http://youtube.com!</p>
<p>Invalid URL!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Border Control</h2>
<p>It&rsquo;s the future, you&rsquo;re the ruler of a totalitarian dystopian society inhabited by <strong>citizens</strong> and <strong>robots</strong>, since you&rsquo;re afraid of rebellions you decide to implement strict control of who enters your city. Your soldiers check the <strong>Id</strong>s of everyone who enters and leaves.</p>
<p>You will receive from the console an unknown amount of lines until the command &ldquo;<strong>End</strong>&rdquo; is received, on each line there will be the information for either a citizen or a robot who tries to enter your city in the format <strong>&ldquo;&lt;name&gt; &lt;age&gt; &lt;id&gt;</strong>&rdquo; for citizens and &ldquo;<strong>&lt;model&gt; &lt;id&gt;</strong>&rdquo; for robots. After the end command on the next line you will receive a single number representing <strong>the last digits of fake ids</strong>, all citizens or robots whose <strong>Id</strong> ends with the specified digits must be detained.</p>
<p>The output of your program should consist of all detained <strong>Id</strong>s each on a separate line (the order of printing doesn&rsquo;t matter).</p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="196">
<p><strong>Input</strong></p>
</td>
<td width="210">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="196">
<p>Pesho 22 9010101122</p>
<p>MK-13 558833251</p>
<p>MK-12 33283122</p>
<p>End</p>
<p>122</p>
</td>
<td width="210">
<p>9010101122</p>
<p>33283122</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="196">
<p>Toncho 31 7801211340</p>
<p>Penka 29 8007181534</p>
<p>IV-228 999999</p>
<p>Stamat 54 3401018380</p>
<p>KKK-666 80808080</p>
<p>End</p>
<p>340</p>
</td>
<td width="210">
<p>7801211340</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Birthday Celebrations</h2>
<p>It is a well known fact that people celebrate birthdays, it is also known that some people also celebrate their pets birthdays. Extend the program from your last task to add <strong>birthdates</strong> to citizens and include a class <strong>Pet</strong>, pets have a <strong>name</strong> and a <strong>birthdate</strong>. Encompass repeated functionality into interfaces and implement them in your classes.</p>
<p>You will receive from the console an unknown amount of lines until the command &ldquo;<strong>End</strong>&rdquo; is received,&nbsp; each line will contain information in one of the following formats <strong>&ldquo;Citizen &lt;name&gt; &lt;age&gt; &lt;id&gt; &lt;birthdate&gt;</strong>&rdquo; for citizens, &ldquo;<strong>Robot</strong> <strong>&lt;model&gt; &lt;id&gt;</strong>&rdquo; for robots or &ldquo;<strong>Pet &lt;name&gt; &lt;birthdate&gt;</strong>&rdquo; for pets. After the end command on the next line you will receive a single number representing <strong>a specific year</strong>, your task is to print all birthdates (of both citizens and pets) in that year in the format <strong>day/month/year</strong> (the order of printing doesn&rsquo;t matter).</p>
<h3>Examples</h3>
<table width="720">
<tbody>
<tr>
<td width="426">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="426">
<p>Citizen Pesho 22 9010101122 10/10/1990</p>
<p>Pet Sharo 13/11/2005</p>
<p>Robot MK-13 558833251</p>
<p>End</p>
<p>1990</p>
</td>
<td width="294">
<p>10/10/1990</p>
</td>
</tr>
<tr>
<td width="426">
<p>Citizen Stamat 16 0041018380 01/01/2000</p>
<p>Robot MK-10 12345678</p>
<p>Robot PP-09 00000001</p>
<p>Pet Topcho 24/12/2000</p>
<p>Pet Kosmat 12/06/2002</p>
<p>End</p>
<p>2000</p>
</td>
<td width="294">
<p>01/01/2000</p>
<p>24/12/2000</p>
</td>
</tr>
<tr>
<td width="426">
<p>Robot VV-XYZ 11213141</p>
<p>Citizen Penka 35 7903210713 21/03/1979</p>
<p>Citizen Kane 40 7409073566 07/09/1974</p>
<p>End</p>
<p>1975</p>
</td>
<td width="294">
<p>&lt;no output&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Food Shortage</h2>
<p>Your totalitarian dystopian society suffers a shortage of food, so many rebels appear. Extend the code from your previous task with new functionality to solve this task.</p>
<p>Define a class <strong>Rebel</strong> which has a <strong>name</strong>, <strong>age </strong>and<strong> group </strong>(string)<strong>, </strong>names are<strong> unique - </strong>there will never be 2 Rebels/Citizens or a Rebel and Citizen with the same name<strong>.</strong> Define an interface <strong>IBuyer</strong> which defines a method <strong>BuyFood() </strong>and a integer property<strong> Food</strong>. Implement the <strong>IBuyer</strong> interface in the <strong>Citizen</strong> and <strong>Rebel</strong> class, both Rebels and Citizens <strong>start with 0 food</strong>, when a Rebel buys food his <strong>Food</strong> increases by <strong>5</strong>, when a Citizen buys food his <strong>Food</strong> increases by <strong>10</strong>.</p>
<p>On the first line of the input you will receive an integer <strong>N</strong> - the number of people, on each of the next <strong>N</strong> lines you will receive information in one of the following formats &ldquo;<strong>&lt;name&gt; &lt;age&gt; &lt;id&gt; &lt;birthdate&gt;</strong>&rdquo; for a Citizen or &ldquo;<strong>&lt;name&gt; &lt;age&gt;&lt;group&gt;</strong>&rdquo; for a Rebel. After the <strong>N</strong> lines until the command &ldquo;<strong>End</strong>&rdquo; is received, you will receive names of people who bought food, each on a new line. Note that not all names may be valid, in case of an incorrect name - nothing should happen. &nbsp;</p>
<p>On the only line of output you should print the total amount of food purchased.</p>
<h3>Examples</h3>
<table width="720">
<tbody>
<tr>
<td width="426">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="426">
<p>2</p>
<p>Pesho 25 8904041303 04/04/1989</p>
<p>Stancho 27 WildMonkeys</p>
<p>Pesho</p>
<p>Gosho</p>
<p>Pesho</p>
<p>End</p>
</td>
<td width="294">
<p>20</p>
</td>
</tr>
<tr>
<td width="426">
<p>4</p>
<p>Stamat 23 TheSwarm</p>
<p>Toncho 44 7308185527 18/08/1973</p>
<p>Joro 31 Terrorists</p>
<p>Penka 27 881222212 22/12/1988</p>
<p>Jiraf</p>
<p>Joro</p>
<p>Jiraf</p>
<p>Joro</p>
<p>Stamat</p>
<p>Penka</p>
<p>End</p>
</td>
<td width="294">
<p>25</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Military Elite</h2>
<p>Create the following class hierarchy:</p>
<ul>
<li><strong>Soldier</strong> &ndash; general class for soldiers, holding <strong>id</strong>, <strong>first name</strong> and <strong>last name.</strong>
<ul>
<li><strong>Private</strong> &ndash; lowest base soldier type, holding the field <strong>salary</strong>(double).
<ul>
<li><strong>LeutenantGeneral</strong> &ndash; holds a set of <strong>Privates</strong> under his command.</li>
<li><strong>SpecialisedSoldier &ndash; </strong>general class for all specialised soldiers &ndash; holds the <strong>corps</strong> of the soldier. The corps can only be one of the following: <strong>Airforces </strong>or <strong>Marines</strong>.
<ul>
<li><strong>Engineer</strong> &ndash; holds a set of <strong>repairs</strong>. A <strong>repair </strong>holds a <strong>part name</strong> and <strong>hours worked</strong>(int).</li>
<li><strong>Commando</strong> &ndash; holds a set of <strong>missions</strong>. A mission holds <strong>code name</strong> and a <strong>state</strong> (<strong><em>inProgress</em></strong> or <strong><em>Finished</em></strong>). A mission can be finished through the method <strong>CompleteMission()</strong>.</li>
</ul>
</li>
<li><strong>Spy</strong> &ndash; holds the <strong>code number </strong>of the spy.</li>
</ul>
</li>
</ul>
</li>
</ul>
<p>Extract <strong>interfaces</strong> for each class. (e.g. <strong>ISoldier</strong>, <strong>IPrivate</strong>, <strong>ILeutenantGeneral</strong>, etc.) The interfaces should hold their public properties and methods (e.g. <strong>Isoldier</strong> should hold <strong>id</strong>, <strong>first name</strong> and <strong>last name</strong>). Each class should implement its respective interface. Validate the input where necessary (corps, mission state) - input should match <strong>exactly</strong> one of the required values, otherwise it should be treated as <strong>invalid</strong>. In case of <strong>invalid</strong> <strong>corps</strong> the entire line should be skipped, in case of an <strong>invalid</strong> <strong>mission</strong> <strong>state</strong> only the mission should be skipped.</p>
<p>You will receive from the console an unknown amount of lines containing information about soldiers until the command &ldquo;<strong>End</strong>&rdquo; is received. The information will be in one of the following formats:</p>
<ul>
<li>Private: &ldquo;<strong>Private &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt; &lt;salary&gt;</strong>&rdquo;</li>
<li>LeutenantGeneral: &ldquo;<strong>LeutenantGeneral &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt; &lt;salary&gt; &lt;private1Id&gt; &lt;private2Id&gt; &hellip; &lt;privateNId&gt;</strong>&rdquo; where privateXId will <strong>always</strong> be an <strong>Id</strong> of a private already received through the input.</li>
<li>Engineer: &ldquo;<strong>Engineer &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt; &lt;salary&gt; &lt;corps&gt; &lt;repair1Part&gt; &lt;repair1Hours&gt; &hellip; &lt;repairNPart&gt; &lt;repairNHours&gt;</strong>&rdquo; where repairXPart is the name of a repaired part and repairXHours the hours it took to repair it (the two parameters will always come paired).</li>
<li>Commando: &ldquo;<strong>Commando &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt; &lt;salary&gt; &lt;corps&gt; &lt;mission1CodeName&gt; &lt;mission1state&gt; &hellip; &lt;missionNCodeName&gt; &lt;missionNstate&gt;</strong>&rdquo; a missions code name, description and state will always come together.</li>
<li>Spy: &ldquo;<strong>Spy &lt;id&gt; &lt;firstName&gt; &lt;lastName&gt; &lt;codeNumber&gt;</strong>&rdquo;</li>
</ul>
<p>Define proper constructors. Avoid code duplication through abstraction. Override <strong>ToString()</strong> in all classes to print detailed information about the object.</p>
<p>Privates:<br /> <strong>Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary: &lt;salary&gt;</strong></p>
<p>Spy:<br /> <strong>Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt;<br /> Code Number: &lt;codeNumber&gt;</strong></p>
<p>LeutenantGeneral:<br /> <strong>Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary: &lt;salary&gt;<br /> Privates:<br /> &nbsp; &lt;private1 ToString()&gt;<br /> &nbsp; &lt;private2 ToString()&gt;<br /> &nbsp; &hellip;<br /> &nbsp; &lt;privateN ToString()&gt;</strong></p>
<p>Engineer:<br /> <strong>Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary: &lt;salary&gt;<br /> Corps: &lt;corps&gt;<br /> Repairs:<br /> &nbsp; &lt;repair1 ToString()&gt;<br /> &nbsp; &lt;repair2 ToString()&gt;<br /> &nbsp; &hellip;<br /> &nbsp; &lt;repairN ToString()&gt;</strong></p>
<p>Commando:<br /> <strong>Name: &lt;firstName&gt; &lt;lastName&gt; Id: &lt;id&gt; Salary: &lt;salary&gt;<br /> Corps: &lt;corps&gt;<br /> Missions:<br /> &nbsp; &lt;mission1 ToString()&gt;<br /> &nbsp; &lt;mission2 ToString()&gt;<br /> &nbsp; &hellip;<br /> &nbsp; &lt;missionN ToString()&gt;</strong></p>
<p>Repair:<br /> <strong>Part Name: &lt;partName&gt; Hours Worked: &lt;hoursWorked&gt;</strong></p>
<p>Mission:<br /> <strong>Code Name: &lt;codeName&gt; State: &lt;state&gt;</strong></p>
<p><strong>NOTE: </strong>Salary should be printed rounded to <strong>two decimal places</strong> after the separator.</p>
<h3>Examples</h3>
<table width="765">
<tbody>
<tr>
<td width="384">
<p><strong>Input</strong></p>
</td>
<td width="381">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="384">
<p>Private 1 Pesho Peshev 22.22<br /> Commando 13 Stamat Stamov 13.1 Airforces</p>
<p>Private 222 Toncho Tonchev 80.08</p>
<p>LeutenantGeneral 3 Joro Jorev 100 222 1</p>
<p>End</p>
</td>
<td width="381">
<p>Name: Pesho Peshev Id: 1 Salary: 22.22</p>
<p>Name: Stamat Stamov Id: 13 Salary: 13.10</p>
<p>Corps: Airforces</p>
<p>Missions:</p>
<p>Name: Toncho Tonchev Id: 222 Salary: 80.08</p>
<p>Name: Joro Jorev Id: 3 Salary: 100.00</p>
<p>Privates:</p>
<p>&nbsp; Name: Toncho Tonchev Id: 222 Salary: 80.08<br /> &nbsp; Name: Pesho Peshev Id: 1 Salary: 22.22</p>
</td>
</tr>
<tr>
<td width="384">
<p>Engineer 7 Pencho Penchev 12.23 Marines Boat 2 Crane 17</p>
<p>Commando 19 Penka Ivanova 150.15 Airforces HairyFoot finished Freedom inProgress</p>
<p>End</p>
</td>
<td width="381">
<p>Name: Pencho Penchev Id: 7 Salary: 12.23</p>
<p>Corps: Marines</p>
<p>Repairs:</p>
<p>&nbsp; Part Name: Boat Hours Worked: 2</p>
<p>&nbsp; Part Name: Crane Hours Worked: 17</p>
<p>Name: Penka Ivanova Id: 19 Salary: 150.15</p>
<p>Corps: Airforces<br /> Missions:</p>
<p>&nbsp; Code Name: Freedom State: inProgress</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *Collection Hierarchy</h2>
<p>Create 3 different string collections &ndash;<strong> AddCollection</strong>, <strong>AddRemoveCollection</strong> and <strong>MyList</strong>.</p>
<p>&nbsp;The <strong>AddCollection</strong> should have:</p>
<ul>
<li>Only a single method <strong>Add</strong> which adds an item to the <strong>end</strong> of the collection.</li>
</ul>
<p>&nbsp;The <strong>AddRemoveCollection</strong> should have:</p>
<ul>
<li>An <strong>Add </strong>method &ndash; which adds an item to the <strong>start</strong> of the collection.</li>
<li>A <strong>Remove</strong> method which removes the <strong>last</strong> item in the collection.</li>
</ul>
<p>&nbsp;The <strong>MyList</strong> collection should have:</p>
<ul>
<li>An <strong>Add</strong> method which adds an item to the <strong>start</strong> of the collection.</li>
<li>A <strong>Remove</strong> method which removes the <strong>first</strong> element in the collection.</li>
<li>A <strong>Used</strong> property which displays the amount of elements currently in the collection.</li>
</ul>
<p>Create interfaces which define the collections functionality, think how to model the relations between interfaces to reuse code. Add an extra bit of functionality to the methods in the custom collections, <strong>add</strong> methods should return the index in which the item was added, <strong>remove</strong> methods should return the item that was removed.</p>
<p>Your task is to create a single copy of your collections, after which on the first input line you will receive a random amount of strings in a single line separated by spaces - the elements you have to add to each of your collections. For each of your collections write a single line in the output that holds the results of all <strong>Add operations</strong> separated by spaces (check the examples to better understand the format). On the second input line you will receive a single number - the amount of <strong>Remove operations</strong> you have to call on each collection. In the same manner as with the Add operations for each collection (except the AddCollection), print a line with the results of each Remove operation separated by spaces.</p>
<h3>Input</h3>
<p>The input comes from the console. It will hold two lines:</p>
<ul>
<li>The first line will contain a random amount of strings separated by spaces - the elements you have to <strong>Add</strong> to each of your collections.</li>
<li>The second line will contain a single number - the amount of <strong>Remove </strong></li>
</ul>
<h3>Output</h3>
<p>The output will consist of 5 lines:</p>
<ul>
<li>The first line contains the results of all <strong>Add</strong> operations on the <strong>AddCollection</strong> separated by spaces.</li>
<li>The second line contains the results of all <strong>Add</strong> operations on the <strong>AddRemoveCollection</strong> separated by spaces.</li>
<li>The third line contains the result of all <strong>Add</strong> operations on the <strong>MyList</strong> collection separated by spaces.</li>
<li>The fourth line contains the result of all <strong>Remove</strong> operations on the <strong>AddRemoveCollection</strong> separated by spaces.</li>
<li>The fifth line contains the result of all <strong>Remove</strong> operations on the <strong>MyList</strong> collection separated by spaces.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>All collections should have a <strong>length of 100.</strong></li>
<li>There will never be <strong>more than 100</strong> add operations.</li>
<li>The number of remove operations will never be more than the amount of add</li>
</ul>
<h3>Examples</h3>
<table width="706">
<tbody>
<tr>
<td width="334">
<p><strong>Input</strong></p>
</td>
<td width="372">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="334">
<p>banichka boza tutmanik</p>
<p>3</p>
</td>
<td width="372">
<p>0 1 2</p>
<p>0 0 0</p>
<p>0 0 0</p>
<p>banichka boza tutmanik</p>
<p>tutmanik boza banichka</p>
</td>
</tr>
<tr>
<td width="334">
<p>one two three four five six seven</p>
<p>4</p>
</td>
<td width="372">
<p>0 1 2 3 4 5 6</p>
<p>0 0 0 0 0 0 0</p>
<p>0 0 0 0 0 0 0</p>
<p>one two three four</p>
<p>seven six five four</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Hint</h3>
<p>Create an interface hierarchy representing the collections. You can use a List as the underlying collection and implement the methods using the List&rsquo;s Add, Remove and Insert methods.</p>
<h2>Problem 10. *Explicit Interfaces</h2>
<p>Create 2 interfaces<strong> IResident</strong> and <strong>IPerson</strong>. <strong>IResident</strong> should have a <strong>name</strong>, <strong>country </strong>and a method<strong> GetName()</strong>. <strong>IPerson</strong> should have a <strong>name</strong>, an <strong>age </strong>and a method<strong> GetName()</strong>. Create a class Citizen which implements both <strong>IResident </strong>and <strong>IPerson</strong>, explicitly declare that IResident&rsquo;s <strong>GetName()</strong> method should return &ldquo;Mr/Ms/Mrs &rdquo; before the name while IPerson&rsquo;s <strong>GetName()</strong> method should return just the name. You will receive lines of citizen information from the console until the command &ldquo;<strong>End</strong>&rdquo; is received. Each will be in the format <strong>&ldquo;&lt;name&gt; &lt;country&gt; &lt;age&gt;</strong>&rdquo; for each line create the corresponding citizen and print his <strong>IPerson&rsquo;s GetName()</strong> and his <strong>IResitent&rsquo;s GetName().</strong></p>
<h3>Examples</h3>
<table>
<tbody>
<tr>
<td width="352">
<p><strong>Input</strong></p>
</td>
<td width="335">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="352">
<p>PeshoPeshev Bulgaria 20</p>
<p>End</p>
</td>
<td width="335">
<p>PeshoPeshev</p>
<p>Mr/Ms/Mrs PeshoPeshev</p>
</td>
</tr>
<tr>
<td width="352">
<p>JoroJorev Bulgaria 33</p>
<p>EricAnderson GreatBritain 28</p>
<p>PeterArmstrong USA 19</p>
<p>End</p>
</td>
<td width="335">
<p>JoroJorev</p>
<p>Mr/Ms/Mrs JoroJorev</p>
<p>EricAnderson</p>
<p>Mr/Ms/Mrs EricAnderson</p>
<p>PeterArmstrong</p>
<p>Mr/Ms/Mrs PeterArmstrong</p>
</td>
</tr>
</tbody>
</table>
<h3>&nbsp;</h3>
<h3>Hint</h3>
<p>Check online about Explicit Interface Implementation.</p>