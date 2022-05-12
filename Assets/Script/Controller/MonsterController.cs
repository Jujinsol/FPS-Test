using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
		_stat = GetComponent<Stat>();
		if (_stat.IsDead)
        {
			DeathAni();
			Destroy(gameObject, 0.8f);
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

		/*_stat = GetComponent<Stat>();
		GameObject go = GameObject.Find("Player");
		_playerStat = go.GetComponent<PlayerStat>();

		while (_playerStat._hp > 0)
		{
			_playerStat._hp -= _stat.Attack;
			if (_playerStat._hp <= 0)
				_playerStat._hp = 0;
		}*/
	}

	public void DamageAni (){
		anim.CrossFade (DAMAGE);
	}

	public void DeathAni (){
		anim.CrossFade (DEATH, 0.4f);
	}
    #endregion

}
