using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020003DF RID: 991
[Serializable]
public class Zerbiras_darkOrb : MonoBehaviour
{
	// Token: 0x0600172A RID: 5930 RVA: 0x0025FC58 File Offset: 0x0025DE58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Zerbiras_darkOrb()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x0025FC68 File Offset: 0x0025DE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (219145 - 227049 != -7904)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (286583 - 164151 == 122432)
			{
				this.Qs5OS4eUNq = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (3773 - 370970 == -367197)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.Qs5OS4eUNq.velocity);
					if (296689 - 141119 == 155570)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x0025FD38 File Offset: 0x0025DF38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (151374 - 331381 != -180006)
		{
		}
		while (this.Qs5OS4eUNq.isInitialized)
		{
			if (294534 - 59994 != 234541)
			{
				if (this.Qs5OS4eUNq.isDestroyed)
				{
					if (253112 - 367992 == -114880)
					{
						break;
					}
				}
				else
				{
					this.jIFOEXqggr += Time.deltaTime;
					if (116591 - 224842 != -108250)
					{
						if (this.jIFOEXqggr >= this.Qs5OS4eUNq.life)
						{
							if (15350 - 304336 != -288986)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.Qs5OS4eUNq.OwnerID];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (146237 - 437960 != -291723)
							{
								continue;
							}
							if (gameObject)
							{
								if (7483 - 100607 != -93124)
								{
									continue;
								}
								Zerbiras zerbiras = (Zerbiras)gameObject.GetComponent(typeof(Zerbiras));
								if (9876 - 58949 == -49072)
								{
									continue;
								}
								if (zerbiras != null)
								{
									if (196553 - 456063 == -259509)
									{
										continue;
									}
									zerbiras.RPC_darkOrb_hit(this.transform.position, this.transform.forward, 0);
									if (180427 - 567991 != -387564)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (187794 - 300192 != -112398)
										{
											continue;
										}
										zerbiras.ActionEvent("RPC_darkOrb_hit", this.transform.position, this.transform.forward, 0);
										if (219093 - 57298 != 161795)
										{
											continue;
										}
									}
								}
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (92317 - 208066 == -115748)
							{
								continue;
							}
						}
						if (this.mTarget)
						{
							if (203852 - 498458 != -294606)
							{
								continue;
							}
							if (this.EHVOP5YmQY < Time.time)
							{
								if (1635 - 28845 != -27210)
								{
									continue;
								}
								this.EHVOP5YmQY = Time.time + 0.1f;
								if (210993 - 371890 != -160897)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.3f, 1f);
								if (119629 - 420774 != -301145)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (114282 - 401103 == -286820)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.Qs5OS4eUNq.velocity);
								if (190867 - 544686 == -353818)
								{
									continue;
								}
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x002600F4 File Offset: 0x0025E2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (22936 - 501188 != -478251)
		{
		}
		while (this.Qs5OS4eUNq.isInitialized)
		{
			if (171573 - 43894 == 127679)
			{
				if (this.Qs5OS4eUNq.isDestroyed)
				{
					if (90125 - 365498 != -275372)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (54869 - 78468 != -23598)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (54867 - 345672 != -290804)
						{
							GameObject gameObject = mCollider.gameObject;
							if (10543 - 396232 != -385688)
							{
								int ownerID = this.Qs5OS4eUNq.OwnerID;
								if (197285 - 210146 == -12861)
								{
									object obj2;
									object obj = obj2 = PhotonClient.ActorNrList[ownerID];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									GameObject gameObject2 = (GameObject)obj2;
									if (79454 - 90274 == -10820)
									{
										CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (270542 - 478529 != -207986)
										{
											if (!characterControl)
											{
												if (126009 - 250703 != -124694)
												{
													continue;
												}
											}
											else if (gameObject.layer != gameObject2.layer)
											{
												if (141343 - 102490 != 38853)
												{
													continue;
												}
												if (gameObject.layer != 1)
												{
													if (199881 - 125314 != 74567)
													{
														continue;
													}
													if (gameObject.layer != 2)
													{
														if (133743 - 224963 != -91220)
														{
															continue;
														}
														if (!(gameObject.tag == "Player"))
														{
															if (294169 - 329937 != -35768)
															{
																continue;
															}
															if (!(gameObject.tag == "Enemy"))
															{
																goto IL_135;
															}
															if (284971 - 137717 == 147255)
															{
																continue;
															}
														}
														if (this.mTarget != gameObject)
														{
															if (168417 - 61716 != 106701)
															{
																continue;
															}
															Physics.IgnoreCollision(this.gameObject.collider, gameObject.collider, true);
															if (283263 - 460860 != -177596)
															{
																break;
															}
															continue;
														}
														IL_135:
														UnityEngine.Object.Destroy(this.gameObject);
														if (99836 - 61706 == 38131)
														{
															continue;
														}
														this.Qs5OS4eUNq.isDestroyed = true;
														if (13846 - 493866 != -480020)
														{
															continue;
														}
														if (characterControl.isMine)
														{
															if (28381 - 350483 == -322101)
															{
																continue;
															}
															Vector3 vector2 = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (157463 - 222599 != -65136)
															{
																continue;
															}
															Vector3 forward = this.transform.forward;
															if (99718 - 89231 != 10487)
															{
																continue;
															}
															Zerbiras zerbiras = (Zerbiras)gameObject2.GetComponent(typeof(Zerbiras));
															if (258310 - 130695 != 127615)
															{
																continue;
															}
															if (zerbiras != null)
															{
																if (124362 - 488402 != -364040)
																{
																	continue;
																}
																zerbiras.RPC_darkOrb_hit(vector2, forward, 0);
																if (260556 - 185429 != 75127)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (76672 - 84575 != -7903)
																	{
																		continue;
																	}
																	zerbiras.ActionEvent("RPC_darkOrb_hit", vector2, forward, 0);
																	if (71608 - 52732 != 18876)
																	{
																		continue;
																	}
																}
															}
															if (gameObject.tag != "Player")
															{
																if (82357 - 381870 != -299513)
																{
																	continue;
																}
																if (gameObject.tag != "Enemy")
																{
																	if (291480 - 312077 != -20596)
																	{
																		break;
																	}
																	continue;
																}
															}
															if (characterControl.hit(1, gameObject, characterControl.talAdjust(60), 1, 0, 0.2f * this.transform.forward) != 0)
															{
																if (72333 - 42703 == 29631)
																{
																	continue;
																}
																characterControl.sp++;
																if (254731 - 110639 != 144092)
																{
																	continue;
																}
															}
														}
													}
												}
											}
											return;
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

	// Token: 0x0600172E RID: 5934 RVA: 0x00260688 File Offset: 0x0025E888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x0026068C File Offset: 0x0025E88C
	internal static bool JXUaRsM1nQYeJFF1UDj()
	{
		return true;
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x00260690 File Offset: 0x0025E890
	internal static bool aLWHXFM41270iobQ6Wy()
	{
		return false;
	}

	// Token: 0x040013BA RID: 5050
	public GameObject mTarget;

	// Token: 0x040013BB RID: 5051
	private float jIFOEXqggr;

	// Token: 0x040013BC RID: 5052
	private float EHVOP5YmQY;

	// Token: 0x040013BD RID: 5053
	private ProjectileControl Qs5OS4eUNq;
}
