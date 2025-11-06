using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private CanvasGroup uiGroup;
    public static bool gamePaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (gamePaused)
            {
                ResumeGame();
                /*if (uiGroup.alpha < 1)
                {
                    uiGroup.alpha += Time.deltaTime;
                }*/
            }
            else {
                PauseGame();
                /*if (uiGroup.alpha >= 1) { 
                
                }*/
            }
        }
    }

    void ResumeGame() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
        //uiGroup.alpha = 0f;
    }

    void PauseGame() { 
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
        //uiGroup.alpha = 1f;
        //PlayerPrefs.SetInt("ValorEntero", 10);

        Debug.Log(PlayerPrefs.GetInt("ValorEntero"));

        //PlayerPrefs.Save();

    }
}
