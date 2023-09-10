using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour,ICharacter
{
    [SerializeField] private Rigidbody2D rb2D;
    Vector3 moveDirection = Vector3.right;
    float speed;

    private void Start()
    {
        RotateBulletToPlayer();
        speed = 5f;
    }


    private void FixedUpdate()
    {
        MoveBullet();
    }

    private void Update()
    {
        CheckOutScreen();
    }

    private void RotateBulletToPlayer()
    {
        moveDirection = (EnemyManager.Instance.player.transform.position - transform.position).normalized; // �ӽ÷� EnemyManager ����
        float rotZ = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);    
    }

    private void MoveBullet()
    {
        rb2D.velocity = moveDirection * speed ;
    }

    private void CheckOutScreen()
    {
        Vector3 screenPos = BulletManager.Instance.mainCamera.WorldToViewportPoint(transform.position);

        if (screenPos.x > 1 || screenPos.x < 0 || screenPos.y > 1 || screenPos.y < 0)
        {
            BulletManager.Instance.DestroyBullet(this);
        }
    }

    public void AttackCharacter()
    {
        // �÷��̾�� �΋H������ ����� �޼���
    }

    public void TakeDamage()
    {
        // �÷��̾��� �Ѿ˰� �΋H���ٸ� ����� �޼���
    }

}
