using UnityEngine;
using System.Collections;

public class bulletController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().velocity = new Vector3 (0, 5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
