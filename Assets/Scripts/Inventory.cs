using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<SOPeces>allFishes;
    
    [SerializeField] List<SOPeces> fishes;

    float allWeight;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            //fishes.ForEach(_fishes => Debug.Log(_fishes.nameFish));
            Debug.Log("Tiene " + allWeight +" kilos de Pescado");
            foreach (var item in allFishes)
            {
                int count = fishes.FindAll(c=>c.nameFish == item.name).Count;
                Debug.Log(item.name +" "+ count);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Fish")) 
        {
            Fish pescado = collision.gameObject.GetComponent<Fish>();
            
            fishes.Add(pescado.assignedFish);
            Debug.Log("¡He pescado un pez! Se llama "+ pescado.gameNameFish +",mide " + pescado.gameLength + " y cuesta "+ pescado.gamePrice + " monedas.");
            allWeight += pescado.gameWeight;
            Destroy(pescado.gameObject);
        }
    }
}
