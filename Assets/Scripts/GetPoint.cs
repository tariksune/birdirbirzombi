using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetPoint : MonoBehaviour
{

    public bool inGetPoint;
    public TextMeshProUGUI getPointText;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        inGetPoint = false;
    }

    // Update is called once per frame
    void Update()
    {
               
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GetPoint")
        {
            inGetPoint = true;
            score++;
            getPointText.text = score.ToString();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GetPoint")
        {
            inGetPoint = false;
            getPointText.text = score.ToString();
        }
    }
}
