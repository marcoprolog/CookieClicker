using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
CookieClicker clicker;

    // Start is called before the first frame update
    void Start()
    {
        clicker = GetComponent<CookieClicker>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("got a cookie");
        clicker.counter++;
    }
}
