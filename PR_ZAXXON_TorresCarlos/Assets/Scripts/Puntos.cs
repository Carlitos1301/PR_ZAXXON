using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    [SerializeField] Text scoreTx;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.globalscore = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        scoreTx.text = "" + GameManager.globalscore;
    }
}
