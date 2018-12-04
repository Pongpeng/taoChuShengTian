using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnLevel02 : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnClick()
    {
        SceneManager.LoadScene("Gamemenu");
        Debug.Log("选关卡02按钮激活");
    }
}
