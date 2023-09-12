using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public GameObject character;

    // CharacterIndex -> MainScene
    // AddListener ��� ����. ���� ���� ����
    public void OnclickedCharacter()
    {
        if (character != null)
        {
            // character ��ü�� null�� �ƴ� ���� �Ʒ� �ڵ� ����
            UIManager.instance.LoadScene("MainScene");
        }
        else
        {
            Debug.LogError("character ��ü�� �Ҵ���� �ʾҽ��ϴ�.");
        }
    }
}
