using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Move", menuName ="Create a move")]

public class MoveBase : ScriptableObject
{
    [SerializeField] string name;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] Type monsterType;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp;
}
