<h1><bold>Facebook Authentication in Unity</bold><h1>

<i>Version Note: In this repository I used Facebook SDK 7.9 and Unity 5.5. </i>
<br>

<h2>Overview</h2>

<p> I created a script to better understanding the authentication in games using Facebook. </p>
 
 <br>
 
<h2>Tools to Install Before Use</h2>
<ul>
  <li>Unity 5.5</li>
  <li>Facebook SDK</li>
</ul>

<br>

<h2>Implementation</h2>
<ol type="1">
  <li>Create a new project on Unity.</li>
  <li>Import Facebook SDK Asset
	<img src="first.jpg">
  </li>
  <li>Create a new application on developers.facebook.com
   <img src="second.jpg">
   </li>
   <li>Click to Edit Settings on Facebook tab. 
   <img src="third.jpg">
   </li>
   <li>Get your Application name and ID on your app dashboard on developers.facebook.com. Copy that ID and paste on the inspector which opened on Unity.
   <img src="fourth.jpg">
   <img src="fifth.jpg">
   </li>
   <li>Paste the code in the script above to and empty script on Unity</li>
   <li>Create a new GUI</li>
   <li>Create new to empty game objects which will be used to state if the user logged in or not.</li>
   <li>Create a new login button under the game object which refers the not logged in status.</li>
   <li>Create a new image and text under the game object which refers logged in status.</li>
   <li>Empty a new game object not under anything in hierarchy as a script contoller and drag and drop our script.</li>
   <li>Drag and drop necessary items as it shown below:
   <img src="sixth.jpg">
   </li>
   <li>Run the game</li>
   <li>Unity will ask a User Access Token that you can reach <a href="https://developers.facebook.com/tools/accesstoken/">Here</a></li>
   
   
</ol>

 


