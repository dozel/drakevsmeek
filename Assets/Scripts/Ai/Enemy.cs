using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Player player; 
	float waitToMove = 2.0f; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!player){
			return; 
		}
		if(player.myTurn && Time.time > player.moveStart + waitToMove){
			decideMove(); 
		}	
	}

	void decideMove(){
		Debug.Log("Hacked ai. Only choses one move"); 
		player.move(Player.Moves.Attack); 
	}

}
