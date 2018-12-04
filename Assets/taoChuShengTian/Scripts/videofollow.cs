using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videofollow : MonoBehaviour {

    public Transform player;

    //无尽地图
    public Sprite map1;
    public Sprite map2;
    public int mapCount = 2;
    public GameObject[] maps;
    public static videofollow _instance;

    public float smoothRate = 0.5f;
    private Transform thisTransform;
    private Vector2 velocity;

	void Start () {

        _instance = this;

        thisTransform = transform;
        velocity = new Vector2(0.5f, 0.5f);

	}
	
	void Update () {
       // Vector2 newPos2D = Vector2.zero;
       // //newPos2D.x = Mathf.SmoothDamp(thisTransform.position.x, player.position.x-5 , ref velocity.x, smoothRate); 
       // Vector3 newPos = new Vector3(newPos2D.x, newPos2D.y, transform.position.z);
       // transform.position = Vector3.Slerp(transform.position, newPos, Time.time);
       //// Debug.Log();

        //这里的逻辑错了

	}


}
