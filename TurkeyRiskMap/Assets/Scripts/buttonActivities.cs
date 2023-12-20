using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class buttonActivites : MonoBehaviour
{
    Database db;

    public GameObject canvas, inspector;
    public TMP_Text pName, pInfo, IText, IRain, IDisaster,ISoil;
    string[] controlArray = new string[81];


    private void Awake()
    {
        db = GameObject.FindWithTag("DB").GetComponent<Database>();
    }

    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = 0.1f;

        

        for (int i = 0; i < 81; i++)
        {
            controlArray[i] = (i + 1).ToString();
        }
        
        
    }

    

    
    public void openCanvas()
    {

        
        
    }

    public void onMouseEnter()
    {
        for (int i = 0; i < controlArray.Length; i++)
        {
            if (this.gameObject.tag == controlArray[i])
            {
               
                Debug.Log("oldu");
                db.getData(Convert.ToInt32(controlArray[i]));
            }
            else
            {
                continue;
            }
        }

    }

    public void onMouseExit()
    {
        inspector.SetActive(false);
        
    }

    public void closeCanvas()
    {
        canvas.SetActive(false);
    }

    
}
