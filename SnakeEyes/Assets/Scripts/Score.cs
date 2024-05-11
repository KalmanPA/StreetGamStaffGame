using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public DiceRoll Dice;
    public DiceRoll Dice2;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI scoreText2;

    [SerializeField] TextMeshProUGUI snakeText;
    //private void Awake()
    //{
    //    dice = FindObjectOfType<DiceRoll>();
    //}

    void Update()
    {
        if (Dice != null)
        {
            if (Dice.diceFaceNum != 0)
            {
                scoreText.text = Dice.diceFaceNum.ToString();
            }
        }

        if (Dice2 != null)
        {
            if (Dice2.diceFaceNum != 0)
            {
                scoreText2.text = Dice2.diceFaceNum.ToString();
            }
        }

        if (Dice2.diceFaceNum == 1 && Dice.diceFaceNum == 1 && Dice.GetComponent<Rigidbody>().velocity == Vector3.zero
            && Dice2.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            ActivateSnakeEyes();
        }
        else
        {
            DeactivateSnakeEyes();
        }
    }

    private void DeactivateSnakeEyes()
    {
        snakeText.gameObject.SetActive(false);
    }

    private void ActivateSnakeEyes()
    {
        snakeText.gameObject.SetActive(true);
    }
}
