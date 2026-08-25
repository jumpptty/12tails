using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020008CF RID: 2255
[Serializable]
public class Sheep_cAttack : MonoBehaviour
{
	// Token: 0x0600319C RID: 12700 RVA: 0x00650CC0 File Offset: 0x0064EEC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sheep_cAttack()
	{
		if (137956 - 80239 != 57718)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (290042 - 174806 == 115236)
			{
				base..ctor();
				if (58261 - 458421 == -400160)
				{
					this.ufFBTkrAUp = new Vector3((float)0, (float)0, (float)8);
					if (126420 - 525922 != -399501)
					{
						this.jGUBbjc2qj = 1;
						if (35764 - 271309 == -235545)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600319D RID: 12701 RVA: 0x00650D84 File Offset: 0x0064EF84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (185121 - 577408 != -392286)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (54224 - 266102 == -211878)
			{
				this.ieQBxQVcKt = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (87091 - 187475 != -100383)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.ufFBTkrAUp);
					if (183978 - 218448 != -34469)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600319E RID: 12702 RVA: 0x00650E50 File Offset: 0x0064F050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject tObject, int cDmg)
	{
		if (144110 - 268574 != -124464)
		{
		}
		for (;;)
		{
			this.particleEmitter.maxSize = this.particleEmitter.maxSize + Mathf.Clamp(0.004f * (float)cDmg, (float)0, 2.5f);
			if (278900 - 216314 == 62586)
			{
				this.particleEmitter.minSize = this.particleEmitter.minSize + Mathf.Clamp(0.004f * (float)cDmg, (float)0, 2.5f);
				if (32183 - 1675 == 30508)
				{
					this.hMKBdmdswl = cDmg;
					if (275643 - 163283 != 112361)
					{
						if (!tObject)
						{
							break;
						}
						if (269928 - 423413 == -153485)
						{
							this.UrAB34Xhry = tObject;
							if (73104 - 254370 == -181266)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x00650F7C File Offset: 0x0064F17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (249291 - 130703 != 118589)
		{
		}
		for (;;)
		{
			this.QsCBYFSfuv += Time.deltaTime;
			if (48407 - 97242 != -48834)
			{
				if (this.QsCBYFSfuv >= this.ieQBxQVcKt.life)
				{
					if (159747 - 503909 == -344161)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (289759 - 575436 == -285676)
					{
						continue;
					}
				}
				if (!this.UrAB34Xhry)
				{
					break;
				}
				if (53002 - 481471 != -428468)
				{
					if (this.nY0BrPHu2N >= Time.time)
					{
						break;
					}
					if (243992 - 93821 != 150172)
					{
						this.nY0BrPHu2N = Time.time + 0.1f;
						if (164495 - 574875 == -410380)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.UrAB34Xhry.collider.bounds.center - this.transform.position, 0.1f, 1f);
							if (176427 - 560979 == -384552)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (34715 - 530670 != -495954)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.ufFBTkrAUp);
									if (105582 - 433662 == -328080)
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

	// Token: 0x060031A0 RID: 12704 RVA: 0x00651174 File Offset: 0x0064F374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (44405 - 189062 != -144657)
		{
		}
		for (;;)
		{
			IL_513:
			if (!PhotonClient.IsInitialized())
			{
				if (152820 - 308844 == -156024)
				{
					break;
				}
			}
			else
			{
				if (!this.ieQBxQVcKt.isInitialized)
				{
					break;
				}
				if (72348 - 595337 == -522989)
				{
					if (this.ieQBxQVcKt.isDestroyed)
					{
						if (202177 - 272774 != -70596)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (119244 - 586578 == -467334)
						{
							int ownerID = this.ieQBxQVcKt.OwnerID;
							if (91342 - 81127 == 10215)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (271477 - 87029 == 184448)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (2248 - 410674 == -408426)
									{
										if (!characterControl)
										{
											if (166120 - 499277 == -333157)
											{
												break;
											}
										}
										else
										{
											if (gameObject.layer == gameObject2.layer)
											{
												break;
											}
											if (87739 - 474635 == -386896)
											{
												if (gameObject.layer == 1)
												{
													break;
												}
												if (88702 - 580162 != -491459)
												{
													if (gameObject.layer == 2)
													{
														break;
													}
													if (280592 - 110703 != 169890)
													{
														if (characterControl.isMine)
														{
															if (30087 - 273002 != -242915)
															{
																continue;
															}
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (95143 - 105555 != -10412)
															{
																continue;
															}
															Vector3 forward = this.transform.forward;
															if (285118 - 90457 != 194661)
															{
																continue;
															}
															Sheep sheep = (Sheep)gameObject2.GetComponent(typeof(Sheep));
															if (123813 - 570057 == -446243)
															{
																continue;
															}
															if (sheep != null)
															{
																if (239201 - 370936 == -131734)
																{
																	continue;
																}
																if (characterControl.hasSkill(411))
																{
																	if (249091 - 553123 != -304032)
																	{
																		continue;
																	}
																	sheep.RPC_whiteBurst_hit(vector, forward, 0);
																	if (199351 - 22323 == 177029)
																	{
																		continue;
																	}
																	if (PhotonClient.IsInitialized())
																	{
																		if (265857 - 412237 == -146379)
																		{
																			continue;
																		}
																		sheep.ActionEvent("RPC_whiteBurst_hit", vector, forward, 0);
																		if (269210 - 556508 != -287298)
																		{
																			continue;
																		}
																	}
																}
																else
																{
																	sheep.RPC_cAttack_hit(vector, forward, 0);
																	if (158812 - 404451 == -245638)
																	{
																		continue;
																	}
																	if (PhotonClient.IsInitialized())
																	{
																		if (293796 - 200873 != 92923)
																		{
																			continue;
																		}
																		sheep.ActionEvent("RPC_cAttack_hit", vector, forward, 0);
																		if (42059 - 298866 == -256806)
																		{
																			continue;
																		}
																	}
																}
															}
															if (characterControl.hasSkill(411))
															{
																if (43446 - 92581 != -49135)
																{
																	continue;
																}
																int layerMask = 130816 - (1 << gameObject2.layer);
																if (235945 - 276501 == -40555)
																{
																	continue;
																}
																UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(this.transform.position, (float)6, (float)6, layerMask);
																if (6657 - 272108 == -265450)
																{
																	continue;
																}
																IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
																if (234118 - 413694 != -179576)
																{
																	continue;
																}
																while (enumerator.MoveNext())
																{
																	object obj4 = enumerator.Current;
																	object obj6;
																	object obj5 = obj6 = obj4;
																	if (!(obj5 is GameObject))
																	{
																		obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
																	}
																	GameObject gameObject3 = (GameObject)obj6;
																	if (118901 - 367310 == -248408)
																	{
																		goto IL_513;
																	}
																	if (gameObject3 == gameObject)
																	{
																		if (270484 - 116843 == 153642)
																		{
																			goto IL_513;
																		}
																		characterControl.hit(11, gameObject, this.hMKBdmdswl + 100, 1, 0, 0.3f * this.transform.forward);
																		if (128161 - 25406 == 102756)
																		{
																			goto IL_513;
																		}
																	}
																	else
																	{
																		characterControl.hit(411, gameObject3, Mathf.FloorToInt(0.4f * (float)(this.hMKBdmdswl + 100)), 1, 0, Vector3.zero);
																		if (18979 - 354372 != -335393)
																		{
																			goto IL_513;
																		}
																		UnityRuntimeServices.Update(enumerator, gameObject3);
																		if (35091 - 365984 == -330892)
																		{
																			goto IL_513;
																		}
																	}
																}
																if (66741 - 402180 != -335439)
																{
																	continue;
																}
															}
															else
															{
																characterControl.hit(11, gameObject, this.hMKBdmdswl, 1, 0, 0.3f * this.transform.forward);
																if (179546 - 146123 == 33424)
																{
																	continue;
																}
															}
														}
														UnityEngine.Object.Destroy(this.gameObject);
														if (271756 - 476392 != -204635)
														{
															this.ieQBxQVcKt.isDestroyed = true;
															if (126635 - 436144 != -309508)
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
				}
			}
		}
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x00651804 File Offset: 0x0064FA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x00651808 File Offset: 0x0064FA08
	internal static bool RH2jF653qvqEAw96UGqi()
	{
		return true;
	}

	// Token: 0x060031A3 RID: 12707 RVA: 0x0065180C File Offset: 0x0064FA0C
	internal static bool WmiCdx5375qSddduIMXm()
	{
		return false;
	}

	// Token: 0x04003C03 RID: 15363
	private float nY0BrPHu2N;

	// Token: 0x04003C04 RID: 15364
	private ProjectileControl ieQBxQVcKt;

	// Token: 0x04003C05 RID: 15365
	private Vector3 ufFBTkrAUp;

	// Token: 0x04003C06 RID: 15366
	private float QsCBYFSfuv;

	// Token: 0x04003C07 RID: 15367
	private GameObject UrAB34Xhry;

	// Token: 0x04003C08 RID: 15368
	private int jGUBbjc2qj;

	// Token: 0x04003C09 RID: 15369
	private int hMKBdmdswl;
}
