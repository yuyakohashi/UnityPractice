using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    float elapsedTime;
    bool counter_flag = false;
    public Text _text;

    void Update()
    {
        //Spaceキーで計測開始、停止を切り替え
        if (Input.GetKey(KeyCode.Space))
        {
            counter_flag = !counter_flag;
        }

        if (counter_flag == true)
        {
            elapsedTime += Time.deltaTime;
            _text.text = ("Time： " + (elapsedTime).ToString("0"));
        }
    }
}
 