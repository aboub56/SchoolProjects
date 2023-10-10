using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.01f;
    public float verticalSpeed = 40.0f;
    public float yRange = 3.7f;
    private float verticalInput;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        //Vertical Movement of the ship
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime);
        
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //When space is pressed laser is fired
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        //Old Ideas

        //Vector3 inputVector = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0.0f);
        //transform.Translate(inputVector.normalized * speed * Time.deltaTime);
        
        
        // Ship moves at a constant speed, because of pivot forward is backwards
        //transform.Translate(Vector3.left * speed);

    }
}
