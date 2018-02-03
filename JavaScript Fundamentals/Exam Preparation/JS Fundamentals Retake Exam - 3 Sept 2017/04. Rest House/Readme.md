<h1>Problem 4 &ndash; Rest House</h1>
<p><em>You were able to survive the exams, and now you and your friends from the university have gathered to relax at this year's camp. The bad thing is that the person, responsible for the accommodation of the guests is gone and you can not decide on how to distribute the available rooms. Slowly, anarchy begins to take place among you - the holidaymakers, and it would be a pity to fight like little girls after you have gone through the hardship of the exams. So you decide to take things in your own hands and do the hard job...</em></p>
<p>You will receive an array of rooms and each room will be an object in the following format:</p>
<p>{</p>
<p>&nbsp; number: String,</p>
<p>&nbsp; type: String,</p>
<p>}</p>
<p>The <strong>number</strong> property is the number of the room, <strong>type</strong> is the type of the room: "<strong>double-bedded</strong>" or "<strong>triple</strong>".</p>
<p>Next comes the data for the guests in an array of objects. Each object from the array holds a pair of people, as shown below:</p>
<p>{</p>
<p>&nbsp; first:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp; name: String,</p>
<p>&nbsp;&nbsp; gender: String,</p>
<p>&nbsp;&nbsp; age: Number</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp; second:</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp; name: String,</p>
<p>&nbsp;&nbsp; gender: String,</p>
<p>&nbsp;&nbsp; age: Number</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
<p>The <strong>name</strong> property holds two names &ndash; first name and last name of the person, separated by a space. The <strong>gender</strong> property can be one of two values: "<strong>female</strong>" or "<strong>male</strong>".</p>
<p>Accommodation conditions for guests:</p>
<ul>
<li>If the couple is a <strong>male</strong> <strong>and</strong> a <strong>female</strong>, they must be accommodated in the <strong>first free double</strong> room;</li>
<li>If the couple is of two people of <strong>the same gender</strong>, they should be accommodated in a <strong>triple</strong> room;</li>
<li>If there is <strong>free</strong> space in a <strong>triple</strong> room, it must be filled by a <strong>guest</strong> or <strong>guests</strong> of <strong>the same gender</strong> as the one <strong>already staying</strong> in the room;</li>
</ul>
<p>A couple with guests of the same gender <strong>should be split up</strong> to fill the free beds in a <strong>triple </strong>room. Sort the rooms by room number in <strong>ascending alphanumeric</strong> order. For each room, print its number:</p>
<p>Room number: <em>&lt;room number&gt;</em></p>
<p>&nbsp;Sort the guests in each room by their name, in <strong>ascending alphabetical</strong> order, then print their names and age:</p>
<p>--Guest Name: <em>&lt;full name&gt;</em></p>
<p>--Guest Age: <em>&lt;age&gt;</em></p>
<p>Print the number of free beds in each room:</p>
<p>Empty beds in the room:<em> &lt;number of empty beds&gt;</em></p>
<p>The last line from the output should contain the number of people <strong>without a room</strong>, in the following format:</p>
<p>Guests moved to the tea house: <em>&lt;number of people&gt;</em></p>
<h3>Input</h3>
<p>The input comes will be passed to your function as <strong>two arrays of objects</strong> &ndash; first the <strong>rooms</strong>, then the <strong>guests</strong>.</p>
<p><strong>Output</strong></p>
<p>Print the information described above. See the examples for formatting details.</p>
<table width="591">
<tbody>
<tr>
<td width="591">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="591">
<p>[ { <strong>number</strong>: '206', <strong>type</strong>: 'double-bedded' },</p>
<p>&nbsp; { <strong>number</strong>: '311', <strong>type</strong>: 'triple' } ],</p>
<p>[ { <strong>first</strong>: { <strong>name</strong>: 'Tanya Popova', <strong>gender</strong>: 'female', <strong>age</strong>: 24 },</p>
<p>&nbsp;&nbsp;&nbsp; <strong>second</strong>: { <strong>name</strong>: 'Miglena Yovcheva', <strong>gender</strong>: 'female', <strong>age</strong>: 23 } },</p>
<p>&nbsp; { <strong>first</strong>: { <strong>name</strong>: 'Katerina Stefanova', <strong>gender</strong>: 'female', <strong>age</strong>: 23 },</p>
<p>&nbsp;&nbsp;&nbsp; <strong>second</strong>: { <strong>name</strong>: 'Angel Nachev', <strong>gender</strong>: 'male', <strong>age</strong>: 22 } },</p>
<p>&nbsp; { <strong>first</strong>: { <strong>name</strong>: 'Tatyana Germanova', <strong>gender</strong>: 'female', <strong>age</strong>: 23 },</p>
<p>&nbsp;&nbsp;&nbsp; <strong>second</strong>: { <strong>name</strong>: 'Boryana Baeva', <strong>gender</strong>: 'female', <strong>age</strong>: 22 } } ]</p>
</td>
</tr>
<tr>
<td width="591">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="591">
<p>Room number: 206</p>
<p>--Guest Name: Angel Nachev</p>
<p>--Guest Age: 22</p>
<p>--Guest Name: Katerina Stefanova</p>
<p>--Guest Age: 23</p>
<p>Empty beds in the room: 0</p>
<p>Room number: 311</p>
<p>--Guest Name: Miglena Yovcheva</p>
<p>--Guest Age: 23</p>
<p>--Guest Name: Tanya Popova</p>
<p>--Guest Age: 24</p>
<p>--Guest Name: Tatyana Germanova</p>
<p>--Guest Age: 23</p>
<p>Empty beds in the room: 0</p>
<p>Guests moved to the tea house: 1</p>
</td>
</tr>
<tr>
<td width="591">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="591">
<p>The double rooms are reserved for couples of different genders and Katerina and Angel are the only couple that meets these conditions. Tanya and Miglena go to the triple room and after that there is one free bed left in this room. The last pair splits up, because Tatyana and Boryana are of the same gender as Tanya and Miglena and the first one of them &ndash; Tatyana, goes in their room. Boryana is left with no available room for her, so she goes to the tea house.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="585">
<tbody>
<tr>
<td width="585">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="585">
<p>[ { <strong>number</strong>: '101A', <strong>type</strong>: 'double-bedded' },</p>
<p>&nbsp; { <strong>number</strong>: '104', <strong>type</strong>: 'triple' },</p>
<p>&nbsp; { <strong>number</strong>: '101B', <strong>type</strong>: 'double-bedded' },</p>
<p>&nbsp; { <strong>number</strong>: '102', <strong>type</strong>: 'triple' } ],</p>
<p>[ { <strong>first</strong>: { <strong>name</strong>: 'Sushi &amp; Chicken', <strong>gender</strong>: 'female', <strong>age</strong>: 15 },</p>
<p>&nbsp;&nbsp;&nbsp; <strong>second</strong>: { <strong>name</strong>: 'Salisa Debelisa', <strong>gender</strong>: 'female', <strong>age</strong>: 25 } },</p>
<p>&nbsp; { <strong>first</strong>: { <strong>name</strong>: 'Daenerys Targaryen', <strong>gender</strong>: 'female', <strong>age</strong>: 20 },</p>
<p>&nbsp;&nbsp;&nbsp; <strong>second</strong>: { <strong>name</strong>: 'Jeko Snejev', <strong>gender</strong>: 'male', <strong>age</strong>: 18 } },</p>
<p>&nbsp; { <strong>first</strong>: { <strong>name</strong>: 'Pesho Goshov', <strong>gender</strong>: 'male', <strong>age</strong>: 20 },</p>
<p><strong>&nbsp;&nbsp;&nbsp; second</strong>: { <strong>name</strong>: 'Gosho Peshov', gender: 'male', age: 18 } },&nbsp;&nbsp;&nbsp;</p>
<p>&nbsp; { <strong>first</strong>: { <strong>name</strong>: 'Conor McGregor', <strong>gender</strong>: 'male', <strong>age</strong>: 29 },</p>
<p>&nbsp;&nbsp;&nbsp; <strong>second</strong>: { <strong>name</strong>: 'Floyd Mayweather', <strong>gender</strong>: 'male', <strong>age</strong>: 40 } } ]</p>
</td>
</tr>
<tr>
<td width="585">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="585">
<p>Room number: 101A</p>
<p>--Guest Name: Daenerys Targaryen</p>
<p>--Guest Age: 20</p>
<p>--Guest Name: Jeko Snejev</p>
<p>--Guest Age: 18</p>
<p>Empty beds in the room: 0</p>
<p>Room number: 101B</p>
<p>Empty beds in the room: 2</p>
<p>Room number: 102</p>
<p>--Guest Name: Conor McGregor</p>
<p>--Guest Age: 29</p>
<p>--Guest Name: Gosho Peshov</p>
<p>--Guest Age: 18</p>
<p>--Guest Name: Pesho Goshov</p>
<p>--Guest Age: 20</p>
<p>Empty beds in the room: 0</p>
<p>Room number: 104</p>
<p>--Guest Name: Salisa Debelisa</p>
<p>--Guest Age: 25</p>
<p>--Guest Name: Sushi &amp; Chicken</p>
<p>--Guest Age: 15</p>
<p>Empty beds in the room: 1</p>
<p>Guests moved to the tea house: 1</p>
</td>
</tr>
<tr>
<td width="585">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="585">
<p>The first couple from the input is of the same gender, so we have to accommodate them in a triple room. The first available triple room is with number 104. After that, there is one free bed left in it. The next couple is a female and a male &ndash; they should be accommodated in a double-bedded room, which is 101A. Pesho and Gosho are both males, so they cannot go to room 104, because the people there are females. There is one free triple room for them &ndash; 102. Now we have two triple rooms with one free bed each. The last pair is of two males, but in room 102 there is still one free bed, so the pair has to split. The first one from them &ndash; Conor, goes to room 102 and for Floyd there are no more rooms available, so he goes to the tea house.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>