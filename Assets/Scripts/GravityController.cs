using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public float g = 9.81f;
    public Vector3 velocity;
    public float elapsedTime = 0f;

    private bool isGround;

    private void Start()
    {
        isGround = false;
    }

    private void Update()
    {
        GroundCheck();
    }

    private void GroundCheck()
    {
        if (!isGround)
        {
            elapsedTime += Time.deltaTime;
            velocity.y += g * Time.deltaTime;

            transform.position -= velocity * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGround = true;

        velocity.y = 0f;
    }
}