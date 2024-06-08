using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    private ScoreManager _score;

    private void Start()
    {
        _score = GameObject.Find("Score").GetComponent<ScoreManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        ScoreManager.Instance.AddScore(1);//アイテムに当たった時にScoreクラスの関数でScoreを足していく
        Destroy(gameObject);
    }
}
