using UnityEngine;
using System.Collections;

public class PlayerMotor : MonoBehaviour {

	private CharacterController contorller;
	private Vector3 moveVector;
	private float speed = 5.0f;
	private float verticalVelocity = 0.0f;
	private float gravity = 12.0f;
	private float animationDuration = 3.0f;
	void Start () {
	
		contorller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time < animationDuration) 
		{
			contorller.Move (Vector3.forward *speed * Time.deltaTime);
			return;
		
		}

		moveVector = Vector3.zero;
		if (contorller.isGrounded) {
			verticalVelocity = 0.0f;
		}
		else {
			verticalVelocity -= gravity * Time.deltaTime;
		}

		//X - left and Right
		moveVector.x = Input.GetAxisRaw("Horizontal") * speed;

		//Y - Up and Down
		moveVector.y=verticalVelocity;

		//Z- Forword and backword
		moveVector.z=speed;
	
		contorller.Move (moveVector * Time.deltaTime * (speed-2));
	}
}
