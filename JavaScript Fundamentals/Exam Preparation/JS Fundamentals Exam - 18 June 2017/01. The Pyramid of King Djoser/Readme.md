<h1>Problem 1 &ndash; The Pyramid of King Djoser</h1>
<p><em>Glory to Imhotep, Creator of all things material, Chancellor of the King of Egypt, Doctor, First in line after the King of Upper Egypt, Administrator of the Great Palace, Hereditary nobleman, High Priest of Heliopolis, Builder, Chief Carpenter, Chief Sculptor, and Maker of Vases in Chief. It is by King Djoser&rsquo;s decree that on this day we shall commence the construction of a Great Pyramid for our King. Imhotep, son of Ptah, demands that you honour your King by calculating the building materials needed to finish His home for the Afterlife.</em></p>
<p>Write a JS program that calculates how much resources will be required for the construction of a pyramid. It is made out of <strong>stone</strong>, <strong>marble</strong>, <strong>lapis lazuli</strong> and <strong>gold</strong>. Your program will receive an integer that will be the <strong>base</strong> width and length of the pyramid and an <strong>increment</strong>, that is the height of each step. The bulk is made out of stone, while the <strong>outer layer</strong> is made out of marble. <strong>Every fifth step&rsquo;s</strong> outer layer is made out of lapis lazuli <strong>instead</strong> of marble. The <strong>final step</strong> is made out of gold.</p>
<p>The pyramid is built with <strong>1x1 blocks</strong> with <strong>height</strong> equal to the given <strong>increment</strong>. The first step of the pyramid has <strong>width</strong> and <strong>length</strong> equal to the given <strong>base</strong> and every next step is <strong>reduced by 2 blocks</strong> (1 from each side). The height of every step equals the given <strong>increment</strong>. See the drawing for an example. White steps are covered in marble, blue steps are covered in lapis lazuli (<strong>every fifth layer from the bottom</strong>), and yellow steps are made <strong>entirely</strong> out of gold (<strong>top-most step</strong>).</p>
<p>Since the <strong>outer layer</strong> of each step is made of a decorative material, to calculate the required stone for one step, reduce the width and length by 2 blocks (one from each side), find it&rsquo;s area and multiply it by the increment. The rest of the step is made out of lapis lazuli for every fifth step from the bottom and marble for all other steps. To find the amount needed, you may, for example, find its perimeter and reduce it by 4 (to compensate for the overlapping corners) and multiply the result by the increment. See the drawing for details (grey is stone, white is decoration).</p>
<table>
<tbody>
<tr>
<td width="232">&nbsp;</td>
<td width="232">&nbsp;</td>
<td width="232">&nbsp;</td>
</tr>
<tr>
<td width="232">
<p>5x5 step</p>
<p>Stone required &ndash; 9 x increment</p>
<p>Marble required &ndash; 16 x increment</p>
</td>
<td width="232">
<p>7x7 step</p>
<p>Stone required &ndash; 25 x increment</p>
<p>Marble required &ndash; 24 x increment</p>
</td>
<td width="232">
<p>8x8 step</p>
<p>Stone required &ndash; 36 x increment</p>
<p>Marble required &ndash; 28 x increment</p>
</td>
</tr>
</tbody>
</table>
<p>Note the top-most layer is made entirely out of gold, with height equal to the given increment. See the examples for complete calculations.</p>
<h3>Input</h3>
<p>You will receive two <strong>number</strong> parameters <strong>base</strong> and <strong>increment</strong>.</p>
<h3>Output</h3>
<p>Print on the <strong>console</strong> on separate lines the <strong>total</strong> required <strong>amounts</strong> of each material <strong>rounded up</strong> and the <strong>final height</strong> of the pyramid <strong>rounded down</strong>, as shown in the examples.</p>
<h3>Constraints</h3>
<ul>
<li>The <strong>base </strong>will always be an integer greater than zero</li>
<li>The <strong>increment</strong> will always be a number greater than zero</li>
<li>MAX_SAFE_INTEGER will <strong>never be exceeded</strong> for any of the calculations</li>
</ul>
<h3>Examples</h3>
<table width="695">
<tbody>
<tr>
<td width="55">
<p><strong>Input</strong></p>
</td>
<td width="217">
<p><strong>Output</strong></p>
</td>
<td colspan="6" width="423">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td rowspan="8" width="55">
<p>11,</p>
<p>1</p>
</td>
<td rowspan="8" width="217">
<p>Stone required: 165</p>
<p>Marble required: 112</p>
<p>Lapis Lazuli required: 8</p>
<p>Gold required: 1</p>
<p>Final pyramid height: 6</p>
</td>
<td width="47">
<p>Step</p>
</td>
<td width="75">
<p>Size</p>
</td>
<td width="75">
<p>Stone</p>
</td>
<td width="75">
<p>Marble</p>
</td>
<td width="75">
<p>Lapis</p>
</td>
<td width="75">
<p>Gold</p>
</td>
</tr>
<tr>
<td width="47">
<p>1<sup>st</sup></p>
</td>
<td width="75">
<p>11x11</p>
</td>
<td width="75">
<p>81</p>
</td>
<td width="75">
<p>40</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>-</p>
</td>
</tr>
<tr>
<td width="47">
<p>2<sup>nd</sup></p>
</td>
<td width="75">
<p>9x9</p>
</td>
<td width="75">
<p>49</p>
</td>
<td width="75">
<p>32</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>-</p>
</td>
</tr>
<tr>
<td width="47">
<p>3<sup>rd</sup></p>
</td>
<td width="75">
<p>7x7</p>
</td>
<td width="75">
<p>25</p>
</td>
<td width="75">
<p>24</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>-</p>
</td>
</tr>
<tr>
<td width="47">
<p>4<sup>th</sup></p>
</td>
<td width="75">
<p>5x5</p>
</td>
<td width="75">
<p>9</p>
</td>
<td width="75">
<p>16</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>-</p>
</td>
</tr>
<tr>
<td width="47">
<p>5<sup>th</sup></p>
</td>
<td width="75">
<p>3x3</p>
</td>
<td width="75">
<p>1</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>8</p>
</td>
<td width="75">
<p>-</p>
</td>
</tr>
<tr>
<td width="47">
<p>6<sup>th</sup></p>
</td>
<td width="75">
<p>1x1</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>-</p>
</td>
<td width="75">
<p>1</p>
</td>
</tr>
<tr>
<td width="47">
<p>total</p>
</td>
<td width="75">
<p>Height=6</p>
</td>
<td width="75">
<p>165</p>
</td>
<td width="75">
<p>112</p>
</td>
<td width="75">
<p>8</p>
</td>
<td width="75">
<p>1</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="55">
<p><strong>Input</strong></p>
</td>
<td width="217">
<p><strong>Output</strong></p>
</td>
<td width="423">
<p><strong>Explanation</strong></p>
</td>
</tr>
<tr>
<td width="55">
<p>11,</p>
<p>0.75</p>
</td>
<td width="217">
<p>Stone required: 124</p>
<p>Marble required: 84</p>
<p>Lapis Lazuli required: 6</p>
<p>Gold required: 1</p>
<p>Final pyramid height: 4</p>
</td>
<td width="423">
<p>Total <strong>stone</strong> is 81*0.75+49*0.75+25*0.75+9*0.75+1*0.75 = 123.75, we round up to 124.</p>
<p>Total <strong>marble</strong> is 40*0.75+32*0.75+24*0.75+16*0.75=84.</p>
<p>Total <strong>lapis lazuli</strong> is 8*0.75=6.</p>
<p>Total <strong>gold</strong> is 1*0.75=0.75, we round up to 1.</p>
<p>Total <strong>height</strong> is 4.5 (6 <strong>steps</strong> times 0.75), we round down to 4.</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>
<table width="695">
<tbody>
<tr>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
<td rowspan="2" width="53">
<p><strong>&nbsp;</strong></p>
</td>
<td width="76">
<p><strong>Input</strong></p>
</td>
<td width="246">
<p><strong>Output</strong></p>
</td>
</tr>
<tr>
<td width="76">
<p>12,</p>
<p>1</p>
</td>
<td width="246">
<p>Stone required: 220</p>
<p>Marble required: 128</p>
<p>Lapis Lazuli required: 12</p>
<p>Gold required: 4</p>
<p>Final pyramid height: 6</p>
</td>
<td width="76">
<p>23,</p>
<p>0.5</p>
</td>
<td width="246">
<p>Stone required: 886</p>
<p>Marble required: 228</p>
<p>Lapis Lazuli required: 36</p>
<p>Gold required: 1</p>
<p>Final pyramid height: 6</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>