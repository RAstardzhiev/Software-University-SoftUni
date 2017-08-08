<h1>Lab: SOLID</h1>
<p>This document defines the exercises for <a href="https://softuni.bg/courses/csharp-oop-advanced-high-quality-code">"C# OOP Advanced" course @ Software University</a>.</p>
<h2>1.&nbsp;&nbsp; Stream Progress Info</h2>
<p>Refactor code for this task, so <strong>Stream Progress Info</strong> can work with different kinds of <strong>Streams</strong>. First make sure it works with <strong>Music</strong> too. Refactor code, so in the future if a <strong>new kind of stream</strong> is introduced, you will need <strong>just to import one new class</strong> with &nbsp;<strong>BytesSent</strong> and <strong>Length</strong> getters in it.</p>
<h2>2.&nbsp;&nbsp; Graphic Editor</h2>
<p>Refactor code for this task, so <strong>Graphic Editor can draw all kind of shapes</strong> without checking, <strong>what kind is concrete shape.</strong> In the future new shapes will be added to system, so prepare the system for this moments. When you <strong>add new shape</strong>, you just should <strong>add new class and nothing more</strong>.</p>
<h2>3.&nbsp;&nbsp; Detail Printer</h2>
<p>Refactor code for this task, so <strong>Detail Printer</strong> don&rsquo;t need to ask <strong>what kind of employee is passed to it</strong>. Detail Printer need just to print details for all kind of employees. When new kind of employee is added you will need just to <strong>add new class and nothing else.</strong></p>
<h2>4.&nbsp;&nbsp; Recharge</h2>
<p>You are given a library with the following classes</p>
<ul>
<li>Worker implements ISleeper</li>
<li>Employee inherits Worker</li>
<li>Robot inherits Worker</li>
<li>RechargeStation</li>
</ul>
<p>If you inspect the code, you can see that some of the classes have methods that they can't use (throw UnsupportedOpperationException) which is clear indication that the code should be refactored.</p>
<p>Refactor the structure so that it conforms to the <strong>Interface Segregation</strong> principle.</p>
<h3>Hints</h3>
<p>Make the Robot to extend Worker and at the same time to implement Rechargeable</p>
<h2>5.&nbsp;&nbsp; Security Door</h2>
<p>You are given:</p>
<ul>
<li>SecurityManager</li>
<li>abstract class SecurityCheck</li>
<li>interface SecurityUI</li>
</ul>
<p>SecurityManager which can interact with a user by validating his key card or by getting his pin code. Both methods are provided by an interface called SecurityUI. The validation is performed by the appropriate SecurityCheck class.</p>
<p>Refactor the structure so that it conforms to the <strong>Interface Segregation</strong> principle.</p>
<h3>Hints</h3>
<p>Split SecurityUI into smaller role interfaces, one for each SecurityCheck class</p>
<p>&nbsp;</p>