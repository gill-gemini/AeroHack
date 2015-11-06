using UnityEngine;
using System.Collections;

public class MoveMe : MonoBehaviour {

	public GameObject prefab;

	// Use this for initialization
	void Start () {
		GameObject bullet = (GameObject)Instantiate(prefab, new Vector3(0,0,0), Quaternion.identity);
	}
}
