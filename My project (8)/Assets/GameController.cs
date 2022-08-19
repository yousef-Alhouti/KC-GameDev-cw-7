
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Transform SpawnMin;
    public Transform SpawnMid;
    public Transform SpawnMax;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnenemy", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnenemy()
    {
        int RandomPos = Random.Range(1, 4);
        if(RandomPos == 1)
        {
            Instantiate(enemy, SpawnMin);
        }
        else if (RandomPos == 2)
        {
            Instantiate(enemy, SpawnMid);
        }
        else
        {
            Instantiate(enemy, SpawnMax);
        }


    }

}
