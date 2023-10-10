using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    public GameObject Shape;
    public GameObject SpaceShip;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shape.transform.position = Vector3.MoveTowards(Shape.transform.position, SpaceShip.transform.position, speed);
    }
}
