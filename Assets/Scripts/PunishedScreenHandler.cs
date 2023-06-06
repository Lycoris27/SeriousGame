using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunishedScreenHandler : MonoBehaviour
{
    public GameHandlerScript gameHandlerScript;
    public GameObject punishedScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameHandlerScript = GameObject.Find("GameCanvas").GetComponent<GameHandlerScript>();
        punishedScreen = GameObject.Find("PunishedScreen");
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("PressedW") == 0)
        {
            print("Hello! IJHGOISHBGOIBSOIG");
        }
        if(gameHandlerScript.wValue > 0)
        {
            punishedScreen.SetActive(true);
        }
        else
        {
            punishedScreen.SetActive(false);
        }
    }
}
