using UnityEngine;
using System.Collections;
using SocketIO;
using System;
using System.Text.RegularExpressions;

public class SocketLeap : MonoBehaviour {
    private SocketIOComponent socket;
    private float timer;
    private GameObject plane;

    // Use this for initialization
    void Start () {
        plane = GameObject.Find("Plane");
        GameObject gameobj = GameObject.Find("SocketIO");
        socket = gameobj.GetComponent<SocketIOComponent>();
        socket.On("schnippsGesture", deletefunc);
        socket.On("updateInfo", updateInfo);
        
        socket.On("keytapGesture", showSpawnMenu);
        socket.On("keytapGesture2", showMoveMenu);
        socket.On("swipeGesture", swipeGesture);
        socket.On("swipeGesture2", swipeGesture2);
        socket.On("screenTapGesture2", screentapGesture2);
        socket.On("thumbGesture", thumbGesture);
        socket.Emit("getInfo");

	
	}

    private void screentapGesture2(SocketIOEvent obj)
    {
        Debug.Log("ScreenTap2 Received");
        test scrpt = plane.GetComponent<test>();
        scrpt.SpawnScene();
    }

    private void swipeGesture2(SocketIOEvent obj)
    {
        //spawn wall right
      

        //spawn wall left
        //Debug.Log("Spawning Wall left");
        panel scrpt = plane.GetComponent<panel>();
        GameObject wallui = scrpt.uipanel.transform.GetChild(0).transform.GetChild(0).gameObject;
        button_test btnscrpt = wallui.GetComponent<button_test>();
        btnscrpt.SpawnRightWall();
        
    }

    private void thumbGesture(SocketIOEvent obj)
    {
        //todo
    }

    private void swipeGesture(SocketIOEvent obj)
    {

        
        //spawn wall left
        //Debug.Log("Spawning Wall left");
        panel scrpt = plane.GetComponent<panel>();
        GameObject wallui = scrpt.uipanel.transform.GetChild(0).transform.GetChild(0).gameObject;
        button_test btnscrpt = wallui.GetComponent<button_test>();

            btnscrpt.SpawnLeftWall();

        
        
    }

    private void showMoveMenu(SocketIOEvent obj)
    {
        test scrpt = plane.GetComponent<test>();
        scrpt.MoveMenu();
    }


    private void showSpawnMenu(SocketIOEvent obj)
    {
        test scrpt = plane.GetComponent<test>();
        scrpt.SpawnMenu();
    }

    public void deletefunc(SocketIOEvent so)
    {
        panel uiinst = plane.GetComponent<panel>();
        GameObject uipanel = uiinst.uipanel;
        button_test btnscrpt = uipanel.transform.GetChild(0).transform.GetChild(1).GetComponent<button_test>();
        btnscrpt.DeleteWall();
    }

    public void updateInfo(SocketIOEvent so)
    {
        Debug.Log("Update from websocket received");
        Debug.Log(so.data);
    }

    string JsonToString(string target, string s)
    {

        string[] newString = Regex.Split(target, s);

        return newString[1];

    }

    // Update is called once per frame
    void Update () {
        if (timer < 15.0f)
        {
            timer += Time.deltaTime;
            //Debug.Log(timer);
        }
        else
        {
            //socket.Emit("getInfo");
            timer = 0.0f;
        }
        
	
	}
}
