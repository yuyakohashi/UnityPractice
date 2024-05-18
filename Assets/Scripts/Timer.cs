using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float _time;
    public bool _counterFlag = false;
    public Text _text;

    void Update()
    {
        //Spaceキーで計測開始
        if (Input.GetKey(KeyCode.Space))
        {
            _counterFlag = true;
        }

        if (_counterFlag == true)
        {
            _time += Time.deltaTime;
            _text.text = ("Time： " + (_time).ToString("F2"));
        }
    }
}
 