using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;


[CreateAssetMenu(fileName = "monster", menuName = "Create New Monster")]

public class MonsterBase : ScriptableObject
{
    [SerializeField] string name;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] Sprite sprite;
    [SerializeField] Type type;

    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defence;
    [SerializeField] int speed;

    [SerializeField] List<Moves> moveSet;

    public int MaxHp { get { return maxHp; } }
    public int Attack { get { return attack; } }
    public int Defence { get { return defence; } }
    public int Speed { get { return speed; } }
}

[System.Serializable]
public class Moves
{
    [SerializeField] MoveBase moveBase;
}


public enum Type
{
    Rock,
    Paper,
    Scissors
}


