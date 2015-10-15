using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class ClickRegister : MonoBehaviour {
    public GameObject block;

    private List<GameObject> blocksAdded;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    ClickRegisterProcess();
	}

    void ClickRegisterProcess() {
        //Check if the mouse is down.
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse click registered.");

            //Note: Having to use 3D rays rather than the native 2D rays because I want the ray to be directed 'into' the scene in order to find the clicked object.
            RaycastHit hit;

            //Set up the ray to be cast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //A ray that traces from the 0 point of the camera object through to the mouse position and then out into further space.
            Physics.Raycast(ray, out hit);

            GameObject target = hit.collider.gameObject;

            Debug.Log(target);

            target.GetComponent<Clickable>().onPointAndClick();
       } else if (Input.GetMouseButtonDown(1)) {
            Debug.Log("Create Mouse button clicked.");

            Vector3 location = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            location.z = 2;

            GameObject.Instantiate(block, location, Quaternion.identity);

            //blocksAdded.Add(GameObject.Instantiate(block, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity));
       }
    }
}
