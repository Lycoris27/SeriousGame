using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdditionPuzzle : MonoBehaviour
{
    public int[] intValues;
    public int intLength;
    private int solution;
    private int falseAnswer1;
    private int falseAnswer2;
    public TextMeshProUGUI[] answersText;
    public int[] answers;
    private int value;
    private bool a = false;
    private bool b = false;
    // Start is called before the first frame update
    void Start()
    {
        intValues = new int[intLength];
        answers = new int[3];
        /*
        foreach(intValues i in intValues.Length)
        {
            intValues[i] = Random.Range(0, 100);
        }
        */
        for (int i = 0; intValues.Length > i; i++)
        {
            intValues[i] = Random.Range(0, 100);
            print(intValues[i]);
            solution += intValues[i];
            
        }
        for (int i = 0; 3 > i; i++)
        {
            answers[i] = 0;
        }
        print("the solution is " + solution);
        CreateFalses();
        PushToText();
    }
   
   private void CreateFalses()
    {
        falseAnswer1 = solution + Random.Range(-10, 10);
        falseAnswer2 = solution + Random.Range(-10, 10);

        while (falseAnswer1 == falseAnswer2 || falseAnswer1 == solution)
        {
            falseAnswer1 = solution + Random.Range(-10, 10);
        }
        while (falseAnswer1 == falseAnswer2 || falseAnswer1 == solution)
        {
            falseAnswer1 = solution + Random.Range(-10, 10);
        }
    }
    private void PushToText()
    {
        for (int i = 0; intValues.Length > i; i++)
        {
            value = Random.Range(0, 3);
            //print("AAAAAAAAAA" + value);
            if (i == 0)
            {
                answers[value] = solution;
                answersText[i].text = answers[value].ToString();
            }

            if (i == 1)
            {
                while (a == false)
                {
                    if (answers[value] == 0)
                    {
                        answers[value] = falseAnswer1;
                        a = true;
                    }
                    else
                    {
                        value = Random.Range(0, 3);
                    }

                }
            answersText[i].text = answers[value].ToString();
            }
            else
            {
                while (b == false)
                {
                    if (answers[value] == 0)
                    {
                        answers[value] = falseAnswer2;
                        b = true;
                    }
                    else
                    {
                        value = Random.Range(0, 3);
                    }

                }
            answersText[i].text = answers[value].ToString();
            }
        }
        
    }
    
}
