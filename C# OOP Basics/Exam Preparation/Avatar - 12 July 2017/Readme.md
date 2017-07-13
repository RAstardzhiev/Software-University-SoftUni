<h1>OOP Retake Exam &ndash; Avatar</h1>
<p>The nations are at an eternal conflict. Which one of them has the strongest benders? Which one of them has the strongest deities. Who will win and who will fail, trying to do so. . . You decide!</p>
<h2>Overview</h2>
<p>You have been given the godlike power to supervise the conflict between the nations. However, you are lazy to do it by hand, so you will write a godlike program to do it.</p>
<h2>Structure</h2>
<p>The structure of the program consists of Benders and Monuments. Implement your classes, in the same way as they are <strong>described</strong> <strong>below</strong> (class names, field types, field names etc.). Keep the <strong>naming conventions</strong> and <strong>rules</strong>.</p>
<h4>Benders</h4>
<p>All Benders have 2 characteristics you must implement:</p>
<ul>
<li>Name &ndash; a <strong>string</strong>, holding the name of the Bender.</li>
<li>Power &ndash; an <strong>integer</strong>, holding the power of the Bender.</li>
</ul>
<p>There are <strong>4 types</strong> of Benders:</p>
<h5>AirBender</h5>
<p>The AirBender has an additional characteristic:</p>
<ul>
<li>AerialIntegrity &ndash; a <strong>floating-point number</strong>, holding the aerialIntegirty of the Bender.</li>
</ul>
<h5>WaterBender</h5>
<p>The WaterBender has an additional characteristic:</p>
<ul>
<li>WaterClarity &ndash; a <strong>floating-point number</strong>, holding the waterClarity of the Bender.</li>
</ul>
<h5>FireBender</h5>
<p>The FireBender has an additional characteristic:</p>
<ul>
<li>HeatAggression &ndash; a <strong>floating-point number</strong>, holding the heatAggression of the Bender.</li>
</ul>
<h5>EarthBender</h5>
<p>The EarthBender has an additional characteristic:</p>
<ul>
<li>GroundSaturation &ndash; a <strong>floating-point number</strong>, holding the groundSaturation of the Bender.</li>
</ul>
<h4>Monuments</h4>
<p>The second entities are the Monuments. A monument has 1 characteristic:</p>
<ul>
<li>Name &ndash; a <strong>string</strong>, holding the name of the Monument.</li>
</ul>
<p>There are <strong>4 types</strong> of Monuments:</p>
<h5>AirMonument</h5>
<p>The AirMonument has an additional characteristic:</p>
<ul>
<li>AirAffinity &ndash; an <strong>integer</strong>, holding the airAffinity of the <strong>Monument</strong>.</li>
</ul>
<h5>WaterMonument</h5>
<p>The WaterMonument has an additional characteristic:</p>
<ul>
<li>WaterAffinity &ndash; an <strong>integer</strong>, holding the waterAffinity of the <strong>Monument</strong>.</li>
</ul>
<h5>FireMonument</h5>
<p>The FireMonument has an additional characteristic:</p>
<ul>
<li>FireAffinity &ndash; an <strong>integer</strong>, holding the fireAffinity of the <strong>Monument</strong>.</li>
</ul>
<h5>EarthMonument</h5>
<p>The EarthMonument has an additional characteristic:</p>
<ul>
<li>EarthAffinity &ndash; an <strong>integer</strong>, holding the earthAffinity of the <strong>Monument</strong>.</li>
</ul>
<h4>Nation</h4>
<p>The <strong>nations</strong> are just the <strong>majorities</strong> of <strong>Benders</strong>. For example, the <strong>Fire nation</strong> <strong>represents</strong> a <strong>collection</strong> of all the created <strong>Fire Benders</strong>. You do <strong>NOT</strong> need a class for the nations, although it won&rsquo;t be incorrect if you implement a such.</p>
<h2>Functionality</h2>
<p>The functionality and main logic of the program circles around the benders and the monuments. The benders don&rsquo;t just stand there and do nothing. The four types of benders represent the warriors of the different nations. Each nation can issue a war and involve all the others in a fight, which results in only the strongest nation &ndash; remaining alive. The monuments also have a role in these wars. Upon starting a war, all monuments are activated, which by itself increases the nations&rsquo; total power. You can see below, in the subsections, exactly how, this happens.</p>
<h3>Classes</h3>
<h4>The Controller Class</h4>
<p>The business logic of the program should be concentrated around several commands. Implement a class called NationBuilder, which will hold the <strong>main functionality</strong>, represented by these <strong>public</strong> <strong>methods</strong>:</p>
<table width="390">
<tbody>
<tr>
<td width="390">
<p>NationsBuilder.cs</p>
</td>
</tr>
<tr>
<td width="390">
<p>void AssignBender(List&lt;string&gt; benderArgs)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>void AssignMonument(List&lt;string&gt; monumentArgs)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>string GetStatus(string nationsType)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>void IssueWar(string nationsType)</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
<p>string GetWarsRecord()</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp; //TODO: Add some logic here &hellip;</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h4>Benders</h4>
<p>The Benders&rsquo; main role is to be the source of power for a certain nation. They are the warriors that define the power of their nation. The total power of a nation is used when a war is issued. The nations&rsquo; total power is compared and the strongest nation survives.</p>
<p>A Bender&rsquo;s total power is calculated by the following formulas:</p>
<ul>
<li>AirBender &ndash; (power * aerialIntegrity)</li>
<li>WaterBender &ndash; (power * waterClarity)</li>
<li>FireBender &ndash; (power * heatAggression)</li>
<li>EarthBender &ndash; (power * groundSaturation)</li>
</ul>
<p>A <strong>nation&rsquo;s total power</strong> represents the <strong>sum</strong> of its <strong>Benders&rsquo; total powers</strong>.</p>
<h4>Monuments</h4>
<p>The monuments increase a nation&rsquo;s total power, when a war is issued. This means that you must <strong>first</strong> <strong>calculate</strong> the <strong>total power</strong> of <strong>each nation</strong>, and then <strong>increase</strong> it by the<strong> bonuses</strong> of the <strong>monuments</strong>.</p>
<p>Every monument has an affinity. The <strong>sum</strong> of <strong>ALL</strong> monuments&rsquo; affinities <strong>increases</strong> the nation&rsquo;s <strong>total power</strong> by <strong>percentage</strong>.</p>
<p>Each monument <strong>corresponds</strong> to a <strong>particular nation</strong>. If you have an AirMonument it affects the <strong>Air nation</strong> <strong>ONLY</strong>.</p>
<p>For example: If the Air nation has <strong>1000 total power</strong> and you have 2 AirMonuments &ndash; one with 100 airAffinity and the other with 200 airAffinity. The <strong>sum</strong> of their affinities is 300 airAffinity. That means you must <strong>increase</strong> the <strong>total power</strong> of the <strong>Air nation</strong> by <strong>300%</strong>.</p>
<p>So you must <strong>increase</strong> the <strong>total power</strong> by (1000 / 100) * 300 = 3000. That would result in 1000 + 3000 = 4000.</p>
<h3>Commands</h3>
<p>There are several commands that must be implemented in order for the program to follow the business logic.</p>
<p>You will see their functionality and what they are supposed to do in this section.</p>
<h5>Bender Commands</h5>
<p>Parameters &ndash; type (<strong>string</strong>), name (<strong>string</strong>), power (<strong>int</strong>), secondaryParameter (<strong>floating-point number</strong>).</p>
<p>Creates a <strong>Bender</strong> of the <strong>given type</strong>, with the <strong>given parameters</strong>.</p>
<p>The type will either be &ldquo;<strong>Air</strong>&rdquo;, &ldquo;<strong>Water</strong>&rdquo;, &ldquo;<strong>Fire</strong>&rdquo; or &ldquo;<strong>Earth</strong>&rdquo;.</p>
<p>The secondaryParameter should be assigned as a value, <strong>depending</strong> of the <strong>type</strong> of the <strong>Bender</strong>, to one of the following:</p>
<ul>
<li>aerialIntegrity</li>
<li>waterClarity</li>
<li>heatAggression</li>
<li>groundSaturation</li>
</ul>
<h5>Monument Command</h5>
<p>Parameters &ndash; type (<strong>string</strong>), name (<strong>string</strong>), affinity (<strong>int</strong>).</p>
<p>Creates a <strong>Monument</strong> of the <strong>given type</strong>, with the <strong>given parameters</strong>.</p>
<p>The type will either be &ldquo;<strong>Air</strong>&rdquo;, &ldquo;<strong>Water</strong>&rdquo;, &ldquo;<strong>Fire</strong>&rdquo; or &ldquo;<strong>Earth</strong>&rdquo;.</p>
<h5>Status Command</h5>
<p>Parameters &ndash; nation (<strong>string</strong>).</p>
<p>The nation will either be &ldquo;<strong>Air</strong>&rdquo;, &ldquo;<strong>Water</strong>&rdquo;, &ldquo;<strong>Fire</strong>&rdquo; or &ldquo;<strong>Earth</strong>&rdquo;.</p>
<p>Prints detailed information about the <strong>nation</strong>, corresponding to the <strong>given name</strong>. Prints a string representation of all the <strong>Benders</strong> and all of the <strong>Monuments</strong> corresponding to the <strong>given nation</strong>.</p>
<h5>War Command</h5>
<p>Parameters &ndash; nation (<strong>string</strong>).</p>
<p>The nation will either be &ldquo;<strong>Air</strong>&rdquo;, &ldquo;<strong>Water</strong>&rdquo;, &ldquo;<strong>Fire</strong>&rdquo; or &ldquo;<strong>Earth</strong>&rdquo;.</p>
<p>The <strong>given nation</strong>, issues a war and <strong>involves all other nations</strong> in it. All nations&rsquo; <strong>total</strong> <strong>power</strong> is calculated, <strong>summing</strong> up the <strong>total power</strong> of their <strong>Benders</strong>, and then adding up <strong>all bonuses</strong> from their <strong>Monuments</strong>.</p>
<p>When everything has been calculated, the nation with the <strong>highest</strong> <strong>total</strong> <strong>power</strong> is the one that <strong>wins</strong>. The <strong>other</strong> <strong>nations</strong> must <strong>delete</strong> <strong>all</strong> of their <strong>Benders</strong> and <strong>Monuments</strong>, as if they were destroyed.</p>
<p>Naturally, the nations that lost, <strong>may</strong> still <strong>add new Benders</strong> and <strong>Monuments</strong>, so that the logic of the program may continue.</p>
<p>You can safely assume, that there will be <strong>NO nations</strong> who share the <strong>SAME total power </strong>as <strong>value</strong>.</p>
<h5>Quit Command</h5>
<p>Terminates the user input sequence and <strong>exits</strong> the program. Upon doing so, you should print <strong>every issued war</strong> and the <strong>nation</strong> that issued it. The wars must be printed by order of issuing, or in other words, by <strong>order of input</strong>.</p>
<h3>Input</h3>
<p>The input consists of several commands, as you&rsquo;ve already seen. Their input format is described below:</p>
<ul>
<li>Bender {type} {name} {power} {secondaryParameter}</li>
<li>Monument {type} {name} {affinity}</li>
<li>Status {nation}</li>
<li>War {nation}</li>
<li>Quit</li>
</ul>
<h3>Output</h3>
<p>This is the output section. This section describes the format of the output you must present. You can see how the classes are being represented as strings and what is the format of the output of the commands.</p>
<h4>Classes</h4>
<p>Each <strong>type</strong> of <strong>Bender</strong> has his own <strong>string representation</strong>:</p>
<ul>
<li>Air Bender: {benderName}, Power: {power}, Aerial Integrity: {aerialIntegrity}</li>
<li>Water Bender: {benderName}, Power: {power}, Water Clarity: {waterClarity}</li>
<li>Fire Bender: {benderName}, Power: {power}, Heat Aggression: {heatAggression}</li>
<li>Earth Bender: {benderName}, Power: {power}, Ground Saturation: {groundSaturation}</li>
</ul>
<p>Each <strong>type</strong> of <strong>Monument</strong> has his own <strong>string representation</strong>:</p>
<ul>
<li>Air Monument: {monumentName}, Air Affinity: {airAffinity}</li>
<li>Water Monument: {monumentName}, Water Affinity: {waterAffinity}</li>
<li>Fire Monument: {monumentName}, Fire Affinity: {fireAffinity}</li>
<li>Earth Monument: {monumentName}, Earth Affinity: {earthAffinity}</li>
</ul>
<h4>Commands</h4>
<h4>Status Command</h4>
<p>Prints all of its Benders in the following way:</p>
<p>{nationType} Nation<br /> Benders:<br /> ###{bender1}<br /> ###{bender2}<br /> . . .<br /> Monuments:<br /> ###{monument1}<br /> ###{monument2}<br /> . . .</p>
<p>The <strong>nation type</strong> will either be &ldquo;<strong>Air</strong>&rdquo;, &ldquo;<strong>Water</strong>&rdquo;, &ldquo;<strong>Fire</strong>&rdquo; or &ldquo;<strong>Earth</strong>&rdquo;, depending on the nation that is being presented.</p>
<p>Each <strong>Bender</strong> and <strong>Monument</strong> must be <strong>printed</strong> with its <strong>string representation</strong>.</p>
<p>The data should <strong>NOT</strong> be ordered (in other words &ndash; <strong>order of input</strong>).</p>
<p>In case there are <strong>NO Benders</strong> or <strong>NO Monuments</strong> the output should look like this:<br /> Benders: None<br /> or<br /> Monuments: None</p>
<h4>Quit Command</h4>
<p>Terminates the program and prints <strong>ALL</strong> the <strong>issued wars</strong>, <strong>with the nations</strong> that <strong>issued</strong> them, in the following format:</p>
<p>War 1 issued by {nation}.<br /> War 2 issued by {nation}.<br /> War 3 issued by {nation}.<br /> . . .<br /> War N issued by {nation}.</p>
<p>The order of printing is by <strong>order</strong> of <strong>issuing</strong> the wars &ndash; from the <strong>first issued</strong>, to the <strong>last one</strong>.</p>
<p><strong>NOTE</strong>: <strong>All floating-point numbers</strong> in the <strong>output</strong> should be <strong>FORMATTED </strong>to the <strong>second digit</strong> after the <strong>decimal point</strong>.</p>
<h2>Constrains</h2>
<ul>
<li>The <strong>names</strong> of the <strong>Benders</strong> and the <strong>Monuments</strong> will contain only <strong>alphanumeric characters</strong>.</li>
<li>All <strong>integers</strong> in the input will be in <strong>range [0, 1.000.000.000]</strong>.</li>
<li>All <strong>floating-point numbers</strong> in the input will be in <strong>range [0, 1.000.000]</strong>.</li>
<li>There will be <strong>NO invalid</strong> input lines.</li>
<li>There will be <strong>NO invalid parameters</strong> in the commands.</li>
<li>There will be <strong>NO stalemates</strong> when issuing a war.</li>
<li>There will <strong>ALWAYS</strong> be <strong>atleast 1</strong></li>
</ul>
<h2>Examples</h2>
<table width="656">
<tbody>
<tr>
<td width="269">
<p><strong>Input</strong></p>
</td>
<td width="387">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="269">
<p>Bender Fire Tony 1000 2500.5667</p>
<p>Bender Fire Donald 1000 2100</p>
<p>Bender Air Yu 1000 1230</p>
<p>War Fire</p>
<p>War Air</p>
<p>War Fire</p>
<p>Quit</p>
</td>
<td width="387">
<p>War 1 issued by Fire</p>
<p>War 2 issued by Air</p>
<p>War 3 issued by Fire</p>
</td>
</tr>
<tr>
<td width="269">
<p>Bender Air Yu 100 215.677</p>
<p>Bender Air Muk 200 241.24124</p>
<p>Bender Fire Donald 100 214.4</p>
<p>Monument Fire JerseyGrew 1000</p>
<p>Status Air</p>
<p>Status Fire</p>
<p>War Fire</p>
<p>Status Air</p>
<p>Bender Earth Dock 201 123</p>
<p>Bender Water Klci 201 1244</p>
<p>War Water</p>
<p>Quit</p>
</td>
<td width="387">
<p>Air Nation</p>
<p>Benders:</p>
<p>###Air Bender: Yu, Power: 100, Aerial Integrity: 215.68</p>
<p>###Air Bender: Muk, Power: 200, Aerial Integrity: 241.24</p>
<p>Monuments: None</p>
<p>Fire Nation</p>
<p>Benders:</p>
<p>###Fire Bender: Donald, Power: 100, Heat Aggression: 214.40</p>
<p>Monuments:</p>
<p>###Fire Monument: JerseyGrew, Fire Affinity: 1000</p>
<p>Air Nation</p>
<p>Benders: None</p>
<p>Monuments: None</p>
<p>War 1 issued by Fire</p>
<p>War 2 issued by Water</p>
</td>
</tr>
</tbody>
</table>
<h2>Tasks</h2>
<p>These are the tasks you must complete in order to solve the exam completely. Submit your solutions in the Judge system. <strong>NOTE</strong>: Every task has its <strong>own execution strategy</strong>, so check them out.</p>
<h4>Structure</h4>
<p><strong>Implement</strong> the described <strong>classes</strong>, in the way they were described (<strong>class names</strong>, <strong>field names</strong> and so on). Create a good OOP structure with packages and distribution of classes.</p>
<p>Put everything in a global package. . . Example: &ldquo;src/avatar/. . .&rdquo;, and submit the <strong>PACKAGE ONLY</strong> (&ldquo;avatar&rdquo;) it in the Judge System. Do <strong>NOT</strong> submit the whole &ldquo;src&rdquo; folder.</p>
<h4>Input / Output (I/O)</h4>
<p>Implement the <strong>functionality</strong> that was <strong>described</strong> (<strong>Commands</strong>, <strong>class inner functionality</strong> etc.). Check with the <strong>Example tests</strong>, if you&rsquo;ve done it <strong>correctly</strong>.</p>
<p>You have a few tests in Judge, which mainly <strong>test</strong> the <strong>correct functionality</strong>.</p>
<p>For <strong>this task</strong>, submit the <strong>whole</strong> &ldquo;src&rdquo; folder, in the Judge System.</p>
<p>&nbsp;</p>