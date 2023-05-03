using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnSystem : MonoBehaviour
{

    [SerializeField]    GameObject      SpawnPoints;
    [SerializeField]    GameObject      EnemyPrefab;
                        public float    EnemySpawnRate; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator WaveSystem()
    {

        yield return new WaitForSeconds(EnemySpawnRate);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
