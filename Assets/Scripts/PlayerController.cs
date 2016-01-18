using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

  public float speed;

  private Rigidbody rigidbody;

  public void Start() {
    rigidbody = GetComponent<Rigidbody>();
  }

  public void FixedUpdate() {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

    rigidbody.AddForce(movement * speed);
  }
}
