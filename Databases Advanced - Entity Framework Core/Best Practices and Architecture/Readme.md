<h1>Exercises: Best Practices and Architecture</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h1>Best Practices and Architecture</h1>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Photo Share System</h2>
<p>You are given a project <a href="http://svn.softuni.org/admin/svn/DB-Fundamentals/DB-Advanced-EntityFramework/Feb-2017/08.%20DB-Advanced-EntityFramework-Best%20Practices-and-Architecture/08.%20DB-Advanced-EntityFramework-Best-Practices-and-Architecture-PhotoShare-Skeleton.zip">skeleton</a> of a <strong>Photo Sharing System</strong>. Take a look at it to get more familiar with that project. &nbsp;The database is modeled by code first approach and the models are fine (in other words there is nothing to modify in PhotoShare.Models project).</p>
<p>But the other project PhotoShare.Client is poorly written. Your task is to <strong>improve the architecture of the project.</strong> Seed some data in the database.</p>
<p>Then <strong>implement the missing commands</strong> by the hints given in each command class and <strong>fix any bugs</strong> in the already implemented code.</p>
<h3>System functionality</h3>
<p>The photo share system contains the following commands:</p>
<ul>
<li><strong>Register</strong><strong>User &lt;username&gt; &lt;password&gt; &lt;repeat-password&gt; &lt;email&gt;<br /> </strong>Registers a new user.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>User [username] was registered successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Passwords do not match</p>
</td>
<td width="334">
<p>Passwords do not match!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Username is taken</p>
</td>
<td width="334">
<p>Username [username] is already taken!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<p>Any other validation is already implemented and it should stay as is.</p>
<ul>
<li><strong>AddTown &lt;town Name&gt; &lt;country Name&gt;</strong></li>
</ul>
<p>Adds new&nbsp; town. Town names must be unique.</p>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Town [town] was added successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Town already exists</p>
</td>
<td width="334">
<p>Town [town] was already added!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<p>Any other validation is already implemented and it should stay as is.</p>
<ul>
<li><strong>ModifyUser &lt;username&gt; &lt;property&gt; &lt;new value&gt;<br /> </strong>Modifies current user.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>User [user] [property] is [value].</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not exist</p>
</td>
<td width="334">
<p>User [username] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Property not found</p>
</td>
<td width="334">
<p>Property [property] not supported!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Value not valid for that property</p>
</td>
<td width="334">
<p>Value [value] not valid.</p>
<p>[DetailedMessage]</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>The above command may be executed in the following formats:</p>
<p>ModifyUser &lt;username&gt; Password &lt;NewPassword&gt;</p>
<ul>
<li>Password must contain at least one lowercase letter and digit. If not:
<ul>
<li>Detailed Message - &ldquo;Invalid Password&rdquo;</li>
</ul>
</li>
</ul>
<p>ModifyUser &lt;username&gt; BornTown &lt;newBornTownName&gt;</p>
<ul>
<li>Town must exist in database. If not:
<ul>
<li>Detailed Message &ndash; &ldquo;Town [town] not found!&rdquo;</li>
</ul>
</li>
</ul>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ModifyUser &lt;username&gt; CurrentTown &lt;newCurrentTownName&gt;</p>
<ul>
<li>Town must exist in database. If not:
<ul>
<li>Detailed Message &ndash; &ldquo;Town [town] not found!&rdquo;</li>
</ul>
</li>
</ul>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Any other format different than from all the above formats is invalid.</p>
<ul>
<li><strong>DeleteUser &lt;username&gt;<br /> </strong>Deletes a user.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>User [username] was deleted successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not exist</p>
</td>
<td width="334">
<p>User [username] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>User is already deleted</p>
</td>
<td width="334">
<p>User [username] is already deleted!</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AddTag &lt;tag&gt;<br /> </strong>Adds a tag. Tag names should be unique.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Tag [tag] was added successfully!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Tag already exists</p>
</td>
<td width="334">
<p>Tag [tag] exists!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<p>Tag validation is already implemented and should stay as is.</p>
<ul>
<li><strong>CreateAlbum &lt;username&gt; &lt;albumTitle&gt; &lt;BgColor&gt; &lt;tag1&gt; &lt;tag2&gt;...&lt;tagN&gt;<br /> </strong>Adds an album. Album names should be unique.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Album [Album] successfully created!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not exist</p>
</td>
<td width="334">
<p>User [username] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Album does exist</p>
</td>
<td width="334">
<p>Album [album] exists!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Background color does not exist</p>
</td>
<td width="334">
<p>Color [color] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>If any tag is not found in database</p>
</td>
<td width="334">
<p>Invalid tags!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AddTagTo &lt;album&gt; &lt;tag&gt;<br /> </strong>Adds a tag.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Tag [tag] added to [album]!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Album or tag does not exist</p>
</td>
<td width="334">
<p>Either tag or album do not exist!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AddFriend &lt;username1&gt; &lt;username2&gt;<br /> </strong>The first user adds the second one as a <a href="http://orig13.deviantart.net/006e/f/2013/297/c/6/lol_amumu_by_enzanblues456-d6rnrta.jpg">friend</a>. :)</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Friend [username2] added to [username1]</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Any of the users do not exist.</p>
</td>
<td width="334">
<p>[user*] not found!<br /> <em>*Pick the first not existing possible user</em></p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>They are already friends</p>
</td>
<td width="334">
<p>[username2] is already a friend to [username1]</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>AcceptFriend &lt;username1&gt; &lt;username2&gt;<br /> <br /> </strong></li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>[username1] accepted [username2] as a friend</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Any of the users do not exist.</p>
</td>
<td width="334">
<p>[user*] not found!<br /> <em>*Pick the first not existing possible user</em></p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>They are already friends</p>
</td>
<td width="334">
<p>[username2] is already a friend to [username1]</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
<tr>
<td width="155">
<p>There is no such friend request</p>
</td>
<td width="334">
<p>[username2] has not added [username1] as a friend</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>ListFriends &lt;username&gt;<br /> </strong>List usernames of all friends for given user sorted alphabetically.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Friends:</p>
<p>-[username1]</p>
<p>&hellip;</p>
<p>-[usernameN]</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not have any friends.</p>
</td>
<td width="334">
<p>No friends for this user. :(</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not exist</p>
</td>
<td width="334">
<p>User [user] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>ShareAlbum &lt;albumId&gt; &lt;username&gt; &lt;permission&gt;<br /> </strong>Makes specified user to be part of given album.</li>
</ul>
<table width="680">
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="352">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="352">
<p>Username [user] added to album [album] ([permission])</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Album does not exist</p>
</td>
<td width="352">
<p>Album [albumId] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>User does not exist</p>
</td>
<td width="352">
<p>User [user] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>Permission not valid</p>
</td>
<td width="352">
<p>Permission must be either &ldquo;Owner&rdquo; or &ldquo;Viewer&rdquo;!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>UploadPicture &lt;albumName&gt; &lt;pictureTitle&gt; &lt;pictureFilePath&gt;<br /> </strong>Creates picture and atteches it to specified album</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Picture [picture] added to [album]!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Album does not exist</p>
</td>
<td width="334">
<p>Album [Album] not found!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Exit<br /> </strong>Exits application.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>Good Bye!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
</tbody>
</table>
<p>If command is <strong>NOT</strong> in format specified above (either command name is wrong or input arguments count) throw InvalidOperationException with message: &ldquo;Command &lt;CommandName&gt; not valid!&rdquo;.</p>
<h3>Examples</h3>
<table width="757">
<tbody>
<tr>
<td width="448">
<p><strong>Input</strong></p>
</td>
<td width="310">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="448">
<p>RegisterUser admin abc123 abc123 user@softuni.bg</p>
<p>ModifyUser admin BornTown Sofia</p>
<p>AddTown Sofia Bulgaria</p>
<p>ModifyUser admin BornTown Sofia</p>
<p>UploadPicture Nature Vitosha C://Pictures/Vitosha.png</p>
<p>CreateAlbum admin Nature Magenta nature</p>
<p>AddTag nature</p>
<p>CreateAlbum admin Nature Magenta nature</p>
<p>UploadPicture Nature Vitosha C://Pictures/Vitosha.png</p>
<p>Exit</p>
<p>&nbsp;</p>
</td>
<td width="310">
<p>User admin was registered successfully!</p>
<p>Value Sofia not valid!<br /> Town Sofia not found!</p>
<p>Town Sofia was added successfully!</p>
<p>User admin BornTown is Sofia.</p>
<p>Album Nature not found!</p>
<p>Invalid tags!</p>
<p>Tag #nature was added successfully!</p>
<p>Album Nature successfully created!</p>
<p>Picture Vitosha added to Nature!</p>
<p>Good Bye!</p>
</td>
</tr>
<tr>
<td width="448">
<p>RegisterUser peter pan123 pan123 peter@pan.com</p>
<p>RegisterUser peter aaa a123 pesho@pan.com</p>
<p>RegisterUser capt hook123 hook123 capitan@hook.com</p>
<p>MakeFriends peterr capp</p>
<p>MakeFriends peter capp</p>
<p>MakeFriends peter capt</p>
<p>RegisterUser jack jack123 jack123 jack@j.com</p>
<p>MakeFriends peter jack</p>
<p>ListFriends peter</p>
<p>RegisterUser user</p>
<p>Exit</p>
</td>
<td width="310">
<p>User peter was registered successfully!</p>
<p>Username peter is already taken!</p>
<p>User capt was registered successfully!</p>
<p>User peterr not found!</p>
<p>User capp not found!</p>
<p>Friend capt added to pan!</p>
<p>User jack was registered successfully!</p>
<p>Friend jack added to pan!</p>
<p>Friends</p>
<p>-capt</p>
<p>-jack</p>
<p>Command RegisterUser not valid!</p>
<p>Good Bye!</p>
</td>
</tr>
<tr>
<td width="448">
<p>RegisterUser tomCat tom123 tom123 tom@t.com</p>
<p>RegisterUser jerry jerry123 jerry123 jerry@j.com</p>
<p>RegisterUser butch butch123 butch123 butch@b.com</p>
<p>AddTag #cartoon</p>
<p>CreateAlbum tomCat Tom&amp;Jerry Blue cartoon</p>
<p>ShareAlbum 1 jerry Owner</p>
<p>AddTag #childhood</p>
<p>AddTagTo Tom&amp;Jerry childhood</p>
<p>Exit</p>
</td>
<td width="310">
<p>User tom was registered successfully!</p>
<p>User jerry was registered successfully!</p>
<p>User jerry was registered successfully!</p>
<p>Tag #cartoon was added successfully!</p>
<p>Album Tom&amp;Jerry successfully created!</p>
<p>Username jerry added to album Tom&amp;Jerry (Owner)</p>
<p>Tag #childhood was added successfully!</p>
<p>Tag #childhood added to Tom&amp;Jerry!</p>
<p>Good Bye!</p>
</td>
</tr>
</tbody>
</table>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Extend Photo Share System</h2>
<p>Extend the <strong>Photo Share System</strong> by implementing two more commands:</p>
<ul>
<li><strong>Login &lt;username&gt; &lt;password&gt;</strong><strong><br /> </strong>Logs a user into the system and keep a reference to it until the &ldquo;Logout&rdquo; command is called.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>User [username] successfully logged in!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>Either user does not exist or password does not match</p>
</td>
<td width="334">
<p>Invalid username or password!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
<tr>
<td width="155">
<p>User has logged in already</p>
</td>
<td width="334">
<p>You should logout first!</p>
</td>
<td width="173">
<p>ArgumentException</p>
</td>
</tr>
</tbody>
</table>
<ul>
<li><strong>Logout</strong><strong><br /> </strong>Logs out a user from the system.</li>
</ul>
<table>
<tbody>
<tr>
<td width="155">
<p><strong>Case</strong></p>
</td>
<td width="334">
<p><strong>Message</strong></p>
</td>
<td width="173">
<p><strong>Exception</strong></p>
</td>
</tr>
<tr>
<td width="155">
<p>Success</p>
</td>
<td width="334">
<p>User [username] successfully logged out!</p>
</td>
<td width="173">
<p>None</p>
</td>
</tr>
<tr>
<td width="155">
<p>There is no user logged in.</p>
</td>
<td width="334">
<p>You should log in first in order to logout.</p>
</td>
<td width="173">
<p>InvalidOperationException</p>
</td>
</tr>
</tbody>
</table>
<p><strong>Modify all commands accordingly</strong>.</p>
<p>Logged user can:</p>
<ul>
<li>Modify his own profile</li>
<li>Add friends to himself</li>
<li>Add tag</li>
<li>Add town</li>
<li>Create an album (only if he is owner of the album)</li>
<li>Share an album (only if he is owner of the album)</li>
<li>Upload picture (only if he is owner of the album that picture is uploaded to)</li>
<li>Add tag to album (only if he is owner of the album)</li>
<li>Delete user (can delete only himself/herself)</li>
<li>List friends of any user</li>
<li>Logout</li>
</ul>
<p>Non-logged user can:</p>
<ul>
<li>List friends of any user</li>
<li>Register</li>
<li>Login</li>
</ul>
<p>If any of these rules are violated print: &ldquo;Invalid credentials!&rdquo; and throw InvalidOperationException.</p>
<h3>Examples</h3>
<table width="726">
<tbody>
<tr>
<td width="414">
<p><strong>Input</strong></p>
</td>
<td width="312">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="414">
<p>RegisterUser thor tor123 tor123 tor@t.com</p>
<p>Login thor tor1234</p>
<p>Login thor tor123</p>
<p>Login thor tor123</p>
<p>AddTag thunder</p>
<p>RegisterUser loki loki123 loki123 loki@l.com</p>
<p>Logout</p>
<p>RegisterUser loki loki123 loki123 loki@l.com</p>
<p>Login loki loki123</p>
<p>Exit</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
</td>
<td width="312">
<p>User thor was registered successfully!</p>
<p>Invalid username or password!<br /> User thor successfully logged in!</p>
<p>Invalid Credentials!</p>
<p>Tag #thunder was added successfully!</p>
<p>Invalid Credentials!</p>
<p>User tor successfully logged out!</p>
<p>User loki was registered successfully! <br /> User loki successfully logged in!</p>
<p>Good Bye!</p>
</td>
</tr>
<tr>
<td width="414">
<p>AddTown Asgard Asgard</p>
<p>RegisterUser loki loki123 loki123 loki@l.com</p>
<p>RegisterUser thor tor123 tor123 tor@t.com</p>
<p>Login thor tor123</p>
<p>AddTown Asgard Asgard</p>
<p>ModifyUser thor CurrentTown Asgard</p>
<p>ModifyUser loki CurrentTown Asgard</p>
<p>MakeFriends thor loki</p>
<p>MakeFriends loki thor</p>
<p>CreateAlbum thor TalesOfAsgard Black</p>
<p>CreateAlbum loki FalseGod Black</p>
<p>ShareAlbum 1 loki Viewer</p>
<p>UploadPicture TalesOfAsgard Thor D:\\images\thor.png</p>
<p>AddTag thunder</p>
<p>AddTagTo TalesOfAsgard thunder</p>
<p>ListFriends thor</p>
<p>ListFriends loki</p>
<p>DeleteUser thor</p>
<p>DeleteUser loki</p>
<p>Logout</p>
<p>RegisterUser odin odin123 odin123 odin@d.com</p>
<p>Login loki loki123</p>
<p>ShareAlbum 1 odin Owner</p>
<p>UploadPicture TalesOfAsgard Loki D:\\images\loki.png</p>
<p>AddTag #destruction</p>
<p>AddTagTo TalesOfAsgard #destruction</p>
<p>Exit</p>
</td>
<td width="312">
<p>Invalid credentials!</p>
<p>User loki was registered successfully!</p>
<p>User thor was registered successfully!</p>
<p>User thor successfully logged in!</p>
<p>Town Asgard was added successfully!</p>
<p>User thor CurrentTown is Asgard.</p>
<p>Invalid credentials!</p>
<p>Friend loki added to thor!</p>
<p>Invalid credentials!</p>
<p>Album TalesOfAsgard successfully created!</p>
<p>Invalid credentials!</p>
<p>User loki added to album TalesOfAsgard(Viewer)</p>
<p>Picture Thor added to TalesOfAsgard!</p>
<p>Tag #thunder was added successfully!</p>
<p>Tag #thunder added to TalesOfAsgard!</p>
<p>Friends:</p>
<p>-loki</p>
<p>No friends for this user. :(</p>
<p>User thor was deleted successfully!</p>
<p>Invalid credentials!</p>
<p>User thor successfully logged out!</p>
<p>User odin was registered successfully!</p>
<p>User loki successfully logged in!</p>
<p>Invalid credentials!</p>
<p>Invalid credentials!</p>
<p>Tag #destruction was added successfully!</p>
<p>Invalid credentials!</p>
<p>Good Bye!</p>
</td>
</tr>
</tbody>
</table>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp; *Bus Tickets System</h2>
<p>Your task is to design a database for <strong>Bus Tickets System</strong> using the <strong>code first </strong>approach. The database should keep information about:</p>
<ul>
<li><strong>bus companies</strong> - name, nationality, rating</li>
<li><strong>tickets </strong>- price, seat, customer, trip</li>
<li><strong>customers</strong> - first name, last name, date of birth, gender, home town</li>
<li><strong>trips</strong> - departure time, arrival time, status, origin bus station, destination bus station, bus company</li>
<li><strong>bus stations</strong> - name, town</li>
<li><strong>towns </strong>- name, country</li>
<li><strong>reviews </strong>- content, grade, bus station, customer, date and time of publishing</li>
<li><strong>bank accounts</strong> - account number, balance, customer</li>
</ul>
<p>Each ticket is bought from a customer for a certain trip. A customer has only one home town. Every trip has an origin and a destination, a bus station and it is organized by only one bus company. A bus station is located in only one town and one town can have many bus stations in it. Reviews are written for a certain bus company and a bus company can have many reviews. One customer can write many reviews but a single review can be written only by one customer. Bank account can be owned by one customer and each customer can own only one bank account.</p>
<p>Gender can be only male, female or not specified. The status of the trip can be departed, arrived, delayed or cancelled. Grade of a review can any be a floating-point number in range [1, 10].</p>
<p>When database is up and running <strong>seed</strong> it with some <strong>sample records in each table</strong>.</p>
<p>Now let&rsquo;s <strong>make a command line application</strong> that would <strong>use that database and provide the following functionalities</strong>:</p>
<ul>
<li><strong>print information for trips for a given bus station &ndash; </strong>Print a list of arrivals and departures buses for given bus station id in the format provided below</li>
<li><strong>buy ticket &ndash; </strong>Insert new ticket and reduce the balance from customers&rsquo; bank account. Consider managing all cases such as the customer does not have enough money in his/her bank account.</li>
<li><strong>publish review &ndash; </strong>insert new review from given user into the database</li>
<li><strong>print reviews &ndash; </strong>print a list of reviews for a given bus company in the format provided below</li>
</ul>
<table width="699">
<tbody>
<tr>
<td width="310">
<p><strong>Command</strong></p>
</td>
<td width="390">
<p><strong>Successful Output</strong></p>
</td>
</tr>
<tr>
<td width="310">
<p>print-info {Bus Station ID}</p>
</td>
<td width="390">
<p>{Bus Station Name}, {Town}</p>
<p>Arrivals:</p>
<p>From {origin station} | Arrive at: {Arrival Time} | Status: {status}</p>
<p>Departures:</p>
<p>To {destination station} | Depart at: {Departure Time} | Status {status}</p>
</td>
</tr>
<tr>
<td width="310">
<p>buy-ticket {customer ID} {Trip ID} {Price} {Seat}</p>
</td>
<td width="390">
<p>Customer {Full Name} bought ticket for trip {Trip ID} for {Price} on seat {Seat}</p>
</td>
</tr>
<tr>
<td width="310">
<p>publish-review {Customer ID} {Grade} {Bus Company Name} {Content}</p>
</td>
<td width="390">
<p>Customer {Full Name} published review for company {Company Name}</p>
</td>
</tr>
<tr>
<td width="310">
<p>print-reviews {Bus Company ID}</p>
</td>
<td width="390">
<p>{Id} {Grade} {Date and Time}</p>
<p>{Customer Full Name}</p>
<p>{Content}</p>
</td>
</tr>
</tbody>
</table>
<p>The application should <strong>receive and execute unlimited number of commands</strong> until the <strong>&ldquo;exit&rdquo;</strong> command is received.</p>
<p>Use all of the <strong>best practices</strong> you know to design and write your application.</p>
<h3>Examples</h3>
<table width="710">
<tbody>
<tr>
<td width="265">
<p><strong>Input</strong></p>
</td>
<td width="445">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="265">
<p>print-info 1</p>
<p>exit</p>
<p>&nbsp;</p>
</td>
<td width="445">
<p>Sofia Central Station, Sofia</p>
<p>Arrivals:</p>
<p>From: Burgas | Arrive at: 14:30 | Status: Departed</p>
<p>From: Svishtov | Arrive at: 07:30 | Status: Arrived</p>
<p>From: V.Tarnovo | Arrive at: 14:30 | Status: Departed</p>
<p>Departures:</p>
<p>To: Varna | Depart at: 14:40 | Status: Delayed</p>
<p>To: Plovdiv | Depart at: 15:30 | Status: Cancelled</p>
</td>
</tr>
<tr>
<td width="265">
<p>buy-ticket 2 323 14.20 A4</p>
<p>buy-ticket 3 333 -12.00 B8</p>
<p>buy-ticket 9 874 6.90 A1</p>
<p>exit</p>
</td>
<td width="445">
<p>Customer John Doe bought ticket for trip 323 for $14.20 on seat A4</p>
<p>Invalid price</p>
<p>Insufficient amount of money for customer Harry Potter with bank account number BGR33133235</p>
</td>
</tr>
<tr>
<td width="265">
<p>publish-review 2 10 BusTrip2000 Excellent trip! Look forward to travel again.</p>
<p>publish-review 3 2 BusCompany2001 Awful and dirty bus. Cannot recommend it to anyone.</p>
<p>exit</p>
</td>
<td width="445">
<p>John Doe&rsquo;s review was succesfully published</p>
<p>Chuck Norris&rsquo; review was successfully published</p>
</td>
</tr>
<tr>
<td width="265">
<p>publish-review 2 8.5 BusTrip2000 Would recommend it but the driver needs to stop smoking while driving.</p>
<p>print-reviews 1</p>
<p>exit</p>
</td>
<td width="445">
<p>John Doe&rsquo;s review was succesfully published</p>
<p>1 10 2016/11/15 10:46:18</p>
<p>John Doe</p>
<p>Excellent trip! Look forward to travel again.</p>
<p>2 8.5 2016/11/18 12:20:00</p>
<p>John Doe</p>
<p>Would recommend it but the driver needs to stop smoking while driving.</p>
</td>
</tr>
</tbody>
</table>
<h2>4.&nbsp;&nbsp; **Extend Bus Tickets System</h2>
<p>Implement one additional command <strong>change-trip-status</strong>. That command would change the status of a given trip</p>
<table width="699">
<tbody>
<tr>
<td width="321">
<p><strong>Command</strong></p>
</td>
<td width="378">
<p><strong>Successful Output</strong></p>
</td>
</tr>
<tr>
<td width="321">
<p>change-trip-status {Trip Id} {New Status}</p>
</td>
<td width="378">
<p>Trip from {Origin Bus Station Town} to {Destination Bus Station Town} on {Trip Departure Date and Time}</p>
<p>Status changed from {Old Status} to {New Status}</p>
</td>
</tr>
</tbody>
</table>
<p>Add a <strong>new table to the database</strong> to keep information about <strong>arrived trips</strong> (actual arrival time, origin bus station, destination bus station, passengers count).</p>
<p>In case a <strong>trip status is changed to Arrived, automatically add new record</strong> in the <strong>arrived trips table</strong> with the required information.</p>
<h3>Examples</h3>
<table width="710">
<tbody>
<tr>
<td width="236">
<p><strong>Input</strong></p>
</td>
<td width="474">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="236">
<p>change-trip-status 2 Departed</p>
<p>change-trip-status 3 Cancelled</p>
<p>change-trip-status 134 Arrived</p>
<p>exit</p>
<p>&nbsp;</p>
</td>
<td width="474">
<p>Trip from Burgas to Sofia on 2016/11/15 10:45:00</p>
<p>Status changed from Cancelled to Departed</p>
<p>Trip from Sofia to Varna on 2016/11/15 10:00:00</p>
<p>Status changed from Delayed to Cancelled</p>
<p>Trip from Plovdiv to Varna on 2016/11/14 15:30:00</p>
<p>Status changed from Departed to Arrived</p>
<p>On 2016/11/14 22:32:43 - 34 passengers arrived at Varna from Plovdiv</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>