using UnityEngine;

public class CreateItem : MonoBehaviour
{
    /// <summary>
    /// TODO: スタート地点とゴール地点の位置をとってきてフィールド上に５m等間隔でCubeを生成したい
    /// </summary>
    [Tooltip("対応するPrafab")] public GameObject _cube;
    [Tooltip("Startを入れてください")] public Transform _start;
    [Tooltip("Goolを入れてください")] public Transform _gool;
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
