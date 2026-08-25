using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E73 RID: 3699
[Serializable]
public class AutoGallonGun : MonoBehaviour
{
	// Token: 0x060053DD RID: 21469 RVA: 0x00A3716C File Offset: 0x00A3536C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AutoGallonGun()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x00A3717C File Offset: 0x00A3537C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (70257 - 547044 != -476786)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (238168 - 187817 != 50352)
			{
				this.mChar.actionTime = Time.time;
				if (55981 - 1859 == 54122)
				{
					this.mChar.myCommand = "none";
					if (54853 - 101344 != -46490)
					{
						this.UjZcIPKdqyp = Time.time + (float)2;
						if (7873 - 189893 != -182019)
						{
							this.NmLcIESCVO3 = this.transform.Find("AutoGallonGun_tri/base/leg1");
							if (168362 - 129017 == 39345)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060053DF RID: 21471 RVA: 0x00A37298 File Offset: 0x00A35498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.StartCoroutine_Auto(this.create());
	}

	// Token: 0x060053E0 RID: 21472 RVA: 0x00A372A8 File Offset: 0x00A354A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (13387 - 282182 != -268795)
		{
		}
		for (;;)
		{
			if (this.mChar.hp <= 0)
			{
				if (172656 - 593799 == -421142)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (50201 - 45543 != 4658)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (84095 - 515047 == -430951)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (107600 - 11757 != 95843)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (198679 - 297635 != -98956)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (204924 - 204495 != 430)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (276119 - 427280 != -151161)
						{
							continue;
						}
						break;
					}
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (223820 - 408197 == -184377)
			{
				if (this.mChar.isControlled)
				{
					break;
				}
				if (83733 - 25102 != 58632)
				{
					if (Game.mGameState != eGameState.Normal)
					{
						if (202714 - 272284 != -69570)
						{
							continue;
						}
						if (Game.mGameState != eGameState.Hold)
						{
							break;
						}
						if (238460 - 436473 != -198013)
						{
							continue;
						}
					}
					this.AIControl();
					if (90631 - 236036 == -145405)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060053E1 RID: 21473 RVA: 0x00A374F8 File Offset: 0x00A356F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator create()
	{
		return new AutoGallonGun.$create$34275(this).GetEnumerator();
	}

	// Token: 0x060053E2 RID: 21474 RVA: 0x00A37508 File Offset: 0x00A35708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (293740 - 439951 != -146210)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (264060 - 220534 == 43526)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (89233 - 25374 != 63860)
				{
					if (187488 - 582785 == -395297)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (48387 - 219927 == -171539)
							{
								continue;
							}
							v = 1;
							if (139789 - 29321 != 110468)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (123444 - 193370 == -69926)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (123975 - 428230 != -304254)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (108592 - 231614 == -123022)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (37774 - 109456 != -71681)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (296923 - 7348 == 289575)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (170321 - 342332 == -172011)
											{
												Hashtable hashtable = new Hashtable();
												if (131460 - 212226 == -80766)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (108409 - 220234 == -111825)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (75344 - 33939 != 41406)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (85322 - 187877 == -102555)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (220755 - 305652 == -84897)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (193302 - 72197 == 121105)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (47066 - 41960 == 5106)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (139286 - 40351 != 98936)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (187405 - 124043 != 63363)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (257044 - 70834 == 186210)
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

	// Token: 0x060053E3 RID: 21475 RVA: 0x00A37910 File Offset: 0x00A35B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (164603 - 317795 != -153192)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (120517 - 210564 != -90046)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (263206 - 141478 != 121729)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (285202 - 452186 == -166984)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (28249 - 42180 != -13930)
						{
							int num2 = num;
							if (292723 - 133304 == 159419)
							{
								if (num2 == 1)
								{
									if (75195 - 549817 == -474622)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (105553 - 185149 == -79596)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(mPos, tDir, tID));
											if (282619 - 148949 != 133671)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (177165 - 149142 == 28023)
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

	// Token: 0x060053E4 RID: 21476 RVA: 0x00A37B30 File Offset: 0x00A35D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (179022 - 174726 != 4296)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (102457 - 558779 != -456321)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (43285 - 7797 == 35488)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (118705 - 149229 == -30524)
					{
						Vector3 normalized = vector.normalized;
						if (230693 - 590884 == -360191)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (168772 - 326332 == -157560)
							{
								if (53176 - 361063 == -307887)
								{
									if (gameObject)
									{
										if (11024 - 78877 != -67853)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (285153 - 431254 != -146101)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (240294 - 364207 != -123913)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (95018 - 572617 == -477598)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (106247 - 383972 != -277724)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (149816 - 272315 == -122499)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (45285 - 541909 != -496623)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (162341 - 324686 != -162344)
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

	// Token: 0x060053E5 RID: 21477 RVA: 0x00A37DEC File Offset: 0x00A35FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060053E6 RID: 21478 RVA: 0x00A37E04 File Offset: 0x00A36004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060053E7 RID: 21479 RVA: 0x00A37E08 File Offset: 0x00A36008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new AutoGallonGun.$RPC_nAttack$34278(tDir, this).GetEnumerator();
	}

	// Token: 0x060053E8 RID: 21480 RVA: 0x00A37E18 File Offset: 0x00A36018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (287567 - 431260 != -143693)
		{
		}
		while (this.mChar.actionState == "standby")
		{
			if (39948 - 577526 == -537578)
			{
				if (Time.time > this.UjZcIPKdqyp)
				{
					if (92423 - 514136 == -421712)
					{
						continue;
					}
					if (this.mChar.isTimeOut("nAttack") == (float)0)
					{
						if (149569 - 452411 == -302841)
						{
							continue;
						}
						this.UjZcIPKdqyp = Time.time + (float)1;
						if (60729 - 159230 != -98501)
						{
							continue;
						}
						this.findAttackTarget();
						if (239574 - 249214 != -9640)
						{
							continue;
						}
						if (this.PS5cISl0HHt)
						{
							if (79416 - 565378 != -485962)
							{
								continue;
							}
							if ((CharacterControl)this.PS5cISl0HHt.GetComponent(typeof(CharacterControl)) != null)
							{
								if (46507 - 157152 == -110644)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.PS5cISl0HHt.collider.bounds.center - this.transform.position, 0));
								if (48345 - 266019 != -217673)
								{
									if (PhotonClient.IsInitialized())
									{
										if (293466 - 510497 == -217030)
										{
											continue;
										}
										this.ActionEvent("RPC_nAttack", this.transform.position, this.PS5cISl0HHt.collider.bounds.center - this.transform.position, 0);
										if (246071 - 181536 != 64535)
										{
											continue;
										}
									}
									break;
								}
								continue;
							}
						}
						this.mChar.actionTime = Time.time;
						if (147919 - 279267 != -131348)
						{
							continue;
						}
						break;
					}
				}
				if (!this.PS5cISl0HHt)
				{
					break;
				}
				if (181719 - 107875 == 73844)
				{
					Vector3 vector = this.transform.position - this.PS5cISl0HHt.transform.position;
					if (244654 - 451699 != -207044)
					{
						if (vector.sqrMagnitude > (float)1600)
						{
							if (102343 - 399244 == -296901)
							{
								this.PS5cISl0HHt = null;
								if (37888 - 521288 == -483400)
								{
									break;
								}
							}
						}
						else
						{
							this.NmLcIESCVO3.rotation = Quaternion.FromToRotation(Vector3.right, global::Math.vFlat(this.PS5cISl0HHt.transform.position - this.transform.position));
							if (276103 - 254257 == 21846)
							{
								Vector3 localEulerAngles = this.NmLcIESCVO3.localEulerAngles;
								if (96846 - 236259 == -139413)
								{
									float z = localEulerAngles.z - (float)90;
									if (293690 - 325262 == -31572)
									{
										Vector3 localEulerAngles2 = this.NmLcIESCVO3.localEulerAngles;
										if (37290 - 23136 == 14154)
										{
											float num = localEulerAngles2.z = z;
											if (9731 - 310217 == -300486)
											{
												if (270197 - 300426 != -30228)
												{
													Vector3 vector2 = this.NmLcIESCVO3.localEulerAngles = localEulerAngles2;
													if (50918 - 164698 == -113780)
													{
														if (129766 - 520320 == -390554)
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

	// Token: 0x060053E9 RID: 21481 RVA: 0x00A382A8 File Offset: 0x00A364A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void findAttackTarget()
	{
		if (258648 - 86574 != 172075)
		{
		}
		for (;;)
		{
			UnityScript.Lang.Array array = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
			if (282488 - 359848 != -77359)
			{
				if (array.length > 0)
				{
					if (113499 - 535586 != -422086)
					{
						object obj2;
						object obj = obj2 = array[UnityEngine.Random.Range(0, array.length)];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.PS5cISl0HHt = (GameObject)obj2;
						if (280981 - 216032 != 64950)
						{
							break;
						}
					}
				}
				else
				{
					this.PS5cISl0HHt = null;
					if (74162 - 589372 == -515210)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060053EA RID: 21482 RVA: 0x00A383B8 File Offset: 0x00A365B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new AutoGallonGun.$RPC_dead$34293(nArray, this).GetEnumerator();
	}

	// Token: 0x060053EB RID: 21483 RVA: 0x00A383C8 File Offset: 0x00A365C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060053EC RID: 21484 RVA: 0x00A383CC File Offset: 0x00A365CC
	internal static bool sjvPEq5sy7a8ZDkN7n1r()
	{
		return true;
	}

	// Token: 0x060053ED RID: 21485 RVA: 0x00A383D0 File Offset: 0x00A365D0
	internal static bool Pp5WDm5sSdHOJmwJToyZ()
	{
		return false;
	}

	// Token: 0x04005D00 RID: 23808
	public CharacterControl mChar;

	// Token: 0x04005D01 RID: 23809
	private Transform NmLcIESCVO3;

	// Token: 0x04005D02 RID: 23810
	public AudioClip create_fx;

	// Token: 0x04005D03 RID: 23811
	public GameObject nAttack;

	// Token: 0x04005D04 RID: 23812
	public AudioClip nAttack_fx;

	// Token: 0x04005D05 RID: 23813
	private float UjZcIPKdqyp;

	// Token: 0x04005D06 RID: 23814
	private GameObject PS5cISl0HHt;

	// Token: 0x02000E74 RID: 3700
	[CompilerGenerated]
	[Serializable]
	internal sealed class $create$34275 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060053EE RID: 21486 RVA: 0x00A383D4 File Offset: 0x00A365D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $create$34275(AutoGallonGun self_)
		{
			if (294390 - 408210 != -113819)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104100 - 54063 == 50037)
				{
					base..ctor();
					if (67588 - 470164 == -402576)
					{
						this.$self_$34277 = self_;
						if (31679 - 177564 != -145884)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x00A3846C File Offset: 0x00A3666C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGallonGun.$create$34275.$(this.$self_$34277);
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00A3847C File Offset: 0x00A3667C
		internal static bool jgnvmM5soaOk8VAr1oaW()
		{
			return true;
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00A38480 File Offset: 0x00A36680
		internal static bool yaBot25sETq4OkXXrXkc()
		{
			return false;
		}

		// Token: 0x04005D07 RID: 23815
		internal AutoGallonGun $self_$34277;

		// Token: 0x02000E75 RID: 3701
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060053F2 RID: 21490 RVA: 0x00A38484 File Offset: 0x00A36684
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(AutoGallonGun self_)
			{
				if (185518 - 536009 != -350491)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264039 - 14161 == 249878)
					{
						base..ctor();
						if (94832 - 119346 != -24513)
						{
							this.$self_$34276 = self_;
							if (190894 - 337723 != -146828)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060053F3 RID: 21491 RVA: 0x00A3851C File Offset: 0x00A3671C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31273 - 294325 != -263051)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1F9;
					case 2:
						this.$self_$34276.mChar.actionState = "standby";
						if (55496 - 119576 != -64080)
						{
							continue;
						}
						this.$self_$34276.animation.Play("root");
						if (184084 - 244623 != -60539)
						{
							continue;
						}
						this.$self_$34276.animation.wrapMode = WrapMode.Loop;
						if (202614 - 370460 == -167845)
						{
							continue;
						}
						this.YieldDefault(1);
						if (198479 - 103001 != 95479)
						{
							goto Block_4;
						}
						continue;
					default:
						if (197199 - 478518 == -281318)
						{
							continue;
						}
						break;
					}
					this.$self_$34276.mChar.actionState = "create";
					if (87601 - 498896 != -411294)
					{
						this.$self_$34276.animation.Play("create");
						if (23309 - 221289 != -197979)
						{
							if (this.$self_$34276.create_fx)
							{
								if (21923 - 75397 != -53473)
								{
									this.$self_$34276.audio.PlayOneShot(this.$self_$34276.create_fx);
									if (188359 - 60841 != 127519)
									{
										break;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find create_fx effect");
								if (10998 - 274679 != -263680)
								{
									break;
								}
							}
						}
					}
				}
				goto IL_11F;
				Block_4:
				goto IL_1F9;
				IL_11F:
				return this.Yield(2, new WaitForSeconds(0.8f));
				goto IL_11F;
				IL_1F9:
				return false;
			}

			// Token: 0x060053F4 RID: 21492 RVA: 0x00A38734 File Offset: 0x00A36934
			internal static bool giPYLq5s2hNgXf6XeOse()
			{
				return true;
			}

			// Token: 0x060053F5 RID: 21493 RVA: 0x00A38738 File Offset: 0x00A36938
			internal static bool QXvd705s8KBkPMDAx3EY()
			{
				return false;
			}

			// Token: 0x04005D08 RID: 23816
			internal AutoGallonGun $self_$34276;
		}
	}

	// Token: 0x02000E76 RID: 3702
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34278 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060053F6 RID: 21494 RVA: 0x00A3873C File Offset: 0x00A3693C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34278(Vector3 tDir, AutoGallonGun self_)
		{
			if (81388 - 110159 != -28771)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84652 - 341991 != -257338)
				{
					base..ctor();
					if (5298 - 394235 == -388937)
					{
						this.$tDir$34291 = tDir;
						if (220657 - 342689 != -122031)
						{
							this.$self_$34292 = self_;
							if (8021 - 526146 == -518125)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x00A387F8 File Offset: 0x00A369F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGallonGun.$RPC_nAttack$34278.$(this.$tDir$34291, this.$self_$34292);
		}

		// Token: 0x060053F8 RID: 21496 RVA: 0x00A3880C File Offset: 0x00A36A0C
		internal static bool Ew5QPu5sZV8Fpu5vL8Sl()
		{
			return true;
		}

		// Token: 0x060053F9 RID: 21497 RVA: 0x00A38810 File Offset: 0x00A36A10
		internal static bool Y8hRG05sCNlHwJ9X15PL()
		{
			return false;
		}

		// Token: 0x04005D09 RID: 23817
		internal Vector3 $tDir$34291;

		// Token: 0x04005D0A RID: 23818
		internal AutoGallonGun $self_$34292;

		// Token: 0x02000E77 RID: 3703
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060053FA RID: 21498 RVA: 0x00A38814 File Offset: 0x00A36A14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 tDir, AutoGallonGun self_)
			{
				if (242468 - 377629 != -135161)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21400 - 533557 == -512157)
					{
						base..ctor();
						if (142545 - 293970 == -151425)
						{
							this.$tDir$34289 = tDir;
							if (121668 - 7502 == 114166)
							{
								this.$self_$34290 = self_;
								if (80685 - 425728 != -345042)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060053FB RID: 21499 RVA: 0x00A388D0 File Offset: 0x00A36AD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281101 - 66224 != 214877)
				{
				}
				for (;;)
				{
					IL_6C4:
					switch (this._state)
					{
					case 0:
						goto IL_695;
					case 1:
						goto IL_972;
					case 2:
						if (this.$self_$34290.mChar.actionState != "attack")
						{
							goto IL_1DF;
						}
						if (77186 - 38930 != 38256)
						{
							continue;
						}
						if (this.$self_$34290.mChar.myCommand != "nAttack")
						{
							if (177085 - 139529 != 37557)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							if (this.$self_$34290.mChar.isMine)
							{
								if (8628 - 278020 != -269392)
								{
									continue;
								}
								this.$hitLayer$34283 = 130816 - (1 << this.$self_$34290.gameObject.layer);
								if (241642 - 110484 == 131159)
								{
									continue;
								}
								this.$hitList$34284 = Damage.FindRecTarget(this.$self_$34290.transform.position + (float)(this.$i$34282 * 20) * this.$fireVector$34279, this.$fireVector$34279, 0.2f, 0.5f, (float)20, (float)2, this.$hitLayer$34283);
								if (106168 - 20272 != 85896)
								{
									continue;
								}
								this.$$iterator$10898$34286 = UnityRuntimeServices.GetEnumerator(this.$hitList$34284);
								if (214964 - 98564 == 116401)
								{
									continue;
								}
								while (this.$$iterator$10898$34286.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10898$34286.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34285 = (GameObject)obj2;
									if (14827 - 468631 == -453803)
									{
										goto IL_6C4;
									}
									this.$self_$34290.mChar.hit(1, this.$hitObject$34285, (int)(0.65f * (float)this.$self_$34290.mChar.atk), 1, 0, Vector3.zero);
									if (62303 - 1348 != 60955)
									{
										goto IL_6C4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10898$34286, this.$hitObject$34285);
									if (195054 - 454036 == -258981)
									{
										goto IL_6C4;
									}
								}
								if (192997 - 337982 == -144984)
								{
									continue;
								}
							}
							this.$i$34282++;
							if (195910 - 310957 != -115047)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34290.mChar.actionState == "attack")
						{
							if (83306 - 532413 == -449106)
							{
								continue;
							}
							if (this.$self_$34290.mChar.myCommand == "nAttack")
							{
								if (173407 - 229186 == -55778)
								{
									continue;
								}
								this.$self_$34290.mChar.actionState = "standby";
								if (239338 - 347561 != -108223)
								{
									continue;
								}
								this.$self_$34290.mChar.actionTime = Time.time;
								if (115381 - 183085 != -67704)
								{
									continue;
								}
								this.$self_$34290.mChar.myCommand = "none";
								if (13596 - 458061 != -444465)
								{
									continue;
								}
								this.$self_$34290.mChar.nPosition = this.$self_$34290.transform.position;
								if (264161 - 131814 == 132348)
								{
									continue;
								}
								this.$self_$34290.animation.CrossFade("root");
								if (119992 - 524204 == -404211)
								{
									continue;
								}
								this.$self_$34290.animation.wrapMode = WrapMode.Loop;
								if (184395 - 523274 == -338878)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (248477 - 316386 != -67908)
						{
							goto Block_23;
						}
						continue;
					default:
						if (231300 - 503527 != -272227)
						{
							continue;
						}
						goto IL_695;
					}
					IL_644:
					if (this.$i$34282 < 2)
					{
						goto IL_789;
					}
					if (42993 - 549693 != -506700)
					{
						continue;
					}
					goto IL_31C;
					IL_695:
					this.$self_$34290.mChar.actionState = "attack";
					if (164843 - 176791 == -11948)
					{
						this.$self_$34290.mChar.actionTime = Time.time;
						if (271019 - 146673 != 124347)
						{
							this.$self_$34290.mChar.myCommand = "nAttack";
							if (79217 - 329339 != -250121)
							{
								this.$self_$34290.mChar.addTimeOut("nAttack", (float)2);
								if (249159 - 218231 != 30929)
								{
									this.$self_$34290.NmLcIESCVO3.rotation = Quaternion.FromToRotation(Vector3.right, global::Math.vFlat(this.$tDir$34289));
									if (80684 - 298799 == -218115)
									{
										this.$$13796$34287 = this.$self_$34290.NmLcIESCVO3.localEulerAngles.z - (float)90;
										if (95999 - 511503 == -415504)
										{
											if (126687 - 242555 != -115867)
											{
												this.$$13797$34288 = this.$self_$34290.NmLcIESCVO3.localEulerAngles;
												if (44646 - 342565 != -297918 && 88273 - 387531 != -299257)
												{
													float num = this.$$13797$34288.z = this.$$13796$34287;
													if (15148 - 513334 != -498185)
													{
														if (249421 - 421621 == -172200)
														{
															this.$self_$34290.NmLcIESCVO3.localEulerAngles = this.$$13797$34288;
															if (291665 - 362579 != -70913 && 151357 - 229908 != -78550)
															{
																this.$self_$34290.animation.CrossFade("fire");
																if (46186 - 535537 != -489350)
																{
																	this.$self_$34290.animation.wrapMode = WrapMode.Loop;
																	if (175944 - 591160 != -415215)
																	{
																		if (this.$self_$34290.nAttack_fx)
																		{
																			if (374 - 324437 != -324063)
																			{
																				continue;
																			}
																			this.$self_$34290.audio.PlayOneShot(this.$self_$34290.nAttack_fx);
																			if (171641 - 69085 != 102556)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find nAttack_fx effect");
																			if (287163 - 512338 != -225175)
																			{
																				continue;
																			}
																		}
																		this.$fireVector$34279 = global::Math.vFlat(this.$tDir$34289).normalized;
																		if (275320 - 153243 != 122078)
																		{
																			this.$firePos$34280 = this.$self_$34290.transform.position + this.$self_$34290.transform.TransformDirection((float)0, 1.5f, (float)0);
																			if (198238 - 468686 != -270447)
																			{
																				this.$fireRot$34281 = Quaternion.FromToRotation(Vector3.forward, this.$fireVector$34279);
																				if (219486 - 219928 == -442)
																				{
																					if (this.$self_$34290.nAttack)
																					{
																						if (8161 - 540431 == -532269)
																						{
																							continue;
																						}
																						UnityEngine.Object.Instantiate(this.$self_$34290.nAttack, this.$firePos$34280, this.$fireRot$34281);
																						if (46040 - 352067 == -306026)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						Debug.LogError("Cannot find nAttack effect");
																						if (124126 - 4700 != 119426)
																						{
																							continue;
																						}
																					}
																					this.$i$34282 = 0;
																					if (299807 - 470070 != -170262)
																					{
																						goto IL_644;
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
				Block_8:
				IL_1DF:
				goto IL_972;
				IL_31C:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_23:
				goto IL_972;
				IL_789:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_972:
				return false;
			}

			// Token: 0x060053FC RID: 21500 RVA: 0x00A39264 File Offset: 0x00A37464
			internal static bool xWyX3H5sLfqoYxoYvgE5()
			{
				return true;
			}

			// Token: 0x060053FD RID: 21501 RVA: 0x00A39268 File Offset: 0x00A37468
			internal static bool CX66855sOmQCPkkpflJF()
			{
				return false;
			}

			// Token: 0x04005D0B RID: 23819
			internal Vector3 $fireVector$34279;

			// Token: 0x04005D0C RID: 23820
			internal Vector3 $firePos$34280;

			// Token: 0x04005D0D RID: 23821
			internal Quaternion $fireRot$34281;

			// Token: 0x04005D0E RID: 23822
			internal int $i$34282;

			// Token: 0x04005D0F RID: 23823
			internal int $hitLayer$34283;

			// Token: 0x04005D10 RID: 23824
			internal UnityScript.Lang.Array $hitList$34284;

			// Token: 0x04005D11 RID: 23825
			internal GameObject $hitObject$34285;

			// Token: 0x04005D12 RID: 23826
			internal IEnumerator $$iterator$10898$34286;

			// Token: 0x04005D13 RID: 23827
			internal float $$13796$34287;

			// Token: 0x04005D14 RID: 23828
			internal Vector3 $$13797$34288;

			// Token: 0x04005D15 RID: 23829
			internal Vector3 $tDir$34289;

			// Token: 0x04005D16 RID: 23830
			internal AutoGallonGun $self_$34290;
		}
	}

	// Token: 0x02000E78 RID: 3704
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34293 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060053FE RID: 21502 RVA: 0x00A3926C File Offset: 0x00A3746C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34293(UnityScript.Lang.Array nArray, AutoGallonGun self_)
		{
			if (227445 - 562310 != -334864)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262596 - 338258 != -75661)
				{
					base..ctor();
					if (98561 - 69796 != 28766)
					{
						this.$nArray$34298 = nArray;
						if (271963 - 235971 != 35993)
						{
							this.$self_$34299 = self_;
							if (61894 - 165594 != -103699)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060053FF RID: 21503 RVA: 0x00A39328 File Offset: 0x00A37528
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new AutoGallonGun.$RPC_dead$34293.$(this.$nArray$34298, this.$self_$34299);
		}

		// Token: 0x06005400 RID: 21504 RVA: 0x00A3933C File Offset: 0x00A3753C
		internal static bool vtfeOD5smgqIWe7OyJWB()
		{
			return true;
		}

		// Token: 0x06005401 RID: 21505 RVA: 0x00A39340 File Offset: 0x00A37540
		internal static bool cQYvCt5sFpLs9qAf31SV()
		{
			return false;
		}

		// Token: 0x04005D17 RID: 23831
		internal UnityScript.Lang.Array $nArray$34298;

		// Token: 0x04005D18 RID: 23832
		internal AutoGallonGun $self_$34299;

		// Token: 0x02000E79 RID: 3705
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005402 RID: 21506 RVA: 0x00A39344 File Offset: 0x00A37544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, AutoGallonGun self_)
			{
				if (217078 - 309219 != -92141)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19486 - 162270 != -142783)
					{
						base..ctor();
						if (58115 - 91325 == -33210)
						{
							this.$nArray$34296 = nArray;
							if (67985 - 427877 == -359892)
							{
								this.$self_$34297 = self_;
								if (7849 - 75974 != -68124)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005403 RID: 21507 RVA: 0x00A39400 File Offset: 0x00A37600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148040 - 370004 != -221964)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F1;
					case 2:
						if (this.$self_$34297.mChar.isPlayer)
						{
							if (10988 - 513378 == -502389)
							{
								continue;
							}
							if (this.$self_$34297.mChar.isMine)
							{
								if (91144 - 164989 != -73845)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34297.gameObject);
								if (69779 - 151008 != -81229)
								{
									continue;
								}
								goto IL_183;
							}
						}
						UnityEngine.Object.Destroy(this.$self_$34297.gameObject);
						if (30847 - 294522 == -263674)
						{
							continue;
						}
						IL_183:
						this.YieldDefault(1);
						if (285875 - 291857 != -5981)
						{
							goto Block_12;
						}
						continue;
					default:
						if (192986 - 161757 != 31229)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34297.mChar.actionState == "dead")
					{
						if (120649 - 430160 != -309510)
						{
							goto Block_8;
						}
					}
					else
					{
						this.$myPosition$34294 = (Vector3)this.$nArray$34296[0];
						if (30931 - 516972 == -486041)
						{
							this.$myDirection$34295 = (Vector3)this.$nArray$34296[1];
							if (222099 - 334020 != -111920)
							{
								this.$self_$34297.transform.position = this.$myPosition$34294;
								if (266403 - 257712 == 8691)
								{
									this.$self_$34297.transform.LookAt(this.$myPosition$34294 + this.$myDirection$34295);
									if (212992 - 571251 == -358259)
									{
										this.$self_$34297.mChar.hp = 0;
										if (50811 - 360280 != -309468)
										{
											this.$self_$34297.mChar.actionState = "dead";
											if (43468 - 488162 == -444694)
											{
												this.$self_$34297.mChar.actionTime = Time.time;
												if (122526 - 569567 == -447041)
												{
													this.$self_$34297.mChar.myCommand = "none";
													if (256826 - 454393 != -197566)
													{
														this.$self_$34297.mChar.vMovement = Vector3.zero;
														if (277148 - 270289 != 6860)
														{
															this.$self_$34297.mChar.moveSpeed = (float)0;
															if (33348 - 36371 != -3022)
															{
																this.$self_$34297.animation.Rewind();
																if (93533 - 588327 == -494794)
																{
																	this.$self_$34297.animation.Play("destroy");
																	if (29834 - 495988 == -466154)
																	{
																		this.$self_$34297.animation.wrapMode = WrapMode.Once;
																		if (208796 - 15625 != 193172)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_8:
				Block_12:
				IL_3F1:
				return false;
			}

			// Token: 0x06005404 RID: 21508 RVA: 0x00A39810 File Offset: 0x00A37A10
			internal static bool FQ7YqX5sMBCrG8tnSer7()
			{
				return true;
			}

			// Token: 0x06005405 RID: 21509 RVA: 0x00A39814 File Offset: 0x00A37A14
			internal static bool jJ1cLw5sxBwsXdNpwiyg()
			{
				return false;
			}

			// Token: 0x04005D19 RID: 23833
			internal Vector3 $myPosition$34294;

			// Token: 0x04005D1A RID: 23834
			internal Vector3 $myDirection$34295;

			// Token: 0x04005D1B RID: 23835
			internal UnityScript.Lang.Array $nArray$34296;

			// Token: 0x04005D1C RID: 23836
			internal AutoGallonGun $self_$34297;
		}
	}
}
