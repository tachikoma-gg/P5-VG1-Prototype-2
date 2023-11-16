using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    [SerializeField] private float acceleration = 0.2f;

    void Update()
    {
        Accelerate();
        ForwardMovement();
    }

    private void ForwardMovement()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void Accelerate()
    {
        speed += acceleration;
    }
}
