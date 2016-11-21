using UnityEngine;
using System.Collections;

public class Chip : MonoBehaviour {

    GameManager gameManager;

	void Start () {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
	}
	
	void Update () {
	
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameManager.AddToQueue("Movement");
        }
    }
}
