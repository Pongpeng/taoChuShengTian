using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour {
    GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
    void  OnGUI()
    {
        if(GUILayout.Button("Start"))
        {
            obj = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            obj.name = "Health";
            obj.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            obj.GetComponent<Renderer>().material.mainTexture=(Texture)Resources.Load("Health");
            Debug.Log("已经初始化爱心");
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
