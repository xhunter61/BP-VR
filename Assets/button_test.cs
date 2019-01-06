using UnityEngine;
using System.Collections;
using System;

public class button_test : MonoBehaviour{
    GameObject Plane;
   

    public void CloseMenu()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        mech scrpt = cubescrpt.cubeprf.GetComponent<mech>();
        scrpt.menuOpen = false;
        unReferenceUI();
        Debug.Log(scrpt.menuOpen);
        Destroy(transform.parent.parent.gameObject);
       
        
    }

    public void DeleteWall()
    {
        Debug.Log("Deleting Wall");
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        unReferenceUI();
        Destroy(cubescrpt.cubeprf);
        Destroy(transform.parent.parent.gameObject);
    }

    public void SpawnFurniture()
    {
        test scrpt = Plane.GetComponent<test>();
        Vector3 cubePos = new Vector3(scrpt.pos.x, 0.0f, scrpt.pos.z);
        scrpt.spawnmenuopen = false;
        Instantiate(Resources.Load("shelves"), cubePos, Quaternion.Euler(new Vector3(0, scrpt.camera.transform.rotation.eulerAngles.y - 180, 0)));
        Destroy(transform.parent.parent.gameObject);
        //Debug.Log("SPAWN WALL");
        //Debug.Log(scrpt.camera.transform.rotation.eulerAngles.y);
    }

    public void SpawnTable()
    {
        test scrpt = Plane.GetComponent<test>();
        Vector3 cubePos = new Vector3(scrpt.pos.x, 0.0f, scrpt.pos.z);
        scrpt.spawnmenuopen = false;
        Instantiate(Resources.Load("table"), cubePos, Quaternion.Euler(new Vector3(0, scrpt.camera.transform.rotation.eulerAngles.y - 180, 0)));
        Destroy(transform.parent.parent.gameObject);
        //Debug.Log("SPAWN WALL");
        //Debug.Log(scrpt.camera.transform.rotation.eulerAngles.y);
    }


    public void SpawnChair()
    {
        test scrpt = Plane.GetComponent<test>();
        scrpt.spawnmenuopen = false;
        Vector3 cubePos = new Vector3(scrpt.pos.x, 0.0f, scrpt.pos.z);

        Instantiate(Resources.Load("chair"), cubePos, Quaternion.Euler(new Vector3(0, scrpt.camera.transform.rotation.eulerAngles.y - 180, 0)));
        Destroy(transform.parent.parent.gameObject);
        //Debug.Log("SPAWN WALL");
        //Debug.Log(scrpt.camera.transform.rotation.eulerAngles.y);
    }


    /** TODO: -Floor Position richtig anpassen, rotation muss dafür beachtet werden
    *
    *
    *
    **/
    public void SpawnFloor()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        GameObject selectedWall = cubescrpt.cubeprf.gameObject;
        Vector3 test = selectedWall.transform.Find("FloorPoint").position;
        //Vector3 wallTopLeft= new Vector3(selectedWall.transform.position.x- selectedWall.GetComponent<Renderer>().bounds.size.x / 2, 1.294f + selectedWall.GetComponent<Renderer>().bounds.size.y / 2, )
        test scrpt = Plane.GetComponent<test>();
        Debug.Log(selectedWall);
        Vector3 cubePos = new Vector3(selectedWall.transform.position.x-0.88f, 1.294f+ selectedWall.GetComponent<Renderer>().bounds.size.y/2, selectedWall.transform.position.z-1.76f);

        Instantiate(scrpt.floorPref, test, Quaternion.Euler(new Vector3(0, selectedWall.transform.rotation.eulerAngles.y, 0)));
        mech scrptm = cubescrpt.cubeprf.GetComponent<mech>();
        scrptm.menuOpen = false;
        unReferenceUI();
        Destroy(transform.parent.parent.gameObject);
        Debug.Log("SPAWN FLOOR");
      
    }

    public void SpawnWallOnFloor()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        GameObject selectedFloor = cubescrpt.cubeprf.gameObject;
        Vector3 pos = selectedFloor.transform.Find("WallSpawnPoint").position;
        test scrpt = Plane.GetComponent<test>();
        pos += new Vector3(0.0f, 1.3f, 0.0f);
        Instantiate(scrpt.wallPref, pos, Quaternion.Euler(new Vector3(0, selectedFloor.transform.rotation.eulerAngles.y, 0)));
        mech scrptm = cubescrpt.cubeprf.GetComponent<mech>();
        scrptm.menuOpen = false;
        unReferenceUI();
        Destroy(transform.parent.parent.gameObject);
    }

    public void RotateLeft()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        GameObject selectedWall = cubescrpt.cubeprf.gameObject;
        selectedWall.transform.RotateAround( selectedWall.transform.Find("LeftWall").position,Vector3.up, 90.0f);

    }

    public void SpawnLeftWall()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        GameObject selectedWall = cubescrpt.cubeprf.gameObject;
        Vector3 test = selectedWall.transform.Find("LeftWall").position;
        //Vector3 wallTopLeft= new Vector3(selectedWall.transform.position.x- selectedWall.GetComponent<Renderer>().bounds.size.x / 2, 1.294f + selectedWall.GetComponent<Renderer>().bounds.size.y / 2, )
        test scrpt = Plane.GetComponent<test>();
        Debug.Log(selectedWall);
        Vector3 cubePos = new Vector3(selectedWall.transform.position.x - 0.88f, 1.294f + selectedWall.GetComponent<Renderer>().bounds.size.y / 2, selectedWall.transform.position.z - 1.76f);

        Instantiate(scrpt.wallPref, selectedWall.transform.position+(selectedWall.transform.right*-1.76f), Quaternion.Euler(new Vector3(0, selectedWall.transform.rotation.eulerAngles.y, 0)));
        mech scrptm = cubescrpt.cubeprf.GetComponent<mech>();
        scrptm.menuOpen = false;
        unReferenceUI();
        Destroy(transform.parent.parent.gameObject);
        

    }

    public void SpawnRightWall()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        GameObject selectedWall = cubescrpt.cubeprf.gameObject;
        Vector3 test = selectedWall.transform.Find("RightWall").position;
        //Vector3 wallTopLeft= new Vector3(selectedWall.transform.position.x- selectedWall.GetComponent<Renderer>().bounds.size.x / 2, 1.294f + selectedWall.GetComponent<Renderer>().bounds.size.y / 2, )
        test scrpt = Plane.GetComponent<test>();
        Debug.Log(selectedWall);
        Vector3 cubePos = new Vector3(selectedWall.transform.position.x - 0.88f, 1.294f + selectedWall.GetComponent<Renderer>().bounds.size.y / 2, selectedWall.transform.position.z - 1.76f);

        Instantiate(scrpt.wallPref, selectedWall.transform.position + (selectedWall.transform.right * 1.76f), Quaternion.Euler(new Vector3(0, selectedWall.transform.rotation.eulerAngles.y, 0)));
        mech scrptm = cubescrpt.cubeprf.GetComponent<mech>();
        scrptm.menuOpen = false;
        unReferenceUI();
        Destroy(transform.parent.parent.gameObject);
        


    }

    public void MakeDoorway()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        GameObject selectedWall = cubescrpt.cubeprf.gameObject;
        Vector3 pos = selectedWall.transform.position;
        pos += new Vector3(0.0f, 2.60435f / 2.0f, 0.0f);
        pos -= new Vector3(0.0f, 0.3051899f / 2.0f, 0.0f);


        Instantiate(Resources.Load("doorway"), pos, selectedWall.transform.rotation);
        unReferenceUI();
        Destroy(cubescrpt.cubeprf);
        Destroy(transform.parent.parent.gameObject);

    }

    public void MakeWindow()
    {
        cubepref cubescrpt = transform.parent.parent.GetComponent<cubepref>();
        GameObject selectedWall = cubescrpt.cubeprf.gameObject;
        Vector3 pos = selectedWall.transform.position;
        //pos += new Vector3(0.0f, 2.458638f / 2.0f, 1.0f);
        //pos -= new Vector3(0.5f, 0.0f, 0.0f);


        Instantiate(Resources.Load("Window"), pos, selectedWall.transform.rotation);
        unReferenceUI();
        Destroy(cubescrpt.cubeprf);
        Destroy(transform.parent.parent.gameObject);

    }

    //Script für das BewegungsUI
    public void CloseInputMenu()
    {
        test scrpt = Plane.GetComponent<test>();
        scrpt.menuOpen = false;
        Debug.Log(scrpt.menuOpen);
        Destroy(transform.parent.parent.gameObject);
        Debug.Log("CLOSE MENU");

    }

    public void MoveTo()
    {
        test scrpt= Plane.GetComponent<test>();
        GameObject camera = GameObject.Find("Camera");
        camera.transform.parent.position = scrpt.pos;
        Destroy(transform.parent.parent.gameObject);
        Debug.Log(scrpt.pos);
        Debug.Log(camera.transform.position);
        Debug.Log("MOVE TO");
    }

    public void SpawnWall()
    {
        test scrpt = Plane.GetComponent<test>();
        Vector3 cubePos = new Vector3(scrpt.pos.x, 1.294f, scrpt.pos.z);

        GameObject wall= (GameObject) Instantiate(scrpt.wallPref, cubePos, Quaternion.Euler(new Vector3(0,scrpt.camera.transform.rotation.eulerAngles.y,0)));
        Destroy(transform.parent.parent.gameObject);
        Debug.Log("SPAWN WALL");
        Debug.Log(wall.transform.forward);
    }

    public void unReferenceUI()
    {
        panel plnescrpt = Plane.GetComponent<panel>();
        plnescrpt.uipanel = null;
    }




    // Use this for initialization
    void Start () {
        Plane = GameObject.Find("Plane");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onDestroy()
    {
        
      
    }
}
