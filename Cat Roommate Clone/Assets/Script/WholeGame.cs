using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine.UI;


public class WholeGame : MonoBehaviour
{
    int _answerstate = 0;
    public int _goodanswer = 0;
    public int _badanswer = 0;
    public TextMeshProUGUI leftanswer;
    public TextMeshProUGUI rightanswer;
    public Button leftbut;
    public Button rightbut;
    public bool isSelect;

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
            
            if (rightbut)
            {
                isSelect = !isSelect;
            }

        }
        else if (_answerstate == 1)
        {
            speech.text = "What do you like on your pizza?";
            leftanswer.text = "Gotta love greens";
            rightanswer.text = "I'm all about anchovies";
            _answerstate++;

            if (isSelect)
            {
                _goodanswer++;
                catsprite.sprite = cat[3];
            }
            if (!isSelect)
            {
                _badanswer++;
                catsprite.sprite = cat[11];
               
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
                _badanswer++;
                catsprite.sprite = cat[9];
            }
            else if (rightbut)
            {
                _goodanswer++;
                catsprite.sprite = cat[3];
            }
        }
        else if (_answerstate == 3)
        {
            speech.text = "How do you feel about naps?";
            leftanswer.text = "Love 'em!";
            rightanswer.text = "Hate 'em.";
            _answerstate++;

            if (leftbut)
            {
                _badanswer++;
                catsprite.sprite = cat[1];
            }
            else if (rightbut)
            {
                _goodanswer++;
                catsprite.sprite = cat[3];
            }
        }
        else if (_answerstate == 4)
        {
            speech.text = "Don't you hate birds?";
            leftanswer.text = "They're the worst!";
            rightanswer.text = "Not really man.";
            _answerstate++;
            if (leftbut)
            {
                _goodanswer++;
                catsprite.sprite = cat[3];
            }
            else if (rightbut)
            {
                _badanswer++;
                catsprite.sprite = cat[3];
            }
        }
        else if (_answerstate == 5)
        {
            speech.text = "Alright, can I have some belly rubs?";
            leftanswer.text = "I dont know...";
            rightanswer.text = "Sure thing!";
            _answerstate++;

            if (leftbut)
            {
                _goodanswer++;
                catsprite.sprite = cat[3];
            }
            else if (rightbut)
            {
                _badanswer++;
                catsprite.sprite = cat[6];
            }
        }
        else if (_answerstate == 6)
        {
            ChangeSpeech();
            if (leftbut)
            {
                _badanswer++;
            }
            else if (rightbut)
            {
                _goodanswer++;
            }
        }
    }

    void ClickSelect()
    {
        isSelect = !isSelect;
    }


    void ChangeSpeech()
    {
        if (_goodanswer > _badanswer)
        {
            speech.text = "You can totally be my roommate then!";
            leftanswer.text = " ";
            rightanswer.text = " ";
            catsprite.sprite = cat[3];
        }
        else if (_badanswer > _goodanswer)
        {
            speech.text = "You can't live with me man...";
            leftanswer.text = " ";
            rightanswer.text = " ";
            catsprite.sprite = cat[0];
        }

    }
}
    

    
