<h2>* Thea the Photographer</h2>
<p><strong><em>This problem is from the </em></strong><strong><em>Programming Fundamentals Retake Exam (11 September 2016).</em></strong></p>
<p>Thea is a photographer. She takes pictures of people on special events. She is a good friend and you want to help her.</p>
<p>She wants to inform her clients when their pictures will be ready. Since the number of pictures is big and it requires time for editing (#nofilter, #allnatural)<strong> every</strong> single picture - you decide to write a program in order to help her.</p>
<p>Thea follows this pattern: first she takes <strong>all</strong> pictures. Then she goes through every single picture to <strong>filter</strong> these pictures that are considered "good". Then she needs to upload every single <strong>filtered</strong> picture to her cloud. She is considered ready when all <strong>filtered</strong> pictures are <strong>uploaded </strong>in her picture storage.</p>
<p>You will receive the <strong>amount</strong> of pictures she had taken. Then the approximate <strong>time</strong> in <strong>seconds</strong> for every picture to be filtered. Then a <strong>filter factor</strong> &ndash; a <strong>percentage</strong> (integer number) of the <strong>total photos</strong> (rounded to the nearest <strong>bigger</strong> <strong>integer</strong> value e.g. 5.01 -&gt; 6) that are good enough to be given to her clients (Photoshop may do miracles but Thea does not). Approximate <strong>time</strong> for every picture to be uploaded will be given again in <strong>seconds</strong>. Your task is: based on this input to display total time needed for her to be ready with the pictures in given below format.</p>
<h3>Input</h3>
<p>On the first line you will receive an integer <strong>N</strong> &ndash; the amount of pictures Thea had taken.</p>
<p>On the second line you will receive an integer <strong>FT</strong> &ndash; the amount of time (filter time) in seconds that Thea will require to filter every single picture.</p>
<p>On the third line you will receive an integer <strong>FF</strong> &ndash; the filter factor or the percentage of the total pictures that are considered &ldquo;good&rdquo; to be uploaded.</p>
<p>On the fourth line you will receive an integer <strong>UT</strong> &ndash; the amount of time needed for every <strong>filtered</strong> picture to be uploaded to her storage.</p>
<p>The input will be in the described format, there is no need to check it explicitly.</p>
<h3>Output</h3>
<p>Print the amount of time Thea will need in order to have her pictures ready to be sent to her client in given format:</p>
<p>d:HH:mm:ss</p>
<p>d - days needed &ndash; starting from 0.</p>
<p>HH &ndash;&nbsp; hours needed &ndash; from 00 to 24.</p>
<p>mm &ndash; minutes needed &ndash; from 00 to 59.</p>
<p>ss &ndash; minutes needed &ndash; from 00 to 59.</p>
<h3>Constraints</h3>
<p>The amount of total pictures Thea will have taken is range [0 &hellip; 1&nbsp;000&nbsp;000]</p>
<p>The seconds for both filtering and uploading will be in range [0 &hellip; 100&nbsp;000]</p>
<p>The filter factor will be an integer number between [0 &hellip; 100].</p>
<h3>Examples</h3>
<table width="692">
<tbody>
<tr>
<td width="297">
<p><strong>Input</strong></p>
</td>
<td width="127">
<p><strong>Output</strong></p>
</td>
<td width="268">
<p><strong>Comments</strong></p>
</td>
</tr>
<tr>
<td width="297">
<p>1000</p>
<p>1</p>
<p>50</p>
<p>1</p>
</td>
<td width="127">
<p>0:00:25:00</p>
</td>
<td width="268">
<p>Total pictures = 1&nbsp;000, 50% of them are useful -&gt; Filtered pictures = 500</p>
<p>Total pictures * filter time = 1000 s</p>
<p>Filtered pictures * upload time = 500 s</p>
<p>Total time = 1500 s</p>
</td>
</tr>
<tr>
<td width="297">
<p>5342</p>
<p>2</p>
<p>82</p>
<p>3</p>
</td>
<td width="127">
<p>0:06:37:07</p>
</td>
<td width="268">
<p>Total pictures = 5342 - 82% of them are useful -&gt; 4380.44-&gt; 4381 filtered.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>