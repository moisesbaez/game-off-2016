using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
        float moveTime = Time.deltaTime * 1f;
        transform.position += new Vector3(0, moveTime, 0);
	}
}
