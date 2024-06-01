using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    private Score _score;

    private void Start()
    {
        _score = GameObject.Find("Score").GetComponent<Score>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        _score.ScoreAdd();//アイテムに当たった時にScoreクラスの関数でScoreを足していく
        Destroy(gameObject);
    }
}
