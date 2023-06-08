using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDialogueScript : MonoBehaviour
{
    public int dialogueOptions = 0;
    public string[] dialogue; 
    public TextMeshProUGUI dialogueBox;
    // Start is called before the first frame update
    void Awake()
    {
        //dialogueBox = GameObject.Find("DialogueBox");
    }
    void Start()
    {
        //dialogue = new string[dialogueOptions];   
    }

    // Update is called once per frame
    void Update()
    {
        PressButton();
        ShowDialogue();
    }
    private void ShowDialogue()
    {
        dialogueBox.text = dialogue[dialogueOptions].ToString();
    }
    private void PressButton()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogueOptions >= dialogue.Length - 1)
            {
                dialogueOptions = 0;
            }
            else
            {
                dialogueOptions += 1;
            }
        }
    }
}
