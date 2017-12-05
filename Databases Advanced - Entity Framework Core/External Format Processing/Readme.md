<h1>Exercises: External Format Processing</h1>
<p>This document defines the <strong>exercise assignments</strong> for the <a href="https://softuni.bg/trainings/1741/databases-advanced-entity-framework-october-2017">"Databases Advanced &ndash; EF Core" course @ Software University</a>.</p>
<h3>0. Products Shop</h3>
<p>A products shop holds <strong>users</strong>, <strong>products</strong> and <strong>categories</strong> for the products. Users can <strong>sell</strong> and <strong>buy</strong> products.</p>
<ul>
<li>Users have an <strong>id</strong>, <strong>first</strong> <strong>name</strong> (optional) and <strong>last</strong> <strong>name</strong>, and <strong>age </strong>(optional).</li>
<li>Products have an <strong>id</strong>, <strong>name</strong>, <strong>price</strong>, <strong>buyerId </strong>(optional) and <strong>sellerId</strong> as IDs of users.</li>
<li>Categories have an <strong>id</strong> and <strong>name</strong> (from <strong>3</strong> to <strong>15</strong> characters)</li>
</ul>
<p>Using Entity Framework Code First create a database following the above description.</p>
<p>Configure the following relations in your EF models:</p>
<ul>
<li><strong>Users</strong> should have <strong>many products sold</strong> and <strong>many products bought</strong>.</li>
<li><strong>Products</strong> should have<strong> many categories</strong></li>
<li><strong>Categories</strong> should have <strong>many products</strong></li>
</ul>
<h2>JSON Processing</h2>
<h3>1. Import data</h3>
<p><strong>Import</strong> the data from the provided files (<strong>users.json</strong>, <strong>products.json</strong>,<strong> categories.json</strong>).</p>
<p>Import the <strong>users</strong> first. When importing products, randomly <strong>select the buyer</strong> and <strong>seller</strong> from the existing users. Leave out some <strong>products</strong> that have <strong>not been sold</strong> (i.e. buyer is null).</p>
<p>Randomly <strong>generate categories</strong> for each product from the existing categories.</p>
<h3>2. Query and Export Data</h3>
<p>Write the below described queries and <strong>export</strong> the returned data to the specified <strong>format</strong>.</p>
<p>Note that because of the random generation of the data output probably will be different.</p>
<h4>Query 1 - Products In Range</h4>
<p>Get all products in a specified <strong>price range:</strong>&nbsp; 500 to 1000 (inclusive). Order them by price (from lowest to highest). Select only the <strong>product name</strong>, <strong>price</strong> and the <strong>full name</strong> <strong>of the seller</strong>. Export the result to JSON.</p>
<table>
<tbody>
<tr>
<td>
<p><strong>products-in-range.json</strong></p>
</td>
</tr>
<tr>
<td>
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "name": "TRAMADOL HYDROCHLORIDE",</p>
<p>&nbsp;&nbsp;&nbsp; "price": 516.48,</p>
<p>&nbsp;&nbsp;&nbsp; "seller": "Christine Gomez"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "name": "Allopurinol",</p>
<p>&nbsp;&nbsp;&nbsp; "price": 518.50,</p>
<p>&nbsp;&nbsp;&nbsp; "seller": "Kathy Gilbert"</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "name": "Parsley",</p>
<p>&nbsp;&nbsp;&nbsp; "price": 519.06,</p>
<p>&nbsp;&nbsp;&nbsp; "seller": "Jacqueline Perez"</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h4>Query 2 - Successfully Sold Products</h4>
<p>Get all users who have <strong>at least 1 sold item</strong> with a <strong>buyer</strong>. Order them by <strong>last name</strong>, then by <strong>first name</strong>. Select the person's <strong>first</strong> and <strong>last name</strong>. For each of the <strong>sold products</strong> (products with buyers), select the product's <strong>name</strong>, <strong>price</strong> and the buyer's <strong>first</strong> and <strong>last name</strong>.</p>
<table>
<tbody>
<tr>
<td width="467">
<p><strong>users-sold-products</strong><strong>.json</strong></p>
</td>
</tr>
<tr>
<td width="467">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "firstName": "Carl",</p>
<p>&nbsp;&nbsp;&nbsp; "lastName": "Daniels",</p>
<p>&nbsp;&nbsp;&nbsp; "soldProducts": [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name": "Peter Island Continous sunscreen kids",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price": 471.30,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "buyerFirstName": "Anna",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "buyerLastName": "Parker"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name": "Warfarin Sodium",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price": 1379.79,</p>
<p>&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"buyerFirstName": "Brandon",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "buyerLastName": "Fuller"</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h4>Query 3 - Categories By Products Count</h4>
<p>Get <strong>all</strong> <strong>categories</strong>. Order them by the category&rsquo;s<strong> name</strong>. For each category select its <strong>name</strong>, the <strong>number of products</strong>, the <strong>average price of those products</strong> and the <strong>total revenue</strong> (total price sum) of those products (regardless if they have a buyer or not).</p>
<table>
<tbody>
<tr>
<td width="295">
<p><strong>categories-by-products.json</strong></p>
</td>
</tr>
<tr>
<td width="295">
<p>[</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "category": "Sports",</p>
<p>&nbsp;&nbsp;&nbsp; "productsCount": 49,</p>
<p>&nbsp;&nbsp;&nbsp; "averagePrice": 754.327755,</p>
<p>&nbsp;&nbsp;&nbsp; "totalRevenue": 36962.06</p>
<p>&nbsp; },</p>
<p>&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp; "category": "Adult",</p>
<p>&nbsp;&nbsp;&nbsp; "productsCount": 46,</p>
<p>&nbsp;&nbsp;&nbsp; "averagePrice": 905.283478,</p>
<p>&nbsp;&nbsp;&nbsp; "totalRevenue": 41643.04</p>
<p>&nbsp; },</p>
<p>&nbsp; ...</p>
<p>]</p>
</td>
</tr>
</tbody>
</table>
<h4>Query 4 - Users and Products</h4>
<p>Get all users who have <strong>at least 1 sold product</strong>. Order them by the <strong>number of sold products</strong> (from highest to lowest), then by <strong>last name</strong> (ascending). Select only their <strong>first</strong> and <strong>last name</strong>, <strong>age</strong> and for each product - <strong>name</strong> and <strong>price</strong>.</p>
<p>Export the results to <strong>JSON</strong>. Follow the format below to better understand how to structure your data.</p>
<table>
<tbody>
<tr>
<td width="663">
<p><strong>users-and-products.json</strong></p>
</td>
</tr>
<tr>
<td width="663">
<p>{</p>
<p>"usersCount":35,</p>
<p>"users":</p>
<p>[</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "firstName":"Carl",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lastName":"Daniels",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "age":59,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "soldProducts":</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "count":10,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "products":</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Finasteride",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":1374.01</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Peter Island Continous sunscreen kids",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":471.30</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Warfarin Sodium",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":1379.79</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Gilotrif",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":1454.77</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Cold and Cough",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":218.14</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "firstName": null,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "lastName": "Harris",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "age": 0,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "soldProducts":</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "count":9,</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "products":</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; [</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "name":"Clarins Paris Skin Illusion &ndash; 114 cappuccino",</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; "price":811.42</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ]</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; },</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>]</p>
<p>}</p>
</td>
</tr>
</tbody>
</table>
<h2>XML Processing</h2>
<h3>1. Import Data</h3>
<p><strong>Import</strong> the data from the provided files (<strong>users.xml</strong>, <strong>products.xml</strong>,<strong> categories.xml</strong>).</p>
<p>Import the <strong>users</strong> first. When importing products, randomly <strong>select the buyer</strong> and <strong>seller</strong> from the existing users. Leave out some <strong>products</strong> that have <strong>not been sold</strong> (i.e. buyer is null).</p>
<p>Randomly <strong>generate categories</strong> for each product from the existing categories.</p>
<h3>2. Query and Export Data</h3>
<p>Write the below described queries and <strong>export</strong> the returned data to the specified <strong>format</strong>. Make sure that Entity Framework generates only a <strong>single query</strong> for each task.</p>
<h4>Query 1 - Products In Range</h4>
<p>Get all products in a specified <strong>price range</strong> between 1000 and 2000 (inclusive) which have a <strong>buyer</strong>. Order them by price (from lowest to highest). Select only the <strong>product name</strong>, <strong>price</strong> and the <strong>full name</strong> <strong>of the buyer</strong>. Export the result to XML.</p>
<table>
<tbody>
<tr>
<td width="683">
<p><strong>products-in-range.xml</strong></p>
</td>
</tr>
<tr>
<td width="683">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;products&gt;</p>
<p>&nbsp; &lt;product name="TYLENOL COLD MULTI-SYMPTOM DAYTIME" price="1010.81" buyer="Sandra Riley" /&gt;</p>
<p>&nbsp; &lt;product name="Butalbital, Aspirin and Caffeine" price="1010.98" buyer=" Bennett" /&gt;</p>
<p>&nbsp; &lt;product name="SEPHORA Acne-Fighting Mattifying Moisturizer" price="1019.28" buyer="Patricia Cooper" /&gt;</p>
<p>&nbsp;&lt;/products&gt;</p>
</td>
</tr>
</tbody>
</table>
<h4>Query 2 - Sold Products</h4>
<p>Get all users who have <strong>at least 1 sold item</strong>. Order them by <strong>last name</strong>, then by <strong>first name</strong>. Select the person's <strong>first</strong> and <strong>last name</strong>. For each of the <strong>sold products</strong>, select the product's <strong>name</strong> and <strong>price</strong>.</p>
<table>
<tbody>
<tr>
<td width="614">
<p><strong>users-sold-products.xml</strong></p>
</td>
</tr>
<tr>
<td width="614">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;users&gt;</p>
<p>&nbsp; &lt;user first-name="Carl" last-name="Daniels"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;sold-products&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;name&gt;Peter Island Continous sunscreen kids&lt;/name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;price&gt;471.30&lt;/price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/product&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;name&gt;Warfarin Sodium&lt;/name&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;price&gt;1379.79&lt;/price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/product&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;/sold-products&gt;</p>
<p>&lt;/user&gt;</p>
<p>...</p>
<p>&lt;/users&gt;</p>
</td>
</tr>
</tbody>
</table>
<h4>Query 3 - Categories By Products Count</h4>
<p>Get <strong>all</strong> <strong>categories</strong>. Order them by the <strong>number of products</strong> in that category (a product can be in many categories). For each category select its <strong>name</strong>, the <strong>number of products</strong>, the <strong>average price of those products</strong> and the <strong>total revenue</strong> (total price sum) of those products (regardless if they have a buyer or not).</p>
<table>
<tbody>
<tr>
<td width="518">
<p><strong>categories-by-products.xml</strong></p>
</td>
</tr>
<tr>
<td width="518">
<p>&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;categories&gt;</p>
<p>&nbsp; &lt;category name="Sports"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;products-count&gt;49&lt;/products-count&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;average-price&gt;754.327755&lt;/average-price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;total-revenue&gt;36962.06&lt;/total-revenue&gt;</p>
<p>&nbsp; &lt;/category&gt;</p>
<p>&nbsp; &lt;category name="Adult"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;products-count&gt;46&lt;/products-count&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;average-price&gt;905.283478&lt;/average-price&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;total-revenue&gt;41643.04&lt;/total-revenue&gt;</p>
<p>&nbsp; &lt;/category&gt;</p>
<p>...</p>
<p>&lt;/categories&gt;</p>
</td>
</tr>
</tbody>
</table>
<h4>Query 4 - Users and Products</h4>
<p>Get all users who have <strong>at least 1 sold product</strong>. Order them by the <strong>number of sold products</strong> (from highest to lowest), then by <strong>last name</strong> (ascending). Select only their <strong>first</strong> and <strong>last name</strong>, <strong>age</strong> and for each product - <strong>name</strong> and <strong>price</strong>.</p>
<p>Export the results to <strong>XML</strong>. Follow the format below to better understand how to structure your data.</p>
<table>
<tbody>
<tr>
<td width="663">
<p><strong>users-and-products.xml</strong></p>
</td>
</tr>
<tr>
<td width="663">
<p>&nbsp;&lt;?xml version="1.0" encoding="utf-8"?&gt;</p>
<p>&lt;users count="35"&gt;</p>
<p>&nbsp; &lt;user first-name="Carl" last-name="Daniels" age="59"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;sold-products count="10"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product name="Finasteride" price="1374.01" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product name="Peter Island Continous sunscreen kids" price="471.30" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product name="Warfarin Sodium" price="1379.79" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product name="Gilotrif" price="1454.77" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product name="Cold and Cough" price="218.14" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/sold-products&gt;</p>
<p>&nbsp; &lt;/user&gt;</p>
<p>&nbsp; &lt;user last-name="Harris"&gt;</p>
<p>&nbsp;&nbsp;&nbsp; &lt;sold-products count="9"&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &lt;product name="Clarins Paris Skin Illusion - 114 cappuccino" price="811.42" /&gt;</p>
<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ...</p>
<p>&nbsp;&nbsp;&nbsp; &lt;/sold-products&gt;</p>
<p>&nbsp; &lt;/user&gt;</p>
<p>&nbsp; ...</p>
<p>&lt;/users&gt;</p>
</td>
</tr>
</tbody>
</table>
<p>&nbsp;</p>