using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class crunchy : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] textstuff;

    public void ChangeText()
    {
        int randnum;
        randnum = Random.Range(0, textstuff.Length);
        text.text = textstuff[randnum];
    }
}
