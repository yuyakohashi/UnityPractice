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
            ///�v���C���[�������Ői�݁A�S�[���܂Ō���������
            _rigidBody.velocity = transform.forward * _speed;

            /*
            if (Input.GetKey(KeyCode.W))// W�L�[�i�O���ړ��j
            {
                _rigidBody.velocity = transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.S))// S�L�[�i����ړ��j
            {
                _rigidBody.velocity = -transform.forward * _speed;
            }
            if (Input.GetKey(KeyCode.D))// D�L�[�i�E�ړ��j
            {
                _rigidBody.velocity = transform.right * _speed;
            }
            if (Input.GetKey(KeyCode.A))// A�L�[�i���ړ��j
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