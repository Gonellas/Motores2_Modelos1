using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAttack : Swipe
{
    [SerializeField] private GameObject _iceBullet;

    public GroundAttack(Transform transform, GameObject trail, GameObject fireBullet) : base(transform, trail)
    {
        _iceBullet = fireBullet;
    }

    public override Vector2 SwipeDetection()
    {
        Vector2 swipeDirection = base.SwipeDetection();
        if (swipeDirection != Vector2.zero)
        {
            CreateFireEffect();
        }
        return swipeDirection;
    }

    private void CreateFireEffect()
    {
        Object.Instantiate(_iceBullet, _transform.position, Quaternion.identity);
        Debug.Log("Ground attack!");
    }
}
