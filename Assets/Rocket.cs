using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidBody;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotate();
    }

    private void Rotate()
    {
        float rcsThrust = 100f; 

        rigidBody.freezeRotation = true;

        if (Input.GetKey(KeyCode.D))
        {
            float roatationThisFrame = rcsThrust * Time.deltaTime;
            transform.Rotate(-Vector3.forward * roatationThisFrame);
        }

        if (Input.GetKey(KeyCode.A))
        {
            float rotateSpeed = rcsThrust * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotateSpeed);
        }

        rigidBody.freezeRotation = false;
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddRelativeForce(Vector3.up);

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
