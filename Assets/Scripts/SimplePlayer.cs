using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SimplePlayer : MonoBehaviour {
	
	Animator animator;
	public Text CurrentAnimation;
	public GameObject AnimationButton;


	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		CurrentAnimation.text = "No Animation";

	
	} 
	
	// Update is called once per frame
	void Update () {

		if (this.transform.GetComponent<Renderer> ().isVisible ) {
			CurrentAnimation.gameObject.transform.parent.gameObject.SetActive (true);
			AnimationButton.SetActive (true);
		} else {
			CurrentAnimation.gameObject.transform.parent.gameObject.SetActive (false);
			AnimationButton.SetActive (false);
		}

		if (Input.GetKeyDown (KeyCode.R)) {

		



			if (animator.GetBool ("Idle1") == true) {
				animator.SetBool ("Run", true);
				animator.SetBool ("Idle1", false);
			} else {
				animator.SetBool ("Idle1", true);
				animator.SetBool ("Run", false);
			}
			Debug.Log (animator.GetBool ("Idle1"));
			//Invoke ("ResetTransition",0.01f);

		}




	}

	public void CycleAnimation(){

		Debug.Log ("cycle");



		if (animator.GetBool ("Idle1") == true) {
			animator.SetBool ("Run", true);
			animator.SetBool ("Idle1", false);
			CurrentAnimation.text="Runing";
		} else {
			animator.SetBool ("Idle1", true);
			animator.SetBool ("Run", false);
			CurrentAnimation.text="Idle";
		}
		Debug.Log (animator.GetBool ("Idle1"));
		//Invoke ("ResetTransition",0.01f);

	}

}
