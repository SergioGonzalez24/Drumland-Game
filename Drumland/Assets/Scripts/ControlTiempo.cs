using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTiempo : MonoBehaviour
{
    [SerializeField]
    private string tag;

    [SerializeField]
    private GameObject jugadorPrefab;

    private GameObject jugador;

    [SerializeField]
    private GameObject[] spawnPoints;

    [SerializeField]
    private GameObject selectedSpawnPoints;

    [SerializeField]
    private GameObject menuCamera;

    [SerializeField]
    private GameObject menuUI;

    [SerializeField]
    private GameObject gameUI;

    private GameObject Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
