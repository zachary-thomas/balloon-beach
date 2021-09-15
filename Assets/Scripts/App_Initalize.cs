using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App_Initalize : MonoBehaviour
{

    public float curvature = 2.0f;
    public float trimming = 0.1f;

    // Called before Start
    private void Awake()
    {
        Shader.SetGlobalFloat("_Curvature", curvature);
        Shader.SetGlobalFloat("_Trimming", trimming);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
