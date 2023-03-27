using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class LevelManager : MonoBehaviour
{

    private Vector3 bottomLeftEdge;
    private Vector3 topRightEdge;

    [SerializeField] Tilemap tilemap;

    // Start is called before the first frame update
    void Start()
    {

        bottomLeftEdge = tilemap.localBounds.min;
        topRightEdge = tilemap.localBounds.max;


        Player.self.SetLevelLimit(topRightEdge, bottomLeftEdge);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
