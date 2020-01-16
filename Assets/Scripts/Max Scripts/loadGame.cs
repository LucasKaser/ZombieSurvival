using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    public GameObject cube;
    public GameObject otherCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cube.activeSelf == true)
        {
            SceneManager.LoadScene("Map_v2");
        }
        if(otherCube.activeSelf == true)
        {
            Application.Quit();
        }
    }
}
