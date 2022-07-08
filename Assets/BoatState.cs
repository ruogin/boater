using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatState : MonoBehaviour
{
    public string tag;
    private UnityEngine.UI.Button parentButton;

    // Start is called before the first frame update
    void Start()
    {
        parentButton = (this.GetComponent(typeof(UnityEngine.UI.Button))) as UnityEngine.UI.Button;
        System.Threading.Thread.Sleep(10);
        Debug.Log(parentButton.onClick.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
