using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    float elapsedTime;
    bool counter_flag = false;
    public Text _text;

    void Update()
    {
        //Space�L�[�Ōv���J�n�A��~��؂�ւ�
        if (Input.GetKey(KeyCode.Space))
        {
            counter_flag = !counter_flag;
        }

        if (counter_flag == true)
        {
            elapsedTime += Time.deltaTime;
            _text.text = ("Time�F " + (elapsedTime).ToString("0"));
        }
    }
}
 