using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] private float _speed = 8f;
    [SerializeField][Tooltip("X軸の移動可能範囲")]private float xLimit = 9.5f;

    public bool _isStop = false;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (!_isStop)
        {
            ///プレイヤーが自動で進み、ゴールまで向かう処理
            _rigidBody.velocity = transform.forward * _speed * 2f;

            if (Input.GetKey(KeyCode.D))// Dキー（右移動）
            {
                _rigidBody.AddForce(transform.right * 10 * _speed);
            }
            if (Input.GetKey(KeyCode.A))// Aキー（左移動）
            {
                _rigidBody.AddForce(-transform.right * 10 * _speed);
            }
            Vector3 _currentPos = transform.position;

            ///範囲を超えていたら範囲内の値を代入する
            _currentPos.x = Mathf.Clamp(_currentPos.x, -xLimit, xLimit);

            ///追加　positionをcurrentPosにする
            transform.position = _currentPos;
        }
        //https://candle-stoplight-544.notion.site/4e021f226d584730b715626436ccc330
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gool")
        {
            Time.timeScale = 0;
        }
    }
}