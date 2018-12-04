using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
    public Sprite[] SpriteArrayleft;    //左走帧数组
    public Sprite[] SpriteArrayright;   //右走帧数组
    public Sprite[] RideSpritesLeft;    //左骑
    public Sprite[] RideSpritesRight;   //右骑
    public float framesPerSecond;
    public float moveSpeed = 15;
    public float rideSpeed = 25;
   //public float jumpHeight = 2;
    public float gravity = 60;
    

    CharacterController characterControler;
    float horizontal = 0;
    float vertical = 0;

    ////跳跃
    public float jumpSpeed = 40f;
    //public Transform playerJump;
    //private float jumpForce = 300f;        //跳跃的力
    private float move;
    private Vector3 moveDirection = Vector3.zero;


    //帧动画
    public float animSpeed = 10;             //默认1s播放10帧
    private float animTimeInterval = 0;     //帧之间间隔时间
    public SpriteRenderer animRenderer;     //渲染器

    
    private int frameIndex = 0;     //渲染帧的索引值
    //private int frameRideIndex = 0;
    private int animLength = 10;     //帧数长度
    private float animTimer = 0;    //计时器

    private Transform member;

    public string loadName = "winwin";


	// Use this for initialization
    void Start()
    {
        characterControler = GetComponent<CharacterController>();
        animTimeInterval = 1 / animSpeed / 9;       //切换帧的时间间隔
        animLength = SpriteArrayleft.Length;        //得到帧
        animLength = SpriteArrayright.Length;        //得到帧
        //animLength = RideSpritesLeft.Length;
        //animLength = RideSpritesRight.Length;

    }
	
	// Update is called once per frame
	void Update () 
    {
        CharacterController controller = GetComponent<CharacterController>();
        //玩家移动
        characterControler.Move(moveDirection * Time.deltaTime);
        horizontal = Input.GetAxis("Horizontal");       //水平移动
        vertical = Input.GetAxis("Vertical");           //垂直移动
      
        //右移
        if (horizontal > 0.01f)
        {
            moveDirection.x = horizontal * moveSpeed;
            animRenderer.sprite = SpriteArrayright[frameIndex];
        }

        //左移
        if (horizontal < 0.01f)
        {
            moveDirection.x = horizontal * moveSpeed;
            animRenderer.sprite = SpriteArrayleft[frameIndex];//try
        }

        //跳跃

        moveDirection = new Vector3(horizontal, vertical, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
                Debug.Log("空格键激活");



            }
        Debug.Log(moveDirection);
        //重力
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //地图
        //if (member.position.z > transform.position.z + 100) BgControl._instance.GenerateRoad();
        //Destroy(this.gameObject);

        animTimer += Time.deltaTime;
        if (animTimer > animTimeInterval)
        {
            animTimer -= animTimeInterval;          //计时器-帧调用一轮的时间
            frameIndex++;
            frameIndex %= animLength;               //最后一帧，重新开始
            
        }
	}

    //碰撞
    void OnControllerColliderHit(ControllerColliderHit Col)
    {
        Rigidbody body = Col.collider.attachedRigidbody;
        Debug.Log("touch" + "   "+Col.collider.gameObject.name);

        if (Col.collider.gameObject.name == "gate")
        {
            Debug.Log("turn" + Col.collider.gameObject.name);
            SceneManager.LoadSceneAsync(loadName);
        }


            //坐骑
            if (Col.collider.gameObject.tag == "ride")
            {
                //摧毁物体
                Destroy(Col.collider.gameObject);
                ////坐骑右移
                //if (horizontal > 0.01f)
                //{
                //    moveDirection.x = horizontal * rideSpeed;
                //    animRenderer.sprite = RideSpritesRight[frameRideIndex];
                //}

                ////坐骑左移
                //if (horizontal < 0.01f)
                //{
                //    moveDirection.x = horizontal * rideSpeed;
                //    animRenderer.sprite = RideSpritesLeft[frameRideIndex];//try
                //}


                //移动物体
                if (Col.collider.gameObject.tag == "box")
                {
                    //Col.collider.gameObject.addForce;
                    
                    body.velocity = new Vector3(Col.moveDirection.x*moveSpeed, Col.moveDirection.y, Col.moveDirection.z);
                }

                //if (Col.collider.gameObject.tag == "win")
                //{
                //    SceneManager.LoadSceneAsync(loadName);              //跳转胜利界面

                //}

            }
    }

    //void OnTriggerEnter(Collider scene)                   //进入触发器用OnTriggerEnter，进入碰撞器使用OnCollisionEnter
    //{
    //    if (scene.name == "winwin")
    //    {
    //        SceneManager.LoadSceneAsync(loadName);
    //    }
    //}

}
