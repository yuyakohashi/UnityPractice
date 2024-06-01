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
        _score.ScoreAdd();//�A�C�e���ɓ�����������Score�N���X�̊֐���Score�𑫂��Ă���
        Destroy(gameObject);
    }
}
