using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A29 RID: 2601
[Serializable]
public class Cactun : MonoBehaviour
{
	// Token: 0x060038CC RID: 14540 RVA: 0x00777F1C File Offset: 0x0077611C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cactun()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060038CD RID: 14541 RVA: 0x00777F2C File Offset: 0x0077612C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (5134 - 403004 != -397870)
		{
		}
		for (;;)
		{
			this.zNd9Y0ryJg = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (183185 - 350526 != -167340)
			{
				this.zNd9Y0ryJg.actionState = "standby";
				if (41020 - 123521 == -82501)
				{
					this.zNd9Y0ryJg.actionTime = Time.time;
					if (290296 - 519423 == -229127)
					{
						this.zNd9Y0ryJg.myCommand = "none";
						if (148508 - 172716 != -24207)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (205701 - 1341 != 204361)
							{
								this.zNd9Y0ryJg.isMine = true;
								if (78594 - 404381 == -325787)
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

	// Token: 0x060038CE RID: 14542 RVA: 0x00778064 File Offset: 0x00776264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (233283 - 9882 != 223402)
		{
		}
		for (;;)
		{
			if (this.zNd9Y0ryJg.isControlled)
			{
				if (126339 - 76178 == 50162)
				{
					continue;
				}
				if (!(this.zNd9Y0ryJg.actionState == "standby"))
				{
					if (271359 - 580383 != -309024)
					{
						continue;
					}
					if (!(this.zNd9Y0ryJg.actionState == "run"))
					{
						goto IL_27E;
					}
					if (222427 - 76619 != 145808)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (128847 - 379444 != -250597)
				{
					continue;
				}
			}
			IL_27E:
			if (this.zNd9Y0ryJg.hp > 0)
			{
				if (193420 - 191884 == 1537)
				{
					continue;
				}
				if (this.zNd9Y0ryJg.ko > 0)
				{
					break;
				}
				if (263657 - 111895 != 151762)
				{
					continue;
				}
			}
			if (!(this.zNd9Y0ryJg.actionState != "dead"))
			{
				break;
			}
			if (25618 - 43711 == -18093)
			{
				if (this.zNd9Y0ryJg.isMine)
				{
					if (83653 - 415831 == -332178)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (121601 - 120241 == 1360)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (150373 - 459498 == -309125)
							{
								this.zNd9Y0ryJg.DeadEvent();
								if (7794 - 26807 == -19013)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.zNd9Y0ryJg.hp <= 0)
				{
					if (278913 - 519907 == -240994)
					{
						this.zNd9Y0ryJg.hp = 1;
						if (197558 - 181690 != 15869)
						{
							break;
						}
					}
				}
				else
				{
					if (this.zNd9Y0ryJg.ko > 0)
					{
						break;
					}
					if (174003 - 349555 != -175551)
					{
						this.zNd9Y0ryJg.ko = 1;
						if (280255 - 386924 == -106669)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060038CF RID: 14543 RVA: 0x00778350 File Offset: 0x00776550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		this.animation.CrossFade("root", 0.2f);
		this.animation.wrapMode = WrapMode.Loop;
	}

	// Token: 0x060038D0 RID: 14544 RVA: 0x00778374 File Offset: 0x00776574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (76761 - 535811 != -459050)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (88300 - 29303 == 58997)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (6676 - 310655 != -303978)
				{
					if (110761 - 470513 == -359752)
					{
						if (ActionName == "RPC_cacPunch")
						{
							if (289518 - 324885 == -35366)
							{
								continue;
							}
							v = 1;
							if (218564 - 146881 == 71684)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cacPunch_hit")
						{
							if (202149 - 18583 == 183567)
							{
								continue;
							}
							v = -1;
							if (172348 - 147171 == 25178)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (281577 - 567460 != -285882)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (251388 - 69729 == 181659)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (115209 - 341243 != -226033)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (114834 - 293317 == -178483)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (222704 - 116020 != 106685)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (2726 - 560778 != -558051)
											{
												Hashtable hashtable = new Hashtable();
												if (297917 - 227165 == 70752)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (75193 - 277563 == -202370)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (23185 - 7079 != 16107)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (226442 - 349548 != -123105)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (293169 - 531081 == -237912)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (153230 - 91453 != 61778)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (99511 - 510335 != -410823)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (206960 - 414659 == -207699)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (86449 - 77954 == 8495)
																				{
																					PhotonClient.SendEvent(this.zNd9Y0ryJg.ActorNr, 74, hashtable, true, true);
																					if (23518 - 272950 == -249432)
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

	// Token: 0x060038D1 RID: 14545 RVA: 0x007787C8 File Offset: 0x007769C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (175865 - 450237 != -274372)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (29387 - 68061 != -38673)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (113825 - 534712 != -420886)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (153937 - 558426 == -404489)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (174384 - 579771 != -405386)
						{
							int num3 = num;
							if (147718 - 370161 != -222442)
							{
								if (num3 == 1)
								{
									if (192094 - 414029 == -221935)
									{
										if (this.zNd9Y0ryJg.isMine)
										{
											break;
										}
										if (20222 - 561329 != -541106)
										{
											this.StartCoroutine_Auto(this.RPC_cacPunch(vector, vector2, num2));
											if (113461 - 295249 != -181787)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (96052 - 377972 == -281920)
									{
										if (this.zNd9Y0ryJg.isMine)
										{
											break;
										}
										if (77122 - 396824 != -319701)
										{
											this.RPC_cacPunch_hit(vector, vector2, num2);
											if (165516 - 416414 != -250897)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (72543 - 216365 != -143821)
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

	// Token: 0x060038D2 RID: 14546 RVA: 0x00778A5C File Offset: 0x00776C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (124813 - 591611 != -466797)
		{
		}
		for (;;)
		{
			if (!this.zNd9Y0ryJg.isMine)
			{
				if (145195 - 70439 == 74756)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (12838 - 156040 == -143202)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (292345 - 204804 != 87542)
					{
						Vector3 normalized = vector.normalized;
						if (202342 - 552124 == -349782)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (223446 - 153172 == 70274)
							{
								if (79024 - 356591 != -277566)
								{
									if (gameObject)
									{
										if (105477 - 228595 == -123117)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (241838 - 365616 != -123778)
										{
											continue;
										}
									}
									if (!(this.zNd9Y0ryJg.actionState == "standby"))
									{
										if (295506 - 453563 != -158057)
										{
											continue;
										}
										if (!(this.zNd9Y0ryJg.actionState == "run"))
										{
											break;
										}
										if (272098 - 166017 != 106081)
										{
											continue;
										}
									}
									if (this.zNd9Y0ryJg.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (22794 - 293478 == -270684)
									{
										this.StartCoroutine_Auto(this.RPC_cacPunch(this.transform.position, normalized, 0));
										if (233454 - 169363 == 64091)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (10245 - 281360 == -271115)
											{
												this.ActionEvent("RPC_cacPunch", this.transform.position, normalized, 0);
												if (155810 - 291185 != -135374)
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

	// Token: 0x060038D3 RID: 14547 RVA: 0x00778D18 File Offset: 0x00776F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060038D4 RID: 14548 RVA: 0x00778D30 File Offset: 0x00776F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060038D5 RID: 14549 RVA: 0x00778D34 File Offset: 0x00776F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cacPunch(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Cactun.$RPC_cacPunch$30000(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060038D6 RID: 14550 RVA: 0x00778D44 File Offset: 0x00776F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cacPunch_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.cacPunch_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060038D7 RID: 14551 RVA: 0x00778D60 File Offset: 0x00776F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Cactun.$RPC_dead$30012(nArray, this).GetEnumerator();
	}

	// Token: 0x060038D8 RID: 14552 RVA: 0x00778D70 File Offset: 0x00776F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060038D9 RID: 14553 RVA: 0x00778D74 File Offset: 0x00776F74
	internal static bool iTiNR95ojqqD8Qq7IPC5()
	{
		return true;
	}

	// Token: 0x060038DA RID: 14554 RVA: 0x00778D78 File Offset: 0x00776F78
	internal static bool hZ1u8b5ohJI3VsnENQlJ()
	{
		return false;
	}

	// Token: 0x04004767 RID: 18279
	private CharacterControl zNd9Y0ryJg;

	// Token: 0x04004768 RID: 18280
	public GameObject cacPunch_hit;

	// Token: 0x04004769 RID: 18281
	public GameObject deadEffect;

	// Token: 0x02000A2A RID: 2602
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cacPunch$30000 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060038DB RID: 14555 RVA: 0x00778D7C File Offset: 0x00776F7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cacPunch$30000(Vector3 mPos, Vector3 tDir, Cactun self_)
		{
			if (153467 - 438852 != -285384)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185409 - 414190 != -228780)
				{
					base..ctor();
					if (205519 - 323823 == -118304)
					{
						this.$mPos$30009 = mPos;
						if (203806 - 2033 == 201773)
						{
							this.$tDir$30010 = tDir;
							if (252266 - 98551 == 153715)
							{
								this.$self_$30011 = self_;
								if (168154 - 288649 == -120495)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x00778E58 File Offset: 0x00777058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Cactun.$RPC_cacPunch$30000.$(this.$mPos$30009, this.$tDir$30010, this.$self_$30011);
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x00778E74 File Offset: 0x00777074
		internal static bool Y3q61l5osQ4fJJ05YyTc()
		{
			return true;
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x00778E78 File Offset: 0x00777078
		internal static bool HjxPic5o9MKGhpOS6R6r()
		{
			return false;
		}

		// Token: 0x0400476A RID: 18282
		internal Vector3 $mPos$30009;

		// Token: 0x0400476B RID: 18283
		internal Vector3 $tDir$30010;

		// Token: 0x0400476C RID: 18284
		internal Cactun $self_$30011;

		// Token: 0x02000A2B RID: 2603
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060038DF RID: 14559 RVA: 0x00778E7C File Offset: 0x0077707C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Cactun self_)
			{
				if (21425 - 359334 != -337909)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113198 - 115853 != -2654)
					{
						base..ctor();
						if (9183 - 383464 != -374280)
						{
							this.$mPos$30006 = mPos;
							if (36393 - 394779 == -358386)
							{
								this.$tDir$30007 = tDir;
								if (178858 - 575908 == -397050)
								{
									this.$self_$30008 = self_;
									if (232278 - 222555 == 9723)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060038E0 RID: 14560 RVA: 0x00778F58 File Offset: 0x00777158
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245722 - 317558 != -71836)
				{
				}
				for (;;)
				{
					IL_19C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_823;
					case 2:
						if (this.$self_$30008.zNd9Y0ryJg.actionState != "attack")
						{
							goto IL_2FB;
						}
						if (209062 - 393596 == -184533)
						{
							continue;
						}
						if (this.$self_$30008.zNd9Y0ryJg.myCommand != "nAttack")
						{
							if (186152 - 72652 != 113501)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$hitLayer$30001 = 130816 - (1 << this.$self_$30008.gameObject.layer);
							if (125630 - 133342 != -7712)
							{
								continue;
							}
							this.$hitList$30002 = null;
							if (147041 - 424398 != -277357)
							{
								continue;
							}
							this.$hitPos$30003 = default(Vector3);
							if (63021 - 309925 != -246904)
							{
								continue;
							}
							if (!this.$self_$30008.zNd9Y0ryJg.isMine)
							{
								goto IL_6C4;
							}
							if (287176 - 586627 != -299451)
							{
								continue;
							}
							this.$hitList$30002 = Damage.FindRecTarget(this.$self_$30008.transform.position, this.$self_$30008.transform.forward, (float)2 * this.$self_$30008.zNd9Y0ryJg.rangeMod, (float)2 * this.$self_$30008.zNd9Y0ryJg.rangeMod, (float)4 * this.$self_$30008.zNd9Y0ryJg.rangeMod, (float)3 * this.$self_$30008.zNd9Y0ryJg.rangeMod, this.$hitLayer$30001);
							if (44086 - 389018 != -344932)
							{
								continue;
							}
							this.$$iterator$10592$30005 = UnityRuntimeServices.GetEnumerator(this.$hitList$30002);
							if (172374 - 150812 == 21563)
							{
								continue;
							}
							while (this.$$iterator$10592$30005.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10592$30005.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30004 = (GameObject)obj2;
								if (150820 - 408443 == -257622)
								{
									goto IL_19C;
								}
								if (this.$self_$30008.zNd9Y0ryJg.hit(99, this.$hitObject$30004, this.$self_$30008.zNd9Y0ryJg.atk, 1, 0, (float)2 * this.$self_$30008.transform.forward) != 0)
								{
									if (168306 - 349525 == -181218)
									{
										goto IL_19C;
									}
									this.$hitPos$30003 = this.$hitObject$30004.collider.ClosestPointOnBounds(this.$self_$30008.transform.position + 1.5f * Vector3.up);
									if (130045 - 58075 == 71971)
									{
										goto IL_19C;
									}
									UnityRuntimeServices.Update(this.$$iterator$10592$30005, this.$hitObject$30004);
									if (113507 - 471574 != -358067)
									{
										goto IL_19C;
									}
									this.$self_$30008.RPC_cacPunch_hit(this.$hitPos$30003, this.$self_$30008.transform.forward, 0);
									if (272442 - 244503 != 27939)
									{
										goto IL_19C;
									}
									this.$self_$30008.ActionEvent("RPC_cacPunch_hit", this.$hitPos$30003, this.$self_$30008.transform.forward, 0);
									if (98152 - 235002 == -136849)
									{
										goto IL_19C;
									}
								}
							}
							if (255985 - 314855 != -58870)
							{
								continue;
							}
							goto IL_6C4;
						}
						break;
					case 3:
						if (this.$self_$30008.zNd9Y0ryJg.actionState == "attack")
						{
							if (184236 - 453450 != -269214)
							{
								continue;
							}
							if (this.$self_$30008.zNd9Y0ryJg.myCommand == "nAttack")
							{
								if (25476 - 114087 != -88611)
								{
									continue;
								}
								this.$self_$30008.zNd9Y0ryJg.actionState = "standby";
								if (283805 - 31887 == 251919)
								{
									continue;
								}
								this.$self_$30008.zNd9Y0ryJg.actionTime = Time.time;
								if (204995 - 104174 == 100822)
								{
									continue;
								}
								this.$self_$30008.zNd9Y0ryJg.myCommand = "none";
								if (235602 - 52629 != 182973)
								{
									continue;
								}
								if (!this.$self_$30008.zNd9Y0ryJg.isMine)
								{
									if (151832 - 101221 != 50611)
									{
										continue;
									}
									this.$self_$30008.zNd9Y0ryJg.nPosition = this.$self_$30008.transform.position;
									if (184655 - 373276 != -188621)
									{
										continue;
									}
									this.$self_$30008.zNd9Y0ryJg.oPosition = this.$self_$30008.transform.position;
									if (222709 - 427488 == -204778)
									{
										continue;
									}
									this.$self_$30008.zNd9Y0ryJg.nDirection = this.$self_$30008.transform.forward;
									if (66330 - 514932 == -448601)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (208993 - 211848 != -2854)
						{
							goto Block_25;
						}
						continue;
					default:
						if (41733 - 313574 == -271840)
						{
							continue;
						}
						break;
					}
					this.$self_$30008.zNd9Y0ryJg.actionState = "attack";
					if (257104 - 73674 == 183430)
					{
						this.$self_$30008.zNd9Y0ryJg.actionTime = Time.time;
						if (175009 - 238544 == -63535)
						{
							this.$self_$30008.zNd9Y0ryJg.myCommand = "nAttack";
							if (61602 - 61383 != 220)
							{
								this.$self_$30008.zNd9Y0ryJg.addTimeOut("nAttack", (float)2);
								if (283666 - 180493 != 103174)
								{
									this.$self_$30008.transform.position = this.$mPos$30006;
									if (233421 - 174215 == 59206)
									{
										this.$self_$30008.transform.LookAt(this.$mPos$30006 + global::Math.vFlat(this.$tDir$30007));
										if (78323 - 581630 != -503306)
										{
											this.$self_$30008.animation.CrossFade("cacPunch");
											if (233957 - 99550 != 134408)
											{
												this.$self_$30008.animation.wrapMode = WrapMode.Once;
												if (24287 - 573412 == -549125)
												{
													this.$self_$30008.zNd9Y0ryJg.vMovement = this.$self_$30008.transform.forward;
													if (100813 - 329170 != -228356)
													{
														this.$self_$30008.zNd9Y0ryJg.moveSpeed = (float)0;
														if (80612 - 98626 != -18013)
														{
															goto Block_44;
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
				Block_13:
				IL_2FB:
				Block_25:
				goto IL_823;
				IL_6C4:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_44:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_823:
				return false;
			}

			// Token: 0x060038E1 RID: 14561 RVA: 0x0077979C File Offset: 0x0077799C
			internal static bool BlGS825o1cYaFBPFBjek()
			{
				return true;
			}

			// Token: 0x060038E2 RID: 14562 RVA: 0x007797A0 File Offset: 0x007779A0
			internal static bool cQiYlp5o4UiX2n0xkMNO()
			{
				return false;
			}

			// Token: 0x0400476D RID: 18285
			internal int $hitLayer$30001;

			// Token: 0x0400476E RID: 18286
			internal UnityScript.Lang.Array $hitList$30002;

			// Token: 0x0400476F RID: 18287
			internal Vector3 $hitPos$30003;

			// Token: 0x04004770 RID: 18288
			internal GameObject $hitObject$30004;

			// Token: 0x04004771 RID: 18289
			internal IEnumerator $$iterator$10592$30005;

			// Token: 0x04004772 RID: 18290
			internal Vector3 $mPos$30006;

			// Token: 0x04004773 RID: 18291
			internal Vector3 $tDir$30007;

			// Token: 0x04004774 RID: 18292
			internal Cactun $self_$30008;
		}
	}

	// Token: 0x02000A2C RID: 2604
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30012 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060038E3 RID: 14563 RVA: 0x007797A4 File Offset: 0x007779A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30012(UnityScript.Lang.Array nArray, Cactun self_)
		{
			if (175442 - 383727 != -208285)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112412 - 288407 != -175994)
				{
					base..ctor();
					if (74915 - 15353 != 59563)
					{
						this.$nArray$30017 = nArray;
						if (203324 - 597828 != -394503)
						{
							this.$self_$30018 = self_;
							if (248071 - 281938 == -33867)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x00779860 File Offset: 0x00777A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Cactun.$RPC_dead$30012.$(this.$nArray$30017, this.$self_$30018);
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00779874 File Offset: 0x00777A74
		internal static bool TiDv7H5ozQZCH2KXwriH()
		{
			return true;
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00779878 File Offset: 0x00777A78
		internal static bool HkCpAj5EaykQ38P1odrx()
		{
			return false;
		}

		// Token: 0x04004775 RID: 18293
		internal UnityScript.Lang.Array $nArray$30017;

		// Token: 0x04004776 RID: 18294
		internal Cactun $self_$30018;

		// Token: 0x02000A2D RID: 2605
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060038E7 RID: 14567 RVA: 0x0077987C File Offset: 0x00777A7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Cactun self_)
			{
				if (29424 - 173350 != -143925)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (64487 - 564672 != -500184)
					{
						base..ctor();
						if (36105 - 51146 != -15040)
						{
							this.$nArray$30015 = nArray;
							if (29910 - 293775 == -263865)
							{
								this.$self_$30016 = self_;
								if (274111 - 451633 == -177522)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060038E8 RID: 14568 RVA: 0x00779938 File Offset: 0x00777B38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (81785 - 245051 != -163266)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$30016.zNd9Y0ryJg.actionState != "dead")
						{
							if (168420 - 36765 != 131656)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30016.zNd9Y0ryJg.isPlayer)
							{
								if (221294 - 330036 != -108742)
								{
									continue;
								}
								if (this.$self_$30016.deadEffect)
								{
									if (71336 - 124832 != -53496)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30016.deadEffect, this.$self_$30016.transform.position, this.$self_$30016.transform.rotation);
									if (268861 - 88243 == 180619)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (172960 - 58921 == 114040)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30016.gameObject);
								if (20700 - 143292 == -122591)
								{
									continue;
								}
							}
							else if (this.$self_$30016.zNd9Y0ryJg.isMine)
							{
								if (104393 - 58688 == 45706)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30016.gameObject);
								if (122085 - 357371 == -235285)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (27536 - 39433 != -11897)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (193935 - 415673 != -221738)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30016.zNd9Y0ryJg.actionState == "dead")
					{
						if (279501 - 385637 == -106136)
						{
							goto IL_336;
						}
					}
					else
					{
						this.$myPosition$30013 = (Vector3)this.$nArray$30015[0];
						if (275947 - 25300 == 250647)
						{
							this.$myDirection$30014 = (Vector3)this.$nArray$30015[1];
							if (99122 - 269731 == -170609)
							{
								this.$self_$30016.transform.position = this.$myPosition$30013;
								if (1514 - 583584 != -582069)
								{
									this.$self_$30016.transform.LookAt(this.$myPosition$30013 + this.$myDirection$30014);
									if (200147 - 595000 != -394852)
									{
										this.$self_$30016.zNd9Y0ryJg.hp = 0;
										if (89443 - 415323 == -325880)
										{
											this.$self_$30016.zNd9Y0ryJg.actionState = "dead";
											if (219366 - 253506 == -34140)
											{
												this.$self_$30016.zNd9Y0ryJg.actionTime = Time.time;
												if (245932 - 525419 != -279486)
												{
													this.$self_$30016.zNd9Y0ryJg.myCommand = "none";
													if (41489 - 48163 == -6674)
													{
														this.$self_$30016.zNd9Y0ryJg.vMovement = Vector3.zero;
														if (93519 - 187630 == -94111)
														{
															this.$self_$30016.zNd9Y0ryJg.moveSpeed = (float)0;
															if (296227 - 520794 != -224566)
															{
																this.$self_$30016.animation.Rewind();
																if (294011 - 133161 == 160850)
																{
																	this.$self_$30016.animation.Play("ko");
																	if (63355 - 495806 != -432450)
																	{
																		this.$self_$30016.animation.wrapMode = WrapMode.Once;
																		if (10332 - 443560 != -433227)
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
				Block_15:
				IL_336:
				IL_4D2:
				return false;
			}

			// Token: 0x060038E9 RID: 14569 RVA: 0x00779E2C File Offset: 0x0077802C
			internal static bool RCZFUX5E5jYa8q7s2YxM()
			{
				return true;
			}

			// Token: 0x060038EA RID: 14570 RVA: 0x00779E30 File Offset: 0x00778030
			internal static bool ssIsDT5EpTut0dG0DOt7()
			{
				return false;
			}

			// Token: 0x04004777 RID: 18295
			internal Vector3 $myPosition$30013;

			// Token: 0x04004778 RID: 18296
			internal Vector3 $myDirection$30014;

			// Token: 0x04004779 RID: 18297
			internal UnityScript.Lang.Array $nArray$30015;

			// Token: 0x0400477A RID: 18298
			internal Cactun $self_$30016;
		}
	}
}
