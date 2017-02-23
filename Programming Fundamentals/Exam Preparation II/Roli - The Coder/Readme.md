<h1>Problem 4. Roli - The Coder</h1>
<p>Roli is really busy with the recently started JS Core and DB Fundamentals modules at SoftUni. She is used to going out with friends on a various events. However, when the times comes, you need to tell her to start coding.</p>
<p>Roli is the organizer of those events, so she needs to <strong>keep track of the unique participants for each event</strong>. She saves the events by '<strong>ID</strong>', which is the <strong>unique code</strong> for each event. <strong>For each ID</strong>, she <strong>keeps the event name and the participants</strong> for it.</p>
<p>She receives request in the following format:</p>
<ul>
<li>{<strong>id</strong>} #{<strong>eventName</strong>} @{<strong>participant1</strong>} @{<strong>participant2</strong>} &hellip; @{<strong>participantN</strong>}</li>
</ul>
<p>If she is given event in an <strong>invalid format </strong>(such as without a hashtag), she <strong>ignores that line of input</strong>. If she is given ID that <strong>already exists </strong>she needs to check if the <strong>eventName</strong> is the same. If it is, she <strong>adds</strong> the <strong>participants</strong> from the <strong>request</strong> to the other registered participants. If the event id exists but the name doesn&rsquo;t, it is invalid and you need to ignore it.</p>
<p>After you receive "<strong>Time for Code</strong>", you need to <strong>print</strong> the results. All events must <strong>be sorted by participant count in descending order and then by alphabetical order</strong>. For each event, the <strong>participants</strong> must be sorted in <strong>alphabetical order</strong>.</p>
<h2>Input / Constrains</h2>
<ul>
<li>Unil you receive &ldquo;Time for Code&rdquo; you will get lines of input in which everything is separated by one or more blank spaces</li>
<li>Until you receive "<strong>Time for Code</strong>", you will be receiving events in the following format:
<ul>
<li>{id} #{eventName} @{participant1} @{participant2} &hellip; @{participantN}</li>
</ul>
</li>
</ul>
<h2>Output</h2>
<ul>
<li>All events must be sorted in <strong>descending</strong> order by participant count and <strong>then by alphabetical order</strong>. For each event you need to print:
<ul>
<li>{eventName} &ndash; {participantCount}</li>
</ul>
</li>
<li>On the next lines you need to print all participants. All participants for an event must be sorted alphabetically.</li>
</ul>
<h2>Examples</h2>
<table width="684">
<tbody>
<tr>
<td width="400">
<p><strong>Input</strong></p>
</td>
<td width="283">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="400">
<p>1 #Beers @roli @trophon @alice</p>
<p>2 #GameDevMeetup @sino @valyo</p>
<p>3 #Karaoke @nakov @royal @ROYAL @ivo</p>
<p>Time for Code</p>
</td>
<td width="283">
<p>Karaoke - 4</p>
<p>@ivo</p>
<p>@nakov</p>
<p>@royal</p>
<p>@ROYAL</p>
<p>Beers - 3</p>
<p>@alice</p>
<p>@roli</p>
<p>@trophon</p>
<p>GameDevMeetup - 2</p>
<p>@sino</p>
<p>@valyo</p>
</td>
</tr>
<tr>
<td width="400">
<p><strong>Input</strong></p>
</td>
<td width="283">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="400">
<p>1 #Beers @roli @trophon @alice</p>
<p>2 #GameDevMeetup @sino @valyo</p>
<p>1 #Beers2 @nakov @royal @ROYAL @ivo</p>
<p>1 #Beers @roli @trophon @alice @sino</p>
<p>3 #Rakia</p>
<p>Time for Code</p>
</td>
<td width="283">
<p>Beers - 4</p>
<p>@alice</p>
<p>@roli</p>
<p>@sino</p>
<p>@trophon</p>
<p>GameDevMeetup - 2</p>
<p>@sino</p>
<p>@valyo</p>
<p>Rakia - 0</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>