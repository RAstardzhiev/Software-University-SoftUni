<h1>Lab: Unit Testing</h1>
<h1>Part I: Unit Testing Basics</h1>
<h2>1.&nbsp;&nbsp; Test Axe</h2>
<p>Load provided solution in Visual Studio. Add new project <strong>Tests</strong></p>
<p>Create a class AxeTests</p>
<p>Create the following tests:</p>
<ul>
<li>Test if weapon loses durability after each attack</li>
<li>Test attacking with a broken weapon</li>
</ul>
<h3>&nbsp;</h3>
<h2>2.&nbsp;&nbsp; Test Dummy</h2>
<p>Create a class DummyTests</p>
<p>Create the following tests:</p>
<ul>
<li>Dummy loses health if attacked</li>
<li>Dead Dummy throws exception if attacked</li>
<li>Dead Dummy can give XP</li>
<li>Alive Dummy can't give XP</li>
</ul>
<h3>Hints</h3>
<p>Follow the logic of the previous problem</p>
<h2>3.&nbsp;&nbsp; Refactor Tests</h2>
<p>Refactor the tests for Axe and Dummy classes</p>
<p>Make sure that:</p>
<ul>
<li><strong>Names</strong> of test methods are <strong>descriptive</strong></li>
<li>You use <strong>appropriate</strong> <strong>assertions</strong> (assert equals vs assert true)</li>
<li>You use <strong>assertion</strong> <strong>messages</strong></li>
<li>There are <strong>no magic numbers</strong></li>
<li>There is <strong>no code duplication</strong> (Don&rsquo;t Repeat Yourself)</li>
</ul>
<h3>Hints</h3>
<p>Extract constants and private fields for Axe class</p>
<p>Create a method that executes <strong>before each test</strong></p>
<p>Make use of constants and private fields, as well as add assertion messages</p>
<p>Follow the same logic for other test methods and TestDummy class</p>
<h1>Part II: Dependencies</h1>
<h2>4.&nbsp;&nbsp; Fake Axe and Dummy</h2>
<p>Test if hero gains XP when target dies</p>
<p>To do this, you need to:</p>
<ul>
<li>Make <strong>Hero</strong> class <strong>testable</strong> (use <strong>Dependency Injection</strong>)</li>
<li>Introduce <strong>Interfaces</strong> for Axe and Dummy
<ul>
<li>Interface Weapon</li>
<li>Interface Target</li>
</ul>
</li>
</ul>
<p>Create fake Weapon and fake Dummy for the test</p>
<h3>Hints</h3>
<p>Create <strong>I</strong><strong>Weapon and ITarget</strong> interface. Modify implementation methods to <strong>make use of interfaces. </strong>Modify both <strong>Axe</strong> and <strong>Dummy</strong> classes.</p>
<p>Use <strong>Dependency Injection</strong> for Hero class</p>
<p>Create HeroTests class and test gaining XP functionality by faking Weapon and Target classes</p>
<h2>5.&nbsp;&nbsp; Mocking</h2>
<p>Include Moq in the project dependencies, then:</p>
<ul>
<li>Mock fakes from previous problem Hints</li>
</ul>
<p>Go to HeroTests and refactor the code, making use of Moq</p>