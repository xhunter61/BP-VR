using UnityEngine;
using System.Collections;
using System;
using UnityEngine.EventSystems;

public class moveto : MonoBehaviour, IGvrGazeResponder {
    public GameObject reticle;
    public GameObject camera;
    public GameObject menu;
    RaycastHit hit;
    private bool menuOpen = false;
    private Vector3 pos;
    public void OnGazeEnter()
    {
        Debug.Log(reticle.transform.forward);
    }

    public void OnGazeExit()
    {
        
    }

    public void OnGazeTrigger()
    {
 
            Ray ray = new Ray(reticle.transform.position, reticle.transform.forward);
            Debug.Log(ray);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.point);
                pos= new Vector3(hit.point.x, 1.5f, hit.point.z);


                camera.transform.position = pos;
            }

        
        
    }

    public void MoveTo()
    {

    }

    // Use this for initialization
    void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
