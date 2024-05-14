using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlC : MonoBehaviour
{
    private Animator anim;
    private string[] animationNames;
    private int currentAnimationIndex;

    void Start()
    {
        anim = GetComponent<Animator>();

        // Указываем названия всех анимаций
        animationNames = new string[] { "Cidle", "Circle", "Cdie" };

        // Запускаем первую анимацию
        PlayRandomAnimation();
    }
    void PlayRandomAnimation()
    {
        // Выбираем случайную анимацию
        int randomIndex = Random.Range(0, animationNames.Length);
        while (randomIndex == currentAnimationIndex)
        {
            randomIndex = Random.Range(0, animationNames.Length);
        }

        currentAnimationIndex = randomIndex;

        // Воспроизводим выбранную анимацию
        anim.Play(animationNames[currentAnimationIndex]);

        // Запускаем функцию повторно после окончания текущей анимации
        Invoke("PlayRandomAnimation", anim.GetCurrentAnimatorStateInfo(0).length);
    }
}
