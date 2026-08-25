using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A22 RID: 2594
[Serializable]
public class PvpMount_mole_nAttack : MonoBehaviour
{
	// Token: 0x06003899 RID: 14489 RVA: 0x00774298 File Offset: 0x00772498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PvpMount_mole_nAttack()
	{
		if (111215 - 221404 != -110188)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (264588 - 309911 == -45323)
			{
				base..ctor();
				if (259102 - 294356 != -35253)
				{
					this.xUU9tDjKqg = new Vector3((float)0, (float)0, (float)15);
					if (118077 - 281137 != -163059)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600389A RID: 14490 RVA: 0x0077433C File Offset: 0x0077253C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (70436 - 561932 != -491495)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (153143 - 241256 != -88112)
			{
				this.qNs96Nbk0A = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (267980 - 43413 == 224567)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.xUU9tDjKqg);
					if (272618 - 235392 != 37227)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600389B RID: 14491 RVA: 0x00774408 File Offset: 0x00772608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (19867 - 137096 != -117229)
		{
		}
		for (;;)
		{
			this.a6U9XcOqu4 += Time.deltaTime;
			if (245164 - 228178 != 16987)
			{
				if (this.a6U9XcOqu4 >= this.qNs96Nbk0A.life)
				{
					if (145509 - 27556 == 117953)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (231074 - 529200 == -298126)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (22087 - 379180 == -357093)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600389C RID: 14492 RVA: 0x00774508 File Offset: 0x00772708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (275933 - 378073 != -102139)
		{
		}
		for (;;)
		{
			IL_15D:
			int ownerID = this.qNs96Nbk0A.OwnerID;
			if (161877 - 500607 == -338730)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (147975 - 531766 != -383790)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (2489 - 195487 == -192998)
					{
						if (!characterControl)
						{
							if (33837 - 528094 == -494257)
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
							if (78178 - 377030 == -298852)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (265227 - 44680 == 220547)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (137589 - 22336 != 115254)
									{
										if (characterControl.isMine)
										{
											if (102233 - 236704 != -134471)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (76661 - 598385 == -521723)
											{
												continue;
											}
											float num = (float)1;
											if (237383 - 493812 == -256428)
											{
												continue;
											}
											PvpMount pvpMount = (PvpMount)gameObject.GetComponent(typeof(PvpMount));
											if (123086 - 95085 == 28002)
											{
												continue;
											}
											if (pvpMount != null)
											{
												if (272597 - 459843 == -187245)
												{
													continue;
												}
												pvpMount.RPC_nAttack_mole_hit(vector, Vector3.zero, 0);
												if (22137 - 47575 == -25437)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (67562 - 126369 == -58806)
													{
														continue;
													}
													pvpMount.ActionEvent("RPC_nAttack_mole_hit", vector, Vector3.zero, 0);
													if (58755 - 116592 == -57836)
													{
														continue;
													}
												}
											}
											ChampionMount championMount = (ChampionMount)gameObject.GetComponent(typeof(ChampionMount));
											if (291187 - 487980 == -196792)
											{
												continue;
											}
											if (championMount != null)
											{
												if (247229 - 593953 == -346723)
												{
													continue;
												}
												championMount.RPC_nAttack_mole_hit(vector, Vector3.zero, 0);
												if (14986 - 72008 != -57022)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (139373 - 123013 != 16360)
													{
														continue;
													}
													championMount.ActionEvent("RPC_nAttack_mole_hit", vector, Vector3.zero, 0);
													if (215629 - 443187 != -227558)
													{
														continue;
													}
												}
											}
											int layerMask = 130816 - (1 << gameObject.layer);
											if (158489 - 131532 == 26958)
											{
												continue;
											}
											UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector, (float)4, (float)4, layerMask);
											if (107106 - 109581 == -2474)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (255982 - 409004 != -153022)
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
												if (185482 - 463526 != -278044)
												{
													goto IL_15D;
												}
												if (characterControl.hit(1, gameObject2, characterControl.atk, 1, 0, 0.3f * (gameObject2.transform.position - this.transform.position).normalized) != 0)
												{
													if (121380 - 458181 == -336800)
													{
														goto IL_15D;
													}
													characterControl.sp++;
													if (287417 - 31693 == 255725)
													{
														goto IL_15D;
													}
												}
											}
											if (21616 - 594085 == -572468)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (288261 - 272683 == 15578)
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

	// Token: 0x0600389D RID: 14493 RVA: 0x00774A38 File Offset: 0x00772C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600389E RID: 14494 RVA: 0x00774A3C File Offset: 0x00772C3C
	internal static bool poC39y5oDPNfD8U64mjt()
	{
		return true;
	}

	// Token: 0x0600389F RID: 14495 RVA: 0x00774A40 File Offset: 0x00772C40
	internal static bool FbRoot5ovn87W7ohsUJX()
	{
		return false;
	}

	// Token: 0x04004750 RID: 18256
	private ProjectileControl qNs96Nbk0A;

	// Token: 0x04004751 RID: 18257
	private Vector3 xUU9tDjKqg;

	// Token: 0x04004752 RID: 18258
	private float a6U9XcOqu4;
}
