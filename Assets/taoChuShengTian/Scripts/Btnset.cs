using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Btnset : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnClick()
    {
        Debug.Log("设置按钮激活");
        SceneManager.LoadScene("GameSetScens");
    }

   

  
}
