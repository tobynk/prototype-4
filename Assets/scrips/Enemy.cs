using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed=3.0f;
    private Rigidbody enemyRB;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection =(Player.transform.position - transform.position).normalized ;
        enemyRB.AddForce(lookDirection* speed);
        if (transform.position.y<-10)
        {
            Destroy(gameObject);
        }
    }
}
