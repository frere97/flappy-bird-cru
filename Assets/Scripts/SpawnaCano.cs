using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnaCano : MonoBehaviour
{
    public GameObject cano;
    public float TempoEntreSpawn = 2;
    float timer;
    [SerializeField] Vector2 SpawnRangeY = new Vector2(-3, 3);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > TempoEntreSpawn && GameManager.Instance.PlayerVivo == true) { 
        Instantiate(cano, new Vector3(this.transform.position.x, Random.Range(SpawnRangeY.x, SpawnRangeY.y), 0), Quaternion.identity);
            timer = 0;
            
        }
    }
}
