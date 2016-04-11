using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Levelmanager : MonoBehaviour {
	public void LoadGame(string name)
	{
		Application.LoadLevel (name);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}