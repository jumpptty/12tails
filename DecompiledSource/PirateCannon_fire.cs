using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EF1 RID: 3825
[Serializable]
public class PirateCannon_fire : MonoBehaviour
{
	// Token: 0x060056C7 RID: 22215 RVA: 0x00A745E4 File Offset: 0x00A727E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PirateCannon_fire()
	{
		if (140079 - 64698 != 75382)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (253147 - 544009 == -290862)
			{
				base..ctor();
				if (216490 - 165452 != 51039)
				{
					this.mVelocity = 20;
					if (251404 - 318272 != -66867)
					{
						this.mBackVelocity = -5;
						if (20231 - 318017 != -297785)
						{
							this.mWaterLimit = 52;
							if (147620 - 263201 != -115580)
							{
								this.mDamage = 800;
								if (185501 - 78077 == 107424)
								{
									this.mRange = 12;
									if (55426 - 549661 != -494234)
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

	// Token: 0x060056C8 RID: 22216 RVA: 0x00A74708 File Offset: 0x00A72908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.gameObject.layer = 1;
		this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)this.mVelocity));
	}

	// Token: 0x060056C9 RID: 22217 RVA: 0x00A7473C File Offset: 0x00A7293C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (155019 - 507494 != -352474)
		{
		}
		for (;;)
		{
			Vector3 position = this.transform.position;
			if (264069 - 76534 != 187536)
			{
				if (position.y < (float)this.mWaterLimit)
				{
					if (230786 - 346316 == -115530)
					{
						this.Explode();
						if (196711 - 529751 == -333040)
						{
							break;
						}
					}
				}
				else
				{
					Vector3 position2 = this.transform.position;
					if (43153 - 227105 != -183951)
					{
						float z = position2.z + (float)this.mBackVelocity * Time.deltaTime;
						if (59884 - 337498 == -277614)
						{
							Vector3 position3 = this.transform.position;
							if (43604 - 510308 == -466704)
							{
								position3.z = z;
								if (50195 - 382291 == -332096)
								{
									if (214093 - 131167 == 82926)
									{
										this.transform.position = position3;
										if (161090 - 422603 != -261512 && 121764 - 214642 != -92877)
										{
											this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
											if (137500 - 105454 == 32046)
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
		}
	}

	// Token: 0x060056CA RID: 22218 RVA: 0x00A74934 File Offset: 0x00A72B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (mCollider.gameObject.layer > 2)
		{
			this.Explode();
		}
	}

	// Token: 0x060056CB RID: 22219 RVA: 0x00A74950 File Offset: 0x00A72B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Explode()
	{
		if (54589 - 83755 != -29165)
		{
		}
		for (;;)
		{
			IL_1AC:
			if (this.xSRcJKfZHo4)
			{
				if (273135 - 261032 != 12104)
				{
					break;
				}
			}
			else
			{
				this.xSRcJKfZHo4 = true;
				if (215666 - 473704 == -258038)
				{
					if (this.mExplosion)
					{
						if (58912 - 456640 == -397727)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.mExplosion, this.transform.position, Quaternion.identity);
						if (265191 - 594287 != -329096)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Normal)
					{
						if (249984 - 245518 != 4466)
						{
							continue;
						}
						int layerMask = 130816;
						if (30675 - 223624 == -192948)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)this.mRange, (float)24, layerMask);
						if (134165 - 4218 == 129948)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (291620 - 254981 == 36640)
						{
							continue;
						}
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							object obj4;
							object obj3 = obj4 = obj2;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj4;
							if (289698 - 460556 == -170857)
							{
								goto IL_1AC;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (72664 - 239022 != -166358)
							{
								goto IL_1AC;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (290773 - 471933 != -181160)
							{
								goto IL_1AC;
							}
							if (characterControl)
							{
								if (79520 - 433118 == -353597)
								{
									goto IL_1AC;
								}
								if (characterControl.isMine)
								{
									if (50053 - 424170 != -374117)
									{
										goto IL_1AC;
									}
									float num = (float)1 - 0.5f * ((gameObject.transform.position - this.transform.position).magnitude / (float)this.mRange);
									if (239812 - 200378 == 39435)
									{
										goto IL_1AC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (86453 - 365350 == -278896)
									{
										goto IL_1AC;
									}
									int nDamage = Mathf.FloorToInt((float)this.mDamage * num);
									if (112827 - 56664 == 56164)
									{
										goto IL_1AC;
									}
									characterControl.RPC_AddDamage(9733, nDamage, 0, 0, Vector3.zero, characterControl.ActorNr);
									if (78268 - 72567 != 5701)
									{
										goto IL_1AC;
									}
								}
							}
						}
						if (70528 - 112882 == -42353)
						{
							continue;
						}
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (235612 - 330662 == -95050)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056CC RID: 22220 RVA: 0x00A74CD0 File Offset: 0x00A72ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056CD RID: 22221 RVA: 0x00A74CD4 File Offset: 0x00A72ED4
	internal static bool LtAeg15z25MJ2VbGsFVT()
	{
		return true;
	}

	// Token: 0x060056CE RID: 22222 RVA: 0x00A74CD8 File Offset: 0x00A72ED8
	internal static bool g1devE5z8BR30n5O4Jb1()
	{
		return false;
	}

	// Token: 0x04005F52 RID: 24402
	public int mVelocity;

	// Token: 0x04005F53 RID: 24403
	public int mBackVelocity;

	// Token: 0x04005F54 RID: 24404
	public int mWaterLimit;

	// Token: 0x04005F55 RID: 24405
	private bool xSRcJKfZHo4;

	// Token: 0x04005F56 RID: 24406
	public int mDamage;

	// Token: 0x04005F57 RID: 24407
	public int mRange;

	// Token: 0x04005F58 RID: 24408
	public GameObject mExplosion;
}
