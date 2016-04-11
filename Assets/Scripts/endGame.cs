using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class endGame : MonoBehaviour {

	public Text scoreText;
	// Use this for initialization
	public void returnToLevel(string name)
	{
		Application.LoadLevel (name);
	}

	void Start()
	{
		scoreText.GetComponent<Text>().text = "You Scored: " + GameManager.score;
	}
}
