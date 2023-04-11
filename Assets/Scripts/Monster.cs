using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    MonsterBase _monster;
    
    public Monster(MonsterBase mBase)
    {
        _monster = mBase;

    }

    public int MaxHp
    {
        get { return _monster.MaxHp; }
    }

    public int Attack
    {
        get { return _monster.Attack; }
    }

    public int Defence
    {
        get { return _monster.Defence; }
    }

    public int Speed
    {
        get { return _monster.Speed; }
    }
}
