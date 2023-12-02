using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(0, 30f)]
    public float Player_Speed = 5f;
    public CharacterController controller;

    public float gravity = -9.81f;
    public Vector3 gravity_vector3;
    public Transform grabity_transform;
    private bool isGround;
    public float gravity_radius = 0.5f;
    public LayerMask gravity_layer;

    void Start()
    {
        if (controller == null) {
            controller = GetComponent<CharacterController>();
        }          
    }

    // Update is called once per frame
    void Update()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_y = Input.GetAxis("Vertical");

        Vector3 move = (transform.right * move_x + transform.forward * move_y) * Player_Speed * Time.deltaTime;
        controller.Move(move);
    }


    void Player_Physics() {
        // gravity_vector3.y += gravity;
        // isGround = Physics.CheckSphere(grav)

    }


}
