using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

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
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		//Application.LoadLevel(Application.loadedLevel);
	}
}
