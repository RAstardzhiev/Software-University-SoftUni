<h1>Exercises: Objects, Associative Arrays, Maps, Sets</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/316/">https://judge.softuni.bg/Contests/316/</a>.</p>
<h2>1.&nbsp;&nbsp; &nbsp;Heroic Inventory</h2>
<p>In the era of heroes, every hero has his own items which make him unique. Create a function which creates a <strong>register for the heroes</strong>, with their <strong>names</strong>, <strong>level</strong>, and <strong>items</strong>, if they have such. The register should accept data in a specified format, and return it presented in a specified format.</p>
<p>The <strong>input</strong> comes as array of strings. Each element holds data for a hero, in the following format:</p>
<p>&ldquo;{heroName} / {heroLevel} / {item1}, {item2}, {item3}...&rdquo;</p>
<p>You must store the data about every hero. The <strong>name</strong> is a <strong>string</strong>, the <strong>level</strong> is a <strong>number </strong>and the items are all <strong>strings.</strong></p>
<p>The <strong>output</strong> is a <strong>JSON representation</strong> of the data for all the heroes you&rsquo;ve stored. The data must be an <strong>array of all the heroes</strong>. Check the examples for more info.</p>
<h3>Examples</h3>
<table width="713">
<tbody>
<tr>
<td width="354">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="354">
<p>Isacc / 25 / Apple, GravityGun</p>
<p>Derek / 12 / BarrelVest, DestructionSword</p>
<p>Hes / 1 / Desolator, Sentinel, Antara</p>
</td>
<td width="359">
<p>[{"name":"Isacc","level":25,"items":["Apple","GravityGun"]},{"name":"Derek","level":12,"items":["BarrelVest","DestructionSword"]},{"name":"Hes","level":1,"items":["Desolator","Sentinel","Antara"]}]</p>
</td>
</tr>
<tr>
<td width="354">
<p>&nbsp;</p>
</td>
<td width="359">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="354">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="354">
<p>Jake / 1000 / Gauss, HolidayGrenade</p>
</td>
<td width="359">
<p>[{"name":"Jake","level":1000,"items":["Gauss","HolidayGrenade"]}]</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>We need an array that will hold our hero data. That is the first thing we create.</li>
<li>Next, we need to loop over the whole input, and process it. Let&rsquo;s do that with a simple for</li>
<li>Every element from the input holds data about a hero, however the <strong>elements from the data</strong> we need are <strong>separated by some delimiter</strong>, so we just split each string with that <strong>delimiter</strong>.</li>
<li>Next, we need to take the elements from the <strong>string array</strong>, which is a result of the <strong>string split</strong>, and parse them.</li>
<li>However, if you do this, you could get quite the error in the current logic. If you go up and read the problem definition again, you will notice that there might be a <strong>case</strong> where the hero <strong>has</strong> <strong>no items</strong>; in that case, if we try to take the <strong>3<sup>rd</sup> element</strong> of the currentHeroArguments array, it will <strong>result in an error</strong>. That is why we need to perform a simple check.</li>
<li>If <strong>there are any items</strong> in the <strong>input</strong>, the <strong>variable</strong> will be set to the <strong>split version of them</strong>. If not, it will just remain an <strong>empty array</strong>, <strong>as it is supposed to</strong>.</li>
<li>We have now extracted the needed data &ndash; we have stored the <strong>input name</strong> in a <strong>variable</strong>, we have parsed the <strong>given level</strong> to a <strong>number</strong>, and we have also <strong>split</strong> the <strong>items</strong> that the <strong>hero holds</strong> by their <strong>delimiter</strong>, which would result in a <strong>string array</strong> of elements. By definition, the <strong>items</strong> are <strong>strings</strong>, so we don&rsquo;t need to process the array we&rsquo;ve made anymore.</li>
<li>Now what is left is to add that data into <strong>an object</strong> and <strong>add</strong> that object to the <strong>array</strong>.</li>
<li>Lastly, we need to turn the array of objects we have made, into a JSON string, which is done by the stringify() function</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2>2.&nbsp;&nbsp; JSON&rsquo;s Table</h2>
<p>JSON&rsquo;s Table is a magical table which turns JSON data into an HTML table. You will be given <strong>JSON strings</strong> holding data about employees, including their <strong>name</strong>, <strong>position</strong> and <strong>salary</strong>. You need to <strong>parse that data</strong> into <strong>objects</strong>, and create an <strong>HTML table</strong> which holds the data for each <strong>employee on a different row</strong>, as <strong>columns</strong>.</p>
<p>The <strong>name</strong> and <strong>position</strong> of the employee are <strong>strings</strong>, the <strong>salary</strong> is a <strong>number</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element is a JSON string which represents the data for a certain employee.</p>
<p>The <strong>output</strong> is the HTML code of a table which holds the data exactly as explained above. Check the examples for more info.</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="726">
<tbody>
<tr>
<td width="467">
<p><strong>Input</strong></p>
</td>
<td width="258">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="467">
<p>{"name":"Pesho","position":"Promenliva","salary":100000}</p>
<p>{"name":"Teo","position":"Lecturer","salary":1000}</p>
<p>{"name":"Georgi","position":"Lecturer","salary":1000}</p>
</td>
<td width="258">
<p>&lt;table&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;Pesho&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;Promenliva&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;100000&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;Teo&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;Lecturer&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;1000&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;Georgi&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;Lecturer&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;td&gt;1000&lt;/td&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;tr&gt;</p>
<p>&lt;/table&gt;</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>You might want to <strong>escape the HTML</strong>. Otherwise you might find yourself victim to vicious JavaScript <strong>code in the input</strong>, which aims only to hack you.</li>
</ul>
<h2>3.&nbsp;&nbsp; Cappy Juice</h2>
<p>You will be given different juices, as <strong>strings</strong>. You will also <strong>receive quantity</strong> as a <strong>number</strong>. If you receive a juice, you already have, <strong>you must sum</strong> the <strong>current quantity</strong> of that juice, with the <strong>given one</strong>. When a juice reaches <strong>1000 quantity</strong>, it produces a bottle. You must <strong>store all produced bottles</strong> and you must <strong>print them</strong> at the end.</p>
<p><strong>Note:</strong> <strong>1000 quantity</strong> of juice is <strong>one bottle</strong>. If you happen to have <strong>more than 1000</strong>, you must make <strong>as much bottles as you can</strong>, and store <strong>what</strong> <strong>is</strong> <strong>left</strong> from the juice.</p>
<p><strong>Example:</strong> <strong>You have 2643 quantity</strong> of Orange Juice &ndash; this is <strong>2 bottles</strong> of Orange Juice and <strong>643 quantity left</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element holds data about a juice and quantity in the following format:</p>
<p>&ldquo;{juiceName} =&gt; {juiceQuantity}&rdquo;</p>
<p>The <strong>output</strong> is the produced bottles. The bottles are to be printed in <strong>order of obtaining the bottles</strong>. Check the second example bellow - even though we receive the Kiwi juice first, we don&rsquo;t form a bottle of Kiwi juice until the 4<sup>th</sup> line, at which point we have already create Pear and Watermelon juice bottles, thus the Kiwi bottles appear last in the output.</p>
<h3>Examples</h3>
<table width="685">
<tbody>
<tr>
<td width="155">
<p><strong>Input</strong></p>
</td>
<td width="170">
<p><strong>Output</strong></p>
</td>
<td width="19">
<p><strong>&nbsp;</strong></p>
</td>
<td width="161">
<p><strong>Input</strong></p>
</td>
<td width="180">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Orange =&gt; 2000</p>
<p>Peach =&gt; 1432</p>
<p>Banana =&gt; 450</p>
<p>Peach =&gt; 600</p>
<p>Strawberry =&gt; 549</p>
</td>
<td width="170">
<p>Orange =&gt; 2</p>
<p>Peach =&gt; 2</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="161">
<p>Kiwi =&gt; 234</p>
<p>Pear =&gt; 2345</p>
<p>Watermelon =&gt; 3456</p>
<p>Kiwi =&gt; 4567</p>
<p>Pear =&gt; 5678</p>
<p>Watermelon =&gt; 6789</p>
</td>
<td width="180">
<p>Pear =&gt; 8</p>
<p>Watermelon =&gt; 10</p>
<p>Kiwi =&gt; 4</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>4.&nbsp;&nbsp; Store Catalogue</h2>
<p>You have to create a sorted catalogue of store products. You will be given the products&rsquo; names and prices. You need to order them by <strong>alphabetical order</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element holds info about a product in the following format:</p>
<p>&ldquo;{productName} : {productPrice}&rdquo;</p>
<p>The <strong>product&rsquo;s name</strong> will be a <strong>string</strong>, which will <strong>always</strong> <strong>start with a capital letter</strong>, and the <strong>price</strong> will be <strong>a number</strong>. You can safely assume there will be <strong>NO duplicate product input</strong>. The comparison for alphabetical order is <strong>case-insensitive</strong>.</p>
<p>As <strong>output</strong> you must print all the products in a specified format. They must be ordered <strong>exactly as specified above</strong>. The products must be <strong>divided into groups</strong>, by the <strong>initial of their name</strong>. The <strong>group&rsquo;s initial should be printed</strong>, and after that the products should be printed with <strong>2 spaces before their names</strong>. For more info check the examples.</p>
<h3>Examples</h3>
<table width="722">
<tbody>
<tr>
<td width="165">
<p><strong>Input</strong></p>
</td>
<td width="180">
<p><strong>Output</strong></p>
</td>
<td width="19">
<p><strong>&nbsp;</strong></p>
</td>
<td width="161">
<p><strong>Input</strong></p>
</td>
<td width="198">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="165">
<p>Appricot : 20.4</p>
<p>Fridge : 1500</p>
<p>TV : 1499</p>
<p>Deodorant : 10</p>
<p>Boiler : 300</p>
<p>Apple : 1.25</p>
<p>Anti-Bug Spray : 15</p>
<p>T-Shirt : 10</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
<td width="180">
<p>A</p>
<p>&nbsp; Anti-Bug Spray: 15</p>
<p>&nbsp; Apple: 1.25</p>
<p>&nbsp; Appricot: 20.4</p>
<p>B</p>
<p>&nbsp; Boiler: 300</p>
<p>D</p>
<p>&nbsp; Deodorant: 10</p>
<p>F</p>
<p>&nbsp; Fridge: 1500</p>
<p>T</p>
<p>&nbsp; T-Shirt: 10</p>
<p>&nbsp; TV: 1499</p>
</td>
<td width="19">
<p>&nbsp;</p>
</td>
<td width="161">
<p>Banana : 2</p>
<p>Rubic's Cube : 5</p>
<p>Raspberry P : 4999</p>
<p>Rolex : 100000</p>
<p>Rollon : 10</p>
<p>Rali Car : 2000000</p>
<p>Pesho : 0.000001</p>
<p>Barrel : 10</p>
</td>
<td width="198">
<p>B</p>
<p>&nbsp; Banana: 2</p>
<p>&nbsp; Barrel: 10</p>
<p>P</p>
<p>&nbsp; Pesho: 0.000001</p>
<p>R</p>
<p>&nbsp; Rali Car: 2000000</p>
<p>&nbsp; Raspberry P: 4999</p>
<p>&nbsp; Rolex: 100000</p>
<p>&nbsp; Rollon: 10</p>
<p>&nbsp; Rubic's Cube: 5</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Auto-Engineering Company</h2>
<p>You are tasked to create a register for a company that produces cars. You need to store <strong>how many cars</strong> have been produced from a <strong>specified model</strong> of a <strong>specified brand</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element holds information in the following format:</p>
<p>&ldquo;{carBrand} | {carModel} | {producedCars}&rdquo;</p>
<p>The car <strong>brands</strong> and <strong>models</strong> are <strong>strings</strong>, the <strong>produced cars</strong> are <strong>numbers</strong>. If the <strong>car brand</strong> you&rsquo;ve received <strong>already exists</strong>, just add the <strong>new</strong> <strong>car model</strong> to it with the <strong>produced cars</strong> <strong>as its value</strong>. If even the car model exists, just <strong>add</strong> the <strong>given value</strong> to the <strong>current one</strong>.</p>
<p>As <strong>output</strong> you need to print &ndash; <strong>for every car brand</strong>, the <strong>car models</strong>, and <strong>number of cars produced</strong> from that model. The output format is:</p>
<p>&ldquo;{carBrand}</p>
<p>&nbsp; ###{carModel} -&gt; {producedCars}</p>
<p>&nbsp; ###{carModel2} -&gt; {producedCars}</p>
<p>&nbsp; ...&rdquo;</p>
<p>The order of printing is the order in which the brands and models first appear in the input. The first brand in the input should be the first printed and so on. For each brand, the first model received from that brand, should be the first printed and so on.</p>
<h3>Examples</h3>
<table width="618">
<tbody>
<tr>
<td width="316">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="316">
<p>Audi | Q7 | 1000</p>
<p>Audi | Q6 | 100</p>
<p>BMW | X5 | 1000</p>
<p>BMW | X6 | 100</p>
<p>Citroen | C4 | 123</p>
<p>Volga | GAZ-24 | 1000000</p>
<p>Lada | Niva | 1000000</p>
<p>Lada | Jigula | 1000000</p>
<p>Citroen | C4 | 22</p>
<p>Citroen | C5 | 10</p>
</td>
<td width="302">
<p>Audi</p>
<p>###Q7 -&gt; 1000</p>
<p>###Q6 -&gt; 100</p>
<p>BMW</p>
<p>###X5 -&gt; 1000</p>
<p>###X6 -&gt; 100</p>
<p>Citroen</p>
<p>###C4 -&gt; 145</p>
<p>###C5 -&gt; 10</p>
<p>Volga</p>
<p>###GAZ-24 -&gt; 1000000</p>
<p>Lada</p>
<p>###Niva -&gt; 1000000</p>
<p>###Jigula -&gt; 1000000</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>The <strong>Map structure</strong> should be perfect for this problem.</li>
</ul>
<h2>6.&nbsp;&nbsp; System Components</h2>
<p>You will be given a register of systems with components and subcomponents. You need to build an ordered database of all the elements that have been given to you.</p>
<p>The elements are registered in a very simple way. When you have processed all of the input data, you must print them in a specific order. For every System you must print its components in a specified order, and for every Component, you must print its Subcomponents in a specified order.</p>
<p>The <strong>Systems</strong> you&rsquo;ve stored must be ordered by <strong>amount of components</strong>, in <strong>descending order</strong>, as <strong>first criteria</strong>, and by <strong>alphabetical order</strong> as <strong>second criteria</strong>. The <strong>Components</strong> must be ordered by <strong>amount of Subcomponents</strong>, in <strong>descending order</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element holds <strong>data</strong> about a <strong>system</strong>, a <strong>component</strong> in that <strong>system</strong>, and a <strong>subcomponent</strong> in that <strong>component</strong>. If the given <strong>system already exists</strong>, you should just <strong>add the new component</strong> to it. If even the <strong>component exists</strong>, you should just <strong>add</strong> the <strong>new subcomponent</strong> to it. The <strong>subcomponents</strong> will <strong>always be</strong> <strong>unique</strong>. The input format is:</p>
<p>&ldquo;{systemName} | {componentName} | {subcomponentName}&rdquo;</p>
<p>All of the elements are strings, and can contain <strong>any ASCII character</strong>. The <strong>string comparison</strong> for the alphabetical order is <strong>case-insensitive</strong>.</p>
<p>As <strong>output</strong> you need to print all of the elements, ordered exactly in the way specified above. The format is:</p>
<p>&ldquo;{systemName}</p>
<p>&nbsp;|||{componentName}</p>
<p>&nbsp;|||{component2Name}</p>
<p>&nbsp;||||||{subcomponentName}</p>
<p>&nbsp;||||||{subcomponent2Name}</p>
<p>&nbsp;{system2Name}</p>
<p>&nbsp;...&rdquo;</p>
<h3>Examples</h3>
<table width="666">
<tbody>
<tr>
<td width="325">
<p><strong>Input</strong></p>
</td>
<td width="340">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="325">
<p>SULS | Main Site | Home Page<br /> SULS | Main Site | Login Page<br /> SULS | Main Site | Register Page<br /> SULS | Judge Site | Login Page<br /> SULS | Judge Site | Submittion Page<br /> Lambda | CoreA | A23<br /> SULS | Digital Site | Login Page<br /> Lambda | CoreB | B24<br /> Lambda | CoreA | A24<br /> Lambda | CoreA | A25<br /> Lambda | CoreC | C4<br /> Indice | Session | Default Storage<br /> Indice | Session | Default Security</p>
</td>
<td width="340">
<p>Lambda<br /> |||CoreA<br /> ||||||A23<br /> ||||||A24<br /> ||||||A25<br /> |||CoreB<br /> ||||||B24<br /> |||CoreC<br /> ||||||C4<br /> SULS<br /> |||Main Site<br /> ||||||Home Page<br /> ||||||Login Page<br /> ||||||Register Page<br /> |||Judge Site<br /> ||||||Login Page<br /> ||||||Submittion Page</p>
<p>|||Digital Site</p>
<p>||||||Login Page<br /> Indice</p>
<p>|||Session</p>
<p>||||||Default Storage</p>
<p>||||||Default Security</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Creating a sorting function with two criteria might seem a bit daunting at first, but it can be simplified to the following:
<ul>
<li>If elements <strong>a</strong> and <strong>b</strong> are different based on the <strong>first criteria</strong>, then that result is the result of the sorting function, checking the second criteria is not required.</li>
<li>If elements <strong>a</strong> and <strong>b</strong> are <strong>equal</strong> based on the <strong>first criteria</strong>, then the result of comparing <strong>a</strong> and <strong>b</strong> on the <strong>second criteria</strong> is the result of the sorting.</li>
</ul>
</li>
</ul>
<h2>7.&nbsp;&nbsp; Usernames</h2>
<p>You are tasked to create a catalogue of usernames. The usernames will be strings that <strong>may contain any ASCII</strong> character. You <strong>need to order</strong> them <strong>by their length</strong>, in <strong>ascending order</strong>, as <strong>first criteria</strong>, and by <strong>alphabetical order</strong> as <strong>second criteria</strong>.</p>
<p>The <strong>input</strong> comes as array of strings. Each element represents a <strong>username</strong>. Sometimes the input may contain <strong>duplicate usernames</strong>. Make it so that there are <strong>NO duplicates</strong> in the output.</p>
<p>The <strong>output</strong> is all of the usernames, <strong>ordered </strong>exactly as <strong>specified above</strong> &ndash; each printed on a new line.</p>
<h3>Examples</h3>
<table width="703">
<tbody>
<tr>
<td width="165">
<p><strong>Input</strong></p>
</td>
<td width="176">
<p><strong>Output</strong></p>
</td>
<td width="13">
<p><strong>&nbsp;</strong></p>
</td>
<td width="170">
<p><strong>Input</strong></p>
</td>
<td width="180">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="165">
<p>Ashton<br /> Kutcher<br /> Ariel<br /> Lilly<br /> Keyden<br /> Aizen<br /> Billy<br /> Braston</p>
</td>
<td width="176">
<p>Aizen<br /> Ariel<br /> Billy<br /> Lilly<br /> Ashton<br /> Keyden<br /> Braston<br /> Kutcher</p>
</td>
<td width="13">
<p>&nbsp;</p>
</td>
<td width="170">
<p>Denise<br /> Ignatius<br /> Iris<br /> Isacc<br /> Indie<br /> Dean<br /> Donatello<br /> Enfuego<br /> Benjamin<br /> Biser<br /> Bounty<br /> Renard<br /> Rot</p>
</td>
<td width="180">
<p>Rot<br /> Dean<br /> Iris<br /> Biser<br /> Indie<br /> Isacc<br /> Bounty<br /> Denise<br /> Renard<br /> Enfuego<br /> Benjamin<br /> Ignatius<br /> Donatello</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Try to find a <strong>structure</strong> which <strong>does NOT allow duplicates</strong>, it will be best for the current problem.</li>
</ul>
<h2>8.&nbsp;&nbsp; *Unique Sequences</h2>
<p>You are tasked with storing sequences of numbers. You will receive an unknown amount of <strong>arrays containing numbers</strong> from which you must store only the <strong>unique</strong> arrays (duplicate arrays should be discarded). An array is considered the <strong>same</strong> (<strong>NOT unique</strong>) if it contains the <strong>same numbers </strong>as another array<strong>, regardless of their order</strong>.</p>
<p>After storing all arrays, your program should print them back in <strong>ascending</strong> order based on their <strong>length</strong>, if two arrays have the same length they should be printed in <strong>order of being received from the input</strong>. Each individual array should be printed in <strong>descending order </strong>in the format <strong>"[a<sub>1</sub>, a<sub>2</sub>, a<sub>3</sub>,&hellip; a<sub>n</sub>]"</strong>. Check the examples bellow.</p>
<p>The <strong>input</strong> comes as an array of strings where each entry is a JSON representing an array of numbers.</p>
<p>The <strong>output</strong> should be printed on the console - each array printed on a new line in the format <strong>"[a<sub>1</sub>, a<sub>2</sub>, a<sub>3</sub>,&hellip; a<sub>n</sub>]"</strong> , following the above mentioned ordering.</p>
<h3>Examples</h3>
<table width="713">
<tbody>
<tr>
<td width="354">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="354">
<p>[-3, -2, -1, 0, 1, 2, 3, 4]</p>
<p>[10, 1, -17, 0, 2, 13]</p>
<p>[4, -3, 3, -2, 2, -1, 1, 0]</p>
</td>
<td width="359">
<p>[13, 10, 2, 1, 0, -17]</p>
<p>[4, 3, 2, 1, 0, -1, -2, -3]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="713">
<tbody>
<tr>
<td width="354">
<p><strong>Input</strong></p>
</td>
<td width="359">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="354">
<p>[7.14, 7.180, 7.339, 80.099]</p>
<p>[7.339, 80.0990, 7.140000, 7.18]</p>
<p>[7.339, 7.180, 7.14, 80.099]</p>
</td>
<td width="359">
<p>[80.099, 7.339, 7.18, 7.14]</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<ul>
<li>Think of an easy way to compare arrays.</li>
<li>Sometimes the most obvious collection choice is not the best one.</li>
</ul>
<p>&nbsp;</p>