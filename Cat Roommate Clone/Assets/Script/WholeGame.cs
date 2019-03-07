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

    }

    // Update is called once per frame
    
    public void Choices()
    {
        if (_answerstate == 0 && Input.GetMouseButtonDown(0))
        {
            speech.text = "Are you a Night Owl or Early Bird?";
            leftanswer.text = "Night Owl.";
            rightanswer.text = "Early Bird!";
            
            _answerstate++;
            _goodanswer++;
            _badanswer++;
        }
        else if (_answerstate == 1 && _goodanswer == 1)
        {
            Debug.Log("BRUH");
            _goodanswer++;
            speech.text =
            leftanswer.text =
            rightanswer.text = 
            

        }
        else
        {
            if (_answerstate == 1 && _badanswer == 1)
            {
                Debug.Log("hey man thats harsh");
                _badanswer++;
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
