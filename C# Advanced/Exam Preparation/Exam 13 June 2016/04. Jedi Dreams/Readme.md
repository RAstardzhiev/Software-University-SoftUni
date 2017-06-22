<h1>Problem 4 &ndash; Jedi Dreams</h1>
<p>Now, here is Ivan. He is a young padawan. He thinks that, he can learn how to use the Force, but that is not true.&nbsp; He dreams about how one day, he will hack The Dark Side Judge System and become a Master Jedi.</p>
<p>Your task is simple. Help Ivan to understand how the Force works and hack the Judge together.</p>
<p>Actually, you need to solve one hard programming problem.</p>
<p>You are given a source code with valid syntax. Your task is to find where all method invokes happen. For each declared method, you need to find all invoked methods in it. See the example below for better clarification.</p>
<p>For your convenience the code, has some limitations to make the task easier.</p>
<ul>
<li>The code will be fully understandable by your current level at Java Jedi Part 2. There will be no strange structures, object oriented programming, unknown keywords, whatsoever&hellip;</li>
<li><strong>All method declarations will be static</strong> without any access modifiers such as &ldquo;public&rdquo;, &ldquo;private&rdquo; and &ldquo;protected&rdquo;.</li>
<li>The code will not be <strong>necessary compiling</strong> but will be with valid syntax.</li>
<li><strong>All method names</strong> will be on the same line with the <strong>static</strong></li>
<li>There will <strong>not </strong>be any other static declarations <strong>except for the methods</strong>.</li>
<li>There will <strong>not</strong> be any <strong>commented code or code in strings</strong>.</li>
<li>Brackets are your best friends.</li>
</ul>
<p>You will be given <strong>N</strong> lines with source code. Find <strong>all</strong> method invokes in a particular method declaration.</p>
<p>Each declared method must be <strong>ordered</strong> by the <strong>count</strong> of the methods invoked in it &ndash; <strong>descending order</strong>. If two declared methods are with the same count of inner calls, print them in <strong>alphabetical order</strong>. All invoked methods must be sorted <strong>alphabetically</strong>. &nbsp;Print them in the following format:</p>
<p><strong>&ldquo;{method name} -&gt; {number of calls} -&gt; {invoked method 1, invoked method2, &hellip;}&rdquo;</strong></p>
<p>If there are no invoked methods in certain declaration, print:</p>
<p><strong>&ldquo;{method name} -&gt; None&rdquo;</strong></p>
<p>See the examples below for more information.</p>
<h3>Input</h3>
<ul>
<li>On the first input line you will be given the number <strong>N</strong>.</li>
<li>On the next <strong>N </strong>lines you will be given lines of code.</li>
</ul>
<h3>Output</h3>
<ul>
<li>The output data should be printed on the console.</li>
<li>Each method declaration must be printed on a separate line, in which you show all invoked methods in it in the format described above.</li>
</ul>
<h3>Constraints</h3>
<ul>
<li><strong>N </strong>will be between 10 and 200, inclusive.</li>
<li>The input data will <strong>always be valid</strong> and in the format described. There is no need to check it explicitly.</li>
<li>All method names will contains at least one <strong>uppercase</strong></li>
</ul>
<p>&nbsp;</p>
<table width="768">
<tbody>
<tr>
<td width="768">
<p><strong>Example Input</strong></p>
</td>
</tr>
<tr>
<td width="768">
<p>46</p>
<p>static void InitPatterns(List&lt;bool[,]&gt; patterns)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // zero</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; patterns.Add(new bool[,]</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //<strong>TODO</strong></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; });</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // one</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; patterns.Add(new bool[,]</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //<strong>TODO</strong></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; });</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; static bool CheckCurrentPattern(int[,] numbers , bool[,] pattern , int row , int col , int digit)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for(int i = 0; i &lt; pattern.GetLength(0); i++)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for(int j = 0; j &lt; pattern.GetLength(1); j++)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;{</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //<strong>TODO</strong></p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; return true;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; static void Main(string[] args)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; int n = int.Parse(Console.ReadLine());</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; int[,] numbers = new int[n , n];</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for(int i = 0; i &lt; n; i++)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; var currentNumbers = Console.ReadLine().Split(' ')</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; for(int j = 0; j &lt; currentNumbers.Length; j++)</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; numbers[i , j] = int.Parse(currentNumbers[j]);</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; List&lt;bool[,]&gt; patterns = new List&lt;bool[,]&gt;();</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; InitPatterns(patterns);</p>
</td>
</tr>
<tr>
<td width="768">
<p><strong>Example Output</strong></p>
</td>
</tr>
<tr>
<td width="768">
<p>Main -&gt; 6 -&gt; InitPatterns, Parse, Parse, ReadLine, ReadLine, Split</p>
<p>CheckCurrentPattern -&gt; 2 -&gt; GetLength, GetLength</p>
<p>InitPatterns -&gt; 2 -&gt; Add, Add</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>