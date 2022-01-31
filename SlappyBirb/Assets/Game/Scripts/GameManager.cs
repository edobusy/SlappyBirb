using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int points = 0;
    public TextMeshProUGUI pointsCounter;
    public GameObject endGameMenu;
    public TextMeshProUGUI endGameScore;

    // Start is called before the first frame update
    void Start()
    {
        endGameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        DisplayPoints();
    }

    public void AddPoint()
    {
        points++;
    }

    private void DisplayPoints()
    {
        pointsCounter.text = points.ToString();
    }

    public void EndGame()
    {
        Debug.Log("Game has ENDED!!! Your final score is " + points);
        endGameMenu.SetActive(true);
        endGameScore.text = points.ToString();
    }
}
