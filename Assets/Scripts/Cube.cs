using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Cube : Shape
{
    private string awesomenessLevel;
    private readonly string[] awesomenessLevels = {"great", "mediocre", "ultra", "mega", "insane"};

    void Awake()
    {
        this.awesomenessLevel = this.awesomenessLevels[2];
    }

    public string AwesomenessLevel
    {
        get => this.awesomenessLevel;
        set
        {
            if (!this.awesomenessLevels.Contains(value))
            {
                this.awesomenessLevel = value;
            }
            else
            {
                this.awesomenessLevel = this.awesomenessLevels[0];
            }
        }
    }

    public override string GetDisplayInfo()
    {
        return $"I am a cube and my awesomeness is {this.AwesomenessLevel}";
    }

    
}
