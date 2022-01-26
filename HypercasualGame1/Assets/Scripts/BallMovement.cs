using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float ballSpeed;

    void Start()
    {

    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * ballSpeed;
        float forwardMovement = Input.GetAxis("Vertical") * ballSpeed;

        transform.position += new Vector3(horizontalMovement, 0, forwardMovement);
    }

    //void ClampedPlayerMovement()
    //{
    //    float xMove = Input.GetAxis("Horizontal") * ballSpeed;
    //    transform.Translate(xMove, 0f, 0f);
    //    float zMove = Input.GetAxis("Vertical") * ballSpeed;
    //    transform.Translate(0f, 0f, zMove);
    //    // initially, the temporary vector should equal the player's position
    //    Vector3 clampedPosition = transform.position;
    //    // Now we can manipulte it to clamp the y element
    //    clampedPosition.x = Mathf.Clamp(clampedPosition.x, -4.8f, 4.8f);
    //    clampedPosition.z = Mathf.Clamp(clampedPosition.z, -4.8f, 4.8f);
    //    // re-assigning the transform's position will clamp it
    //    transform.position = clampedPosition;
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag.Equals("ground"))
        {
            Debug.Log("Game Over!!!");
            Destroy(gameObject, 2f);
        }
    }
}
