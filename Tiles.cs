using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{   // Setting up colours and sprite rendering.
    [SerialiseField] private Colour _baseColour,_offsetColour;
    [SerialiseField] private SpriteRenderer _renderer;
    [SerialiseField] private GameObject _highlight;

    // If offset,  set the colour to the offset colour.
    // Otherwise, set to the base colour.
    public void Init(bool isOffset){
        _renderer.colour = isOffest ? _offsetColour : _baseColour;

    } // Highlighting when the mouse appears on tile.
    void OnMouseEnter() {
        _highlight.SetActive(true);
    } // Removing highlight when mouse leaves tile.
    void OnMouseExit() {
        _highlight.SetActive(false);
    }
}
