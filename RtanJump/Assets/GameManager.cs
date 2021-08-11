using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //singletone
    public static GameManager I;

    //Awake() : Start()보다 먼저 실행
    //Awake -> Start -> Update -> Update ...
    private void Awake()
    {
        I = this;
    }

    public void GameOver()
    {
        //Invoke -> unity 제공 함수
        Invoke("GameOver_", 2); //2초 뒤에 GameOver_() 실행
    }

    public void GameWin()
    {
        GameOver_();
    }


    void GameOver_()
    {
        // 0번째 씬을 로드
        SceneManager.LoadScene(0);
    }
}
