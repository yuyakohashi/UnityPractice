using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //このスクリプトではScoreとScoreTextの管理をする
    /// <summary>
    /// TODO:[Scoreの加算方法]
    /// DestroyItemスクリプトでScoreのコンポーネントとオブジェクトを取得して、
    /// アイテムに当たった時にScoreクラスの関数でScoreを足していく
    /// </summary>
    public Text _scoreText;
    private int _score = 0;//スコア加算用変数
    [SerializeField] private int _scoreUp = 1;

    private void Start()
    {
        _scoreText.text = "0"; 
    }
    public void ScoreAdd()
    {
        _score += _scoreUp;
        _scoreText.text = _score.ToString();
    }
}