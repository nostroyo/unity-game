using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamCtrl : MonoBehaviour
{
    private Player playerTarget;
    CinemachineVirtualCamera virtualCamera;
    // Start is called before the first frame update
    void Start()
    {
        playerTarget = FindFirstObjectByType<Player>();
        virtualCamera = GetComponent<CinemachineVirtualCamera>();

        virtualCamera.Follow = playerTarget.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
