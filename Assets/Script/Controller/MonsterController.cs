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

	void Start () {
		anim = GetComponent<Animation>();
	}

    private void Update()
    {
		DeadCheck();
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
		anim.CrossFade (DEATH, 0.4f);
	}

}
