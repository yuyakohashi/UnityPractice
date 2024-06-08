using UnityEngine;

///<summary>
///クラスのインスタンスが必ず１つしか生成されないようにするデザインパターン
/// </summary>
public class ScoreManager : MonoBehaviour
{
    static ScoreManager _instance = new ScoreManager();
    public static ScoreManager Instance => _instance;
    private ScoreManager(){}

    int _score = 0;

    public void AddScore(int score)
    {
        _score += score;
    }

    public int GetScore()
    {
        return _score;
    }
}