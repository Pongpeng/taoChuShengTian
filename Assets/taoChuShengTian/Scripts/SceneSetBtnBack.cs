using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSetBtnBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void onClick(){
        Debug.Log("返回主菜单");
        Application.LoadLevelAdditive("Gamemenu");
    }
}
