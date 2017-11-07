<h1>Exercises: Introduction to DB Apps</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1442/databases-advanced-entity-framework-october-2016">"Databases Advanced &ndash; Entity Framework" course @ Software University.</a></p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Initial Setup</h2>
<p>Write a program that connects to your <strong>localhost</strong> server. Create <strong>new database </strong>called <strong>MinionsDB</strong> where we will keep information about our minions and villains.</p>
<p>For each <strong>minion</strong> we should keep information about its <strong>name</strong>, <strong>age</strong> and <strong>town</strong>.&nbsp; Each <strong>town</strong> has information about <strong>the</strong> <strong>country</strong> where it&rsquo;s located. <strong>Villains</strong> have <strong>name</strong> and <strong>evilness</strong> <strong>factor</strong> (<strong>super good</strong>, <strong>good</strong>, <strong>bad</strong>, <strong>evil</strong>, <strong>super</strong> <strong>evil</strong>). Each <strong>minion</strong> can <strong>serve</strong> <strong>several</strong> <strong>villains</strong> and <strong>each</strong> <strong>villain</strong> can <strong>have</strong> <strong>several</strong> <strong>minions</strong> <strong>serving</strong> <strong>him</strong>. Fill all tables with at least 5 records each.</p>
<p>In the end you shoud have the following tables:</p>
<ul>
<li>Countries</li>
<li>Towns</li>
<li>Minions</li>
<li>EvilnessFactors</li>
<li>Villains</li>
<li>MinionsVillains</li>
</ul>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Villain Names</h2>
<p>Write a program that prints on the console <strong>all villains&rsquo; names</strong> and their <strong>number of minions</strong> of those who have more than 3 minions <strong>ordered descending</strong> by number of minions.</p>
<h3>Example</h3>
<table width="103">
<tbody>
<tr>
<td width="103">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="103">
<p>Gru - 6</p>
<p>Victor - 4</p>
<p>Jilly &ndash; 4</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Minion Names</h2>
<p>Write a program that prints on the console <strong>all minion names</strong> and age for a given <strong>villain id</strong>, ordered by <strong>name</strong> <strong>alphabetically.</strong></p>
<p>If there is no villain with the given ID, print "No villain with ID &lt;<strong>VillainId</strong>&gt; exists in the database.".<br /> If the selected villain has no minions, print "(no minions)" on the second row.</p>
<h3>Example</h3>
<table width="633">
<tbody>
<tr>
<td width="56">
<p><strong>Input</strong></p>
</td>
<td width="121">
<p><strong>Output</strong></p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="56">
<p><strong>Input</strong></p>
</td>
<td width="139">
<p><strong>Output</strong></p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="56">
<p><strong>Input</strong></p>
</td>
<td width="169">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="56">
<p>1</p>
</td>
<td width="121">
<p>Villain: Gru</p>
<p>1. Bob 13</p>
<p>2. Kevin 14</p>
<p>3. Steward 19</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="56">
<p>3</p>
</td>
<td width="139">
<p>Villain: Victor</p>
<p>1. Bob 13</p>
<p>2. Simon 22</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="56">
<p>2</p>
</td>
<td width="169">
<p>Villain: Victor Jr.</p>
<p>(no minions)</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="435">
<tbody>
<tr>
<td width="57">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="57">
<p>10</p>
</td>
<td width="378">
<p>No villain with ID 10 exists in the database.</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp;&nbsp;&nbsp; Add Minion</h2>
<p>Write a program that <strong>reads</strong> <strong>information</strong> about a minion and its villain and <strong>adds it to the database</strong>. In case the town of the minion is not in the database, <strong>insert</strong> it as well. In case the villain is not present in the database, add him too with a default <strong>evilness</strong> <strong>factor</strong> of "evil". Finally set the new minion to be a servant of the villain. Print appropriate messages after each operation.</p>
<h3>Input</h3>
<p>The input comes in two lines:</p>
<ul>
<li>On the first line, you will receive the <strong>minion</strong> <strong>information</strong> in the format "Minion: &lt;<strong>Name</strong>&gt; &lt;<strong>Age</strong>&gt; &lt;<strong>TownName</strong>&gt;"</li>
<li>On the second &ndash; the <strong>villain</strong> <strong>information</strong> in the format "Villain: &lt;<strong>Name</strong>&gt;"</li>
</ul>
<h3>Output</h3>
<p>After completing an operation, you must print one of the following messages:</p>
<ul>
<li>After adding a new <strong>town</strong> to the database: "Town &lt;<strong>TownName</strong>&gt; was added to the database."</li>
<li>After adding a new <strong>villain</strong> to the database: "Villain &lt;<strong>VillainName</strong>&gt; was added to the database."</li>
<li>Finally, after successfully adding the <strong>minion</strong> to the database and making it a <strong>servant</strong> of a villain: "Successfully added &lt;<strong>MinionName</strong>&gt; to be minion of &lt;<strong>VillainName</strong>&gt;."</li>
</ul>
<p><strong>*Bonus task:</strong> Make sure all operations are executed successfully. In case of an error do not change the database.</p>
<h3>Example</h3>
<table width="680">
<tbody>
<tr>
<td width="255">
<p><strong>Input</strong></p>
</td>
<td width="425">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="255">
<p>Minion: Bob 14 Berlin</p>
<p>Villain: Gru</p>
</td>
<td width="425">
<p>Successfully added Robert to be minion of Gru.</p>
</td>
</tr>
<tr>
<td width="255">
<p>Minion: Cathleen 20 Liverpool</p>
<p>Villain: Gru</p>
</td>
<td width="425">
<p>Town Liverpool was added to the database.</p>
<p>Successfully added Cathleen to be minion of Gru.</p>
</td>
</tr>
<tr>
<td width="255">
<p>Minion: Mars 23 Sofia</p>
<p>Villain: Poppy</p>
</td>
<td width="425">
<p>Villain Poppy was added to the database.</p>
<p>Successfully added Mars to be minion of Poppy.</p>
</td>
</tr>
<tr>
<td width="255">
<p>Minion: Carry 20 Eindhoven</p>
<p>Villain: Jimmy</p>
</td>
<td width="425">
<p>Town Eindhoven was added to the database.</p>
<p>Villain Jimmy was added to the database.</p>
<p>Successfully added Carry to be minion of Jimmy.</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp; Change Town Names Casing</h2>
<p>Write a program that <strong>changes all town names to uppercase</strong> for a given country.</p>
<p>You will receive one line of input with the <strong>name</strong> of the country.</p>
<p><strong>Print the</strong> <strong>number of towns that were changed</strong> in the format "&lt;<strong>ChangedTownsCount</strong>&gt; town names were affected.". On a second line, <strong>print</strong> the <strong>names that were changed</strong>, separated with a comma and a space.</p>
<p>If <strong>no</strong> <strong>towns</strong> were affected (the country does not exist in the database or has no cities connected to it), <strong>print </strong>"<strong>No town names were affected.</strong>".</p>
<h3>Example</h3>
<table width="340">
<tbody>
<tr>
<td width="95">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>Bulgaria</p>
</td>
<td width="246">
<p>3 town names were affected.</p>
<p>[SOFIA, VARNA, BURGAS]</p>
</td>
</tr>
<tr>
<td width="95">
<p>Germany</p>
</td>
<td width="246">
<p>No town names were affected.</p>
</td>
</tr>
</tbody>
</table>
<h2>6.&nbsp;&nbsp;&nbsp;&nbsp; *Remove Villain</h2>
<p>Write a program that receives the <strong>ID</strong> of a villain, <strong>deletes him from the database</strong> and <strong>releases his minions</strong> from serving to him. Print on <strong>two</strong> <strong>lines</strong> the name of the deleted villain in format "&lt;<strong>Name</strong>&gt; <strong>was</strong> <strong>deleted</strong>." and the number of minions released in format "&lt;<strong>MinionCount</strong>&gt; <strong>minions</strong> <strong>were</strong> <strong>released</strong>.". Make sure all operations go as planned, otherwise do not make any changes in the database.</p>
<p>If there is no villain in the database with the given ID, print "<strong>No such villain was found</strong>.".</p>
<h3>Example</h3>
<table width="293">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="217">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>1</p>
</td>
<td width="217">
<p>Gru was deleted.</p>
<p>6 minions were released.</p>
</td>
</tr>
<tr>
<td width="76">
<p>3</p>
</td>
<td width="217">
<p>Victor was deleted.</p>
<p>0 minions were released.</p>
</td>
</tr>
<tr>
<td width="76">
<p>101</p>
</td>
<td width="217">
<p>No such villain was found.</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp;&nbsp;&nbsp; Print All Minion Names</h2>
<p>Write a program that <strong>prints all minion names</strong> from the minions table <strong>in the following order:</strong> first record, last record, first + 1, last - 1, first + 2, last - 2 &hellip; first + n, last - n.</p>
<table>
<tbody>
<tr>
<td width="22">
<p>1</p>
</td>
<td width="22">
<p>10</p>
</td>
<td width="22">
<p>2</p>
</td>
<td width="22">
<p>9</p>
</td>
<td width="22">
<p>3</p>
</td>
<td width="29">
<p>8</p>
</td>
<td width="22">
<p>4</p>
</td>
<td width="22">
<p>7</p>
</td>
<td width="23">
<p>5</p>
</td>
<td width="22">
<p>6</p>
</td>
</tr>
</tbody>
</table>
<h3>Example</h3>
<table width="189">
<tbody>
<tr>
<td width="104">
<p><strong>Original Order</strong></p>
</td>
<td width="85">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="104">
<p>Bob</p>
<p>Kevin</p>
<p>Steward</p>
<p>Jimmy</p>
<p>Vicky</p>
<p>Becky</p>
<p>Jully</p>
</td>
<td width="85">
<p>Bob</p>
<p>Jully</p>
<p>Kevin</p>
<p>Becky</p>
<p>Steward</p>
<p>Vicky</p>
<p>Jimmy</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp;&nbsp;&nbsp; Increase Minion Age</h2>
<p>Read from the console minion IDs separated by space.<strong> Increment the age</strong> of those minions <strong>by 1</strong> and make their <strong>names title case</strong>. Finally, <strong>print the name and the age of all minions</strong> in the database, each on a new row in format <strong>"&lt;Name&gt; &lt;Age&gt;</strong>".</p>
<h3>Example</h3>
<table width="208">
<tbody>
<tr>
<td colspan="3" width="208">
<p><strong>Minions</strong></p>
</td>
</tr>
<tr>
<td width="32">
<p><strong>Id</strong></p>
</td>
<td width="129">
<p><strong>Name</strong></p>
</td>
<td width="47">
<p><strong>Age</strong></p>
</td>
</tr>
<tr>
<td width="32">
<p>1</p>
</td>
<td width="129">
<p>bob</p>
</td>
<td width="47">
<p>14</p>
</td>
</tr>
<tr>
<td width="32">
<p>2</p>
</td>
<td width="129">
<p>stuart</p>
</td>
<td width="47">
<p>22</p>
</td>
</tr>
<tr>
<td width="32">
<p>3</p>
</td>
<td width="129">
<p>kevin</p>
</td>
<td width="47">
<p>13</p>
</td>
</tr>
<tr>
<td width="32">
<p>4</p>
</td>
<td width="129">
<p>jimmy</p>
</td>
<td width="47">
<p>49</p>
</td>
</tr>
<tr>
<td width="32">
<p>5</p>
</td>
<td width="129">
<p>vicky jackson</p>
</td>
<td width="47">
<p>26</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="444">
<tbody>
<tr>
<td width="64">
<p><strong>Input</strong></p>
</td>
<td width="153">
<p><strong>Output</strong></p>
</td>
<td width="19">
<p><strong>&nbsp;</strong></p>
</td>
<td width="57">
<p><strong>Input</strong></p>
</td>
<td width="151">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="64">
<p>2 1 4</p>
</td>
<td width="153">
<p>Bob 15</p>
<p>Stuart 23</p>
<p>kevin 13</p>
<p>Jimmy 50</p>
<p>vicky jackson 26</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="57">
<p>5</p>
</td>
<td width="151">
<p>bob 14</p>
<p>stuart 22</p>
<p>kevin 13</p>
<p>jimmy 49</p>
<p>Vicky Jackson 27</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp;&nbsp;&nbsp; Increase Age Stored Procedure</h2>
<p>Create stored procedure <strong>usp_GetOlder</strong> (<strong>directly in the database</strong> using <strong>Management Studio</strong> or any other similar tool) that receives <strong>MinionId</strong> and <strong>increases that minion&rsquo;s age by 1</strong>. Write a program that <strong>uses that stored procedure to increase the age</strong> of a minion whose id will be given as input from the console. After that <strong>print the name and the age</strong> of that minion.</p>
<h3>Example</h3>
<table width="208">
<tbody>
<tr>
<td colspan="3" width="208">
<p><strong>Minions</strong></p>
</td>
</tr>
<tr>
<td width="32">
<p><strong>Id</strong></p>
</td>
<td width="129">
<p><strong>Name</strong></p>
</td>
<td width="47">
<p><strong>Age</strong></p>
</td>
</tr>
<tr>
<td width="32">
<p>1</p>
</td>
<td width="129">
<p>bob</p>
</td>
<td width="47">
<p>14</p>
</td>
</tr>
<tr>
<td width="32">
<p>2</p>
</td>
<td width="129">
<p>steward</p>
</td>
<td width="47">
<p>22</p>
</td>
</tr>
<tr>
<td width="32">
<p>3</p>
</td>
<td width="129">
<p>kevin</p>
</td>
<td width="47">
<p>13</p>
</td>
</tr>
<tr>
<td width="32">
<p>4</p>
</td>
<td width="129">
<p>jimmy</p>
</td>
<td width="47">
<p>49</p>
</td>
</tr>
<tr>
<td width="32">
<p>5</p>
</td>
<td width="129">
<p>vicky jackson</p>
</td>
<td width="47">
<p>26</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="295">
<tbody>
<tr>
<td width="47">
<p><strong>Input</strong></p>
</td>
<td width="248">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="47">
<p>1</p>
</td>
<td width="248">
<p>bob &ndash; 15 years old</p>
</td>
</tr>
<tr>
<td width="47">
<p>3</p>
</td>
<td width="248">
<p>kevin &ndash; 14 years old</p>
</td>
</tr>
<tr>
<td width="47">
<p>5</p>
</td>
<td width="248">
<p>vicky jackson &ndash; 27 years old</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>