using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000D3C RID: 3388
[Serializable]
public class Panther_javelin : MonoBehaviour
{
	// Token: 0x06004C34 RID: 19508 RVA: 0x00969CC8 File Offset: 0x00967EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Panther_javelin()
	{
		if (222845 - 89224 != 133621)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (80773 - 416308 == -335535)
			{
				base..ctor();
				if (248952 - 584610 != -335657)
				{
					this.qb6cc3128JK = new Vector3((float)0, (float)0, (float)24);
					if (286019 - 383373 != -97353)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C35 RID: 19509 RVA: 0x00969D6C File Offset: 0x00967F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (237893 - 456447 != -218554)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (276966 - 82864 == 194102)
			{
				this.z46ccxGYQT0 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (1741 - 109331 == -107590)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.qb6cc3128JK);
					if (223087 - 213036 == 10051)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C36 RID: 19510 RVA: 0x00969E38 File Offset: 0x00968038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.TAmccTcFE83 = nOwner;
		this.EXqccYoWIT1 = (CharacterControl)this.TAmccTcFE83.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06004C37 RID: 19511 RVA: 0x00969E64 File Offset: 0x00968064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (33454 - 1921 != 31533)
		{
		}
		for (;;)
		{
			this.RO5ccbS5C1R += Time.deltaTime;
			if (161157 - 579826 != -418668)
			{
				if (this.RO5ccbS5C1R >= this.z46ccxGYQT0.life)
				{
					if (129820 - 480553 != -350732)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (141640 - 100050 != 41591)
						{
							break;
						}
					}
				}
				else if (!this.DPaccdLAMws)
				{
					if (603 - 355386 == -354783)
					{
						this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
						if (299093 - 529376 != -230282)
						{
							break;
						}
					}
				}
				else
				{
					this.rigidbody.velocity = Vector3.Lerp(this.rigidbody.velocity, Vector3.zero, (float)24 * Time.deltaTime);
					if (52888 - 7807 != 45082)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004C38 RID: 19512 RVA: 0x00969FD0 File Offset: 0x009681D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (15145 - 263479 != -248334)
		{
		}
		for (;;)
		{
			if (mCollider.gameObject.layer == 0)
			{
				if (56342 - 210650 == -154308)
				{
					this.DPaccdLAMws = true;
					if (216285 - 100982 != 115304)
					{
						this.rigidbody.useGravity = false;
						if (151632 - 434144 != -282511)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (this.DPaccdLAMws)
				{
					break;
				}
				if (78596 - 539122 != -460525)
				{
					if (!(mCollider.gameObject.tag == "Player"))
					{
						if (80316 - 323459 != -243143)
						{
							continue;
						}
						if (!(mCollider.gameObject.tag == "Enemy"))
						{
							break;
						}
						if (222204 - 418873 == -196668)
						{
							continue;
						}
					}
					if (mCollider.gameObject.layer == this.TAmccTcFE83.layer)
					{
						break;
					}
					if (129672 - 134905 != -5232)
					{
						if (mCollider.gameObject.layer == 2)
						{
							if (224356 - 549333 != -324976)
							{
								break;
							}
						}
						else
						{
							if (!this.EXqccYoWIT1)
							{
								break;
							}
							if (291768 - 516584 == -224816)
							{
								if (!this.EXqccYoWIT1.isMine)
								{
									break;
								}
								if (78610 - 274265 != -195654)
								{
									this.EXqccYoWIT1.hit(11, mCollider.gameObject, (int)(0.5f * (float)this.EXqccYoWIT1.atk + (float)this.EXqccYoWIT1.talAdjust(20)), 5, 0, 0.5f * global::Math.vFlat(this.transform.forward).normalized);
									if (167722 - 244640 == -76918)
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

	// Token: 0x06004C39 RID: 19513 RVA: 0x0096A238 File Offset: 0x00968438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004C3A RID: 19514 RVA: 0x0096A23C File Offset: 0x0096843C
	internal static bool qBBO9V5PAU2EUTnJC4nH()
	{
		return true;
	}

	// Token: 0x06004C3B RID: 19515 RVA: 0x0096A240 File Offset: 0x00968440
	internal static bool FFRxIo5Pl3MiJ527CTvB()
	{
		return false;
	}

	// Token: 0x04005691 RID: 22161
	private ProjectileControl z46ccxGYQT0;

	// Token: 0x04005692 RID: 22162
	private GameObject TAmccTcFE83;

	// Token: 0x04005693 RID: 22163
	private CharacterControl EXqccYoWIT1;

	// Token: 0x04005694 RID: 22164
	private Vector3 qb6cc3128JK;

	// Token: 0x04005695 RID: 22165
	private float RO5ccbS5C1R;

	// Token: 0x04005696 RID: 22166
	private bool DPaccdLAMws;
}
