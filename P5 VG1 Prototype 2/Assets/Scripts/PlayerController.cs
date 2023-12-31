using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 25f;
    [SerializeField] private int outerBounds = 10;
    [SerializeField] private GameObject projectilePrefab;

    void Update()
    {
        PlayerMove();
        PlayerBounds();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            LaunchProjectile();
        }
    }

    private void PlayerMove()
    {
        float inputX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * inputX * Time.deltaTime * speed);
    }

    private void PlayerBounds()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        if(x > outerBounds)
        {
            transform.position = new Vector3(outerBounds, y, z);
        }

        if(x < -outerBounds)
        {
            transform.position = new Vector3(-outerBounds, y, z);
        }
    }

    private void LaunchProjectile()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
