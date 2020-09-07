using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MySecundClass : GenericSingletonClass<MySecundClass>
{
    public Text Text1, Text2, Text3;
    
    // Start is called before the first frame update
    void Start()
    {
        Text1.text = MyFirstClass.Instance.numbers.ToString() +" Set from scound class";
        print("Starting Value of the number in First Class is : "+MyFirstClass.Instance.numbers);

        Text2.text = MyFirstClass.Instance.textline.ToString() + " Set from scound class";

        print("Starting Value of the String text in First Class is : " + MyFirstClass.Instance.textline);

        MyFirstClass.Instance.numbers += 100;

        print("After change Value of the number in First Class is : " + MyFirstClass.Instance.numbers);
    }

    void Update()
    {      

    }
}
