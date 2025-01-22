using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class RoadRecycle   : MonoBehaviour
{
    float height;
    [SerializeField]
    float speed = 3.0f;
    BoxCollider collider;
    
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        height = collider.size.z;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (transform.position.z <= -height)
        {
            Reposition();
        }
    }

    void Move()
    {
        transform.Translate(Vector3.back * (GameManager.GameSpeed * Time.deltaTime));
    }

    void Reposition()
    {
        Vector3 offset = new Vector3(0.0f, 0.0f, height * 4);
        transform.position += offset;
    }
}
