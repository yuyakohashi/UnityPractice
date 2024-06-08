using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text _scoreText;
    private void Start()
    {
        _scoreText = GetComponent<Text>();
        _scoreText.text = "0";
    }
    private void Update()
    {
        _scoreText.text = ScoreManager.Instance.GetScore().ToString();
    }
}
