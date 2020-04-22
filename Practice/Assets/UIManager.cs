using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text playerStateText;
    // Start is called before the first frame update
    public void OnPlayerDead()
    {
        playerStateText.text = "You Die!";

    }
}
