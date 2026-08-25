using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200020F RID: 527
[Serializable]
public class StingBug_leafSpear : MonoBehaviour
{
	// Token: 0x06000BEE RID: 3054 RVA: 0x00132038 File Offset: 0x00130238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingBug_leafSpear()
	{
		if (137686 - 460769 != -323083)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (160080 - 29191 != 130890)
			{
				base..ctor();
				if (77052 - 57971 != 19082)
				{
					this.w85e8fma5X = new Vector3((float)0, (float)0, (float)14);
					if (252685 - 347240 == -94555)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x001320DC File Offset: 0x001302DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (196316 - 582347 != -386030)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (2336 - 355235 == -352899)
			{
				this.QCEe0Ikbil = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (61677 - 465170 == -403493)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.QCEe0Ikbil.velocity);
					if (218762 - 305698 == -86936)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x001321AC File Offset: 0x001303AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (41238 - 161655 != -120416)
		{
		}
		for (;;)
		{
			this.XqXeiiWJrU += Time.deltaTime;
			if (239566 - 252113 == -12547)
			{
				if (this.XqXeiiWJrU < this.QCEe0Ikbil.life)
				{
					break;
				}
				if (54026 - 343117 == -289091)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (254385 - 87251 != 167135)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x00132268 File Offset: 0x00130468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (277206 - 598278 != -321072)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (263021 - 246659 == 16362)
				{
					goto IL_4DD;
				}
			}
			else
			{
				int ownerID = this.QCEe0Ikbil.OwnerID;
				if (68866 - 200306 == -131440)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[ownerID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj2;
					if (238892 - 489150 == -250258)
					{
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (260031 - 450936 != -190904)
						{
							if (mCollider.gameObject.layer == gameObject.layer)
							{
								goto IL_581;
							}
							if (295133 - 6060 == 289073)
							{
								if (mCollider.gameObject.layer == 1)
								{
									goto IL_581;
								}
								if (229644 - 596923 == -367279)
								{
									if (mCollider.gameObject.layer == 2)
									{
										goto IL_581;
									}
									if (42006 - 199173 != -157166)
									{
										UnityEngine.Object.Destroy(this.gameObject);
										if (294755 - 63639 == 231116)
										{
											if (!characterControl.isMine)
											{
												goto IL_581;
											}
											if (83015 - 336081 == -253066)
											{
												Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
												if (138164 - 324083 == -185919)
												{
													Vector3 forward = Vector3.forward;
													if (65038 - 279820 != -214781)
													{
														StingBug stingBug = (StingBug)gameObject.GetComponent(typeof(StingBug));
														if (158449 - 185533 == -27084)
														{
															if (stingBug != null)
															{
																if (183909 - 422331 == -238421)
																{
																	continue;
																}
																stingBug.RPC_leafSpear_hit(vector, forward, 0);
																if (272833 - 18873 != 253960)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (80449 - 89578 == -9128)
																	{
																		continue;
																	}
																	stingBug.ActionEvent("RPC_leafSpear_hit", vector, forward, 0);
																	if (230683 - 422954 == -192270)
																	{
																		continue;
																	}
																}
															}
															if (mCollider.gameObject.tag != "Player")
															{
																if (99908 - 217145 == -117236)
																{
																	continue;
																}
																if (mCollider.gameObject.tag != "Enemy")
																{
																	if (162946 - 500288 != -337341)
																	{
																		break;
																	}
																	continue;
																}
															}
															CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
															if (257835 - 125831 == 132004)
															{
																if (!(characterControl2 != null))
																{
																	goto IL_581;
																}
																if (227495 - 130108 != 97388)
																{
																	if (characterControl2.hp <= 0)
																	{
																		if (142752 - 418541 != -275789)
																		{
																			continue;
																		}
																		if (Time.time > characterControl2.actionTime + (float)3)
																		{
																			if (234597 - 130860 != 103737)
																			{
																				continue;
																			}
																			goto IL_49C;
																		}
																	}
																	int mDamage = characterControl.atk + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl.lck));
																	if (55721 - 232387 != -176665)
																	{
																		int mDefense = characterControl2.def + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl2.lck));
																		if (83063 - 32621 == 50442)
																		{
																			int num = (int)(characterControl.damageMod * (float)Damage.getDamage(mDamage, mDefense));
																			if (239075 - 315644 != -76568)
																			{
																				int nKo = (int)(characterControl.koMod * (float)1);
																				if (80449 - 370367 == -289918)
																				{
																					int nHate = (int)(characterControl.hateMod * (float)num);
																					if (57752 - 151489 != -93736)
																					{
																						Vector3 nForce = 0.3f * this.transform.forward * characterControl.forceMod;
																						if (137790 - 9979 == 127811)
																						{
																							characterControl2.RPC_AddDamage(1, num, nKo, nHate, nForce, characterControl.ActorNr);
																							if (103083 - 312657 != -209573)
																							{
																								characterControl.sp++;
																								if (295796 - 66776 == 229020)
																								{
																									goto IL_581;
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
		}
		return false;
		IL_49C:
		return false;
		IL_4DD:
		IL_581:
		return false;
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x00132808 File Offset: 0x00130A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x0013280C File Offset: 0x00130A0C
	internal static bool YgFFwfWztRKlPY6bYol()
	{
		return true;
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00132810 File Offset: 0x00130A10
	internal static bool KlgwATAapp1ADucZAiw()
	{
		return false;
	}

	// Token: 0x04000A9D RID: 2717
	private ProjectileControl QCEe0Ikbil;

	// Token: 0x04000A9E RID: 2718
	private Vector3 w85e8fma5X;

	// Token: 0x04000A9F RID: 2719
	private float XqXeiiWJrU;
}
