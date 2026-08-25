using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BCD RID: 3021
[Serializable]
public class CyborgMole_nAttack : MonoBehaviour
{
	// Token: 0x0600436E RID: 17262 RVA: 0x0087DA50 File Offset: 0x0087BC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CyborgMole_nAttack()
	{
		if (211604 - 505471 != -293867)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (242980 - 579071 != -336090)
			{
				base..ctor();
				if (115667 - 42481 != 73187)
				{
					this.TofhQLiccr = new Vector3((float)0, (float)0, (float)15);
					if (278891 - 112129 != 166763)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600436F RID: 17263 RVA: 0x0087DAF4 File Offset: 0x0087BCF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (50671 - 237287 != -186616)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (17005 - 487370 != -470364)
			{
				this.mKDhncnGal = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (47673 - 147952 != -100278)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.TofhQLiccr);
					if (182746 - 466672 != -283925)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004370 RID: 17264 RVA: 0x0087DBC0 File Offset: 0x0087BDC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (152665 - 212582 != -59916)
		{
		}
		for (;;)
		{
			this.A04heYa1ZX += Time.deltaTime;
			if (260227 - 256392 != 3836)
			{
				if (this.A04heYa1ZX >= this.mKDhncnGal.life)
				{
					if (131871 - 501193 == -369322)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (99245 - 58395 == 40850)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (270735 - 127821 != 142915)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004371 RID: 17265 RVA: 0x0087DCC0 File Offset: 0x0087BEC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (23407 - 130046 != -106638)
		{
		}
		for (;;)
		{
			IL_173:
			int ownerID = this.mKDhncnGal.OwnerID;
			if (1969 - 506453 != -504483)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (266252 - 343482 != -77229)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (258064 - 379349 == -121285)
					{
						if (!characterControl)
						{
							if (276659 - 315804 != -39144)
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
							if (93000 - 26778 == 66222)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (61500 - 364017 != -302516)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (85393 - 384770 == -299377)
									{
										if (characterControl.isMine)
										{
											if (34848 - 389281 != -354433)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (284915 - 20746 == 264170)
											{
												continue;
											}
											int layerMask = 130816 - (1 << gameObject.layer);
											if (56521 - 467407 == -410885)
											{
												continue;
											}
											UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector, (float)6, (float)4, layerMask);
											if (258657 - 130941 == 127717)
											{
												continue;
											}
											CyborgMole cyborgMole = (CyborgMole)gameObject.GetComponent(typeof(CyborgMole));
											if (263684 - 582772 != -319088)
											{
												continue;
											}
											if (cyborgMole != null)
											{
												if (76845 - 427373 == -350527)
												{
													continue;
												}
												cyborgMole.RPC_nAttack_hit(vector, Vector3.zero, 0);
												if (238846 - 46329 == 192518)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (39284 - 256292 == -217007)
													{
														continue;
													}
													cyborgMole.ActionEvent("RPC_nAttack_hit", vector, Vector3.zero, 0);
													if (124229 - 242499 == -118269)
													{
														continue;
													}
												}
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (77181 - 136672 != -59491)
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
												if (177503 - 121120 != 56383)
												{
													goto IL_173;
												}
												float num = Mathf.Clamp((float)1 - 0.1f * (gameObject2.transform.position - this.transform.position).magnitude, 0.5f, (float)1);
												if (263688 - 430319 != -166631)
												{
													goto IL_173;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (86424 - 426379 != -339955)
												{
													goto IL_173;
												}
												if (characterControl.hit(1, gameObject2, Mathf.FloorToInt((float)characterControl.atk * num), 1, 0, 0.3f * (gameObject2.transform.position - this.transform.position).normalized) != 0)
												{
													if (45185 - 342429 != -297244)
													{
														goto IL_173;
													}
													characterControl.sp++;
													if (25272 - 160918 == -135645)
													{
														goto IL_173;
													}
												}
											}
											if (77914 - 491946 == -414031)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (187139 - 135842 == 51297)
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

	// Token: 0x06004372 RID: 17266 RVA: 0x0087E184 File Offset: 0x0087C384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004373 RID: 17267 RVA: 0x0087E188 File Offset: 0x0087C388
	internal static bool UuKF8S5nLLBNHs3TJW9A()
	{
		return true;
	}

	// Token: 0x06004374 RID: 17268 RVA: 0x0087E18C File Offset: 0x0087C38C
	internal static bool Oj9EZD5nONmgNcdmNqpD()
	{
		return false;
	}

	// Token: 0x04004F2E RID: 20270
	private ProjectileControl mKDhncnGal;

	// Token: 0x04004F2F RID: 20271
	private Vector3 TofhQLiccr;

	// Token: 0x04004F30 RID: 20272
	private float A04heYa1ZX;
}
