using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float _time;
    public bool _counterFlag = false;
    public Text _text;

    void Update()
    {
        //Space�L�[�Ōv���J�n
        if (Input.GetKey(KeyCode.Space))
        {
            _counterFlag = true;
        }

        if (_counterFlag == true)
        {
            _time += Time.deltaTime;
            _text.text = ("Time�F " + (_time).ToString("F2"));
        }
    }
}
 