using UnityEngine;
using System.Collections;

public class LogMovement : MonoBehaviour {

	private Rigidbody2D rigid;

	public int scoreValue;
	public float speed;

	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rigid.velocity = new Vector2 (-speed, 0);
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name == "GameManager") {
			GameManager.score += scoreValue;
			Destroy (gameObject);
		}
	}
}
