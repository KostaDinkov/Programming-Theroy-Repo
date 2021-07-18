using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{

    public void ChangeColor()
    {
        var renderer = this.gameObject.GetComponent<Renderer>();
        renderer.material.SetColor("_Color", this.GetRandomColor());
    }

    private Color GetRandomColor()
    {
        return new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    void OnMouseDown()
    {
        this.DisplayInfo();
        this.ChangeColor();
    }

    public abstract void DisplayInfo();

}
