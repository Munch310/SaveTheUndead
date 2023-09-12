using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bullet : MonoBehaviour,ICharacter
{
    [SerializeField] protected Rigidbody2D rb2D;
    protected Vector3 moveDirection = Vector3.zero;
    protected float speed;

    protected virtual void Start()
    {
    }
    protected void FixedUpdate()
    {
        MoveBullet();
    }

    protected void Update()
    {
        CheckOutScreen();
    }
    protected void RotateBullet(Vector3 pos)
    {
        moveDirection = (pos - transform.position).normalized; // 임시로 EnemyManager 참조

        float rotZ = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg + Random.Range(-80f, 80f);
        moveDirection = Quaternion.AngleAxis(rotZ, Vector3.up) * moveDirection;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    protected void MoveBullet()
    {
        rb2D.velocity = moveDirection * speed ;
    }
    protected void CheckOutScreen()
    {
        Vector3 screenPos = BulletManager.Instance.mainCamera.WorldToViewportPoint(transform.position);

        if (screenPos.x > 1 || screenPos.x < 0 || screenPos.y > 1 || screenPos.y < 0)
        {
            Destroy(gameObject);
        }
    }
    public virtual void AttackCharacter()
    {
        Destroy(gameObject);
    }
    public virtual void TakeDamage()
    {
        Destroy(gameObject);
    }

    
}
