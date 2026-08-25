using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020006D9 RID: 1753
[Serializable]
public class Monkey_fireBall : MonoBehaviour
{
	// Token: 0x06002745 RID: 10053 RVA: 0x004B6904 File Offset: 0x004B4B04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monkey_fireBall()
	{
		if (100496 - 272612 != -172115)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (53084 - 274771 == -221687)
			{
				base..ctor();
				if (16991 - 151556 == -134565)
				{
					this.iWBslN08ac = new Vector3((float)0, (float)0, (float)30);
					if (21162 - 532337 == -511175)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x004B69A8 File Offset: 0x004B4BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (260532 - 351029 != -90496)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (223089 - 562539 != -339449)
			{
				this.a5QsvXMoZ5 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (178717 - 495303 != -316585)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.iWBslN08ac);
					if (220595 - 93919 != 126677)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x004B6A74 File Offset: 0x004B4C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (293532 - 405371 != -111839)
		{
		}
		for (;;)
		{
			this.FbrsGYQ7an += Time.deltaTime;
			if (98572 - 280433 == -181861)
			{
				if (this.FbrsGYQ7an < this.a5QsvXMoZ5.life)
				{
					break;
				}
				if (113023 - 523879 != -410855)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (145567 - 335506 == -189939)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x004B6B30 File Offset: 0x004B4D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (143124 - 370575 != -227451)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (128725 - 17894 != 110832)
				{
					break;
				}
			}
			else
			{
				if (!this.a5QsvXMoZ5.isInitialized)
				{
					break;
				}
				if (119858 - 473191 != -353332)
				{
					if (this.a5QsvXMoZ5.isDestroyed)
					{
						if (143707 - 78982 == 64725)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (249929 - 388234 == -138305)
						{
							int ownerID = this.a5QsvXMoZ5.OwnerID;
							if (190911 - 208759 != -17847)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (179045 - 267379 == -88334)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (199384 - 286611 == -87227)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (263562 - 244128 == 19434)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (174125 - 126137 != 47989)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (61857 - 42339 != 19519)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (60475 - 151721 == -91246)
													{
														this.a5QsvXMoZ5.isDestroyed = true;
														if (194767 - 181544 == 13223)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (85622 - 268800 == -183178)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (273951 - 86104 == 187847)
																{
																	Vector3 forward = this.transform.forward;
																	if (241473 - 24169 == 217304)
																	{
																		Monkey monkey = (Monkey)gameObject2.GetComponent(typeof(Monkey));
																		if (3826 - 432339 == -428513)
																		{
																			if (!(monkey != null))
																			{
																				break;
																			}
																			if (252965 - 473678 == -220713)
																			{
																				monkey.RPC_fireBall_hit(vector, forward, 0);
																				if (125698 - 200419 == -74721)
																				{
																					if (PhotonClient.IsInitialized())
																					{
																						if (263391 - 338487 == -75095)
																						{
																							continue;
																						}
																						monkey.ActionEvent("RPC_fireBall_hit", vector, forward, 0);
																						if (22710 - 534741 != -512031)
																						{
																							continue;
																						}
																					}
																					int nDamage = characterControl.talAdjust(this.mLv * 20 + 20 + ((!characterControl.hasSkill(402)) ? 0 : 20));
																					if (269950 - 593819 != -323868)
																					{
																						int num = monkey.getIntenseFireLv();
																						if (23631 - 111308 != -87676)
																						{
																							if (characterControl.hasSkill(432))
																							{
																								if (184619 - 513342 == -328722)
																								{
																									continue;
																								}
																								num = 5;
																								if (232200 - 31258 == 200943)
																								{
																									continue;
																								}
																							}
																							if (gameObject.tag != "Player")
																							{
																								if (75527 - 377643 != -302116)
																								{
																									continue;
																								}
																								if (gameObject.tag != "Enemy")
																								{
																									if (182661 - 152425 != 30237)
																									{
																										goto Block_40;
																									}
																									continue;
																								}
																							}
																							if (characterControl.hit(200 + this.mLv, gameObject, nDamage, 1, 0, 0.3f * this.transform.forward) == 0)
																							{
																								break;
																							}
																							if (264954 - 301675 == -36721)
																							{
																								if (num > 0)
																								{
																									if (261271 - 593174 != -331903)
																									{
																										continue;
																									}
																									CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																									if (92789 - 29680 != 63109)
																									{
																										continue;
																									}
																									int debuff = Damage.getDebuff((float)4, characterControl.cha, characterControl2.cha);
																									if (14817 - 120195 == -105377)
																									{
																										continue;
																									}
																									characterControl2.RPC_AddStatus("burn", num, debuff, 0, characterControl.ActorNr);
																									if (153692 - 394718 == -241025)
																									{
																										continue;
																									}
																								}
																								monkey.FireRune();
																								if (258903 - 251727 == 7176)
																								{
																									characterControl.sp++;
																									if (156121 - 99268 == 56853)
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
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_5D5;
		Block_40:
		return false;
		IL_5D5:
		return false;
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x004B7124 File Offset: 0x004B5324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x004B7128 File Offset: 0x004B5328
	internal static bool VlsRBVhgWv2b2oCEyPb()
	{
		return true;
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x004B712C File Offset: 0x004B532C
	internal static bool uH6LCkhfCWIWknN94wg()
	{
		return false;
	}

	// Token: 0x04002BE2 RID: 11234
	private ProjectileControl a5QsvXMoZ5;

	// Token: 0x04002BE3 RID: 11235
	private Vector3 iWBslN08ac;

	// Token: 0x04002BE4 RID: 11236
	private float FbrsGYQ7an;

	// Token: 0x04002BE5 RID: 11237
	public int mLv;
}
