<h1>Exercises: Introduction to DB Apps</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1442/databases-advanced-entity-framework-october-2016">"Databases Advanced &ndash; Entity Framework" course @ Software University.</a></p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Initial Setup</h2>
<p>Write a program that connects to your <strong>localhost</strong> server. Create <strong>new database </strong>called <strong>MinionsDB</strong> where we will keep information about our minions and villains.</p>
<p>For each <strong>minion</strong> we should keep information about its <strong>name</strong>, <strong>age</strong> and <strong>town</strong>.&nbsp; Each <strong>town</strong> has information about <strong>in</strong> <strong>which</strong> <strong>country</strong> is located. <strong>Villains</strong> have <strong>name</strong> and <strong>evilness</strong> <strong>factor</strong> (<strong>good</strong>, <strong>bad</strong>, <strong>evil</strong>, <strong>super</strong> <strong>evil</strong>). Each <strong>minion</strong> can <strong>serve</strong> to <strong>several</strong> <strong>villains</strong> and <strong>each</strong> <strong>villain</strong> can <strong>have</strong> <strong>several</strong> <strong>minions</strong> to <strong>serve</strong> <strong>him</strong>. Fill all tables with at least 5 records each.</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Get Villains&rsquo; Names</h2>
<p>Write a program that prints on the console <strong>all villains&rsquo; names</strong> and their <strong>number of minions</strong> of those who has more than 3 minions <strong>ordered descending</strong> by number of minions.</p>
<h3>Example</h3>
<table width="95">
<tbody>
<tr>
<td width="95">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="95">
<p>Gru 6</p>
<p>Victor 4</p>
<p>Jilly 4</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; Get Minion Names</h2>
<p>Write a program that prints on the console <strong>all minion names</strong> and age for given <strong>villain id.</strong></p>
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
<p><em>(no minions)</em></p>
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
<p>Write a program that <strong>reads</strong> <strong>information</strong> about minion and its villain and <strong>add it to the database</strong>. In case the town of the minion is not in the database <strong>insert</strong> it as well. In case the villain is not present in the database add him too with default evilness factor of &ldquo;evil&rdquo;. Finally set the new minion to be servant of the villain. Print appropriate messages after each operation.</p>
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
<p>Successfully added Mars to be minion of Poppy</p>
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
<p>Successfully added Carry to be minion of Jimmy</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp;&nbsp;&nbsp; Change Town Names Casing</h2>
<p>Write a program that <strong>change all town names to uppercase</strong> for towns for given country. <strong>Print the</strong> <strong>number of towns that were changed</strong> in the format provided in examples. On the next line <strong>print</strong> those <strong>names that were changed</strong> separated with coma and space.</p>
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
<p>Write a program that receives <strong>ID</strong> of a villain, <strong>delete him from the database</strong> and <strong>releases his minions</strong> from serving to him. As an output print the name of the villain and the number of minions were released. Make sure all operations go as planned otherwise do not make any changes in the database.</p>
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
<p>Gru was deleted</p>
<p>6 minions released</p>
</td>
</tr>
<tr>
<td width="76">
<p>3</p>
</td>
<td width="217">
<p>Victor was deleted</p>
<p>0 minions released</p>
</td>
</tr>
<tr>
<td width="76">
<p>101</p>
</td>
<td width="217">
<p>No such villain was found</p>
</td>
</tr>
</tbody>
</table>
<h2>7.&nbsp;&nbsp;&nbsp;&nbsp; Print All Minion Names</h2>
<p>Write a program that <strong>prints all minion names</strong> from the minions table <strong>in order</strong> first record, last record, first + 1, last &ndash; 1, first + 2, last &ndash; 2&hellip; first + n, last &ndash; n.</p>
<table>
<tbody>
<tr>
<td width="22">
<p>1</p>
</td>
<td width="22">
<p>3</p>
</td>
<td width="22">
<p>5</p>
</td>
<td width="22">
<p>7</p>
</td>
<td width="22">
<p>9</p>
</td>
<td width="29">
<p>10</p>
</td>
<td width="22">
<p>8</p>
</td>
<td width="22">
<p>6</p>
</td>
<td width="23">
<p>4</p>
</td>
<td width="22">
<p>2</p>
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
<h2>8.&nbsp;&nbsp;&nbsp;&nbsp; Increase Minions Age</h2>
<p>Read from console minion IDs separated by space.<strong> Increment age</strong> of those minions <strong>by 1</strong> and make their <strong>name title case</strong>. Finally <strong>print names and ages of all minions</strong> that are in the database.</p>
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
<p>Steward 23</p>
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
<p>steward 22</p>
<p>kevin 13</p>
<p>jimmy 49</p>
<p>Vicky Jackson 27</p>
</td>
</tr>
</tbody>
</table>
<h2>9.&nbsp;&nbsp;&nbsp;&nbsp; Increase Age Stored Procedure</h2>
<p>Create stored procedure <strong>usp_GetOlder</strong> (<strong>directly in the database</strong> using <strong>Management Studio</strong> or any other similar tool) that receive <strong>MinionId</strong> and <strong>increase its years by 1</strong>. Write a program that <strong>uses that stored procedure to increase age</strong> of a minion whose id will be given as input from the console. After that <strong>print the name and the age</strong> of that minion.</p>
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
<table width="208">
<tbody>
<tr>
<td width="47">
<p><strong>Input</strong></p>
</td>
<td width="161">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="47">
<p>1</p>
</td>
<td width="161">
<p>bob 15</p>
</td>
</tr>
<tr>
<td width="47">
<p>3</p>
</td>
<td width="161">
<p>kevin 14</p>
</td>
</tr>
<tr>
<td width="47">
<p>5</p>
</td>
<td width="161">
<p>vicky jackson 27</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>