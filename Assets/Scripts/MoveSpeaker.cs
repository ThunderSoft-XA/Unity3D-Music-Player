using UnityEngine;
using System.Collections;

public class MoveSpeaker : MonoBehaviour {

    Vector2 m_screenPos = new Vector2(); //记录手指触碰的位置

    void Start()
    {
        //Input.multiTouchEnabled = true;//开启多点触碰
    }

    void Update()
    {
        if (Input.touchCount <= 0)  
            return;
        if (Input.touchCount == 1) //单点触碰移动摄像机
        {
            if (Input.touches[0].phase == TouchPhase.Began)
                m_screenPos = Input.touches[0].position;   //记录手指刚触碰的位置
            if (Input.touches[0].phase == TouchPhase.Moved) //手指在屏幕上移动，移动摄像机
            {
                transform.Translate(new Vector3( Input.touches[0].deltaPosition.x * 50 * Time.deltaTime, Input.touches[0].deltaPosition.y * 50 * Time.deltaTime, 0));       
            }
        }
    }
}