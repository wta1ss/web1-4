﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

	float rotSpeed = 0; // 回転速度

	void Start() {
	}

	void Update() {
		// マウスが押されたら回転速度を設定する。
		if(Input.GetMouseButtonDown(0)) {
			this.rotSpeed = 10;
		}

		// 回転速度分、ルーレットを回転させる
		transform.Rotate(0, 0, this.rotSpeed);

		// ルーレットを減速させる（追加）
		this.rotSpeed *= 0.96f;
	}
}