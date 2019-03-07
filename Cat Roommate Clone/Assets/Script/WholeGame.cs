using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine.UI;


public class WholeGame : MonoBehaviour
{
    int _answerstate = 0;
    int _goodanswer = 0;
    int _badanswer = 0;
    public TextMeshProUGUI leftanswer;
    public TextMeshProUGUI rightanswer;
    public Button leftbut;
    public Button rightbut;
    
    public TextMeshProUGUI speech;
    public Sprite[] cat;
    public SpriteRenderer catsprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    
    public void Choices()
    {
        if (_answerstate == 0)
        {
            speech.text = "Are you a Night Owl or Early Bird?";
            leftanswer.text = "Night Owl.";
            rightanswer.text = "Early Bird!";
            catsprite.sprite = cat[10];
            _answerstate++;
            
        }
        else if (_answerstate == 1)
        {
            speech.text = "What do you like on your pizza?";
            leftanswer.text = "Gotta love greens";
            rightanswer.text = "I'm all about anchovies";
            _answerstate++;

            if (leftbut)
            {
                _goodanswer++;
                Debug.Log("goody hoe");

            }
            else if (rightbut)
            {
                _badanswer++;
                Debug.Log("harsh bitch");
            }
        }
        else if (_answerstate == 2)
        {
            speech.text = "Are you allergic to cats?";
            leftanswer.text = "Yes dude, get away!";
            rightanswer.text = "Nah.";
            _answerstate++;
            
            if (leftbut)
            {
                _goodanswer++;
                Debug.Log("goody hoe 2.0");

            }
            else if (rightbut)
            {
                _badanswer++;
                Debug.Log("harsh bitch 2.0");
            }
        }
        else if (_answerstate == 3)
        {
            speech.text = "Are you allergic to cats?";
            leftanswer.text = "Yes dude, get away!";
            rightanswer.text = "Nah.";
            _answerstate++;
            
            if (leftbut)
            {
                _goodanswer++;
                Debug.Log("goody hoe 3.0");

            }
            else if (rightbut)
            {
                _badanswer++;
                Debug.Log("harsh bitch 3.0");
            }
        }






    }

    public void ChangeSpeech()
    {
        if (_goodanswer > _badanswer)
        {
            speech.text = "You can totally be my roommate then!";
        }
        else if (_badanswer > _goodanswer)
        {
            speech.text = "You can't live with me man...";
        }

    }
}
