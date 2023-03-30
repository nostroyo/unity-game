using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHandler : MonoBehaviour
{

    [SerializeField] string[] sentences;
    private bool canActivateBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canActivateBox && Input.GetButtonDown("Fire1") && !DialogCtrl.self.isDialogActive())
        {
            DialogCtrl.self.ActivateDialog(sentences);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canActivateBox = collision.CompareTag("Player");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canActivateBox = collision.CompareTag("Player");
    }
}
