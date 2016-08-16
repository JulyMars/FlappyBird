using UnityEngine;
using System.Collections;

public class FllowBird : MonoBehaviour
{

	Transform bird;
	// Use this for initialization
	void Start ()
	{
		bird = GameObject.FindWithTag ("Player").transform;
	}

	// Update is called once per frame
	void Update ()
	{
		Vector3 pos = this.transform.position;
		pos.x = bird.position.x;
		this.transform.position = pos;
	}
}
