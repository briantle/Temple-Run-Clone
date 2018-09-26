using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonHandler : MonoBehaviour {

	public Button play, quit;

	// Use this for initialization
	void Start () {
		play.onClick.AddListener (RestartLevel);
		quit.onClick.AddListener (QuitGame);
	}
	void RestartLevel(){
		SceneManager.LoadScene ("SpaceMap");
	}
	void QuitGame(){
		Application.Quit();
	}
}
