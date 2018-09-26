using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShowTime : MonoBehaviour {

	public Text timeText;
	public Text currentLevel;
    private float deltaTime;
	private Player playa;
	
	void Start(){
		playa = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // As long as the player is alive, we want to keep a timer of how longer they have been running
        if (playa.enabled){
			currentLevel.text = "Level: " + SceneManager.GetActiveScene ().name;
			timeText.text = "Time: " + (int) Time.timeSinceLevelLoad;
			if (Time.timeSinceLevelLoad >= 30f)
				SceneManager.LoadScene ("Win");
		}
	}
}
