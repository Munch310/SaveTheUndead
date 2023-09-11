using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; private set; }

    public List<Enemy> EnemeisList { get; private set; }

    public GameObject player; // �ӽ� �÷��̾� ������

    [SerializeField] private GameObject enemyPrefabs;

    bool[,] map = new bool[12,24];

    int emptySlot = 288;

    // �����Ǵ� ĭ�� ��ĭ�� 1f x 1f�� ��´ٸ�?

    // ���� ������ 25f ����, �������� 12.5f ������

    // �׷��� �迭�� bool[25][50] ���� ����

    // ���� �̹� Enemy�� pos�� x + 12.5f , y + 6.25f �� �ε�����

    private void Awake()
    {
        if(Instance == null) Instance = this;
    }

    private void Start()
    {
        EnemeisList = new List<Enemy>();

        for (int i =0; i< 12; i++)
        {
            for(int j=0; j <24; j++)
            {
                SpawnEnemy(i,j);
            }
            
        }
    }
    public void SpawnEnemy(int y, int x)
    {
        GameObject go = Instantiate(enemyPrefabs, new Vector3(-12.5f, -6.25f) + new Vector3(x * 1f, y * 1f), Quaternion.identity);
        Enemy enemyComponent = go.GetComponent<Enemy>();

        EnemeisList.Add(enemyComponent);
    }

    public Vector3 CheckEmptySpace(int x, int y)
    {
        
       while (emptySlot >0 && map[y, x])
        {
            x++;
            if (x >= map.GetLength(0))
            {
                x = 0;
                y++;
            }

            if (y >= map.GetLength(1))
            {
                y = 0;
            }
        }

        map[y, x] = true;
        emptySlot--;

        return new Vector3(-12.5f, -6.25f) + new Vector3(x * 1f, y * 1f);

    }

    public Vector3 SettingPos()
    {
        int x = UnityEngine.Random.Range(0, 25);
        int y = UnityEngine.Random.Range(0, 13);

        return CheckEmptySpace(x,y);
    }

}
