using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAreaBehaviour : MonoBehaviour{

	public TextMeshPro areaText;
	public ARPlane arPlane;

	private void ARPlane_BoundaryChanged(ARPlaneBoundaryChangedEventArgs obj) {
		areaText.text = CalculatePlaneArea(arPlane).ToString();
	}
	private float CalculatePlaneArea(ARPlane plane) {
		return plane.size.x * plane.size.y;
	}

	public void ToggleAreaView() {
		if(areaText.enabled)
			areaText.enabled = false;
		else 
			areaText.enabled = true;
	}

	private void Update() {
		areaText.transform.rotation = Quaternion.LookRotation(areaText.transform.position - Camera.main.transform.position);
	}

    void Start(){
        
    }

    // void Update(){
        
    // }
}
