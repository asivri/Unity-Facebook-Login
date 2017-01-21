using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;
public class FBAuth : MonoBehaviour {

	//Initialization of Game Objects which will be used to hide or display the login 
	//button depends on the login status.
	public GameObject DisplayButton; //Drag and Drop the GameObject which refers the not logged in status.
	public GameObject HideButton;	 //Drag and Drop the GameObject which refers the user already logged in.
	public GameObject NameObject;
	public GameObject ImageObject;

	//This parameters will be used to show user's name and profile picture which comes from FB.
	Text FirstName;
	Image ProfileImage;


	//Awake, CheckForLoging and OnHideUnity functions are used for initialization for Facebook SDK.
	//Instead of using Start and Update we are using Awake function.
	void Awake()
	{
		FB.Init (CheckForLogin, OnHideUnity);
	}

	void CheckForLogin()
	{
		if (FB.IsLoggedIn) {
			Debug.Log ("Logged in");
		}
		else
		{
			Debug.Log ("Not logged in yet");
		}

		ButtonDisplayManager (FB.IsLoggedIn);
	}

	void OnHideUnity(bool isGameShown)
	{
		if (isGameShown == false) {
			Time.timeScale = 0;
		}
		else {
			Time.timeScale = 1;
		}
	}

	public void LoginViaFB()
	{
		List<string> permissions = new List<string> ();
		permissions.Add ("public_profile"); //You can include other details like email, user_friends etc. to reach deeper info.

		/*
		 Another way to do it (From Official FB Tutorial)
		 var permissions = new List<string>(){"public_profile"};
		 */

		FB.LogInWithReadPermissions (permissions, AuthCallBack);
	}

	void AuthCallBack(ILoginResult result)
	{
		if (result.Error != null)//If there is an error. 
		{ 
			Debug.Log (result.Error); //Just to see the error on console.
		} 
		else
		{
			if (FB.IsLoggedIn) {
				Debug.Log ("Logged in");
			}
			else
			{
				Debug.Log ("Not logged in yet");
			}

			ButtonDisplayManager (FB.IsLoggedIn);
		}
	}

	//There can also be an animation instead of SetActive. 
	void ButtonDisplayManager(bool isIn)
	{
		if (isIn) {
			DisplayButton.SetActive (false);
			HideButton.SetActive (true);

			//This is the REST API part of the facebook. We can also use .POST etc.
			FB.API ("/me?fields=first_name", HttpMethod.GET, DisplayFirstName);
			FB.API("/me/picture?type=square&height=350&width=440", HttpMethod.GET, DisplayProfileImage);

		}
		else
		{
			DisplayButton.SetActive (true);
			HideButton.SetActive (false);
		}
	}

	void DisplayFirstName(IResult result)
	{
		FirstName = NameObject.GetComponent<Text> ();

		if (result.Error == null) 
		{
			FirstName.text = "Welcome back " + result.ResultDictionary ["first_name"];
		}
	}

	void DisplayProfileImage(IGraphResult result) //The important thing is result paramater turns to IGraphResult!!!
	{
		ProfileImage = ImageObject.GetComponent<Image> ();

		if (result.Texture == null)
		{
			//An idea to implement if there is no profile image: We can use random pictures related to our game like animals, flags etc.
		} 
		else
		{
			ProfileImage.sprite = Sprite.Create (result.Texture, new Rect (0, 0, 440, 350), new Vector2());	
		}

	}
}
