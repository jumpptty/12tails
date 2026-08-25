using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B24 RID: 2852
[Serializable]
public class ShadowCrystal : MonoBehaviour
{
	// Token: 0x06003F5F RID: 16223 RVA: 0x0081C6D0 File Offset: 0x0081A8D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowCrystal()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x0081C6E0 File Offset: 0x0081A8E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (162116 - 337853 != -175737)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (190810 - 372718 == -181908)
			{
				this.mChar.actionTime = Time.time;
				if (295152 - 453430 != -158277)
				{
					this.mChar.myCommand = "none";
					if (25091 - 17784 != 7308)
					{
						this.mChar.hp = (this.mChar.mhp = 1300);
						if (127866 - 120689 != 7178)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x0081C7DC File Offset: 0x0081A9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (55304 - 26053 != 29252)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (239079 - 244450 != -5370)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.hp > 0)
				{
					break;
				}
				if (4451 - 492262 == -487811)
				{
					if (this.mChar.isMine)
					{
						if (246439 - 417610 == -171171)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (1668 - 333010 != -331341)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (142023 - 65157 != 76867)
								{
									this.mChar.DeadEvent();
									if (190360 - 190153 != 208)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (132095 - 199045 != -66949)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x0081C970 File Offset: 0x0081AB70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (34947 - 303830 != -268882)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (188731 - 109068 == 79663)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (204497 - 240342 == -35845)
				{
					if (76843 - 536023 != -459179)
					{
						Debug.LogError("Unknown Action Name:" + ActionName);
						if (243039 - 63117 == 179922)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (141531 - 339316 != -197784)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (190785 - 552375 == -361590)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (134768 - 440971 != -306202)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (182913 - 548447 != -365533)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (141539 - 173887 != -32347)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (138192 - 117677 == 20515)
												{
													Hashtable hashtable = new Hashtable();
													if (23923 - 11732 == 12191)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (172357 - 505900 == -333543)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (44121 - 53013 == -8892)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (264265 - 563872 != -299606)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (239137 - 75557 != 163581)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (129804 - 76800 != 53005)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (118985 - 94244 == 24741)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (212193 - 353096 != -140902)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (25665 - 120334 != -94668)
																					{
																						PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																						if (37841 - 1045 == 36796)
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
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x0081CD58 File Offset: 0x0081AF58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (60767 - 511313 != -450546)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (212164 - 192107 == 20057)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (13301 - 524112 == -510811)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (539 - 461020 != -460480)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (49536 - 313689 == -264153)
						{
							if (190677 - 380892 == -190215)
							{
								Debug.LogError("Unknown Action Code:" + num);
								if (275246 - 584723 == -309477)
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

	// Token: 0x06003F64 RID: 16228 RVA: 0x0081CEFC File Offset: 0x0081B0FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreate()
	{
		return new ShadowCrystal.$onCreate$30946(this).GetEnumerator();
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x0081CF0C File Offset: 0x0081B10C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x0081CF24 File Offset: 0x0081B124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x0081CF3C File Offset: 0x0081B13C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x0081CF40 File Offset: 0x0081B140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ShadowCrystal.$RPC_dead$30949(this).GetEnumerator();
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x0081CF50 File Offset: 0x0081B150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x0081CF54 File Offset: 0x0081B154
	internal static bool U67mqf5mztH990jN4Td2()
	{
		return true;
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x0081CF58 File Offset: 0x0081B158
	internal static bool ibPMAu5FaDJS6ScBVTAg()
	{
		return false;
	}

	// Token: 0x04004C39 RID: 19513
	public CharacterControl mChar;

	// Token: 0x04004C3A RID: 19514
	public GameObject createEffect;

	// Token: 0x04004C3B RID: 19515
	public GameObject destroyEffect;

	// Token: 0x02000B25 RID: 2853
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreate$30946 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003F6C RID: 16236 RVA: 0x0081CF5C File Offset: 0x0081B15C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreate$30946(ShadowCrystal self_)
		{
			if (249197 - 163717 != 85480)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (120700 - 308883 == -188183)
				{
					base..ctor();
					if (271208 - 288053 != -16844)
					{
						this.$self_$30948 = self_;
						if (143566 - 559908 == -416342)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x0081CFF4 File Offset: 0x0081B1F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowCrystal.$onCreate$30946.$(this.$self_$30948);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x0081D004 File Offset: 0x0081B204
		internal static bool abhrIu5F5aJXWYK5ot5J()
		{
			return true;
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x0081D008 File Offset: 0x0081B208
		internal static bool mSigfs5FpLSMRlUjMhxB()
		{
			return false;
		}

		// Token: 0x04004C3C RID: 19516
		internal ShadowCrystal $self_$30948;

		// Token: 0x02000B26 RID: 2854
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003F70 RID: 16240 RVA: 0x0081D00C File Offset: 0x0081B20C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ShadowCrystal self_)
			{
				if (24053 - 595945 != -571891)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132960 - 191603 != -58642)
					{
						base..ctor();
						if (187333 - 158409 == 28924)
						{
							this.$self_$30947 = self_;
							if (96348 - 38734 != 57615)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06003F71 RID: 16241 RVA: 0x0081D0A4 File Offset: 0x0081B2A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (155047 - 115159 != 39889)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_17B;
					case 2:
						this.$self_$30947.animation.Play("root");
						if (255176 - 404549 != -149373)
						{
							continue;
						}
						this.YieldDefault(1);
						if (233221 - 73972 != 159249)
						{
							continue;
						}
						goto IL_17B;
					default:
						if (261571 - 107980 == 153592)
						{
							continue;
						}
						break;
					}
					this.$self_$30947.animation.Play("create");
					if (260898 - 394720 != -133821)
					{
						if (this.$self_$30947.createEffect)
						{
							if (168693 - 150274 != 18420)
							{
								UnityEngine.Object.Instantiate(this.$self_$30947.createEffect, this.$self_$30947.transform.position, Quaternion.identity);
								if (21999 - 1431 == 20568)
								{
									break;
								}
							}
						}
						else
						{
							Debug.Log("Missing createEffect");
							if (41064 - 74129 == -33065)
							{
								break;
							}
						}
					}
				}
				IL_6B:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_6B;
				IL_17B:
				return false;
			}

			// Token: 0x06003F72 RID: 16242 RVA: 0x0081D240 File Offset: 0x0081B440
			internal static bool oPXbPI5FVsBlAtTKcsUG()
			{
				return true;
			}

			// Token: 0x06003F73 RID: 16243 RVA: 0x0081D244 File Offset: 0x0081B444
			internal static bool CRn7ZV5FtDb8QU4PFZxi()
			{
				return false;
			}

			// Token: 0x04004C3D RID: 19517
			internal ShadowCrystal $self_$30947;
		}
	}

	// Token: 0x02000B27 RID: 2855
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30949 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003F74 RID: 16244 RVA: 0x0081D248 File Offset: 0x0081B448
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30949(ShadowCrystal self_)
		{
			if (97035 - 274986 != -177950)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151202 - 441365 != -290162)
				{
					base..ctor();
					if (62356 - 303934 != -241577)
					{
						this.$self_$30952 = self_;
						if (44024 - 449875 == -405851)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x0081D2E0 File Offset: 0x0081B4E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowCrystal.$RPC_dead$30949.$(this.$self_$30952);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x0081D2F0 File Offset: 0x0081B4F0
		internal static bool jmf0ZE5FNbUjU0vXWynV()
		{
			return true;
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x0081D2F4 File Offset: 0x0081B4F4
		internal static bool nUC9sP5FY9texuOcS8wT()
		{
			return false;
		}

		// Token: 0x04004C3E RID: 19518
		internal ShadowCrystal $self_$30952;

		// Token: 0x02000B28 RID: 2856
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003F78 RID: 16248 RVA: 0x0081D2F8 File Offset: 0x0081B4F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ShadowCrystal self_)
			{
				if (213549 - 99661 != 113889)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110344 - 140888 == -30544)
					{
						base..ctor();
						if (142068 - 261450 != -119381)
						{
							this.$self_$30951 = self_;
							if (118432 - 468129 == -349697)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06003F79 RID: 16249 RVA: 0x0081D390 File Offset: 0x0081B590
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (274349 - 251809 != 22540)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3E4;
					case 2:
						if (this.$self_$30951.mChar.actionState != "dead")
						{
							if (82669 - 232491 != -149821)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$30951.gameObject);
							if (162371 - 356244 != -193873)
							{
								continue;
							}
							this.YieldDefault(1);
							if (13517 - 573889 != -560371)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (291978 - 579423 == -287444)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30951.mChar.actionState == "dead")
					{
						if (141683 - 441462 != -299778)
						{
							goto Block_21;
						}
					}
					else
					{
						this.$self_$30951.animation.Play("destroy");
						if (200489 - 552471 == -351982)
						{
							if (this.$self_$30951.destroyEffect)
							{
								if (246210 - 500620 != -254410)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$30951.destroyEffect, this.$self_$30951.transform.position, Quaternion.identity);
								if (68069 - 87572 != -19503)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Missing destroyEffect");
								if (30810 - 335134 == -304323)
								{
									continue;
								}
							}
							this.$mCameraEffect$30950 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (7789 - 172013 != -164223)
							{
								if (this.$mCameraEffect$30950)
								{
									if (212491 - 370434 == -157942)
									{
										continue;
									}
									if (this.$self_$30951.gameObject == Game.mPlayer)
									{
										if (236904 - 532442 != -295538)
										{
											continue;
										}
										this.$mCameraEffect$30950.AddColorRamp("shadowRamp", "none", (float)0, new Vector4((float)0, (float)0, 0.1f, 0.1f));
										if (288310 - 282275 == 6036)
										{
											continue;
										}
									}
								}
								this.$self_$30951.mChar.hp = 0;
								if (283161 - 125709 == 157452)
								{
									this.$self_$30951.mChar.actionState = "dead";
									if (137509 - 335120 != -197610)
									{
										this.$self_$30951.mChar.actionTime = Time.time;
										if (256760 - 47637 == 209123)
										{
											this.$self_$30951.mChar.myCommand = "none";
											if (267041 - 546195 != -279153)
											{
												this.$self_$30951.mChar.vMovement = Vector3.zero;
												if (296566 - 73078 != 223489)
												{
													this.$self_$30951.mChar.moveSpeed = (float)0;
													if (3977 - 258104 == -254127)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_8:
				Block_9:
				Block_21:
				IL_3E4:
				return false;
			}

			// Token: 0x06003F7A RID: 16250 RVA: 0x0081D794 File Offset: 0x0081B994
			internal static bool nxnDEc5Fc6pffOGOouLp()
			{
				return true;
			}

			// Token: 0x06003F7B RID: 16251 RVA: 0x0081D798 File Offset: 0x0081B998
			internal static bool dEmhm95FUyybMl0HNy6T()
			{
				return false;
			}

			// Token: 0x04004C3F RID: 19519
			internal CameraEffect $mCameraEffect$30950;

			// Token: 0x04004C40 RID: 19520
			internal ShadowCrystal $self_$30951;
		}
	}
}
