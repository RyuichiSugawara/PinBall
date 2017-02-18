using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour {
	//得点の変数づくり
	public Text scoreText ;
	private int score = 0;
	private Transform playerTrans;
	// Use this for initialization
	void Start () {
		scoreText.text = "得点:0";//初期値
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text ="得点" + score ;
	}

	//衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other) {

	}
}
