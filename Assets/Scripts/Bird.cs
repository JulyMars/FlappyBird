using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{

	private float offsetX = 0.33333f;
	private int frameCount = 0;
	public float frameRate = 1/10f;
	private float timer;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		if (timer >= frameRate) {
			timer -= frameRate;
			frameCount++;
			this.gameObject.GetComponent<Renderer> ().material.SetTextureOffset ("_MainTex", new Vector2 (frameCount % 3 * offsetX, 0));
		}
	}
}
