using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes;
    public bool isGameOver;
    public GameObject winUI;
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SokovanMain");
        }

        if (isGameOver)
        {
            return;
        }

        int count = 0;

        for (int i = 0; i < 3; i++)
        {
            if (itemBoxes[i].isOverlaped)
            {
                count++;
            }
        }

        if (count >= 3)
        {
            isGameOver = true;
            winUI.SetActive(true);
            
        }
    }
}
