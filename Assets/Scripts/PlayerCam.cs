using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject SpaceshipModel;
    private Vector3 offset = new Vector3(-6.9f, 0.25f, 7.8f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = SpaceshipModel.transform.position + offset;
    }
}
