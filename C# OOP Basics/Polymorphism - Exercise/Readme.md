<h1>Exercises: Polymorphism</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/trainings/1636/c-sharp-oop-basics-june-2017">"C# OOP Basics" course @ Software University</a>. Please submit your solutions (source code) of all below described problems in <a href="https://judge.softuni.bg/Contests/241/Polymorphism-Exercise">Judge</a>.</p>
<h2>Problem 1.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vehicles</h2>
<p>Write a program that models 2 vehicles (<strong>Car</strong> and <strong>Truck</strong>) and will be able to simulate <strong>driving</strong> and <strong>refueling </strong>them. <strong>Car</strong> and <strong>truck</strong> both have <strong>fuel quantity</strong>, <strong>fuel consumption</strong> <strong>in liters</strong> <strong>per km</strong> and can be <strong>driven given distance</strong> and <strong>refueled with given liters.</strong> But in the summer both vehicles use air conditioner and their <strong>fuel consumption</strong> per km is <strong>increased</strong> by <strong>0.9</strong> liters for the <strong>car</strong> and with <strong>1.6</strong> liters for the <strong>truck</strong>. Also the <strong>truck</strong> has a tiny hole in his tank and when it gets <strong>refueled</strong> it gets only <strong>95%</strong> of given <strong>fuel</strong>. The <strong>car</strong> has no problems when refueling and adds <strong>all given fuel to its tank. </strong>If vehicle cannot travel given distance its fuel <strong>does not change.</strong></p>
<p>Input</p>
<ul>
<li>On the first line - information about the car in format {Car {fuel quantity} {liters per km}}</li>
<li>On the second line &ndash; info about the truck in format {Truck {fuel quantity} {liters per km}}</li>
<li>On the third line - number of commands N that will be given on the next N lines</li>
<li>On the next N lines &ndash; commands in format</li>
<li>Drive Car {distance}</li>
<li>Drive Truck {distance}</li>
<li>Refuel Car {liters}</li>
<li>Refuel Truck {liters}</li>
</ul>
<p>Output</p>
<p>After each Drive command print whether the Car/Truck was able to travel the given distance in the formats below. If it&rsquo;s successful:</p>
<p>Car/Truck travelled {distance} km</p>
<p>Or if it is not:</p>
<p>Car/Truck needs refueling</p>
<p>Finally print the remaining fuel for both car and truck rounded to 2 digits after the floating point in format:</p>
<p>Car: {liters}</p>
<p>Truck: {liters}</p>
<h3>Examples</h3>
<table width="474">
<tbody>
<tr>
<td width="222">
<p><strong>Input</strong></p>
</td>
<td width="252">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="222">
<p>Car 15 0.3</p>
<p>Truck 100 0.9</p>
<p>4</p>
<p>Drive Car 9</p>
<p>Drive Car 30</p>
<p>Refuel Car 50</p>
<p>Drive Truck 10</p>
</td>
<td width="252">
<p>Car travelled 9 km</p>
<p>Car needs refueling</p>
<p>Truck travelled 10 km</p>
<p>Car: 54.20</p>
<p>Truck: 75.00</p>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="222">
<p>Car 30.4 0.4</p>
<p>Truck 99.34 0.9</p>
<p>5</p>
<p>Drive Car 500</p>
<p>Drive Car 13.5</p>
<p>Refuel Truck 10.300</p>
<p>Drive Truck 56.2</p>
<p>Refuel Car 100.2</p>
</td>
<td width="252">
<p>Car needs refueling</p>
<p>Car travelled 13.5 km</p>
<p>Truck needs refueling</p>
<p>Car: 113.05</p>
<p>Truck: 109.13</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 2.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Vehicles Extension</h2>
<p>Use your solution of the previous task for starting point and add more functionality. Add new vehicle &ndash; <strong>Bus</strong>. Now every vehicle has <strong>tank capacity</strong> and fuel quantity <strong>cannot fall</strong> <strong>below 0 </strong>(If fuel quantity become less than 0 <strong>print</strong> on the console <strong>&ldquo;Fuel must be a positive number&rdquo;</strong>).</p>
<p>The <strong>car</strong> and the <strong>bus</strong> <strong>cannot be filled up</strong> with <strong>more </strong>fuel<strong> than their tank capacity</strong>. If you <strong>try to put more fuel</strong> in the tank than the <strong>available space,</strong> print on the console <strong>&ldquo;Cannot fit fuel in tank&rdquo;</strong> and <strong>do not add any fuel</strong> in vehicles tank.</p>
<p>Add <strong>new command</strong> for the bus. The <strong>bus</strong> can <strong>drive</strong> <strong>with or without people</strong>. If the bus is driving <strong>with people</strong>, the <strong>air-conditioner</strong> <strong>is turned on</strong> and its <strong>fuel consumption</strong> per kilometer is <strong>increased with 1.4 liters</strong>. If there are <strong>no people in the bus</strong> when driving the air-conditioner is <strong>turned off</strong> and <strong>does not increase</strong> the fuel consumption.</p>
<h3>Input</h3>
<ul>
<li>On the first three lines you will receive information about the vehicles in format:</li>
</ul>
<p><strong>Vehicle {initial fuel quantity} {liters per km} {tank capacity}</strong></p>
<ul>
<li>On fourth line - number of commands N that will be given on the next N lines</li>
<li>On the next N lines &ndash; commands in format
<ul>
<li>Drive Car {distance}</li>
<li>Drive Truck {distance}</li>
<li>Drive Bus {distance}</li>
<li>DriveEmpty Bus {distance}</li>
<li>Refuel Car {liters}</li>
<li>Refuel Truck {liters}</li>
<li>Refuel Bus {liters}</li>
</ul>
</li>
</ul>
<h3>Output</h3>
<ul>
<li>After each Drive command print whether the Car/Truck was able to travel given distance in format if it&rsquo;s successful:</li>
</ul>
<p>Car/Truck/Bus travelled {distance} km</p>
<ul>
<li>Or if it is not:</li>
</ul>
<p>Car/Truck/Bus needs refueling</p>
<ul>
<li>If given fuel is<strong>&le; 0 </strong>print <strong>&ldquo;Fuel must be a positive number&rdquo;.</strong></li>
<li>If given fuel cannot fit in car or bus tank print &ldquo;Cannot fit in tank&rdquo;</li>
<li>Finally print the remaining fuel for both car and truck rounded 2 digits after floating point in format:</li>
</ul>
<p>Car: {liters}</p>
<p>Truck: {liters}</p>
<p>Bus: {liters}</p>
<p>&nbsp;</p>
<h3>Example</h3>
<table width="438">
<tbody>
<tr>
<td width="175">
<p><strong>Input</strong></p>
</td>
<td width="263">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="175">
<p>Car 30 0.04 70</p>
<p>Truck 100 0.5 300</p>
<p>Bus 40 0.3 150</p>
<p>8</p>
<p>Refuel Car -10</p>
<p>Refuel Truck 0</p>
<p>Refuel Car 10</p>
<p>Refuel Car 300</p>
<p>Drive Bus 10</p>
<p>Refuel Bus 1000</p>
<p>DriveEmpty Bus 100</p>
<p>Refuel Truck 1000</p>
</td>
<td width="263">
<p>Fuel must be a positive number</p>
<p>Fuel must be a positive number</p>
<p>Cannot fit fuel in tank</p>
<p>Bus travelled 10 km</p>
<p>Cannot fit fuel in tank</p>
<p>Bus needs refueling</p>
<p>Car: 40.00</p>
<p>Truck: 1050.00</p>
<p>Bus: 23.00</p>
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>Problem 3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Wild farm</h2>
<p>Your task is to create a class hierarchy like in the picture below. All the classes <strong>except</strong> Vegetable, Meat, Mouse, Tiger, Cat &amp; Zebra <strong>should be abstract</strong>. Override method <strong>ToString()</strong>.</p>
<p>Input should be read from the console. Every <strong>odd</strong> line will contain information about the Animal in following format:</p>
<p><strong>{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed}</strong><em> = Only if its cat</em><strong>]</strong></p>
<p>On the <strong>even</strong> lines you will receive information about the food that you should give to the Animal. The line will consist of <strong>FoodType</strong> and <strong>quantity</strong> separated by a whitespace.</p>
<p><strong>{FoodType} {Quantiy} </strong></p>
<p>You should build the logic to determine if the animal is going to eat the provided food. The <strong>Mouse</strong> and <strong>Zebra</strong> should check if the food is a <strong>Vegetable</strong>. If it is they will eat it - otherwise you should print a message in the format:</p>
<p><strong>{AnimalType in plural</strong><strong>} are not eating that type of food!</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Cats</strong> eat <strong>any</strong> kind of food, but <strong>Tigers</strong> accept <strong>only Meat</strong>. If <strong>Vegetable</strong> is provided to a <strong>Tiger</strong> message like the one above should be printed on the console.</p>
<p>&nbsp;</p>
<p>Override <strong>ToString()</strong> method to print the information about the animal in format:</p>
<p>&nbsp;</p>
<p><strong>{AnimalType}[{AnimalName}, {CatBreed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]</strong></p>
<p>After you read information about the Animal and Food then invoke the <strong>MakeSound()</strong> method of the current animal and then feed it. At the end print the whole object and proceed reading information about the next animal/food. The input will continue until you receive &ldquo;<strong>End</strong>&rdquo; for animal information.</p>
<p>Sounds produced by the animals:</p>
<ul>
<li><strong>Mouse &ndash; &ldquo;SQUEEEAAAK!&rdquo;</strong></li>
<li><strong>Zebra &ndash; &ldquo;Zs&rdquo;</strong></li>
<li><strong>Cat &ndash; &ldquo;Meowwww&rdquo;</strong></li>
<li><strong>Tiger &ndash; &ldquo;ROAAR!!!&rdquo;</strong></li>
</ul>
<h3>Input</h3>
<p>You will receive lines on the Console until the command &ldquo;End&rdquo; is received. On every odd line you will be provided with information about an animal. On every even line you will receive the food which is given to the animal.</p>
<h3>Output</h3>
<p>For each animal you have read, print two lines on the Console:</p>
<ul>
<li>On the first line: the sound produced by the animal</li>
<li>On the second line: all the information about the animal in the format described above</li>
</ul>
<h3>Example</h3>
<table width="696">
<tbody>
<tr>
<td width="300">
<p><strong>Input</strong></p>
</td>
<td width="396">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="300">
<p>Cat Gray 1.1 Home Persian</p>
<p>Vegetable 4</p>
<p>End</p>
</td>
<td width="396">
<p>Meowwww</p>
<p>Cat[Gray, Persian, 1.1, Home, 4]</p>
</td>
</tr>
<tr>
<td width="300">
<p>Tiger Typcho 167.7 Asia</p>
<p>Vegetable 1</p>
<p>End</p>
</td>
<td width="396">
<p>ROAAR!!!</p>
<p>Tigers are not eating that type of food!</p>
<p>Tiger[Typcho, 167.7, Asia, 0]</p>
</td>
</tr>
<tr>
<td width="300">
<p>Zebra Doncho 500 Africa</p>
<p>Vegetable 150</p>
<p>End</p>
</td>
<td width="396">
<p>Zs</p>
<p>Zebra[Doncho, 500, Africa, 150]</p>
</td>
</tr>
<tr>
<td width="300">
<p>Mouse Jerry 0.5 Anywhere</p>
<p>Vegetable 0</p>
<p>End</p>
</td>
<td width="396">
<p>SQUEEEAAAK!</p>
<p>&nbsp;Mouse[Jerry, 0.5, Anywhere, 0]</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>