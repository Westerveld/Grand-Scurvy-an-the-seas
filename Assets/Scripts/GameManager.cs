using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int score;
	public static int health;
	public Text scoreText;
	public Text healthText;

	void Awake()
	{
		score = 0;
		health = 5;
	}

	void Update()
	{
		scoreText.GetComponent<Text>().text = "Score: " + score;
		healthText.GetComponent<Text> ().text = "Health: " + health;

		if (health <= 0) {
			Application.LoadLevel ("end");
		}
	}
}