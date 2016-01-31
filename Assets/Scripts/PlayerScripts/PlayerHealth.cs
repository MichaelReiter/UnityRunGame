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
		GameObject.FindWithTag("UI").GetComponent<AudioSource>().Stop();
		Destroy(GameObject.FindWithTag("UI"));
		//GameObject.FindWithTag("UI").GetComponent<StartOptions>().inMainMenu = true;
		//Application.LoadLevel(Application.loadedLevel);
	}
}
