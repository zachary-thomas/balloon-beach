using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App_Initalize : MonoBehaviour
{
    public GameObject inMenuUI;
    public GameObject inGameUI;
    public GameObject gameOverUI;
    public GameObject player;
    public bool isGameActive = false;

    private bool isGameStarted = false;


    public float curvature = 2.0f;
    public float trimming = 0.1f;

    // Called before Start
    private void Awake()
    {
        Shader.SetGlobalFloat("_Curvature", curvature);
        Shader.SetGlobalFloat("_Trimming", trimming);

        Application.targetFrameRate = 60;
    }

    void Start()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        setMenuActive(true, false, false);
    }

    public void PlayButton()
    {
        if (isGameStarted)
        {
            StartCoroutine(StartGame(1.0f));
        }
        else
        {
            StartCoroutine(StartGame(0.0f));
            isGameStarted = true;
        }

    }

    public void PauseGame()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        setMenuActive(true, false, false);
    }

    IEnumerator StartGame(float waitTime)
    {
        setMenuActive(false, true, false);
        yield return new WaitForSeconds(waitTime);
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;

    }

    private void setMenuActive(bool inMenu, bool inGame, bool gameOver)
    {
        inMenuUI.gameObject.SetActive(inMenu);
        inGameUI.gameObject.SetActive(inGame);
        gameOverUI.gameObject.SetActive(gameOver);
    }
}
