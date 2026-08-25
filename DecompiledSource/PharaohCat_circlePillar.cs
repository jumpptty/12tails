using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000D47 RID: 3399
[Serializable]
public class PharaohCat_circlePillar : MonoBehaviour
{
	// Token: 0x06004C7F RID: 19583 RVA: 0x00972414 File Offset: 0x00970614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PharaohCat_circlePillar()
	{
		if (152852 - 335425 != -182573)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (114445 - 362353 == -247908)
			{
				base..ctor();
				if (89092 - 236941 == -147849)
				{
					this.OU7ccLHUKem = new Vector3((float)0, (float)0, (float)12);
					if (243390 - 413300 != -169909)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C80 RID: 19584 RVA: 0x009724B8 File Offset: 0x009706B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (241057 - 425424 != -184367)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (104053 - 25835 != 78219)
			{
				this.zbUccC7d0Q3 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (142488 - 280069 == -137581)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.OU7ccLHUKem);
					if (177763 - 205486 != -27722)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C81 RID: 19585 RVA: 0x00972584 File Offset: 0x00970784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.zjVccMNLwVW = nOwner;
		this.lI9ccf4NRLZ = (CharacterControl)this.zjVccMNLwVW.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06004C82 RID: 19586 RVA: 0x009725B0 File Offset: 0x009707B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (262343 - 23871 != 238472)
		{
		}
		for (;;)
		{
			this.E7KccwvjXNK += Time.deltaTime;
			if (56136 - 71082 == -14946)
			{
				if (this.E7KccwvjXNK < this.zbUccC7d0Q3.life)
				{
					break;
				}
				if (257620 - 483651 != -226030)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (37357 - 276344 != -238986)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C83 RID: 19587 RVA: 0x0097266C File Offset: 0x0097086C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (193368 - 32046 != 161322)
		{
		}
		for (;;)
		{
			if (this.vgLccUOkUqZ > Time.time)
			{
				if (232159 - 257665 != -25505)
				{
					break;
				}
			}
			else
			{
				if (!(mCollider.gameObject.tag == "Player"))
				{
					if (212223 - 342428 == -130204)
					{
						continue;
					}
					if (!(mCollider.gameObject.tag == "Enemy"))
					{
						break;
					}
					if (201145 - 506349 != -305204)
					{
						continue;
					}
				}
				this.vgLccUOkUqZ = Time.time + 0.2f;
				if (138164 - 581293 == -443129)
				{
					if (mCollider.gameObject.layer == this.zjVccMNLwVW.layer)
					{
						break;
					}
					if (16116 - 180928 != -164811)
					{
						if (mCollider.gameObject.layer == 2)
						{
							if (285602 - 590476 == -304874)
							{
								break;
							}
						}
						else
						{
							if (!this.lI9ccf4NRLZ)
							{
								break;
							}
							if (51958 - 243828 != -191869)
							{
								if (!this.lI9ccf4NRLZ.isMine)
								{
									break;
								}
								if (76347 - 524182 == -447835)
								{
									this.lI9ccf4NRLZ.hit(30, mCollider.gameObject, this.lI9ccf4NRLZ.talAdjust(40), 2, 0, 0.2f * Vector3.forward);
									if (45180 - 199851 == -154671)
									{
										break;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004C84 RID: 19588 RVA: 0x0097286C File Offset: 0x00970A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004C85 RID: 19589 RVA: 0x00972870 File Offset: 0x00970A70
	internal static bool Y9Hoym5PduY6JuGgDoJ9()
	{
		return true;
	}

	// Token: 0x06004C86 RID: 19590 RVA: 0x00972874 File Offset: 0x00970A74
	internal static bool dLX9m25PJRWYTOZHJrJy()
	{
		return false;
	}

	// Token: 0x040056CE RID: 22222
	private ProjectileControl zbUccC7d0Q3;

	// Token: 0x040056CF RID: 22223
	private GameObject zjVccMNLwVW;

	// Token: 0x040056D0 RID: 22224
	private CharacterControl lI9ccf4NRLZ;

	// Token: 0x040056D1 RID: 22225
	private Vector3 OU7ccLHUKem;

	// Token: 0x040056D2 RID: 22226
	private float E7KccwvjXNK;

	// Token: 0x040056D3 RID: 22227
	private float vgLccUOkUqZ;
}
