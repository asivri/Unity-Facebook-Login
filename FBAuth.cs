using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;
public class FBAuth : MonoBehaviour {


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
		}
	}
}
