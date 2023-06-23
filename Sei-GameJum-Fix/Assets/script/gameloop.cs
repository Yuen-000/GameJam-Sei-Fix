using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum gameing
{
    countdown,
    gameplay,
    gameover
}

public class gameloop : MonoBehaviour
{
   public int badpoint = 0;

    [SerializeField]
    gameing going = gameing.countdown;

    [SerializeField]
    CountDown _countdownobject;

    [SerializeField]
    SpawnScript _spornobject;

    [SerializeField]
    changestage _changeobject;

    [SerializeField]
    Text text;

    public static int score = 0;
    [SerializeField]
    int scoreTest;

    public bool ok;

    // Update is called once per frame
    void Update()
    {
        switch (going)
        {
            case gameing.countdown:
                standby();
                break;
            case gameing.gameplay:
                gameplay();
                break;
            case gameing.gameover:
                gameover();
                break;
            default:
                Debug.LogError("going error");
                break;
        }
        scoreTest = score;
    }

    void standby()
    {
        _countdownobject.countstart(true);
        _spornobject.spornstart(false);
        scorecount(false);
        text.color = new Color(0, 0, 0, 0);
        ok = false;
    }


    void gameplay()
    {
        _spornobject.spornstart(true);

        #region change stage check
        //if (_changeobject.changenum == 1 && badpoint == 0)                             //change stage
        //{
        //    score = score + 1;
        //}

        //if (_changeobject.changenum == 2 && badpoint == 0)
        //{
        //    score = score + 1;
        //}

        //if (_changeobject.changenum == 3 && badpoint == 0)
        //{
        //    score = score + 1;
        //}

        //if (_changeobject.changenum == 4 && badpoint == 0)
        //{
        //    score = score + 1;
        //}

        //if (_changeobject.changenum == 5 && badpoint == 0)
        //{
        //    score = score + 1;
        //}

        if (_spornobject.part == 28)
        {
            _changeobject.changenum = 6;
        }

        //if (_changeobject.changenum == 6 && badpoint == 0)
        //{
        //    score = score + 1;
        //}

        #endregion
    }

    void gameover()
    {
        _countdownobject.countstart(false);
        _spornobject.spornstart(false);
        scorecount(true);
        text.color = new Color(0, 0, 0, 0);
    }

    void scorecount(bool checkscore)
    {
        if (checkscore)
        {
            if (score >= 17)
            {
                SceneManager.LoadScene("wonderscenes");
            }
            else if (score >= 10 && score <= 16)
            {
                SceneManager.LoadScene("goodlscenes");

            }
            else if (score <= 9)
            {
                SceneManager.LoadScene("goodluckscenes");

            }
        }
        else
        {
            score = 0;
        }
        
    }

    public void getloppstart()
    {
        SceneManager.GetActiveScene();
    }

    public void setgamestart(gameing _gameing)        //other script use
    {
        going = _gameing;
    }

}
