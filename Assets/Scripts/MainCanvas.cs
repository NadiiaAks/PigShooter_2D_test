using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class MainCanvas : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;

    TargetMoving target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target").GetComponent<TargetMoving>();
    }
    private void Update()
    {
        score.text = "Score: " + target.ScoreKeeper;
    }
    public void FinishGame()
    {
        Application.Quit();
    }
}
