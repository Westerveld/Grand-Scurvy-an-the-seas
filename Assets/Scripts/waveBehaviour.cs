using UnityEngine;
using System.Collections;

public class waveBehaviour : MonoBehaviour {

	private Rigidbody2D rigid;
	public float speed;
	public float boundary;
	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rigid.velocity = new Vector2 (-speed, 0);

		if (rigid.position.x < -boundary) {
			Destroy (gameObject);
		}
	}
}
