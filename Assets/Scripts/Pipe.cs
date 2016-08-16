using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {



	// Use this for initialization
	void Start () {
		RandomGeneratePos ();
	}
	
	public void RandomGeneratePos()
	{
		float random_y = Random.Range (-0.05f, 0.14f);
		Vector3 pos = this.transform.localPosition;
		pos.y = random_y;
		this.transform.localPosition = pos;
	}

	void OnTriggerExit(Collider other)
	{
		if(other.tag=="Player")
		{
			GameManager._instance.score++;
		}

	}
}
