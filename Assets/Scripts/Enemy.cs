using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Enemy : MonoBehaviour
{
    [Serializable] public class HitEvent : UnityEvent<int> { }

    public HitEvent OnHit = new HitEvent();

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
           UpdateEnemyCountdown();
            
    }

    private void UpdateEnemyCountdown()
    {

        int enemyCountdown = 30;

        // enemyCountdown--;
        Score.enemyCountdown--;
        OnHit.Invoke(enemyCountdown);
    }

}
