using UnityEngine;
using System.Collections;

public class CameraConrtoller : MonoBehaviour {

	public GameObject Player;

	private Vector3 offset; 
	private Vector3 moveVector;
	private float transition = 0.0f;
	private float animationDuration = 2.0f;
	private Vector3 animationOffset = new Vector3 (0,5,5);

	// Use this fo r initialization
	void Start () {
		offset = transform.position - Player.transform.position ;
	}
	
	// Update is called once per frames
	void LateUpdate () {

		moveVector =  Player.transform.position + offset;

		if (transition > 1.0f) {
			transform.position = moveVector;
		} 
		else {
			// amimation of the start of the game
			transform.position= Vector3.Lerp(moveVector + animationOffset,moveVector,transition);
			transition += (Time.deltaTime * 1) / animationDuration;
			transform.LookAt (Player.transform.position + Vector3.up);

		}

	}
}
