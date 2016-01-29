using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;

	private Animator anim;
	bool isDead;
	bool damaged = false;

	void Awake() {
		anim = GetComponent<Animator>();
		currentHealth = startingHealth;
	}

	public void Death() {
		isDead = true;
		Application.LoadLevel(Application.loadedLevel);
	}
}
