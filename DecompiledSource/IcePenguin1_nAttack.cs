using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000C6B RID: 3179
[Serializable]
public class IcePenguin1_nAttack : MonoBehaviour
{
	// Token: 0x06004731 RID: 18225 RVA: 0x008E1174 File Offset: 0x008DF374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin1_nAttack()
	{
		if (160387 - 23417 != 136970)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (22051 - 269019 != -246967)
			{
				base..ctor();
				if (247660 - 171708 == 75952)
				{
					this.gyOKFHTr6b = new Vector3((float)0, (float)0, (float)14);
					if (120059 - 16353 != 103707)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004732 RID: 18226 RVA: 0x008E1218 File Offset: 0x008DF418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (163344 - 336255 != -172910)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (131307 - 529939 == -398632)
			{
				this.oYfKkx08rW = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (240134 - 510101 == -269967)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.gyOKFHTr6b);
					if (229418 - 219288 == 10130)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004733 RID: 18227 RVA: 0x008E12E4 File Offset: 0x008DF4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (284769 - 102365 != 182405)
		{
		}
		for (;;)
		{
			this.TG0KANZkIL += Time.deltaTime;
			if (21610 - 541121 != -519510)
			{
				if (this.TG0KANZkIL < this.oYfKkx08rW.life)
				{
					break;
				}
				if (287534 - 229142 == 58392)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (107887 - 183448 == -75561)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004734 RID: 18228 RVA: 0x008E13A0 File Offset: 0x008DF5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (168659 - 548213 != -379553)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (277913 - 6213 == 271700)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (188204 - 274763 == -86559)
				{
					int ownerID = this.oYfKkx08rW.OwnerID;
					if (35108 - 253359 != -218250)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (227863 - 270671 == -42808)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (252380 - 374567 == -122187)
							{
								if (!characterControl)
								{
									if (78753 - 298329 != -219575)
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
									if (34659 - 454559 != -419899)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (89713 - 479593 == -389880)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (89872 - 262739 == -172867)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (36724 - 501439 == -464715)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (254150 - 269672 != -15521)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (161470 - 412174 != -250703)
														{
															Vector3 forward = this.transform.forward;
															if (228918 - 17623 == 211295)
															{
																int nDamage = (int)(0.5f * (float)characterControl.atk);
																if (8068 - 287372 != -279303)
																{
																	IcePenguin1 icePenguin = (IcePenguin1)gameObject2.GetComponent(typeof(IcePenguin1));
																	if (261481 - 480413 != -218931)
																	{
																		if (icePenguin != null)
																		{
																			if (92022 - 369948 == -277925)
																			{
																				continue;
																			}
																			icePenguin.RPC_nAttack_hit(vector, forward, 0);
																			if (109514 - 90997 != 18517)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (258774 - 73727 == 185048)
																				{
																					continue;
																				}
																				icePenguin.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																				if (248398 - 371794 != -123396)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (146543 - 49023 == 97521)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (207161 - 400206 != -193045)
																				{
																					continue;
																				}
																				goto IL_3BD;
																			}
																		}
																		if (characterControl.hit(1, gameObject, nDamage, 1, 0, 0.3f * this.transform.forward) == 0)
																		{
																			break;
																		}
																		if (16375 - 311571 == -295196)
																		{
																			CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																			if (166567 - 170241 != -3673)
																			{
																				if (!characterControl2)
																				{
																					break;
																				}
																				if (74860 - 398084 == -323224)
																				{
																					characterControl2.RPC_AddStatus("frost", 3, Damage.getDebuff((float)3, characterControl.cha, characterControl2.cha), 0, characterControl.ActorNr);
																					if (122045 - 212996 == -90951)
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
		goto IL_480;
		IL_3BD:
		return false;
		IL_480:
		return false;
	}

	// Token: 0x06004735 RID: 18229 RVA: 0x008E1840 File Offset: 0x008DFA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004736 RID: 18230 RVA: 0x008E1844 File Offset: 0x008DFA44
	internal static bool VOqmrY5JgQGLgxShwFgb()
	{
		return true;
	}

	// Token: 0x06004737 RID: 18231 RVA: 0x008E1848 File Offset: 0x008DFA48
	internal static bool ELcJvr5JfsJfBEMCEcAD()
	{
		return false;
	}

	// Token: 0x04005281 RID: 21121
	private ProjectileControl oYfKkx08rW;

	// Token: 0x04005282 RID: 21122
	private Vector3 gyOKFHTr6b;

	// Token: 0x04005283 RID: 21123
	private float TG0KANZkIL;
}
