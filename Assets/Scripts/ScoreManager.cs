using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	
	public static float score;
	public int scoreModifier;
	public Text scoreText;

	void Awake() {
		scoreText = GetComponent<Text>();
		scoreText.enabled = false;
		score = 0;
	}

	void Update () {
		score += Time.deltaTime;
		scoreText.text = "" + (int)score * scoreModifier;
	}
}
