using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboveOrBelow : MonoBehaviour
{
    public Transform targetT;
    public Transform turretT;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(AboveOrBelowFunction(turretT, targetT));
    }

    private int AboveOrBelowFunction(Transform turret, Transform target) {
        
        return (turret.up.x * (target.position.x - turret.position.x) + turret.up.y * (target.position.y - turret.position.y) + turret.up.z * (target.position.z - turret.position.z) >= 0) ? 1 : 0;
    }
}
