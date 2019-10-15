using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapMove : MonoBehaviour
{
    
    public Transform firstBackground;
    public Transform secondBackground;
    public Transform firstBackground2;
    public Transform secondBackground2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveBack();
    }
    void moveBack()
    {
        
        firstBackground.Translate(-2 * Time.deltaTime, 0, 0);
        firstBackground2.Translate(-2 * Time.deltaTime, 0, 0);
        secondBackground.Translate(-1 * Time.deltaTime, 0, 0);
        secondBackground2.Translate(-1 * Time.deltaTime, 0, 0);
        if (firstBackground.position.x <= -17.8f)
        {
            firstBackground.position = new Vector3(18f, firstBackground.position.y, firstBackground.position.z);
        }
        if (secondBackground.position.x <= -17.88f)
        {
            secondBackground.position = new Vector3(18f,secondBackground.position.y, secondBackground.position.z);
        }
        if (firstBackground2.position.x <= -17.8f)
        {
            firstBackground2.position = new Vector3(18f, firstBackground2.position.y, firstBackground2.position.z);
        }
        if (secondBackground2.position.x <= -17.88f)
        {
            secondBackground2.position = new Vector3(18f, secondBackground2.position.y, secondBackground2.position.z);
        }
    }
}
