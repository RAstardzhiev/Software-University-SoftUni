<h1>Problem 4 &ndash; Galactic Elections</h1>
<p><em>Once in a galactic microcycle, a galactic president is chosen. There are many star systems with many planets and even more voters on each planet, so to simplify the process, each system performs and internal election and then sends all of their votes for a single candidate. Even then, the process is lengthy so a software solution is requested of you.</em></p>
<p>Write a JS program that summarizes the results from an election. You will receive an <strong>array of ballots</strong> and each ballot will be an <strong>object</strong> with format:</p>
<p>{</p>
<p>&nbsp; system: String,</p>
<p>&nbsp; candidate: String,</p>
<p>&nbsp; votes: Number</p>
<p>}</p>
<p>The system property is the name of the star system from which the ballot comes, candidate is the name of the candidate for which the votes are cast and votes is the number of votes for said candidate. Go through all of the ballots and store the total votes for each star system per candidate.</p>
<p>After you&rsquo;ve stored the votes, it&rsquo;s time to see who&rsquo;s the winner. For <strong>each star system</strong>, the candidate with the <strong>most votes</strong> in that system, takes it for himself (<strong>wins all of the votes</strong>). When all of the systems have been summarized, you may count how many votes each <strong>remaining</strong> candidate has. <strong>See the examples for details.</strong></p>
<p>If a candidate has <strong>more than</strong> half of all the votes, declare them winner and <strong>print</strong> the message (<strong>3 lines</strong>):</p>
<p><em>&lt;winner name&gt;</em> wins with <em>&lt;number of votes&gt;</em> votes</p>
<p>Runner up: <em>&lt;second place name&gt;</em></p>
<p><em>&lt;list of systems, won by runner up&gt;</em></p>
<p><strong>Order</strong> the systems by number of votes, <strong>descending</strong>. See the examples for formatting details on the list of systems.</p>
<p>It&rsquo;s possible that a <strong>single candidate won all of the systems</strong>, in that case, print the following message (2 lines):</p>
<p><em>&lt;winner name&gt;</em> wins with <em>&lt;number of votes&gt;</em> votes</p>
<p><em>&lt;winner name&gt;</em> wins unopposed!</p>
<p>If nobody got majority, there will be a runoff, so print this message (<strong>single line</strong>):</p>
<p>Runoff between <em>&lt;candidate 1&gt;</em> with <em>&lt;percent&gt;</em>% and <em>&lt;candidate 2&gt;</em> with <em>&lt;percent&gt;</em>%</p>
<p>Print the candidate with more votes first and <strong>round down the percentages in this message</strong>. <strong>See the examples.</strong></p>
<h3>Input</h3>
<p>You will receive an <strong>array of objects</strong> with properties as shown above.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> a message, depending on the outcome of the election, as instructed above.</p>
<h3>Constraints</h3>
<ul>
<li>The input objects will <strong>always be valid</strong></li>
<li>There will always be <strong>at least two</strong> candidates</li>
<li>A system may vote for a single candidate (ballot only for one candidate)</li>
<li>There will never be a tie <strong>within a system</strong></li>
<li>There never be a tie in the <strong>final count</strong> (equal votes for the top two candidates)</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[ { <strong>system</strong>: 'Theta', <strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 10 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', <strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 200 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', <strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 120 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 15 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', <strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 60 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 150 } ]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Space Cow wins with 380 votes</p>
<p>Runner up: Flying Shrimp</p>
<p>Tau: 165</p>
<p>Theta: 10</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>When we collect all the ballots, for system Theta, Flying Shrimp is the only candidate with 10 votes. In system Sigma, Flying Shrimp has 120 votes, while Space Cow has 260. <strong>Space Cow has the most votes in Sigma, so she wins all of the votes for that system (380).</strong> In Tau, Shrimp has 150, Cow 15 &ndash; Flying Shrimp gets all 165.</p>
<p>We&rsquo;ve summarized the systems, so we can count the <strong>final results</strong> &ndash; Flying Shrimp with 175 and Space Cow with 380. 380 is more than half of the total (555), so we declare her winner. At the end, we print all systems that Flying Shrimp won, ordered by number of votes.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[ { <strong>system</strong>: 'Tau', &nbsp;&nbsp;&nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 150 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;&nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 100 },</p>
<p>&nbsp; { <strong>system</strong>: 'Theta', &nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 10 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', &nbsp;&nbsp;<strong>candidate</strong>: 'Space Cow', &nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 200 },</p>
<p>&nbsp; { <strong>system</strong>: 'Sigma', &nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 75 },</p>
<p>&nbsp; { <strong>system</strong>: 'Omicron', <strong>candidate</strong>: 'Flying Shrimp', <strong>votes</strong>: 50 },</p>
<p>&nbsp; { <strong>system</strong>: 'Omicron', <strong>candidate</strong>: 'Octocat', &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 75 } ]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Runoff between Space Cow with 43% and Flying Shrimp with 37%</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Space Cow wins Theta (10) and Sigma (275). Flying Shrimp wins Tau (250). Octocat wins Omicron (125). There is no majority, so we take the two candidates with most votes, and send them to a runoff election. Note all <strong>percentages</strong> are <strong>rounded down</strong>.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="695">
<p><strong>Input</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>[ { <strong>system</strong>: 'Theta', <strong>candidate</strong>: 'Kim Jong Andromeda', <strong>votes</strong>: 10 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Kim Jong Andromeda', <strong>votes</strong>: 200 },</p>
<p>&nbsp; { <strong>system</strong>: 'Tau', &nbsp;&nbsp;<strong>candidate</strong>: 'Flying Shrimp', &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<strong>votes</strong>: 150 } ]</p>
</td>
</tr>
<tr>
<td width="695">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="695">
<p>Kim Jong Andromeda wins with 360 votes</p>
<p>Kim Jong Andromeda wins unopposed!</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>