using UnityEngine;
using System.Collections;

public class PipeUpDown : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag=="Player"){
			GameManager._instance.gameState = GameManager.GAME_END;
		}
	}

}