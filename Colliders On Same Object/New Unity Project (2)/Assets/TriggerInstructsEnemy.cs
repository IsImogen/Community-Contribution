using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInstructsEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){

	if(col.gameObject.GetComponent<EnemyInstructed>() ==null){return;}

	col.gameObject.GetComponent<EnemyInstructed>().updateBehaviour(col,false);

	}

	void OnTriggerExit(Collider col){

	if(col.gameObject.GetComponent<EnemyInstructed>() ==null){return;}

	col.gameObject.GetComponent<EnemyInstructed>().updateBehaviour(col,true);

	}

}
