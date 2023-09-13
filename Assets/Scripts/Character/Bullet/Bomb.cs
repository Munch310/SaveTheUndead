using UnityEngine;

public class Bomb : Bullet
{
    [SerializeField] private GameObject burstPrefabs;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponentInParent<Player>();
        if (player != null)
        {
            AttackCharacter();
            BurstBomb();
            // 1. �÷��̾ ��(���)���� ���� ��ź�� �������� �޾�ģ��.
            // (����� ��ź�� �ݻ�)
            // 1-1. ��ź�� �����鼭 ���ư��� �������� ������ �Ѿ��� �����ش�.
            // 1-2. �޾�ģ ��ź�� ��(���) �ε����� �����Ͽ� ��θ� óġ�Ѵ�.
            // 1-3. �Ѵ�

            // 2. �÷��̾ ��ź�� ������ ��ź�� ����� �� �ִ� ( �Ҹ�)
            // (�÷��̾ ��ź�� �߻�)
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
