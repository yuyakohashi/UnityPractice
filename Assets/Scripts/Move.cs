using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    [SerializeField] private float _speed = 8f;
    [SerializeField][Tooltip("X���̈ړ��\�͈�")]private float xLimit = 9.5f;

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
            _rigidBody.velocity = transform.forward * _speed * 2f;

            if (Input.GetKey(KeyCode.D))// D�L�[�i�E�ړ��j
            {
                _rigidBody.AddForce(transform.right * 10 * _speed);
            }
            if (Input.GetKey(KeyCode.A))// A�L�[�i���ړ��j
            {
                _rigidBody.AddForce(-transform.right * 10 * _speed);
            }
            Vector3 _currentPos = transform.position;

            ///�͈͂𒴂��Ă�����͈͓��̒l��������
            _currentPos.x = Mathf.Clamp(_currentPos.x, -xLimit, xLimit);

            ///�ǉ��@position��currentPos�ɂ���
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