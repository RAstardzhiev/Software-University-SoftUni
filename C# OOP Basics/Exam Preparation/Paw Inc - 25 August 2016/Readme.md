<h1>C# / Java OOP Basics Retake Exam &ndash; Paw Inc.</h1>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>Paw Incorporative is a large corporation that has the grand mission to rescue all street dogs and cats, shelter them, and possibly find a family to adopt them. You have been tasked to create a software program that oversees the operations of Paw Inc.</p>
<h3>Overview</h3>
<p>Paw Inc. has two main types of centers &ndash; Cleansing centers and Adoption centers.</p>
<p>The Cleansing centers&rsquo; main function is to cleanse the animals of all types of dirt, deceases, or any parasites on them, so that they can be suitable for adoption.</p>
<p>The Adoption centers&rsquo; main function is to provide the functionality of adopting an <strong>already cleansed</strong> animal.</p>
<p>The animals are first registered in the Adoption centers. However, they can ONLY be adopted if they are first cleansed.</p>
<p>Upon receiving the command, a particular Adoption center sends all of its stored animals to a particular Cleansing center.</p>
<p>Upon receiving the command, a particular Cleansing center cleanses all of its stored animals, and returns each stored animal to the Adoption center it received it from.</p>
<p>Paw Inc. works with two types of animals &ndash; dogs and cats.</p>
<p>Dogs are not quite smart, but they are loyal, so they have a particular amount of commands they have learned.<br /> Cats are quite intelligent, so they have an estimated intelligence coefficient.</p>
<h3>Task 1: Implementing the class structure &amp; hierarchy</h3>
<p>You need to implement the needed class structure for the components of Paw Inc.</p>
<p><strong>The Centers:</strong></p>
<ul>
<li><strong>Cleansing Center</strong> &ndash; has a <strong>name</strong> and <strong>stored animals</strong>. Provides functionality for cleansing animals.
<ul>
<li>The name will be a string, which could consist of <strong>any ASCII character</strong>.</li>
<li>The stored animals can be many and can be both <strong>dogs</strong> and <strong>cats</strong>.</li>
<li>Upon receiving the cleansing command, it cleanses <strong>all of the stored animals</strong> it has, and <strong>returns each</strong> to the <strong>Adoption center it received it from</strong>.</li>
</ul>
</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<ul>
<li><strong>Adoption Center</strong> &ndash; has a name and stored animals. Provides functionality for sending animals for cleansing and adopting animals.
<ul>
<li>The name will be a string, which could consist of <strong>any ASCII character</strong>.</li>
<li>The stored animals can be many and can be both <strong>dogs</strong> and <strong>cats</strong>.</li>
<li>Upon receiving the send for cleanse command, it sends <strong>all of its stored animals</strong> to the specified <strong>Cleansing center</strong>, so that they can be cleansed.</li>
<li>Upon receiving the adoption command, <strong>all of the cleansed animals</strong>, <strong>currently </strong>in the <strong>adoption center</strong>, get <strong>adopted</strong> and <strong>removed</strong> from the stored animals.</li>
</ul>
</li>
</ul>
<p>&nbsp;</p>
<p><strong>The Animals:</strong></p>
<ul>
<li><strong>Dog</strong> &ndash; has a <strong>name</strong>, <strong>age</strong>, <strong>cleansing status</strong> and <strong>amount of commands</strong> it has learned.
<ul>
<li>The name of the dog is a string, which can consist of <strong>any ASCII character</strong>.</li>
<li>The age of the dog is an <strong>integer</strong>.</li>
<li>The amount of commands of the dog is an <strong>integer</strong>.</li>
</ul>
</li>
<li><strong>Cat</strong> &ndash; has a <strong>name</strong>, <strong>age</strong>, <strong>cleansing status</strong> and <strong>intelligence coefficient</strong>.
<ul>
<li>The name of the cat is a string, which can consist of <strong>any ASCII character</strong>.</li>
<li>The age of the cat is an <strong>integer</strong>.</li>
<li>The intelligence coefficient of the cat is an <strong>integer</strong>.</li>
</ul>
</li>
</ul>
<p>By default, all animals are <strong>UNCLEANSED </strong>upon registration.</p>
<h3>Task 2: Implementing the main functionality &amp; application logic</h3>
<p>The functionality of Paw Inc. is interpreted through commands. There are several commands you need to have in mind.</p>
<h3>Commands</h3>
<ul>
<li><strong>RegisterCleansingCenter | {name}</strong>
<ul>
<li>Registers <strong>a Cleansing center</strong> with the <strong>given</strong> <strong>name</strong>.</li>
</ul>
</li>
<li><strong>RegisterAdoptionCenter | {name}</strong>
<ul>
<li>Registers an <strong>Adoption center</strong> with the <strong>given</strong> <strong>name</strong>.</li>
</ul>
</li>
<li><strong>RegisterDog | {name} | {age} | {learnedCommands} | {adoptionCenterName}</strong>
<ul>
<li>Registers a dog with the <strong>given name</strong>, <strong>age</strong> and <strong>amount</strong> <strong>of learned commands</strong> in the <strong>given Adoption cente</strong></li>
</ul>
</li>
<li><strong>RegisterCat | {name} | {age| | {intelligenceCoefficient} | {adoptionCenterName}</strong>
<ul>
<li>Registers a cat with the <strong>given name</strong>, <strong>age</strong> and <strong>intelligence coefficient</strong> in the <strong>given Adoption center</strong>.</li>
</ul>
</li>
<li><strong>SendForCleansing | {adoptionCenterName} | {cleansingCenterName}</strong>
<ul>
<li>Sends <strong>all UNCLEANSED </strong>animals from the <strong>given Adoption center</strong> to the <strong>given Cleansing center</strong>.</li>
</ul>
</li>
<li><strong>Cleanse | {cleansingCenterName}</strong>
<ul>
<li>Cleanses <strong>all animals</strong> from the <strong>given Cleansing center</strong> and <strong>returns</strong> them to their <strong>corresponding Adoption centers</strong>.</li>
</ul>
</li>
<li><strong>Adopt | {adoptionCenterName}</strong>
<ul>
<li><strong>All CLEANSED</strong> animals from the <strong>given Adoption center</strong> get <strong>adopted</strong>, and <strong>removed</strong> from the stored animals.</li>
</ul>
</li>
<li><strong>Paw Paw Pawah</strong>
<ul>
<li>This command <strong>terminates</strong> the input sequence.</li>
</ul>
</li>
</ul>
<p>You can safely assume that there will <strong>be</strong> <strong>NO invalid</strong> input commands. There will <strong>be NO duplicate names</strong> for the Cleansing and Adoption centers. There will <strong>be NO</strong> <strong>nonexistent</strong> centers in the commands.</p>
<h3>Task 3: Encapsulating the data</h3>
<p>Make sure no data is revealed completely, unless it is absolutely needed for it to be. Make sure you hide all data and also make sure that the input data follows the rules, specified in <strong>Task 1</strong>.</p>
<h3>Task 4 (Final): Presenting the Output</h3>
<p><strong>No output</strong> should be printed as the <strong>result of executing commands</strong>.<br /> The only output you should print is when you receive the input sequence &ndash; terminating command. Then you should print the following:</p>
<p>&ldquo;<strong>Paw Incorporative Regular Statistics<br /> &nbsp; Adoption Centers: {amountOfAdoptionCenters}<br /> &nbsp; Cleansing Centers: {amountOfCleansingCenters}<br /> &nbsp; Adopted Animals: {adoptedAnimal1Name}, {adoptedAnimal2Name}&hellip;<br /> &nbsp; Cleansed Animals: {cleansedAnimal1Name}, {cleansedAnimal2Name}&hellip;<br /> &nbsp; Animals Awaiting Adoption: {amountOfAnimalsWaitingForAdoption}<br /> &nbsp; Animals Awaiting Cleansing: {amountOfAnimalsWaitingForCleansing}</strong>&rdquo;</p>
<p>You need to present the count of all registered Adoption and Cleansing centers.<br /> You need to show all animals, that were adopted, in <strong>alphabetical order</strong>.<br /> You need to show all animals, that were cleansed, in <strong>alphabetical order</strong>.<br /> The comparison is <strong>case-sensitive</strong>.<br /> In case of no such animals, just print <strong>&ldquo;None&rdquo;</strong>.<br /> You need to show the amount of all <strong>CLEANSED </strong>animals, waiting to be adopted in the <strong>Adoption centers</strong>.<br /> You need to show the amount of all <strong>UNCLEANSED </strong>animals, waiting to be cleansed in the <strong>Cleansing centers</strong>.</p>
<p><strong>Note:</strong> For the uncleansed animals, you need to print the count of only those, that are in the <strong>Cleansing centers</strong>.</p>
<h3>Input</h3>
<ul>
<li>The input will come in the form of commands, in the format specified above.</li>
<li>The input sequence ends when the command <strong>&ldquo;Paw Paw Pawah&rdquo;</strong> is received.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The <strong>only</strong> output you need to print is <strong>the final one</strong>, when the input sequence ends.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li>The names of the centers and the animals can consist of any ASCII characters.</li>
<li>The input age of the animals will be a valid integer in range [0, 2<sup>31</sup> &ndash; 1].</li>
<li>The input amount of learned commands for the dogs will be a valid integer in range [0, 2<sup>31</sup> &ndash; 1].</li>
<li>The input intelligence coefficient for the cats will be a valid integer in range [0, 2<sup>31</sup> &ndash; 1].</li>
<li>You can safely assume that all commands will follow the format specified above.</li>
<li>You can safely assume there will be <strong>NO duplicate names</strong> for the centers or the animals.</li>
<li>Allowed time/memory: 250ms/16MB.</li>
</ul>
<h3>Examples</h3>
<table width="698">
<tbody>
<tr>
<td width="387">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="312">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="387">
<p><strong>RegisterAdoptionCenter | Destiny</strong></p>
<p><strong>RegisterCleansingCenter | Hope</strong></p>
<p><strong>RegisterDog | Sharo | 5 | 20 | Destiny</strong></p>
<p><strong>RegisterCat | Argent | 1 | 200 | Destiny</strong></p>
<p><strong>SendForCleansing | Destiny | Hope</strong></p>
<p><strong>Cleanse | Hope</strong></p>
<p><strong>Adopt | Destiny</strong></p>
<p><strong>RegisterAdoptionCenter | Wisdom</strong></p>
<p><strong>RegisterDog | Rex | 12 | 100 | Wisdom</strong></p>
<p><strong>RegisterDog | Bolt | 2 | 100 | Wisdom</strong></p>
<p><strong>SendForCleansing | Wisdom | Hope</strong></p>
<p><strong>Paw Paw Pawah</strong></p>
</td>
<td width="312">
<p><strong>Paw Incorporative Regular Statistics</strong></p>
<p><strong>Adoption Centers: </strong><strong>2</strong></p>
<p><strong>Cleansing Centers: 1</strong></p>
<p><strong>Adopted Animals: Argent, Sharo</strong></p>
<p><strong>Cleansed Animals: Argent, Sharo</strong></p>
<p><strong>Animals Awaiting Adoption: 0</strong></p>
<p><strong>Animals Awaiting Cleansing: </strong><strong>2</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<table width="698">
<tbody>
<tr>
<td width="387">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="312">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="387">
<p><strong>RegisterAdoptionCenter | Rebellion</strong></p>
<p><strong>RegisterAdoptionCenter | Sentinel</strong></p>
<p><strong>RegisterCleansingCenter | Sanctuary</strong></p>
<p><strong>RegisterCleansingCenter | Liberty</strong></p>
<p><strong>RegisterCat | Mr.Whiskas | 1 | 1 | Sentinel</strong></p>
<p><strong>RegisterCat | Gosho | 20 | 100 | Rebellion</strong></p>
<p><strong>RegisterCat | Chukky | 10 | 10 | Rebellion</strong></p>
<p><strong>Adopt | Sentinel</strong></p>
<p><strong>RegisterDog | Sirius | 5 | 1000 | Rebellion</strong></p>
<p><strong>SendForCleansing | Sentinel | Sanctuary</strong></p>
<p><strong>SendForCleansing | Rebellion | Sanctuary</strong></p>
<p><strong>Cleanse | Sanctuary</strong></p>
<p><strong>Adopt | Rebellion</strong></p>
<p><strong>RegisterDog | Husku | 1 | 20 | Sentinel</strong></p>
<p><strong>SendForCleansing | Sentinel | Liberty</strong></p>
<p><strong>RegisterCat | Nero | 1 | 120 | Sentinel</strong></p>
<p><strong>Paw Paw Pawah</strong></p>
</td>
<td width="312">
<p><strong>Paw Incorporative Regular Statistics</strong></p>
<p><strong>Adoption Centers: 2</strong></p>
<p><strong>Cleansing Centers: 2</strong></p>
<p><strong>Adopted Animals: Chukky, Gosho, Sirius</strong></p>
<p><strong>Cleansed Animals: Chukky, Gosho, Mr.Whiskas, Sirius</strong></p>
<p><strong>Animals Awaiting Adoption: 1</strong></p>
<p><strong>Animals Awaiting Cleansing: 1</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Bonus Task: Castration Center</h3>
<p>Paw Inc. has given you a bonus task, in case you manage to finish the other things quickly. The bonus task includes the implementation of a third type of centers, called &ndash; Castration centers.</p>
<p><strong>Structure</strong></p>
<ul>
<li><strong>Castration Center</strong> &ndash; has a <strong>name</strong> and <strong>stored animals</strong>. Provides functionality for castrating animals.
<ul>
<li>The name will be a <strong>string</strong>, which could consist of <strong>any ASCII character</strong>.</li>
<li>The stored animals can be many and can be both <strong>dogs</strong> and <strong>cats</strong>.</li>
<li>Upon receiving the castration command, it castrates <strong>all of the stored animals it has</strong>, and returns each <strong>to the Adoption center</strong> it <strong>received it from</strong>.</li>
</ul>
</li>
</ul>
<p><strong>Functionality</strong></p>
<ul>
<li><strong>RegisterCastrationCenter | {name}</strong>
<ul>
<li>Registers <strong>a Castration center</strong> with the <strong>given</strong> <strong>name</strong>.</li>
</ul>
</li>
<li><strong>SendForCastration | {adoptionCenterName} | {castrationCenterName}</strong>
<ul>
<li>Sends <strong>all </strong>animals from the <strong>given Adoption center</strong> to the <strong>given Castration center</strong>.</li>
</ul>
</li>
<li><strong>Castrate | {castrationCenterName}</strong>
<ul>
<li>Castrates <strong>all animals</strong> from the <strong>given Castration center</strong> and <strong>returns</strong> them to their <strong>corresponding Adoption centers</strong>.</li>
</ul>
</li>
<li><strong>CastrationStatistics</strong>
<ul>
<li>Prints statistics about all the animals that have been castrated.</li>
<li>The format is:</li>
</ul>
</li>
</ul>
<p><strong>&ldquo;Paw Inc. Regular Castration Statistics</strong></p>
<p><strong>&nbsp; Castration Centers: {amountOfCastrationCenters}</strong></p>
<p><strong>&nbsp; Castrated Animals: {castratedAnimal1Name}, {castratedAnimal2Name}&hellip;&rdquo;</strong></p>
<p><strong>&nbsp;</strong></p>
<p>The animals must be presented in <strong>alphabetical order</strong>. The comparison is <strong>case-sensitive</strong>.<br /> In case of no such animals, just print <strong>&ldquo;None&rdquo;.</strong></p>
<h3>Bonus Example</h3>
<table width="708">
<tbody>
<tr>
<td width="387">
<p><strong><strong>Input</strong></strong></p>
</td>
<td width="321">
<p><strong><strong>Output</strong></strong></p>
</td>
</tr>
<tr>
<td width="387">
<p><strong>RegisterAdoptionCenter | Destiny</strong></p>
<p><strong>RegisterCleansingCenter | Hope</strong></p>
<p><strong>RegisterCastrationCenter | Razor</strong></p>
<p><strong>RegisterCat | Stacy | 1 | 100 | Destiny</strong></p>
<p><strong>RegisterCat | Sindy | 1 | 110 | Destiny</strong></p>
<p><strong>SendForCastration | Destiny | Razor</strong></p>
<p><strong>Castrate | Razor</strong></p>
<p><strong>CastrationStatistics</strong></p>
<p><strong>SendForCleansing | Destiny | Hope</strong></p>
<p><strong>Paw Paw Pawah</strong></p>
</td>
<td width="321">
<p><strong>Paw Inc. Regular Castration Statistics</strong></p>
<p><strong>Castration Centers: 1</strong></p>
<p><strong>Castrated Animals: Sindy, Stacy</strong></p>
<p><strong>Paw Incorporative Regular Statistics</strong></p>
<p><strong>Adoption Centers: 1</strong></p>
<p><strong>Cleansing Centers: 1</strong></p>
<p><strong>Adopted Animals: None</strong></p>
<p><strong>Cleansed Animals: None</strong></p>
<p><strong>Animals Awaiting Adoption: 0</strong></p>
<p><strong>Animals Awaiting Cleansing: 2</strong></p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>