using UnityEngine;
using System.Collections;

public class LeapHandTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //public void UpdateHand()
    //{
    //    //Update the spheres first
    //    updateSpheres();

    //    //Update Arm only if we need to
    //    if (_showArm)
    //    {
    //        updateArm();
    //    }

    //    //The cylinder transforms are deterimined by the spheres they are connected to
    //    updateCylinders();
    //}

    ////Transform updating methods

    //private void updateSpheres()
    //{
    //    //Update all spheres
    //    List<Finger> fingers = hand_.Fingers;
    //    for (int i = 0; i < fingers.Count; i++)
    //    {
    //        Finger finger = fingers[i];
    //        for (int j = 0; j < 4; j++)
    //        {
    //            int key = getFingerJointIndex((int)finger.Type, j);
    //            Transform sphere = _jointSpheres[key];
    //            sphere.position = finger.Bone((Bone.BoneType)j).NextJoint.ToVector3();
    //        }
    //    }

    //    palmPositionSphere.position = hand_.PalmPosition.ToVector3();

    //    Vector3 wristPos = hand_.PalmPosition.ToVector3();
    //    wristPositionSphere.position = wristPos;

    //    Transform thumbBase = _jointSpheres[THUMB_BASE_INDEX];

    //    Vector3 thumbBaseToPalm = thumbBase.position - hand_.PalmPosition.ToVector3();
    //    mockThumbJointSphere.position = hand_.PalmPosition.ToVector3() + Vector3.Reflect(thumbBaseToPalm, hand_.Basis.xBasis.ToVector3());
    //}

    //private void updateArm()
    //{
    //    var arm = hand_.Arm;
    //    Vector3 right = arm.Basis.xBasis.ToVector3() * arm.Width * 0.7f * 0.5f;
    //    Vector3 wrist = arm.WristPosition.ToVector3();
    //    Vector3 elbow = arm.ElbowPosition.ToVector3();

    //    float armLength = Vector3.Distance(wrist, elbow);
    //    wrist -= arm.Direction.ToVector3() * armLength * 0.05f;

    //    armFrontRight.position = wrist + right;
    //    armFrontLeft.position = wrist - right;
    //    armBackRight.position = elbow + right;
    //    armBackLeft.position = elbow - right;
    //}

    //private void updateCylinders()
    //{
    //    for (int i = 0; i < _cylinderTransforms.Count; i++)
    //    {
    //        Transform cylinder = _cylinderTransforms[i];
    //        Transform sphereA = _sphereATransforms[i];
    //        Transform sphereB = _sphereBTransforms[i];

    //        Vector3 delta = sphereA.position - sphereB.position;

    //        if (!_hasGeneratedMeshes)
    //        {
    //            MeshFilter filter = cylinder.GetComponent<MeshFilter>();
    //            filter.sharedMesh = generateCylinderMesh(delta.magnitude / transform.lossyScale.x);
    //        }

    //        cylinder.position = sphereA.position;

    //        if (delta.sqrMagnitude <= Mathf.Epsilon)
    //        {
    //            //Two spheres are at the same location, no rotation will be found
    //            continue;
    //        }

    //        cylinder.LookAt(sphereB);
    //    }

    //    _hasGeneratedMeshes = true;
    //}

    //private void updateArmVisibility()
    //{
    //    for (int i = 0; i < _armRenderers.Count; i++)
    //    {
    //        _armRenderers[i].enabled = _showArm;
    //    }
    //}
}
