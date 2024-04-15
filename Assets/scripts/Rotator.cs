using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Vector3 rotationSpeed;
    private float verticalMovementRange;

    void Start()
    {
        rotationSpeed = new Vector3(Random.Range(10, 30), Random.Range(20, 50), Random.Range(30, 60));

        verticalMovementRange = Random.Range(4, 6);
    }

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, verticalMovementRange), transform.position.z);
    }
}
