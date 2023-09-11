using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContorlVolumeSlider : MonoBehaviour
{
    public Slider volumeSlider; // �����̴� ������Ʈ
    public Image volumeIcon; // ���� �������� ǥ���� Image ������Ʈ
    public Sprite[] volumeSprites; // ���� ������ ���� ��������Ʈ �迭

    private void Start()
    {
        // AudioManager�� bgmVolume�� �������� �����̴��� �ʱⰪ ����
        volumeSlider.value = AudioManager.instance.bgmVolume;

        // �����̴� �� ���� �� ȣ��� �̺�Ʈ�� ChangeVolume �Լ� ����
        volumeSlider.onValueChanged.AddListener(ChangeVolume);

        // ���� ������ �ʱ�ȭ
        UpdateVolumeIcon(AudioManager.instance.bgmVolume);
    }

    // ���� �� ���� �Լ�
    public void ChangeVolume(float volume)
    {
        // ���� ������ ������Ʈ
        UpdateVolumeIcon(volume);

        // AudioManager�� bgmVolume �� sfxVolume ������Ʈ
        AudioManager.instance.SetVolume(volume, volume);
    }

    // ���� ������ ������Ʈ �Լ�
    private void UpdateVolumeIcon(float volume)
    {
        // ������ 0 �Ǵ� �ſ� ���� ��
        if (volume == 0)
        {
            volumeIcon.sprite = volumeSprites[0]; // Element0 ��������Ʈ ǥ��
        }
        // ������ �߰��� ��
        else if (volume <= 0.3f)
        {
            volumeIcon.sprite = volumeSprites[1]; // �߰� Element ��������Ʈ ǥ��
        }
        else if(volume <= 0.7f)
        {
            volumeIcon.sprite = volumeSprites[2]; 
        }
        // ������ �ִ��� ��
        else
        {
            volumeIcon.sprite = volumeSprites[3]; // �ִ� Element ��������Ʈ ǥ��
        }
    }
}
