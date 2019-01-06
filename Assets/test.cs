using UnityEngine;
using System.Collections;
using System;
using UnityEngine.EventSystems;

public class test : MonoBehaviour
{
    public GameObject reticle;
    public GameObject camera;
    public GameObject menu;
    public GameObject spawnmenu;
    public GameObject wallPref;
    public GameObject floorPref;
    public GameObject socketio;
    RaycastHit hit;
    public bool menuOpen = false;
    public Vector3 pos;
    public bool spawnmenuopen = false;
    public Vector3 indicPos;
    
    private GameObject menuPanel;
    public void GazeEnter()
    {
        //Debug.Log(reticle.transform.forward);
        //Debug.Log(EventSystem.current.IsPointerOverGameObject());
    }

    public void GazeExit()
    {

    }

    public void GazeTrigger()
    {
        Debug.Log("Click");
        Ray ray = new Ray(reticle.transform.position, reticle.transform.forward);
       // Debug.Log(reticle.transform.position);
       // Debug.Log(reticle.transform.forward);
       // Debug.Log(ray);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            pos = new Vector3(hit.point.x, 1.5f, hit.point.z);


            //camera.transform.position = newPos;


            menuPanel = (GameObject)Instantiate(menu, camera.transform.position + camera.transform.forward * 1, camera.transform.rotation);
           // Debug.Log("UI PANEL SPAWNED");
        }
    }

    public void SpawnMenu()
    {
        Debug.Log("Gesture Keytap");
        Ray ray = new Ray(reticle.transform.position, reticle.transform.forward);
        Debug.Log(reticle.transform.position);
        Debug.Log(reticle.transform.forward);
        Debug.Log(ray);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            pos = new Vector3(hit.point.x, 1.5f, hit.point.z);


            //camera.transform.position = newPos;


            menuPanel = (GameObject)Instantiate(spawnmenu, camera.transform.position + camera.transform.forward * 1, camera.transform.rotation);
            Debug.Log("UI PANEL SPAWNED");
        }

        spawnmenuopen = true;



    }

    public void SpawnScene()
    {
        if (spawnmenuopen)
        {
            Instantiate(Resources.Load("def"), pos, Quaternion.Euler(new Vector3(0, camera.transform.rotation.eulerAngles.y - 180, 0)));
            Destroy(menuPanel);
        }
    }


    public void MoveMenu()
    {
        Debug.Log("Gesture2 Keytap");
        Ray ray = new Ray(reticle.transform.position, reticle.transform.forward);
        Debug.Log(reticle.transform.position);
        Debug.Log(reticle.transform.forward);
        Debug.Log(ray);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            pos = new Vector3(hit.point.x, 1.5f, hit.point.z);


            //camera.transform.position = newPos;


            menuPanel = (GameObject)Instantiate(menu, camera.transform.position + camera.transform.forward * 1, camera.transform.rotation);
            Debug.Log("UI PANEL SPAWNED");
        }





    }

    public void MoveTo()
    {
        camera.transform.position = pos;
    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(reticle.transform.position, reticle.transform.forward);
        // Debug.Log(reticle.transform.position);
        // Debug.Log(reticle.transform.forward);
        // Debug.Log(ray);
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.point);
            indicPos = new Vector3(hit.point.x, 1.5f, hit.point.z);
            //Debug.Log(hit.point.x +" "+hit.point.z);

            //camera.transform.position = newPos;
            //transform.position.Set(pos.x, 1.5f, pos.z);
            //transform.rotation.eulerAngles.Set(0, camera.transform.rotation.eulerAngles.y, 0);

        }




    }
}
