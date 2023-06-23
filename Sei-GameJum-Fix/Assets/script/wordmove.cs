using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;
using UnityEngine.UI;
using TMPro;

public class wordmove : MonoBehaviour
{

    public GameObject targetobject;                                     //setting target object

    public Transform target;
    
    [SerializeField] float speed;

    float dist;

    bool stop = true;

    [SerializeField]
    GameObject born;
    SpawnScript partcount;

    [SerializeField]
    GameObject change;
    changestage stage;

    [SerializeField]
    GameObject bad;
    gameloop badcount;

    [SerializeField]
    GameObject textCheck;
    Text text;

    void Start()
    {
        born = GameObject.Find("born");                             //take date with SpawnScript
        partcount = born.GetComponent<SpawnScript>();                     //take date with SpawnScript
        change = GameObject.Find("Main Camera");
        stage = change.GetComponent<changestage>();
        bad = GameObject.Find("gameloop");
        badcount = bad.GetComponent<gameloop>();
        textCheck = GameObject.FindGameObjectWithTag("OX");
        text = textCheck.GetComponent<Text>();

        Vector3 diff = (this.targetobject.transform.position - this.transform.position).normalized;         //watch target
        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetChild(0).transform.localEulerAngles = new Vector3(0, 0, -transform.localEulerAngles.z);    //change child rotation

        transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));                        //object speed

        Check();
    }

    void Check()                            //check
    {
        if (target)
        {
            dist = Vector3.Distance(target.position, transform.position);
        }

        if (stop)       //space key Check               
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                speed = 0;
                transform.Translate(new Vector3(0, speed, 0));

                if (dist == 0)
                {
                    partcount.part = partcount.part + 1;
                    partcount.instantMode = true;

                    gameloop.score += 1;

                    SEManager.Instance.Play("Play_ Success SE", 0.5f);

                    text.text = "O";
                    text.color = new Color(1,0,0,1);
                    Invoke("FinishOX", 0.6f);
                }
                else if (dist <= 1f)
                {
                    partcount.part = partcount.part + 1;
                    partcount.instantMode = true;

                    gameloop.score += 1;

                    SEManager.Instance.Play("Play_ Success SE", 0.5f);

                    text.text = "O";
                    text.color = new Color(1, 0, 0, 1);
                    Invoke("FinishOX", 0.6f);
                }
                else if (dist > 1f)
                {
                    if (partcount.part < 5)
                    {
                        partcount.part = 5;
                    }
                    else if(partcount.part < 10)
                    {
                        partcount.part = 10;
                    }
                    else if(partcount.part < 15)
                    {
                        partcount.part = 15;
                    }
                    else if(partcount.part < 19)
                    {
                        partcount.part = 19;
                    }
                    else if(partcount.part < 23)
                    {
                        partcount.part = 23;
                    }
                    else if (partcount.part < 27)
                    {
                        partcount.part = 27;
                    }
                    badcount.badpoint = badcount.badpoint + 1;

                    stage.destroyswitch = true;
                    partcount.instantMode = true;

                    SEManager.Instance.Play("Play_ Failure SE", 0.5f);

                    text.text = "X";
                    text.color = new Color(1, 0, 0, 1);
                    Invoke("FinishOX", 0.6f);
                }
                Invoke("NextPart", 1f);
            }
        }
    }
    void ChangeStage()
    {
        stage.changenum += 1;
    }
    void NextPart()
    {
        stop = false;
    }
    void FinishOX()
    {
        text.color = new Color(0, 0, 0, 0);
    }
}
