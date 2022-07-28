using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    [SerializeField] private int maxHp_ = 10;
    [SerializeField] private Transform hpBar_;
    private int curHp_;
    public event EventHandler DeathNotification;
    private void Awake()
    {
        curHp_ = maxHp_;
    }
    private void OnMouseDown()
    {
        GetDamage(5);
    }

    public void GetDamage(int amount)
    {
        curHp_ -= amount;
        ChangeHpBar();
        if (CheckDeath())
        {
            Destroy(gameObject);
        }
    }
    private bool CheckDeath()
    {
        if (curHp_ <= 0)
        {
            DeathNotification(this);
            return true;
        }
        return false;
    }
    private void ChangeHpBar()
    {
        hpBar_.transform.localScale = new Vector2((float)curHp_ / maxHp_,.2f);
    }    
}
