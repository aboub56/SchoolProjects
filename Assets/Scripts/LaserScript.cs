using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public float speed = 20.0f;
    public float rightBounds = -20f;
    public float leftBounds = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.x <= rightBounds)
        {
            Destroy(gameObject);
        }
    }


}
