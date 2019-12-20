using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerPoints : MonoBehaviour
{
    public int points;
    public Text pointtext;
    public int pointMult = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointtext.text = "Points: " + points;
    }
}
