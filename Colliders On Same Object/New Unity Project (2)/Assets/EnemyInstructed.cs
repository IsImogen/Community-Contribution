using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstructed : MonoBehaviour {

	private enum enemyBehaviour {none, agro, attack, retreat} 
	private enemyBehaviour currentBehaviour = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){Debug.Log("I am the instructed enemy, I have triggers on but they do nothing except send this message when ENTERED");}
	void OnTriggerExit(Collider col){Debug.Log("I am the instructed enemy, I have triggers on but they do nothing except send this message when EXITED");}

	public void updateBehaviour(Collider myOwnCollider, bool myOwnColliderWasJustExited){


		if(myOwnCollider is SphereCollider){currentBehaviour = enemyBehaviour.attack;}
		else if(myOwnCollider is BoxCollider){currentBehaviour = enemyBehaviour.retreat;}
		else if(myOwnCollider is CapsuleCollider){currentBehaviour = enemyBehaviour.agro;}


	if(myOwnColliderWasJustExited){currentBehaviour --;}
	Debug.Log(currentBehaviour);

	}
}
