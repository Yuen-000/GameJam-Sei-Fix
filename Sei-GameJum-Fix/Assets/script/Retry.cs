using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
	public void retry()
	{
		// LoadScene�̈�?�ɃV�[?�̖��O�����ēǂ�?��
		SceneManager.LoadScene("TitleScene");
	}
}
