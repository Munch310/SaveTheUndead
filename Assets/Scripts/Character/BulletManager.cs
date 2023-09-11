using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{

    public static BulletManager Instance { get; private set; }

    [SerializeField] private GameObject enemyBulletPrefabs;
    [SerializeField] private GameObject playerBulletPrefabs;

    public Camera mainCamera; // �ӽ� ī�޶� ������

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    public void ShotEnemyBullet(Vector3 spawnPos)
    {
        Instantiate(enemyBulletPrefabs, spawnPos, Quaternion.identity);
    }
}
