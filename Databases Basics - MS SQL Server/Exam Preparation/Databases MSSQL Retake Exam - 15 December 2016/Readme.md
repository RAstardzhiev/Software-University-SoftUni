<h1>Database Fundamentals MSSQL Retake &ndash; The Nerd Herd</h1>
<p>That is the name of the newest super-hot awesome chat application! You are part of the developing team and as a such you are supposed to create the database underneath. Then you have to do some data manipulations. Finally, you have to do some work on the programmability part. Here are some more details:</p>
<h1>Section 1. DDL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>25 pts</strong></h1>
<p><strong><u>For this section put your queries in judge and use SQL Server run queries and check DB.</u></strong></p>
<p>You have been given the E/R Diagram of the chat:</p>
<p>Crate a database called <strong>TheNerdHerd</strong>. You need to create <strong>6 tables</strong>:</p>
<ul>
<li>Users &ndash; contains information about the users who can chat. Each user has location and <strong>exactly one</strong></li>
<li>Credentials &ndash; contains information about the login details.</li>
<li>Location &ndash; contains geographical information about the location of each person</li>
<li>Chats &ndash; contains information about the chat. Chats can have many users in them.</li>
<li>UsersChats &ndash; mapping table between users and chats</li>
<li>Messages &ndash; contains information about the sent messages.</li>
</ul>
<p><br /> <strong>Users</strong></p>
<table width="628">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="350">
<p><strong>Data Type</strong></p>
</td>
<td width="154">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Unique table identificator, Identity</p>
</td>
</tr>
<tr>
<td width="125">
<p>Nickname</p>
</td>
<td width="350">
<p>String up to 25 symbols</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Gender</p>
</td>
<td width="350">
<p>Character with 1 symbol</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Age</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Location_id</p>
</td>
<td width="350">
<p>Integer from&nbsp; 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Relationship with locations</p>
</td>
</tr>
<tr>
<td width="125">
<p>Credential_id</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Relationship with table credentials, Unique values</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Locations</strong></p>
<table width="628">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="350">
<p><strong>Data Type</strong></p>
</td>
<td width="154">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Unique table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>Latitude</p>
</td>
<td width="350">
<p>Floating point number</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Longitude</p>
</td>
<td width="350">
<p>Floating point number</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>&nbsp;</strong></p>
<p><strong>Credentials</strong></p>
<table width="628">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="350">
<p><strong>Data Type</strong></p>
</td>
<td width="154">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="350">
<p>Integer from 0 &nbsp;to 2,147,483,647</p>
</td>
<td width="154">
<p>Unique table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>Email</p>
</td>
<td width="350">
<p>String up to 30 symbols</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>Password</p>
</td>
<td width="350">
<p>String up to 20 symbols</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Chats</strong></p>
<table width="628">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="350">
<p><strong>Data Type</strong></p>
</td>
<td width="154">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Unique table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>Title</p>
</td>
<td width="350">
<p>String up to 32 symbols</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>StartDate</p>
</td>
<td width="350">
<p>Date without time</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>IsActive</p>
</td>
<td width="350">
<p>Bit</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>Messages</strong></p>
<table width="628">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="350">
<p><strong>Data Type</strong></p>
</td>
<td width="154">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>Id</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Unique table identificator</p>
</td>
</tr>
<tr>
<td width="125">
<p>Content</p>
</td>
<td width="350">
<p>String up to 200 symbols</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>SentOn</p>
</td>
<td width="350">
<p>Date without time</p>
</td>
<td width="154">
<p>&nbsp;</p>
</td>
</tr>
<tr>
<td width="125">
<p>ChatId</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Relationship with table chats</p>
</td>
</tr>
<tr>
<td width="125">
<p>UserId</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Relationship with table users</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<p><strong>UsersChats</strong></p>
<table width="628">
<tbody>
<tr>
<td width="125">
<p><strong>Column Name</strong></p>
</td>
<td width="350">
<p><strong>Data Type</strong></p>
</td>
<td width="154">
<p><strong>Constraints</strong></p>
</td>
</tr>
<tr>
<td width="125">
<p>UserId</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Unique table identificator, Relationship with table users</p>
</td>
</tr>
<tr>
<td width="125">
<p>ChatId</p>
</td>
<td width="350">
<p>Integer from 0 to 2,147,483,647</p>
</td>
<td width="154">
<p>Unique table identificator, Relationship with table chats</p>
</td>
</tr>
</tbody>
</table>
<h1>1.&nbsp; Database design</h1>
<p>Send all yours create statements in judge.</p>
<h1>Section 2. DML&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>15 pts</strong></h1>
<p><strong><u>For this section put your queries in judge and use SQL Server run skeleton, run queries and check DB.</u></strong></p>
<p><strong><u>Before you start you have to import Data.sql. If you have created the structure correctly the data should be successfully inserted.</u></strong></p>
<p>In this section you have to do couple of data manipulations:</p>
<h1>2.&nbsp; Insert</h1>
<p>Do you remember ASL?&nbsp; It stands for Age, Sex(gender), Location. You have to insert couple of message based on table <strong>Users. </strong></p>
<ul>
<li>Content &ndash; it should be concatenation of age, gender, latitude and longitude split by <strong>dash</strong>. Use a concatenating function.</li>
<li>SentOn &ndash; should be the current date</li>
<li>ChatId &ndash;
<ul>
<li>If the user is <strong>female multiply the age by 2 and then take the square root </strong></li>
<li>if it is a <strong>male divide the age by 18 and take it the power of 3</strong></li>
<li><strong>when you find the id round it up</strong></li>
</ul>
</li>
<li>UserId &ndash; take the UserId from the table</li>
<li>You should insert data for users with id between 10 and 20 inclusively</li>
</ul>
<p>Example:</p>
<table width="646">
<tbody>
<tr>
<td width="158">
<p><strong>Content</strong></p>
</td>
<td width="162">
<p><strong>SentOn</strong></p>
</td>
<td width="162">
<p><strong>ChatId</strong></p>
</td>
<td width="162">
<p><strong>UserId</strong></p>
</td>
</tr>
<tr>
<td width="158">
<p>56-F-10.1857-123.734</p>
</td>
<td width="162">
<p>2016-12-15</p>
</td>
<td width="162">
<p>11</p>
</td>
<td width="162">
<p>12</p>
</td>
</tr>
</tbody>
</table>
<h1>&nbsp;</h1>
<h1>3.&nbsp; Update</h1>
<p>The back-end developers have slightly failed and let some chats to have messages with a date earlier than the creation date of the chat. You have to fix that. For all chats which have messages before the chat StartDate <strong>update the chat StartDate to be equal to the earliest message in that chat</strong>.</p>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>ChatId</strong></p>
</td>
<td width="95">
<p><strong>StartDate</strong></p>
</td>
<td width="95">
<p><strong>MessageId</strong></p>
</td>
<td width="95">
<p><strong>SentOn</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>4</p>
</td>
<td width="95">
<p>2013-10-28</p>
</td>
<td width="95">
<p>53</p>
</td>
<td width="95">
<p>2011-06-22</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>ChatId</strong></p>
</td>
<td width="95">
<p><strong>StartDate</strong></p>
</td>
<td width="95">
<p><strong>MessageId</strong></p>
</td>
<td width="95">
<p><strong>SentOn</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>4</p>
</td>
<td width="95">
<p>2011-06-22</p>
</td>
<td width="95">
<p>53</p>
</td>
<td width="95">
<p>2011-06-22</p>
</td>
</tr>
</tbody>
</table>
<h1>4.&nbsp; Delete</h1>
<p>Delete all locations which doesn&rsquo;t have user located there.</p>
<h1>Section 3. Querying&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>40 pts</strong></h1>
<p><strong><u>For this section put your queries in judge and use SQL Server prepare DB and run queries.</u></strong></p>
<h1>5.&nbsp; Age Range</h1>
<p>Select all users that are aged between 22 and 37 inclusively.</p>
<p>Required columns:</p>
<ul>
<li>Nickname</li>
<li>Gender</li>
<li>Age</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Nickname</strong></p>
</td>
<td width="95">
<p><strong>Gender</strong></p>
</td>
<td width="95">
<p><strong>Age</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>sbell0</p>
</td>
<td width="95">
<p>F</p>
</td>
<td width="95">
<p>23</p>
</td>
</tr>
</tbody>
</table>
<h1>6.&nbsp; Messages</h1>
<p>Select all messages that are sent after 12.05.2014 and contain the word &ldquo;just&rdquo;. Sort the results by the message id in descending order.</p>
<p>Required columns:</p>
<ul>
<li>Content</li>
<li>SentOn</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="392">
<p><strong>Content</strong></p>
</td>
<td width="205">
<p><strong>SentOn</strong></p>
</td>
</tr>
<tr>
<td width="392">
<p>odio cras mi pede malesuada in imperdiet et commodo vulputate justo in</p>
</td>
<td width="205">
<p>2014-07-30</p>
</td>
</tr>
</tbody>
</table>
<h1>7.&nbsp; Chats</h1>
<p>Select all chats that that are active and their title length is less than 5 <strong>or </strong>3<sup>rd</sup> and 4<sup>th</sup> letters are equal to &ldquo;tl&rdquo;. Sort the results by title in descending order.</p>
<p>Required columns:</p>
<ul>
<li>Title</li>
<li>IsActive</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Title</strong></p>
</td>
<td width="95">
<p><strong>IsActive</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>Viva</p>
</td>
<td width="95">
<p>0</p>
</td>
</tr>
</tbody>
</table>
<h1>8.&nbsp; Chat Messages</h1>
<p>Select all chats with messages sent before 26.03.2012 and chat title with last letter equal to &ldquo;x&rdquo;. Sort by chat Id and message Id in ascending order.</p>
<p>Required columns:</p>
<ul>
<li>Id(Chats)</li>
<li>Tittle</li>
<li>Id(Messages)</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Id</strong></p>
</td>
<td width="95">
<p><strong>Tittle</strong></p>
</td>
<td width="95">
<p><strong>Id</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>22</p>
</td>
<td width="95">
<p>Quo Lux</p>
</td>
<td width="95">
<p>48</p>
</td>
</tr>
</tbody>
</table>
<h1>9.&nbsp; Message Count</h1>
<p>Select all chats and the amount of messages they have. Some messages may not have a chat. Filter messages with id less than 90. Select only the first 5 results sorted by TotalMessages in descending order and chat id in ascending order.</p>
<p>Required columns:</p>
<ul>
<li>Id(Chats)</li>
<li>TotalMessages</li>
</ul>
<p>&nbsp;</p>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Id</strong></p>
</td>
<td width="111">
<p><strong>TotalMessages</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>37</p>
</td>
<td width="111">
<p>4&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<h1>10.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Credentials</h1>
<p>Select all users with emails ending with &ldquo;co.uk&rdquo;. Sort by email in ascending order.</p>
<p>Required columns:</p>
<ul>
<li>Nickname</li>
<li>Email</li>
<li>Password</li>
</ul>
<p>&nbsp;</p>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Nickname</strong></p>
</td>
<td width="111">
<p><strong>Email</strong></p>
</td>
<td width="111">
<p><strong>Password</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>vburkek</p>
</td>
<td width="111">
<p>mperkinst@amazon.co.uk</p>
</td>
<td width="111">
<p>lCFO0hSeRt</p>
</td>
</tr>
</tbody>
</table>
<h1>11.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Locations</h1>
<p>Select all users who don&rsquo;t have a location.</p>
<p>Required columns:</p>
<ul>
<li>Id(Users)</li>
<li>Nickname</li>
<li>Age</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Id</strong></p>
</td>
<td width="111">
<p><strong>Nickname</strong></p>
</td>
<td width="111">
<p><strong>Age</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>1</p>
</td>
<td width="111">
<p>ahunta</p>
</td>
<td width="111">
<p>63</p>
</td>
</tr>
</tbody>
</table>
<h1>12.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Left Users</h1>
<p>Select all messages sent from users who have left the chat (they are not in the chat anymore). Filter data only for chat with id 17. Sort by message Id in descending order.</p>
<p>Required columns:</p>
<ul>
<li>Id(Messages)</li>
<li>ChatId</li>
<li>UserId</li>
</ul>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Id</strong></p>
</td>
<td width="111">
<p><strong>ChatId</strong></p>
</td>
<td width="111">
<p><strong>UserId</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>65</p>
</td>
<td width="111">
<p>17</p>
</td>
<td width="111">
<p>24</p>
</td>
</tr>
</tbody>
</table>
<h1>13.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Users in Bulgaria</h1>
<p>Select all users that are located in Bulgaria. Consider the latitude is in range [41.14;44.13] and longitude in range [22.21; 28.36]. Sort the results by title in ascending order.</p>
<p>Required columns:</p>
<ul>
<li>Nickname</li>
<li>Title</li>
<li>Latitude</li>
<li>Longitude</li>
</ul>
<p>&nbsp;</p>
<p>Example:</p>
<table>
<tbody>
<tr>
<td width="92">
<p><strong>Nickname</strong></p>
</td>
<td width="111">
<p><strong>Title</strong></p>
</td>
<td width="111">
<p><strong>Latitude</strong></p>
</td>
<td width="111">
<p><strong>Longitude</strong></p>
</td>
</tr>
<tr>
<td width="92">
<p>slittle1</p>
</td>
<td width="111">
<p>Lotlux</p>
</td>
<td width="111">
<p>42.09028</p>
</td>
<td width="111">
<p>25.03239</p>
</td>
</tr>
</tbody>
</table>
<h1>14.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last Chat</h1>
<p>Select the first message (if there is any) of the last chat.</p>
<p>Required columns:</p>
<ul>
<li>Title</li>
<li>Content</li>
</ul>
<p>Example:</p>
<table width="424">
<tbody>
<tr>
<td width="71">
<p><strong>Title</strong></p>
</td>
<td width="353">
<p><strong>Content</strong></p>
</td>
</tr>
<tr>
<td width="71">
<p>Bigtax</p>
</td>
<td width="353">
<p>NULL</p>
</td>
</tr>
</tbody>
</table>
<h1><br /> Section 4. Programmability&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>20 pts</strong></h1>
<p><strong><u>For this section put your queries in judge and use SQL Server run skeleton, run queries and check DB.</u></strong></p>
<h1>15.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Radians</h1>
<p>Create a user defined function that transforms degrees to radians. The formula should multiply the degrees by Pi and then split by 180. The return type must be float. Call the function <strong>udf_GetRadians.</strong></p>
<p>Parameters:</p>
<ul>
<li>Degrees</li>
</ul>
<p>Example:<br /> <br /> &nbsp;&nbsp; SELECT dbo.udf_GetRadians(22.12) AS Radians</p>
<p>&nbsp;</p>
<table width="113">
<tbody>
<tr>
<td width="113">
<p><strong>Radians</strong></p>
</td>
</tr>
<tr>
<td width="113">
<p>0.386066830541146</p>
</td>
</tr>
</tbody>
</table>
<h1>16.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Change Password</h1>
<p>Create a user defined procedure that receives an email and changes the password with the newly provided one. If the email doesn&rsquo;t exist throw an exception with Severity = 16, State = 1 and message &ldquo;The email does't exist!&rdquo;. Call the procedure <strong>udp_ChangePassword.</strong></p>
<p>Parameters:</p>
<ul>
<li>Email</li>
<li>NewPassword</li>
</ul>
<p>&nbsp;</p>
<p>Example:<br /> </p>
<table width="304">
<tbody>
<tr>
<td width="152">
<p><strong>Email</strong></p>
</td>
<td width="152">
<p><strong>Password</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>abarnes0@sogou.com</p>
</td>
<td width="152">
<p>LOL77s</p>
</td>
</tr>
</tbody>
</table>
<p><br /> &nbsp;&nbsp; exec udp_ChangePassword 'abarnes0@sogou.com','new_pass'</p>
<p>&nbsp;</p>
<table width="304">
<tbody>
<tr>
<td width="152">
<p><strong>Email</strong></p>
</td>
<td width="152">
<p><strong>Password</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>abarnes0@sogou.com</p>
</td>
<td width="152">
<p>new_pass</p>
</td>
</tr>
</tbody>
</table>
<h1>17.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Send Message</h1>
<p>Create a user defined procedure sends a message with a current date. The procedure should receive UserId, ChatId and the Content of the message. If there is no chat with that user throw an exception with Severity = 16, State = 1 and message &ldquo;There is no chat with that user!&rdquo;. Call the procedure <strong>udp_SendMessage</strong>.</p>
<p>Parameters:</p>
<ul>
<li>UserId</li>
<li>ChatId</li>
<li>Content</li>
</ul>
<p>Example:<br /> <br /> &nbsp;&nbsp; EXEC dbo.udp_SendMessage 19, 17, 'Awesome'</p>
<p><strong>&nbsp;</strong></p>
<p>&nbsp;</p>
<table width="601">
<tbody>
<tr>
<td width="152">
<p><strong>Content</strong></p>
</td>
<td width="150">
<p><strong>SentOn</strong></p>
</td>
<td width="150">
<p><strong>ChatId</strong></p>
</td>
<td width="150">
<p><strong>UserId</strong></p>
</td>
</tr>
<tr>
<td width="152">
<p>Awesome</p>
</td>
<td width="150">
<p>2016-12-15</p>
</td>
<td width="150">
<p>17</p>
</td>
<td width="150">
<p>19</p>
</td>
</tr>
</tbody>
</table>
<h1>18.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Log Messages</h1>
<p>Create a trigger that logs any deleted message from table messages. <strong>Submit only your create trigger statement. </strong>The log table should be called <strong>MessageLogs</strong> and should have exactly the same structure as table <strong>Messages</strong>. The name of the trigger is not important.</p>
<p>&nbsp;</p>
<p>Example:<br /> <br /> &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;DELETE FROM [Messages]</p>
<p>&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;WHERE [Messages].Id = 1</p>
<p><strong>MessageLogs</strong></p>
<p>&nbsp;</p>
<table width="601">
<tbody>
<tr>
<td width="46">
<p><strong>Id</strong></p>
</td>
<td width="342">
<p><strong>Content</strong></p>
</td>
<td width="92">
<p><strong>SentOn</strong></p>
</td>
<td width="60">
<p><strong>ChatId</strong></p>
</td>
<td width="63">
<p><strong>UserId</strong></p>
</td>
</tr>
<tr>
<td width="46">
<p>1</p>
</td>
<td width="342">
<p>in faucibus orci luctus et ultrices posuere cubilia curae mauris</p>
</td>
<td width="92">
<p>2016-11-18</p>
</td>
<td width="60">
<p>49</p>
</td>
<td width="63">
<p>20</p>
</td>
</tr>
</tbody>
</table>
<h1><br /> Section 5. Bonus&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>10 pts</strong></h1>
<p><strong><u>For this section put your queries in judge and use SQL Server run skeleton, run queries and check DB.</u></strong></p>
<h1>19.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Delete users</h1>
<p>Create a trigger that will help you to delete a user. <strong>Submit the create trigger statement only.</strong></p>
<p>Example:<br /> <br /> &nbsp;&nbsp; &nbsp;&nbsp;DELETE FROM Users</p>
<p>&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;WHERE Users.Id = 1<br /> </p>
<p><strong>&nbsp;&nbsp;&nbsp;&nbsp; </strong><strong>(3 row(s) affected)</strong></p>