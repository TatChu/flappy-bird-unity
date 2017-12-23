using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipeController : MonoBehaviour {


	[SerializeField]
	private GameObject pipeHolder;

	// Use this for initialization
	void Start () {
		StartCoroutine (Spawner());
	}
	
	IEnumerator Spawner(){
		yield return new WaitForSeconds (3f);
		Vector3 pipePosition = transform.position;
		pipePosition.y = Random.Range(-2.6f, 2.6f);
		Instantiate (pipeHolder, pipePosition, Quaternion.identity);
		StartCoroutine (Spawner ());
	}
}
