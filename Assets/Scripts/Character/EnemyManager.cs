using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; private set; }
    public List<Enemy> EnemeisList { get; private set; }

    private void Awake()
    {
        if(Instance == null) Instance = this;   
    }

    // �ʿ��� ���ڸ��� ã�Ƽ� enemy�� �����Ѵ�.

    // Enemy�� List�� �����ϸ鼭 Enemy���� �÷��̾ �����ϵ��� �Ѵ�.

    // Enemy���� ������ ��Ÿ�Ӹ��� ���� �߻��Ѵ�.

}
