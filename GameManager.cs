using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public Button armadilloButton;
    public Button armadilloButton2;
    public Button hedgehogButton;
    public Button hedgehog2Button;
    public Button rolypolyButton;
    public Button rolypoly2Button;
    public bool isGameActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartGame();
    }

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.SetActive(false);
    }


}
