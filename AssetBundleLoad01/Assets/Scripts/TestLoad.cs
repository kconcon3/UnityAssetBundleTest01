using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoad : MonoBehaviour {

	void Start ()
	{
		// アセットバンドルのロード
		AssetBundle ab = AssetBundle.LoadFromFile("AssetBundleData/asset_pack01");

		if( ab == null )
		{
			// ロード失敗
			Debug.Log("error : load bundle");
		}
		else
		{
			// ロード成功
			Debug.Log("success : load bundle");

			// Prefabのロード
			GameObject prefab = ab.LoadAsset<GameObject>("Cat01");		// 注：LoadAssetは階層指定が出来ない

			if( prefab == null )
			{
				// Prefabのロード失敗
				Debug.Log("error : load asset");
			}
			else
			{
				// Prefabのロード成功

				// Prefabをインスタンス化
				Instantiate(prefab);
			}
		}
	}
}
