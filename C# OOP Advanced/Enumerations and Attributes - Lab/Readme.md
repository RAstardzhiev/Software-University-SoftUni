<h1>Lab: Enumerations and Attributes</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/csharp-oop-advanced-high-quality-code">https://softuni.bg/courses/csharp-oop-advanced-high-quality-code</a>.</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/Practice/Index/708">https://judge.softuni.bg/Contests/Practice/Index/708#0</a>.</p>
<h1>Part I: Enumerations</h1>
<h2>1.&nbsp;&nbsp; Weekdays</h2>
<p>Create Enum Weekday with the days from <strong>Monday</strong> through <strong>Sunday</strong>.</p>
<p>Create a class WeeklyCalendar that should have at least the methods:</p>
<ul>
<li>void AddEntry(string weekday, string notes)</li>
<li>IEnumerable&lt;WeeklyEntry&gt; WeeklySchedule</li>
</ul>
<p>Create a class WeeklyEntry which should have constructor:</p>
<ul>
<li>WeeklyEntry(string weekday, string notes)</li>
<li>Implement IComparable&lt;WeeklyEntry&gt; - Entries have to be compare first by their week day and then by note</li>
</ul>
<p>Override ToString() of WeeklyEntry &ndash; "{weekday} - {notes}" (e.g. "Monday - sport", "Sunday - sleep")</p>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>WeeklyCalendar calendar = new WeeklyCalendar();</p>
<p>calendar.AddEntry("Monday", "Internal meeting");</p>
<p>calendar.AddEntry("Tuesday", "Create presentation");</p>
<p>calendar.AddEntry("Tuesday", "Create lab and exercise");</p>
<p>calendar.AddEntry("Thursday", "Enum Lecture");</p>
<p>calendar.AddEntry("Monday", "Second internal meeting");</p>
<p>&nbsp;</p>
<p>var ordered = calendar.WeeklySchedule.OrderBy(n =&gt; n).ToList();</p>
<p>foreach (var weeklyEntry in ordered)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(weeklyEntry);</p>
}</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>Create the WeeklyCalendar:</p>
<p>&nbsp;</p>
<p>Create WeeklyEntry and think about a solution to compare entries:</p>
<h2>2.&nbsp;&nbsp; Coffee Machine</h2>
<p>Create a class CoffeeMachine, with methods:</p>
<ul>
<li>void BuyCoffee(string size, string type)</li>
<li>void InsertCoin(string coin)</li>
<li>IEnumerable&lt;CoffeeType&gt; CoffeesSold { get; }</li>
</ul>
<p>Create enum CoffeeType - Espresso, Latte, Irish</p>
<p>Create enum Coin - 1, 2, 5, 10, 20, 50 (constants should be named One, Two, Five, etc.)</p>
<p>Create enum CoffeePrice - Small (50 c), Normal (100 c), Double (200 c)</p>
<p>CoffeeMachine should <strong>clear all coins after each successful coffee sold</strong>.</p>
<p>When you receive "End" command, print all sold coffees.</p>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>CoffeeMachine machine = new CoffeeMachine();</p>
<p>&nbsp;</p>
<p>string input;</p>
<p>while ((input = Console.ReadLine()) != "End")</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; string[] inputArgs = input.Split();</p>
<p>&nbsp;&nbsp;&nbsp; if (inputArgs.Length == 1)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; machine.InsertCoin(inputArgs[0]);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; else</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; machine.BuyCoffee(inputArgs[0], inputArgs[1]);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
<p>&nbsp;</p>
<p>foreach (var coffeeType in machine.CoffeesSold)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; Console.WriteLine(coffeeType);</p>
}</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="605">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>Ten</p>
<p>Twenty</p>
<p>Twenty</p>
<p>Small Espresso</p>
<p>End</p>
</td>
<td width="378">
<p>Espresso</p>
</td>
</tr>
<tr>
<td width="227">
<p>Ten</p>
<p>Twenty</p>
<p>Small Espresso</p>
<p>Twenty</p>
<p>Small Espresso</p>
<p>End</p>
</td>
<td width="378">
<p>Espresso</p>
<p>&nbsp;</p>
<p>//Comment: first try - not enough coins</p>
</td>
</tr>
</tbody>
</table>
<h1>Part II: Attributes</h1>
<h2>3.&nbsp;&nbsp; Create Attribute</h2>
<p>Create attribute SoftUni with a string element called <strong>name</strong>, that<strong>: </strong></p>
<ul>
<li>Can be used over classes and methods</li>
<li>Allow multiple attributes of same type</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>[SoftUni("Ventsi")]</p>
<p>class StartUp</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; [SoftUni("Gosho")]</p>
<p>&nbsp;&nbsp;&nbsp; static void Main(string[] args)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
}</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Coding Tracker</h2>
<p>Create a class <strong>Tracker</strong> with a method:</p>
<ul>
<li>static void printMethodsByAuthor()</li>
</ul>
<h3>&nbsp;Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>[SoftUni("Ventsi")]</p>
<p>class StartUp</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; [SoftUni("Gosho")]</p>
<p>&nbsp;&nbsp;&nbsp; static void Main(string[] args)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var tracker = new Tracker();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; tracker.PrintMethodsByAuthor();</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
}</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>