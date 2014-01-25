﻿using UnityEngine;
using System.Collections;

public class TileClass : MonoBehaviour {

	public GameObject entity;
	public GameObject[] walls;

	public const int NORTH = 0, EAST = 1, SOUTH = 2, WEST = 3;

	// Use this for initialization
	void Awake () {
		walls = new GameObject[4];
	}

	public void SetWall(int direction, GameObject wall){
		walls[direction] = wall;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}