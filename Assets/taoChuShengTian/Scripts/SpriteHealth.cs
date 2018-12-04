using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteHealth : MonoBehaviour {

    private  UISlider hpslider ;
    private RectTransform rectTrans;


    public Transform target;
    public Vector2 offsetPos;
    public float value;
    public float maxvalue;


	// Use this for initialization
	void Start () {


        //Transform HealthPoint = Resources.Load("Health",typeof(Transform))as Transform;
        //health = Instantiate(HealthPoint);

        //GameObject pic = new GameObject("Health");

        //Sprite spr=Resources.Load<Sprite>("Health");
        //pic.AddComponent<SpriteRenderer>().sprite = spr;
        Debug.Log("成功创建健康值");

        hpslider = GetComponent<UISlider>();
        rectTrans = GetComponent<RectTransform>();
        Init();
    }
    void Init()
    {
        value = maxvalue;
        hpslider.value = value / maxvalue;
    }
    // Update is called once per frame
    void Update () {


        if (target == null)
            return;
        Vector3 tarPos = target.transform.position;
        Vector2 pos = RectTransformUtility.WorldToScreenPoint(Camera.main,tarPos);
        rectTrans.position = pos + offsetPos;
	}
}
