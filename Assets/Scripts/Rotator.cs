using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public Vector3 rotationRate;

	// Update is called once per frame
	void Update () {
		transform.Rotate (rotationRate * Time.deltaTime);
	}
}
