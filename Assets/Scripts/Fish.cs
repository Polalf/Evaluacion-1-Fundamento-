using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public SOPeces assignedFish;

    [Header("Texts")]
    public string gameNameFish;

    [Header("Settings")]
    public int gamePrice;
    public float gameWeight;
    public float gameLength;
    //public float gameDificult;

    [Header("Visuals")]
    public SpriteRenderer sr;

    [Header("Move")]
    [SerializeField] Vector2 coordenadasMove;
    

    void Start()
    {
        gameNameFish = assignedFish.nameFish;

        gamePrice = assignedFish.price;
        gameWeight= assignedFish.weight;
        gameLength  = assignedFish.length;
        //gameDificult= assignedFish.dificult;

        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = assignedFish.spriteFish;
        StartCoroutine(Movement());
    }

    
    void Update()
    {
        
    }

    IEnumerator Movement()
    {
        while(true)
        {
            Vector3 a = transform.position;
            Vector3 b = new Vector3 (Random.Range(-coordenadasMove.x, coordenadasMove.x), Random.Range(-coordenadasMove.y, coordenadasMove.y));

            for (float i = 0; i < assignedFish.dificult; i += Time.deltaTime)
            {
                transform.position = Vector3.Lerp(a,b,i/ assignedFish.dificult);
                yield return null;
            }
            
        }
        
    }

}
