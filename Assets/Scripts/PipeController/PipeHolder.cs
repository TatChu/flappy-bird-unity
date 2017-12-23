using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeHolder : MonoBehaviour {


	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_PipeMove ();
	}

	void _PipeMove(){
		Vector3 temp = transform.position;
		temp.x -= speed * Time.deltaTime;
		transform.position = temp;
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "destroy_pipe") {
			Destroy (gameObject);
		}
	}
}
