using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    private Stack<GameObject> stack;

    [System.Serializable]
    public struct ChipItem
    {
        public string name;
        public GameObject prefab;
    }

    public List<ChipItem> chips;

	void Start ()
    {
        stack = new Stack<GameObject>();
	}
	
	void Update ()
    {
        if(Input.GetMouseButtonDown(1))
        {
            RemoveFromQueue();
        }   
	}

    public void AddToQueue(string chipType)
    {
        ChipItem chipItem = chips.Find(chip => chip.name == chipType);
        GameObject gameChip = (GameObject)GameObject.Instantiate(chipItem.prefab, new Vector3(stack.Count + 1.5f, 1.5f, 0), Quaternion.identity);
        stack.Push(gameChip);
    }

    private void RemoveFromQueue()
    {
        if (stack.Count == 0)
        {
            return;
        }

        GameObject removedGameObject = stack.Pop();
        Destroy(removedGameObject);
    }
}
