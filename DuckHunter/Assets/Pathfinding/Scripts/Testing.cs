﻿/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using CodeMonkey;

public class Testing : MonoBehaviour {
    
    [SerializeField] private PathfindingDebugStepVisual pathfindingDebugStepVisual;
    [SerializeField] private PathfindingVisual pathfindingVisual;
    [SerializeField] private CharacterPathfindingMovementHandler characterPathfinding;
    private Pathfinding pathfinding;

    private void Start() {
        pathfinding = new Pathfinding(20, 15);
        pathfindingDebugStepVisual.Setup(pathfinding.GetGrid());
        pathfindingVisual.SetGrid(pathfinding.GetGrid());
    }

    private void Update() {
        /*
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Should be first debug");
            Vector3 mouseWorldPosition = UtilsClass.GetMouseWorldPosition();
            pathfinding.GetGrid().GetXY(mouseWorldPosition, out int x, out int y);
            Debug.Log("Before call to deep search");
            List<PathNode> path = pathfinding.BreadthFirstSearch(0, 0, x, y);
            Debug.Log("After the call to search deep");
            if (path != null) {
                for (int i=0; i<path.Count - 1; i++) {
                    Debug.DrawLine(new Vector3(path[i].x, path[i].y) * 10f + Vector3.one * 5f, new Vector3(path[i+1].x, path[i+1].y) * 10f + Vector3.one * 5f, Color.green, 5f);
                }
            }
            characterPathfinding.SetTargetPosition(mouseWorldPosition);

            
            GameObject duck;
            duck = new GameObject("Duck");
            SpriteRenderer renderer = duck.AddComponent<SpriteRenderer>();
            renderer.sprite = (UnityEngine.Sprite)Resources.Load("whiteL3.png");
            //Add Components

            duck.AddComponent<BoxCollider>();
            duck.AddComponent<MeshRenderer>();
            duck.transform.position = new Vector3(x, y, 1);
            
        }
        */
        if (Input.GetMouseButtonDown(1)) {
            Vector3 mouseWorldPosition = UtilsClass.GetMouseWorldPosition();
            pathfinding.GetGrid().GetXY(mouseWorldPosition, out int x, out int y);
            pathfinding.GetNode(x, y).SetIsWalkable(!pathfinding.GetNode(x, y).isWalkable);
        }
        
    }

}
