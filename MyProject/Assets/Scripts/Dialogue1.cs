using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue1 : MonoBehaviour
{
    public GameObject Balloon;
    public string Text;

    private GameObject _curBalloon;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("hit");

        if (col.tag != "Player")
        {
            return;
        }

        Canvas canvas = FindObjectOfType<Canvas>();

        if (canvas == null)
        {
            return;
        }

        _curBalloon = Instantiate(Balloon);//create text balloon
        _curBalloon.GetComponent<RectTransform>().position = new Vector2(400,900);//position text balloon
        _curBalloon.GetComponent<Text>().text = Text;//udate text in balloon
        _curBalloon.transform.parent = canvas.transform;//aadd balloon under Canvas

    }

    // Update is called once per frame
    void OnTriggerExit(Collider col)
    {
        if (col.tag!="Player")
        {
            return;
        }

        if (_curBalloon==null)
        {
            return;
        }

        Destroy(_curBalloon);
    }
}
