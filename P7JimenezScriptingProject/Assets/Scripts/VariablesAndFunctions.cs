using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Creating an integer variable
    public int myInt = 67;

    // Start is called before the first frame update
    void Start()

    {
        //running my int variable thru the function
        myInt = MultiplyByTwo(myInt);


        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
    
   





   

