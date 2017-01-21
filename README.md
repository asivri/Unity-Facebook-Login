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
	<a href="http://hizliresim.com/GP77rr"><img src="http://i.hizliresim.com/GP77rr.png"></a>
	<br>
  </li>
  <li>Create a new application on developers.facebook.com
   <a href="http://hizliresim.com/l3XXAQ"><img src="http://i.hizliresim.com/l3XXAQ.png"></a>
   <br>
   </li>
   <li>Click to Edit Settings on Facebook tab. 
   <a href="http://hizliresim.com/X9GGZ5"><img src="http://i.hizliresim.com/X9GGZ5.png"></a>
   <br>
   </li>
   <li>Get your Application name and ID on your app dashboard on developers.facebook.com. Copy that ID and paste on the inspector which opened on Unity.
   <a href="http://hizliresim.com/jXMMoW"><img src="http://i.hizliresim.com/jXMMoW.png"></a>
   <a href="http://hizliresim.com/Qv559j"><img src="http://i.hizliresim.com/Qv559j.png"></a>
   <br>
   </li>
   <li>Paste the code in the script above to and empty script on Unity</li>
   <li>Create a new GUI</li>
   <li>Create new to empty game objects which will be used to state if the user logged in or not.</li>
   <li>Create a new login button under the game object which refers the not logged in status.</li>
   <li>Create a new image and text under the game object which refers logged in status.</li>
   <li>Empty a new game object not under anything in hierarchy as a script contoller and drag and drop our script.</li>
   <li>Drag and drop necessary items as it shown below:
   <a href="http://hizliresim.com/3v55Q9"><img src="http://i.hizliresim.com/3v55Q9.png"></a>
   <br>
   </li>
   <li>Run the game</li>
   <li>Unity will ask a User Access Token that you can reach <a href="https://developers.facebook.com/tools/accesstoken/">Here</a></li>
</ol>

<h2>Sources</h2>
<p>When I was implementing the code, I followed the by <a href="https://www.youtube.com/watch?annotation_id=annotation_1019767461&feature=iv&src_vid=nmeMHY5D4SI&v=7fuhQDTNVGk">Here</a> Grey Zoned.

 <h2>License</h2>
 <p>License 
Copyright © 2017 Ahmet Ozan Sivri asivri@fredonia.edu This work is free. You can redistribute it and/or modify it 
under the terms of the Do What The Fuck You Want To Public License, Version 2, as published by Sam Hocevar. See http://www.wtfpl.net/ for more details.</p>

<bold>Note: It can be licensed under  Do What The Fuck You Want To Public License it still can be necessary to refer Grey Zoned's video as a source.</bold>

