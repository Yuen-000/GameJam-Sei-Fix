using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnScript : MonoBehaviour
{
	public int part = 0;

	public GameObject instance;

	[SerializeField]
	public GameObject[] obj;

	[SerializeField]
	changestage _changestage;


	public bool instantMode = true;

	public bool issporn = false;

	public int intat = 1;

    private void Start()
    {
		instantMode = true;
    }

    void Update()                                  
	{
        if (issporn)
        {
			if (instantMode)
			{
				StartCoroutine("instant");
				instantMode = false;
			}
		}
	}

	public IEnumerator instant()                                 //random sporn place
	{
		yield return new WaitForSeconds(50 * Time.deltaTime);
		float x = 0, y = 0;
		int rand = Random.Range(0, 4);

		switch (rand)
		{
			case 0:
				x = Random.Range(18f, 20f);
				y = Random.Range(-12f, 12f);
				break;
			case 1:
				x = Random.Range(-20f, -18f);
				y = Random.Range(-12f, 12f);
				break;
			case 2:
				x = Random.Range(-20f, 20f);
				y = Random.Range(10f, 12f);
				break;
			case 3:
				x = Random.Range(-20f, 20f);
				y = Random.Range(-12f, -10f);
				break;
			default:
				break;
		}
		x += _changestage.changenum * 30;
		Vector3 position = new Vector3(x, y, 0);

		Instantiate(obj[part], position, Quaternion.identity);
	}

	public void spornstart(bool _bornstart)
    {
		issporn = _bornstart;
    }
}
