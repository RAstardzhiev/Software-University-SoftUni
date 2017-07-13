<h1>C# OOP Basics Exam Preparation I &ndash;</h1>
<h1>Need For Speed</h1>
<p>The Speed Rush has been around for many years. The thrill of racing with insane speeds, and the risk of winning or losing a lot of money, is the main reason for the racers&rsquo; &hellip; Need For Speed.</p>
<h3>Overview</h3>
<p>You have a task to write a software program, which will create a virtual model of the cars, races and their development.</p>
<h3>Task I : Structure</h3>
<p>The main structure of the program should include the following elements:</p>
<h4>Cars</h4>
<p>A basic car has the following properties: a <strong>brand</strong> (<strong>string</strong>), a <strong>model</strong> (<strong>string</strong>), an <strong>yearOfProduction</strong> (<strong>int</strong>), <strong>horsepower</strong> (<strong>int</strong>), <strong>acceleration</strong> (<strong>int</strong>), <strong>suspension</strong> (<strong>int</strong>), and <strong>durability</strong> (<strong>int</strong>).</p>
<p>Each different type of car adds to those properties. Here are the types:</p>
<ul>
<li>PerformanceCar &ndash; a car made for racing. Might be a little ugly, but it is a rocket inside.
<ul>
<li>Has <strong>addOns</strong> (<strong>Collection of strings</strong>). (by default &ndash; <strong>empty</strong>)</li>
<li><strong>Increases</strong> its given <strong>horsepower</strong> by <strong>50%</strong>.</li>
<li><strong>Decreases </strong>its given <strong>suspension</strong> by <strong>25%</strong>.</li>
</ul>
</li>
<li>ShowCar &ndash; a car made for showing off. Looking cool out there, bro.
<ul>
<li>Has <strong>stars</strong> (<strong>int</strong>). (by default &ndash; <strong>0</strong>)</li>
</ul>
</li>
</ul>
<h4>Races</h4>
<p>The basic race has the following properties: <strong>length </strong>(<strong>int</strong>), <strong>route</strong> (<strong>string</strong>), a <strong>prizePool</strong> (<strong>int</strong>), and <strong>participants</strong> (<strong>Collection of Cars</strong>),</p>
<ul>
<li>CasualRace &ndash; just a normal race. Several beasts&rsquo; warfare, spreading their roars throughout the roads.</li>
<li>DragRace &ndash; a drag race. An engine fray. The ideal gear shifting will be the winner in this.</li>
<li>DriftRace &ndash; a drift race. Don&rsquo;t you wish your girlfriend was drifty like</li>
</ul>
<h4>Garage</h4>
<ul>
<li>Garage &ndash; The Garage is that place where all the cars stay, when they are not racing. The Garage also provides the ability to <strong>modify</strong> parked car
<ul>
<li>Has <strong>parkedCars</strong> (<strong>Collection of Cars</strong>).</li>
</ul>
</li>
</ul>
<h4>Constructors</h4>
<p>Implement all <strong>class constructors</strong>, with the <strong>parameters</strong> in the <strong>EXACT</strong> <strong>given order </strong>and the<strong> EXACT given types</strong>.</p>
<h4>String Representation&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4>
<p>Implement ToString() methods for every Car class. You can see the requirements in the <strong>Output</strong> <strong>Section</strong> below.</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Task II: Business Logic</h3>
<h4>The Controller Class</h4>
<p>The business logic of the program should be concentrated around several commands. Implement a class called CarManager, which will hold the <strong>main functionality</strong>, represented by these <strong>methods</strong>:</p>
<ul>
<li>void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)</li>
<li>string Check(int id)</li>
<li>void Open(int id, string type, int length, string route, int prizePool)</li>
<li>void Participate(int carId, int raceId)</li>
<li>string Start(int id)</li>
<li>void Park(int id)</li>
<li>void Unpark(int id)</li>
<li>void Tune(int tuneIndex, string addOn)</li>
</ul>
<h4>Commands</h4>
<p>The commands in the <strong>CarManager class</strong> should represent the <strong>functionality</strong> to the input commands of the user. Here are the <strong>input commands</strong> you need to accept from the <strong>user input</strong>.</p>
<ul>
<li><strong>register {id} {type} {brand} {model} {year} {horsepower} {acceleration} {suspension} {durability}</strong>
<ul>
<li><strong>REGISTERS</strong> a car of the <strong>given type</strong>, with the <strong>given</strong> <strong>id</strong>, and the <strong>given</strong> <strong>stats</strong>.</li>
<li>The <strong>car type</strong> will be either &ldquo;<strong>Performance</strong>&rdquo; or &ldquo;<strong>Show</strong>&rdquo;.</li>
</ul>
</li>
<li><strong>check {id}</strong>
<ul>
<li><strong>CHECKS details </strong>about the <strong>car</strong> with the<strong> given id</strong>.</li>
<li><strong>RETURNS </strong>a <strong>string</strong> <strong>representation</strong> of the <strong>car</strong>.</li>
</ul>
</li>
<li><strong>open {id} {type} {length} {route} {prizePool}</strong>
<ul>
<li><strong>OPENS</strong> a race of the <strong>given type</strong>, with the <strong>given id</strong>, and <strong>stats</strong>.</li>
<li>The <strong>race type</strong> will be either &ldquo;<strong>Casual</strong>&rdquo;, &ldquo;<strong>Drag</strong>&rdquo; or &ldquo;<strong>Drift</strong>&rdquo;.</li>
</ul>
</li>
<li><strong>participate {carId} {raceId}</strong>
<ul>
<li><strong>ADDS</strong> a car as a <strong>participant</strong> in the <strong>given race</strong>.</li>
<li>Once added, a car <strong>CANNOT</strong> <strong>turn down</strong> a <strong>race </strong>or be <strong>REMOVED</strong> from it.</li>
</ul>
</li>
<li><strong>start {raceId}</strong>
<ul>
<li><strong>INITIATES</strong> the <strong>race</strong> with the <strong>given id</strong>.</li>
<li><strong>RETURNS </strong>detailed information about the <strong>race result</strong>.</li>
</ul>
</li>
<li><strong>park {carId}</strong>
<ul>
<li><strong>PARKS</strong> a car by a <strong>given id</strong> in the garage.</li>
</ul>
</li>
<li><strong>unpark {carId}</strong>
<ul>
<li><strong>UNPARKS</strong> the car with the<strong> given id</strong> from the garage.</li>
</ul>
</li>
<li><strong>tune {tuneIndex} {tuneAddOn}</strong>
<ul>
<li><strong>Tunes</strong> the <strong>currently parked CARS</strong> with the <strong>given</strong> <strong>index</strong> and the given <strong>add-on</strong>.</li>
<li>You should <strong>increase</strong> a car&rsquo;s <strong>horsepower</strong> by the <strong>given index</strong>, and the <strong>suspension</strong>, by <strong>HALF</strong> of the <strong>given index.</strong>
<ul>
<li><strong>150 tuneIndex</strong> = <strong>150</strong> <strong>increase</strong> in the <strong>horsepower</strong> and <strong>75 increase</strong> in <strong>suspension</strong>.</li>
</ul>
</li>
</ul>
</li>
</ul>
<p><strong>&nbsp;</strong></p>
<ul>
<li>If the car is a <strong>ShowCar</strong> it should increase its <strong>stars </strong>by the <strong>given tuneIndex</strong>.</li>
<li>Upon tuning, a <strong>PerformanceCar</strong> adds the <strong>given</strong> <strong>add-on</strong> to its <strong>collection</strong> of <strong>add-ons</strong>.</li>
</ul>
<h4>Functionality</h4>
<p><strong>Cars</strong> and <strong>Races</strong> are the <strong>main entities</strong> in the program&rsquo;s functionality. They have no suitable way to be <strong>ACCESSED</strong>, which is why, upon registration, they are <strong>given</strong> an <strong>Id</strong>. The Id will be a simple integer. There is <strong>NO need</strong> for <strong>Cars</strong> and <strong>Races</strong> to know their <strong>Ids</strong>. The <strong>CarManager</strong> is the one that <strong>controls</strong> the <strong>main logic</strong>, which is why it is the <strong>only class</strong> which needs to know of <strong>every car</strong> and<strong> race&rsquo;s</strong> <strong>id</strong>.</p>
<p>When you register a car, you store it in such a way, so that you can <strong>access</strong> it <strong>by id</strong>. You can then make the car participate in a race, or select it in the garage. There are several <strong>RULES</strong> that you must follow:</p>
<ol>
<li>Once a car has been <strong>ADDED</strong> as a <strong>participant</strong> in a race, it <strong>CANNOT</strong> be <strong>PARKED </strong>in the garage, <strong>UNTIL</strong> the race is <strong>OVER</strong>.
<ul>
<li><strong>IGNORE</strong> any attempt to park a racer car.</li>
</ul>
</li>
<li>A car, which has been <strong>PARKED</strong> in the garage, <strong>CANNOT</strong> participate in a race.
<ul>
<li><strong>IGNORE</strong> any attempt to include a parked car in a race.</li>
</ul>
</li>
<li><strong>IGNORE</strong> any attempt to <strong>TUNE</strong> cars, when there are <strong>NO PARKED </strong>cars in the garage.</li>
<li><strong>SINGLE</strong> car <strong>CAN</strong> participate in <strong>MANY</strong></li>
<li>A race <strong>CANNOT</strong> start without <strong>ANY</strong></li>
<li>A race <strong>CAN</strong> start with <strong>LESS</strong> than <strong>three participants</strong>.</li>
</ol>
<p><strong>Performance points</strong> <strong>(PP)</strong> determine every race&rsquo;s winners. <strong>PP</strong> are either <strong>Overall Performance</strong>, <strong>Engine Performance</strong> or <strong>Suspension Performance</strong>. Here are the different <strong>formulas</strong>:</p>
<ul>
<li>A CasualRacedetermines its <strong>winners</strong> based on their <strong>Overall Performance</strong> (<strong>OP</strong>) (in <strong>DESCENDING</strong> order). <strong>Overall Performance</strong>, of <strong>EACH CAR</strong>, is calculated by the following formula:<br /> (horsepower / acceleration) + (suspension + durability)</li>
</ul>
<p><strong>&nbsp;</strong></p>
<ul>
<li>A DragRacedetermines its <strong>winners</strong> based on their <strong>Engine Performance</strong> (<strong>EP</strong>) (in <strong>DESCENDING</strong> order). <strong>Engine</strong> <strong>Performance</strong>, of <strong>EACH CAR</strong>, is calculated by the following formula:<br /> (horsepower / acceleration)</li>
</ul>
<p><strong>&nbsp;</strong></p>
<ul>
<li>A DriftRacedetermines its <strong>winners</strong> based on their <strong>Suspension Performance</strong> (<strong>SP</strong>) (in <strong>DESCENDING</strong> order). <strong>Suspension</strong> <strong>Performance</strong>, of <strong>EACH CAR</strong>, is calculated by the following formula:<br /> (suspension + durability)</li>
</ul>
<p>Depending on the different TYPE of RACE, different type of POINTS are calculated for the racers. In the end all points are presented as Performance Points (in the OUTPUT).</p>
<p>When you <strong>OPEN</strong> a race, you register it &ndash; this provides the functionality to <strong>add participants</strong> to it. <br /> When you <strong>START</strong> a race, the winners are calculated immediately, <strong>PRINTED</strong> as <strong>output</strong>, and the race becomes <strong>CLOSED </strong>(you <strong>CANNOT </strong>add any more <strong>participants</strong> in it, and you <strong>CANNOT</strong> start it again).</p>
<p>&nbsp;</p>
<p>If <strong>TWO </strong>cars have the <strong>SAME </strong>result, participant<strong> registered before the other</strong> comes <strong>FIRST</strong>.</p>
<p>The <strong>1st place</strong> winner takes <strong>50 %</strong> of the race&rsquo;s <strong>prize pool</strong>.</p>
<p>The <strong>2nd place</strong> winner takes <strong>30 %</strong> of the race&rsquo;s <strong>prize pool</strong>.</p>
<p>The <strong>3rd place</strong> winner takes <strong>20 %</strong> of the race&rsquo;s <strong>prize pool</strong>.</p>
<p>You need to take in account <strong>ONLY</strong> the <strong>FIRST 3 </strong>players, <strong>AFTER</strong> you&rsquo;ve ordered them in <strong>descending order</strong>, by the <strong>corresponding criteria</strong>.</p>
<p>In case a race has <strong>LESS</strong> than <strong>3 participants</strong>, you should print <strong>only</strong> <strong>them</strong>, as <strong>winners</strong>. The <strong>prizes</strong> remain the <strong>SAME</strong>.</p>
<p>In case a race has <strong>NO</strong> participants, you should print &ldquo;<strong>Cannot start the race with zero participants.</strong>&rdquo;, and <strong>IGNORE</strong> the command.</p>
<h3>Task III: I / O (Input / Output)</h3>
<h4>Input</h4>
<ul>
<li>The input will come in the form of commands, in the format specified above.</li>
<li>The input sequence ends when you receive the command &ldquo;<strong>Cops Are Here</strong>&rdquo;.</li>
</ul>
<h4>Output</h4>
<p>Two elements generate output in the program&rsquo;s functionality:</p>
<ul>
<li>The &ldquo;<strong>check</strong>&rdquo; command should <strong>RETURN</strong> a <strong>String representation</strong> of the <strong>CAR</strong> with the <strong>GIVEN ID</strong>:
<ul>
<li>&ldquo;{brand} {model} {yearOfProduction}</li>
<li>{horsepower} HP, 100 m/h in {acceleration} s</li>
<li>{suspension} Suspension force, {durability} Durability&rdquo;</li>
<li>If the car is a <strong>PerformanceCar</strong>, you must print &ldquo;Add-ons: {add-ons}&rdquo;, on the <strong>last line</strong> &ndash; <strong>each</strong> <strong>add-on</strong> <strong>separated</strong> by a <strong>comma</strong> and a <strong>space</strong> &ldquo;<strong>, </strong>&ldquo;. In case there are <strong>NO</strong> add-ons, print &ldquo;<strong>None</strong>&rdquo;.</li>
<li>If the car is a <strong>ShowCar</strong>, you must print &ldquo;{stars} *&rdquo;, on the <strong>last line</strong>.</li>
</ul>
</li>
<li>The &ldquo;<strong>start</strong>&rdquo; command should <strong>RETURN</strong> a <strong>String representation</strong> the <strong>RACE</strong> with the <strong>GIVEN ID</strong>:
<ul>
<li>&ldquo;{route} - {length}</li>
<li>{brand} {model} {performancePoints}PP - ${moneyWon}</li>
<li>{brand} {model} {performancePoints}PP - ${moneyWon}</li>
<li>{brand} {model} {performancePoints}PP - ${moneyWon}&rdquo;</li>
<li><strong>1</strong>, <strong>2</strong> and <strong>3</strong> &ndash; being the <strong>1<sup>st</sup></strong>, <strong>2<sup>nd</sup></strong> and <strong>3<sup>rd</sup></strong> participants (the <strong>winners</strong>).</li>
<li><strong>If </strong>there are <strong>LESS</strong> than <strong>3</strong> participants, print as much as there are.</li>
<li>In case there are <strong>NO</strong> participants, print &ldquo;<strong>Cannot start the race with zero participants.</strong>&rdquo;, and <strong>IGNORE</strong> the command.</li>
</ul>
</li>
</ul>
<h4>Constrains</h4>
<ul>
<li><strong>All integers</strong> in the input will be in <strong>range [0, 100000]</strong>.</li>
<li><strong>All strings</strong> in the input may consist of <strong>any ASCII character</strong>, except <strong>SPACE</strong>
<ul>
<li>So that the input is easily processed.</li>
</ul>
</li>
<li>There will be <strong>NO invalid</strong> input lines, or <strong>invalid </strong>(<strong>non-existent</strong>) Ids.</li>
<li>Note that throughout the program, you are working <strong>ONLY</strong> with <strong>INTEGERS</strong>.
<ul>
<li>Each <strong>mathematical</strong> or <strong>logical action</strong> performed on <strong>numeric data</strong>, should be performed between <strong>INTEGERS</strong>.</li>
</ul>
</li>
<li>Note: <strong>50%</strong> of <strong>X </strong>is <strong>EQUAL</strong> to <strong>(X * 50) / 100</strong>.</li>
<li><strong>Note</strong>: <strong>Decrease</strong> means <strong>DECREASE&hellip; 100</strong> <strong>decreased</strong> by <strong>25%</strong> = <strong>100 &ndash; (100 * 25) / 100 = 100 &ndash; 25 = 75</strong>.</li>
</ul>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h4>Examples</h4>
<table width="756">
<tbody>
<tr>
<td width="474">
<p><strong>Input</strong></p>
</td>
<td width="282">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="474">
<p>register 1 Performance BMV M92 2013 300 4 150 75</p>
<p>register 2 Show Maserati Levante 2015 400 6 250 100</p>
<p>register 3 Performance Nissan GT-R 2017 550 4 300 100</p>
<p>register 4 Performance McLaren P1 2016 650 2 400 200</p>
<p>register 5 Performance Trabant 601 1988 2000 1 10000 1000</p>
<p>open 1 Drag 10 BeverlyHills 50000</p>
<p>open 3 Casual 20 NewYork 100000</p>
<p>participate 1 1</p>
<p>participate 2 1</p>
<p>participate 3 1</p>
<p>participate 4 1</p>
<p>participate 5 1</p>
<p>participate 1 3</p>
<p>participate 2 3</p>
<p>participate 3 3</p>
<p>participate 4 3</p>
<p>participate 5 3</p>
<p>check 5</p>
<p>start 1</p>
<p>start 3</p>
<p>Cops Are Here</p>
</td>
<td width="282">
<p>Trabant 601 1988</p>
<p>3000 HP, 100 m/h in 1 s</p>
<p>7500 Suspension force, 1000 Durability</p>
<p>Add-ons: None</p>
<p>BeverlyHills - 10</p>
<p>1. Trabant 601 3000PP - $25000</p>
<p>2. McLaren P1 487PP - $15000</p>
<p>3. Nissan GT-R 206PP - $10000</p>
<p>NewYork - 20</p>
<p>1. Trabant 601 11500PP - $50000</p>
<p>2. McLaren P1 987PP - $30000</p>
<p>3. Nissan GT-R 531PP - $20000</p>
</td>
</tr>
<tr>
<td width="474">
<p>register 3 Show Porsche Carrera 2017 550 4 300 100</p>
<p>register 4 Performance McLaren P1 2016 650 2 400 200</p>
<p>register 5 Performance Trabant 601 1988 2000 1 10000 1000</p>
<p>open 1 Casual 20 Manhattan 100000</p>
<p>open 2 Drag 14 Washington 100000</p>
<p>participate 5 1</p>
<p>participate 5 2</p>
<p>park 3</p>
<p>park 4</p>
<p>park 5</p>
<p>start 2</p>
<p>tune 150 Turbo</p>
<p>tune 100 Nitrous</p>
<p>tune 50 Tires</p>
<p>participate 3 1</p>
<p>check 3</p>
<p>check 4</p>
<p>unpark 4</p>
<p>participate 4 1</p>
<p>start 1</p>
<p>Cops Are Here</p>
</td>
<td width="282">
<p>Washington - 14</p>
<p>1. Trabant 601 3000PP - $50000</p>
<p>Porsche Carrera 2017</p>
<p>850 HP, 100 m/h in 4 s</p>
<p>450 Suspension force, 100 Durability</p>
<p>300 *</p>
<p>McLaren P1 2016</p>
<p>1275 HP, 100 m/h in 2 s</p>
<p>450 Suspension force, 200 Durability</p>
<p>Add-ons: Turbo, Nitrous, Tires</p>
<p>Manhattan - 20</p>
<p>1. Trabant 601 11500PP - $50000</p>
<p>2. McLaren P1 1287PP - $30000</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h3>Task IV: Bonus</h3>
<p>The modern racers like different types of races. If you are really good at writing software, then your employers would like to hire you for some more work.</p>
<p>Your task is to implement classes for <strong>2</strong> extra <strong>SPECIAL</strong> <strong>races</strong>:</p>
<ul>
<li>TimeLimitRace
<ul>
<li>Is <strong>INITIALIZED</strong> with an<strong> EXTRA PARAMETER &ndash; goldTime</strong> (<strong>int</strong>).</li>
</ul>
</li>
<li>CircuitRace
<ul>
<li>Is <strong>INITIALIZED</strong> with an<strong> EXTRA PARAMETER &ndash; laps</strong> (<strong>int</strong>).</li>
</ul>
</li>
</ul>
<p>Both races, have an extra parameter, aside from the <strong>normal races</strong>. The parameter is received, <strong>from</strong> the <strong>user input</strong> as last parameter, when <strong>OPENING </strong>one of these <strong>types</strong> of <strong>races</strong>.</p>
<h4>Logic</h4>
<p>The TimeLimitRace can only have <strong>1 participant</strong>. <strong>ANY</strong> attempt to <strong>add more participants</strong> to it should be <strong>IGNORED</strong>.<br /> The participant has a <strong>Time Performance</strong> (<strong>TP</strong>), which is calculated by the following formula:</p>
<p>raceLength&nbsp; * ((participantHorsepower / 100) * participantAcceleration)</p>
<p>Depending on the Time Performance, the player earns &ldquo;<strong>Gold</strong>&rdquo;, &ldquo;<strong>Silver</strong>&rdquo; or &ldquo;<strong>Bronze</strong>&rdquo; time:</p>
<ul>
<li><strong>TP</strong> &lt;= <strong>raceGoldTime</strong> &ndash; Racer has earned <strong>Gold</strong> Time and earns <strong>100%</strong> of the <strong>prizePool</strong>.</li>
<li><strong>TP</strong> &lt;= <strong>raceGoldTime</strong> + <strong>15</strong> &ndash; Racer has earned <strong>Silver</strong> Time and earns <strong>50%</strong> of the <strong>prizePool</strong>.</li>
<li><strong>TP</strong> &gt; <strong>raceGoldTime</strong> + <strong>15</strong> &ndash; Racer has earned <strong>Bronze</strong> Time and earns <strong>30%</strong> of the <strong>prizePool</strong>.</li>
</ul>
<p>The <strong>String representation</strong> of the TimeLimitRace is in the following format:</p>
<ul>
<li>&ldquo;{route} &ndash; {length}</li>
<li>{participantBrand} {participantModel} &ndash; {participantTimePerformance} s.</li>
<li>{participantEarnedTime} Time, ${wonPrize}.&rdquo;</li>
</ul>
<p>&nbsp;</p>
<p>The CircuitRace is almost like a normal race, with the difference that it has <strong>laps</strong> and <strong>4 winners</strong> in <strong>total</strong>. The winners are <strong>determined</strong> by <strong>Overall Performance</strong> (<strong>OP</strong>) like in CasualRace.</p>
<ul>
<li><strong>1<sup>st</sup></strong> place earns <strong>40% </strong>of the</li>
<li><strong>2<sup>nd</sup></strong> place earns <strong>30% </strong>of the</li>
<li><strong>3<sup>rd</sup></strong> place earns <strong>20% </strong>of the</li>
<li><strong>4<sup>th</sup></strong> place earns <strong>10%</strong> of the <strong>prizePool</strong>.</li>
</ul>
<p>The special thing about this race is &hellip; That <strong>EVERY</strong> lap <strong>DECREASES</strong> the <strong>DURABILITY</strong> of <strong>EACH</strong> participant by (<strong>length</strong> <strong>*</strong> <strong>length</strong>). The <strong>String representation</strong> of the CircuitRace is in the following format:</p>
<ul>
<li>&ldquo;{route} - {length * laps}</li>
<li>{brand} {model} {performancePoints}PP - ${moneyWon}</li>
<li>{brand} {model} {performancePoints}PP - ${moneyWon}</li>
<li>{brand} {model} {performancePoints}PP - ${moneyWon}</li>
<li>{brand} {model} {performancePoints}PP - ${moneyWon}&rdquo;</li>
</ul>
<p>&nbsp;</p>
<h4>Examples</h4>
<table width="744">
<tbody>
<tr>
<td width="450">
<p><strong>Input</strong></p>
</td>
<td width="294">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="450">
<p>register 1 Performance Mitsubishi Lancer-Evo 2010 400 5 200 100</p>
<p>register 2 Performance Nissan Z370 2012 500 4 300 200</p>
<p>register 3 Show BMW i8-Spyder 2016 600 3 400 300</p>
<p>register 4 Performance Lamborghini Aventador 2017 1000 2 500 300</p>
<p>register 5 Show Ford Mustang-Shelby 1970 400 5 700 200</p>
<p>open 1 Circuit 10 SofiaStreets 100000 5</p>
<p>open 2 Circuit 2 SofiaAirport 10000 2</p>
<p>participate 1 1</p>
<p>participate 2 1</p>
<p>participate 3 1</p>
<p>participate 4 1</p>
<p>participate 5 1</p>
<p>start 1</p>
<p>check 1</p>
<p>check 2</p>
<p>check 3</p>
<p>check 4</p>
<p>check 5</p>
<p>Cops Are Here</p>
</td>
<td width="294">
<p>SofiaStreets - 50</p>
<p>1. Lamborghini Aventador 925PP - $40000</p>
<p>2. Ford Mustang-Shelby 480PP - $30000</p>
<p>3. BMW i8-Spyder 400PP - $20000</p>
<p>4. Nissan Z370 112PP - $10000</p>
<p>Mitsubishi Lancer-Evo 2010</p>
<p>600 HP, 100 m/h in 5 s</p>
<p>150 Suspension force, -400 Durability</p>
<p>Add-ons: None</p>
<p>Nissan Z370 2012</p>
<p>750 HP, 100 m/h in 4 s</p>
<p>225 Suspension force, -300 Durability</p>
<p>Add-ons: None</p>
<p>BMW i8-Spyder 2016</p>
<p>600 HP, 100 m/h in 3 s</p>
<p>400 Suspension force, -200 Durability</p>
<p>0 *</p>
<p>Lamborghini Aventador 2017</p>
<p>1500 HP, 100 m/h in 2 s</p>
<p>375 Suspension force, -200 Durability</p>
<p>Add-ons: None</p>
<p>Ford Mustang-Shelby 1970</p>
<p>400 HP, 100 m/h in 5 s</p>
<p>700 Suspension force, -300 Durability</p>
<p>0 *</p>
</td>
</tr>
<tr>
<td width="450">
<p>register 1 Performance Mitsubishi Lancer-Evo 2010 400 5 200 100</p>
<p>register 4 Performance Lamborghini Aventador 2017 1000 2 500 300</p>
<p>park 4</p>
<p>tune 1000 Turbo</p>
<p>unpark 4</p>
<p>open 1 TimeLimit 5 SofiaAirport 100000 260</p>
<p>open 2 TimeLimit 5 Malibu 10000 240</p>
<p>start 1</p>
<p>participate 4 1</p>
<p>participate 1 1</p>
<p>participate 4 2</p>
<p>start 1</p>
<p>start 2</p>
<p>Cops Are Here</p>
</td>
<td width="294">
<p>Cannot start the race with zero participants.</p>
<p>SofiaAirport - 5</p>
<p>Lamborghini Aventador - 250 s.</p>
<p>Gold Time, $100000.</p>
<p>Malibu - 5</p>
<p>Lamborghini Aventador - 250 s.</p>
<p>Silver Time, $5000.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>