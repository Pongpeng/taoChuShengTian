using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnLevel01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnClick() {
        SceneManager.LoadScene("GameLevelOne");
        Debug.Log("选关卡01按钮激活");
    }
}
