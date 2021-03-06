using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MonsterController : MonoBehaviour {


	public const string IDLE	= "Idle";
	public const string RUN		= "Run";
	public const string ATTACK	= "Attack";
	public const string DAMAGE	= "Damage";
	public const string DEATH	= "Death";

	[SerializeField]
	float _followRange = 10.0f;
	[SerializeField]
	float _attackRange = 2.0f;

	private Transform _target;
	private NavMeshAgent nma;
	Animation anim;
    Stat _stat;
	PlayerStat _playerStat;
	BigMonStat _bigStat;

	private float TimeLeft = 0.9f;
	private float nextTime = 0.0f;

	void Start () {
		anim = GetComponent<Animation>();
		_target = GameObject.FindGameObjectWithTag("Player").transform;
		nma = GetComponent<NavMeshAgent>();
	}

    private void Update()
    {
		if ((_target.transform.position - nma.destination).magnitude < _followRange)
			UpdateFollow();

		DeadCheck();
	}

	void UpdateFollow()
	{
		Vector3 dir = _target.transform.position - transform.position;
		if (dir.magnitude < _attackRange)
		{
			nma.SetDestination(transform.position);
			UpdateAttack();
		}
		else
			nma.SetDestination(_target.transform.position);
	}

	void UpdateAttack()
	{
		Vector3 dir = _target.transform.position - transform.position;
		if (dir.magnitude < _attackRange)
		{
			AttackAni();
		}

	}

	void DeadCheck()
    {
		if (SceneManager.GetActiveScene().name == "FinalStage")
		{
			_bigStat = GameObject.Find("BigMonster").GetComponent<BigMonStat>();
			if (_bigStat.IsDead)
			{
				DeathAni();
				Destroy(gameObject, 0.8f);
			}
		}
		else
		{
			_stat = GameObject.Find("Monster").GetComponent<Stat>();
			if (_stat.IsDead)
			{
				DeathAni();
				Destroy(gameObject, 0.8f);
			}
		}
    }

    #region Animation
    public void IdleAni (){
		anim.CrossFade (IDLE);
	}

	public void RunAni (){
		anim.CrossFade (RUN);
	}

	public void AttackAni (){
		anim.CrossFade (ATTACK);
		if (Time.time > nextTime)
		{
			nextTime = Time.time + TimeLeft;
			Attack();
		}
	}

	public void DamageAni (){
		anim.CrossFade (DAMAGE);
	}

	public void DeathAni (){
		anim.CrossFade (DEATH, 0.4f);
	}
	#endregion

	void Attack()
	{
		_playerStat = GameObject.Find("Player").GetComponent<PlayerStat>();

		if (SceneManager.GetActiveScene().name == "FinalStage")
		{
			_bigStat = GameObject.Find("BigMonster").GetComponent<BigMonStat>();
			_bigStat.BigMonAttack(_playerStat);
        }
		else
		{
			_stat = GameObject.Find("Monster").GetComponent<Stat>();
			_stat.MonsterAttack(_playerStat);
		}
	}
}
