using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour,ICharacter
{
    [SerializeField] private Rigidbody2D rb2D;
    Vector3 moveDirection = Vector3.right;
    float speed;

    // �÷��̾��� ������ �޾Ƽ� �ش� �������� ����ؼ� �����̴ٰ� ȭ�� ������ ������ �������.

    private void Start()
    {
        //moveDirection =  (GameManager.Instance.player.transform.position -transform.position).normalized;
        RotateBulletToPlayer();
        speed = 5f;
    }


    private void FixedUpdate()
    {
        MoveBullet();
    }
    private void RotateBulletToPlayer()
    {
        // �÷��̾� �������� ȸ��
        float rotZ = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        // �ش� ���������� ������ ���Ѵ�.

        transform.rotation = Quaternion.Euler(0, 0, rotZ);    
    }

    private void MoveBullet()
    {
        rb2D.velocity = moveDirection * speed ;
    }

    public void AttackCharacter()
    {
        // �÷��̾�� �΋H������ ����� �޼���
    }

    public void TakeDamage()
    {
        // ���� �΋H������?
    }

    
}
