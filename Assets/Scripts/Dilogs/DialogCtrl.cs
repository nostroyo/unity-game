using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogCtrl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogTxt, nameTxt;

    [SerializeField] GameObject dialogBox, nameBox;

    [SerializeField] string[] dialogLines;
    [SerializeField] int currentSentence;

    public static DialogCtrl self;

    private bool justStarted;


    // Start is called before the first frame update
    void Start()
    {
        self = this;
        currentSentence = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogBox.activeInHierarchy)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                if (justStarted)
                {
                    justStarted = false;
                } else
                {
                    currentSentence++;
                }
                
                if(currentSentence < dialogLines.Length)
                {
                    checkForName();
                    dialogTxt.text = dialogLines[currentSentence];
                } else
                {
                    dialogBox.SetActive(false);
                }
                Player.self.deactivateMovement = isDialogActive();

            }
        }

    }

    public void ActivateDialog(string[] sentenceToUse)
    {

        dialogLines = sentenceToUse;

        currentSentence = 0;

        dialogTxt.text = dialogLines[currentSentence];

        dialogBox.SetActive(true);

        justStarted = true;

        

    }

    public bool isDialogActive()
    {
        return dialogBox.activeInHierarchy;
    }

    void checkForName()
    {
        if (dialogLines[currentSentence].StartsWith('#'))
        {
            nameTxt.text = dialogLines[currentSentence].Replace('#', ' ');
            currentSentence++;
        }
    }
}
