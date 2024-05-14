using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLR : MonoBehaviour
{
    private Animator anim;
    private string[] animationNames;
    private int currentAnimationIndex;

    void Start()
    {
        anim = GetComponent<Animator>();

        // ��������� �������� ���� ��������
        animationNames = new string[] { "LRidle", "LeftRight", "lRdie" };

        // ��������� ������ ��������
        PlayRandomAnimation();
    }
    void PlayRandomAnimation()
    {
        // �������� ��������� ��������
        int randomIndex = Random.Range(0, animationNames.Length);
        while (randomIndex == currentAnimationIndex)
        {
            randomIndex = Random.Range(0, animationNames.Length);
        }

        currentAnimationIndex = randomIndex;

        // ������������� ��������� ��������
        anim.Play(animationNames[currentAnimationIndex]);

        // ��������� ������� �������� ����� ��������� ������� ��������
        Invoke("PlayRandomAnimation", anim.GetCurrentAnimatorStateInfo(0).length);
    }
}
