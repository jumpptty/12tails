using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000106 RID: 262
[Serializable]
public class GenesisSeed : MonoBehaviour
{
	// Token: 0x060005D1 RID: 1489 RVA: 0x0009BFD0 File Offset: 0x0009A1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GenesisSeed()
	{
		if (208597 - 196709 != 11888)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (72044 - 319958 == -247914)
			{
				base..ctor();
				if (229044 - 106868 == 122176)
				{
					this.V6KnvX50w3 = (float)30;
					if (281374 - 410424 == -129050)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0009C06C File Offset: 0x0009A26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (154333 - 131511 != 22822)
		{
		}
		for (;;)
		{
			this.HH7n2AF41X = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (145544 - 248899 != -103354)
			{
				this.HH7n2AF41X.actionState = "standby";
				if (141550 - 341435 == -199885)
				{
					this.HH7n2AF41X.actionTime = Time.time;
					if (60637 - 63057 != -2419)
					{
						this.HH7n2AF41X.myCommand = "none";
						if (45771 - 539830 == -494059)
						{
							this.V6KnvX50w3 = (float)(30 + UnityEngine.Random.Range(0, 7));
							if (264972 - 444103 == -179131)
							{
								this.jFDnlDr7a5 = new GUIStyle();
								if (278085 - 558744 == -280659)
								{
									this.jFDnlDr7a5.font = (Font)Resources.Load("GameGui/Fonts/GMO32");
									if (87664 - 456799 == -369135)
									{
										this.jFDnlDr7a5.normal.textColor = new Color(0.3f, 0.1f, 0.1f, (float)1);
										if (86592 - 279172 != -192579)
										{
											this.jFDnlDr7a5.alignment = TextAnchor.MiddleCenter;
											if (207106 - 513574 == -306468)
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

	// Token: 0x060005D3 RID: 1491 RVA: 0x0009C244 File Offset: 0x0009A444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (66274 - 50737 != 15538)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (93481 - 60172 != 33309)
				{
					continue;
				}
				this.HH7n2AF41X.isMine = true;
				if (124753 - 36951 == 87803)
				{
					continue;
				}
			}
			this.StartCoroutine_Auto(this.RPC_create());
		}
		while (48841 - 536402 == -487560);
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x0009C2F0 File Offset: 0x0009A4F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (231947 - 73045 != 158902)
		{
		}
		for (;;)
		{
			if (!this.HH7n2AF41X)
			{
				if (167548 - 92419 != 75130)
				{
					break;
				}
			}
			else
			{
				if (this.V6KnvX50w3 <= (float)1)
				{
					break;
				}
				if (155793 - 465516 != -309722)
				{
					Vector3 vector = Camera.main.WorldToScreenPoint(this.transform.position + 3.2f * Vector3.up);
					if (249354 - 518380 == -269026)
					{
						if ((float)0 >= vector.z)
						{
							break;
						}
						if (198143 - 146114 == 52029)
						{
							if (vector.z >= (float)60)
							{
								break;
							}
							if (77419 - 155634 == -78215)
							{
								GUI.depth = 3;
								if (296910 - 143352 == 153558)
								{
									GUI.Label(new Rect(vector.x - (float)20, (float)Screen.height - vector.y - (float)20, (float)40, (float)40), string.Empty + Mathf.FloorToInt(this.V6KnvX50w3), this.jFDnlDr7a5);
									if (282607 - 538685 != -256077)
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

	// Token: 0x060005D5 RID: 1493 RVA: 0x0009C49C File Offset: 0x0009A69C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (159119 - 470833 != -311714)
		{
		}
		for (;;)
		{
			if (this.HH7n2AF41X.hp <= 0)
			{
				if (90486 - 324066 != -233580)
				{
					continue;
				}
				if (this.HH7n2AF41X.actionState != "dead")
				{
					if (242847 - 138741 == 104107)
					{
						continue;
					}
					if (this.HH7n2AF41X.isMine)
					{
						if (134742 - 252794 != -118052)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (10366 - 406052 != -395686)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (219344 - 264348 == -45003)
						{
							continue;
						}
						this.HH7n2AF41X.DeadEvent();
						if (211641 - 255164 != -43522)
						{
							break;
						}
						continue;
					}
					else
					{
						this.HH7n2AF41X.hp = 1;
						if (251415 - 404066 != -152650)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.HH7n2AF41X.hp > 0)
			{
				if (133284 - 570352 == -437067)
				{
					continue;
				}
				if (this.V6KnvX50w3 <= (float)0)
				{
					if (273039 - 291926 == -18886)
					{
						continue;
					}
					if (this.HH7n2AF41X.actionState != "explode")
					{
						if (24910 - 35511 == -10600)
						{
							continue;
						}
						if (this.HH7n2AF41X.isMine)
						{
							if (287066 - 561099 == -274032)
							{
								continue;
							}
							this.StartCoroutine_Auto(this.RPC_explode(this.transform.position, this.transform.forward, 0));
							if (2411 - 158018 != -155607)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (57344 - 166797 != -109453)
							{
								continue;
							}
							this.ActionEvent("RPC_explode", this.transform.position, this.transform.forward, 0);
							if (289108 - 446228 != -157119)
							{
								break;
							}
							continue;
						}
						else
						{
							this.V6KnvX50w3 = (float)0;
							if (47611 - 288023 != -240412)
							{
								continue;
							}
							break;
						}
					}
				}
			}
			if (!(this.HH7n2AF41X.actionState == "standby"))
			{
				break;
			}
			if (291072 - 504856 == -213784)
			{
				this.V6KnvX50w3 -= Time.deltaTime;
				if (223282 - 175404 == 47878)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x0009C808 File Offset: 0x0009AA08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (112750 - 84433 != 28318)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (37979 - 572058 != -534078)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (17103 - 250750 == -233647)
				{
					if (34839 - 491758 != -456918)
					{
						if (ActionName == "RPC_explode")
						{
							if (131321 - 436851 == -305529)
							{
								continue;
							}
							v = 1;
							if (20158 - 67791 != -47633)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (46607 - 402313 != -355706)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (91399 - 165421 == -74022)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (273181 - 188758 == 84423)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (13916 - 34840 == -20924)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (258644 - 502688 != -244043)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (249186 - 391580 != -142393)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (236194 - 4190 == 232004)
											{
												Hashtable hashtable = new Hashtable();
												if (251492 - 272310 != -20817)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (244047 - 519242 != -275194)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (83539 - 372894 == -289355)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (177747 - 361106 != -183358)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (266755 - 57685 == 209070)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (212569 - 214714 != -2144)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (121115 - 580497 == -459382)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (86277 - 597899 != -511621)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (177584 - 83625 != 93960)
																				{
																					PhotonClient.SendEvent(this.HH7n2AF41X.ActorNr, 74, hashtable, true, true);
																					if (246337 - 26855 != 219483)
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

	// Token: 0x060005D7 RID: 1495 RVA: 0x0009CC3C File Offset: 0x0009AE3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (136638 - 599348 != -462709)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (16539 - 420030 == -403491)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (288716 - 42014 == 246702)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (158387 - 321004 != -162616)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (226573 - 14274 == 212299)
						{
							int num2 = num;
							if (11391 - 276865 != -265473)
							{
								if (num2 == 1)
								{
									if (56958 - 594340 == -537382)
									{
										if (this.HH7n2AF41X.isMine)
										{
											break;
										}
										if (127752 - 320536 == -192784)
										{
											this.StartCoroutine_Auto(this.RPC_explode(mPos, tDir, tID));
											if (164564 - 597598 == -433034)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (183392 - 292727 != -109334)
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

	// Token: 0x060005D8 RID: 1496 RVA: 0x0009CE5C File Offset: 0x0009B05C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_create()
	{
		return new GenesisSeed.$RPC_create$16248(this).GetEnumerator();
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0009CE6C File Offset: 0x0009B06C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_explode(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GenesisSeed.$RPC_explode$16251(this).GetEnumerator();
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0009CE7C File Offset: 0x0009B07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0009CE94 File Offset: 0x0009B094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0009CEAC File Offset: 0x0009B0AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0009CEB0 File Offset: 0x0009B0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new GenesisSeed.$RPC_dead$16261(nArray, this).GetEnumerator();
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0009CEC0 File Offset: 0x0009B0C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0009CEC4 File Offset: 0x0009B0C4
	internal static bool jrVj5EULWvJcqSGluFr()
	{
		return true;
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0009CEC8 File Offset: 0x0009B0C8
	internal static bool EE7BhKUOUddbsy6SK0r()
	{
		return false;
	}

	// Token: 0x0400056B RID: 1387
	private CharacterControl HH7n2AF41X;

	// Token: 0x0400056C RID: 1388
	private float V6KnvX50w3;

	// Token: 0x0400056D RID: 1389
	private GUIStyle jFDnlDr7a5;

	// Token: 0x0400056E RID: 1390
	public GameObject create_ring;

	// Token: 0x0400056F RID: 1391
	public GameObject explode_ring;

	// Token: 0x04000570 RID: 1392
	public GameObject destroy_ring;

	// Token: 0x02000107 RID: 263
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_create$16248 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x0009CECC File Offset: 0x0009B0CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_create$16248(GenesisSeed self_)
		{
			if (2606 - 112874 != -110267)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137607 - 439630 != -302022)
				{
					base..ctor();
					if (256296 - 471418 == -215122)
					{
						this.$self_$16250 = self_;
						if (97899 - 112168 == -14269)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0009CF64 File Offset: 0x0009B164
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GenesisSeed.$RPC_create$16248.$(this.$self_$16250);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0009CF74 File Offset: 0x0009B174
		internal static bool WPAIB0UmcsTxUf5SxgE()
		{
			return true;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0009CF78 File Offset: 0x0009B178
		internal static bool PdZKnxUFIYh85uQ6GG4()
		{
			return false;
		}

		// Token: 0x04000571 RID: 1393
		internal GenesisSeed $self_$16250;

		// Token: 0x02000108 RID: 264
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060005E5 RID: 1509 RVA: 0x0009CF7C File Offset: 0x0009B17C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GenesisSeed self_)
			{
				if (246804 - 460634 != -213830)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167159 - 313344 != -146184)
					{
						base..ctor();
						if (117341 - 487476 != -370134)
						{
							this.$self_$16249 = self_;
							if (227012 - 396987 == -169975)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x0009D014 File Offset: 0x0009B214
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75867 - 263877 != -188010)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_469;
					case 2:
						if (this.$self_$16249.HH7n2AF41X.actionState != "attack")
						{
							if (198051 - 456459 != -258407)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$16249.animation.Play("root");
							if (289972 - 207423 == 82550)
							{
								continue;
							}
							this.$self_$16249.animation.wrapMode = WrapMode.Loop;
							if (186697 - 533566 != -346869)
							{
								continue;
							}
							this.$self_$16249.HH7n2AF41X.actionState = "standby";
							if (122822 - 266620 != -143798)
							{
								continue;
							}
							this.$self_$16249.HH7n2AF41X.actionTime = Time.time;
							if (218446 - 401156 != -182710)
							{
								continue;
							}
							this.$self_$16249.HH7n2AF41X.myCommand = "none";
							if (86173 - 413158 != -326985)
							{
								continue;
							}
							this.YieldDefault(1);
							if (106808 - 201277 != -94468)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					default:
						if (29915 - 417936 == -388020)
						{
							continue;
						}
						break;
					}
					this.$self_$16249.HH7n2AF41X.actionState = "attack";
					if (146304 - 217877 != -71572)
					{
						this.$self_$16249.HH7n2AF41X.actionTime = Time.time;
						if (252882 - 258333 != -5450)
						{
							this.$self_$16249.HH7n2AF41X.myCommand = "create";
							if (246472 - 216752 == 29720)
							{
								this.$self_$16249.HH7n2AF41X.addTimeOut("nAttack", (float)6);
								if (216805 - 593546 == -376741)
								{
									this.$self_$16249.animation.Play("create");
									if (67512 - 336935 != -269422)
									{
										this.$self_$16249.animation.wrapMode = WrapMode.Once;
										if (250120 - 34515 == 215605)
										{
											this.$self_$16249.HH7n2AF41X.vMovement = this.$self_$16249.transform.forward;
											if (212291 - 72629 == 139662)
											{
												this.$self_$16249.HH7n2AF41X.moveSpeed = (float)0;
												if (28523 - 346428 == -317905)
												{
													if (this.$self_$16249.create_ring)
													{
														if (28850 - 432928 == -404077)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.$self_$16249.create_ring, this.$self_$16249.transform.position, this.$self_$16249.transform.rotation);
														if (165721 - 227987 == -62265)
														{
															continue;
														}
													}
													else
													{
														Debug.Log("Missing create_ring");
														if (292843 - 78208 == 214636)
														{
															continue;
														}
													}
													Vector3 vector = Camera.main.transform.position - this.$self_$16249.transform.position;
													if (36468 - 457879 != -421410)
													{
														if (vector.sqrMagnitude >= (float)200)
														{
															break;
														}
														if (278495 - 12843 != 265653)
														{
															Camera.main.SendMessage("AddCamereShake", 0.3f);
															if (9725 - 500201 != -490475)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_11:
				Block_23:
				IL_469:
				return false;
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x0009D49C File Offset: 0x0009B69C
			internal static bool hOBB8qUMKZeeCFCW5nn()
			{
				return true;
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x0009D4A0 File Offset: 0x0009B6A0
			internal static bool rqwm2VUxi9vsweSEmf2()
			{
				return false;
			}

			// Token: 0x04000572 RID: 1394
			internal GenesisSeed $self_$16249;
		}
	}

	// Token: 0x02000109 RID: 265
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_explode$16251 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x0009D4A4 File Offset: 0x0009B6A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_explode$16251(GenesisSeed self_)
		{
			if (149245 - 298611 != -149365)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290848 - 223589 == 67259)
				{
					base..ctor();
					if (84579 - 129541 != -44961)
					{
						this.$self_$16260 = self_;
						if (189963 - 334446 != -144482)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0009D53C File Offset: 0x0009B73C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GenesisSeed.$RPC_explode$16251.$(this.$self_$16260);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0009D54C File Offset: 0x0009B74C
		internal static bool O3k8dcUgNlQr7wUgmX4()
		{
			return true;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0009D550 File Offset: 0x0009B750
		internal static bool GDW1jsUfWauV9sU7lIu()
		{
			return false;
		}

		// Token: 0x04000573 RID: 1395
		internal GenesisSeed $self_$16260;

		// Token: 0x0200010A RID: 266
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060005ED RID: 1517 RVA: 0x0009D554 File Offset: 0x0009B754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GenesisSeed self_)
			{
				if (7451 - 372959 != -365508)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (137544 - 406450 == -268906)
					{
						base..ctor();
						if (141306 - 575719 != -434412)
						{
							this.$self_$16259 = self_;
							if (140181 - 393879 != -253697)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x0009D5EC File Offset: 0x0009B7EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (17374 - 506780 != -489406)
				{
				}
				for (;;)
				{
					IL_16B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_682;
					case 2:
						if (this.$self_$16259.HH7n2AF41X.actionState != "attack")
						{
							if (289598 - 190954 != 98645)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (this.$self_$16259.explode_ring)
							{
								if (250511 - 524843 == -274331)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16259.explode_ring, this.$self_$16259.transform.position, this.$self_$16259.transform.rotation);
								if (85682 - 423819 == -338136)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Missing explode_ring");
								if (226366 - 236238 == -9871)
								{
									continue;
								}
							}
							if (this.$self_$16259.HH7n2AF41X.isMine)
							{
								if (111723 - 474119 == -362395)
								{
									continue;
								}
								this.$hitLayer$16252 = 130816 - (1 << this.$self_$16259.gameObject.layer);
								if (288021 - 57899 != 230122)
								{
									continue;
								}
								this.$hitList$16253 = Damage.FindAreaTarget(this.$self_$16259.transform.position, (float)60, (float)12, this.$hitLayer$16252);
								if (64410 - 586123 != -521713)
								{
									continue;
								}
								this.$$iterator$9954$16258 = UnityRuntimeServices.GetEnumerator(this.$hitList$16253);
								if (65678 - 434017 == -368338)
								{
									continue;
								}
								while (this.$$iterator$9954$16258.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9954$16258.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16254 = (GameObject)obj2;
									if (46476 - 156088 != -109612)
									{
										goto IL_16B;
									}
									this.$hitDir$16255 = this.$hitObject$16254.transform.position - this.$self_$16259.transform.position;
									if (215582 - 505156 != -289574)
									{
										goto IL_16B;
									}
									UnityRuntimeServices.Update(this.$$iterator$9954$16258, this.$hitObject$16254);
									if (226452 - 451451 == -224998)
									{
										goto IL_16B;
									}
									this.$hitMagnitude$16256 = (float)1 - 0.01f * this.$hitDir$16255.magnitude;
									if (167611 - 386703 == -219091)
									{
										goto IL_16B;
									}
									this.$hitChar$16257 = (CharacterControl)this.$hitObject$16254.GetComponent(typeof(CharacterControl));
									if (176578 - 77198 != 99380)
									{
										goto IL_16B;
									}
									UnityRuntimeServices.Update(this.$$iterator$9954$16258, this.$hitObject$16254);
									if (2126 - 542574 == -540447)
									{
										goto IL_16B;
									}
									if (this.$hitChar$16257)
									{
										if (41740 - 390253 == -348512)
										{
											goto IL_16B;
										}
										this.$hitChar$16257.RPC_AddEffectDamage(31, Mathf.FloorToInt((float)999 * this.$hitMagnitude$16256 * (1f * (float)this.$self_$16259.HH7n2AF41X.hp / (float)this.$self_$16259.HH7n2AF41X.mhp)), 1, 0, Vector3.zero, this.$self_$16259.HH7n2AF41X.ActorNr);
										if (76283 - 340241 != -263958)
										{
											goto IL_16B;
										}
									}
								}
								if (153145 - 2153 == 150993)
								{
									continue;
								}
							}
							Vector3 vector = Camera.main.transform.position - this.$self_$16259.transform.position;
							if (248780 - 110053 != 138727)
							{
								continue;
							}
							if (vector.sqrMagnitude < (float)200)
							{
								if (2403 - 300462 == -298058)
								{
									continue;
								}
								Camera.main.SendMessage("AddCamereShake", 0.3f);
								if (82307 - 106645 == -24337)
								{
									continue;
								}
							}
							if (this.$self_$16259.HH7n2AF41X.hasStatus("transform"))
							{
								if (23074 - 428503 == -405428)
								{
									continue;
								}
								this.$self_$16259.HH7n2AF41X.removeStatus("transform");
								if (188569 - 129881 != 58688)
								{
									continue;
								}
							}
							else if (this.$self_$16259.HH7n2AF41X.hasStatus("mimic"))
							{
								if (260825 - 120487 == 140339)
								{
									continue;
								}
								this.$self_$16259.HH7n2AF41X.removeStatus("mimic");
								if (142675 - 129515 == 13161)
								{
									continue;
								}
							}
							else
							{
								UnityEngine.Object.Destroy(this.$self_$16259.gameObject);
								if (166690 - 19101 == 147590)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (55054 - 190007 != -134952)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					default:
						if (39075 - 419450 == -380374)
						{
							continue;
						}
						break;
					}
					this.$self_$16259.HH7n2AF41X.actionState = "attack";
					if (194054 - 162905 == 31149)
					{
						this.$self_$16259.HH7n2AF41X.actionTime = Time.time;
						if (275029 - 563840 != -288810)
						{
							this.$self_$16259.HH7n2AF41X.myCommand = "explode";
							if (99602 - 128089 == -28487)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_35:
				Block_37:
				IL_682:
				return false;
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x0009DC90 File Offset: 0x0009BE90
			internal static bool roIudPUnfPgQi2PnjmV()
			{
				return true;
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x0009DC94 File Offset: 0x0009BE94
			internal static bool LY4JVDU6jGWsvcSKdgf()
			{
				return false;
			}

			// Token: 0x04000574 RID: 1396
			internal int $hitLayer$16252;

			// Token: 0x04000575 RID: 1397
			internal UnityScript.Lang.Array $hitList$16253;

			// Token: 0x04000576 RID: 1398
			internal GameObject $hitObject$16254;

			// Token: 0x04000577 RID: 1399
			internal Vector3 $hitDir$16255;

			// Token: 0x04000578 RID: 1400
			internal float $hitMagnitude$16256;

			// Token: 0x04000579 RID: 1401
			internal CharacterControl $hitChar$16257;

			// Token: 0x0400057A RID: 1402
			internal IEnumerator $$iterator$9954$16258;

			// Token: 0x0400057B RID: 1403
			internal GenesisSeed $self_$16259;
		}
	}

	// Token: 0x0200010B RID: 267
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16261 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x0009DC98 File Offset: 0x0009BE98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16261(UnityScript.Lang.Array nArray, GenesisSeed self_)
		{
			if (180537 - 12476 != 168062)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34667 - 597605 == -562938)
				{
					base..ctor();
					if (74500 - 321254 != -246753)
					{
						this.$nArray$16266 = nArray;
						if (8946 - 410125 == -401179)
						{
							this.$self_$16267 = self_;
							if (199099 - 442355 == -243256)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0009DD54 File Offset: 0x0009BF54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GenesisSeed.$RPC_dead$16261.$(this.$nArray$16266, this.$self_$16267);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0009DD68 File Offset: 0x0009BF68
		internal static bool Aj67jdUimtSoRjOEWs0()
		{
			return true;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0009DD6C File Offset: 0x0009BF6C
		internal static bool UYW3ZbUKtgyR2XVdaQt()
		{
			return false;
		}

		// Token: 0x0400057C RID: 1404
		internal UnityScript.Lang.Array $nArray$16266;

		// Token: 0x0400057D RID: 1405
		internal GenesisSeed $self_$16267;

		// Token: 0x0200010C RID: 268
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060005F5 RID: 1525 RVA: 0x0009DD70 File Offset: 0x0009BF70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GenesisSeed self_)
			{
				if (113104 - 499849 != -386745)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60730 - 270842 == -210112)
					{
						base..ctor();
						if (200475 - 35063 == 165412)
						{
							this.$nArray$16264 = nArray;
							if (183182 - 386244 != -203061)
							{
								this.$self_$16265 = self_;
								if (48189 - 118198 != -70008)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060005F6 RID: 1526 RVA: 0x0009DE2C File Offset: 0x0009C02C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257452 - 16118 != 241334)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						if (this.$self_$16265.HH7n2AF41X.actionState != "dead")
						{
							if (148772 - 286712 != -137939)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							if (this.$self_$16265.destroy_ring)
							{
								if (290092 - 52993 == 237100)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16265.destroy_ring, this.$self_$16265.transform.position, Quaternion.identity);
								if (121313 - 481758 != -360445)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing destroy_ring effect");
								if (296164 - 413230 == -117065)
								{
									continue;
								}
							}
							if (!this.$self_$16265.HH7n2AF41X.isPlayer)
							{
								if (36592 - 118038 == -81445)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16265.gameObject);
								if (281521 - 76434 != 205087)
								{
									continue;
								}
							}
							else if (this.$self_$16265.HH7n2AF41X.isMine)
							{
								if (125464 - 151010 != -25546)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16265.gameObject);
								if (178414 - 270640 != -92226)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (111985 - 142191 != -30205)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (188085 - 563055 != -374970)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16265.HH7n2AF41X.actionState == "dead")
					{
						if (277709 - 419198 == -141489)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$16262 = (Vector3)this.$nArray$16264[0];
						if (77747 - 286446 == -208699)
						{
							this.$myDirection$16263 = (Vector3)this.$nArray$16264[1];
							if (192847 - 92283 != 100565)
							{
								this.$self_$16265.transform.position = this.$myPosition$16262;
								if (138286 - 192411 == -54125)
								{
									this.$self_$16265.transform.LookAt(this.$myPosition$16262 + this.$myDirection$16263);
									if (68846 - 160623 == -91777)
									{
										this.$self_$16265.HH7n2AF41X.hp = 0;
										if (123968 - 404546 == -280578)
										{
											this.$self_$16265.HH7n2AF41X.actionState = "dead";
											if (296251 - 519977 == -223726)
											{
												this.$self_$16265.HH7n2AF41X.actionTime = Time.time;
												if (90593 - 509450 == -418857)
												{
													this.$self_$16265.HH7n2AF41X.myCommand = "none";
													if (165432 - 425115 == -259683)
													{
														this.$self_$16265.HH7n2AF41X.vMovement = Vector3.zero;
														if (167991 - 214374 == -46383)
														{
															this.$self_$16265.HH7n2AF41X.moveSpeed = (float)0;
															if (109797 - 5558 == 104239)
															{
																this.$self_$16265.animation.Rewind();
																if (177766 - 166975 == 10791)
																{
																	this.$self_$16265.animation.Play("destroy");
																	if (230597 - 522264 == -291667)
																	{
																		this.$self_$16265.animation.wrapMode = WrapMode.Once;
																		if (225698 - 112820 != 112879)
																		{
																			goto Block_25;
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
				Block_3:
				Block_13:
				goto IL_4C7;
				Block_25:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_4C7:
				return false;
			}

			// Token: 0x060005F7 RID: 1527 RVA: 0x0009E314 File Offset: 0x0009C514
			internal static bool l1tWgdUddD5y9FqcUa3()
			{
				return true;
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x0009E318 File Offset: 0x0009C518
			internal static bool uQo2DSUJ3DRPqcettZy()
			{
				return false;
			}

			// Token: 0x0400057E RID: 1406
			internal Vector3 $myPosition$16262;

			// Token: 0x0400057F RID: 1407
			internal Vector3 $myDirection$16263;

			// Token: 0x04000580 RID: 1408
			internal UnityScript.Lang.Array $nArray$16264;

			// Token: 0x04000581 RID: 1409
			internal GenesisSeed $self_$16265;
		}
	}
}
