using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionEsfera : MonoBehaviour {
public float vel =0f;
    public bool hayMov = false;

    // Use this for initialization
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "IniciarRun");
    }

        void IniciarRun()
        {
            hayMov = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (hayMov)
            {
                GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * vel, 0);
            }
        }
    }

