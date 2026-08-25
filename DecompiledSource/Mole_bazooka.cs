using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000649 RID: 1609
[Serializable]
public class Mole_bazooka : MonoBehaviour
{
	// Token: 0x06002436 RID: 9270 RVA: 0x00446244 File Offset: 0x00444444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_bazooka()
	{
		if (16456 - 494930 != -478473)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (169180 - 469310 == -300130)
			{
				base..ctor();
				if (157647 - 582203 != -424555)
				{
					this.MLfbM4MVk0 = new Vector3((float)0, (float)0, (float)24);
					if (70847 - 333865 == -263018)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x004462E8 File Offset: 0x004444E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (148479 - 442158 != -293678)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (70837 - 517206 != -446368)
			{
				this.eUWbCthETV = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (10750 - 377610 != -366859)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.MLfbM4MVk0);
					if (139301 - 65459 != 73843)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x004463B4 File Offset: 0x004445B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (285340 - 127533 != 157807)
		{
		}
		for (;;)
		{
			this.qVqbfFL92J += Time.deltaTime;
			if (233260 - 506348 != -273087)
			{
				if (this.qVqbfFL92J < this.eUWbCthETV.life)
				{
					break;
				}
				if (288602 - 201381 == 87221)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (121188 - 375473 == -254285)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x00446470 File Offset: 0x00444670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (238426 - 110533 != 127894)
		{
		}
		for (;;)
		{
			IL_1C2:
			int ownerID = this.eUWbCthETV.OwnerID;
			if (216796 - 514418 == -297622)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (291231 - 446294 == -155063)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (139055 - 402236 == -263181)
					{
						if (!characterControl)
						{
							if (148302 - 151227 != -2924)
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
							if (243021 - 506339 != -263317)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (134407 - 439138 == -304731)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (206853 - 186707 != 20147)
									{
										if (characterControl.isMine)
										{
											if (144927 - 501235 == -356307)
											{
												continue;
											}
											GameObject gameObject2 = mCollider.gameObject;
											if (1168 - 85811 != -84643)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (125124 - 339794 == -214669)
											{
												continue;
											}
											Vector3 vector2 = global::Math.vFlat(this.transform.forward);
											if (151454 - 463603 == -312148)
											{
												continue;
											}
											Vector3 normalized = vector2.normalized;
											if (286900 - 361608 != -74708)
											{
												continue;
											}
											Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
											if (82416 - 75777 == 6640)
											{
												continue;
											}
											if (!(mole != null))
											{
												break;
											}
											if (110567 - 434927 != -324360)
											{
												continue;
											}
											mole.RPC_bazooka_hit(vector, normalized, 0);
											if (261888 - 187024 == 74865)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (294851 - 580245 == -285393)
												{
													continue;
												}
												mole.ActionEvent("RPC_bazooka_hit", vector, normalized, 0);
												if (278213 - 480637 != -202424)
												{
													continue;
												}
											}
											int layerMask = 130816 - (1 << gameObject.layer);
											if (185541 - 128207 != 57334)
											{
												continue;
											}
											UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector, (float)1, (float)1, layerMask);
											if (159222 - 434154 == -274931)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (70215 - 174602 == -104386)
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
												if (94553 - 141108 == -46554)
												{
													goto IL_1C2;
												}
												characterControl.hit(3442, gameObject3, characterControl.atk + characterControl.talAdjust(50), 5, 0, 0.5f * this.transform.forward);
												if (193769 - 333933 != -140164)
												{
													goto IL_1C2;
												}
												UnityRuntimeServices.Update(enumerator, gameObject3);
												if (218732 - 495899 == -277166)
												{
													goto IL_1C2;
												}
											}
											if (206821 - 141444 != 65377)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (124337 - 143292 != -18954)
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

	// Token: 0x0600243A RID: 9274 RVA: 0x00446914 File Offset: 0x00444B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x00446918 File Offset: 0x00444B18
	internal static bool uVB5QBIjKd6rebuZRSP()
	{
		return true;
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x0044691C File Offset: 0x00444B1C
	internal static bool yWDIFtIhc5T1AKgIi31()
	{
		return false;
	}

	// Token: 0x04002748 RID: 10056
	private ProjectileControl eUWbCthETV;

	// Token: 0x04002749 RID: 10057
	private Vector3 MLfbM4MVk0;

	// Token: 0x0400274A RID: 10058
	private float qVqbfFL92J;
}
