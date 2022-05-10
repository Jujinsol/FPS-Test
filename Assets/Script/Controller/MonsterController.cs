using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour {

	public const string IDLE	= "Idle";
	public const string RUN		= "Run";
	public const string ATTACK	= "Attack";
	public const string DAMAGE	= "Damage";
	public const string DEATH	= "Death";

	Animation anim;
    Stat _stat;
	PlayerStat _playerStat;

	void Start () {
		anim = GetComponent<Animation>();
	}

    private void Update()
    {

    }

    public void IdleAni (){
		anim.CrossFade (IDLE);
	}

	public void RunAni (){
		anim.CrossFade (RUN);
	}

	public void AttackAni (){
		anim.CrossFade (ATTACK);
	}

	public void DamageAni (){
		anim.CrossFade (DAMAGE);
	}

	public void DeathAni (){
		anim.CrossFade (DEATH);
	}

    public void OnTriggerEnter(Collider other)
    {
		_stat = gameObject.GetComponent<Stat>();
		_stat.OnHit();
    }

}
