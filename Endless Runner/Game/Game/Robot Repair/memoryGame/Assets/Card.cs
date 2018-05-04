using UnityEngine;
using System.Collections;

public class Card {
	public bool isFaceUp=false; // determines whether or not the //card has been flipped
	public bool isMatched=false; //isMatched is a true or false (boolean) flag //that we'll set to true when the card has been matched with its partner. 

	public string img; //img variable stores the name of the picture 

	public Texture btnTexture;
	// Use this for initialization
	public Card()
	{
		img = "robot";
	}

	public bool hasTexture() {
		return btnTexture != null;
	}

	public void setBtnTexture(Texture texture) {
		btnTexture = texture;
	}

	public Texture getTexture() {
		return btnTexture;
	}
}

