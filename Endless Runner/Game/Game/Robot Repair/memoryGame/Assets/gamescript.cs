using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class gamescript : MonoBehaviour {
	
	private int cols = 4; // the number of columns in the card grid
	private int rows = 4; // the number of rows in the card grid 
	private int totalCards = 16;
	private int matchesNeededToWin;
	private int matchesMade = 0; // At the outset, the player has not made any matches
	private int cardW = 100; // Each card's width and height is 100 pixels
	private List<Card> aCards; // We'll store all the cards we create in this array
	private Card[,] aGrid; // This 2d array will keep track of the shuffled, dealt cards
	private List<Card> aCardsFlipped; // This generic array list will store the two cards that the player flips over
	private bool playerCanClick; // We'll use this flag to prevent the player from clicking buttons when we don't want him to 
	private bool playerHasWon = false; // Store whether or not theplayer has won. This should probably start out false
	
void Start () 
{
		matchesNeededToWin = totalCards / 2; // If there are 16 cards, the player needs to find 8 matches to clear the board
		playerCanClick = true; // We should let the player play, don't you think? 
		aCards = new List<Card>(); // this Generic List is our deck of cards. It can only ever hold instances of the Card class.
		aGrid = new Card[rows,cols]; // The rows and cols variables help us define the dimensions of this 2D array
		aCardsFlipped = new List<Card>(); // This List will store the two cards the player flips over.
		
	List: for(int i = 0; i<rows; i++)
		{
			// For each individual grid row, loop through the total number of columns in the grid:
			for(int j = 0; j<cols; j++)
			{
				aGrid[i,j] = new Card(); // stuff a new card instance into the 2D array
			}
		}
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUILayout.BeginArea (new Rect (0,0,Screen.width, Screen.height));
		BuildGrid();
		GUILayout.EndArea();
		print("building grid!");
		
	}
	
	void BuildGrid()
	{
		GUILayout.BeginVertical(); 
		for(int i = 0; i<rows; i++)
		{
			GUILayout.BeginHorizontal(); 
			for(int j = 0; j<cols; j++)
			{
				Card card = aGrid[i,j];

				Texture cardTexture;
				if (!card.hasTexture()) 
				{
					cardTexture = Resources.Load(card.img) as Texture;
					card.setBtnTexture(cardTexture);
				} 
				else 
				{
					cardTexture = card.getTexture();
				}

				if(GUILayout.Button(cardTexture, GUILayout.Width(cardW)))
				{
					Debug.Log(card.img);
				}
			}
			GUILayout.EndHorizontal();
		}
		GUILayout.EndVertical(); 
		print ("building grid!");
	}
}



