using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

	public float boundForce;
	private Rigidbody2D birdBody;
	private Animator anim;

	// Variable to handle button flap
	private bool isAlive;
	private bool pressedFlapBtn;



	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	AudioClip flyClip, pingClip, dieClip;

	void Awake(){
		isAlive = true;
		birdBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	// Use this for initialization
//	void Start () {
//		
//	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}

	void FixedUpdate(){
		_BirdMove ();
	}

	void _BirdMove(){
		if (isAlive) {
			if (pressedFlapBtn) {
				pressedFlapBtn = false;
				birdBody.velocity = new Vector2(birdBody.velocity.x, boundForce);
				audioSource.PlayOneShot (flyClip);
			}
		}

		// On click left mouse handle
//		if(Input.GetMouseButtonDown(0)){
//		}

		// Vận tốc theo chiều y lớn hơn 0 => Đang bay lên
		if (birdBody.velocity.y > 0) {
			float angel = 0;
			angel = Mathf.Lerp (0, 90, birdBody.velocity.y / 7);
			transform.rotation = Quaternion.Euler (0, 0, angel);
		} else if (birdBody.velocity.y == 0) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {
			float angel = 0;
			angel = Mathf.Lerp (0, -90, -birdBody.velocity.y / 7);
			transform.rotation = Quaternion.Euler (0, 0, angel);
		}
			
	}

	public void OnClickFlapBtn(){
		pressedFlapBtn = true;
	}

}
