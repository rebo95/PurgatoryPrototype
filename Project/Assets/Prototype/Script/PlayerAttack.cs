using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Attack", fileName = "New Attack")]
public class PlayerAttack : ScriptableObject
{
    public string Name;
    public string AnimationKey;
    public float PointOfNoReturn;
    public float EndOfTheAttack;

    [Header("Attack Stats:")]
    public float Damage;
    public float StaminaCost;



}
