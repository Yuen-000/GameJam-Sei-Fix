using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
	public void retry()
	{
		// LoadScene‚Ìˆø?‚ÉƒV[?‚Ì–¼‘O‚ğ“ü‚ê‚Ä“Ç‚İ?‚Ş
		SceneManager.LoadScene("TitleScene");
	}
}
