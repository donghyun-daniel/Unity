using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent onReset;
    public static GameManager instance;
    public GameObject readyPannel;
    public Text scoreText;
    public Text bestScoreText;
    public Text messageText;
    public bool isRoundActive = false;
    private int score = 0;
    public CannonRotator cannonRotator;
    public CamFollow cam;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        UpdateUI();
    }

    private void Start()
    {
        StartCoroutine("RoundRoutine");
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateBestScore();
    }

    void UpdateBestScore()
    {
        if (GetBestScore() < score)
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }

    int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore");
    }

    void UpdateUI()
    {
        scoreText.text = "Score : " + score;
        bestScoreText.text = "Best Score : " + GetBestScore();
    }

    public void OnBallDestroy()
    {
        UpdateUI();
        isRoundActive = false;
    }

    public void Reset()
    {
        score = 0;
        UpdateUI();
        StartCoroutine("RoundRoutine");
    }

    IEnumerator RoundRoutine()
    {
        //Ready
        onReset.Invoke();
        readyPannel.SetActive(true);
        cam.SetTarget(cannonRotator.transform, CamFollow.State.Idle);
        cannonRotator.enabled = false;
        isRoundActive = false;
        messageText.text = "Ready...";
        yield return new WaitForSeconds(3f);
        //Play
        isRoundActive = true;
        readyPannel.SetActive(false);
        cannonRotator.enabled = true;
        cam.SetTarget(cannonRotator.transform, CamFollow.State.Ready);
        while (isRoundActive)
        {
            yield return null;
        }

        //End
        readyPannel.SetActive(true);
        cannonRotator.enabled = false;
        messageText.text = "Wait for next round...";
        yield return new WaitForSeconds(3f);
        Reset();
    }
}
