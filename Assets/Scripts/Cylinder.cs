using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private float tallness;

    public float Tallness
    {
        get => this.tallness;
        set
        {
            if (value < 0)
            {
                this.tallness = 0;
            }
            else
            {
                this.tallness = value;
            }
        }
    }

    private void Awake()
    {
        this.Tallness = 100f;
    }

    public override string GetDisplayInfo()
    {
        return $"I am a cylinder and my tallness is {this.Tallness}";
    }

    
}
