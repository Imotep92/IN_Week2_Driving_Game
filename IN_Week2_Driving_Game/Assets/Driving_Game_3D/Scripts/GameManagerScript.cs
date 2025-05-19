using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void gameOver() //intended to manage GameOver UI
    {
        gameOverUI.SetActive(true);
    }
}
