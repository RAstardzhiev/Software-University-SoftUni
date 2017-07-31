<h1>Exercises: Enumerations and Attributes</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/trainings/1375/java-basics-oop-june-2016">"C# OOP Basics" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card Suit</h2>
<p>Create an enumeration type that has as its constants the four suits of a deck of playing cards (Clubs, Hearts, Diamonds, Spades) Iterate over the values of the enumeration type and print all ordinal values and names.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Card Suits</p>
</td>
<td width="378">
<p>Card Suits:</p>
<p>Ordinal value: 0; Name value: Clubs</p>
<p>Ordinal value: 1; Name value: Diamonds</p>
<p>Ordinal value: 2; Name value: Hearts</p>
<p>Ordinal value: 3; Name value: Spades</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card Rank</h2>
<p>Create an enumeration type that has as its constants the fourteen ranks of a deck of playing cards (Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King) Iterate over the values of the enumeration type and print all ordinal values and names.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Card Ranks</p>
</td>
<td width="378">
<p>Card Ranks:</p>
<p>Ordinal value: 0; Name value: Ace</p>
<p>Ordinal value: 1; Name value: Two</p>
<p>Ordinal value: 2; Name value: Three</p>
<p>Ordinal value: 3; Name value: Four</p>
<p>Ordinal value: 4; Name value: Five</p>
<p>Ordinal value: 5; Name value: Six</p>
<p>Ordinal value: 6; Name value: Seven</p>
<p>Ordinal value: 7; Name value: Eight</p>
<p>Ordinal value: 8; Name value: Nine</p>
<p>Ordinal value: 9; Name value: Ten</p>
<p>Ordinal value: 10; Name value: Jack</p>
<p>Ordinal value: 11; Name value: Queen</p>
<p>Ordinal value: 12; Name value: King</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card Power</h2>
<p>Create <strong>class</strong> <strong>Card</strong> that holds <strong>Rank</strong> and <strong>Suit</strong>. &nbsp;Create a program that generates a deck of cards which have a power. The power of a card is calculated by adding the power of its rank plus the power of its suit.</p>
<p>Rank powers are as follows: (Ace - 14, Two - 2, Three - 3, Four - 4, Five - 5, Six - 6, Seven - 7, Eight - 8, Nine - 9, Ten - 10, Jack - 11, Queen - 12, King - 13).</p>
<p>Suit powers are as follows: (Clubs - 0, Diamonds - 13, Hearts - 26, Spades - 39).</p>
<p>You will get a command consisting of two lines. On the first line you will receive the Rank of the card and on the second line you will get the suit of the card.</p>
<p>Print the output in the format "Card name: ACE of SPADES; Card power: 53".</p>
<h3>Note</h3>
<p>Try using the enumeration types you have created in the previous problems but extending them with constructors and methods. To get the card power cast to integer Rank and Suit and add them together.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Two</p>
<p>Clubs</p>
</td>
<td width="378">
<p>Card name: Two of Clubs; Card power: 2</p>
</td>
</tr>
<tr>
<td width="198">
<p>Ace</p>
<p>Spades</p>
</td>
<td width="378">
<p>Card name: Ace of Spades; Card power: 53</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 4.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card ToString()</h2>
<p>If you haven&rsquo;t done it already override the <strong>ToString()</strong> of your <strong>Card</strong> class you've created earlier. Make it so it returns the same information as before e.g. in format:</p>
<p>"Card name: {Rank} of {Suit}; Card power: {Card power}"</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Two</p>
<p>Clubs</p>
</td>
<td width="378">
<p>Card name: Two of Clubs; Card power: 2</p>
</td>
</tr>
<tr>
<td width="198">
<p>Ace</p>
<p>Spades</p>
</td>
<td width="378">
<p>Card name: Ace of Spades; Card power: 53</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 5.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card CompareTo()</h2>
<p>As your cards have power you can safely add a functionality for comparing them. Try using the already available interface <strong>IComparable&lt;T&gt;</strong> and override the <strong>CompareTo() </strong>method.</p>
<p>Read two cards from the console and print the greater of the two. In the given format:</p>
<p>"Card name: {Rank} of {Suit}; Card power: {Card power}"</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Two</p>
<p>Clubs</p>
<p>Ace</p>
<p>Spades</p>
</td>
<td width="378">
<p>Card name: Ace of Spades; Card power: 53</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 6.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Custom Enum Attribute</h2>
<p>Create a custom attribute <strong>TypeAttribute</strong> that can be applied to classes and can be accessed at runtime. The <strong>TypeAttribute</strong> elements should contain <strong>type,</strong> <strong>category</strong> and <strong>description </strong>as parameters. Apply the attribute to both enumeration types you have created for the previous problems (Rank and Suit). Provide them these exact values:</p>
<p>Rank:</p>
<ul>
<li>type = "Enumeration"</li>
<li>category = "Rank"</li>
<li>description = "Provides rank constants for a Card class."</li>
</ul>
<p>Suit:</p>
<ul>
<li>type = "Enumeration"</li>
<li>category = "Suit"</li>
<li>description = "Provides suit constants for a Card class."</li>
</ul>
<p>Create a program which gets the description of an enumeration type by a given rank.</p>
<h3>Note</h3>
<p>Try using the <a href="https://msdn.microsoft.com/en-us/library/system.type.getcustomattributes(v=vs.110).aspx"><strong>typeof(TypeAttribute).GetCustomAttributes()</strong></a> method.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Rank</p>
</td>
<td width="378">
<p>Type = Enumeration, Description = Provides rank constants for a Card class.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 7.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Deck of Cards</h2>
<p>Create a program that generates all cards of a card playing deck. First print the clubs, starting from the Ace, ending with a King. Continue with the same cards from Hearts, Diamonds and Spades. Print them in the format given below.</p>
<h3>Note</h3>
<p>Try using the enumeration types you have created in the previous problems.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Card Deck</p>
</td>
<td width="378">
<p>Ace of Clubs</p>
<p>Two of Clubs</p>
<p>Three of Clubs</p>
<p>Four of Clubs</p>
<p>Five of Clubs</p>
<p>...</p>
<p>...</p>
<p>King of Spades</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 8.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card Game</h2>
<p>Simulate a card game in which you have two players. Each player has a hand of five cards. The winning player is the player which holds the highest powered card in his hand.</p>
<p>Rank powers are as follows: (Ace - 14, Two - 2, Three - 3, Four - 4, Five - 5, Six - 6, Seven - 7, Eight - 8, Nine - 9, Ten - 10, Jack - 11, Queen - 12, King - 13).</p>
<p>Suit powers are as follows: (Clubs - 0, Diamonds - 13, Hearts - 26, Spades - 39).</p>
<h3>Input</h3>
<p>On the first two lines you will get the names of the players.</p>
<p>On the next lines, you should <strong>read cards</strong> from the console in the format <strong>{Ace of Clubs} </strong>for a certain player until he has <strong>exactly 5 cards in his hand</strong>. If he receives a card that is not in the deck, you should print "Card is not in the deck." If he receives an invalid card name, for example "spades of Ace", print "No such card exists."</p>
<h3>Output</h3>
<p>Print the name of the winner and his winning card in the format "{Player name} wins with {Card name}."</p>
<h3>Examples</h3>
<table width="701">
<tbody>
<tr>
<td width="170">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
<td width="285">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="170">
<p>Ivo</p>
<p>Gosho</p>
<p>Queen of Diamonds</p>
<p>King of Diamonds</p>
<p><strong>Ace of Hearts</strong></p>
<p>Ace of Hearts</p>
<p>spades of Ace</p>
<p>Two of Hearts</p>
<p>Three of Hearts</p>
<p>Four of Hearts</p>
<p>Five of Hearts</p>
<p>Six of Hearts</p>
<p>Seven of Hearts</p>
<p>Eight of Hearts</p>
</td>
<td width="246">
<p>Card is not in the deck.</p>
<p>No such card exists.</p>
<p>Ivo wins with Ace of Hearts.</p>
</td>
<td width="285">
<p>Player Ivo receives cards (in orange) from the deck, until he has exactly five of them.</p>
<p>When he is given ACE of HEARTS for a second time, error message is printed and his hand stays the same size.</p>
<p>When a card with invalid name is given, error message is printed and his hand stays the same size.</p>
<p>When Ivo's hand has 5 cards, Gosho starts receiving cards from the deck.</p>
<p>When Gosho has 5 cards, the hands are evaluated and one of the players wins.</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 9.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Traffic Lights</h2>
<p>Implement a simple state machine in the form of a traffic light. Every traffic light has three possible signals - red, green and yellow. Each traffic light can be updated, which changes the color of its signal (e.g. if it is currently red, it changes to green, if it is green it changes to yellow). The order of signals is red -&gt; green -&gt; yellow -&gt; red and so on.</p>
<p>On the first line you will be given multiple traffic light signals in the format "Red Green Yellow". You need to make as many traffic lights as there are signals in the input.</p>
<p>On the second line, you will receive the <strong>n</strong> number of times you need to change each traffic light's signal.</p>
<p>Your output should consist of <strong>n</strong> number of lines, including each updated traffic light's signal. To better understand the problem, see the example below.</p>
<h3>Examples</h3>
<table width="576">
<tbody>
<tr>
<td width="198">
<p><strong>Input</strong></p>
</td>
<td width="378">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="198">
<p>Green Red Yellow</p>
<p>4</p>
</td>
<td width="378">
<p>Yellow Green Red</p>
<p>Red Yellow Green</p>
<p>Green Red Yellow</p>
<p>Yellow Green Red</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 10. Create Custom Class Attribute</h2>
<p>Create a custom attribute that can be applied to classes and can be accessed at runtime. The attribute type elements it should contain are author, revision, description and reviewers. Apply the attribute to the Weapon class you have created for the Inferno Infinity problem. Provide these<strong> exact</strong> values:</p>
<ul>
<li>author = "Pesho"</li>
<li>revision = 3</li>
<li>description = "Used for C# OOP Advanced Course - Enumerations and Attributes."</li>
<li>reviewers = "Pesho", "Svetlio"</li>
</ul>
<p>Implement additional commands for extracting different annotation values:</p>
<ul>
<li>Author - prints the author of the class</li>
<li>Revision - prints the revision of the class</li>
<li>Description - prints the class description</li>
<li>Reviewers - prints the reviewers of the class</li>
</ul>
<h3>Examples</h3>
<table width="709">
<tbody>
<tr>
<td width="246">
<p><strong>Input</strong></p>
</td>
<td width="463">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="246">
<p>Author</p>
<p>Revision</p>
<p>Description</p>
<p>Reviewers</p>
<p>END</p>
</td>
<td width="463">
<p>Author: Pesho</p>
<p>Revision: 3</p>
<p>Class description: Used for C# OOP Advanced Course - Enumerations and Attributes.</p>
<p>Reviewers: Pesho, Svetlio</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 11. *Inferno Infinity</h2>
<p>If you've been involved with the creation of Inferno III last year, you may be informed of the disastrous critic reception it has received. Nevertheless, your company is determined to satisfy its fan base, so a sequel is coming and yeah, you will develop the crafting module of the game using the latest OOP trends.</p>
<p>You have three different weapons (Axe, Sword and Knife) which have base stats and a name. The base stats are min damage, max damage and number of sockets (sockets are basically holes, in which you can insert gems). Below are the base stats for the three weapon types:</p>
<ul>
<li>Axe (5-10 damage, 4 sockets)</li>
<li>Sword (4-6 damage, 3 sockets)</li>
<li>Knife (3-4 damage, 2 sockets)</li>
</ul>
<p>What&rsquo;s more, every weapon comes with a different level of rarity (how rare it is to come across such an item). Depending on its rarity, a weapon&rsquo;s maximum and minimum damage can be modified.</p>
<ul>
<li>Common (increases damage x1)</li>
<li>Uncommon (increases damage x2)</li>
<li>Rare (increases damage x3)</li>
<li>Epic (increases damage x5)</li>
</ul>
<p>So a Common Axe would have its damage modified in the following way: minimum damage = 5 *1, maximum damage = 10 *1. Whereas an Epic Axe would look like this: minimum damage = 5 * 5, maximum damage = 10 * 5.</p>
<p>Additionally, every weapon provides a bonus to three magical stats - strength, agility and vitality. At first the bonus of every magical stat is zero and can be increased with gems which are inserted into the weapon.</p>
<p>Every gem provides a bonus to all three of the magical stats. There are three different kind of gems:</p>
<ul>
<li>Ruby (+7 strength, +2 agility, +5 vitality)</li>
<li>Emerald (+1strength, +4 agility, +9 vitality)</li>
<li>Amethyst (+2 strength, +8 agility, +4 vitality)</li>
</ul>
<p>Every point of strength adds +2 to min damage and +3 to max damage. Every point of agility adds +1 to min damage and +4 to max damage. Vitality does not add damage.</p>
<p>Furthermore, every gem comes in different levels of clarity (basically level of quality). Depending on its level of clarity, a gem&rsquo;s stats can be modified in the following manner:</p>
<ul>
<li>Chipped (increases each stat by 1)</li>
<li>Regular (increases each stat by 2)</li>
<li>Perfect (increases each stat by 5)</li>
<li>Flawless (increases each stat by 10)</li>
</ul>
<p>So a Chipped Amethyst will have its stats modified like this: strength = 2 + 1, agility = 8 + 1, vitality = 4 + 1. Whilst a Perfect Emerald would look like this: strength = 1 + 5, agility = 4 + 5, vitality = 9 + 5.</p>
<p>Your job is to implement the functionality to read some weapons from the console and optionally to insert or remove gems at different socket indexes until you receive the END command.</p>
<p>Also, upon the <strong>Print</strong> command, in order to print correct final stats for a given weapon, first calculate the weapon&rsquo;s <strong>base stats </strong>taking into account <strong>its type and rarity</strong>. Afterwards, calculate the stats of each of its gems based on their <strong>clarity </strong>and finally add everything together. For the specific format of printing refer to the Output section.</p>
<h3>Note</h3>
<p>If you add gem on top of another, just overwrite it. If you add a gem to an invalid index, nothing happens. If you try to remove a gem from an empty socket or from invalid index, nothing happens. Upon receiving the END command print the weapons in order of their appearance in the format provided below.</p>
<h3>Input</h3>
<p>Each line consists of three types of commands in which the tokens are separated by ";".</p>
<p>Command types:</p>
<ul>
<li>Create;{weapon type};{weapon name}</li>
<li>Add;{weapon name};{socket index};{gem type}</li>
<li>Remove;{weapon name};{socket index}</li>
<li>Print;{weapon name}</li>
</ul>
<h3>Output</h3>
<p>Print weapons in the given format:</p>
<p>"{weapon's name}: {min damage}-{max damage} Damage, +{points} Strength, +{points} Agility, +{points} Vitality"</p>
<h3>Examples</h3>
<table width="709">
<tbody>
<tr>
<td width="321">
<p><strong>Input</strong></p>
</td>
<td width="387">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="321">
<p>Create;Common Axe;Axe of Misfortune</p>
<p>Add;Axe of Misfortune;0;Chipped Ruby</p>
<p>Print;Axe of Misfortune</p>
<p>END</p>
</td>
<td width="387">
<p>Axe of Misfortune: 24-46 Damage, +8 Strength, +3 Agility, +6 Vitality</p>
</td>
</tr>
<tr>
<td width="321">
<p>Create;Common Axe;Axe of Misfortune</p>
<p>Add;Axe of Misfortune;0;Flawless Ruby</p>
<p>Remove;Axe of Misfortune;0</p>
<p>Print;Axe of Misfortune</p>
<p>END</p>
</td>
<td width="387">
<p>Axe of Misfortune: 5-10 Damage, +0 Strength, +0 Agility, +0 Vitality</p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 12. **Refactoring - Bonus</h2>
<p>Refactor your Inferno Infinity problem code according to all HQC standards.</p>
<ul>
<li>Think about the proper naming of all your variables, methods, classes and interfaces.</li>
<li>Review all of your methods and make sure they are doing only one highly concrete thing.</li>
<li>Review your class hierarchy and make sure you have no duplicating code.</li>
<li>Consider making your classes less dependent of each other. If you have the <strong>new</strong> keyword anywhere inside the body of a non-factory or main class, think about how to remove it. Read about <a href="https://en.wikipedia.org/wiki/Dependency_injection"><strong>dependency injection</strong></a><strong>.</strong></li>
<li>Consider adding independent classes for reading input and writing output.</li>
<li>Create repository class that stores all weapon data.</li>
<li>Create an engine, weapon creator and so on. Try using design patterns like command and factory.</li>
<li>Make you classes <a href="https://en.wikipedia.org/wiki/Cohesion_(computer_science)"><strong>highly cohesive</strong></a> and <a href="https://en.wikipedia.org/wiki/Coupling_(computer_programming)"><strong>loosely coupled</strong></a>.</li>
</ul>