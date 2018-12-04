using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Btnstart : MonoBehaviour
{

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
        SceneManager.LoadScene("demo0");
        Debug.Log("开始按钮激活");
    }
}
