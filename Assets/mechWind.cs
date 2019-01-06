using UnityEngine;
using System.Collections;
using System;

/**
*TODO: - 
*
*
*
**/

public class mechWind : MonoBehaviour
{
    public Material highMat;
    public Material defaultMat;
    public GameObject actionMenu;
    private GameObject menuPanel;
    public GameObject camera;
    public GameObject reticle;
    public float gazeTime = 2f;
    public float menuTimer = 10f;
    private float timer;
    private bool gazedAt;
    public bool menuOpen = false;
    RaycastHit hit;
    public void GazeEnter()
    {
        Debug.Log("Box wird highlight");
        gazedAt = true;
        

        Renderer[] renderers = transform.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.material = highMat;
        }

    }

    public void GazeExit()
    {
        Debug.Log("Box wird unhighlight");
        gazedAt = false;
        timer = 0f;
        Renderer[] renderers = transform.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.material = defaultMat;
        }
    }

    public void GazeTrigger()
    {
        Debug.Log("Test");
    }

    public void onResize()
    {
        Debug.Log("Resize Cube");
    }

    // Use this for initialization
    void Start()
    {

        camera = GameObject.Find("Camera");
        reticle = GameObject.Find("GvrReticlePointer");

    }

    // Update is called once per frame
    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (timer >= gazeTime && menuOpen == false)
            {
                menuOpen = true;
                timer = 0f;
                Ray ray = new Ray(reticle.transform.position, reticle.transform.forward);
                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log(hit.point);
                    Vector3 hitPoint = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                    Debug.Log(GetHitFace(hit));

                }

                //GetComponent<Renderer>().bounds.size.z gibt größe des Cubes zurück
                //Vector3 newPos = new Vector3(camera.transform.position + camera.transform.forward * 1, camera.transform.rotation);
                Quaternion camrot = new Quaternion(camera.transform.rotation.x, camera.transform.rotation.y, camera.transform.rotation.z, camera.transform.rotation.w);
                menuPanel = (GameObject)Instantiate(actionMenu, camera.transform.position + camera.transform.forward * 1, camera.transform.rotation);
                cubepref cubescrpt = menuPanel.GetComponent<cubepref>();
                cubescrpt.cubeprf = transform.gameObject;
                GameObject panl = GameObject.Find("Plane");
                panel panscrpt = panl.GetComponent<panel>();
                panscrpt.uipanel = menuPanel.gameObject;
                //menuPanel.transform.parent = gameObject.transform;
            }
        }
        else
        {
            if (menuOpen == true)
            {

            }
        }
    }

    public enum MCFace
    {
        None,
        Up,
        Down,
        East,
        West,
        North,
        South
    }

    public MCFace GetHitFace(RaycastHit hit)
    {
        Vector3 incomingVec = hit.normal - Vector3.up;

        if (incomingVec == new Vector3(0, -1, -1))
            return MCFace.South;

        if (incomingVec == new Vector3(0, -1, 1))
            return MCFace.North;

        if (incomingVec == new Vector3(0, 0, 0))
            return MCFace.Up;

        if (incomingVec == new Vector3(1, 1, 1))
            return MCFace.Down;

        if (incomingVec == new Vector3(-1, -1, 0))
            return MCFace.West;

        if (incomingVec == new Vector3(1, -1, 0))
            return MCFace.East;

        return MCFace.None;
    }
}
