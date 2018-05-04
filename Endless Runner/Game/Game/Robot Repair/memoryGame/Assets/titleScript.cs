using UnityEngine;
using System.Collections;

public class titleScript : MonoBehaviour {
	public GUISkin customSkin;

	private float buttonW = 100; // button width 
	private float buttonH = 50; // button height
	private float btnPositionX; // half of the Screen width
	private float btnPositionY;
	private float halfButtonW;
	private float halfButtonH;

	void Start () {
		halfButtonW = buttonW / 2;
		halfButtonH = buttonH / 2;
		btnPositionX = Screen.width / 2 - halfButtonW;
		btnPositionY = Screen.height / 2 - halfButtonH;
		
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.skin = customSkin;
		if(GUI.Button(new Rect(btnPositionX, btnPositionY, buttonW, buttonH), "Play Game"))
		{
			Application.LoadLevel("game");
		}
	
	}
}
