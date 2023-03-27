using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogCtrl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogTxt, nameTxt;

    [SerializeField] GameObject dialogBox, nameBox;

    [SerializeField] string[] dialogLines = new string[3];
    [SerializeField] int currentSentence;


    // Start is called before the first frame update
    void Start()
    {
        currentSentence = 0;
        dialogLines[0] = "Bonjour";
        dialogLines[1] = "Je suis l'ours";
        dialogLines[2] = "J'aime le miel";
    }

    // Update is called once per frame
    void Update()
    {
        dialogTxt.text = dialogLines[currentSentence];
    }
}
