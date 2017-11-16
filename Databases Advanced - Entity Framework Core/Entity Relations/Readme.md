<h1>Exercises: Entity Relations</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp;&nbsp;&nbsp; Student System</h2>
<p>Your task is to create a database for the <strong>Student System</strong>, using the <strong>EF Core Code First </strong>approach. It should look like this:</p>
<h3>Constraints</h3>
<p>Your <strong>namespaces</strong> should be:</p>
<ul>
<li>P01_StudentSystem &ndash; for your Startup class, if you have one</li>
<li>P01_Data &ndash; for your DbContext</li>
<li>P01_Data.Models &ndash; for your models</li>
</ul>
<p>Your <strong>models</strong> should be:</p>
<ul>
<li>StudentSystemContext &ndash; your DbContext</li>
<li>Student:
<ul>
<li>StudentId</li>
<li>Name (up to 100 characters, unicode)</li>
<li>PhoneNumber (exactly 10 characters, not unicode, not required)</li>
<li>RegisteredOn</li>
<li>Birthday (not required)</li>
</ul>
</li>
<li>Course:
<ul>
<li>CourseId</li>
<li>Name (up to 80 characters, unicode)</li>
<li>Description (unicode, not required)</li>
<li>StartDate</li>
<li>EndDate</li>
<li>Price</li>
</ul>
</li>
<li>Resource:
<ul>
<li>ResourceId</li>
<li>Name (up to 50 characters, unicode)</li>
<li>Url (not unicode)</li>
<li>ResourceType (enum &ndash; can be Video, Presentation, Document or Other)</li>
<li>CourseId</li>
</ul>
</li>
<li>Homework:
<ul>
<li>HomeworkId</li>
<li>Content (string, linking to a file, not unicode)</li>
<li>ContentType (enum &ndash; can be Application, Pdf or Zip)</li>
<li>SubmissionTime</li>
<li>StudentId</li>
<li>CourseId</li>
</ul>
</li>
<li>StudentCourse &ndash; mapping class between <strong>Students</strong> and <strong>Courses</strong></li>
</ul>
<p>Table relations:</p>
<ul>
<li><strong>One student</strong> can have <strong>many CourseEnrollments</strong></li>
<li><strong>One student </strong>can have<strong> many HomeworkSubmissions</strong></li>
<li><strong>One course</strong> can have <strong>many StudentsEnrolled</strong></li>
<li><strong>One course</strong> can have <strong>many Resources</strong></li>
<li><strong>One course</strong> can have <strong>many HomeworkSubmissions</strong></li>
</ul>
<p>You will need a constructor, accepting <strong>DbContextOptions</strong> to test your solution in <strong>Judge</strong>!</p>
<h2>2.&nbsp;&nbsp;&nbsp;&nbsp; Seed Some Data in the Database</h2>
<p>Write a <strong>seed method</strong> that fills the database with sample data.<br /> Fill a few <strong>students</strong>, <strong>courses</strong>, <strong>resources</strong> and <strong>homework submissions</strong>.</p>
<h4>Bonus</h4>
<p>Create a console application that reads information about <strong>courses</strong> and <strong>students</strong>.</p>
<h2>3.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Football Betting</h2>
<p>Your task is to create a database for a <strong>Football Bookmaker System</strong>, using the <strong>Code First </strong>approach. It should look like this:</p>
<h3>Constraints</h3>
<p>Your <strong>namespaces</strong> should be:</p>
<ul>
<li>P03_FootballBetting &ndash; for your Startup class, if you have one</li>
<li>P03_Data &ndash; for your DbContext</li>
<li>P03_Data.Models &ndash; for your models</li>
</ul>
<p>Your models should be:</p>
<ul>
<li><strong>FootballBettingContext</strong> &ndash; your DbContext</li>
<li><strong>Team</strong> &ndash; TeamId, Name, LogoUrl, Initials (JUV, LIV, ARS&hellip;), Budget, PrimaryKitColorId, SecondaryKitColorId, TownId</li>
<li><strong>Color</strong> &ndash; ColorId, Name</li>
<li><strong>Town</strong> &ndash; TownId, Name, CountryId</li>
<li><strong>Country</strong> &ndash; CountryId, Name</li>
<li><strong>Player</strong> &ndash; PlayerId, Name, SquadNumber, TeamId, PositionId, IsInjured</li>
<li><strong>Position</strong> &ndash; PositionId, Name</li>
<li><strong>PlayerStatistic</strong> &ndash; GameId, PlayerId, ScoredGoals, Assists, MinutesPlayed</li>
<li><strong>Game</strong> &ndash; GameId, HomeTeamId, AwayTeamId, HomeTeamGoals, AwayTeamGoals, DateTime, HomeTeamBetRate, AwayTeamBetRate, DrawBetRate, Result)</li>
<li><strong>Bet</strong> &ndash; BetId, Amount, Prediction, DateTime, UserId, GameId</li>
<li><strong>User</strong> &ndash; UserId, Username, Password, Email, Name, Balance</li>
</ul>
<p>Table relationships:</p>
<ul>
<li><strong>A Team</strong> has one <strong>PrimaryKitColor</strong> and one <strong>SecondaryKitColor</strong></li>
<li><strong>A Color </strong>has <strong>many PrimaryKitTeams </strong>and <strong>many SecondaryKitTeams</strong></li>
<li><strong>A Team</strong> residents in one <strong>Town</strong></li>
<li><strong>A Town</strong> can host <strong>several</strong> <strong>Teams</strong></li>
<li><strong>A Game </strong>has one <strong>HomeTeam </strong>and one <strong>AwayTeam </strong>and a <strong>Team </strong>can have <strong>many</strong> <strong>HomeGames </strong>and <strong>many</strong> <strong>AwayGames</strong></li>
<li><strong>A Town</strong> can be placed in <strong>one</strong> <strong>Country</strong> and a <strong>Country</strong> can have many <strong>Towns</strong></li>
<li><strong>A Player</strong> can play for <strong>one</strong> <strong>Team</strong> and <strong>one</strong> <strong>Team</strong> can have many <strong>Players</strong></li>
<li><strong>A Player</strong> can play at one <strong>Position</strong> and one <strong>Position</strong> can be played by <strong>many</strong> <strong>Players</strong></li>
<li><strong>One</strong> <strong>Player</strong> can play in <strong>many</strong> <strong>Games</strong> and in each <strong>Game</strong>, <strong>many</strong> <strong>Players</strong> take part (<strong>PlayerStatistics</strong>)</li>
<li><strong>Many</strong> <strong>Bets</strong> can be placed on <strong>one</strong> <strong>Game</strong>, but <strong>a</strong> <strong>Bet</strong> can be only on <strong>one</strong> <strong>Game</strong></li>
<li>Each bet for given game must have <strong>Prediction</strong> result</li>
<li><strong>A Bet</strong> can be placed by only <strong>one</strong> <strong>User</strong> and one <strong>User</strong> can place many <strong>Bets</strong></li>
</ul>
<p>Separate the <strong>models</strong>, <strong>data</strong> and <strong>client</strong> into <strong>different layers</strong> (projects).</p>