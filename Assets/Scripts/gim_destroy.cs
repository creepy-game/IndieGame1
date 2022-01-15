using UnityEngine;

public class gim_destroy : MonoBehaviour
{
	public GameObject DestoroyObject;
	public GameObject objectDestorou;
	/// 衝突した時
	/// <param name="collision"></param>
	void OnCollisionEnter(Collision collision)
	{

		// 衝突した相手にPlayerタグが付いているとき
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject);//当たっているコライダを消去
			Destroy(DestoroyObject);//当たっている物体を消去
			Destroy(objectDestorou);//2爪の物体を消去
		}
	}
}