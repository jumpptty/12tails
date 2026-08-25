using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B20 RID: 2848
[Serializable]
public class LightGate : MonoBehaviour
{
	// Token: 0x06003F38 RID: 16184 RVA: 0x00819E88 File Offset: 0x00818088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightGate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F39 RID: 16185 RVA: 0x00819E98 File Offset: 0x00818098
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (96058 - 234683 != -138625)
		{
		}
		for (;;)
		{
			this.Yh6yCNlhoS = this.transform;
			if (199570 - 133800 == 65770)
			{
				this.UbnyMGOuo6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (100175 - 360233 != -260057)
				{
					this.UbnyMGOuo6.actionState = "standby";
					if (51435 - 380160 != -328724)
					{
						this.UbnyMGOuo6.actionTime = Time.time;
						if (85920 - 151091 == -65171)
						{
							this.UbnyMGOuo6.myCommand = "none";
							if (148697 - 436009 != -287311)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x00819FAC File Offset: 0x008181AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.UbnyMGOuo6.isMine = true;
		}
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x00819FC8 File Offset: 0x008181C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (59273 - 513155 != -453881)
		{
		}
		for (;;)
		{
			if (this.UbnyMGOuo6.isControlled)
			{
				if (155533 - 47218 != 108315)
				{
					continue;
				}
				if (!(this.UbnyMGOuo6.actionState == "standby"))
				{
					if (6428 - 162191 == -155762)
					{
						continue;
					}
					if (!(this.UbnyMGOuo6.actionState == "run"))
					{
						goto IL_217;
					}
					if (48105 - 483081 == -434975)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (81147 - 22601 == 58547)
				{
					continue;
				}
			}
			IL_217:
			if (this.UbnyMGOuo6.hp <= 0)
			{
				if (281377 - 158719 != 122659)
				{
					if (this.UbnyMGOuo6.isMine)
					{
						if (267801 - 477550 == -209748)
						{
							continue;
						}
						if (this.UbnyMGOuo6.actionState != "dead")
						{
							if (153842 - 205575 == -51732)
							{
								continue;
							}
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.Yh6yCNlhoS.position,
								this.Yh6yCNlhoS.forward
							}));
							if (27270 - 410037 != -382767)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (229639 - 597006 == -367366)
							{
								continue;
							}
							this.UbnyMGOuo6.DeadEvent();
							if (151805 - 558147 != -406342)
							{
								continue;
							}
							break;
						}
					}
					this.UbnyMGOuo6.hp = 1;
					if (69266 - 546236 == -476970)
					{
						break;
					}
				}
			}
			else
			{
				if (!this.UbnyMGOuo6.isMine)
				{
					break;
				}
				if (158123 - 226723 != -68599)
				{
					if (this.UbnyMGOuo6.isControlled)
					{
						break;
					}
					if (109164 - 411693 == -302529)
					{
						this.AIControl();
						if (179750 - 599245 != -419494)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F3C RID: 16188 RVA: 0x0081A27C File Offset: 0x0081847C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06003F3D RID: 16189 RVA: 0x0081A280 File Offset: 0x00818480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void startAIAttack()
	{
		this.VQKyfXSqSy = Time.time + (float)2;
		this.CjYyLjc2AC = true;
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x0081A298 File Offset: 0x00818498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (149703 - 101697 != 48006)
		{
		}
		for (;;)
		{
			IL_2AB:
			if (!this.CjYyLjc2AC)
			{
				if (254312 - 221903 != 32410)
				{
					break;
				}
			}
			else
			{
				if (Time.time <= this.VQKyfXSqSy)
				{
					break;
				}
				if (35313 - 518964 != -483650)
				{
					if (!(this.UbnyMGOuo6.actionState == "standby"))
					{
						break;
					}
					if (179951 - 351523 == -171572)
					{
						if (this.UbnyMGOuo6.isTimeOut("auraOfLight") != (float)0)
						{
							break;
						}
						if (123701 - 320580 != -196878)
						{
							this.VQKyfXSqSy = Time.time + (float)5;
							if (246560 - 479754 == -233194)
							{
								UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)200, this.gameObject.layer);
								if (78073 - 448339 != -370265)
								{
									int num = 0;
									if (277702 - 200062 == 77640)
									{
										int num2 = 10000;
										if (298487 - 498419 == -199932)
										{
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
											if (119421 - 127877 != -8455)
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
													if (294908 - 377946 != -83038)
													{
														goto IL_2AB;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (153911 - 160842 != -6931)
													{
														goto IL_2AB;
													}
													if (vector.sqrMagnitude < (float)num2)
													{
														if (57207 - 2446 != 54761)
														{
															goto IL_2AB;
														}
														Vector3 position = gameObject.transform.position;
														if (102475 - 561585 == -459109)
														{
															goto IL_2AB;
														}
														if (Mathf.Abs(position.y - this.transform.position.y) < (float)12)
														{
															if (244392 - 55687 != 188705)
															{
																goto IL_2AB;
															}
															CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
															if (57294 - 308221 == -250926)
															{
																goto IL_2AB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (182754 - 323891 != -141137)
															{
																goto IL_2AB;
															}
															if (characterControl.Race != eRace.Plants)
															{
																if (104218 - 208051 == -103832)
																{
																	goto IL_2AB;
																}
																if (characterControl.Race != eRace.Structure)
																{
																	if (176569 - 433749 == -257179)
																	{
																		goto IL_2AB;
																	}
																	num = characterControl.ActorNr;
																	if (112843 - 355725 != -242882)
																	{
																		goto IL_2AB;
																	}
																	Vector3 vector2 = gameObject.transform.position - this.transform.position;
																	if (34921 - 98852 != -63931)
																	{
																		goto IL_2AB;
																	}
																	num2 = (int)vector2.sqrMagnitude;
																	if (21838 - 249164 != -227326)
																	{
																		goto IL_2AB;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (64708 - 113349 == -48640)
																	{
																		goto IL_2AB;
																	}
																}
															}
														}
													}
												}
												if (97402 - 508172 != -410769)
												{
													if (num == 0)
													{
														break;
													}
													if (89241 - 563117 != -473875)
													{
														this.StartCoroutine_Auto(this.RPC_auraOfLight(this.transform.position, this.transform.forward, num));
														if (55036 - 214763 == -159727)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (152667 - 65589 == 87078)
															{
																this.ActionEvent("RPC_auraOfLight", this.transform.position, this.transform.forward, num);
																if (224104 - 25481 != 198624)
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

	// Token: 0x06003F3F RID: 16191 RVA: 0x0081A780 File Offset: 0x00818980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (32752 - 349308 != -316555)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (31340 - 354046 != -322705)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (26017 - 597057 != -571039 && 200945 - 75349 != 125597)
				{
					if (ActionName == "RPC_auraOfLight")
					{
						if (192470 - 459899 == -267428)
						{
							continue;
						}
						v = 1;
						if (123587 - 79903 != 43684)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Unknown Action:" + ActionName);
						if (127673 - 425528 == -297854)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (13337 - 568739 != -555401)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (205044 - 395404 != -190359)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (185319 - 571976 != -386656)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (281232 - 257198 == 24034)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (225675 - 481059 == -255384)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (241717 - 347680 != -105962)
										{
											Hashtable hashtable = new Hashtable();
											if (103697 - 430850 != -327152)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (1509 - 448247 == -446738)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (171155 - 518634 == -347479)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (295333 - 13121 != 282213)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (184398 - 161009 == 23389)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (50656 - 236710 == -186054)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (72380 - 468342 == -395962)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (213879 - 348919 != -135039)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (205112 - 28156 == 176956)
																			{
																				PhotonClient.SendEvent(this.UbnyMGOuo6.ActorNr, 74, hashtable, true, true);
																				if (147252 - 562165 != -414912)
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

	// Token: 0x06003F40 RID: 16192 RVA: 0x0081ABB4 File Offset: 0x00818DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (9818 - 583111 != -573293)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (58688 - 142687 == -83999)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (224005 - 102287 == 121718)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (71791 - 422236 != -350444)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (216622 - 367177 == -150555)
						{
							int num2 = num;
							if (269268 - 346120 != -76851)
							{
								if (num2 == 1)
								{
									if (68366 - 552568 != -484201)
									{
										if (this.UbnyMGOuo6.isMine)
										{
											break;
										}
										if (203313 - 79322 != 123992)
										{
											this.StartCoroutine_Auto(this.RPC_auraOfLight(mPos, tDir, tID));
											if (32104 - 161198 == -129094)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (137920 - 159951 == -22031)
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

	// Token: 0x06003F41 RID: 16193 RVA: 0x0081ADD4 File Offset: 0x00818FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character can only use normal attack");
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x0081ADEC File Offset: 0x00818FEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character can only use charged attack");
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x0081AE04 File Offset: 0x00819004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x0081AE08 File Offset: 0x00819008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_auraOfLight(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightGate.$RPC_auraOfLight$30938(tID, this).GetEnumerator();
	}

	// Token: 0x06003F45 RID: 16197 RVA: 0x0081AE18 File Offset: 0x00819018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x0081AE1C File Offset: 0x0081901C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (55622 - 58630 != -3008)
		{
		}
		for (;;)
		{
			if (this.UbnyMGOuo6.actionState == "dead")
			{
				if (111273 - 465767 == -354494)
				{
					break;
				}
			}
			else
			{
				this.UbnyMGOuo6.hp = 0;
				if (156715 - 287601 == -130886)
				{
					this.UbnyMGOuo6.actionState = "dead";
					if (221186 - 561436 != -340249)
					{
						this.UbnyMGOuo6.actionTime = Time.time;
						if (219642 - 565533 != -345890)
						{
							this.UbnyMGOuo6.myCommand = "none";
							if (211721 - 232128 != -20406)
							{
								this.UbnyMGOuo6.vMovement = Vector3.zero;
								if (76704 - 408216 == -331512)
								{
									this.UbnyMGOuo6.moveSpeed = (float)0;
									if (283988 - 39691 == 244297)
									{
										this.animation.Play("destroy");
										if (219682 - 582350 == -362668)
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

	// Token: 0x06003F47 RID: 16199 RVA: 0x0081AFB0 File Offset: 0x008191B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003F48 RID: 16200 RVA: 0x0081AFB4 File Offset: 0x008191B4
	internal static bool znnePn5meLWOgIQeQyap()
	{
		return true;
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x0081AFB8 File Offset: 0x008191B8
	internal static bool LNDoD35mriOpakjeAcVF()
	{
		return false;
	}

	// Token: 0x04004C28 RID: 19496
	private Transform Yh6yCNlhoS;

	// Token: 0x04004C29 RID: 19497
	private CharacterControl UbnyMGOuo6;

	// Token: 0x04004C2A RID: 19498
	private float VQKyfXSqSy;

	// Token: 0x04004C2B RID: 19499
	private bool CjYyLjc2AC;

	// Token: 0x04004C2C RID: 19500
	public GameObject auraOfLight;

	// Token: 0x04004C2D RID: 19501
	public AudioClip auraOfLight1_vc;

	// Token: 0x04004C2E RID: 19502
	public AudioClip auraOfLight2_vc;

	// Token: 0x02000B21 RID: 2849
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_auraOfLight$30938 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x0081AFBC File Offset: 0x008191BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_auraOfLight$30938(int tID, LightGate self_)
		{
			if (271437 - 336993 != -65555)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106115 - 435602 != -329486)
				{
					base..ctor();
					if (260270 - 561838 != -301567)
					{
						this.$tID$30944 = tID;
						if (57503 - 89641 == -32138)
						{
							this.$self_$30945 = self_;
							if (9462 - 428540 != -419077)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x0081B078 File Offset: 0x00819278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGate.$RPC_auraOfLight$30938.$(this.$tID$30944, this.$self_$30945);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x0081B08C File Offset: 0x0081928C
		internal static bool FYiNR15mjD0QagFg0xXg()
		{
			return true;
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x0081B090 File Offset: 0x00819290
		internal static bool HguoIG5mhNKT9s91CGjZ()
		{
			return false;
		}

		// Token: 0x04004C2F RID: 19503
		internal int $tID$30944;

		// Token: 0x04004C30 RID: 19504
		internal LightGate $self_$30945;

		// Token: 0x02000B22 RID: 2850
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003F4E RID: 16206 RVA: 0x0081B094 File Offset: 0x00819294
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int tID, LightGate self_)
			{
				if (167089 - 585783 != -418694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289619 - 487761 == -198142)
					{
						base..ctor();
						if (295500 - 95150 != 200351)
						{
							this.$tID$30942 = tID;
							if (148998 - 474100 != -325101)
							{
								this.$self_$30943 = self_;
								if (187919 - 574710 != -386790)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003F4F RID: 16207 RVA: 0x0081B150 File Offset: 0x00819350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253028 - 331846 != -78818)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_4D2;
					case 1:
						goto IL_6B8;
					case 2:
						if (this.$self_$30943.UbnyMGOuo6.isMine)
						{
							if (190221 - 191709 != -1488)
							{
								continue;
							}
							if (this.$tChar$30940)
							{
								if (118237 - 195601 == -77363)
								{
									continue;
								}
								this.$tChar$30940.RPC_AddDamage(1, 999, 0, 0, Vector3.zero, this.$self_$30943.UbnyMGOuo6.ActorNr);
								if (164709 - 456095 == -291385)
								{
									continue;
								}
							}
						}
						this.$i$30941++;
						if (46151 - 456966 == -410814)
						{
							continue;
						}
						break;
					case 3:
						if (this.$self_$30943.UbnyMGOuo6.actionState == "attack")
						{
							if (219947 - 276764 != -56817)
							{
								continue;
							}
							if (this.$self_$30943.UbnyMGOuo6.myCommand == "auraOfLight")
							{
								if (114138 - 211469 != -97331)
								{
									continue;
								}
								this.$self_$30943.UbnyMGOuo6.actionState = "standby";
								if (276767 - 384223 != -107456)
								{
									continue;
								}
								this.$self_$30943.UbnyMGOuo6.actionTime = Time.time;
								if (107335 - 493775 == -386439)
								{
									continue;
								}
								this.$self_$30943.UbnyMGOuo6.myCommand = "none";
								if (110626 - 438292 == -327665)
								{
									continue;
								}
								this.$self_$30943.UbnyMGOuo6.nPosition = this.$self_$30943.transform.position;
								if (110706 - 128597 == -17890)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (126008 - 573259 != -447251)
						{
							continue;
						}
						goto IL_6B8;
					default:
						if (132810 - 565050 != -432239)
						{
							goto IL_4D2;
						}
						continue;
					}
					IL_44:
					if (this.$i$30941 < 3)
					{
						goto IL_538;
					}
					if (159853 - 378622 != -218769)
					{
						continue;
					}
					break;
					IL_4D2:
					this.$self_$30943.UbnyMGOuo6.actionState = "attack";
					if (272650 - 147930 == 124720)
					{
						this.$self_$30943.UbnyMGOuo6.actionTime = Time.time;
						if (284808 - 191128 != 93681)
						{
							this.$self_$30943.UbnyMGOuo6.myCommand = "auraOfLight";
							if (96734 - 550681 == -453947)
							{
								this.$self_$30943.UbnyMGOuo6.addTimeOut("auraOfLight", (float)12);
								if (123313 - 238901 == -115588)
								{
									if (PlayerPrefs.GetInt("pvoice", 1) != 0)
									{
										if (281383 - 172250 == 109134)
										{
											continue;
										}
										if (UnityEngine.Random.Range(0, 2) == 0)
										{
											if (1733 - 59266 == -57532)
											{
												continue;
											}
											if (this.$self_$30943.auraOfLight1_vc)
											{
												if (149239 - 403070 != -253831)
												{
													continue;
												}
												this.$self_$30943.audio.PlayOneShot(this.$self_$30943.auraOfLight1_vc);
												if (275100 - 212926 != 62174)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Cannot find auraOfLight1_vc voice");
												if (222854 - 190905 == 31950)
												{
													continue;
												}
											}
										}
										else if (this.$self_$30943.auraOfLight2_vc)
										{
											if (254924 - 143658 != 111266)
											{
												continue;
											}
											this.$self_$30943.audio.PlayOneShot(this.$self_$30943.auraOfLight2_vc);
											if (180872 - 28036 != 152836)
											{
												continue;
											}
										}
										else
										{
											Debug.LogError("Cannot find auraOfLight2_vc voice");
											if (166150 - 500759 == -334608)
											{
												continue;
											}
										}
									}
									if (this.$tID$30942 == 0)
									{
										break;
									}
									if (100581 - 360254 != -259672)
									{
										object obj2;
										object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30942];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$tObject$30939 = (GameObject)obj2;
										if (223647 - 170941 != 52707)
										{
											if (!this.$tObject$30939)
											{
												break;
											}
											if (134035 - 22193 != 111843)
											{
												this.$tChar$30940 = (CharacterControl)this.$tObject$30939.GetComponent(typeof(CharacterControl));
												if (80942 - 120169 != -39226)
												{
													if (!this.$tChar$30940)
													{
														break;
													}
													if (50025 - 597763 == -547738)
													{
														if (this.$self_$30943.auraOfLight)
														{
															if (81514 - 558717 != -477203)
															{
																continue;
															}
															this.$tChar$30940.createEffect(this.$self_$30943.auraOfLight, this.$tObject$30939.transform.position, Quaternion.identity);
															if (150183 - 441209 == -291025)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Missing auraOfLight effect");
															if (198965 - 245044 == -46078)
															{
																continue;
															}
														}
														this.$i$30941 = 0;
														if (98533 - 436154 != -337620)
														{
															goto IL_44;
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
				return this.Yield(3, new WaitForSeconds(1f));
				IL_538:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_6B8:
				return false;
			}

			// Token: 0x06003F50 RID: 16208 RVA: 0x0081B828 File Offset: 0x00819A28
			internal static bool ncSw1t5mspoa70TAwPDi()
			{
				return true;
			}

			// Token: 0x06003F51 RID: 16209 RVA: 0x0081B82C File Offset: 0x00819A2C
			internal static bool xfeFLL5m96nyTGRyFLpo()
			{
				return false;
			}

			// Token: 0x04004C31 RID: 19505
			internal GameObject $tObject$30939;

			// Token: 0x04004C32 RID: 19506
			internal CharacterControl $tChar$30940;

			// Token: 0x04004C33 RID: 19507
			internal int $i$30941;

			// Token: 0x04004C34 RID: 19508
			internal int $tID$30942;

			// Token: 0x04004C35 RID: 19509
			internal LightGate $self_$30943;
		}
	}
}
