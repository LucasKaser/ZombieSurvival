using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSavesScript : MonoBehaviour
{
    public Text scoreText;
    public Text roundText;
    public Text menuText;
    public Text summaryText;
    public Text luckText;
    public Text lastText;
    
    // Start is called before the first frame update
    void Start()
    {
        menuText.text = "MAIN MENU";
        summaryText.text = "This is a Zombie Survival game!Your goal is to survive as long as you can.There are rounds and each round slightly more powerful zombies that spawn." +
            " Make sure to kill them all. You will find guns, obsticals, and upgrades that you can spend your points to interact with." +
            " If you look at your right wrist it will show you your points and the round number.";
        lastText.text = "LAST GAME";
        luckText.text = "Better luck next time!";

        scoreText.text = "Score: " + PlayerPrefs.GetInt("Points");
        roundText.text = "Round: " + PlayerPrefs.GetInt("wave");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
