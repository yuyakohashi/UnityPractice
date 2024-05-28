using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] private float _speed = 10.0f;
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
            _rigidBody.velocity = transform.forward * _speed;

            /*
            if (Input.GetKey(KeyCode.W))// Wキー（前方移動）
            {
                _rigidBody.velocity = transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.S))// Sキー（後方移動）
            {
                _rigidBody.velocity = -transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.D))// Dキー（右移動）
            {
                _rigidBody.velocity = transform.right * _speed;
            }
            if (Input.GetKey(KeyCode.A))// Aキー（左移動）
            {
                _rigidBody.velocity = -transform.right * _speed;
            }
            */
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