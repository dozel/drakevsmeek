using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class Player : MonoBehaviour {
	public enum Moves {Attack, Defend, Special};

	public float maxHp = 100; 
	public float maxSp = 100; 

	bool attacking; 
	bool defending; 
	bool specialing; 
	public bool myTurn; 
	public float moveStart; 
	protected List<Moves> moves = new List<Moves>();

	public Director director; 


		// Use this for initialization
	void Start () {
					
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toggleMoveStatus(){
		myTurn = !myTurn; 			
		if(myTurn){
			moveStart = Time.time; 
		}
	}

	public void move(Player.Moves move){
		if(!director){
			throw new System.ArgumentException("Director not yet set.");
		}
		director.characterMoved(); 	
		moves.Add(move); 
	}

}
