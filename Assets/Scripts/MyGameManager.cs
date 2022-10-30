using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    private Health playerHealth;
    public enum gameStates
    {
        Playing,
        GameOver
    }

    public gameStates gameState = gameStates.Playing;
    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindWithTag("Rocket");
        }
        playerHealth = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case gameStates.Playing:
                if(!playerHealth.isAlive)
                {
                    gameState = gameStates.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                } else
                {
                    gameState = gameStates.Playing;
                    mainCanvas.SetActive(true);
                    gameOverCanvas.SetActive(false);
                }

                break;
        }

    }
}
