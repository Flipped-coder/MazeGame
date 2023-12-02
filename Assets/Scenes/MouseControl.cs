using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 通过鼠标控制人物旋转
public class MouseControl : MonoBehaviour
{
    public Transform Player_Object;
    public Transform Player_Camera;

    public float Rotation_min = -80;
    public float Rotation_max = 80;

    [Range(1f,200f)]
    public float Mouse_Spead = 100f;

    float PlayerRotation_Y = 0f; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerMouseControl();


    }


    /// <summary>
    /// 鼠标控制人物视角
    /// </summary>
    void playerMouseControl() {
        float xMouse = Input.GetAxis("Mouse X") * Mouse_Spead * Time.deltaTime;
        float yMouse = Input.GetAxis("Mouse Y") * Mouse_Spead * Time.deltaTime;

        PlayerRotation_Y -= yMouse;
        PlayerRotation_Y = Mathf.Clamp(PlayerRotation_Y, Rotation_min, Rotation_max);

        Player_Object.Rotate(Vector3.up * xMouse);

        Quaternion quaternion = Quaternion.Euler(PlayerRotation_Y, 0, 0);
        Player_Camera.localRotation = quaternion;
    }
}
