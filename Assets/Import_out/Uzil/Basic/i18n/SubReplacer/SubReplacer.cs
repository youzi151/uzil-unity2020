﻿
namespace Uzil.i18n {

public abstract class SubReplacer {

	/*======================================Constructor==========================================*/

	/*=====================================Static Members========================================*/

	/*=====================================Static Funciton=======================================*/

	/*=========================================Members===========================================*/

	/*========================================Components=========================================*/
	
	/*==========================================Event============================================*/

	/*======================================Unity Function=======================================*/

	/*========================================Interface==========================================*/

	/*=====================================Public Function=======================================*/

	/** 代換字詞 */
	public virtual void Render (ReadProcess process) {

	}

	/** 取得未代換字串 */
	protected string getUnReplace (string key) {
		return "<size=50%>"+key+"</size>";
	}

	/*===================================Protected Function======================================*/
	
	/*====================================Private Function=======================================*/
	
}


}