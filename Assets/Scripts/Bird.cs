using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{

	private float offsetX = 0.33333f;
	private int frameCount = 0;
	public float frameRate = 1 / 10f;
	private float timer;

	// Use this for initialization
	void Start ()
	{
	}

	// Update is called once per frame
	void Update ()
	{
		if (GameManager._instance.gameState == GameManager.GAME_PLAYING) {
			Vector3 vel = this.GetComponent<Rigidbody> ().velocity;
			this.GetComponent<Rigidbody> ().velocity = new Vector3 (2, vel.y, vel.z);

			timer += Time.deltaTime;
			if (timer >= frameRate) {
				timer -= frameRate;
				frameCount++;
				this.gameObject.GetComponent<Renderer> ().material.SetTextureOffset ("_MainTex", new Vector2 (frameCount % 3 * offsetX, 0));
			}

			if (Input.GetMouseButtonDown (0)) {
				Vector3 pos = this.GetComponent<Rigidbody> ().velocity;
				this.GetComponent<Rigidbody> ().velocity = new Vector3 (pos.x, 5, pos.z);
				print (pos);
			}
		}

	}

	public void ActiveBird()
	{
		this.GetComponent<Rigidbody> ().useGravity = true;
	}

}