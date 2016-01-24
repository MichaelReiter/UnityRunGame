using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	public Color damageColor = new Color(1f,0f,0f,0.1f);

	private Animator anim;
	bool isDead;
	bool damaged;

	void Awake() {
		anim = GetComponent<Animator>();
		currentHealth = startingHealth;
		healthSlider.value = currentHealth;
	}

	void Update() {
		if (damaged) {
			damageImage.color = new Color(damageImage.color.r, damageImage.color.g, damageImage.color.b, damageImage.color.a + 0.1f);
		} else {

		}

		damaged = false;
	}

	public void TakeDamage(int amount) {
		damaged = true;
		currentHealth -= amount;
		healthSlider.value = currentHealth;

		if (currentHealth <= 0 && !isDead) {
			Death();
		}
	}

	void Death() {
		isDead = true;

		anim.SetTrigger("isDead");
	}
}
