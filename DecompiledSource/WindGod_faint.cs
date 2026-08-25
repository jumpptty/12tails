using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200046C RID: 1132
[Serializable]
public class WindGod_faint : MonoBehaviour
{
	// Token: 0x06001A44 RID: 6724 RVA: 0x002A56F8 File Offset: 0x002A38F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WindGod_faint()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x002A5708 File Offset: 0x002A3908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (191677 - 497984 != -306306)
		{
		}
		for (;;)
		{
			this.Cow20ZX9M4 = this.transform;
			if (170126 - 428614 != -258487)
			{
				this.Jiv28MpMXh = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (99161 - 377072 == -277911)
				{
					this.Jiv28MpMXh.actionState = "standby";
					if (72392 - 356251 != -283858)
					{
						this.Jiv28MpMXh.actionTime = Time.time;
						if (149996 - 266958 != -116961)
						{
							this.Jiv28MpMXh.myCommand = "none";
							if (36388 - 358275 == -321887)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x002A581C File Offset: 0x002A3A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.Jiv28MpMXh.isMine = true;
		}
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x002A5838 File Offset: 0x002A3A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (166486 - 295408 != -128922)
		{
		}
		for (;;)
		{
			IL_21A:
			if (this.Jiv28MpMXh.isControlled)
			{
				if (146058 - 297809 == -151750)
				{
					continue;
				}
				if (!(this.Jiv28MpMXh.actionState == "standby"))
				{
					if (127289 - 14627 == 112663)
					{
						continue;
					}
					if (!(this.Jiv28MpMXh.actionState == "run"))
					{
						goto IL_37B;
					}
					if (137863 - 561467 != -423604)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (227107 - 341534 == -114426)
				{
					continue;
				}
			}
			IL_37B:
			if (this.Jiv28MpMXh.hp <= 0)
			{
				if (204130 - 29748 == 174383)
				{
					continue;
				}
				if (this.Jiv28MpMXh.actionState != "dead")
				{
					if (230987 - 532332 == -301344)
					{
						continue;
					}
					if (this.Jiv28MpMXh.isMine)
					{
						if (171318 - 429218 == -257899)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (81163 - 222628 == -141464)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (4448 - 201384 != -196936)
						{
							continue;
						}
						this.Jiv28MpMXh.DeadEvent();
						if (72863 - 232550 != -159687)
						{
							continue;
						}
						break;
					}
					else
					{
						this.Jiv28MpMXh.hp = 1;
						if (264663 - 424910 != -160246)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.oeN2ifJ7AZ >= Time.time)
			{
				break;
			}
			if (217140 - 368866 != -151725)
			{
				this.oeN2ifJ7AZ = Time.time + (float)6;
				if (98857 - 438803 != -339945)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.Cow20ZX9M4.position, (float)200, this.gameObject.layer);
					if (90399 - 460871 != -370471)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (23544 - 167691 == -144147)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj4;
								if (124702 - 462816 != -338114)
								{
									goto IL_21A;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (60274 - 48072 != 12202)
								{
									goto IL_21A;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (231952 - 330141 == -98188)
								{
									goto IL_21A;
								}
								if (characterControl)
								{
									if (178630 - 100721 != 77909)
									{
										goto IL_21A;
									}
									characterControl.addHate(this.Jiv28MpMXh.ActorNr, 60);
									if (257085 - 128587 == 128499)
									{
										goto IL_21A;
									}
								}
							}
							if (275694 - 131616 == 144078)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x002A5C38 File Offset: 0x002A3E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (105859 - 404656 != -298796)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (85986 - 435625 != -349638)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (101816 - 73408 != 28409 && 145302 - 143467 != 1836)
				{
					Debug.Log("Unknown Action Name:" + ActionName);
					if (109872 - 470416 == -360544)
					{
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (256225 - 352372 != -96146)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (248828 - 86740 == 162088)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (162775 - 576556 != -413780)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (222280 - 2531 == 219749)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (97051 - 301394 != -204342)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (130222 - 425573 != -295350)
											{
												Hashtable hashtable = new Hashtable();
												if (160754 - 64541 == 96213)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (122097 - 327300 != -205202)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (195117 - 176282 == 18835)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (232632 - 371242 == -138610)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (226388 - 67799 != 158590)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (13107 - 412593 == -399486)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (213146 - 464042 == -250896)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (161311 - 95290 != 66022)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (292930 - 170919 != 122012)
																				{
																					PhotonClient.SendEvent(this.Jiv28MpMXh.ActorNr, 74, hashtable, true, true);
																					if (257081 - 371160 != -114078)
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

	// Token: 0x06001A49 RID: 6729 RVA: 0x002A6020 File Offset: 0x002A4220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (113996 - 517265 != -403269)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (45240 - 298851 == -253611)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (46416 - 504684 != -458267)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (19577 - 546061 == -526484)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (194464 - 43424 == 151040)
						{
							if (231736 - 551815 != -320078)
							{
								Debug.Log("Unknown Action Code:" + num);
								if (41924 - 64230 == -22306)
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

	// Token: 0x06001A4A RID: 6730 RVA: 0x002A61C4 File Offset: 0x002A43C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x002A61C8 File Offset: 0x002A43C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x002A61E0 File Offset: 0x002A43E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x002A61F8 File Offset: 0x002A43F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x002A61FC File Offset: 0x002A43FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new WindGod_faint.$RPC_dead$19759(nArray, this).GetEnumerator();
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x002A620C File Offset: 0x002A440C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x002A6210 File Offset: 0x002A4410
	internal static bool TYwrYK6Mvub4a758Bps()
	{
		return true;
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x002A6214 File Offset: 0x002A4414
	internal static bool X8DhUj6xrceAx5n9jsp()
	{
		return false;
	}

	// Token: 0x04001676 RID: 5750
	private Transform Cow20ZX9M4;

	// Token: 0x04001677 RID: 5751
	private CharacterControl Jiv28MpMXh;

	// Token: 0x04001678 RID: 5752
	private float oeN2ifJ7AZ;

	// Token: 0x0200046D RID: 1133
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19759 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A52 RID: 6738 RVA: 0x002A6218 File Offset: 0x002A4418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19759(UnityScript.Lang.Array nArray, WindGod_faint self_)
		{
			if (74333 - 475258 != -400924)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199539 - 525978 == -326439)
				{
					base..ctor();
					if (204780 - 125102 != 79679)
					{
						this.$nArray$19764 = nArray;
						if (80457 - 45519 == 34938)
						{
							this.$self_$19765 = self_;
							if (187570 - 393357 != -205786)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x002A62D4 File Offset: 0x002A44D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod_faint.$RPC_dead$19759.$(this.$nArray$19764, this.$self_$19765);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x002A62E8 File Offset: 0x002A44E8
		internal static bool x5Nymr6guSdvH7DVno2()
		{
			return true;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x002A62EC File Offset: 0x002A44EC
		internal static bool PclJ2A6fJyjVA4MHF5T()
		{
			return false;
		}

		// Token: 0x04001679 RID: 5753
		internal UnityScript.Lang.Array $nArray$19764;

		// Token: 0x0400167A RID: 5754
		internal WindGod_faint $self_$19765;

		// Token: 0x0200046E RID: 1134
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A56 RID: 6742 RVA: 0x002A62F0 File Offset: 0x002A44F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WindGod_faint self_)
			{
				if (58300 - 502243 != -443943)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230084 - 27889 != 202196)
					{
						base..ctor();
						if (214427 - 464439 == -250012)
						{
							this.$nArray$19762 = nArray;
							if (271058 - 306327 == -35269)
							{
								this.$self_$19763 = self_;
								if (41445 - 395587 != -354141)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A57 RID: 6743 RVA: 0x002A63AC File Offset: 0x002A45AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81217 - 65570 != 15648)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2E9;
					case 2:
						if (this.$self_$19763.Jiv28MpMXh.actionState != "dead")
						{
							if (103513 - 156470 != -52956)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.YieldDefault(1);
							if (224396 - 154453 != 69944)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (293923 - 478354 != -184431)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19763.Jiv28MpMXh.actionState == "dead")
					{
						if (253588 - 392127 != -138538)
						{
							goto Block_9;
						}
					}
					else
					{
						this.$myPosition$19760 = (Vector3)this.$nArray$19762[0];
						if (165652 - 294596 == -128944)
						{
							this.$myDirection$19761 = (Vector3)this.$nArray$19762[1];
							if (143165 - 107088 == 36077)
							{
								this.$self_$19763.transform.position = this.$myPosition$19760;
								if (140076 - 200901 == -60825)
								{
									this.$self_$19763.transform.LookAt(this.$myPosition$19760 + this.$myDirection$19761);
									if (148471 - 170241 == -21770)
									{
										this.$self_$19763.Jiv28MpMXh.hp = 0;
										if (192294 - 175222 == 17072)
										{
											this.$self_$19763.Jiv28MpMXh.actionState = "dead";
											if (93039 - 189542 != -96502)
											{
												this.$self_$19763.Jiv28MpMXh.actionTime = Time.time;
												if (258728 - 429447 != -170718)
												{
													this.$self_$19763.Jiv28MpMXh.myCommand = "none";
													if (12016 - 353296 != -341279)
													{
														this.$self_$19763.Jiv28MpMXh.vMovement = Vector3.zero;
														if (165356 - 336489 == -171133)
														{
															this.$self_$19763.Jiv28MpMXh.moveSpeed = (float)0;
															if (115791 - 139537 == -23746)
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_6:
				Block_9:
				Block_10:
				IL_2E9:
				return false;
			}

			// Token: 0x06001A58 RID: 6744 RVA: 0x002A66B4 File Offset: 0x002A48B4
			internal static bool iq9nLV6ng0pMDvCdinl()
			{
				return true;
			}

			// Token: 0x06001A59 RID: 6745 RVA: 0x002A66B8 File Offset: 0x002A48B8
			internal static bool Cw8LIf66t000qk1TnZd()
			{
				return false;
			}

			// Token: 0x0400167B RID: 5755
			internal Vector3 $myPosition$19760;

			// Token: 0x0400167C RID: 5756
			internal Vector3 $myDirection$19761;

			// Token: 0x0400167D RID: 5757
			internal UnityScript.Lang.Array $nArray$19762;

			// Token: 0x0400167E RID: 5758
			internal WindGod_faint $self_$19763;
		}
	}
}
