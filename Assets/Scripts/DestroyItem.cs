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
        ScoreManager.Instance.AddScore(1);//�A�C�e���ɓ�����������Score�N���X�̊֐���Score�𑫂��Ă���
        Destroy(gameObject);
    }
}
