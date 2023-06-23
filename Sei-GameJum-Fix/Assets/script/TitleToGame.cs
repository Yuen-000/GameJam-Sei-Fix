using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToGame : MonoBehaviour
{
    public void TileGame()
    {
        SceneManager.LoadScene("stagescenes");
    }
 
}

