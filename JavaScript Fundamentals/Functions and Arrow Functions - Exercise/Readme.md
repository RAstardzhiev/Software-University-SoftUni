<h1>Exercises: Functions and Arrow Functions</h1>
<p>Problems for exercises and homework for the <a href="https://softuni.bg/courses/javascript-fundamentals">&ldquo;JavaScript Fundamentals&rdquo; course @ SoftUni</a>. Submit your solutions in the SoftUni judge system at <a href="https://judge.softuni.bg/Contests/310/">https://judge.softuni.bg/Contests/310/</a>.</p>
<h2>1.&nbsp;&nbsp; Inside Volume</h2>
<p>Write a JS function that determines whether a point is inside the volume, defined by the box, shown on the right.</p>
<p>The <strong>input</strong> comes as an array of numbers. Each set of 3 elements are the x, y and z coordinates of a point.</p>
<p>The <strong>output</strong> should be printed to the console on a new line for each point. Print inside if the point lies inside the volume and outisde otherwise.</p>
<h3>Examples</h3>
<table width="227">
<tbody>
<tr>
<td width="151">
<p><strong>Input</strong></p>
</td>
<td width="76">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>[8, 20, 22]</p>
</td>
<td width="76">
<p>outside</p>
</td>
</tr>
<tr>
<td width="151">
<p>[13.1, 50, 31.5,</p>
<p>50, 80, 50,</p>
<p>-5, 18, 43]</p>
</td>
<td width="76">
<p>inside</p>
<p>inside</p>
<p>outside</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>This task is very similar to previous assignments where a point might lie inside an area in 2D space, with just an extra dimension added. If we look at a classic conditional statement, which checks whether a point is inside a rectangle:</p>
<p>It checks whether a coordinate is greater than the minimum and at the same time less than the maximum bounding value for both axes (x and y). All we have to do is to include an additional check for a coordinate to be within the vertical limits of the volume (z-axis):</p>
<p>We can then wrap this whole statement in a function and as we process each set of coordinates, pass them to see if they are inside the volume and print the correct message to the console. Since the volume is the same every time, we can hardcode the values, but it&rsquo;s generally good practice to pass them as function arguments, so that the function may work with any arbitrary volume. Later in the course we&rsquo;ll learn how to shorten this with the use of objects.</p>
<p>We can extract the sets of coordinates with a loop that skips 3 elements at a time and assigns them to temporary variables:</p>
<p>We know from the problem description that the input array will contain sets to three coordinates. Starting at 0, the current element (denoted by index <strong><em>i</em></strong> inside the loop) is the x-coordinate, the element after the current (<strong><em>i + 1</em></strong>) is the y-coordinate, and the element two indices after the current (<strong><em>i + 2</em></strong>) is the z-coordinate. At the end of the cycle, the index is increased by 3 and we can obtain the coordinates of the next point, using the same arithmetic (instead of 0, 1 and 2 we will get 3, 4 and 5) and so on, until there are no more elements in the array. The three coordinates are passed into our function and we get a Boolean value as a result. If it&rsquo;s true, we print inside for the current point and otherwise we print outside.</p>
<p>The solution may now be submitted to the judge system at <a href="https://judge.softuni.bg/Contests/310">https://judge.softuni.bg/Contests/310</a></p>
<h2>2.&nbsp;&nbsp; Road Radar</h2>
<p>Write a JS function that determines whether a driver is within the speed limit. You will receive his speed and the area where he&rsquo;s driving. Each area has a different limit: on the <strong>motorway</strong> the limit is <strong>130 </strong>km/h, on the <strong>interstate</strong> the limit is <strong>90</strong>, inside a <strong>city</strong> the limit is <strong>50</strong> and within a <strong>residential </strong>area the limit is <strong>20 </strong>km/h. If the driver is within the limits, your function prints nothing. If he&rsquo;s over the limit however, your function prints the severity of the infraction. For speeds up to <strong>20</strong> km/h over the limit, he&rsquo;s speeding; for speeds up to <strong>40</strong> over the limit, the infraction is <strong>excessive speeding</strong> and for anything else, <strong>reckless driving</strong>.</p>
<p>The <strong>input</strong> comes as an array of elements. The first element is the current speed (as number), the second element is the area where the vehicle is driving.</p>
<p>The <strong>output</strong> should be printed to the console. Note in certain cases there will be no output.</p>
<h3>Examples</h3>
<table width="416">
<tbody>
<tr>
<td width="189">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="189">
<p>[40, city]</p>
</td>
<td width="227">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="189">
<p>[21, residential]</p>
</td>
<td width="227">
<p>speeding</p>
</td>
</tr>
<tr>
<td width="189">
<p>[120, interstate]</p>
</td>
<td width="227">
<p>excessive speeding</p>
</td>
</tr>
<tr>
<td width="189">
<p>[200, motorway]</p>
</td>
<td width="227">
<p>reckless driving</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>We can divide the task in two functions &ndash; one that determines what the current speed limit is, depending on zone, and another which tells us if an infraction is being made, depending on current speed and current limit. Determining the limit is achieved with a <strong>switch</strong> statement on the input:</p>
<p>This function takes a string as an argument and returns a number, depending on what that string is. We can take this directly from the input, pass it to this function and save the return value in a variable. In our second function, we pass the current speed and the limit, which we just saved.</p>
<p>We calculate the difference between the current speed and the limit &ndash; if it&rsquo;s negative or zero, this means the driver is within the rules and we return false, and in any other case, return the infraction as a string and store the result of the operation in a variable.</p>
<p>We can use the fact that JavaScript functions can return different data types and directly use the result we stored in a conditional statement &ndash; if it&rsquo;s <strong>false</strong> (no infraction), do nothing, if it&rsquo;s <strong>truthy</strong> (non-empty string in this case), print the value store in the variable.</p>
<h2>3.&nbsp;&nbsp; Template format</h2>
<p>Write a JS program that receives data about a quiz and prints it formatted as an XML document. The data comes as pairs of question-answer entries. The format of the document should be as follows:</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>XML</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;?xml version="1.0" encoding="UTF-8"?&gt;</p>
<p>&lt;quiz&gt;</p>
<p>&nbsp; &lt;question&gt;</p>
<p>&nbsp;&nbsp;&nbsp; {question text}</p>
<p>&nbsp; &lt;/question&gt;</p>
<p>&nbsp; &lt;answer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; {answer text}</p>
<p>&nbsp; &lt;/answer&gt;</p>
<p>&lt;/quiz&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>The <strong>input</strong> comes as an array of string elements.</p>
<p>The <strong>output</strong> should be printed on the console.</p>
<h3>Examples</h3>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>["Who was the forty-second president of the U.S.A.?",</p>
<p>"William Jefferson Clinton"]</p>
</td>
</tr>
<tr>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;?xml version="1.0" encoding="UTF-8"?&gt;</p>
<p>&lt;quiz&gt;</p>
<p>&nbsp; &lt;question&gt;</p>
<p>&nbsp;&nbsp;&nbsp; Who was the forty-second president of the U.S.A.?</p>
<p>&nbsp; &lt;/question&gt;</p>
<p>&nbsp; &lt;answer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; William Jefferson Clinton</p>
<p>&nbsp; &lt;/answer&gt;</p>
<p>&lt;/quiz&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="680">
<tbody>
<tr>
<td width="680">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>["Dry ice is a frozen form of which gas?",</p>
<p>"Carbon Dioxide",</p>
<p>"What is the brightest star in the night sky?",</p>
<p>"Sirius"]</p>
</td>
</tr>
<tr>
<td width="680">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="680">
<p>&lt;?xml version="1.0" encoding="UTF-8"?&gt;</p>
<p>&lt;quiz&gt;</p>
<p>&nbsp; &lt;question&gt;</p>
<p>&nbsp;&nbsp;&nbsp; Dry ice is a frozen form of which gas?</p>
<p>&nbsp; &lt;/question&gt;</p>
<p>&nbsp; &lt;answer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; Carbon Dioxide</p>
<p>&nbsp; &lt;/answer&gt;</p>
<p>&nbsp; &lt;question&gt;</p>
<p>&nbsp;&nbsp;&nbsp; What is the brightest star in the night sky?</p>
<p>&nbsp; &lt;/question&gt;</p>
<p>&nbsp; &lt;answer&gt;</p>
<p>&nbsp;&nbsp;&nbsp; Sirius</p>
<p>&nbsp; &lt;/answer&gt;</p>
<p>&lt;/quiz&gt;</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; Cooking by Numbers</h2>
<p>Write a JS program that receives a number and a list of five operations. Perform the operations in sequence by starting with the input number and using the result of every operation as starting point for the next. Print the result of every operation in order. The operations can be one of the following:</p>
<ul>
<li>chop &ndash; divide the number by two</li>
<li>dice &ndash; square root of number</li>
<li>spice &ndash; add 1 to number</li>
<li>bake &ndash; multiply number by 3</li>
<li>fillet &ndash; subtract 20% from number</li>
</ul>
<p>The <strong>input</strong> comes as an array of 6 string elements. The first element is your starting point and must be parsed to a number. The remaining 5 elements are the names of operations to be performed.</p>
<p>The <strong>output</strong> should be printed on the console.</p>
<h3>Examples</h3>
<table width="491">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">
<p>[32, chop, chop, chop, chop, chop]</p>
</td>
<td width="113">
<p>16<br /> 8<br /> 4<br /> 2<br /> 1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="491">
<tbody>
<tr>
<td width="378">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="378">[9, dice, spice, chop, bake, fillet]</td>
<td width="113">
<p>3</p>
<p>4</p>
<p>2</p>
<p>6</p>
<p>4.8</p>
</td>
</tr>
</tbody>
</table>
<h2>5.&nbsp;&nbsp; Modify Average</h2>
<p>Write a JS program that modifies a number until the average value of all of its digits is <strong>higher than 5</strong>. In order to modify the number, your program should append a <strong>9</strong> to the end of the number, when the average value of all of its digits is <strong>higher than 5</strong> the program should stop appending. If the number&rsquo;s average value of all of its digits is already <strong>higher than 5</strong>, no appending should be done.</p>
<p>The <strong>input</strong> is a single number.</p>
<p>The <strong>output</strong> should consist of a single number - the final modified number which has an average value of all of its digits <strong>higher than 5</strong>. The <strong>output</strong> should be printed on the console.</p>
<h3>Constraints</h3>
<ul>
<li><strong>The input number will consist of no more than 6 digits.</strong></li>
<li><strong>The input will be a valid number (there will be no leading zeroes).</strong></li>
</ul>
<h3>Examples</h3>
<table width="268">
<tbody>
<tr>
<td width="112">
<p><strong>Input</strong></p>
</td>
<td width="156">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="112">
<p>101</p>
</td>
<td width="156">
<p>1019999</p>
</td>
</tr>
<tr>
<td width="112">
<p>5835</p>
</td>
<td width="156">
<p>5835</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;</strong></p>
<h2>6.&nbsp;&nbsp; Validity Checker</h2>
<p>Write a JS program that receives two points in the format <strong>[x1, y1, x2, y2] </strong>and checks if the distances between each point and the start of the cartesian coordinate system (0, 0) and between the points themselves is <strong>valid</strong>. A distance between two points is considered <strong>valid</strong>, if it is an <strong>integer value</strong>. In case a distance is valid write "<strong>{x1, y1} to {x2, y2} is valid"</strong>, in case the distance is invalid write <strong>"{x1, y1} to {x2, y2} is invalid"</strong>.</p>
<p>The order of comparisons should always be first <strong>{x1, y1}</strong> to <strong>{0, 0}</strong>, then <strong>{x2, y2}</strong> to <strong>{0, 0}</strong> and finally <strong>{x1, y1}</strong> to <strong>{x2, y2}</strong>.</p>
<p>The <strong>input</strong> consists of two points given as an array of numbers.</p>
<p>For each comparison print on the <strong>output</strong> either "<strong>{x1, y1} to {x2, y2} is valid" </strong>if the distance between them is valid, or <strong>"{x1, y1} to {x2, y2} is invalid"</strong>- if it&rsquo;s invalid.</p>
<h3>Examples</h3>
<table width="700">
<tbody>
<tr>
<td width="346">
<p><strong>Input</strong></p>
</td>
<td width="354">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="346">
<p>[3, 0, 0, 4]</p>
</td>
<td width="354">
<p>{3, 0} to {0, 0} is valid</p>
<p>{0, 4} to {0, 0} is valid</p>
<p>{3, 0} to {0, 4} is valid</p>
</td>
</tr>
<tr>
<td width="346">
<p>[2, 1, 1, 1]</p>
</td>
<td width="354">
<p>{2, 1} to {0, 0} is invalid</p>
<p>{1, 1} to {0, 0} is invalid</p>
<p>{2, 1} to {1, 1} is valid</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>7.&nbsp;&nbsp; Treasure Locator</h2>
<p>You will be given a series of coordinates, leading to a buried treasure. Use the map to the right to write a program that locates on which island it is. After you find where all the treasure chests are, compose a list and print it on the console. If a chest is not on any of the islands, print &ldquo;On the bottom of the ocean&rdquo; to inform your treasure-hunting team to bring diving gear. If the location is on the shore (border) of the island, it&rsquo;s still considered to lie inside.</p>
<p>The <strong>input</strong> comes as an array with a variable number of elements that are numbers. Each pair is the coordinates to a buried treasure chest.</p>
<p>The <strong>output</strong> is a list of the locations of every treasure chest, either the name of an island or &ldquo;On the bottom of the ocean&rdquo;, printed on the console.</p>
<p>&nbsp;</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[4, 2, 1.5, 6.5, 1, 3]</p>
</td>
<td width="302">
<p>On the bottom of the ocean</p>
<p>Tonga</p>
<p>Tuvalu</p>
</td>
</tr>
<tr>
<td width="227">
<p>[6, 4]</p>
</td>
<td width="302">
<p>Samoa</p>
</td>
</tr>
</tbody>
</table>
<h2>8.&nbsp;&nbsp; Trip Length</h2>
<p>You will be given the coordinates of 3 points on a 2D plane. Write a program that finds the two shortest segments that connect them (without going back to the starting point). When determining the listing order, use the order with the lowest numerical value (see the figure in the hints for more information).</p>
<p>The <strong>input</strong> comes as an array of 6 numbers. The order is <strong>[x1, y1, x2, y2, x3, y3]</strong>.</p>
<p>The <strong>output</strong> is the return value of your program as a string, representing the order in which the three points must be visited and the final distance between them. See the examples for more info.</p>
<h3>Examples</h3>
<table width="454">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[0, 0, 2, 0, 4, 0]</p>
</td>
<td width="227">
<p>1-&gt;2-&gt;3: 4</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="454">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[5, 1, 1, 1, 5, 4]</p>
</td>
<td width="227">
<p>2-&gt;1-&gt;3: 7</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="454">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="227">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[-1, -2, 3.5, 0, 0, 2]</p>
</td>
<td width="227">
<p>1-&gt;3-&gt;2: 8.154234499766936</p>
</td>
</tr>
</tbody>
</table>
<h3>Hints</h3>
<p>You can find the horizontal and vertical offset between two points by calculating the difference between their coordinates. Use Pythagoras&rsquo; theorem to find the distance.</p>
<p>If more than one shortest paths exist, choose the one with lowest numerical value. For instance, in the figure on the right, 1&agrave;2&agrave;3 is the same distance as 3&agrave;2&agrave;1, but we chose to start at 1, since it&rsquo;s lower than 3. When choosing the second point, we encounter the same issue &ndash; 1&agrave;3&agrave;2 would be the same as 1&agrave;2&agrave;3, but we chose to visit 2 first, because it&rsquo;s lower than 3.</p>
<h2>9.&nbsp;&nbsp; *Radio Crystals</h2>
<p>It&rsquo;s time to put your skills to work for the war effort &ndash; creating management software for a radio transmitter factory. Radios require a finely tuned quartz crystal in order to operate at the correct frequency. The resource used to produce them is quartz ore that comes in big chunks and needs to undergo several processes, before it reaches the desired properties.</p>
<p>You need to write a JS program that monitors the current thickness of the crystal and recommends the next procedure that will bring it closer to the desired frequency. To reduce waste and the time it takes to make each crystal your program needs to complete the process with the least number of operations. Each operation takes the same amount of time, but since they are done at different parts of the factory, the crystals have to be transported and thoroughly washed every time an operation different from the previous must be performed, so this must also be taken into account. When determining the order, always attempt to start from the operation that removes the largest amount of material.</p>
<p>The different operations you can perform are the following:</p>
<ul>
<li>Cut &ndash; cuts the crystal in 4</li>
<li>Lap &ndash; removes 20% of the crystal&rsquo;s thickness</li>
<li>Grind &ndash; removes 20 microns of thickness</li>
<li>Etch &ndash; removes 2 microns of thickness</li>
<li>X-ray &ndash; increases the thickness of the crystal by 1 micron; this operation can only be done once!</li>
<li>Transporting and washing &ndash; removes any imperfections smaller than 1 micron (round down the number); do this after every batch of operations that remove material</li>
</ul>
<p>At the beginning of your program, you will receive a number representing the desired final thickness and a series of numbers, representing the thickness of crystal ore in microns. Process each chunk and print to the console the order of operations and number of times they need to be repeated to bring them to the desired thickness.</p>
<p>The <strong>input</strong> comes as a numeric array with a variable number of elements. The first number is the target thickness and all following numbers are the thickness of different chunks of quartz ore.</p>
<p>The <strong>output</strong> is the order of operation and how many times they are repeated, every operation on a new line. See the examples for more information.</p>
<h3>Examples</h3>
<table width="529">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[1375, 50000]</p>
</td>
<td width="302">
<p>Processing chunk 50000 microns</p>
<p>Cut x2</p>
<p>Transporting and washing</p>
<p>Lap x3</p>
<p>Transporting and washing</p>
<p>Grind x11</p>
<p>Transporting and washing</p>
<p>Etch x3</p>
<p>Transporting and washing</p>
<p>X-ray x1</p>
<p>Finished crystal 1375 microns</p>
</td>
</tr>
</tbody>
</table>
<h4>Explanation</h4>
<p>The operation that would remove the most material is always cutting &ndash; it removes three quarters of the chunk. Starting from 50000, if we perform it twice, we bring the chunk down to 3125. If we cut again, the chunk will be 781.25, which is less than the desired thickness, so we move to the next operation, but we first round down the number (transporting &amp; washing). Next, we lap the chunk &ndash; after three operations, the crystal reaches 1600 microns. One more lapping would take it to 1280, so we move on to the next operation instead. We do the same check with grinding, and finally by etching 2 times, the crystal has reached 1376 microns, which is one more than desired. We don&rsquo;t have an operation which only takes away 1 micron, so instead we etch once more to get to 1374, wash and then x-ray to add 1 micron, which brings us to the desired thickness.</p>
<table width="529">
<tbody>
<tr>
<td width="227">
<p><strong>Input</strong></p>
</td>
<td width="302">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="227">
<p>[1000, 4000, 8100]</p>
</td>
<td width="302">
<p>Processing chunk 4000 microns</p>
<p>Cut x1</p>
<p>Transporting and washing</p>
<p>Finished crystal 1000 microns</p>
<p>Processing chunk 8100 microns</p>
<p>Cut x1</p>
<p>Transporting and washing</p>
<p>Lap x3</p>
<p>Transporting and washing</p>
<p>Grind x1</p>
<p>Transporting and washing</p>
<p>Etch x8</p>
<p>Transporting and washing</p>
<p>Finished crystal 1000 microns</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<h2>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; **DNA Helix</h2>
<p>Write a JS program that prints a DNA helix with length, specified by the user. The helix has a repeating structure, but the symbol in the chain follows the sequence ATCGTTAGGG. See the examples for more information.</p>
<p>The <strong>input</strong> comes as a single number. It represents the length of the required helix.</p>
<p>The <strong>output</strong> is the completed structure, printed on the console.</p>
<h3>Examples</h3>
<table width="402">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="24">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="113">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>4</p>
</td>
<td width="113">
<p>**AT**<br /> *C--G*<br /> T----T<br /> *A--G*</p>
</td>
<td width="76">
<p>10</p>
</td>
<td width="113">**AT**<br /> *C--G*<br /> T----T<br /> *A--G*<br /> **GG**<br /> *A--T*<br /> C----G<br /> *T--T*<br /> **AG**<br /> *G--G*</td>
</tr>
</tbody>
</table>
<h2>&nbsp;</h2>