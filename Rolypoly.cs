using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolypoly : MonoBehaviour
{

    public Rigidbody rolypolyRb;
    public float armorCooling = 5f;
    public float boostMass = 10f;
    public bool armorActive;

    void Start()
    {
        rolypolyRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(BoostMass(5f));
            armorActive = true;
        }
    }

    IEnumerator BoostMass(float armorCooling)
    {
        rolypolyRb.mass += boostMass;

        yield return new WaitForSeconds(armorCooling);

        rolypolyRb.mass -= boostMass;
        armorActive = false;
    }

}
