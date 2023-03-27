using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Image imageToFade;
    public static MenuManager self;

    public void FadeImage()
    {
        Animator anim = imageToFade.GetComponent<Animator>();
        anim.SetTrigger("StartFading");

    }

    // Start is called before the first frame update
    void Start()
    {
        self = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
