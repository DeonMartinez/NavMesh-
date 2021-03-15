using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    [SerializeField]
    Transform _destination;
    public bool flee = false; 

    NavMeshAgent _navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if(_navMeshAgent == null)
        {
            Debug.LogError("NavMesh agent not attached to " + gameObject.name);
        }
    }

    private void FixedUpdate()
    {
            SetDestination();    
    }
    private void SetDestination()
    {
        if(_destination != null && flee !=true)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
        if (_destination != null && flee == true)
        {
            Vector3 targetVector = -_destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }
    }
}
