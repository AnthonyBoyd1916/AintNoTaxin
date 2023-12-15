using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator anims;
    [SerializeField] private Transform attPoint;
    [SerializeField] private float attRange = 1f;
    [SerializeField] private LayerMask enemLayer;

    private void Awake()
    {
        anims = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PAttack();
        }
    }

    void PAttack()
    {
        anims.SetTrigger("Attackin");
        Collider2D[] hitenemies = Physics2D.OverlapCircleAll(attPoint.position, attRange, enemLayer);

        foreach(Collider2D enemy in hitenemies)
        {
            enemy.GetComponent<KnightEnemyAI>().TakeDam(1);
        }

    }

    void OnDrawGizmosSellected()
    {
        if (attPoint == null) { return; }       
        Gizmos.DrawWireSphere(attPoint.position, attRange);
    }
}
