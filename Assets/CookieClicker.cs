using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieClicker : MonoBehaviour
{

    public bool click;
    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        int mul = Multiply(2, 3);
        Debug.Log(mul);

        while (mul > 0)
        {
            Debug.Log(mul);
            mul--;
        }

        for(int i = 0; i<10; i++)
        {
            //Debug.Log(i);
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        click = Input.GetKeyDown(KeyCode.C);
        if (click)
        {
            //execute when the condition is true
            Debug.Log("Click!");
            counter = counter + 1;
            //counter += 1;
            //counter++; //++counter;
        }
        else
        {
            //execute when the condition is false
        }

        // = is assignment
        // == is comparison
        if (counter == 10)
        {
            Debug.Log("You got 10!");
        }
    }

    //access_modifier return_type name( inputs )
    public int Multiply(int n1, int n2)
    {
        return n1 * n2;
    }
}
