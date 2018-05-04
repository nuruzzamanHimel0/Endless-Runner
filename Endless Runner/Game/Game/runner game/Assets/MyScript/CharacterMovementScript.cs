using UnityEngine;
using System.Collections;

public class CharacterMovementScript : MonoBehaviour {

	private Animator animator;
	private int lane;
	private Vector3 newPosition;
	void Start () {
		
		animator = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			animator.SetBool ("sliding",true);
			Invoke ("stopSliding",0.1f);
		}



	
	}


	void stopSliding()
	{
		animator.SetBool ("sliding",false);
	}
}
