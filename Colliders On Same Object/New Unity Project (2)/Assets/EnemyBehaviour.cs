using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

/*
Im trying to use the terminology from the posted question but also
do a simple example without using stay or raycast or to many moving parts

So in the states of behaviour
none could refer to no action the guard doesnt see you
agro could be they feel safe attack from affar (in the example it was run to attack range)
attack could be mid range
retreat could be they try and create distance from you

in this example we do not know which collider is triggered

so if the game started with someone within the agro zone and they passed
into attack current behaviour starts at zero so it would only trigger the agro stage

also if two players entered the first sphere it would go straight to attack

a possible way of overcoming the former is in the start function
check if the player is already within the distance and initialise current behaviour
accordingly

*/

private enum enemyBehaviour {none, agro, attack, retreat} // maybe easy to follow if I use my own: Far, MiddleDistance, Nearby,Close

	private enemyBehaviour currentBehaviour = 0;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider col){

	currentBehaviour++;

	Debug.Log(currentBehaviour);



	}

	void OnTriggerExit(Collider col){
	currentBehaviour--;

	Debug.Log(currentBehaviour);

	}
}
