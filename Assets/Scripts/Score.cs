using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshPro textMeshPro = null;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshPro>();
    }

    public void ShowScore(int score)
    {
        textMeshPro.text = score.ToString();
    }

}
