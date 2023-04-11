using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public MoveBase Base { get; set; }
    public int PP { get; set; }

    public Move(MoveBase monsterBase, int pp)
    {
        Base= monsterBase;
        PP= pp;
    }
}

