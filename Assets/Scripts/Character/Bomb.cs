using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Bomb : Bullet
{
    [SerializeField] private GameObject burstPrefabs;

    protected override void Start()
    {
        speed = 5f;
        RotateBullet(EnemyManager.Instance.player.transform.position);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AttackCharacter();
            // 1. �÷��̾ ��(���)���� ���� ��ź�� �������� �޾�ģ��.
            // 1-1. ��ź�� �����鼭 ���ư��� �������� ������ �Ѿ��� �����ش�.
            // 1-2. �޾�ģ ��ź�� ��(���) �ε����� �����Ͽ� ��θ� óġ�Ѵ�.
            // 1-3. �Ѵ�

            // 2. �÷��̾ ��ź�� ������ ��ź�� ����� �� �ִ� ( �Ҹ�)
            // 2-1. ��ź�� ����ϸ� ��ó �Ѿ��� �������.
            // 2-2. ��ź�� ����ϸ� ��ó ��ΰ� �������.
            // 2-3. �Ѵ�
        }
    }

    public void BurstBomb()
    {
        Instantiate(burstPrefabs,transform.position, Quaternion.identity);
        Destroy(this);
    }
}
