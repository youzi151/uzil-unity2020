
using UnityEngine;
using UnityCamera = UnityEngine.Camera;

namespace Uzil.BuiltinUtil {

public class CameraObj : MonoBehaviour {
	
	/*======================================Constructor==========================================*/

	/*=====================================Static Members========================================*/

	/*=====================================Static Funciton=======================================*/

	/*=========================================Members===========================================*/

	/* 識別 */
    public string key = null;

	/* 攝影機 */
	public UnityCamera targetCamera = null;

	/*========================================Components=========================================*/

	/*==========================================Event============================================*/

    /*======================================Unity Function=======================================*/
	
	void Awake () {
		if (this.key != null) CameraUtil.Reg(this.key, this);
	}
	
	void Update () {
	
	}

	void OnDestroy () {
		if (this.key != null) CameraUtil.UnReg(this.key);
	}
	
	/*========================================Interface==========================================*/

	/*=====================================Public Function=======================================*/

	/*===================================Protected Function======================================*/
	
	/*====================================Private Function=======================================*/
}


}