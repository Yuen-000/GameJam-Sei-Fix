using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
	public void retry()
	{
		// LoadSceneの引?にシー?の名前を入れて読み?む
		SceneManager.LoadScene("TitleScene");
	}
}
