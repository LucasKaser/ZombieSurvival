using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyH : MonoBehaviour
{
    public Collider MainCollider;
    public Collider[] AllColliders;
    private void Awake()
    {
        MainCollider = GetComponent<Collider>();
        AllColliders = GetComponentsInChildren<Collider>(true);
        DoRagdoll(false);

    }

   public void DoRagdoll(bool isRagdoll)
    {
        foreach (var col in AllColliders)
            col.enabled = isRagdoll;
        MainCollider.enabled = !isRagdoll;
        GetComponent<Rigidbody>().useGravity = !isRagdoll;
        GetComponent<Animator>().enabled = !isRagdoll;
    }
}
