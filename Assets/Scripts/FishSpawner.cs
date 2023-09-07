using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] GameObject baseFish;
    [SerializeField] Vector2 coordenadasSpawn;
   // public float x
    public List<SOPeces>fishes;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFish());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnFish()
    {
        while(true)
        {
            Vector3 randomPos = new Vector3(Random.Range(-coordenadasSpawn.x,coordenadasSpawn.x),Random.Range(-coordenadasSpawn.y, coordenadasSpawn.y));
            SOPeces x = fishes[Random.Range(0,fishes.Count)];
            Fish fish = Instantiate(baseFish,randomPos,Quaternion.identity).GetComponent<Fish>();
            fish.assignedFish = x;
            yield return new WaitForSeconds(2f);
        }
       
    }
}
