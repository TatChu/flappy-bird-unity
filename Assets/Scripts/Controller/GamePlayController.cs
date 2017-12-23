using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

	[SerializeField]
	private Button BtnIntro;

	void Awake(){
		Time.timeScale = 0;
	}
	public void _OnClickBtnIntro(){
		Time.timeScale = 1;
		BtnIntro.gameObject.SetActive (false);
	}
}
