using UnityEngine;
using System.Collections;

public class ScreenOrientationC : MonoBehaviour {

	// Use this for initialization

		public bool orientationPortrait; 
		public bool orientationLandscape; 
		
	void Start () {



			
		Invoke ("screenOrientation",1);
	
		 
	}
	
	 
	// Update is called once per frame
	void Update () {
	




	}

	void screenOrientation(){

		
		if(orientationLandscape==true){
			
			Screen.orientation = ScreenOrientation.LandscapeRight;
		}
		if(orientationPortrait==true){
			Screen.orientation = ScreenOrientation.Portrait;
		}
		if(orientationLandscape==true && orientationPortrait==true){
			

			Screen.orientation = ScreenOrientation.AutoRotation;
			Screen.autorotateToLandscapeRight = true;
			Screen.autorotateToLandscapeLeft = true;
			Screen.autorotateToPortrait = true;
		}


	}
}
