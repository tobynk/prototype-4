using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    public float speed = 5.0f;
    private GameObject focalpoint;
    public bool haspowerup=false;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        focalpoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRB.AddForce(focalpoint.transform.forward * speed * forwardInput);
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("powerup"));
        {
            haspowerup=true;
            Destroy(other.GameObject);
        }

        
    }
}
