<h1>Exercises: Open / Closed and Liskov</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/courses/csharp-oop-advanced-high-quality-code">"C# OOP Advanced" course @ Software University</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Logger</h2>
<p>Write a logging library for logging messages. The interface for the end-user should be as follows:</p>
<table>
<tbody>
<tr>
<td width="354">
<p><strong>Sample Source Code</strong></p>
</td>
<td width="343">
<p><strong>Sample Output</strong></p>
</td>
</tr>
<tr>
<td width="354">
<p>ILayout simpleLayout = new SimpleLayout();</p>
<p>IAppender consoleAppender =</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp; new ConsoleAppender(simpleLayout);</p>
<p>ILogger logger = new Logger(consoleAppender);</p>
<p>&nbsp;</p>
<p>logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");</p>
<p>logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");</p>
</td>
<td width="343">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>Logger logs data and time (string) and a message (string).</p>
<h3>Library Architecture</h3>
<p>The library should have the following components:</p>
<ul>
<li><strong>Layouts</strong> - define the format in which messages should be appended (e.g. <strong>SimpleLayout</strong> displays logs in the format "<strong>&lt;date-time&gt; - &lt;report level&gt; - &lt;message&gt;</strong>")</li>
<li><strong>Appenders -</strong> responsible for appending the messages somewhere (e.g. Console, File, etc.)</li>
<li><strong>Loggers</strong> - hold methods for various kinds of logging (warnings, errors, info, etc.)</li>
</ul>
<p>Whenever a logger is told to log something, it calls all of its appenders and tells them to append the message. In turn, the appenders append the message (e.g. to the console or a file) according to the layout they have.</p>
<h3>Requirements</h3>
<p>You library should correctly follow all <strong>SOLID</strong> principles:</p>
<ul>
<li><strong>Single Responsibility Principle</strong> - no class or method should do more than one thing at once</li>
<li><strong>Open-Closed Principle</strong> - the library should be open for extension (i.e. its user should be able to create his own layouts/appenders/loggers)</li>
<li><strong>Liskov Substitution Principle -</strong> children classes should not break the behavior of their parent</li>
<li><strong>Interface Segregation Principle</strong> - the library should provide simple interfaces for the client to implement</li>
<li><strong>Dependency Inversion</strong> - no class/method should directly depend on concretions (only on abstractions)</li>
</ul>
<p>Avoid code repetition. Name everything accordingly.</p>
<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
<h3>Implementations</h3>
<p>The library should provide the following ready classes for the client:</p>
<ul>
<li><strong>SimpleLayout</strong> - defines the format "<strong>&lt;date-time&gt; - &lt;report level&gt; - &lt;message&gt;</strong>"</li>
<li><strong>ConsoleAppender</strong> - appends a log to the console using the provided layout</li>
<li><strong>FileAppender</strong> - appends a log to a file using the provided layout</li>
<li><strong>LogFile </strong>- a custom file class which logs messages in a string builder using a method <strong>Write()</strong>. It should have a <strong>getter</strong> for its <strong>size</strong> which is the sum of the ascii codes of all alphabet characters it contains (e.g. a-z and A-Z).</li>
<li><strong>Logger</strong>- a logger class which is used to log messages. Calls each of its appenders when something needs to be logged.</li>
</ul>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="606">
<p><strong>Sample Source Code</strong></p>
</td>
</tr>
<tr>
<td width="606">
<p>var simpleLayout = new SimpleLayout();</p>
<p>var consoleAppender = new ConsoleAppender(simpleLayout);</p>
<p>&nbsp;</p>
<p>var file = new LogFile();</p>
<p>var fileAppender = new FileAppender(simpleLayout);</p>
<p>fileAppender.File = file;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>var logger = new Logger(consoleAppender, fileAppender);</p>
<p>logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");</p>
<p>logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");</p>
</td>
</tr>
</tbody>
</table>
<p>The above code should log the messages both on the <strong>console</strong> and in <strong>log.txt</strong> in the format <strong>SimpleLayout</strong> provides.</p>
<h3>Extensibility</h3>
<p>The end-user should be able to add his own <strong>layouts</strong>/<strong>appenders</strong>/<strong>loggers</strong> and use them. For example, he should be able to create his own <strong>XmlLayout</strong> and make the appenders use it, <strong>without directly</strong><strong> editing</strong> the library source code.</p>
<table>
<tbody>
<tr>
<td width="606">
<p><strong>Sample Source Code</strong></p>
</td>
</tr>
<tr>
<td width="606">
<p>var xmlLayout = new XmlLayout();</p>
<p>var consoleAppender = new ConsoleAppender(xmlLayout);</p>
<p>var logger = new Logger(consoleAppender);</p>
<p>&nbsp;</p>
<p>logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");</p>
<p>logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");</p>
</td>
</tr>
<tr>
<td width="606">
<p><strong>Console Output</strong></p>
</td>
</tr>
<tr>
<td width="606">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h3>Report Threshold</h3>
<p>Implement a <strong>report level threshold</strong> in all appenders. The appender should append only messages with report level <strong>above or equal to </strong>its report level threshold (by default all messages are appended). The report level is in the order Info &gt; Warning &gt; Error &gt; Critical &gt; Fatal.</p>
<table>
<tbody>
<tr>
<td width="697">
<p><strong>Sample Source Code</strong></p>
</td>
</tr>
<tr>
<td width="697">
<p>var simpleLayout = new SimpleLayout();</p>
<p>var consoleAppender = new ConsoleAppender(simpleLayout);</p>
<p>consoleAppender.ReportLevel = ReportLevel.Error;</p>
<p>&nbsp;</p>
<p>var logger = new Logger(consoleAppender);</p>
<p>&nbsp;</p>
<p>logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");</p>
<p>logger.Warn("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");</p>
<p>logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");</p>
<p>logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");</p>
<p>logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");</p>
</td>
</tr>
<tr>
<td width="697">
<p><strong>Console Output</strong></p>
</td>
</tr>
<tr>
<td width="697">&nbsp;</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>Only messages from error and above are appended.</p>
<h3>File</h3>
<p>A file should write all messages internally and it should keep information about its size.</p>
<p>Size of a file is calculated by summing ASCII codes of all alphabet characters (a-Z). For example, a file appender with simple layout and a single message <strong>"3/31/2015 5:33:07 PM - ERROR - Error parsing request" </strong>has size 2606 (including all characters in PM, ERROR, Error, parsing, request). In case of Xml layout, the file would have size 6632, because of the extra characters within the tags.</p>
<h3>Controller</h3>
<p>Implement a Controller which reads all appenders that a Logger will have and input messages from the console. Every message should be evaluated by all the appenders and logged if they meet the report level. Console appenders should write directly on the console. File appenders write (save) the messages but do not print them.</p>
<h3>Input</h3>
<p>On the first line, you will get <strong>N</strong> - the number of appenders. On the next N lines, you will get information about the appenders in one of the formats below:</p>
<ul>
<li><strong>"&lt;appender type&gt; &lt;layout type&gt; &lt;REPORT LEVEL&gt;"</strong></li>
<li><strong>"&lt;appender type&gt; &lt;layout type&gt;"</strong></li>
</ul>
<p>If no report level is provided, the appender should be set to record all messages.</p>
<p>Next, until you get the "END" command you will receive messages containing report level, time and message separated by pipe "|":</p>
<ul>
<li><strong>"&lt;REPORT LEVEL&gt;|&lt;time&gt;|&lt;message&gt;"</strong></li>
</ul>
<h3>Output</h3>
<p>Console appenders should print directly at the console in the layout they are provided:</p>
<ul>
<li>Simple layout example - <strong>"3/31/2015 5:33:07 PM - ERROR - Error parsing request"</strong></li>
<li>Xml layout example (date, level and message tags are indented by 1 tabulation) -</li>
</ul>
<p><strong>&lt;log&gt;</strong></p>
<p><strong>&lt;date&gt;3/31/2015 5:33:07 PM&lt;/date&gt;</strong></p>
<p><strong>&lt;level&gt;ERROR&lt;/level&gt;</strong></p>
<p><strong>&lt;message&gt;Error parsing request&lt;/message&gt;</strong></p>
<p><strong>&lt;/log&gt;</strong></p>
<p>&nbsp;</p>
<p>After the "END" command you should print Logger info which includes statistics about every appender (its type, layout, report level, messages appended and file size for file appenders):</p>
<p><strong>"Logger info</strong></p>
<p><strong>Appender type: &lt;appender type&gt;, Layout type: &lt;layout type&gt;, Report level: &lt;REPORT LEVEL&gt;, Messages appended: &lt;count&gt;, File size &lt;size&gt;"</strong></p>
<h3>Example</h3>
<table width="690">
<tbody>
<tr>
<td width="690">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>2</p>
<p>ConsoleAppender SimpleLayout CRITICAL</p>
<p>FileAppender XmlLayout</p>
<p>INFO|3/26/2015 2:08:11 PM|Everything seems fine</p>
<p>WARNING|3/26/2015 2:22:13 PM|Warning: ping is too high - disconnect imminent</p>
<p>ERROR|3/26/2015 2:32:44 PM|Error parsing request</p>
<p>CRITICAL|3/26/2015 2:38:01 PM|No connection string found in App.config</p>
<p>FATAL|3/26/2015 2:39:19 PM|mscorlib.dll does not respond</p>
<p>END</p>
</td>
</tr>
<tr>
<td width="690">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="690">
<p>3/26/2015 2:38:01 PM - CRITICAL - No connection string found in App.config</p>
<p>3/26/2015 2:39:19 PM - FATAL - mscorlib.dll does not respond</p>
<p>Logger info</p>
<p>Appender type: ConsoleAppender, Layout type: SimpleLayout, Report level: CRITICAL, Messages appended: 2</p>
<p>Appender type: FileAppender, Layout type: XmlLayout, Report level: INFO, Messages appended: 5, File size: 37526</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Blobs</h2>
<p>This problem is originally from the <a href="https://judge.softuni.bg/Contests/147/OOP-Exam-20-December-2015-Morning">OOP-Exam-20-December-2015-Blobs</a>.</p>
<p>Blobs are slimy little creatures who have been at war for the last 300 years that have special abilities in the form of behaviors and special attacks.</p>
<p>You are given a partly finished library, which contains some models (Blob, Behavior and Attack). Refactor the given code and complete an application which supports creating blobs and simulating fights between them.</p>
<h2>Task 1 - Implement the Game Objects</h2>
<p>A blob has a <strong>name</strong>, <strong>health</strong> and <strong>damage</strong>.</p>
<p>A blob also has a <strong>behavior</strong>. A behavior is triggered when a blob falls to<strong> less or equal </strong>to<strong> half its initial health</strong>. The following behaviors should be supported:</p>
<ul>
<li><strong>Aggressive Behavior</strong> - doubles the blob's damage. Each consecutive turn the blob loses <strong>5 damage</strong>. The unit's damage cannot fall below its initial value (the damage before the behavior was toggled).</li>
<li><strong>Inflated Behavior</strong> - The blob gains <strong>50 health</strong>. Each consecutive turns the blob loses <strong>10 health</strong>.</li>
</ul>
<p>A behavior can only be triggered <strong>once</strong>. It should be triggered even if the blob falls to 0 health. If it is triggered a second time, an error should be raised.</p>
<p>A blob can <strong>attack</strong> another blob. The following attacks should be supported:</p>
<ul>
<li><strong>Putrid Fart</strong> - the blob produces an attack with <strong>damage</strong> equal to its <strong>own damage</strong></li>
<li><strong>Blobplode </strong>- the blob loses <strong>half its current health</strong> (e.g. from 55 health loses 27 health = 28 health left) and produces an attack with <strong>damage</strong> equal to <strong>double its own damage</strong>
<ul>
<li>The blob cannot fall below 1 health from attacking with Blobplode</li>
</ul>
</li>
</ul>
<p>A blob can perform an attack multiple times (only once per turn). A blob can have only a <strong>single attack</strong> (either Putrid Fart, Blobplode or any other attack) and a single behavior (either Aggressive, Inflated or any other behavior).</p>
<h3>Other Notes</h3>
<ul>
<li>If a blob's attack <strong>triggers a behavior</strong>, the behavior should be applied <strong>immediately </strong>(i.e. a <strong>behavior triggered by an attack</strong> can affect the <strong>attack</strong> that triggered it)</li>
<li>A blob should not fall below <strong>0 health</strong></li>
<li><strong>Dead blobs</strong> cannot attack / be attacked</li>
</ul>
<h2>Task 2 - Flexible Blobs</h2>
<p>Design the blobs so they can work flexibly with <strong>any behavior</strong> and <strong>any attack</strong>.</p>
<h2>Task 3 - Improve the Models</h2>
<p>Encapsulate all internal behavior. The implemented classes should not reveal any internal logic.</p>
<p>Avoid code repetition and promote code reusability by applying the good practices of OOP.</p>
<h2>Task 4 - Application Logic</h2>
<p>From the standard input you will receive<strong> commands</strong>, each on a separate line. The application should support the following commands:</p>
<ul>
<li><strong>create &lt;name&gt; &lt;health&gt; &lt;damage&gt; &lt;behavior&gt; &lt;attack&gt;</strong> - adds a new blob with the specified behavior and attack</li>
<li><strong>attack &lt;attacker&gt; &lt;target&gt;</strong> - forces a blob to perform an attack on another blob</li>
</ul>
<p>The <strong>attacking blob</strong> produces an <strong>attack</strong> that deals damage to the <strong>target blob's health</strong>.</p>
<ul>
<li><strong>pass</strong> - does nothing, skips the turn and progresses the game</li>
<li><strong>status</strong> - prints data about the current state of the game in the following format:</li>
</ul>
<table>
<tbody>
<tr>
<td width="618">
<p><strong>Blob {name}: {health} HP, {damage} Damage</strong></p>
<p><strong>...</strong></p>
</td>
</tr>
</tbody>
</table>
<p>Blobs should be printed in order of entry in the game.</p>
<p>If a blob has been killed, the format should instead be:</p>
<table>
<tbody>
<tr>
<td width="618">
<p><strong>Blob {name} KILLED</strong></p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>drop</strong> - ends the program</li>
</ul>
<p>Each command should progress the game with <strong>1 turn </strong>after it is executed.</p>
<h2>Task 5 - Loose Coupling</h2>
<p>The application should support the creation of blobs with <strong>any behavior </strong>and<strong> attack</strong>.</p>
<h2>Task 6 - Input / Output Independence</h2>
<p>The application should be designed to work with <strong>any input source </strong>and <strong>output destination</strong>. In other words, it should <strong>NOT</strong> depend on the console.</p>
<h2>* Bonus Task 7 - Blob Events</h2>
<p>Implement a fifth command:</p>
<ul>
<li><strong>report-events</strong> - if passed as <strong>first command</strong> in input the engine should <strong>print detailed information</strong> when blobs attack each other:</li>
<li>When a blob toggles its behavior</li>
</ul>
<table width="612">
<tbody>
<tr>
<td width="612">
<p><strong>Blob {name} toggled {behavior-type}</strong></p>
</td>
</tr>
</tbody>
</table>
<ul>
<li>When a blob is killed (its health drops to 0 after all effects are taken into consideration)</li>
</ul>
<table>
<tbody>
<tr>
<td width="612">
<p><strong>Blob {name} was killed </strong></p>
</td>
</tr>
</tbody>
</table>
<p>The blobs should <strong>NOT</strong> directly interact with the engine or any input/output classes.</p>
<p>This task is not part of the automated tests in the Judge system.</p>
<h2>Input</h2>
<p>The input will be read from the standard input. On each line a command will be given (one of the described above).</p>
<h2>Output</h2>
<p>The output should be printed on the console. Upon receiving the status command, print the current status of the game as described above.</p>
<h2>Constraints</h2>
<ul>
<li>The <strong>health</strong> and <strong>damage</strong> will be valid 32-bit integer numbers</li>
<li>The input will always end with the drop command</li>
<li>The <strong>report-events</strong> command will always come first if present in the input</li>
</ul>
<h2>Examples</h2>
<table>
<tbody>
<tr>
<td width="347">
<p><strong>Input</strong></p>
</td>
<td width="348">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="347">
<p>create Cenko 30 15 Inflated PutridFart</p>
<p>create Boko 50 20 Aggressive Blobplode</p>
<p>attack Boko Cenko</p>
<p>status</p>
<p>status</p>
<p>status</p>
<p>status</p>
<p>status</p>
<p>status</p>
<p>drop</p>
</td>
<td width="348">
<p>Blob Cenko: 50 HP, 15 Damage</p>
<p>Blob Boko: 25 HP, 40 Damage</p>
<p>Blob Cenko: 40 HP, 15 Damage</p>
<p>Blob Boko: 25 HP, 35 Damage</p>
<p>Blob Cenko: 30 HP, 15 Damage</p>
<p>Blob Boko: 25 HP, 30 Damage</p>
<p>Blob Cenko: 20 HP, 15 Damage</p>
<p>Blob Boko: 25 HP, 25 Damage</p>
<p>Blob Cenko: 10 HP, 15 Damage</p>
<p>Blob Boko: 25 HP, 20 Damage</p>
<p>Blob Cenko KILLED</p>
<p>Blob Boko: 25 HP, 20 Damage</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="347">
<p><strong>Input</strong></p>
</td>
<td width="348">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="347">
<p>create Fiki 90 5 Inflated Blobplode</p>
<p>create Jorjo 30 25 Inflated Blobplode</p>
<p>attack Fiki Jorjo</p>
<p>status</p>
<p>attack Fiki Jorjo</p>
<p>status</p>
<p>drop</p>
</td>
<td width="348">
<p>Blob Fiki: 95 HP, 5 Damage</p>
<p>Blob Jorjo: 20 HP, 25 Damage</p>
<p>Blob Fiki: 33 HP, 5 Damage</p>
<p>Blob Jorjo: 60 HP, 25 Damage</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="347">
<p><strong>Input</strong></p>
</td>
<td width="348">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="347">
<p>create Sir 70 20 Aggressive Blobplode</p>
<p>create Stenly 33 15 Aggressive Blobplode</p>
<p>create Royce 50 20 Inflated Blobplode</p>
<p>status</p>
<p>attack Stenly Royce</p>
<p>status</p>
<p>status</p>
<p>drop</p>
</td>
<td width="348">
<p>Blob Sir: 70 HP, 20 Damage</p>
<p>Blob Stenly: 33 HP, 15 Damage</p>
<p>Blob Royce: 50 HP, 20 Damage</p>
<p>Blob Sir: 70 HP, 20 Damage</p>
<p>Blob Stenly: 17 HP, 15 Damage</p>
<p>Blob Royce: 70 HP, 20 Damage</p>
<p>Blob Sir: 70 HP, 20 Damage</p>
<p>Blob Stenly: 17 HP, 15 Damage</p>
<p>Blob Royce: 60 HP, 20 Damage</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="347">
<p><strong>Input</strong></p>
</td>
<td width="348">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="347">
<p>report-events</p>
<p>create Petya 20 10 Aggressive PutridFart</p>
<p>create Emi 30 15 Inflated PutridFart</p>
<p>attack Petya Emi</p>
<p>attack Petya Emi</p>
<p>attack Emi Petya</p>
<p>attack Emi Petya</p>
<p>pass</p>
<p>status</p>
<p>drop</p>
</td>
<td width="348">
<p>Blob Emi toggled InflatedBehavior</p>
<p>Blob Petya toggled AggressiveBehavior</p>
<p>Blob Petya was killed</p>
<p>Blob Petya KILLED</p>
<p>Blob Emi: 30 HP, 15 Damage</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>