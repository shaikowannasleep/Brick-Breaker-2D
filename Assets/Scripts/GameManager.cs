using System;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
filename: GameManager.cs
@author: shaikowannasleep
createdAt: 2024-02-13 20:25
 */

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int score = 1;

    [SerializeField]
    private int lives = 3;

    public int level = 1;

    private void Awake()
    {
        //! Note :  gameobj nay persist across all scene typically by default.
        DontDestroyOnLoad(this.gameObject);
    }


    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        this.score = 0;
        this.lives = 3;
        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        this.level = level;
        SceneManager.LoadScene("Level" + level);
    }

}
