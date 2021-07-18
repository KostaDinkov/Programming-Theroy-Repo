using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private int fatness;

    public int Fatness
    {
        get => this.fatness;
        set
        {
            if (value <= 0)
            {
                this.fatness = 1;
            }
            else
            {
                this.fatness = value;
            }
        }
    }

    void Awake()
    {
        this.Fatness = 200;
    }

    public override string GetDisplayInfo()
    {
        return $"I am a sphere and my Fatness is {this.Fatness}";
    }
}
