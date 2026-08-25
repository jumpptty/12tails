using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200005B RID: 91
[Serializable]
public class CrystalBug_shard : MonoBehaviour
{
	// Token: 0x060001D1 RID: 465 RVA: 0x0002EE98 File Offset: 0x0002D098
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrystalBug_shard()
	{
		if (136732 - 572515 != -435783)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (135195 - 251129 == -115934)
			{
				base..ctor();
				if (67236 - 386088 == -318852)
				{
					this.snSfedEXu = new Vector3((float)0, (float)0, (float)14);
					if (122207 - 408380 == -286173)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0002EF3C File Offset: 0x0002D13C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (154601 - 483563 != -328962)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (193484 - 183891 == 9593)
			{
				this.Yu8ZEZWAy = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (271878 - 355768 != -83889)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.snSfedEXu);
					if (186152 - 268704 != -82551)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0002F008 File Offset: 0x0002D208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.RWZCW36C6 = nOwner;
		this.txYM4D5JX = (CharacterControl)this.RWZCW36C6.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0002F034 File Offset: 0x0002D234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (205000 - 330562 != -125562)
		{
		}
		for (;;)
		{
			this.dDNLGYSZ6 += Time.deltaTime;
			if (178280 - 185354 == -7074)
			{
				if (this.dDNLGYSZ6 < this.Yu8ZEZWAy.life)
				{
					break;
				}
				if (218475 - 104202 == 114273)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (255810 - 47997 == 207813)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0002F0F0 File Offset: 0x0002D2F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (165626 - 560857 != -395231)
		{
		}
		for (;;)
		{
			if (!(mCollider.gameObject.tag == "Player"))
			{
				if (288438 - 501938 != -213500)
				{
					continue;
				}
				if (!(mCollider.gameObject.tag == "Enemy"))
				{
					break;
				}
				if (270086 - 5544 == 264543)
				{
					continue;
				}
			}
			if (mCollider.gameObject.layer == this.RWZCW36C6.layer)
			{
				break;
			}
			if (51075 - 15771 == 35304)
			{
				if (mCollider.gameObject.layer == 2)
				{
					if (196168 - 77384 == 118784)
					{
						break;
					}
				}
				else
				{
					if (!this.txYM4D5JX)
					{
						break;
					}
					if (194744 - 105752 == 88992)
					{
						if (!this.txYM4D5JX.isMine)
						{
							break;
						}
						if (120246 - 423073 != -302826)
						{
							this.txYM4D5JX.hit(30, mCollider.gameObject, this.txYM4D5JX.talAdjust(80), 2, 0, 0.5f * Vector3.forward);
							if (109256 - 506741 != -397484)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0002F298 File Offset: 0x0002D498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0002F29C File Offset: 0x0002D49C
	internal static bool yrmsMspsqqnmOhPv3pW()
	{
		return true;
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0002F2A0 File Offset: 0x0002D4A0
	internal static bool DMDOnkp9lEp1XpCjksO()
	{
		return false;
	}

	// Token: 0x04000215 RID: 533
	private ProjectileControl Yu8ZEZWAy;

	// Token: 0x04000216 RID: 534
	private GameObject RWZCW36C6;

	// Token: 0x04000217 RID: 535
	private CharacterControl txYM4D5JX;

	// Token: 0x04000218 RID: 536
	private Vector3 snSfedEXu;

	// Token: 0x04000219 RID: 537
	private float dDNLGYSZ6;
}
