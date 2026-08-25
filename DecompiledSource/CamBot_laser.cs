using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000AAC RID: 2732
[Serializable]
public class CamBot_laser : MonoBehaviour
{
	// Token: 0x06003C47 RID: 15431 RVA: 0x007CEC94 File Offset: 0x007CCE94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CamBot_laser()
	{
		if (234582 - 559928 != -325345)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (9180 - 385535 == -376355)
			{
				base..ctor();
				if (148397 - 492340 != -343942)
				{
					this.xiTuIEnFSH = new Vector3((float)0, (float)0, (float)30);
					if (252992 - 431767 == -178775)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C48 RID: 15432 RVA: 0x007CED38 File Offset: 0x007CCF38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (294082 - 95726 != 198357)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (79095 - 81886 != -2790)
			{
				this.RHEun07kHB = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (115599 - 499627 == -384028)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.xiTuIEnFSH);
					if (105929 - 39040 != 66890)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x007CEE04 File Offset: 0x007CD004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.VSDuQjc5Dr = nOwner;
		this.JtLueFL4M5 = (CharacterControl)this.VSDuQjc5Dr.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x007CEE30 File Offset: 0x007CD030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (138003 - 49255 != 88748)
		{
		}
		for (;;)
		{
			this.O2LuJ2WpHb += Time.deltaTime;
			if (211656 - 510797 == -299141)
			{
				if (this.O2LuJ2WpHb < this.RHEun07kHB.life)
				{
					break;
				}
				if (197243 - 575734 == -378491)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (260522 - 574500 == -313978)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003C4B RID: 15435 RVA: 0x007CEEEC File Offset: 0x007CD0EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (196576 - 30226 != 166350)
		{
		}
		for (;;)
		{
			if (!(mCollider.gameObject.tag == "Player"))
			{
				if (282147 - 379347 != -97200)
				{
					continue;
				}
				if (!(mCollider.gameObject.tag == "Enemy"))
				{
					break;
				}
				if (117034 - 328631 != -211597)
				{
					continue;
				}
			}
			if (mCollider.gameObject.layer == this.VSDuQjc5Dr.layer)
			{
				break;
			}
			if (116529 - 575167 == -458638)
			{
				if (mCollider.gameObject.layer == 2)
				{
					if (275442 - 27458 == 247984)
					{
						break;
					}
				}
				else
				{
					if (!this.JtLueFL4M5)
					{
						break;
					}
					if (84096 - 576773 == -492677)
					{
						if (!this.JtLueFL4M5.isMine)
						{
							break;
						}
						if (173680 - 477234 != -303553)
						{
							this.JtLueFL4M5.hit(11, mCollider.gameObject, (int)(0.5f * (float)this.JtLueFL4M5.atk + (float)this.JtLueFL4M5.talAdjust(20)), 2, 0, Vector3.zero);
							if (99963 - 246650 == -146687)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003C4C RID: 15436 RVA: 0x007CF09C File Offset: 0x007CD29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003C4D RID: 15437 RVA: 0x007CF0A0 File Offset: 0x007CD2A0
	internal static bool gROx6X5Cc0vTJObosTR5()
	{
		return true;
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x007CF0A4 File Offset: 0x007CD2A4
	internal static bool UUdqN75CURlhNrOBd1FD()
	{
		return false;
	}

	// Token: 0x040049D0 RID: 18896
	private ProjectileControl RHEun07kHB;

	// Token: 0x040049D1 RID: 18897
	private GameObject VSDuQjc5Dr;

	// Token: 0x040049D2 RID: 18898
	private CharacterControl JtLueFL4M5;

	// Token: 0x040049D3 RID: 18899
	private Vector3 xiTuIEnFSH;

	// Token: 0x040049D4 RID: 18900
	private float O2LuJ2WpHb;
}
