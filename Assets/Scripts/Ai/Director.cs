using UnityEngine;
using System.Collections;

public class Director : MonoBehaviour {

	public GameObject drake; 
	public GameObject meek; 
	Player player1; 
	Player player2; 
	Enemy enemy; 
	Enemy enemy2; 
	int currentMove = 0; 

	// Use this for initialization
	void Start () {
		enemy = new Enemy(); 	
		Debug.Log("Hack using two ai bots.");  // I like this instead of TODO: it makes you want to remove it. 
		doubleEnemy(); 
		randomlySelectTurn(); 
		player1.director = this; 
		player2.director = this; 
	}
	
	// Update is called once per frame
	void Update () {

	}

	void doubleEnemy(){
		player1 = meek.GetComponent<Player>(); 
		player2 = drake.GetComponent<Player>();  
		enemy.player = player1; 
		enemy2.player = player2; 
	}

	public void userPicksChar(string charachter){
		if(charachter == "Drake"){
			player1 = drake.GetComponent<Player>(); 
			player2 = meek.GetComponent<Player>();  
			enemy.player = player2; 
			return; 
		}
		player1 = meek.GetComponent<Player>(); 
		player2 = drake.GetComponent<Player>();  
		enemy.player = player2; 
	}

	void randomlySelectTurn(){
		bool turn = (Random.value > 0.5); 
		player1.myTurn = !turn; 
		player2.myTurn = turn; 
	}

	public void characterMoved(){
		currentMove++; 
		player1.toggleMoveStatus(); 
		player2.toggleMoveStatus(); 
	}
}
