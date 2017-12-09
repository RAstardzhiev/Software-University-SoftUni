<h1>Entity Framework Core: Exam Preparation 1</h1>
<p>Exam problems for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>. Submit your solutions in the SoftUni judge system (delete all "bin"/"obj" folders).</p>
<p>Your task is to create a database application using <strong>Entity Framework Core</strong> using the <strong>Code First</strong> approach. Design the <strong>domain models</strong> and <strong>methods</strong> for manipulating the data, as described below.</p>
<h1>Instagraph</h1>
<p>Some of you may know about Instagraph, some of you may not. For those who don&rsquo;t, Instagraph is the backup <strong>database</strong> of <strong>Instagram</strong>. And guess what, you were chosen to work on it. This time your task is to create a whole <strong>Entity</strong> <strong>Framework</strong> <strong>Core</strong> <strong>application</strong> that will work with the <strong>database</strong>.</p>
<h2>Project Skeleton Overview</h2>
<p>You are given a <strong>project skeleton</strong>, which includes the following items:</p>
<ul>
<li>App &ndash; contains the Startup class, which is the <strong>entry point of the application</strong>. Also contains an AutoMapper profile (InstagraphProfile), which you can configure if you choose to use AutoMapper in your app.</li>
<li>Data &ndash; contains the InstagraphContext class and the <strong>connection string</strong></li>
<li>Models &ndash; contains the <strong>entity classes</strong></li>
<li>DataProcessor &ndash; contains the Serializer and Deserializer classes, which are used for <strong>importing </strong>and <strong>exporting </strong>data</li>
</ul>
<h2>Problem 1. Model Definition (50 pts)</h2>
<p>Every user has a <strong>profile</strong> <strong>picture</strong>, many <strong>posts and </strong>many<strong> comments </strong>on posts. Many <strong>users</strong> can have the same <strong>profile</strong> <strong>picture</strong>. In addition, a <strong>user</strong> can <strong>follow</strong> <strong>many</strong> <strong>other</strong> <strong>users</strong> and be <strong>followed</strong> <strong>by</strong> <strong>many</strong> <strong>other</strong> <strong>users</strong>. Any <strong>picture</strong> can be a part of <strong>many</strong> <strong>posts</strong>. Each post is <strong>created</strong> by a <strong>single</strong> <strong>user</strong> and is about a <strong>certain</strong> <strong>picture</strong>. A <strong>post</strong> can have <strong>many</strong> <strong>comments</strong>.</p>
<h3>Picture</h3>
<ul>
<li>Id &ndash; an <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>Path &ndash; a <strong>string</strong></li>
<li>Size &ndash; a <strong>decimal</strong></li>
<li>Users &ndash; a <strong>Collection</strong> of type User</li>
<li>Posts &ndash; a <strong>Collection</strong> of type Post</li>
</ul>
<h3>User</h3>
<ul>
<li>Id &ndash; an <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>Username &ndash; a <strong>string </strong>with<strong> max length 30</strong>, <strong>Unique</strong></li>
<li>Password &ndash; a <strong>string </strong>with<strong> max length 20</strong></li>
<li>ProfilePictureId &ndash; an <strong>integer</strong></li>
<li>ProfilePicture &ndash; a Picture</li>
<li>Followers &ndash; a <strong>Collection</strong> of type UserFollower</li>
<li>UsersFollowing &ndash; a <strong>Collection</strong> of type UserFollower</li>
<li>Posts &ndash; a <strong>Collection</strong> of type Post</li>
<li>Comments &ndash; a <strong>Collection</strong> of type Comment</li>
</ul>
<h3>Post</h3>
<ul>
<li>Id &ndash; an <strong>integer, Primary Key</strong></li>
<li>Caption &ndash; a <strong>string</strong></li>
<li>UserId &ndash; an <strong>integer</strong></li>
<li>User &ndash; a User</li>
<li>PictureId &ndash; an <strong>integer</strong></li>
<li>Picture &ndash; a Picture</li>
<li>Comments &ndash; a <strong>Collection </strong>of type<strong> Comment</strong></li>
</ul>
<h3>Comment</h3>
<ul>
<li>Id &ndash; an <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>Content &ndash; a <strong>string</strong> with <strong>max</strong> <strong>length</strong> <strong>250</strong></li>
<li><strong>UserId</strong> &ndash; an <strong>integer</strong></li>
<li>User &ndash; a User</li>
<li><strong>PostId</strong> &ndash; an <strong>integer</strong></li>
<li>Post &ndash; a Post</li>
</ul>
<h3>UserFollower</h3>
<ul>
<li>UserId &ndash; an <strong>integer</strong>, <strong>Primary Key</strong></li>
<li>User &ndash; a User</li>
</ul>
<ul>
<li><strong>FollowerId</strong> &ndash; an <strong>integer</strong>, <strong>Primary Key</strong></li>
<li><strong>Follower</strong> &ndash; a <strong>User</strong></li>
</ul>
<p><strong>All data</strong> is <strong>REQUIRED</strong>, unless it is explicitly said that <strong>null</strong> is <strong>allowed</strong>.</p>
<h2>Problem 2. Data Import (35pts)</h2>
<p>For the functionality of the application, you need to create several methods that manipulate the database. The <strong>project skeleton</strong> already provides you with these methods, inside the Instagraph.DataProcessor project inside your solution. Use <strong>Data Transfer Objects</strong> as needed.</p>
<p>Use the provided <strong>JSON</strong> and <strong>XML</strong> files to populate the database with data. Import all the information from those files into the database.</p>
<p>You are <strong>not allowed</strong> to modify the provided JSON and XML files.</p>
<p>Make sure all fields have been entered and are valid, otherwise the import <strong>entity</strong> data <strong>should NOT be considered valid</strong>.</p>
<p>You will also have to print a simple message indicating if the data has been imported successfully or there was an error.</p>
<p>In case of <strong>SUCCESS</strong> the message format is:</p>
<ul>
<li><strong>Picture</strong>: "Successfully imported Picture {picturePath}."</li>
<li><strong>User</strong>: "Successfully imported User {username}."</li>
<li><strong>Post</strong>: "Successfully imported Post {postCaption}.&rdquo;.</li>
<li><strong>Comment</strong>: "Successfully imported Comment {commentContent}."</li>
<li><strong>User - Follower</strong>: "Successfully imported Follower {followerUsername} to User {userUsername}."</li>
</ul>
<p>In case of <strong>ERROR</strong> you always print "Error: Invalid data.".</p>
<h3>JSON Import (15 pts)</h3>
<h4>Importing Pictures</h4>
<p>Using the file <strong>pictures.json</strong>, import the data from that file into the database.</p>
<h4>Pictures</h4>
<p>A picture is <strong>valid</strong> when it has a <strong>unique</strong> <strong>path</strong>, which is not an <strong>empty</strong> <strong>string</strong> and has a size, which is <strong>bigger</strong> <strong>than 0</strong>.</p>
<h5>Example</h5>
<table width="702">
<tbody>
<tr>
<td width="702">
<p><strong>pictures.json</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>[</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Path" : "src/folders/resources/images/profile/blocked/bmp/kjOJjKpKh4.bmp",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Size" : 32495.57</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Path" : "src/folders/resources/images/post/timeline/png/27kLXVm22Q.png",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Size" : 44273.27</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Path" : "src/folders/resources/images/profile/browsed/bmp/Q52q15Zefa.bmp"</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; &hellip;</strong></p>
<p><strong>]</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p>Successfully imported Picture src/folders/resources/images/profile/blocked/bmp/kjOJjKpKh4.bmp.</p>
<p>Successfully imported Picture src/folders/resources/images/post/timeline/png/27kLXVm22Q.png.</p>
<p>Error: Invalid data.</p>
<p><strong>&hellip;</strong></p>
</td>
</tr>
</tbody>
</table>
<h4>Users</h4>
<p>A <strong>user</strong> must have a <strong>valid</strong> <strong>profile</strong> <strong>picture</strong>, <strong>username</strong> and <strong>password</strong>.</p>
<h5>Example</h5>
<table width="702">
<tbody>
<tr>
<td width="702">
<p><strong>users.json</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>[</strong></p>
<p><strong>&nbsp;{</strong></p>
<p><strong>&nbsp;&nbsp; "Username" : "UnderSinduxrein",</strong></p>
<p><strong>&nbsp;&nbsp; "Password" : "4l8nYGTKMW",</strong></p>
<p><strong>&nbsp;&nbsp; "ProfilePicture" : "src/folders/resources/images/post/formed/digi/6YLvj97k03.digi"</strong></p>
<p><strong>&nbsp;},</strong></p>
<p><strong>&nbsp;{</strong></p>
<p><strong>&nbsp;&nbsp; "Username" : "BlaAntigadsa",</strong></p>
<p><strong>&nbsp;&nbsp; "Password" : ":Q5wjT4[e"</strong></p>
<p><strong>&nbsp;},</strong></p>
<p><strong>&nbsp;{</strong></p>
<p><strong>&nbsp;&nbsp; "Password" : "El[MwhxY)J",</strong></p>
<p><strong>&nbsp;&nbsp; "ProfilePicture" : "src/folders/resources/images/profile/blocked/jpg/pgfMG75k4e.jpg"</strong></p>
<p><strong>&nbsp;},</strong></p>
<p><strong>&nbsp;&hellip;</strong></p>
<p><strong>]</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p>Successfully imported User UnderSinduxrein.</p>
<p>Error: Invalid data.</p>
<p>Error: Invalid data.</p>
<p><strong>&hellip;</strong></p>
</td>
</tr>
</tbody>
</table>
<h4>Followers</h4>
<p>To make <strong>someone</strong> a <strong>follower</strong> of <strong>another</strong> <strong>user</strong>, both of them <strong>must</strong> <strong>exist</strong> in the <strong>database</strong>.</p>
<h5>Example</h5>
<table width="702">
<tbody>
<tr>
<td width="702">
<p><strong>users_followers.json</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>[</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "User" : "BlaImmagiIana",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Follower" : "ScoreSinduxIana"</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "User" : "BlaSinduxrein",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Follower" : "RoundInspecindi"</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "User" : "AryaNinehow",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Follower" : "DarkImmagidsa"</strong></p>
<p><strong>&nbsp; }, &hellip;</strong></p>
<p><strong>]</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p>Successfully imported Follower ScoreSinduxIana to User BlaImmagiIana.</p>
<p>Successfully imported Follower RoundInspecindi to User BlaSinduxrein.</p>
<p>Successfully imported Follower DarkImmagidsa to User AryaNinehow.</p>
<p><strong>&hellip;</strong></p>
</td>
</tr>
</tbody>
</table>
<h3>XML Import (5 pts)</h3>
<p>The other <strong>2 tables</strong> must be populated with data in <strong>XML</strong> format.</p>
<h4>Posts</h4>
<p>A <strong>post</strong> should only be inserted if the <strong>user</strong> and <strong>picture</strong> <strong>already</strong> <strong>exist</strong> in the <strong>database</strong>.</p>
<h5>Example</h5>
<table width="708">
<tbody>
<tr>
<td width="708">
<p><strong>posts.xml</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p><strong>&lt;?xml version="1.0" encoding="utf-8"?&gt;</strong></p>
<p><strong>&lt;posts&gt;</strong></p>
<p><strong>&nbsp; &lt;post&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;caption&gt;#everything #swag #sunglasses #smiley #justdoit #ocean&lt;/caption&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;user&gt;ScoreAntigarein&lt;/user&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;picture&gt;src/folders/resources/images/story/blocked/png/1S2el3wJ3v.png&lt;/picture&gt;</strong></p>
<p><strong>&nbsp; &lt;/post&gt;</strong></p>
<p><strong>&nbsp; &lt;post&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;caption&gt;#cool #justdoit #sky #ocean #reason #gram #faith #hope&lt;/caption&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;user&gt;HighAsmahow&lt;/user&gt;</strong></p>
<p><strong>&nbsp;&nbsp; &nbsp;&lt;picture&gt;src/folders/resources/images/profile/blocked/jpg/pgfMG75k4e.jpg&lt;/picture&gt;</strong></p>
<p><strong>&nbsp; &lt;/post&gt;</strong></p>
<p>&nbsp; &hellip;</p>
<p><strong>&lt;/posts&gt;</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p>Successfully imported Post #everything #swag #sunglasses #smiley #justdoit #ocean.</p>
<p>Successfully imported Post #cool #justdoit #sky #ocean #reason #gram #faith #hope.</p>
<p><strong>&hellip;</strong></p>
</td>
</tr>
</tbody>
</table>
<h4>Comments</h4>
<p>Comments <strong>should</strong> only be <strong>added</strong> for <strong>existing</strong> <strong>users</strong> and <strong>posts</strong>.</p>
<h5>Example</h5>
<table width="708">
<tbody>
<tr>
<td width="708">
<p><strong>comments.xml</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p><strong>&lt;?xml version="1.0" encoding="utf-8"?&gt;</strong></p>
<p><strong>&lt;comments&gt;</strong></p>
<p><strong>&nbsp; &lt;comment&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;content&gt;Wow! Wow, epic!! How?&lt;/content&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;user&gt;RoundAntigaBel&lt;/user&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;post id="22" /&gt;</strong></p>
<p><strong>&nbsp; &lt;/comment&gt;</strong></p>
<p><strong>&nbsp; &lt;comment&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;content&gt;This is just... this is the best! Why?&lt;/content&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;user&gt;BlaImmagiIana&lt;/user&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;post id="50" /&gt;</strong></p>
<p><strong>&nbsp; &lt;/comment&gt;</strong></p>
<p><strong>&nbsp; &hellip;</strong></p>
<p><strong>&lt;/comments&gt;</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p>Successfully imported Comment Wow! Wow, epic!! How?.</p>
<p>Error: Invalid data.</p>
<p><strong>&hellip;</strong></p>
</td>
</tr>
</tbody>
</table>
<h2>Problem 3. Data Export (15pts)</h2>
<p>For the functionality of the application, you need to create several methods that manipulate the database. The <strong>project skeleton</strong> already provides you with these methods, inside the Instagraph.DataProcessor project inside your solution. Use <strong>Data Transfer Objects</strong> as needed.</p>
<h3>JSON Export (5 pts)</h3>
<h4>Uncommented Posts</h4>
<p>Export all posts which do <strong>NOT</strong> have <strong>ANY comments</strong>. Extract everything and <strong>order</strong> it by <strong>id</strong> in <strong>ascending order</strong>.</p>
<p>Extract the Id, Path as "<strong>Picture</strong>" and the <strong>poster</strong>&rsquo;s Username as "U<strong>ser</strong>".</p>
<h5>Example</h5>
<table width="708">
<tbody>
<tr>
<td width="708">
<p><strong>UncommentedPosts.json</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p><strong>[</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Id": 1,</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Picture": "src/folders/resources/images/story/blocked/png/1S2el3wJ3v.png",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "User": "ScoreAntigarein"</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Id": 4,</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Picture": "src/folders/resources/images/story/blocked/png/1S2el3wJ3v.png",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "User": "DarkImmagidsa"</strong></p>
<p><strong>&nbsp; },</strong></p>
<p><strong>&nbsp; &hellip;</strong></p>
<p><strong>]</strong></p>
</td>
</tr>
</tbody>
</table>
<h4>Popular users</h4>
<p>Extract all <strong>users</strong> who have <strong>posts</strong>, <strong>commented</strong> by <strong>their followers</strong>.</p>
<p>Extract the user&rsquo;s username as &ldquo;<strong>user</strong>&rdquo;, and the user&rsquo;s count of followers as &ldquo;<strong>followers</strong>&rdquo;.</p>
<p>Order the data by <strong>id </strong>in <strong>ascending order</strong>.</p>
<h5>Example</h5>
<table width="708">
<tbody>
<tr>
<td width="708">
<p><strong>PopularUsers.json</strong></p>
</td>
</tr>
<tr>
<td width="708">
<p><strong>[</strong></p>
<p><strong>&nbsp; {</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Username": "ZendArmyhow",</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; "Followers": 7</strong></p>
<p><strong>&nbsp; }</strong></p>
<p><strong>]</strong></p>
</td>
</tr>
</tbody>
</table>
<h3>XML Export (5 pts)</h3>
<h4>Comments on Posts</h4>
<p>Extract <strong>all users</strong>. For each <strong>user</strong>, <strong>extract</strong> the <strong>post</strong> which has the <strong>most comments</strong>.</p>
<p>Extract the user&rsquo;s username as "<strong>Username</strong>" and the count of comments on the top post as <br /> "<strong>MostComments</strong>".</p>
<p>If a <strong>person</strong> has <strong>no posts</strong>, set his <strong>comments</strong> to <strong>0</strong>.</p>
<p><strong>Order</strong> the <strong>data</strong> in <strong>descending order</strong> by <strong>MostComments, then by Username ascending</strong>.</p>
<h5>Example</h5>
<table width="702">
<tbody>
<tr>
<td width="702">
<p><strong>CommentsOnPosts.xml</strong></p>
</td>
</tr>
<tr>
<td width="702">
<p><strong>&lt;users&gt;</strong></p>
<p><strong>&nbsp; &lt;user&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;Username&gt;ScoreAntigarein&lt;/Username&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;MostComments</strong><strong>&gt;3&lt;/MostComments</strong><strong>&gt;</strong></p>
<p><strong>&nbsp; &lt;/user&gt;</strong></p>
<p><strong>&nbsp; &lt;user&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;Username&gt;AryaDenotehow&lt;/Username&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;MostComments</strong><strong>&gt;2&lt;/MostComments</strong><strong>&gt;</strong></p>
<p><strong>&nbsp; &lt;/user&gt;</strong></p>
<p><strong>&nbsp; &lt;user&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;Username&gt;HighAsmahow&lt;/Username&gt;</strong></p>
<p><strong>&nbsp;&nbsp;&nbsp; &lt;MostComments</strong><strong>&gt;2&lt;/MostComments</strong><strong>&gt;</strong></p>
<p><strong>&nbsp; &lt;/user&gt;</strong></p>
<p><strong>&nbsp; &hellip;</strong></p>
<p><strong>&lt;/users&gt;</strong></p>
</td>
</tr>
</tbody>
</table>
<h5>&nbsp;</h5>