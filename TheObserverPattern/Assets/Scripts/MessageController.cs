using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    Text message;
    void Start()
    {
        message = this.GetComponent<Text>();
        message.enabled = false;
    }

    public void SetMassage(GameObject go)
    {
        message.text = "You Picked up" + go.ToSafeString() +"!.." ;
        message.enabled = true;
        Invoke("Turnoff", 2f);
    }
    void Turnoff()
    {
        message.enabled = false;
    }
}
