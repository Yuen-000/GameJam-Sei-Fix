using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    [SerializeField] Text socoreLoad;

    // Start is called before the first frame update
    void Start()
    {
        //スコアを文字として表示する
        socoreLoad.text = gameloop.score.ToString();
    }
}
