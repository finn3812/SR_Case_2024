using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerCanon : towerFIJ
{
    public override GameObject selectEnemy()
    {
        Debug.Log("Er i barne klassen");
        return enemies[0];
    }
}
