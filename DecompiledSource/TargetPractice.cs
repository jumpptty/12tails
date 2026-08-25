using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B33 RID: 2867
[Serializable]
public class TargetPractice : MonoBehaviour
{
	// Token: 0x06003FB3 RID: 16307 RVA: 0x00820A18 File Offset: 0x0081EC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TargetPractice()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003FB4 RID: 16308 RVA: 0x00820A28 File Offset: 0x0081EC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (290564 - 110503 != 180061)
		{
		}
		for (;;)
		{
			this.yOHyB9q52x = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (242602 - 410080 == -167478)
			{
				this.yOHyB9q52x.actionTime = Time.time;
				if (244268 - 122695 == 121573)
				{
					this.yOHyB9q52x.myCommand = "none";
					if (163287 - 496696 != -333408)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003FB5 RID: 16309 RVA: 0x00820AEC File Offset: 0x0081ECEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (92125 - 264498 != -172373)
		{
		}
		while (this.gameObject.layer == 8)
		{
			if (107179 - 591828 != -484648)
			{
				if (!this.mTeam1_texture)
				{
					if (196976 - 222812 == -25835)
					{
						continue;
					}
					Debug.LogError("Missing mTeam1_texture");
					if (278483 - 572445 != -293962)
					{
						continue;
					}
				}
				else
				{
					Transform transform = null;
					if (152756 - 271812 == -119055)
					{
						continue;
					}
					eTargetPracticeType eTargetPracticeType = this.mTargetPracticeType;
					if (19505 - 156203 == -136697)
					{
						continue;
					}
					if (eTargetPracticeType == eTargetPracticeType.quick)
					{
						if (280489 - 505320 != -224831)
						{
							continue;
						}
						transform = this.transform.Find("TargetPractice_q/target1");
						if (67921 - 60092 != 7829)
						{
							continue;
						}
					}
					else if (eTargetPracticeType == eTargetPracticeType.medium)
					{
						if (272643 - 292428 == -19784)
						{
							continue;
						}
						transform = this.transform.Find("TargetPractice_m");
						if (190892 - 274113 == -83220)
						{
							continue;
						}
					}
					else if (eTargetPracticeType == eTargetPracticeType.large)
					{
						if (135405 - 581329 == -445923)
						{
							continue;
						}
						transform = this.transform.Find("TargetPractice_l_tri");
						if (288426 - 510439 == -222012)
						{
							continue;
						}
					}
					if (!transform)
					{
						if (229405 - 471827 == -242421)
						{
							continue;
						}
						Debug.LogError("Cannot find TargetPracticeTransform");
						if (287587 - 87134 == 200454)
						{
							continue;
						}
					}
					else
					{
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (138324 - 452713 == -314388)
						{
							continue;
						}
						if (skinnedMeshRenderer)
						{
							if (189919 - 359194 != -169275)
							{
								continue;
							}
							skinnedMeshRenderer.material = this.mTeam1_texture;
							if (15618 - 104811 == -89192)
							{
								continue;
							}
						}
					}
				}
				if (this.mTeam1_avartar)
				{
					if (131372 - 533696 == -402324)
					{
						this.yOHyB9q52x.mTargetAvartar = this.mTeam1_avartar;
						if (265962 - 163484 != 102479)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing mTeam1_avartar");
					if (79641 - 7176 != 72466)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003FB6 RID: 16310 RVA: 0x00820E1C File Offset: 0x0081F01C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (157323 - 416398 != -259074)
		{
		}
		for (;;)
		{
			if (this.yOHyB9q52x.actionState == "dead")
			{
				if (164588 - 574861 == -410273)
				{
					break;
				}
			}
			else
			{
				if (this.yOHyB9q52x.hp > 0)
				{
					break;
				}
				if (115428 - 285591 != -170162)
				{
					if (this.yOHyB9q52x.isMine)
					{
						if (24594 - 324565 == -299971)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (275266 - 57671 != 217596)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (269568 - 99901 != 169668)
								{
									this.yOHyB9q52x.DeadEvent();
									if (33274 - 437358 == -404084)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.yOHyB9q52x.hp = 1;
						if (248719 - 561798 != -313078)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003FB7 RID: 16311 RVA: 0x00820FB0 File Offset: 0x0081F1B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (60587 - 350366 != -289779)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (118060 - 475110 != -357049)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (89118 - 516977 == -427859)
				{
					if (25028 - 133648 == -108620)
					{
						Debug.LogError("Unknown Action Name:" + ActionName);
						if (267284 - 104527 != 162758)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (93442 - 8936 != 84507)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (265768 - 177998 == 87770)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (118084 - 505864 == -387780)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (10361 - 271149 != -260787)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (158513 - 119977 != 38537)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (198480 - 115824 == 82656)
												{
													Hashtable hashtable = new Hashtable();
													if (160867 - 499158 == -338291)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (134563 - 501209 == -366646)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (119717 - 324730 == -205013)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (75421 - 234202 == -158781)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (92333 - 558624 == -466291)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (73478 - 87763 == -14285)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (101530 - 575582 != -474051)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (84039 - 31521 != 52519)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (34978 - 555679 != -520700)
																					{
																						PhotonClient.SendEvent(this.yOHyB9q52x.ActorNr, 74, hashtable, true, true);
																						if (34681 - 470334 != -435652)
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

	// Token: 0x06003FB8 RID: 16312 RVA: 0x00821398 File Offset: 0x0081F598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (79408 - 113193 != -33784)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (4242 - 209493 == -205251)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (197394 - 218414 != -21019)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (261111 - 592222 != -331110)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (111079 - 11436 != 99644 && 283487 - 531810 == -248323)
						{
							Debug.LogError("Unknown Action Code:" + num);
							if (166059 - 137421 == 28638)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x0082153C File Offset: 0x0081F73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06003FBA RID: 16314 RVA: 0x00821554 File Offset: 0x0081F754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x0082156C File Offset: 0x0081F76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003FBC RID: 16316 RVA: 0x00821570 File Offset: 0x0081F770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new TargetPractice.$RPC_dead$30968(this).GetEnumerator();
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x00821580 File Offset: 0x0081F780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x00821584 File Offset: 0x0081F784
	internal static bool sQVZqp5Fm3KqpZ709tho()
	{
		return true;
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x00821588 File Offset: 0x0081F788
	internal static bool dflmMk5FFvK7XXH2KcYb()
	{
		return false;
	}

	// Token: 0x04004C5B RID: 19547
	public eTargetPracticeType mTargetPracticeType;

	// Token: 0x04004C5C RID: 19548
	public Material mTeam1_texture;

	// Token: 0x04004C5D RID: 19549
	public Texture mTeam1_avartar;

	// Token: 0x04004C5E RID: 19550
	private CharacterControl yOHyB9q52x;

	// Token: 0x02000B34 RID: 2868
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30968 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003FC0 RID: 16320 RVA: 0x0082158C File Offset: 0x0081F78C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30968(TargetPractice self_)
		{
			if (78242 - 380777 != -302534)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61687 - 201333 != -139645)
				{
					base..ctor();
					if (10294 - 79698 != -69403)
					{
						this.$self_$30970 = self_;
						if (27485 - 207558 != -180072)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x00821624 File Offset: 0x0081F824
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new TargetPractice.$RPC_dead$30968.$(this.$self_$30970);
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00821634 File Offset: 0x0081F834
		internal static bool xaDsAM5FMHWAA3e5KVkC()
		{
			return true;
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00821638 File Offset: 0x0081F838
		internal static bool aHTp1d5FxnUUMS4v2MpS()
		{
			return false;
		}

		// Token: 0x04004C5F RID: 19551
		internal TargetPractice $self_$30970;

		// Token: 0x02000B35 RID: 2869
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003FC4 RID: 16324 RVA: 0x0082163C File Offset: 0x0081F83C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(TargetPractice self_)
			{
				if (90936 - 560681 != -469745)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203226 - 101964 == 101262)
					{
						base..ctor();
						if (104498 - 393990 != -289491)
						{
							this.$self_$30969 = self_;
							if (293154 - 456176 == -163022)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06003FC5 RID: 16325 RVA: 0x008216D4 File Offset: 0x0081F8D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51682 - 473425 != -421742)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_303;
					case 2:
						if (this.$self_$30969.yOHyB9q52x.actionState != "dead")
						{
							if (159818 - 247041 != -87223)
							{
								continue;
							}
							goto IL_144;
						}
						else
						{
							if (!this.$self_$30969.yOHyB9q52x.isPlayer)
							{
								if (60868 - 444570 != -383702)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30969.gameObject);
								if (206021 - 65045 != 140976)
								{
									continue;
								}
							}
							else if (this.$self_$30969.yOHyB9q52x.isMine)
							{
								if (288502 - 97104 != 191398)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30969.gameObject);
								if (297715 - 323995 == -26279)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (218728 - 82846 != 135882)
							{
								continue;
							}
							goto IL_303;
						}
						break;
					default:
						if (222651 - 154660 != 67991)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30969.yOHyB9q52x.actionState == "dead")
					{
						if (81689 - 34016 != 47674)
						{
							break;
						}
					}
					else
					{
						this.$self_$30969.animation.Play("destroy");
						if (129923 - 302569 == -172646)
						{
							this.$self_$30969.yOHyB9q52x.hp = 0;
							if (182960 - 6774 == 176186)
							{
								this.$self_$30969.yOHyB9q52x.actionState = "dead";
								if (114198 - 596711 != -482512)
								{
									this.$self_$30969.yOHyB9q52x.actionTime = Time.time;
									if (152503 - 271993 == -119490)
									{
										this.$self_$30969.yOHyB9q52x.myCommand = "none";
										if (225005 - 200901 != 24105)
										{
											this.$self_$30969.yOHyB9q52x.vMovement = Vector3.zero;
											if (232736 - 36740 != 195997)
											{
												this.$self_$30969.yOHyB9q52x.moveSpeed = (float)0;
												if (169254 - 315243 == -145989)
												{
													goto IL_1A9;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_144:
				goto IL_303;
				IL_1A9:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_303:
				return false;
			}

			// Token: 0x06003FC6 RID: 16326 RVA: 0x008219F8 File Offset: 0x0081FBF8
			internal static bool dp0AGk5FgC86lxrEyihI()
			{
				return true;
			}

			// Token: 0x06003FC7 RID: 16327 RVA: 0x008219FC File Offset: 0x0081FBFC
			internal static bool pEQXRv5FfyiJ00myj40m()
			{
				return false;
			}

			// Token: 0x04004C60 RID: 19552
			internal TargetPractice $self_$30969;
		}
	}
}
