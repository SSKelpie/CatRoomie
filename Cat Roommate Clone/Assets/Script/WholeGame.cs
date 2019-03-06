using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditorInternal;
using UnityEngine.UI;


public class WholeGame : MonoBehaviour
{
    int _answerstate = 0;
    int _goodanswer = 0;
    int _badanswer = 0;
    public TextMeshProUGUI leftanswer;
    public TextMeshProUGUI rightanswer;
    public TextMeshProUGUI speech;
    public Sprite[] cat;

    // Start is called before the first frame update
    void Start()
    {
        speech = GetComponent<TextMeshProUGUI>();
       
    }

    // Update is called once per frame
    
    public void Choices()
    {
        if (_answerstate <= 0)
        {
            _answerstate++;
            _goodanswer++;
            _badanswer++;
            //cat = 

        }
        else if (_answerstate <= 1 && _goodanswer <= 1 && _badanswer <= 1)
        {
            speech.text = "Are you a Night Owl or Early Bird?";
            leftanswer.text = "Night Owl.";
            rightanswer.text = "Early Bird!";
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
