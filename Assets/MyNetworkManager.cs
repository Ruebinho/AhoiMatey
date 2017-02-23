using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " Starting Host");
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " Host started");
    }

    public override void OnStartClient(NetworkClient myNetClient)
    {
        Debug.Log(Time.timeSinceLevelLoad + " Client start requested" );
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        //base.OnClientConnect(conn);
        Debug.Log(Time.timeSinceLevelLoad + " Client connected to IP: " + conn.address);
        CancelInvoke();
    }

    void PrintConnectingMessage()
    {
        Debug.Log(".:connecting:.");
    }
}
