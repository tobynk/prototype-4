using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private GameObject focalpoint;
    public float speed = 5.0f;
    public bool haspowerup=false;
    private float powerupStrength = 15.0f;
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
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PowerUp"));
        {
            haspowerup=true;
            Destroy(other.gameObject);
        }

        
    }
    private void OnCollisionEnter(Collision Collision)
    {
        if(Collision.gameObject.CompareTag("Enemy") && haspowerup);
        {
            Rigidbody enemyRigidbody = Collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = Collision.gameObject.transform.position-transform.position;
            Debug.Log("colldid with:"+Collision.gameObject.name+"with powerup set to"+ haspowerup);
            enemyRigidbody.AddForce(awayFromPlayer*powerupStrength, ForceMode.Impulse);
        }

        
    }
}
