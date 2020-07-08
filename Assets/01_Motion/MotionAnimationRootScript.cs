using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Animator))]
    
public class MotionAnimationRootScript : MonoBehaviour {

    HumanPoseHandler humanPoseHandler;
	HumanPose humanPose;
	Animator anim;

    Transform head;
            
    // void OnAnimatorMove()
    // {
    //         Animator animator = GetComponent<Animator>(); 
                              
    //         if (animator)
    //         {
    //             Vector3 newPosition = transform.position;
    //            newPosition.z += Time.deltaTime; 
    //  transform.position = newPosition;
    //             float legPosition = 0;
    //             legPosition += Time.deltaTime;
    //             animator.SetFloat("LeftUpperLegIn-Out", legPosition); 
    //         }
    // }

    void Start() {
        LookUpMuscleIndex();
    }
    void Update() {
        anim = GetComponent<Animator>();

		// run this if you want the indexes to muscles on your character
		

		humanPoseHandler = new HumanPoseHandler(anim.avatar, transform);
		// get human pose
		humanPose = new HumanPose();

		// TODO keeping body above plane
		//humanPose.bodyPosition = current_position;

		// reference pose to pose handler
		humanPoseHandler.GetHumanPose(ref humanPose);

		// set a specific musle; 9: Neck Nod Down-Up
        humanPose.muscles[9] = 40f - (40f * Time.deltaTime * 40f); 
        Debug.Log(humanPose.muscles[9]);

        // use pose information to actually set the pose; doesn't work so far
        humanPoseHandler.SetHumanPose(ref humanPose);
    }

    void LookUpMuscleIndex() {
		string[] muscleName = HumanTrait.MuscleName;
		int i = 0;
		while (i < HumanTrait.MuscleCount)
		{
			Debug.Log(i + ": " + muscleName[i] +
				" min: " + HumanTrait.GetMuscleDefaultMin(i) + " max: " + HumanTrait.GetMuscleDefaultMax(i));
			i++;
		}
	}
}