using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Clickable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void onPointAndClick()
    {
        Debug.Log("Recieving object: onClick() successfully called.");

        this.gameObject.transform.parent.gameObject.active = false;
    }
}
