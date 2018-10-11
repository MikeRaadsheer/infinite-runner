using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreText : MonoBehaviour {

    string score = "";

    private Text text;

    private void Start()
    {
        text = FindObjectOfType<Text>();    
    }

    public void SetText(string text)
    {
        score = text;
    }

	void Update () {
        text.text = "Score: " + score;
	}
}
