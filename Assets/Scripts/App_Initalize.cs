using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App_Initalize : MonoBehaviour
{
    public GameObject inMenuUI;
    public GameObject inGameUI;
    public GameObject gameOverUI;
    public GameObject player;


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
        inMenuUI.gameObject.SetActive(true);
        inGameUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }
}
