using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changestage : MonoBehaviour
{
    public int changenum = 0;

    public bool destroyswitch = true;

    [SerializeField]
    public gameloop _gameloop;

    [SerializeField]
    SpawnScript spawnScript;

    // Update is called once per frame
    void Update()
    {
        //�X�e�[�W��Change
        switch (changenum)
        {
            case 0:
                this.transform.localPosition = new Vector3(0, 0, -10);
                if (spawnScript.part == 5)
                {
                    changenum += 1;
                }
                break;

            case 1:
                this.transform.localPosition = new Vector3(30, 0, -10);
                if (spawnScript.part == 10)
                {
                    changenum += 1;
                }
                break;

            case 2:
                this.transform.localPosition = new Vector3(60, 0, -10);
                if (spawnScript.part == 15)
                {
                    changenum += 1;
                }

                break;

            case 3:
                this.transform.localPosition = new Vector3(90, 0, -10);
                if (spawnScript.part == 19)
                {
                    changenum += 1;
                }
                break;

            case 4:
                this.transform.localPosition = new Vector3(120, 0, -10);
                if (spawnScript.part == 23)
                {
                    changenum += 1;
                }

                break;

            case 5:
                this.transform.localPosition = new Vector3(150, 0, -10);
                if (spawnScript.part == 27)
                {
                    changenum += 1;
                }

                break;

            case 6:
                //�X�|�[����������������
                GameObject[] objs = GameObject.FindGameObjectsWithTag("seipart");
                for (int i = 0; i < objs.Length; i++)
                {
                    Destroy(objs[i]);
                }
                destroyswitch = false;
                changenum += 1;
                break;

            case 7:
                //�Q�[���I�[�o�[�܂Ŕ��
                _gameloop.setgamestart(gameing.gameover);
                break;

            default:
                break;
        }
    }
}
