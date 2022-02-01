using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickAndKeypadMovement : MonoBehaviour
{
    protected Joystick joystick;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 10f + Input.GetAxis("Horizontal") * 10f, rigidbody.velocity.y, joystick.Vertical * 10f + Input.GetAxis("Vertical") * 10f);
    }
}
