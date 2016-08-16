using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour
{
	public Transform firstGroud;
	public Pipe pipe1;
	public Pipe pipe2;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter (Collider other)
	{
		print ("other ================");
		if (other.tag == "Player") {
			Vector3 pos = firstGroud.localPosition;
			pos.x += 30;
			firstGroud.localPosition = pos;
			print (GameManager._instance.firstGround.localPosition);
			GameManager._instance.firstGround = firstGroud;
			//pipe1.RandomGeneratePos ();
			//pipe2.RandomGeneratePos ();
		}
	}
}
