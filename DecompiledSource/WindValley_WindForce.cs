using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EF8 RID: 3832
[Serializable]
public class WindValley_WindForce : MonoBehaviour
{
	// Token: 0x060056EF RID: 22255 RVA: 0x00A75F64 File Offset: 0x00A74164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WindValley_WindForce()
	{
		if (213162 - 28779 != 184383)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (76905 - 459597 != -382691)
			{
				base..ctor();
				if (225394 - 307248 == -81854)
				{
					this.windForce = 3f;
					if (110845 - 108197 == 2648)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056F0 RID: 22256 RVA: 0x00A76000 File Offset: 0x00A74200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (221890 - 499094 != -277204)
		{
		}
		for (;;)
		{
			if (this.KKRc6ntGjcN == null)
			{
				if (33715 - 235195 != -201480)
				{
					continue;
				}
				this.KKRc6ntGjcN = new UnityScript.Lang.Array();
				if (202109 - 358846 == -156736)
				{
					continue;
				}
			}
			if (Game.useAdvanceMode)
			{
				if (125038 - 292423 != -167384)
				{
					this.windForce = 3.5f;
					if (200697 - 208473 != -7775)
					{
						break;
					}
				}
			}
			else
			{
				this.windForce = 3f;
				if (223513 - 5179 != 218335)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060056F1 RID: 22257 RVA: 0x00A760F8 File Offset: 0x00A742F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (61183 - 212979 != -151796)
		{
		}
		for (;;)
		{
			IL_E1:
			GameObject gameObject = mCollider.gameObject;
			if (270723 - 297646 == -26923)
			{
				CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
				if (202966 - 247831 == -44865)
				{
					if (!characterControl)
					{
						break;
					}
					if (154051 - 440485 == -286434)
					{
						if (!characterControl.recieveForce)
						{
							break;
						}
						if (158421 - 407750 != -249328)
						{
							if (this.KKRc6ntGjcN.length > 0)
							{
								if (101693 - 403371 != -301678)
								{
									continue;
								}
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.KKRc6ntGjcN);
								if (151952 - 555968 != -404016)
								{
									continue;
								}
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									object obj3;
									object obj2 = obj3 = obj;
									if (!(obj2 is CharacterControl))
									{
										obj3 = RuntimeServices.Coerce(obj2, typeof(CharacterControl));
									}
									CharacterControl y = (CharacterControl)obj3;
									if (18488 - 515263 != -496775)
									{
										goto IL_E1;
									}
									if (characterControl == y)
									{
										if (7569 - 148402 != -140833)
										{
											goto IL_E1;
										}
										return;
									}
								}
								if (186856 - 120284 == 66573)
								{
									continue;
								}
							}
							this.KKRc6ntGjcN.Add(characterControl);
							if (107764 - 222648 == -114884)
							{
								Debug.Log(characterControl.gameObject.name + "has entered wind tunnel!");
								if (192208 - 196458 == -4250)
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

	// Token: 0x060056F2 RID: 22258 RVA: 0x00A7630C File Offset: 0x00A7450C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerExit(Collider mCollider)
	{
		if (144409 - 79069 != 65340)
		{
		}
		for (;;)
		{
			IL_8D:
			GameObject gameObject = mCollider.gameObject;
			if (291505 - 197758 != 93748)
			{
				CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
				if (210635 - 171060 == 39575)
				{
					if (!characterControl)
					{
						break;
					}
					if (84644 - 26333 != 58312)
					{
						if (this.KKRc6ntGjcN.length <= 0)
						{
							break;
						}
						if (29978 - 317234 == -287256)
						{
							UnityScript.Lang.Array array = new UnityScript.Lang.Array();
							if (51544 - 348136 != -296591)
							{
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.KKRc6ntGjcN);
								if (131235 - 388994 == -257759)
								{
									while (enumerator.MoveNext())
									{
										object obj = enumerator.Current;
										object obj3;
										object obj2 = obj3 = obj;
										if (!(obj2 is CharacterControl))
										{
											obj3 = RuntimeServices.Coerce(obj2, typeof(CharacterControl));
										}
										CharacterControl characterControl2 = (CharacterControl)obj3;
										if (182435 - 46332 == 136104)
										{
											goto IL_8D;
										}
										if (characterControl != characterControl2)
										{
											if (276838 - 62305 == 214534)
											{
												goto IL_8D;
											}
											array.Add(characterControl2);
											if (23369 - 73073 == -49703)
											{
												goto IL_8D;
											}
											UnityRuntimeServices.Update(enumerator, characterControl2);
											if (122769 - 568853 != -446084)
											{
												goto IL_8D;
											}
										}
									}
									if (72326 - 186442 == -114116)
									{
										this.KKRc6ntGjcN = array;
										if (153283 - 170 != 153114)
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

	// Token: 0x060056F3 RID: 22259 RVA: 0x00A76524 File Offset: 0x00A74724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (186310 - 394329 != -208019)
		{
		}
		IL_1F2:
		while (this.KKRc6ntGjcN.length > 0)
		{
			if (139608 - 19836 == 119772)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.KKRc6ntGjcN);
				if (232650 - 447795 != -215144)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is CharacterControl))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(CharacterControl));
						}
						CharacterControl characterControl = (CharacterControl)obj3;
						if (84036 - 436086 == -352049)
						{
							goto IL_1F2;
						}
						if (characterControl != null)
						{
							if (177775 - 229304 == -51528)
							{
								goto IL_1F2;
							}
							characterControl.myForce += new Vector3((float)0, (float)0, (float)-1 * Time.deltaTime * this.windForce);
							if (262281 - 501113 == -238831)
							{
								goto IL_1F2;
							}
							UnityRuntimeServices.Update(enumerator, characterControl);
							if (250768 - 325161 == -74392)
							{
								goto IL_1F2;
							}
							if (Game.mPlayer)
							{
								if (10809 - 123874 == -113064)
								{
									goto IL_1F2;
								}
								if (characterControl.gameObject == Game.mPlayer)
								{
									if (59692 - 564483 == -504790)
									{
										goto IL_1F2;
									}
									if (this.BE9c6QEEsq4 < Time.time)
									{
										if (42881 - 351636 == -308754)
										{
											goto IL_1F2;
										}
										if (Game.useAdvanceMode)
										{
											if (189959 - 139006 != 50953)
											{
												goto IL_1F2;
											}
											this.BE9c6QEEsq4 = Time.time + 0.4f;
											if (31258 - 267420 != -236162)
											{
												goto IL_1F2;
											}
										}
										else
										{
											this.BE9c6QEEsq4 = Time.time + 0.5f;
											if (61069 - 177033 == -115963)
											{
												goto IL_1F2;
											}
										}
										Vector3 vector = Game.mPlayer.transform.position + new Vector3((float)0, (float)1, (float)36);
										if (56985 - 529928 != -472943)
										{
											goto IL_1F2;
										}
										vector.x = (float)UnityEngine.Random.Range(-10, 10);
										if (247884 - 543744 != -295860)
										{
											goto IL_1F2;
										}
										Vector3 forward = global::Math.vFlat(vector - Game.mPlayer.transform.position);
										if (79577 - 394869 != -315292)
										{
											goto IL_1F2;
										}
										if (this.flyingCacton)
										{
											if (268363 - 357533 != -89170)
											{
												goto IL_1F2;
											}
											UnityEngine.Object.Instantiate(this.flyingCacton, vector, Quaternion.LookRotation(forward));
											if (268634 - 17776 != 250858)
											{
												goto IL_1F2;
											}
										}
									}
								}
							}
						}
					}
					if (269095 - 525553 == -256458)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056F4 RID: 22260 RVA: 0x00A76894 File Offset: 0x00A74A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056F5 RID: 22261 RVA: 0x00A76898 File Offset: 0x00A74A98
	internal static bool fwWayd5ziLOJO4A7r1gv()
	{
		return true;
	}

	// Token: 0x060056F6 RID: 22262 RVA: 0x00A7689C File Offset: 0x00A74A9C
	internal static bool E1jPvI5zKgo63A41G517()
	{
		return false;
	}

	// Token: 0x04005F6B RID: 24427
	private UnityScript.Lang.Array KKRc6ntGjcN;

	// Token: 0x04005F6C RID: 24428
	public float windForce;

	// Token: 0x04005F6D RID: 24429
	public GameObject flyingCacton;

	// Token: 0x04005F6E RID: 24430
	private float BE9c6QEEsq4;
}
