using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ICharacter
{   
    float remainCoolTime = 0f;
    float COOL_TIME = 3f;

    private void Update()
    {
        remainCoolTime -= Time.deltaTime;
        if (remainCoolTime <= 0f) AttackCharacter();
    }

    

    public void AttackCharacter()
    {
        RotateEnemyToPlayer();
        BulletManager.Instance.ShotBullet(transform.position);
        remainCoolTime = COOL_TIME;
    }

    private void RotateEnemyToPlayer()
    {
        // �÷��̾� �������� ȸ��?
    }

    public void TakeDamage() {}

    // Player�� ��ġ�� �޾Ƽ� ������ Player �������� �����Ѵ�.
}
