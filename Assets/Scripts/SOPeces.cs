using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Fishes", fileName = "Game/Fish")]
public class SOPeces : ScriptableObject
{
    public string nameFish;
    public int price;
    public float weight;
    public float length;
    [Range(0.25f,1f)]
    public float dificult;
    public Sprite spriteFish;


}
