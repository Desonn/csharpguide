using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
    GameObject _cube;
    Color _color;
    Color _lastColor;
    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }
    public void Excute()
    {
        //change color of cube on click
        _lastColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    public void Undue()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _lastColor; ;
    }

    
}
