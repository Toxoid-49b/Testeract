using UnityEngine;
using System.Collections;

public class TPlayer : MonoBehaviour {

	public GameObject myCameraObject;
	public GameObject myPlayerModel;

	private bool isDead;
	private NetworkView myNetworkView;

	void Awake(){

		myNetworkView = GetComponent<NetworkView>();
		if(!myNetworkView.isMine){

			myCameraObject.SetActive(false);
			GetComponent<MouseLook>().enabled = false;
			GetComponent<CharacterController>().enabled = false;

		}

	}

	public void Kill(){

		isDead = true;
		myPlayerModel.AddComponent<Rigidbody>();
		GetComponent<CharacterController>().enabled = false;

		//Fun camera animation as to allow dead player to view 12 year old player teabagging said player

	}

	public void Spawn(){

		isDead = false;
		if(myPlayerModel.GetComponent<Rigidbody>() != null)Destroy(myPlayerModel.GetComponent<Rigidbody>());
		myPlayerModel.transform.rotation = Quaternion.identity;
		GetComponent<CharacterController>().enabled = true;

	}

}
