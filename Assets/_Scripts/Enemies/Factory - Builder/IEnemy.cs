using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy
{
    void LoseHP(float damage);
    Vector3 GetPosition();
}