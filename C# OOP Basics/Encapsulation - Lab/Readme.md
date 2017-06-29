<h1>Lab: Encapsulation</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017">"C# OOP Basics" course @ SoftUni</a>".</p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/Practice/Index/678#2">https://judge.softuni.bg/Contests/Practice/Index/678#2</a></p>
<h2>1.&nbsp;&nbsp; Sort Persons by Name and Age</h2>
<p>Create a class <strong>Person</strong>, which should have <strong>private</strong> fields for:</p>
<ul>
<li>FirstName: string</li>
<li>LastName: string</li>
<li>Age: int</li>
<li>ToString(): string - override</li>
</ul>
<p>You should be able to use the class like this:</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>public static void Main()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; var lines = int.Parse(Console.ReadLine());</p>
<p>&nbsp;&nbsp;&nbsp; var persons = new List&lt;Person&gt;();</p>
<p>&nbsp;&nbsp;&nbsp; for (int i = 0; i &lt; lines; i++)</p>
<p>&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var cmdArgs = Console.ReadLine().Split();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; persons.Add(person);</p>
<p>&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp; &nbsp;persons.OrderBy(p =&gt; p.FirstName)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .ThenBy(p =&gt; p.Age)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .ToList()</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; .ForEach(p =&gt; Console.WriteLine(p.ToString()));</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="482">
<tbody>
<tr>
<td width="181">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="181">
<p>5</p>
<p>Asen Ivanov 65</p>
<p>Boiko Borisov 57</p>
<p>Ventsislav Ivanov 27</p>
<p>Asen Harizanoov 44</p>
<p>Boiko Angelov 35</p>
</td>
<td width="302">
<p>Asen Harizanoov is a 44 years old.</p>
<p>Asen Ivanov is a 65 years old.</p>
<p>Boiko Angelov is a 35 years old.</p>
<p>Boiko Borisov is a 57 years old.</p>
<p>Ventsislav Ivanov is a 27 years old.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Solution</h3>
<p>Create a <strong>new class</strong> and ensure <strong>proper naming</strong>. Define the <strong>private</strong> fields</p>
<p>&nbsp;</p>
<p>Create a constructor for Person, which takes 3 parameters firstName, lastName, age.</p>
<p>Create properties for these fields, which are as strictly as possible</p>
<p>Override <strong>ToString()</strong> method:</p>
<h2>2.&nbsp;&nbsp; Salary Increase</h2>
<p><strong>Refactor project from last task.</strong></p>
<p>Read person with their names, age and salary. Read percent bonus to every person salary. Persons younger than 30 get half bonus. Expand <strong>Person</strong> from previous task. New <strong>fields</strong> and <strong>methods:</strong></p>
<ul>
<li>Salary: double</li>
<li>IncreaseSalary(double bonus)</li>
</ul>
<p>You should be able to use the class like this:</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p>StartUp.cs</p>
</td>
</tr>
<tr>
<td width="695">
<p>var lines = int.Parse(Console.ReadLine());</p>
<p>var persons = new List&lt;Person&gt;();</p>
<p>for (int i = 0; i &lt; lines; i++)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; var cmdArgs = Console.ReadLine().Split();</p>
<p>&nbsp;&nbsp;&nbsp; var person = new Person(cmdArgs[0],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; cmdArgs[1],</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; int.Parse(cmdArgs[2]),</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; double.Parse(cmdArgs[3]));</p>
<p>&nbsp;</p>
<p>&nbsp; &nbsp;&nbsp;persons.Add(person);</p>
<p>}</p>
<p>var bonus = double.Parse(Console.ReadLine());</p>
persons.ForEach(p =&gt; Console.WriteLine(p.ToString()));</td>
</tr>
</tbody>
</table>
<h3>Examples</h3>
<table width="523">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>5</p>
<p>Asen Ivanov 65 2200</p>
<p>Boiko Borisov 57 3333</p>
<p>Ventsislav Ivanov 27 600</p>
<p>Asen Harizanoov 44 666.66</p>
<p>Boiko Angelov 35 559.4</p>
<p>20</p>
</td>
<td width="302">
<p>Asen Ivanov get 2200 leva</p>
<p>Boiko Borisov get 3333 leva</p>
<p>Ventsislav Ivanov get 600 leva</p>
<p>Asen Harizanoov get 666.66 leva</p>
<p>Boiko Angelov get 559.4 leva</p>
</td>
</tr>
</tbody>
</table>
<h3>Solution</h3>
<p>Add new <strong>private</strong> field for <strong>salary</strong> and <strong>refactor constructor</strong>. Add new <strong>method</strong>, which will <strong>update</strong> salary with bonus</p>
<p>Refactor <strong>toString()</strong> method for this task.</p>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Validation Data</h2>
<p>Expand Person with proper validation for every field:</p>
<ul>
<li><strong>Names must be at least 3 symbols</strong></li>
<li><strong>Age must not be zero or negative</strong></li>
<li><strong>Salary can't be less than 460.0 </strong></li>
</ul>
<p>Print proper message to end user (look at example for messages).</p>
<p>Use ArgumentExeption with messages from example.</p>
<h3>Examples</h3>
<table width="563">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="342">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>5</p>
<p>Asen Ivanov -6 2200</p>
<p>B Borisov 57 3333</p>
<p>Ventsislav Ivanov 27 600</p>
<p>Asen H 44 666.66</p>
<p>Boiko Angelov 35 300</p>
<p>20</p>
</td>
<td width="342">
<p>Age cannot be zero or negative integer</p>
<p>First name cannot be less than 3 symbols</p>
<p>Last name cannot be less than 3 symbols</p>
<p>Salary cannot be less than 460 leva</p>
<p>Ventsislav Ivanov get 660.0 leva</p>
</td>
</tr>
</tbody>
</table>
<h3>&nbsp;</h3>
<h2>4.&nbsp;&nbsp; First and Reserve Team</h2>
<p>Create a Team class. Add to this team all person you read. All person younger than 40 go in first team, others go in reverse team. At the end print first and reserve team sizes.</p>
<p>The class should have <strong>private fields</strong> for:</p>
<ul>
<li>name: string</li>
<li>firstTeam: List&lt;Person&gt;</li>
<li>reserveTeam: List&lt;Person&gt;</li>
</ul>
<p>The class should have <strong>constructors</strong>:</p>
<ul>
<li>Team(string name)</li>
</ul>
<p>The class should also have <strong>public methods</strong> for:</p>
<ul>
<li>AddPlayer(Person person): void</li>
<li>FirstTeam: IReadOnlyCollection</li>
<li>ReserveTeam: IReadOnlyCollection</li>
</ul>
<h3>Examples</h3>
<table width="563">
<tbody>
<tr>
<td width="221">
<p><strong>Input</strong></p>
</td>
<td width="342">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="221">
<p>5</p>
<p>Asen Ivanov 20 2200</p>
<p>Boiko Borisov 57 3333</p>
<p>Ventsislav Ivanov 27 600</p>
<p>Grigor Dimitrov 25 666.66</p>
<p>Boiko Angelov 35 555</p>
</td>
<td width="342">
<p>First team have 4 players</p>
<p>Reserve team have 1 players</p>
</td>
</tr>
</tbody>
</table>