using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public float runSpeed = 40f;

    float horizontalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        Input.GetAxisRaw("Horizontal");
        
    }

    private void FixedUpdate()
    {
        //Move our character
        controller2D.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
