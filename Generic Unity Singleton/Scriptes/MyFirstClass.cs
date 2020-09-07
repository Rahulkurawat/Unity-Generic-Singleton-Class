using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstClass : GenericSingletonClass<MyFirstClass> 
{
    public int numbers = 100;

    public string textline = "I am first class";
  
    // Start is called before the first frame update
  
    void Start()
    {
        MySecundClass.Instance.Text3.text = "This Text is set from First Class";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
