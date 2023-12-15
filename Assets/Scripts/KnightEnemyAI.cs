using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KnightEnemyAI : MonoBehaviour
{
    [SerializeField] private Transform playpos;
    [SerializeField] private Transform enemypos;
    //[SerializeField] private LayerMask PlayerLayer;
    NavMeshAgent agent;
    int Health = 2, cHealth;
    private Animator anims;
    private Vector2 movement;
    //private Vector3 dir;
    //private float detectionRadius = 8f, attRadius = 0.5f;
    //private bool candetect, canattack;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        cHealth = Health;
        anims = GetComponent<Animator>();
    }

    private void Update()
    {
        agent.SetDestination(playpos.position);

        
        //candetect = Physics2D.OverlapCircle(transform.position, detectionRadius, PlayerLayer);
        //canattack = Physics2D.OverlapCircle(transform.position, attRadius, PlayerLayer);

        //if (candetect && !canattack)
        //{
            //anims.SetBool("IsWalkin", candetect);

            
        //}
        //else if (candetect && canattack)
        //{
            //anims.SetBool("IsWalkin", false);
            //anims.SetBool("Attackin", canattack);
        //}

        //dir = playpos.position - enemypos.position;
        //float angle = Mathf.Atan2(dir.x , dir.y) * Mathf.Rad2Deg;
        //dir.Normalize();
        //movement = dir;

        //if (movement.x != 0 || movement.y != 0)
        //{
            //anims.SetFloat("X", movement.x);
            //anims.SetFloat("Y", movement.y);

            //anims.SetBool("IsWalkin", true);
        //}
        //else
        //{
           //anims.SetBool("IsWalkin", false);
        //}

    }

    //private void OnMoves(InputValue value)
    //{
    //movement = value.Get<Vector2>();

    //if (movement.x != 0 || movement.y != 0)
    //{
    // anims.SetFloat("X", movement.x);
    // anims.SetFloat("Y", movement.y);

    //anims.SetBool("IsWalkin", true);
    //}
    //else
    //{
    // anims.SetBool("IsWalkin", false);
    //}
    //}

    public void TakeDam(int dam)
    {
        cHealth -= dam;

        if(cHealth <= 0)
        {
            KillKnight();
        }
    }

    private void KillKnight()
    {
        anims.SetBool("Death", true);
        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
