<h1>OOP Advanced Exam &ndash; H.E.L.L.</h1>
<p>In a galaxy far away, a civilization called &ndash; The Lightmen organizes an annual tournament. The participants are striving for power through the use of marvelous magical items, in order to win the unnatural fray &ndash; H.E.L.L.</p>
<h3>Overview</h3>
<p>Due to the fact that H.E.L.L. has gotten way out of hand and there have been countless... casualties, the Light Council decided to cancel the tournament. But the light people were not very happy with that decision, so the Council had the idea of a mini-game that simulates the tournament. Guess who they hired to write the code for it. That&rsquo;s right! You!</p>
<h3>Structure</h3>
<p>Here are the entities that should exist as models in your program.</p>
<h4>Heroes</h4>
<p>The main participants of the tournament are <strong>Heroes</strong>. Each hero has <strong>several stats</strong>:</p>
<ul>
<li>Name &ndash; a <strong>string</strong>, indicating the <strong>name</strong> of the <strong>hero</strong>.</li>
<li>Strength &ndash; an <strong>integer</strong>, indicating the <strong>strength</strong> of the <strong>hero</strong>.</li>
<li>Agility &ndash; an <strong>integer</strong>, indicating the <strong>agility</strong> of the <strong>hero</strong>.</li>
<li>Intelligence &ndash; an <strong>integer</strong>, indicating the <strong>intelligence</strong> of the <strong>hero</strong>.</li>
<li>HitPoints &ndash; an <strong>integer</strong>, indicating the <strong>hit</strong> <strong>points</strong> of the <strong>hero</strong>.</li>
<li>Damage &ndash; an <strong>integer</strong>, indicating the <strong>damage</strong> of the <strong>hero</strong>.</li>
</ul>
<p>The heroes also have an <strong>Inventory</strong>. The inventory will be <strong>given to you</strong> in the <strong>skeleton</strong>. <br /> You can check <strong>more info</strong> about it in the <strong>Skeleton</strong> <strong>section</strong>.</p>
<p>There are generally <strong>3</strong> <strong>types</strong> of <strong>heroes &ndash; </strong>Barbarian, Assassin, and Wizard.</p>
<h4>Items</h4>
<p>Aside from the heroes there are items.</p>
<p>The items have several properties:</p>
<ul>
<li>Name &ndash; a <strong>string</strong>, indicating the <strong>name</strong> of the item.</li>
<li>StrengthBonus &ndash; an <strong>integer</strong>, indicating the <strong>strength</strong> <strong>bonus</strong> of the <strong>item</strong>.</li>
<li>AgilityBonus &ndash; an <strong>integer</strong>, indicating the <strong>agility bonus</strong> of the <strong>item</strong>.</li>
<li>IntelligenceBonus &ndash; an <strong>integer</strong>, indicating the <strong>intelligence bonus</strong> of the <strong>item</strong>.</li>
<li>HitPointsBonus &ndash; an <strong>integer</strong>, indicating the <strong>hit points bonus</strong> of the <strong>item</strong>.</li>
<li>DamageBonus &ndash; an <strong>integer</strong>, indicating the <strong>damage bonus</strong> of the <strong>item</strong>.</li>
</ul>
<p>There are two types of items &ndash; CommonItem and RecipeItem.</p>
<ul>
<li>The CommonItem is just a normal item.</li>
<li>The RecipeItem has RequiredItems &ndash; a <strong>collection</strong> of CommonItem.</li>
</ul>
<p>The RecipeItem will be <strong>initialized</strong> with an <strong>additional element</strong> &ndash; the RequiredItems. Check in the <strong>Input section</strong> for more info.</p>
<h3>Functionality</h3>
<p>As you can see the main logic goes around several entities &ndash; the heroes and the items. The heroes have items which increase their stats. The heroes also have an inventory, in which their items are being held. There are also recipe items which have a little more interesting logic behind themselves.</p>
<h4>Heroes</h4>
<p>The difference between the 3 types of heroes (<strong>Strength</strong>, <strong>Agility</strong>, <strong>Intelligence</strong>) is the <strong>base stats</strong>, they start with. They are constant values.</p>
<table width="585">
<tbody>
<tr>
<td width="139">
<p>Stats</p>
</td>
<td width="148">
<p>Barbarian</p>
</td>
<td width="147">
<p>Assassin</p>
</td>
<td width="152">
<p>Wizard</p>
</td>
</tr>
<tr>
<td width="139">
<p>Strength</p>
</td>
<td width="148">
<p>90</p>
</td>
<td width="147">
<p>25</p>
</td>
<td width="152">
<p>25</p>
</td>
</tr>
<tr>
<td width="139">
<p>Agility</p>
</td>
<td width="148">
<p>25</p>
</td>
<td width="147">
<p>100</p>
</td>
<td width="152">
<p>25</p>
</td>
</tr>
<tr>
<td width="139">
<p>Intelligence</p>
</td>
<td width="148">
<p>10</p>
</td>
<td width="147">
<p>15</p>
</td>
<td width="152">
<p>100</p>
</td>
</tr>
<tr>
<td width="139">
<p>HitPoints</p>
</td>
<td width="148">
<p>350</p>
</td>
<td width="147">
<p>150</p>
</td>
<td width="152">
<p>100</p>
</td>
</tr>
<tr>
<td width="139">
<p>Damage</p>
</td>
<td width="148">
<p>150</p>
</td>
<td width="147">
<p>300</p>
</td>
<td width="152">
<p>250</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Upon initialization</strong>, each <strong>hero</strong> should be <strong>assigned the values</strong>, specified above, <strong>depending</strong> on <strong>his type</strong>.</p>
<h4>Items</h4>
<h5>CommonItem</h5>
<p>If a <strong>hero</strong> has a <strong>certain </strong>CommonItem in his <strong>inventory</strong>, <strong>his stats</strong> are <strong>increased</strong>, by the <strong>value</strong> of the <strong>stat bonuses</strong> of the <strong>item</strong>, <strong>CORRESPONDINGLY</strong>.</p>
<p><strong>In other words</strong>: If a hero has an <strong>item</strong> with <strong>50 strength bonus</strong>, in his <strong>inventory</strong>, the <strong>hero&rsquo;s strength</strong> is <strong>increased</strong> by <strong>50</strong>. <br /> If a CommonItem is <strong>removed</strong> from the <strong>inventory</strong>, <strong>all bonuses</strong> from it, are <strong>also removed</strong>.</p>
<h5>RecipeItem</h5>
<p>When a hero has a RecipeItem in his Inventory, it does <strong>NOT</strong> give him <strong>ANY</strong> of its bonuses. The RecipeItem is formed from its RequiredItems.</p>
<p>When a hero <strong>has</strong> <strong>all of the items</strong> that a RecipeItem requires, those items are being <strong>removed</strong> from his <strong>inventory</strong>, <strong>along</strong> with <strong>the</strong> <strong>recipe</strong>, and a CommonItem is put on their place, with the <strong>stats</strong> of the RecipeItem.<br /> As if the items have combined with the recipe in order to create a stronger item.</p>
<h4>Commands</h4>
<p>There are several commands which are given from the user input, in order to control the game of H.E.L.L. Here you can see how they are formed.</p>
<p>The <strong>parameters</strong> will be given in the <strong>EXACT ORDER</strong>, as the one <strong>specified below</strong>. <br /> You can see the exact input format in the <strong>Input section</strong>.</p>
<p><strong>Each</strong> <strong>command</strong> will <strong>generate an output</strong> <strong>result</strong>, which you must <strong>print</strong>.<br /> You can see the exact output format in the <strong>Output section</strong>.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h5>Hero Command</h5>
<p><strong>Parameters</strong> &ndash; <strong>name</strong> (string), <strong>type</strong> (string).</p>
<p>Creates a Hero of the <strong>given type</strong>, with the <strong>given name</strong>. <br /> The type will either be &ldquo;Barbarian&rdquo;, &ldquo;Assassin&rdquo; or &ldquo;Wizard&rdquo;.</p>
<h5>Item Command</h5>
<p><strong>Parameters</strong> &ndash; <strong>name</strong> (string), <strong>heroName</strong> (string), <strong>strengthBonus</strong> (int), <strong>agilityBonus</strong> (int), <strong>intelligenceBonus</strong> (int), <strong>hitpointsBonus</strong> (int), <strong>damageBonus</strong> (int).</p>
<p>Creates a CommonItem with the <strong>given parameters</strong>, and <strong>adds</strong> it to the <strong>inventory</strong> of the <strong>hero</strong> with the <strong>given name</strong>.</p>
<h5>Recipe Command</h5>
<p><strong>Parameters</strong> &ndash; <strong>name</strong> (string), <strong>heroName</strong> (string), <strong>strengthBonus</strong> (int), <strong>agilityBonus</strong> (int), <strong>intelligenceBonus</strong> (int), <strong>hitpointsBonus</strong> (int), <strong>damageBonus</strong> (int), <strong>requiredItem1</strong> (string), <strong>requiredItem2</strong> (string). . .</p>
<p>Creates a RecipeItem with the <strong>given parameters</strong>, and <strong>adds</strong> it to the <strong>inventory</strong> of the <strong>hero</strong> with the <strong>given name</strong>.</p>
<p>The <strong>required items</strong> are <strong>given last</strong>, and their <strong>COUNT</strong> is <strong>VARIABLE</strong>. The required items are <strong>given</strong> as <strong>names</strong> of <strong>items</strong>.</p>
<h5>Inspect Command</h5>
<p><strong>Parameters</strong> &ndash; <strong>name</strong> (string)</p>
<p><strong>Inspects</strong> the <strong>hero</strong> with the <strong>given name</strong>, providing <strong>information</strong> about his <strong>stats</strong> and <strong>items</strong>.<br /> The command should present information <strong>ONLY</strong> about the CommonItems from the hero.</p>
<h5>Quit</h5>
<p><strong>Quits</strong> the game. . . When that happens, <strong>ALL HEROES</strong> must be <strong>printed</strong> in a specific format.</p>
<h3>Skeleton</h3>
<p>In this section you will be given information about the Skeleton, or the code that has been given to you.</p>
<p>You are allowed to change the <strong>internal</strong> and <strong>private logic</strong> of the <strong>classes</strong> that have been given to you. <br /> In other words, you can change the <strong>body code</strong> and the <strong>definitions</strong> of the <strong>private members</strong> in whatever <br /> way you like.</p>
<p>However. . .</p>
<p>You are <strong>NOT ALLOWED</strong> to <strong>CHANGE</strong> the <strong>Interfaces</strong> that have been provided by the <strong>skeleton</strong> in <strong>ANY way</strong>. <br /> You are <strong>NOT ALLOWED</strong> to<strong> ADD</strong> more <strong>PUBLIC LOGIC</strong>, than the <strong>one</strong>, <strong>provided</strong> by the <strong>Interfaces</strong>.</p>
<h4>Interfaces</h4>
<p>You will be given the <strong>DOCUMENTED</strong> <strong>interfaces</strong> for the Hero and Item entities. You should use them when you are implementing your entities.</p>
<p>You will <strong>also be given</strong> an <strong>interface</strong> for the Inventory class, but you will be given the <strong>class itself</strong> too.</p>
<p>You will <strong>also be given</strong> an <strong>annotation</strong>, connected to the Inventory class, which will ease your work, in some way.</p>
<p>Read the documentation of the interfaces to gain basic knowledge of the behavior they define.</p>
<h4>Inventory</h4>
<p>You will be given the Inventory<strong> class</strong>, along with an <strong>Interface</strong> for it.</p>
<p>The Inventory&rsquo;s main purpose is to <strong>store</strong> the <strong>items</strong> of a particular <strong>hero</strong>.</p>
<p>The Inventory class holds <strong>2 collections</strong> &ndash; for the CommonItems and for the RecipeItems. They are being stored in different collections for obvious reasons...</p>
<p>The <strong>collections</strong> are <strong>private</strong>, so <strong>in order</strong> to <strong>add items</strong> to them, the class <strong>exposes 2 methods</strong> for adding elements.</p>
<p>Upon <strong>adding</strong> a RecipeItem or a CommonItem, the Inventory checks <strong>all recipes</strong>, and if <strong>all required items</strong>, to a certain recipe, <strong>have been gathered</strong>, it combines them with the recipe and creates a CommonItem with the stats of the <strong>corresponding</strong> RecipeItem.</p>
<p>The Inventory also holds several methods, for <strong>extracting the bonuses</strong> from all CommonItems, because only they <strong>give bonuses</strong> to the <strong>hero</strong>.</p>
<p>Your task is to study the code in the Skeleton, and use it in your code, in order to complete the business logic of the program.</p>
<h3>Input</h3>
<p>The input consists of several commands which will be given in the format, specified below:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</p>
<ul>
<li>Hero {heroName} {heroType}</li>
<li>Item {name} {heroName} {strengthBonus} {agilityBonus} {intelligenceBonus} {hitpointsBonus} {damageBonus}</li>
<li>Recipe {name} {heroName} {strengthBonus} {agilityBonus} {intelligenceBonus} {hitpointsBonus} {damageBonus} {requiredItem1} {requiredItem2}. . .</li>
<li>Inspect {heroName}</li>
<li>Quit</li>
</ul>
<h3>Output</h3>
<p>Each of the commands generates <strong>output</strong>. Here are the <strong>output formats</strong> of each command:</p>
<ul>
<li>Hero Command &ndash; registers a hero of the given type, with the given name. Prints the following result:</li>
</ul>
<p>Created {type} &ndash; {name}</p>
<p>&nbsp;</p>
<ul>
<li>Item Command &ndash; adds a CommonItem to a specified hero.</li>
</ul>
<p>Added item - {itemName} to Hero - {heroName}</p>
<p>&nbsp;</p>
<ul>
<li>Recipe Command &ndash; adds a RecipeItem to a specified hero.</li>
</ul>
<p>Added recipe - {recipeName} to Hero &ndash; {heroName}</p>
<p>&nbsp;</p>
<ul>
<li>Inspect command &ndash; provides <strong>information</strong> about a <strong>hero&rsquo;s</strong> <strong>stats</strong> and <strong>items</strong>, in the following format:</li>
</ul>
<p>Hero: {heroName}, Class: {heroType}<br /> HitPoints: {hitpoints}, Damage: {damage}<br /> Strength: {strength}<br /> Agility: {agility}<br /> Intelligence: {intelligence}<br /> Items:<br /> ###Item: {item1Name}<br /> ###+{strengthBonus} Strength<br /> ###+{agilityBonus} Agility<br /> ###+{intelligenceBonus} Intelligence<br /> ###+{hitpointsBonus} HitPoints<br /> ###+{damageBonus} Damage<br /> ###Item: {item2Name}<br /> . . .</p>
<ul>
<li>In case the hero <strong>has NO items</strong>, print &ldquo;Items: None&rdquo; below the stats.</li>
</ul>
<p>&nbsp;</p>
<ul>
<li>Quit command &ndash; <strong>prints</strong> all heroes <strong>ordered</strong> in <strong>descending order</strong> by <strong>the sum</strong> of their (<strong>Strength</strong> + <strong>Agility</strong> + <strong>Intelligence</strong>) and if <strong>2 heroes</strong> have the <strong>SAME SUM</strong>, they should be <strong>ordered</strong> in <strong>descending order</strong> by <strong>the sum</strong> of their (<strong>hitpoints</strong> + <strong>damage</strong>). The format, in which the heroes should be printed is:</li>
</ul>
<ol>
<li>{heroType}: {heroName}<br /> ###HitPoints: {hitpoints}<br /> ###Damage: {damage}<br /> ###Strength: {strength}<br /> ###Agility: {agility}<br /> ###Intelligence: {intelligence}<br /> ###Items: {item1Name}, {item2Name}, {item3Name}. . .<br /> 2. {heroType}: {heroName}<br /> . . .
<ul>
<li>In case the hero <strong>has NO items</strong>, print &ldquo;Items: None&rdquo; below the stats.</li>
</ul>
</li>
</ol>
<h3>Constrains</h3>
<ul>
<li>The <strong>names</strong> of the <strong>heroes</strong> and the <strong>items</strong> may contain <strong>only Alphanumeric characters</strong>.</li>
<li>The <strong>strengthBonus</strong>, <strong>intelligenceBonus</strong>, <strong>agilityBonus</strong>, <strong>hitpointsBonus</strong>, <strong>damageBonus</strong> <strong>stats</strong> of the <strong>ITEMS</strong><br /> will be <strong>valid integers</strong> in <strong>range [0, 2<sup>30</sup>]</strong>.</li>
<li>There will be <strong>NO invalid input</strong>, like missing arguments from the input or non-existent heroes in the commands, requiring hero names.</li>
</ul>
<p>&nbsp;</p>
<h3>Example Tests</h3>
<table width="706">
<tbody>
<tr>
<td width="382">
<p><strong>Input</strong></p>
</td>
<td width="324">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="382">
<p>Hero Ivan Barbarian</p>
<p>Hero Pesho Assassin</p>
<p>Item Knife Ivan 0 10 0 0 30</p>
<p>Item Stick Ivan 0 0 10 0 5</p>
<p>Recipe Spear Ivan 25 10 10 100 50 Knife Stick</p>
<p>Inspect Ivan</p>
<p>Inspect Pesho</p>
<p>Quit</p>
<p>&nbsp;</p>
</td>
<td width="324">
<p>Created Barbarian - Ivan</p>
<p>Created Assassin - Pesho</p>
<p>Added item - Knife to Hero - Ivan</p>
<p>Added item - Stick to Hero - Ivan</p>
<p>Added recipe - Spear to Hero - Ivan</p>
<p>Hero: Ivan, Class: Barbarian</p>
<p>HitPoints: 450, Damage: 200</p>
<p>Strength: 115</p>
<p>Agility: 35</p>
<p>Intelligence: 20</p>
<p>Items:</p>
<p>###Item: Spear</p>
<p>###+25 Strength</p>
<p>###+10 Agility</p>
<p>###+10 Intelligence</p>
<p>###+100 HitPoints</p>
<p>###+50 Damage</p>
<p>Hero: Pesho, Class: Assassin</p>
<p>HitPoints: 150, Damage: 300</p>
<p>Strength: 25</p>
<p>Agility: 100</p>
<p>Intelligence: 15</p>
<p>Items: None</p>
<p>1. Barbarian: Ivan</p>
<p>###HitPoints: 450</p>
<p>###Damage: 200</p>
<p>###Strength: 115</p>
<p>###Agility: 35</p>
<p>###Intelligence: 20</p>
<p>###Items: Spear</p>
<p>2. Assassin: Pesho</p>
<p>###HitPoints: 150</p>
<p>###Damage: 300</p>
<p>###Strength: 25</p>
<p>###Agility: 100</p>
<p>###Intelligence: 15</p>
<p>###Items: None</p>
</td>
</tr>
<tr>
<td width="382">
<p>Hero Donald Wizard</p>
<p>Item Staff Donald 0 10 50 100 100</p>
<p>Item Orb Donald 0 0 100 100 350</p>
<p>Hero Jefrey Wizard</p>
<p>Item Staff Jefrey 0 10 50 100 100</p>
<p>Item Orb Jefrey 0 0 100 100 350</p>
<p>Recipe Oculus Jefrey 100 100 100 1000 2500 Staff Orb</p>
<p>Recipe Oculus Donald 100 100 100 1000 2500 Staff Orb</p>
<p>Item Ring Jefrey 0 0 0 1 1</p>
<p>Quit</p>
</td>
<td width="324">
<p>Created Wizard - Donald</p>
<p>Added item - Staff to Hero - Donald</p>
<p>Added item - Orb to Hero - Donald</p>
<p>Created Wizard - Jefrey</p>
<p>Added item - Staff to Hero - Jefrey</p>
<p>Added item - Orb to Hero - Jefrey</p>
<p>Added recipe - Oculus to Hero - Jefrey</p>
<p>Added recipe - Oculus to Hero - Donald</p>
<p>Added item - Ring to Hero - Jefrey</p>
<p>1. Wizard: Jefrey</p>
<p>###HitPoints: 1101</p>
<p>###Damage: 2751</p>
<p>###Strength: 125</p>
<p>###Agility: 125</p>
<p>###Intelligence: 200</p>
<p>###Items: Oculus, Ring</p>
<p>2. Wizard: Donald</p>
<p>###HitPoints: 1100</p>
<p>###Damage: 2750</p>
<p>###Strength: 125</p>
<p>###Agility: 125</p>
<p>###Intelligence: 200</p>
<p>###Items: Oculus</p>
</td>
</tr>
</tbody>
</table>
<h3>Tasks</h3>
<h4>Task 1: High Quality Structure</h4>
<h5>Refactor the given Skeleton code and use it.</h5>
<p>Apparently, there was a person who tried to write the program before you, but he couldn&rsquo;t do much, so he was &hellip; Detached. But he somehow managed to write the Inventory class. His work, however, is not that trustworthy, so you might have to give it an eye or two, for potential <strong>functionality bugs</strong> and things that <strong>do NOT follow </strong>the <strong>good practices</strong> of <strong>Object-Oriented Programming</strong>.</p>
<p>The previous employee left a single <strong>TODO</strong> in the code. It requires for you to initialize a CommonItem, with the <strong>stat bonuses</strong> of the RecipeItem, given as <strong>parameter</strong> to the <strong>corresponding method</strong>.</p>
<p>Refactor anything, which will <strong>improve</strong> the <strong>code quality</strong>, in your opinion. Be careful <strong>NOT</strong> to <strong>break the code</strong> or one of the <strong>rules</strong> specified in the <strong>Skeleton</strong> <strong>section</strong>.</p>
<p><strong>Implement</strong> the <strong>given</strong> <strong>INTERFACES</strong> in your class definitions, all of them.</p>
<h5>High Quality Code.</h5>
<p>Achieve good separation of concerns using abstractions and interfaces to decouple classes, while reusing code through inheritance and polymorphism. Your classes should have strong cohesion - have single responsibility and loose coupling - know about as few other classes as possible.</p>
<p>Make sure you <strong>inject</strong> <strong>all</strong> of your class <strong>dependencies</strong> trough <strong>interfaces</strong>.</p>
<h5>Reflection.</h5>
<p>Implement the Items property method of the Hero entities, with <strong>reflection</strong>.</p>
<h4>Task 2: Correct business logic.</h4>
<p>The given code provides some functionality, but it does not cover the entire task. Implement the rest of the business logic, using the given code, and implement everything following the requirements specification. Check your solutions in the Judge system.</p>
<p>Make sure you have <strong>fixed</strong> <strong>ALL BUGS</strong> in the Inventory logic <strong>before</strong> you <strong>submit your code</strong> in <strong>Judge</strong> or you are sure to get <strong>incorrect results</strong>.</p>
<h4>Task 3: Unit Testing.</h4>
<p>Test the <strong>ALL</strong> of the Inventory class&rsquo;s methods for potential bugs.</p>
<p>You are allowed to use <strong>only</strong> the <strong>classes </strong>and<strong> interfaces</strong>, <strong>PROVIDED BY THE</strong> <strong>Skeleton</strong> in your <strong>unit testing</strong>. If you try to use the classes you have implemented, you will <strong>NOT</strong> <strong>receive any points</strong>.<br /> </p>