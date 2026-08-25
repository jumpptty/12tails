using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000654 RID: 1620
[Serializable]
public class Mole_stunGrenade : MonoBehaviour
{
	// Token: 0x0600247E RID: 9342 RVA: 0x0044A810 File Offset: 0x00448A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_stunGrenade()
	{
		if (270674 - 53991 != 216684)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (214044 - 366287 == -152243)
			{
				base..ctor();
				if (136335 - 575344 == -439009)
				{
					this.peMdX6JQWV = new Vector3((float)0, (float)0, (float)15);
					if (61552 - 584242 != -522689)
					{
						this.mLv = 1;
						if (240298 - 477522 == -237224)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600247F RID: 9343 RVA: 0x0044A8D4 File Offset: 0x00448AD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (154698 - 62311 != 92387)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (130419 - 582089 != -451669)
			{
				this.IOPdtrtHHK = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (74865 - 5503 != 69363)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.peMdX6JQWV);
					if (32088 - 114878 != -82789)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002480 RID: 9344 RVA: 0x0044A9A0 File Offset: 0x00448BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (225236 - 387588 != -162351)
		{
		}
		for (;;)
		{
			this.y8qdOE8jas += Time.deltaTime;
			if (34802 - 153446 == -118644)
			{
				if (this.y8qdOE8jas >= this.IOPdtrtHHK.life)
				{
					if (158882 - 33504 != 125379)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (236996 - 562177 == -325181)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (231718 - 549181 == -317463)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002481 RID: 9345 RVA: 0x0044AAA0 File Offset: 0x00448CA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (6549 - 506181 != -499632)
		{
		}
		for (;;)
		{
			IL_235:
			int ownerID = this.IOPdtrtHHK.OwnerID;
			if (278245 - 220499 == 57746)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (145535 - 556699 != -411163)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (68238 - 454802 != -386563)
					{
						if (!characterControl)
						{
							if (194078 - 168805 != 25274)
							{
								break;
							}
						}
						else
						{
							if (mCollider.gameObject.layer == gameObject.layer)
							{
								break;
							}
							if (224069 - 569182 == -345113)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (201774 - 428999 == -227225)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (1453 - 521526 == -520073)
									{
										if (characterControl.isMine)
										{
											if (222680 - 197798 == 24883)
											{
												continue;
											}
											float num = (float)6;
											if (69167 - 409530 != -340363)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (221158 - 397592 != -176434)
											{
												continue;
											}
											int layerMask = 130816;
											if (181045 - 525431 != -344386)
											{
												continue;
											}
											UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector, num * characterControl.rangeMod, (float)4, layerMask);
											if (211740 - 454467 == -242726)
											{
												continue;
											}
											Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
											if (53943 - 528828 == -474884)
											{
												continue;
											}
											if (!(mole != null))
											{
												break;
											}
											if (246121 - 445129 == -199007)
											{
												continue;
											}
											mole.RPC_nAttack_hit(vector, Vector3.zero, 0);
											if (127051 - 338240 == -211188)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (219475 - 306777 == -87301)
												{
													continue;
												}
												mole.ActionEvent("RPC_nAttack_hit", vector, Vector3.zero, 0);
												if (292927 - 27642 != 265285)
												{
													continue;
												}
											}
											int smartShellLv = mole.getSmartShellLv();
											if (93315 - 35892 != 57423)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (199485 - 553768 == -354282)
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
												GameObject gameObject2 = (GameObject)obj6;
												if (88542 - 118512 == -29969)
												{
													goto IL_235;
												}
												if (smartShellLv > 0)
												{
													if (298603 - 464093 != -165490)
													{
														goto IL_235;
													}
													if (gameObject2.layer == gameObject.layer)
													{
														if (138889 - 595327 == -456437)
														{
															goto IL_235;
														}
														characterControl.hit(242 + this.mLv, gameObject2, 0, 5 * this.mLv, 0, Vector3.zero);
														if (219635 - 551413 == -331777)
														{
															goto IL_235;
														}
														UnityRuntimeServices.Update(enumerator, gameObject2);
														if (190224 - 284847 == -94622)
														{
															goto IL_235;
														}
													}
													else
													{
														characterControl.hit(242 + this.mLv, gameObject2, 0, 10 * this.mLv, 0, Vector3.zero);
														if (7008 - 149105 != -142097)
														{
															goto IL_235;
														}
														UnityRuntimeServices.Update(enumerator, gameObject2);
														if (232320 - 62608 == 169713)
														{
															goto IL_235;
														}
														CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
														if (299350 - 455677 != -156327)
														{
															goto IL_235;
														}
														UnityRuntimeServices.Update(enumerator, gameObject2);
														if (55106 - 150812 == -95705)
														{
															goto IL_235;
														}
														if (characterControl2)
														{
															if (203791 - 414407 != -210616)
															{
																goto IL_235;
															}
															characterControl2.RPC_AddEffectDamage(264, 30, 0, 0, Vector3.zero, characterControl.ActorNr);
															if (265920 - 283450 == -17529)
															{
																goto IL_235;
															}
														}
													}
												}
												else
												{
													characterControl.hit(242 + this.mLv, gameObject2, 0, 10 * this.mLv, 0, Vector3.zero);
													if (45359 - 365747 == -320387)
													{
														goto IL_235;
													}
													UnityRuntimeServices.Update(enumerator, gameObject2);
													if (130352 - 557840 == -427487)
													{
														goto IL_235;
													}
												}
											}
											if (105755 - 549962 == -444206)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (135287 - 515680 != -380392)
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

	// Token: 0x06002482 RID: 9346 RVA: 0x0044B0D4 File Offset: 0x004492D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002483 RID: 9347 RVA: 0x0044B0D8 File Offset: 0x004492D8
	internal static bool ntlAUTBHEMxuXyVRuZp()
	{
		return true;
	}

	// Token: 0x06002484 RID: 9348 RVA: 0x0044B0DC File Offset: 0x004492DC
	internal static bool zEdUGGBWMXNnAwv7RRn()
	{
		return false;
	}

	// Token: 0x04002775 RID: 10101
	private ProjectileControl IOPdtrtHHK;

	// Token: 0x04002776 RID: 10102
	private Vector3 peMdX6JQWV;

	// Token: 0x04002777 RID: 10103
	private float y8qdOE8jas;

	// Token: 0x04002778 RID: 10104
	public int mLv;
}
