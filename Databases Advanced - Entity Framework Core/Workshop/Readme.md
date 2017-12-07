<h1>Lab: Team Builder</h1>
<p>This document defines the <strong>exercise assignments</strong> for the "<a href="https://softuni.bg/courses/databases-advanced-entity-framework">Databases Advanced &ndash; Entity Framework" courses @ Software University</a>.</p>
<h2>Create Code First Model</h2>
<p>Your task is to implement Team Builder console application. The application will consist of <strong>users</strong>, <strong>teams, invitations</strong> and <strong>events</strong>. Each event has several teams participating in it and each team has several users. Any <strong>team member</strong> or <strong>creator</strong> may send <strong>invitation</strong> to other user: let&rsquo;s say we have two teams: <strong>A </strong>and <strong>B</strong> &ndash; and we are <strong>members</strong> of <strong>A</strong> but <strong>not</strong> of <strong>B </strong>&ndash; we can <strong>send invitation</strong> to other users <strong>to join</strong> team<strong> A</strong> <strong>and</strong> we <strong>cannot</strong> send invitations <strong>for</strong> team <strong>B</strong> because we are not simply part of it). The <strong>invitation</strong> <strong>holds</strong> information about the <strong>team</strong> which could be joined and who is the <strong>invited user</strong>, it also contains information if it is <strong>active</strong> or not.</p>
<p>The application consists of the following models:</p>
<p><strong>Here is information about each table:</strong></p>
<p><strong>Users</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="301">
<p><strong>Data Type</strong></p>
</td>
<td width="270">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Unique table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>Username</p>
</td>
<td width="301">
<p>String from 3 to 25 symbols</p>
</td>
<td width="270">
<p>Unique, Required</p>
</td>
</tr>
<tr>
<td width="125">
<p>FirstName</p>
</td>
<td width="301">
<p>String up to 25 symbols</p>
</td>
<td width="270">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>LastName</p>
</td>
<td width="301">
<p>String up to 25 symbols</p>
</td>
<td width="270">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Password</p>
</td>
<td width="301">
<p>String from 6 to 30 symbols</p>
</td>
<td width="270">
<p>Should contain one digit and one uppercase letter, Required</p>
</td>
</tr>
<tr>
<td width="125">
<p>Gender</p>
</td>
<td width="301">
<p>Enumeration</p>
</td>
<td width="270">
<p>Could be: '<em>Male</em>' or '<em>Female</em>'</p>
</td>
</tr>
<tr>
<td width="125">
<p>Age</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>IsDeleted</p>
</td>
<td width="301">
<p>Bool</p>
</td>
<td width="270">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Teams</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="301">
<p><strong>Data Type</strong></p>
</td>
<td width="270">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>Name</p>
</td>
<td width="301">
<p>String up to 25 symbols</p>
</td>
<td width="270">
<p>Unique, Required</p>
</td>
</tr>
<tr>
<td width="125">
<p>Description</p>
</td>
<td width="301">
<p>String up to 32 symbols</p>
</td>
<td width="270">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Acronym</p>
</td>
<td width="301">
<p>String with exactly 3 symbols</p>
</td>
<td width="270">
<p>Must be 3 symbols long, Required</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Events</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="302">
<p><strong>Data Type</strong></p>
</td>
<td>
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="302">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>Name</p>
</td>
<td width="302">
<p>String up to 25 symbols, Unicode</p>
</td>
<td>
<p>Required</p>
</td>
</tr>
<tr>
<td width="125">
<p>Description</p>
</td>
<td width="302">
<p>String up to 250 symbols, Unicode</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>StartDate</p>
</td>
<td width="302">
<p>DateTime in format {dd/MM/yyyy HH:mm}</p>
</td>
<td>
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>EndDate</p>
</td>
<td width="302">
<p>DateTime in format {dd/MM/yyyy HH:mm}</p>
</td>
<td>
<p>Must be after StartDate</p>
</td>
</tr>
<tr>
<td width="125">
<p>CreatorId</p>
</td>
<td width="302">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td>
<p>Relationship with table Users</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Invitations</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="301">
<p><strong>Data Type</strong></p>
</td>
<td width="270">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>InvitedUserId</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Relationship with table Users</p>
</td>
</tr>
<tr>
<td width="125">
<p>TeamId</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Relationship with table Teams</p>
</td>
</tr>
<tr>
<td width="125">
<p>IsActive</p>
</td>
<td width="301">
<p>Boolean</p>
</td>
<td width="270">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p><strong>UserTeams</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="301">
<p><strong>Data Type</strong></p>
</td>
<td width="270">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>UserId</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Relationship with table Users, Unique table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>TeamId</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Relationship with table Teams, Unique table identificator</p>
</td>
</tr>
</tbody>
</table>
<p><strong>TeamEvents</strong></p>
<table width="696">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="301">
<p><strong>Data Type</strong></p>
</td>
<td width="270">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>TeamId</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Relationship with table Teams, Unique table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>EventId</p>
</td>
<td width="301">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="270">
<p>Relationship with table Events, Unique table identificator</p>
</td>
</tr>
</tbody>
</table>
<h3>Application Summary</h3>
<p><strong>User</strong> can <strong>create</strong> <strong>event</strong> or <strong>team</strong> &ndash; becoming their creator. <strong>One</strong> <strong>event</strong> may have <strong>several teams</strong> while <strong>single team</strong> can participate <strong>in multiple events</strong>. <strong>Team</strong> consists of <strong>users</strong> which also can be part of <strong>other teams</strong>.</p>
<p>Anyone from a team can <strong>invite</strong> people to join. Only the <strong>creator</strong> may <strong>remove</strong> <strong>users</strong> or to <strong>disband</strong> the whole <strong>team</strong>.</p>
<p>In order for a team to successfully participate in event &ndash; team&rsquo;s creator must apply for it and later on to be approved by the creator of the event.</p>
<h3>Application Functionality</h3>
<p>Team Builder contains the following functionality:</p>
<ul>
<li><strong>Register</strong><strong>User &lt;username&gt; &lt;password&gt; &lt;repeat-password&gt; &lt;firstName&gt; &lt;lastName&gt; &lt;age&gt; &lt;gender&gt;</strong><strong><br /> </strong>Registers a new user.</li>
</ul>
<table>
<tbody>
<tr>
<td width="151">
<p><strong>Case</strong></p>
</td>
<td width="323">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Success</p>
</td>
<td width="323">
<p>User [username] was registered successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="151">
<p>Username is not valid</p>
</td>
<td width="323">
<p>Username [username] not valid!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Password is not valid</p>
</td>
<td width="323">
<p>Password [password] is not valid!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Age is not in valid&nbsp; format or is non-positive number</p>
</td>
<td width="323">
<p>Age not valid!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Gender is not valid</p>
</td>
<td width="323">
<p>Gender should be either &ldquo;Male&rdquo; or &ldquo;Female&rdquo;!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Passwords do not match</p>
</td>
<td width="323">
<p>Passwords do not match!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Username is taken</p>
</td>
<td width="323">
<p>Username [username] is already taken!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is currently logged in user</p>
</td>
<td width="323">
<p>You should logout first!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<p>*Validation on first/last name is removed for the sake of simplicity &ndash; you are not obligated to perform any validation checks.</p>
<ul>
<li><strong>Login &lt;username&gt; &lt;password&gt;</strong><strong><br /> </strong>Logs a user into the system and keep a reference to it until the &ldquo;<strong>Logout</strong>&rdquo; command is called.</li>
</ul>
<table>
<tbody>
<tr>
<td width="151">
<p><strong>Case</strong></p>
</td>
<td width="324">
<p><strong>Message</strong></p>
</td>
<td width="171">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Success</p>
</td>
<td width="324">
<p>User [username] successfully logged in!</p>
</td>
<td width="171">
<p>None</p>
</td>
</tr>
<tr>
<td width="151">
<p>Either user does not exist or password does not match or user is deleted</p>
</td>
<td width="324">
<p>Invalid username or password!</p>
</td>
<td width="171">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is currently logged in user</p>
</td>
<td width="324">
<p>You should logout first!</p>
</td>
<td width="171">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Logout</strong><strong><br /> </strong>Logs out a user from the application.</li>
</ul>
<table>
<tbody>
<tr>
<td width="151">
<p><strong>Case</strong></p>
</td>
<td width="323">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Success</p>
</td>
<td width="323">
<p>User [username] successfully logged out!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is no user logged in.</p>
</td>
<td width="323">
<p>You should login first!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>DeleteUser<br /> </strong>Deletes currently logged in user and then logs out.</li>
</ul>
<table>
<tbody>
<tr>
<td width="151">
<p><strong>Case</strong></p>
</td>
<td width="323">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Success</p>
</td>
<td width="323">
<p>User [username] was deleted successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is no user logged in.</p>
</td>
<td width="323">
<p>You should login first!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>CreateEvent &lt;name&gt; &lt;description&gt; &lt;startDate&gt; &lt;endDate&gt;<br /> </strong>Creates an event (currently logged user is it&rsquo;s creator). Keep in mind when parsing dates that there should be additional spaces between them.</li>
</ul>
<p><strong>*</strong>There might be several events with the same name. <strong>Always pick the one with the latest start date!<br /> <br /> </strong></p>
<table>
<tbody>
<tr>
<td width="150">
<p><strong>Case</strong></p>
</td>
<td width="324">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="150">
<p>Success</p>
</td>
<td width="324">
<p>Event [eventName] was created successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="150">
<p>Either start date or end date is in invalid format</p>
</td>
<td width="324">
<p>Please insert the dates in format: [dd/MM/yyyy HH:mm]!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="150">
<p>Start date is after end date</p>
</td>
<td width="324">
<p>Start date should be before end date.</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="150">
<p>There is no logged in user</p>
</td>
<td width="324">
<p>You should login first!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>CreateTeam &lt;name&gt; &lt;acronym&gt; &lt;description&gt;<br /> </strong>Creates a team (currently logged user is it&rsquo;s creator). Description is optional.</li>
</ul>
<table>
<tbody>
<tr>
<td width="174">
<p><strong>Case</strong></p>
</td>
<td width="300">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="174">
<p>Success</p>
</td>
<td width="300">
<p>Team [team] successfully created!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="174">
<p>Team does exist</p>
</td>
<td width="300">
<p>Team [team] exists!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="174">
<p>Acronym is not valid</p>
</td>
<td width="300">
<p>Acronym [acronym] not valid!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="174">
<p>There is no logged in user</p>
</td>
<td width="300">
<p>You should login first!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>InviteToTeam &lt;teamName&gt; &lt;username&gt;</strong><strong><br /> </strong>Sends an invite to the specified user to join given team. If the user is actually the creator of the team &ndash; add him/her directly!</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="151">
<p><strong>Case</strong></p>
</td>
<td width="324">
<p><strong>Message</strong></p>
</td>
<td width="174">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Success</p>
</td>
<td width="324">
<p>Team [teamName] invited [username]!</p>
</td>
<td width="174">
<p>None</p>
</td>
</tr>
<tr>
<td width="151">
<p>If the current user is not creator of the team nor part of it or user to invite is alredy a member</p>
</td>
<td width="324">
<p>Not allowed!</p>
</td>
<td width="174">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Either user or team does not exist</p>
</td>
<td width="324">
<p>Team or user does not exist!</p>
</td>
<td width="174">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is an already active invite</p>
</td>
<td width="324">
<p>Invite is already sent!</p>
</td>
<td width="174">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is no logged in user</p>
</td>
<td width="324">
<p>You should login first!</p>
</td>
<td width="174">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AcceptInvite &lt;teamName&gt;</strong><strong><br /> </strong>Checks current user&rsquo;s active invites and <strong>accepts</strong> the one from the team specified.</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="319">
<p><strong>Message</strong></p>
</td>
<td width="174">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="319">
<p>User [username] joined team [teamName]!</p>
</td>
<td width="174">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Team does not exist</p>
</td>
<td width="319">
<p>Team [teamName] not found!</p>
</td>
<td width="174">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>There is no invite from that team</p>
</td>
<td width="319">
<p>Invite from [teamName] is not found!</p>
</td>
<td width="174">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>There is no logged in user</p>
</td>
<td width="319">
<p>You should login first!</p>
</td>
<td width="174">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>DeclineInvite &lt;teamName&gt;<br /> </strong>Checks current user&rsquo;s active invites and <strong>declines</strong> the one from the team specified.</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="319">
<p><strong>Message</strong></p>
</td>
<td width="174">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="319">
<p>Invite from [teamName] declined.</p>
</td>
<td width="174">
<p>None</p>
</td>
</tr>
<tr>
<td colspan="3" width="648">
<p><em>*Look in above command to see other cases.</em></p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>KickMember &lt;teamName&gt; &lt;username&gt;</strong><strong><br /> </strong>Removes specified user member from given team. Only the creator of the team can kick other members.</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="335">
<p><strong>Message</strong></p>
</td>
<td width="158">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="335">
<p>User [username] was kicked from [teamName]!</p>
</td>
<td width="158">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Team does not exist</p>
</td>
<td width="335">
<p>Team [teamName] not found!</p>
</td>
<td width="158">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not exist</p>
</td>
<td width="335">
<p>User [username] not found!</p>
</td>
<td width="158">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>User is not a member in team</p>
</td>
<td width="335">
<p>User [username] is not a member in [teamName]!</p>
</td>
<td width="158">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Current user is not creator of the team</p>
</td>
<td width="335">
<p>Not allowed!</p>
</td>
<td width="158">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="155">
<p>User to be kicked is the creator of the team</p>
</td>
<td width="335">
<p>Command not allowed. Use DisbandTeam instead.</p>
</td>
<td width="158">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="155">
<p>There is no logged in user</p>
</td>
<td width="335">
<p>You should login first!</p>
</td>
<td width="158">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Disband &lt;teamName</strong><strong>&gt;<br /> </strong>Deletes given team. Allowed for the team&rsquo;s creator only.</li>
</ul>
<p><strong>&nbsp;</strong></p>
<table width="648">
<tbody>
<tr>
<td width="151">
<p><strong>Case</strong></p>
</td>
<td width="324">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Success</p>
</td>
<td width="324">
<p>[teamName] has disbanded!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="151">
<p>Team does not exist</p>
</td>
<td width="324">
<p>Team [teamName] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Current user is not creator of the team</p>
</td>
<td width="324">
<p>Not allowed!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is no logged in user</p>
</td>
<td width="324">
<p>You should login first!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AddTeamTo &lt;eventName&gt; &lt;teamName</strong><strong>&gt;<br /> </strong>Adds given team for event specified. If there are more than one events with same name pick the latest start date.</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="151">
<p><strong>Case</strong></p>
</td>
<td width="324">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="151">
<p>Success</p>
</td>
<td width="324">
<p>Team [teamName] added for [eventName]!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="151">
<p>Event does not exist</p>
</td>
<td width="324">
<p>Event [eventName] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Team does not exist</p>
</td>
<td width="324">
<p>Team [teamName] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Current user is not creator of the event</p>
</td>
<td width="324">
<p>Not allowed!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="151">
<p>Team is already added to event</p>
</td>
<td width="324">
<p>Cannot add same team twice!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="151">
<p>There is no logged in user</p>
</td>
<td width="324">
<p>You should login first!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>ShowEvent &lt;eventName&gt;<br /> </strong>Shows details for given event.</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="152">
<p><strong>Case</strong></p>
</td>
<td width="326">
<p><strong>Message</strong></p>
</td>
<td width="170">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>Success</p>
</td>
<td width="326">
<p>[eventName] [eventStartDate] [eventEndDate]</p>
<p>[description]</p>
<p>Teams:</p>
<p>-[teamName]</p>
<p>&hellip;</p>
</td>
<td width="170">
<p>None</p>
</td>
</tr>
<tr>
<td width="152">
<p>Event does not exist</p>
</td>
<td width="326">
<p>Event [eventName] not found!</p>
</td>
<td width="170">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>ShowTeam &lt;teamName&gt;<br /> </strong>Show details about given team.</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="152">
<p><strong>Case</strong></p>
</td>
<td width="326">
<p><strong>Message</strong></p>
</td>
<td width="170">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>Success</p>
</td>
<td width="326">
<p>[teamName] [teamAcronym]</p>
<p>Members:</p>
<p>--[username1]</p>
<p>&hellip;</p>
<p>--[usernameN]</p>
</td>
<td width="170">
<p>None</p>
</td>
</tr>
<tr>
<td width="152">
<p>Team does not exist</p>
</td>
<td width="326">
<p>Team [teamName] not found!</p>
</td>
<td width="170">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Exit<br /> </strong>Exits application.</li>
</ul>
<table width="648">
<tbody>
<tr>
<td width="152">
<p><strong>Case</strong></p>
</td>
<td width="326">
<p><strong>Message</strong></p>
</td>
<td width="170">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>Success</p>
</td>
<td width="326">
<p><em>None</em></p>
</td>
<td width="170">
<p>None</p>
</td>
</tr>
</tbody>
</table>
<p>If a command&rsquo;s name is <strong>different</strong> from any of the commands above, throw a NotSupportedException with message: &ldquo;Command [commandName] not valid!&rdquo;.</p>
<p>If format of the command is not valid (invalid number or arguments) throw FormatException with message: &ldquo;Invalid arguments count!&rdquo;</p>
<h3>Examples</h3>
<table width="714">
<tbody>
<tr>
<td width="384">
<p><strong>Input</strong></p>
</td>
<td width="330">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="384">
<p>RegisterUser johny j0hny j0hny John Smith 22 Male</p>
<p>RegisterUser johny Inval1d Inval1d John Smith 22 Male</p>
<p>Login johny Invalid</p>
<p>Login johny Inval1d</p>
<p>Logout</p>
<p>Logout j0hny</p>
<p>Login johny Inval1d</p>
<p>DeleteUser</p>
<p>Logout</p>
<p>Login johny Inval1d</p>
<p>Exit</p>
</td>
<td width="330">
<p>Password j0hny not valid!</p>
<p>User johny was registered successfully!</p>
<p>Invalid username or password!</p>
<p>User johny successfully logged in!</p>
<p>User johny successfully logged out!</p>
<p>Invalid arguments count!</p>
<p>User johny successfully logged in!</p>
<p>User johny was deleted successfully!</p>
<p>You should login first!</p>
<p>Invalid username or password!</p>
</td>
</tr>
<tr>
<td width="384">
<p>RegisterUser daniel Dan123 Dan123 Daniel Trevor 22 MMale</p>
<p>RegisterUser daniel Dan123 Dan123 Daniel Trevor 22 Male</p>
<p>Login daniel Dan123</p>
<p>CreateEvent TEDexSofia Inovation 01-01-2012 12:00 02-01-2012 22:00</p>
<p>CreateEvent TEDexSofia Inovation 01/01/2012 12:00 02/01/2012 22:00</p>
<p>CreateTeam Band BND</p>
<p>CreateTeam BitColns BCS</p>
<p>AddTeamTo TEDexSofia Band</p>
<p>AddTeamTo TEDexSofia BCS</p>
<p>AddTeamTo TEDexSofia Band</p>
<p>AddTeamTo TEDexSofia BitColns</p>
<p>ShowEvent TEDexSofia</p>
<p>Exit</p>
</td>
<td width="330">
<p>Gender should be either &ldquo;Male&rdquo; or &ldquo;Female&rdquo;!</p>
<p>User daniel was registered successfully!</p>
<p>User daniel successfully logged in!</p>
<p>Please insert the dates in format: [dd/MM/yyyy HH:mm]!</p>
<p>Event TEDexSofia was created successfully!</p>
<p>Team Band successfully created!</p>
<p>Team BitColns successfully created!</p>
<p>Team Band added for TEDexSofia!</p>
<p>Team BCS not found!</p>
<p>Cannot add same team twice!</p>
<p>Team BitColns added for TEDexSofia!</p>
<p>TEDexSofia 01/01/2012 12:00 02/01/2012 22:00</p>
<p>Inovation</p>
<p>Teams:</p>
<p>-Band</p>
<p>-BitColns</p>
</td>
</tr>
<tr>
<td width="384">
<p>RegisterUser gordon Ham123 Ham123 Gordon Hamilton -2 Male</p>
<p>RegisterUser gordon Ham123 Ham123 Gordon Hamilton 32 Male</p>
<p>RegisterUser terrydom Terry123 Terry123 Terry Molina 32 Female</p>
<p>Login gordon Ham123</p>
<p>CreateEvent CrackIT ITHardware 22/10/2013 12:00 22/10/2013 22:00</p>
<p>CreateEvent CrackIT ITHard 13/08/2015 12:00 15/08/2015 22:00</p>
<p>CreateTeam Crackers CKS</p>
<p>CreateTeam Balder BLD</p>
<p>InviteToTeam Crackers terry-dom</p>
<p>InviteToTeam Crackers terrydom</p>
<p>InviteToTeam Balder terrydom</p>
<p>Logout</p>
<p>Login terrydom Terry123</p>
<p>AcceptInvite CrackIT</p>
<p>AcceptInvite Crackers</p>
<p>DeclineInvite Balder</p>
<p>Disband Balder</p>
<p>Logout</p>
<p>Login gordon Ham123</p>
<p>ShowTeam Balder</p>
<p>Disband Balder</p>
<p>ShowTeam Crackers</p>
<p>KickMember Crackers terry-dom</p>
<p>KickMember Crackers terrydom</p>
<p>AddTeamTo CrackIT Crackers</p>
<p>ShowEvent CrackIT</p>
<p>Exit</p>
</td>
<td width="330">
<p>Age not valid!</p>
<p>User gordon was registered successfully!</p>
<p>User terrydom was registered successfully!</p>
<p>User gordon successfully logged in!</p>
<p>Event CrackIT was created successfully!</p>
<p>Event CrackIT was created successfully!</p>
<p>Team Crackers successfully created!</p>
<p>Team Balder successfully created!</p>
<p>Team or user does not exist!</p>
<p>Team Crackers invited terrydom!</p>
<p>Team Balder invited terrydom!</p>
<p>User gordon successfully logged out!</p>
<p>User terrydom successfully logged in!</p>
<p>Team CrackIT not found!</p>
<p>User terrydom joined team Crackers!</p>
<p>Invite from Balder declined.</p>
<p>Not allowed!</p>
<p>User terrydom successfully logged out!</p>
<p>User gordon successfully logged in!</p>
<p>Balder BLD</p>
<p>Members:</p>
<p>Balder has disbanded!</p>
<p>Crackers CKS</p>
<p>Members:</p>
<p>--terrydom</p>
<p>User terry-dom not found!</p>
<p>User terrydom was kicked from Crackers!</p>
<p>Team Crackers added for CrackIT!</p>
<p>CrackIT 13/08/2015 12:00 15/08/2015 22:00</p>
<p>ITHard</p>
<p>Teams:</p>
<p>-Crackers</p>
</td>
</tr>
</tbody>
</table>
<h2>Configure Models and Relations</h2>
<h3>Create Entity Classes</h3>
<p>Let&rsquo;s start with creating a simple blank solution:</p>
<p>Now let&rsquo;s start with creating project for our models. Create Class Library project named TeamBuilder.Models:</p>
<p>Inside the models&rsquo; project create <strong>empty</strong> classes for every independent entity (including <strong>join entities</strong>). In the end, you should have something like this:</p>
<p>Let&rsquo;s start with defining properties for our models, the first one is the User:</p>
<p>However for the MinLength attribute we will have to reference the System.ComponentModel.DataAnnotations package for our project.</p>
<p>We will use EntityTypeConfiguration class for any relation configuration etc. Talking about relations? Let&rsquo;s add all navigation properties for the <strong>User</strong> entity:</p>
<p>As you can see we have different collections (some with the same model).</p>
<p>One last step for the User model &ndash; <strong>initialize</strong> all the above <strong>collections</strong> in the constructor:</p>
<p>Now we are done with our User, let&rsquo;s continue with our Event:</p>
<p>So what we left to configure is the Invitation and the Team models. Well it&rsquo;s up to you to do it but here is small hint on the Invitation model &ndash; make Invitation <strong>initially active</strong> (set this.IsActive = true):</p>
<p>The Team will have reference to it&rsquo;s <strong>creator</strong>, <strong>members</strong>, <strong>events</strong> which the team is participating and collection of <strong>invitations</strong> send from any member (or creator) of the team.</p>
<h3>Set up Entity Relations</h3>
<p>Now let&rsquo;s move on the next part &ndash; creating our data model alongside with configuration of the relations.</p>
<p>Create a new Class Library project called TeamBuilder.Data. In it, delete the generated class &rdquo;Class1.cs&rdquo; and add a new DbContext<strong> class</strong>. Name it TeamBuilderContext. Make sure to install Microsoft.EntityFrameworkCore.SqlServer package beforehand.</p>
<p>When you&rsquo;re done, your <strong>project structure</strong> should look like this:</p>
<p>Make sure to reference TeamBuilder.Models project to TeamBuilder.Data:</p>
<p>Now go to TeamBuilderContext.cs file and reference all models that we have already created:</p>
<p>Now in the TeamBuilder.Data project add new folder named <strong>Configuration</strong> &ndash; in it we will put all model configurations:</p>
<p>Now in it, let&rsquo;s create a UserConfiguration class &ndash; make that class inherit (ouch) EntityTypeConfiguration&lt;User&gt;:</p>
<p>Now let&rsquo;s configure the simple properties of the User model:</p>
<p>Now let&rsquo;s start setting up the <strong>relations</strong>. First begin with created <strong>Teams/Events</strong>:</p>
<p>This will set up the one-to-many relation between <strong>User-Team</strong> and <strong>User-Event</strong>.</p>
<p><strong>User-Invitation</strong> relation:</p>
<p>We will need one more configuration class before moving on &ndash; it will be EventConfiguration:</p>
<p>Before we move on to configuring these relations in the OnModelCreating method, let&rsquo;s create <strong>two more classes</strong> which will configure our <strong>many-to-many</strong> relations:</p>
<p>EventTeamConfiguration.cs:</p>
<p>UserTeamConfiguration.cs:</p>
<p>Now, let&rsquo;s go to TeamBuilderContext.cs, override the <strong>OnModelCreating</strong> method and include all the configurations in the model builder:</p>
<p>We are done with setting up the relations &ndash; what&rsquo;s left is to configure the other models and the additional constraints (like .IsRequired(), .HasMaxLength() and so on). This part is left to you.😊</p>
<p>Reminder: add those configurations in the <strong>ModelBuilder</strong> as well.</p>
<h3>Configure Connection String</h3>
<p>We&rsquo;ve set up almost everything. All that&rsquo;s left is to tell Entity Framework Core which <strong>SQL Server instance</strong> and <strong>database</strong> to target.</p>
<p>Create a new class, called ConnectionConfiguration.cs:</p>
<p>Inside it, define your connection string:</p>
<p>Then, in your TeamBuilderContext class, override the OnConfiguring method:</p>
<h2>Define Application Structure</h2>
<p>Great, we have created the models and their relations. Next, we have to start implementing the console application. Create new Console Application project named TeamBuilder.App. And it will have the following hierarchy:</p>
<p>We will use the so called <strong>Command Pattern</strong>, used by some kind of <strong>Engine</strong> class. Every command may use <strong>helper methods</strong> and <strong>classes</strong>.</p>
<p>Rename <strong>Program.cs</strong> to <strong>Application.cs</strong>.</p>
<p>Reference the TeamBuilder.App to Teambuilder.Data and TeamBuilder.Models as well.</p>
<h2>Implement Utilities</h2>
<p>Before we go to implementing the <strong>core logic</strong> of the application, let&rsquo;s write some <strong>helper methods</strong> which will help us later.</p>
<p>Create a <strong>public static class Constants</strong>. Inside of it &ndash; there will be several <strong>constants</strong> for performing <strong>validation checks</strong> or even <strong>error messages</strong>. For the sake of simplicity, you won&rsquo;t need to implement this one yourself, it&rsquo;s ready to copy-paste:</p>
<table width="684">
<tbody>
<tr>
<td width="684">
<p>public static class Constants</p>
<p>{</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const int MinUsernameLength = 3;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const int MaxUsernameLength = 25;</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const int MaxFirstNameLength = 25;</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const int MaxLastNameLength = 25;</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const int MinPasswordLength = 6;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const int MaxPasswordLength = 30;</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string DateTimeFormat = "dd/MM/yyyy HH:mm";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static class ErrorMessages</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Common error messages.</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string InvalidArgumentsCount = "Invalid arguments count!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string LogoutFirst = "You should logout first!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string LoginFirst = "You should login first!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string TeamOrUserNotExist = "Team or user does not exist!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string InviteIsAlreadySent = "Invite is already sent!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string NotAllowed = "Not allowed!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string TeamNotFound = "Team {0} not found!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string UserNotFound = "User {0} not found!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string EventNotFound = "Event {0} not found!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string InviteNotFound = "Invite from {0} is not found!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string NotPartOfTeam = "User {0} is not a member in {1}!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string CommandNotAllowed = "Command not allowed. Use {0} instead.";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string CannotAddSameTeamTwice = "Cannot add same team twice!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // User error messages.</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string UsernameNotValid = "Username {0} not valid!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string PasswordNotValid = "Password {0} not valid!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string PasswordDoesNotMatch = "Passwords do not match!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string AgeNotValid = "Age not valid!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string GenderNotValid = "Gender should be either &ldquo;Male&rdquo; or &ldquo;Female&rdquo;!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string UsernameIsTaken = "Username {0} is already taken!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string UserOrPasswordIsInvalid = "Invalid username or password!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string InvalidDateFormat =</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "Please insert the dates in format: [dd/MM/yyyy HH:mm]!";</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Team error messages.</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string InvalidAcronym = "Acronym {0} not valid!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public const string TeamExists = "Team {0} exists!";</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<p>Now add new class called <strong>Check.cs</strong>. It will have one simple method in it which will check if array&rsquo;s length is equal to expected amount:</p>
<p>You may add other checker methods here if you want (make sure they are <strong>static</strong> though).</p>
<p>One last helper named CommandHelper before we continue with our core logic. The helper class will make queries to the database checking whether certain things <strong>exist</strong> (for example - check if a <strong>town exists</strong> by a given <strong>town name</strong> and so on).</p>
<p>It will contain the following methods:</p>
<ul>
<li><strong>bool IsTeamExisting</strong>(<strong>string</strong> <strong>teamName</strong>)</li>
<li><strong>bool IsUserExisting</strong>(<strong>string</strong> <strong>username</strong>)</li>
<li><strong>bool IsInviteExisting</strong>(<strong>string</strong> <strong>teamName</strong>, <strong>User</strong> <strong>user</strong>)</li>
<li><strong>bool IsUserCreatorOfTeam</strong>(<strong>string</strong> <strong>teamName</strong>, <strong>User</strong> <strong>user</strong>)</li>
<li><strong>bool IsUserCreatorOfEvent</strong>(<strong>string</strong> <strong>eventName</strong>, <strong>User</strong> <strong>user)</strong></li>
<li><strong>bool IsMemberOfTeam</strong>(<strong>string</strong> <strong>teamName</strong>, <strong>string</strong> <strong>username</strong>)</li>
<li><strong>bool IsEventExisting</strong>(<strong>string</strong> <strong>eventName</strong>)</li>
</ul>
<p>Let&rsquo;s implement those one by one:</p>
<p>Here is how the IsUserExisting() should be implemented:</p>
<p>And here&rsquo;s how the IsInviteExisting() method should be implemented:</p>
<p>* Note that we are using the <strong>user&rsquo;s</strong> <strong>Id</strong>, keep that in mind when passing the <strong>user</strong> to that method (they should already be loaded from the database).</p>
<p>Here&rsquo;s how to implement the IsMemberOfTeam() method:</p>
<p>It is your turn to implement IsEventExisting(), IsUserCreatorOfEvent()and IsUserCreatorOfTeam().</p>
<p>After all you should have three classes in your Utilities folder:</p>
<p>We are <a href="https://media.giphy.com/media/1bHdnX1QMeQTe/giphy.gif">done</a> with this section.</p>
<h2>Implement Core Structure</h2>
<p>Our application will rely on three major elements: Engine, CommandDispatcher and Commands bundle classes.</p>
<p>First we will take on the Engine class. In the <strong>Core</strong> folder add new Engine.cs class with simple Run() method:</p>
<p>Inside the run method create new <strong>endless loop</strong> inside that loop put <strong>try-catch block</strong>:</p>
<p>Note that inside the exception we get the base exception (the initial exception) and we print it on the console.</p>
<p>We have a neat application here, but it <strong>does not do anything</strong>. We have to make it<strong> parse input</strong> from the <strong>console</strong>. Then, based on the <strong>input</strong>, find a <strong>specific command</strong> and <strong>execute</strong> it.&nbsp; The <strong>result</strong> of the command should be <strong>printed back</strong> on the <strong>console</strong>.</p>
<p>For this part, we will need to make a CommandDispatcher class. Its task is to <strong>parse the input</strong>, <strong>find</strong> the specified <strong>command</strong> (<strong>if any</strong>) and <strong>execute</strong> that command while <strong>giving the command the input</strong> from the user.</p>
<p>Create a CommandDispatcher class in <strong>Core</strong> folder. <strong>Make</strong> one <strong>method</strong> which <strong>receives string</strong> and <strong>returns string</strong> called Dispatch():</p>
<p>Now <strong>split</strong> the <strong>input</strong> (split by any whitespace character), <strong>take</strong> the <strong>first</strong> <strong>argument</strong> as the name of the command and create new array (or <strong>overwrite</strong> the old one) which will have all other arguments from the input except the <strong>name</strong> of the command. Something like this:</p>
<p>Now, write a <strong>switch case</strong> on the <strong>command name</strong> and set the default behavior to <strong>throw an exception</strong>:</p>
<p>Now that we have configured the basic logic turn back to the <strong>Engine</strong> class.</p>
<p>Add new private field of CommandDispatcher which must be initialized in the constructor:</p>
<p>Now use it in the Run() method:</p>
<p>We are done with our Engine class for now. Let&rsquo;s instantiate in our Application:</p>
<p>Let&rsquo;s create one simple command. Inside the <strong>Commands</strong> folder create new ExitCommand class with <br /> Execute(string[] inputArgs) method which returns string:</p>
<p>The function must check if there are any input arguments and throw exception if there are or else to exit the program:</p>
<p>One last thing before we move on. Include that command in the CommandDispatcher:</p>
<p>Set current project as start up project, check for any errors and if there are not &ndash; start the program.</p>
<p>If everything is fine, the result should be like the one above.</p>
<h2>Implement Base Logic</h2>
<p>In this part we will take on implementing: RegisterUser, Login, Logout and DeleteUser.</p>
<p>First things first &ndash; create a new command class, named RegisterUserCommand. Again, make an Execute method just like the one we created in the ExitCommand:</p>
<p>We have several cases here so go back to the <a href="#_Application_Functionality">Application Functionality</a> section and see how the command should behave.</p>
<p>Now after that we know what the command is expected to do is time to put some code to work:</p>
<p>Note that every message for the exception is taken from our static helper class.</p>
<p>There are some more validations on the input:</p>
<p>We are almost done with validation, we have to check if the given username is taken and if not to register the new user:</p>
<p>*Note that we are using the CommandHelper class to make the check.</p>
<p>Here is how we can the RegisterUser method may look like:</p>
<p>After we are done come back to the command dispatcher and add new case:</p>
<p>Start the application and run sample register user command(take one from the <a href="#_Examples">Examples</a> section). Something like this should happen:</p>
<p>See if the user is really saved in the database. You can play around with the corner cases if you want.</p>
<p>The next two commands to implement (Login and Logout) require an additional helper class which will have the logic behind authenticating a user in our application.</p>
<p>In the Core folder, add a new class - AuthenticationManager. It consists of the following functionallities:</p>
<ul>
<li>void Login(User user) &ndash; saves given user as logged user until logout or exit of the application</li>
<li>void Logout() &ndash; logs out currently logged in user, if there is none should throw exception (use the method below)</li>
<li>void Authorize() &ndash; throws InvalidOperationException if there is no logged in user</li>
<li>bool IsAuthenticated() &ndash; returns true if there is logged in user else returns false</li>
<li>User GetCurrentUser() &ndash; gets currently logged in user if there is not throws exception</li>
</ul>
<p>Let&rsquo;s take a look at how the Authorize() method might look like:</p>
<p>Where current user is private static <strong>field</strong>:</p>
<p>Other methods are left to you to implement them.</p>
<p>Now we are done with our AuthenticationManager (sort of). Let&rsquo;s implement Login and Logout. Create LoginCommand first:</p>
<p>Again go to <a href="#_Application_Functionality">Application Functionality</a> section and see the cases defined there.</p>
<p>First check given arguments count then if there is currently logged in user:</p>
<p>If there is no logged in user try to find one based on the input given. If you don&rsquo;t find one return null. Something like this:</p>
<p>If you wonder what&rsquo;s behind GetUserByCredentials:</p>
<p>*Hint: use .FirstOrDefault()</p>
<p>So we finished implementing the login command, now let&rsquo;s create LogoutCommand:</p>
<p>Now go back to the CommandDispatcher and cases for login and logout:</p>
<p>Start the application again and try to test it with some of the <a href="#_Examples">Examples</a>:</p>
<p>If everything is all right something like this should be displayed.</p>
<p>One last thing before we finish up this section &ndash; the DeleteUserCommand:</p>
<p>Now for one last <a href="http://cdn.niketalk.com/5/50/900x900px-LL-506d59bf_not-this-shit-again_zpsb4456328.jpeg">time</a> go to the CommandDispatcher and add <strong>case</strong> for this command.</p>
<p>After doing that you are fully capable of testing the first example given in the <a href="#_Examples">Examples</a> section.</p>
<p>Run the program, insert the input and something like this should happen:</p>
<p>And for the next part all you have to do is&hellip; relax. Chill buddy, grab a beer, talk to somebody &ndash; you don&rsquo;t need that application to build a social team around you 😉.</p>