
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	public static float CountDownTime;  // 
	public Text TextCountDown;              // 
	
	[SerializeField]
    public gameloop _gameloop;

	bool iscount = false;

	// Use this for initialization
	void Start()
	{
		iscount = true;
		CountDownTime = 3F;  // 
		//Debug.Log(_gameloop);
	}

	// Update is called once per frame
	void Update()
	{
		StartCoroutine(Countdowntostart());

	}

	IEnumerator Countdowntostart()
    {
		if (iscount)
		{
			// 
			TextCountDown.text = String.Format("{00:0}", CountDownTime);
			// 
			CountDownTime -= Time.deltaTime;
			// 
			if (CountDownTime <= 1F)
			{
				CountDownTime = 1F;
				TextCountDown.text = "Start!";
				yield return new WaitForSeconds(1f);
				GameObject tobj = GameObject.FindGameObjectWithTag("countdowntext");
				Destroy(tobj);

				_gameloop.setgamestart(gameing.gameplay);

			}
		}
	}


	

	public void countstart(bool _countstart)
    {
		iscount = _countstart;
    }
}
