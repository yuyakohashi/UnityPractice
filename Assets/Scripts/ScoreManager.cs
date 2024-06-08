using UnityEngine;

///<summary>
///�N���X�̃C���X�^���X���K���P������������Ȃ��悤�ɂ���f�U�C���p�^�[��
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