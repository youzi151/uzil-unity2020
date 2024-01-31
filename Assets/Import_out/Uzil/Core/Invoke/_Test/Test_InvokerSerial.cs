﻿using UnityEngine;

namespace Uzil.Test {

public class Test_InvokerSerial : MonoBehaviour {

	
	/*======================================Constructor==========================================*/

	/*=====================================Static Members========================================*/

	/*=====================================Static Funciton=======================================*/

	/*=========================================Members===========================================*/

	/*========================================Components=========================================*/

	/*==========================================Event============================================*/

	/*======================================Unity Function=======================================*/

	// Use this for initialization
	void Start () {

		InvokerSerial serial = new InvokerSerial();

		// 第3個要執行的
		serial.Set(()=>{
			Debug.Log("3");
		}, 3);

		// 第1個要執行的
		serial.Set(()=>{
			Debug.Log("1");
		}, 1);

		// 第2個要執行的
		serial.Set(()=>{
			Debug.Log("2");
		}, 2);

		// 移除第2個要執行的
		serial.Remove(2);

		// 開始執行全部
		serial.DoAll();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	/*========================================Interface==========================================*/

	/*=====================================Public Function=======================================*/

	/*===================================Protected Function======================================*/
	
	/*====================================Private Function=======================================*/
}


}