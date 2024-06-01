using UnityEngine;

public class CreateItem : MonoBehaviour
{
    /// <summary>
    /// TODO: �X�^�[�g�n�_�ƃS�[���n�_�̈ʒu���Ƃ��Ă��ăt�B�[���h��ɂTm���Ԋu��Cube�𐶐�������
    /// </summary>
    [Tooltip("�Ή�����Prafab")] public GameObject _cube;
    [Tooltip("Start�����Ă�������")] public Transform _start;
    [Tooltip("Gool�����Ă�������")] public Transform _gool;
    private int _distance;
    private int _startZ;
    private int _goolZ;
    [SerializeField]private int _space = 6;
    void Start()
    {
        _startZ = (int)_start.position.z;
        _goolZ = (int)_gool.position.z;
        _distance = _startZ + _goolZ;
        int pro = _distance / _space;

        for (int i = 1; i < pro; i++)
        {
            _startZ += _space;
            Instantiate(_cube, new Vector3(0, 1, _startZ), Quaternion.identity);
        }
    }
}
