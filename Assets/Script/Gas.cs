using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }
    
    void Move()
    {
        transform.Translate(Vector3.back * (GameManager.GameSpeed * Time.deltaTime));
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.gas += 30;
        }
    }
}
