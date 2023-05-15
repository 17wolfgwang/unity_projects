using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float angle = 100f;

    Rigidbody rb;
    AudioSource AS;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        AS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
        
    }

    void ProcessThrust(){
        if(Input.GetKey(KeyCode.Space)) {
            //0,1,0 = Vector3.up
            rb.AddRelativeForce(Vector3.up* mainThrust*Time.deltaTime);
            if(!AS.isPlaying) {
                AS.Play();
            }
        }
        else {
            AS.Stop();
        }
    }

    void ProcessRotation(){
        if(Input.GetKey(KeyCode.A)) {
            ApplyRotation(angle);
        }
        else if(Input.GetKey(KeyCode.D)) {
            ApplyRotation(-angle);
        }
    }

    void ApplyRotation(float rotationThisFrame) {
        
        rb.freezeRotation = true; // freezing rotation so we can manually rotate
        // 0,0,1
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; // unfreezing rotation so the physics system can take over

    }
}
