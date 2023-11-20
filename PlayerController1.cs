using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public enum playerSelect { player1, player2 };
    public enum inputSelect { horizontal, vertical, power };
    string[,] inputs = new string[2, 3]
    {
        {
            "Horizontal", "Vertical", "Power"
        }
        ,
        {
            "Horizontal2", "Vertical2", "Power2"
        }
    };
    public playerSelect whichPlayer;

    public float speed = 10.0f;
    public Rigidbody player1Rb;
    public GameObject quillPrefab;
    public Transform SpawnPoint;
    public Rolypoly rolypoly;
    // Start is called before the first frame update
    void Start()
    {
        
        player1Rb = GetComponent<Rigidbody>();
        rolypoly = GameObject.Find("Player1").GetComponent<Rolypoly>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis(inputs[(int)whichPlayer, (int)inputSelect.vertical]);
        player1Rb.AddForce(Vector3.forward * speed *  forwardInput);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            player1Rb.AddForce(Vector3.forward * speed * forwardInput);
        }

        float sideInput = Input.GetAxis(inputs[(int)whichPlayer, (int)inputSelect.horizontal]);
        player1Rb.AddForce(Vector3.right * speed * sideInput);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            player1Rb.AddForce(Vector3.forward * speed * sideInput);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(quillPrefab, SpawnPoint.position, quillPrefab.transform.rotation);
        }

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }

        ArmorSpeedBoost();
    }

    public void ArmorSpeedBoost()
    {
        if (rolypoly.armorActive == true)
        {
            speed = 50;
        }
        if (rolypoly.armorActive == false)
        {
            speed = 10;
        }
    }
}
