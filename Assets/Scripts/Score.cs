using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //���̃X�N���v�g�ł�Score��ScoreText�̊Ǘ�������
    /// <summary>
    /// TODO:[Score�̉��Z���@]
    /// DestroyItem�X�N���v�g��Score�̃R���|�[�l���g�ƃI�u�W�F�N�g���擾���āA
    /// �A�C�e���ɓ�����������Score�N���X�̊֐���Score�𑫂��Ă���
    /// </summary>
    public Text _scoreText;
    private int _score = 0;//�X�R�A���Z�p�ϐ�
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