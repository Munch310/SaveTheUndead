using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    public GameObject stageUI;
    public GameObject resultUI;

    int level;
    public int score = 0;

    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;

    //������ (���� �ð� + ������ �� ��) ������ �ɵ�? 

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //ĳ���� ���� => ���ξ� ȣ���ϴ� ����� ����.
    //������ ĳ���� ������ ���� ������ �Ѿ������ �ؾ� ��.
    //�� �κ��� ��� ����.

    //�ɼǿ��� ������ ���� ���� ���� ������ �Ѿ�;� ��.
    //�� �κ��� AudioManager �� DontDestroyOnLoad ó���صδ� ������ �ذ��ߴٰ� ��.
    //StartSecene �� �ִ� AudioManager �� ����� �� ����.


    //���õ� ĳ���Ϳ� ���� ����ȭ�� �ɷ�ġ �ο� + �ش� ��������Ʈ�� ����ǵ��� �ؾ� ��(�̰� ��ǻ� �������� ���� �ؾ� ��.)

    //�÷��̾��� ��Ȳ�� �µ��� ����, ��� ��, �ǰ� ��, �̵� �� �ִϸ��̼� ����.
    //(����Ű �Է��� ���� ���� ������ ���� ���� �ִϸ��̼��� ����Ʈ, ����Ű �ԷµǴ� ���� �̵� �ִϸ��̼� ����)
    //(� �ִϸ��̼��� ��� ���̰� �ǰ� �ÿ��� �ǰ� �ִϸ��̼��� �켱������ ����ȴ�. ü���� 0�� �ƴٸ� ��� �ִϸ��̼� ���, �ణ�� ������ �� ���â ���)

    //������ ȹ�� ��, �ش� ������ ����ü�� �����ϰ� ������ ȿ���� �÷��̾�� ����ǵ��� �ؾ� ��(EnemyManager ����ڰ� ������ ��� ���)

    //StartScene ���� ������ �ɼ� ���� MainScene ������ ����ǵ��� �ؾ� ��.(Audio �κ� �����̶��, DontDestroyOnLoad ó�� �� AudioManager ȣ���ϸ� ��)

    //���� �ð� ��� �� ���̵� ���� ���(LevelManager ����ڰ� ������ ��� ���)
    //(�� �ݰ� ��� or ��(����ü) �̵� �ӵ� ����)

    //�÷��̾ ���� �浹 �� ��� ����(PlayerManager, EnemyManager ����ڰ� ������ ��� ���)

    //�÷��̾ �� �Ѿ��� ���� �浹 �� �� ����, ���� ����(PlayerManager ����ڰ� ������ ��� ���)

    //�÷��̾� ��� �� ���â ���(UIManager ����ڰ� ������ ��� ���)

    //����� �ߴ� �޼ҵ嵵 �ʿ���.

    /// <summary>
    /// ���� ����. ���������� ������ �帧 ��ü�� ����Ѵ�.
    /// </summary>
    public void StartGame()
    {
        //����� ��� ����
        AudioManager.instance.PlayBgm(AudioManager.Bgm.MainScene);

        bool isAlive = true;
        int score = 0;
        //�÷��̾ ����ִ� ���� ����.
        //while (isAlive)
        //{
        //    //�ð��� �帧�� ���� ���ھ� ����

        //    //�̵�, ���� ���� �Է� ������ �̿� ���� ó��

        //    //
        //    // 

        //    /*
        //    //�÷��̾� �ǰ� ���� ��
        //    if ()
        //    {
        //        isAlive = HitPlayer();
        //    }
        //    */
        //}

        GameOver(score);
    }
    
    /// <summary>
    /// �÷��̾ �� źȯ�� ���� �浹 ���� �� ȣ��. �ش� �� ����, score +1
    /// </summary>
    public void HitEnemy()
    {
        //�ش� �� ����

        score += 1;
    }

    /// <summary>
    /// ����Ű �Է� ���� �� ȣ��. �ش� Ű�� ������ �÷��̾ �̵���Ű�� �̵� �ִϸ��̼� ��� Ʈ���� Ȱ��ȭ. Player ����ڰ� ������ ����� ����� ����.
    /// </summary>
    public void MovePlayer()
    {

    }

    /// <summary>
    /// �÷��̾�� �� �Ǵ� �÷��̾�� �������� �浹 ���� �� ȣ��. �÷��̾� ü�� ����, ü���� ���� �ִٸ� �ǰ� �ִϸ��̼� ��� Ʈ���� Ȱ��ȭ, true ��ȯ. �ƴ϶�� false ȣ��.
    /// </summary>
    public bool HitPlayer()
    {
        return false;
    }

    /// <summary>
    /// �÷��̾�� �������� �浹 ���� �� ȣ��. �ش� ������ ����, �÷��̾�� ȿ�� ����
    /// </summary>
    public void TakeItem()
    {
        
    }

    /// <summary>
    /// ��� �ִϸ��̼� ��� Ʈ���� Ȱ��ȭ. �ణ�� ������(��� �ִϸ��̼� ����� ���� �� ��) �� �ְ� ���â ��µǵ���. ��õ� ���� ���� ����.
    /// </summary>
    private void GameOver(int score)
    {
        //����� ��� �ߴ�

        //��� �ִϸ��̼� ��� Ʈ���� Ȱ��ȭ

        //�ִϸ��̼� ������ �� ����� �ణ�� ������

        //���â + ��õ� ��ư ���

        /*
        //��õ� �Է� ���� ��
        if ()
        {
            StartGame();
        }
        */
    }
}
