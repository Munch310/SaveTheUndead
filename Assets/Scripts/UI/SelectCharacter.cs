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
        SceneManager.LoadScene("MainScene");
   }
}
