using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameHandlerScript : MonoBehaviour
{
    public int wValue;
    public TextMeshProUGUI wPressedTxt;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        wValue = PlayerPrefs.GetInt("PressedW");
        PlayerPrefs.SetInt("PressedW", wValue);
        wPressedTxt.text = PlayerPrefs.GetInt("PressedW").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PressButton();
    }
    private void PressButton()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            print("hello");
            wValue += 1;
            PlayerPrefs.SetInt("PressedW", wValue);
            wPressedTxt.text = PlayerPrefs.GetInt("PressedW").ToString();
        }
    }
}


    /*
    PlayerPrefs.SetInt("highscore",value);

    SetFloat
    SetString
    */
