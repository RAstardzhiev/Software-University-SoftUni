<h1>Lab: Reflection</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/trainings/1637/c-sharp-oop-advanced-july-2017">"CSharp OOP Advanced" course @ SoftUni.</a></p>
<p>You can check your solutions here: <a href="https://judge.softuni.bg/Contests/710/Reflection-Lab">https://judge.softuni.bg/Contests/710/Reflection-Lab</a></p>
<h2>1.&nbsp;&nbsp; Stealer</h2>
<p>Add the Hacker class from the text file to your project. There is one really nasty hacker but not so wise though. He is trying to steal a big amount of money and transfer it to his own account. The police is after him but they need a proffessional&hellip; Correct - this is you!</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; You have the information that this hacker is keeping some of his info in private fields. Create a new class named <strong>Spy </strong>and add inside a method called - <strong>StealFieldInfo </strong>which receives:</p>
<ul>
<li>stirng - name of the class to investigate</li>
<li>array of string - names of the filds to investigate</li>
</ul>
<p>After finding the fields you must print on the console:</p>
<p>&ldquo;Class under investigation: <strong>{nameOfTheClass}</strong>&rdquo;</p>
<p>On the next lines print info about each field in the current format:</p>
<p>&ldquo;<strong>{filedName} </strong>= <strong>{fieldValue}</strong>&rdquo;</p>
<p>Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class! </strong></p>
<p>In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>Class under investigation: Hacker</p>
<p>username = securityGod82</p>
<p>password = mySuperSecretPassw0rd</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>2.&nbsp;&nbsp; High Quality Mistakes</h2>
<p>You are already expert of <strong>High Quality Code</strong>, so you know what kind of <strong>access modifiers</strong> must be set to members of class. You should have noticed our hacker is not familiar with these concepts.</p>
<p>Create a method inside your Spy class called - <strong>AnalyzeAcessModifiers</strong><strong>(</strong><strong>stirng className</strong><strong>)</strong>. Check all <strong>fields and methods access modifiers</strong>. Print on console all <strong>mistakes</strong> in format:</p>
<ul>
<li>Fields
<ul>
<li><strong>{fieldName} must be private!</strong></li>
</ul>
</li>
<li>Getters
<ul>
<li><strong>{methodName} have to be public!</strong></li>
</ul>
</li>
<li>Setters
<ul>
<li><strong>{methodName} have to be private!</strong></li>
</ul>
</li>
</ul>
<p>Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class! </strong></p>
<p>In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>username must be private!</p>
<p>get_Id have to be public!</p>
<p>set_Password have to be private!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>3.&nbsp;&nbsp; Mission Private Impossible</h2>
<p>It&rsquo;s time to see what this hacker you are dealing with aims to do. &nbsp;Create a method inside your Spy class called - <strong>RevealPrivateMethods</strong><strong>(</strong><strong>stirng className</strong><strong>)</strong>. Print all private methods in the following format:</p>
<p>All Private Methods of Class: <strong>{className}</strong></p>
<p>Base Class: <strong>{baseClassName}</strong></p>
<p>On the next lines print found method&rsquo;s names each on new line</p>
<p>Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class! </strong></p>
<p>In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>All Private Methods of Class: Hacker</p>
<p>Base Class: Object</p>
<p>get_Id</p>
<p>set_Id</p>
<p>set_BankAccountBalance</p>
<p>Finalize</p>
<p>MemberwiseClone</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>4.&nbsp;&nbsp; Collector</h2>
<p>Using reflection to get all "Hacker" methods. Then prepare algorithm that will recognize, which methods are getters and setters.</p>
<p>Print to console each getter on new line in format:</p>
<p><strong>{name} will return {Return Type}</strong></p>
<p>Then print all setters in format:</p>
<p><strong>{name} will set field of {Parameter Type}</strong></p>
<p>Use <strong>StringBuilder</strong> to concatenate the answer<strong>. Don&rsquo;t change anything in "Hacker" class! </strong></p>
<p>In your main Method you should be able to check your program with the current piece of code.</p>
<h3>Example</h3>
<table>
<tbody>
<tr>
<td width="520">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="520">
<p>get_Password will return System.String</p>
<p>get_Id will return System.Int32</p>
<p>get_BankAccountBalance will return System.Double</p>
<p>set_Password will set field of System.String</p>
<p>set_Id will set field of System.Int32</p>
<p>set_BankAccountBalance will set field of System.Double</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>