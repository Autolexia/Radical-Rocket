using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rotate();
    }


    void rotate()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime, Time.deltaTime));
    }
}
