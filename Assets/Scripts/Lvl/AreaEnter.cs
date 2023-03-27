using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    public string transitionAreaName;

    Player GetPlayer()
    {
        return GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (GetPlayer().transitionName == transitionAreaName)
        {
            GetPlayer().transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
