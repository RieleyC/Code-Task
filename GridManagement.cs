using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creating a class for managing the grid.
public class GridManagement : MonoBehaviour {
    // Making width/height
    [SerialiseField] private int _width, _height;
    // Spawning Tiles
    [SerialiseField] private Tile _tilespawn;   
    // Camera transformation
    [SerialiseField] private Transform _cam;
    // Setting up a logic dictionary for the tiles.
    private Dictionary<Vector2, Tile> _tiles; 

    void Start(){
        GenerateGrid();
    }

    // Generates the grid for play.
    void GenerateGrid(){
        // Allowing logic to be applied to the tiles.
        _tiles = new Dictionary<Vector2, Tile>();
        // Controls the 'width' variable of the grid
        for (int i = 0; i < _width, x++){ 
            // Controls the 'height' variable of the grid
            for (int y = 0; i < _height, y++){
                // Loads in square tiles to the grid.
                var SpawnedTile = Instantiate(_tilespawn, new Vector3(x,y), Quarternion.identity);
                SpawnedTile.name = $"Tile {x} {y}";
                
                // Checks if x is even and y is odd, or vice versa.
                var isOffest = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                SpawnedTile.Init(isOffest);

                _tiles[new vector2(x, y)] = SpawnedTile;

            }
        }
        // Moving the camera to centre on the grid instead of one of the corners.
        _cam.transform.position = new Vector3((float)_width/2 -0.5f,(float)_height/2 -0.5f, -10);        
    }

    public Tile GetTileAtPosition(Vector2 pos) {
        if(_tiles.TryGetValue(pos,out var tile)){
            return tile; 
        }
        
        return null;
    }
}