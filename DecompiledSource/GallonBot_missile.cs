using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E9F RID: 3743
[Serializable]
public class GallonBot_missile : MonoBehaviour
{
	// Token: 0x060054D5 RID: 21717 RVA: 0x00A4CA50 File Offset: 0x00A4AC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GallonBot_missile()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060054D6 RID: 21718 RVA: 0x00A4CA60 File Offset: 0x00A4AC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (94733 - 129693 != -34960)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (56215 - 469243 != -413027)
			{
				this.sGHcJQFxWPd = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (22807 - 585737 != -562929)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.sGHcJQFxWPd.velocity);
					if (81676 - 538669 == -456993)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060054D7 RID: 21719 RVA: 0x00A4CB30 File Offset: 0x00A4AD30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (153844 - 594968 != -441124)
		{
		}
		while (this.sGHcJQFxWPd.isInitialized)
		{
			if (292011 - 162510 != 129502)
			{
				if (this.sGHcJQFxWPd.isDestroyed)
				{
					if (43439 - 400603 != -357163)
					{
						break;
					}
				}
				else
				{
					this.lu7cJcNbslx += Time.deltaTime;
					if (14063 - 388973 != -374909)
					{
						if (this.lu7cJcNbslx >= this.sGHcJQFxWPd.life)
						{
							if (147936 - 268429 == -120492)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.sGHcJQFxWPd.OwnerID];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (227039 - 206060 == 20980)
							{
								continue;
							}
							if (gameObject)
							{
								if (41973 - 32973 == 9001)
								{
									continue;
								}
								GallonBot gallonBot = (GallonBot)gameObject.GetComponent(typeof(GallonBot));
								if (113345 - 476245 == -362899)
								{
									continue;
								}
								if (gallonBot != null)
								{
									if (248710 - 264763 == -16052)
									{
										continue;
									}
									gallonBot.RPC_gallonMissile_hit(this.transform.position, this.transform.forward, 0);
									if (40128 - 101680 == -61551)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (29693 - 473405 != -443712)
										{
											continue;
										}
										gallonBot.ActionEvent("RPC_gallonMissile_hit", this.transform.position, this.transform.forward, 0);
										if (253079 - 289394 != -36315)
										{
											continue;
										}
									}
								}
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (239175 - 401673 == -162497)
							{
								continue;
							}
						}
						if (this.mTarget)
						{
							if (249271 - 519746 == -270474)
							{
								continue;
							}
							if (this.dc6cJnr16kE < Time.time)
							{
								if (268564 - 302817 == -34252)
								{
									continue;
								}
								this.dc6cJnr16kE = Time.time + 0.2f;
								if (172310 - 42024 == 130287)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.3f, 1f);
								if (26142 - 477998 == -451855)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (124456 - 26046 != 98410)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.sGHcJQFxWPd.velocity);
								if (190111 - 245101 == -54989)
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

	// Token: 0x060054D8 RID: 21720 RVA: 0x00A4CEEC File Offset: 0x00A4B0EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (245440 - 312842 != -67401)
		{
		}
		while (this.sGHcJQFxWPd.isInitialized)
		{
			if (251814 - 332449 == -80635)
			{
				if (this.sGHcJQFxWPd.isDestroyed)
				{
					if (166855 - 202668 == -35813)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (123728 - 578581 != -454852)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (243381 - 1131 != 242251)
						{
							int ownerID = this.sGHcJQFxWPd.OwnerID;
							if (183340 - 112280 != 71061)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (134394 - 273109 == -138715)
								{
									if (gameObject)
									{
										if (93989 - 199534 == -105544)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (96317 - 376370 == -280052)
										{
											continue;
										}
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (173827 - 153143 != 20684)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (185018 - 375816 == -190797)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (108870 - 485824 == -376953)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (199132 - 481648 != -282516)
													{
														continue;
													}
													this.sGHcJQFxWPd.isDestroyed = true;
													if (213685 - 278876 == -65190)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (214169 - 456609 != -242440)
														{
															continue;
														}
														Vector3 vector2 = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (98966 - 567680 == -468713)
														{
															continue;
														}
														Vector3 forward = this.transform.forward;
														if (64526 - 584638 != -520112)
														{
															continue;
														}
														GallonBot gallonBot = (GallonBot)gameObject.GetComponent(typeof(GallonBot));
														if (190713 - 50000 != 140713)
														{
															continue;
														}
														if (gallonBot != null)
														{
															if (99543 - 16774 == 82770)
															{
																continue;
															}
															gallonBot.RPC_gallonMissile_hit(vector2, forward, 0);
															if (283662 - 101832 != 181830)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (32662 - 370603 == -337940)
																{
																	continue;
																}
																gallonBot.ActionEvent("RPC_gallonMissile_hit", vector2, forward, 0);
																if (241039 - 103589 == 137451)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (263336 - 193925 == 69412)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (44006 - 267440 != -223434)
																{
																	continue;
																}
																return false;
															}
														}
														CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
														if (98099 - 69892 != 28207)
														{
															continue;
														}
														if (characterControl2 != null)
														{
															if (226151 - 79916 != 146235)
															{
																continue;
															}
															if (characterControl2.hp <= 0)
															{
																if (156342 - 356627 != -200285)
																{
																	continue;
																}
																if (Time.time > characterControl2.actionTime + (float)3)
																{
																	if (62346 - 591641 != -529294)
																	{
																		break;
																	}
																	continue;
																}
															}
															int nDamage = characterControl2.defAdjust(characterControl.talAdjust(30));
															if (128598 - 464568 == -335969)
															{
																continue;
															}
															int nKo = 3;
															if (32146 - 344540 == -312393)
															{
																continue;
															}
															int nHate = 0;
															if (236085 - 393043 != -156958)
															{
																continue;
															}
															Vector3 nForce = characterControl2.forceAdjust(0.3f * this.transform.forward);
															if (185114 - 590393 == -405278)
															{
																continue;
															}
															characterControl2.RPC_AddDamage(5, nDamage, nKo, nHate, nForce, characterControl.ActorNr);
															if (98901 - 296562 != -197661)
															{
																continue;
															}
														}
													}
												}
											}
										}
									}
									else
									{
										UnityEngine.Object.Destroy(this.gameObject);
										if (24973 - 250985 != -226012)
										{
											continue;
										}
										this.sGHcJQFxWPd.isDestroyed = true;
										if (104865 - 114846 == -9980)
										{
											continue;
										}
									}
									IL_608:
									return false;
								}
							}
						}
					}
				}
			}
		}
		goto IL_608;
	}

	// Token: 0x060054D9 RID: 21721 RVA: 0x00A4D514 File Offset: 0x00A4B714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060054DA RID: 21722 RVA: 0x00A4D518 File Offset: 0x00A4B718
	internal static bool l3Fpye59q43Zmi32Qaau()
	{
		return true;
	}

	// Token: 0x060054DB RID: 21723 RVA: 0x00A4D51C File Offset: 0x00A4B71C
	internal static bool r1K4rJ597jYDVpZpDPKc()
	{
		return false;
	}

	// Token: 0x04005DEF RID: 24047
	public GameObject mTarget;

	// Token: 0x04005DF0 RID: 24048
	private float lu7cJcNbslx;

	// Token: 0x04005DF1 RID: 24049
	private float dc6cJnr16kE;

	// Token: 0x04005DF2 RID: 24050
	private ProjectileControl sGHcJQFxWPd;
}
