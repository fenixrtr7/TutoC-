using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
    GameObject _cube;
    Color _color;
    Color _previusColor;

    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }

    public void Execute()
    {
        //change the color of the cube to a random color
        _previusColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    public void Undue()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _previusColor;
    }
}
