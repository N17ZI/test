using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Messages : MonoBehaviour
{
    public Text gameOverText;
    public Image gameOverImage;
    public bool gameOver;
    private BallController ballController;
    void Start()
    {
        ballController = GetComponent<BallController>();
        gameOver = ballController.gameObject.GetComponent<BallController>();
        gameOverText.gameObject.SetActive(false);
        gameOverImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (PlayerHasLost())
        {
            // Показываем сообщение при поражении игрока
            gameOverText.gameObject.SetActive(true);
            gameOverImage.gameObject.SetActive(true);
        }
    }

    private bool PlayerHasLost()
    {

        return false;
    }

}
