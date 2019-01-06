using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public GameObject camera;
    public GameObject reticle;
    GameObject Plane;
    RaycastHit hit;
    // Use this for initialization
    void Start () {
        Plane = GameObject.Find("Plane");
    }
	
	// Update is called once per frame
	void Update () {
        test scrpt = Plane.GetComponent<test>();
        Vector3 pos = new Vector3(scrpt.indicPos.x, 0.2570161f/2, scrpt.indicPos.z);
        //Debug.Log(pos);
        transform.position=pos;
        transform.rotation = camera.transform.rotation;



    }
}
