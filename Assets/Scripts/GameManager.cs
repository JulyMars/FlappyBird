using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	static public GameManager _instance;
	static public int GAME_MENU = 1;
	static public int GAME_PLAYING = 2;
	static public int GAME_END = 3;

	public Transform firstGround;

	public int score = 0;
	public int gameState = GAME_MENU;

	void Awake ()
	{
		_instance = this;
	}

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0) && gameState == GAME_MENU) {
			gameState = GAME_PLAYING;
			GameObject.FindGameObjectWithTag ("Player").SendMessage ("ActiveBird");
		}
	}

	void OnGUI ()
	{
		GUILayout.Label ("Score: " + score);
	}
}
