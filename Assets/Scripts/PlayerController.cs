using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed = 1;
	public Text collectText;
	public Text collectedAll;

	private int collected;
	
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		setCollectText ();
		collectedAll.text = "";
	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive(false);
			collected++;
			setCollectText ();
		}
	}

	void setCollectText () {
		collectText.text = "Count " + collected.ToString ();
		if (collected >= 11) {
			collectedAll.text = "You Win!";
		}
	}
}