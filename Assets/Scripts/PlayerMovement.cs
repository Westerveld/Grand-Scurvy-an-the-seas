using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private Rigidbody2D rigid;
	private int healthValue = 1;
	private bool goingUp;
	private AudioSource audioSource;
	
	public AudioClip audio;
	public float boundary;
	public float moveSpeed;

	void Awake()
	{
		audioSource = gameObject.GetComponent<AudioSource> ();
	}
	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("joystick button 0")){
			rigid.velocity = new Vector2(0f,moveSpeed);
			goingUp = true;
		}
		if(Input.GetKeyDown ("down")){
			rigid.velocity = new Vector2(0f,-moveSpeed);
			goingUp = false;
		}

		if (goingUp) {
			rigid.MoveRotation(10f);
		} else {
			rigid.MoveRotation (-10f);
		}

		if (rigid.position.y < -boundary || rigid.position.y > boundary) {
			GameManager.health -= healthValue;
			audioSource.clip = audio;
			audioSource.Play ();
			if(goingUp)
			{
				rigid.velocity = new Vector2(0f, -moveSpeed);
				goingUp = false;
			}else{
				rigid.velocity = new Vector2(0f, moveSpeed);
				goingUp = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag == "Enemy")
		{
			GameManager.health -= healthValue;
			audioSource.clip = audio;
			audioSource.Play ();
			Camera.main.GetComponent<CameraShake>().Shake();
			Destroy(coll.gameObject);
		}
	}
}
