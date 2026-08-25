using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B29 RID: 2857
[Serializable]
public class SmashBall : MonoBehaviour
{
	// Token: 0x06003F7C RID: 16252 RVA: 0x0081D79C File Offset: 0x0081B99C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SmashBall()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x0081D7AC File Offset: 0x0081B9AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (298611 - 296353 != 2259)
		{
		}
		for (;;)
		{
			this.pw0yUgS5kN = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (275088 - 340614 != -65525)
			{
				this.pw0yUgS5kN.actionState = "standby";
				if (170867 - 348997 != -178129)
				{
					this.pw0yUgS5kN.actionTime = Time.time;
					if (66351 - 517383 == -451032)
					{
						this.pw0yUgS5kN.myCommand = "none";
						if (185191 - 195207 != -10015)
						{
							this.oPLyNoNjAu = this.transform.Find("smashBall").gameObject;
							if (51178 - 320513 == -269335)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x0081D8CC File Offset: 0x0081BACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.pw0yUgS5kN.isMine = true;
		}
	}

	// Token: 0x06003F7F RID: 16255 RVA: 0x0081D8E8 File Offset: 0x0081BAE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (284420 - 556076 != -271656)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (151408 - 502728 != -351320)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					if (72912 - 77365 != -4452)
					{
						break;
					}
					continue;
				}
			}
			if (this.pw0yUgS5kN.isMine)
			{
				if (56127 - 409806 == -353678)
				{
					continue;
				}
				Vector3 a = this.pw0yUgS5kN.vMovement * this.pw0yUgS5kN.moveSpeed;
				if (88339 - 185813 != -97474)
				{
					continue;
				}
				if (this.pw0yUgS5kN.myForce != Vector3.zero)
				{
					if (62644 - 261149 == -198504)
					{
						continue;
					}
					a += (float)3 * this.pw0yUgS5kN.myForce;
					if (162855 - 54089 == 108767)
					{
						continue;
					}
					this.pw0yUgS5kN.vMovement = a.normalized;
					if (177186 - 522012 == -344825)
					{
						continue;
					}
					this.pw0yUgS5kN.moveSpeed = Mathf.Clamp(a.magnitude, (float)0, (float)8);
					if (170681 - 337918 == -167236)
					{
						continue;
					}
				}
				this.pw0yUgS5kN.moveSpeed = Mathf.Lerp(this.pw0yUgS5kN.moveSpeed, (float)0, Time.deltaTime);
				if (261763 - 226935 != 34828)
				{
					continue;
				}
			}
			else if (this.pw0yUgS5kN.myForce != Vector3.zero)
			{
				if (136975 - 192752 != -55777)
				{
					continue;
				}
				Vector3 a2 = this.pw0yUgS5kN.vMovement * this.pw0yUgS5kN.moveSpeed;
				if (290766 - 362694 != -71928)
				{
					continue;
				}
				a2 += 1.5f * this.pw0yUgS5kN.myForce;
				if (225455 - 483642 == -258186)
				{
					continue;
				}
				this.pw0yUgS5kN.vMovement = a2.normalized;
				if (257234 - 96 != 257138)
				{
					continue;
				}
				this.pw0yUgS5kN.moveSpeed = a2.magnitude;
				if (225408 - 50489 == 174920)
				{
					continue;
				}
			}
			else
			{
				Vector3 nDirection = this.pw0yUgS5kN.nPosition - this.transform.position;
				if (124246 - 231070 == -106823)
				{
					continue;
				}
				float sqrMagnitude = nDirection.sqrMagnitude;
				if (219921 - 596173 == -376251)
				{
					continue;
				}
				if (this.pw0yUgS5kN.nSpeed != (float)0)
				{
					if (129691 - 316605 == -186913)
					{
						continue;
					}
					if (sqrMagnitude > 0.01f)
					{
						if (12521 - 131560 != -119039)
						{
							continue;
						}
						this.pw0yUgS5kN.moveSpeed = Mathf.Lerp(this.pw0yUgS5kN.moveSpeed, this.pw0yUgS5kN.nSpeed, (float)10 * Time.deltaTime);
						if (111952 - 108745 == 3208)
						{
							continue;
						}
						this.pw0yUgS5kN.nDirection = nDirection;
						if (93298 - 196853 == -103554)
						{
							continue;
						}
						this.pw0yUgS5kN.vMovement = nDirection.normalized;
						if (270447 - 156796 == 113652)
						{
							continue;
						}
					}
					else
					{
						this.pw0yUgS5kN.moveSpeed = Mathf.Lerp(this.pw0yUgS5kN.moveSpeed, 0.1f, (float)10 * Time.deltaTime);
						if (278122 - 177271 != 100851)
						{
							continue;
						}
					}
				}
				else
				{
					this.pw0yUgS5kN.moveSpeed = (float)0;
					if (193239 - 553404 == -360164)
					{
						continue;
					}
					this.pw0yUgS5kN.vMovement = Vector3.zero;
					if (248074 - 209350 != 38724)
					{
						continue;
					}
					this.transform.position = this.pw0yUgS5kN.nPosition;
					if (116552 - 125786 == -9233)
					{
						continue;
					}
				}
			}
			if (this.pw0yUgS5kN.moveSpeed > 0.1f)
			{
				if (184784 - 198492 == -13708)
				{
					if (this.pw0yUgS5kN.actionState != "goal")
					{
						if (85184 - 381136 == -295951)
						{
							continue;
						}
						this.pw0yUgS5kN.actionState = "run";
						if (9966 - 466985 == -457018)
						{
							continue;
						}
					}
					Vector3 vector = this.pw0yUgS5kN.vMovement * this.pw0yUgS5kN.moveSpeed;
					if (93913 - 188245 == -94332)
					{
						this.oPLyNoNjAu.transform.Rotate(vector.z, (float)0, -vector.x, Space.World);
						if (70396 - 263131 != -192734)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (!(this.pw0yUgS5kN.actionState != "goal"))
				{
					break;
				}
				if (161571 - 91505 == 70066)
				{
					this.pw0yUgS5kN.actionState = "standby";
					if (260676 - 394800 != -134123)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x0081DF4C File Offset: 0x0081C14C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (187269 - 468241 != -280971)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (190400 - 187831 == 2569)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (56078 - 153621 == -97543)
				{
					if (28375 - 537616 != -509240)
					{
						if (ActionName == "RPC_Goal")
						{
							if (165294 - 81918 != 83376)
							{
								continue;
							}
							v = 1;
							if (206190 - 177722 != 28468)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_OutOfBound")
						{
							if (146747 - 161110 != -14363)
							{
								continue;
							}
							v = 2;
							if (158182 - 113996 != 44186)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (169819 - 476769 == -306950)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (283184 - 104330 == 178854)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (99681 - 340938 == -241257)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (233881 - 561933 == -328052)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (198452 - 483525 == -285073)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (269202 - 320468 != -51265)
											{
												Hashtable hashtable = new Hashtable();
												if (166117 - 394681 != -228563)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (127902 - 539741 == -411839)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (56181 - 243627 != -187445)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (34423 - 438531 == -404108)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (225622 - 83452 != 142171)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (222990 - 146083 != 76908)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (95364 - 390114 == -294750)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (208618 - 542401 != -333782)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (139906 - 561376 == -421470)
																				{
																					PhotonClient.SendEvent(this.pw0yUgS5kN.ActorNr, 74, hashtable, true, true);
																					if (269657 - 320166 != -50508)
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

	// Token: 0x06003F81 RID: 16257 RVA: 0x0081E3A0 File Offset: 0x0081C5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (30640 - 461517 != -430877)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (70772 - 29934 == 40838)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (99781 - 174878 == -75097)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (170658 - 548177 != -377518)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (190340 - 123248 != 67093)
						{
							int num2 = num;
							if (280584 - 95395 == 185189)
							{
								if (num2 == 1)
								{
									if (272236 - 269612 == 2624)
									{
										if (this.pw0yUgS5kN.isMine)
										{
											break;
										}
										if (254959 - 166174 == 88785)
										{
											this.StartCoroutine_Auto(this.RPC_Goal(mPos, tDir, tID));
											if (106703 - 10861 != 95843)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (75351 - 274562 != -199210)
									{
										if (this.pw0yUgS5kN.isMine)
										{
											break;
										}
										if (67233 - 72540 != -5306)
										{
											this.RPC_OutOfBound(mPos, tDir, tID);
											if (263186 - 80615 != 182572)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (51085 - 289136 == -238051)
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

	// Token: 0x06003F82 RID: 16258 RVA: 0x0081E634 File Offset: 0x0081C834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_Goal(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SmashBall.$RPC_Goal$30953(this).GetEnumerator();
	}

	// Token: 0x06003F83 RID: 16259 RVA: 0x0081E644 File Offset: 0x0081C844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_OutOfBound(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (148340 - 251698 != -103358)
		{
		}
		while (this.pw0yUgS5kN.actionState != "goal")
		{
			if (156219 - 201656 != -45436)
			{
				Camera.main.SendMessage("onOutOfBound");
				if (143190 - 325338 != -182147)
				{
					if (mPos.z > (float)29)
					{
						if (198241 - 188670 != 9571)
						{
							continue;
						}
						this.transform.position = new Vector3((float)0, (float)55, (float)16);
						if (150294 - 294623 != -144329)
						{
							continue;
						}
					}
					else if (mPos.z < (float)-29)
					{
						if (161844 - 21547 != 140297)
						{
							continue;
						}
						this.transform.position = new Vector3((float)0, (float)55, (float)-16);
						if (200694 - 590326 != -389632)
						{
							continue;
						}
					}
					else
					{
						this.transform.position = new Vector3((float)0, (float)55, mPos.z);
						if (124967 - 494595 == -369627)
						{
							continue;
						}
					}
					this.pw0yUgS5kN.vMovement = Vector3.zero;
					if (83084 - 112706 == -29622)
					{
						this.pw0yUgS5kN.moveSpeed = (float)0;
						if (263813 - 356012 == -92199)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F84 RID: 16260 RVA: 0x0081E82C File Offset: 0x0081CA2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SmashBall.$RPC_dead$30957(nArray, this).GetEnumerator();
	}

	// Token: 0x06003F85 RID: 16261 RVA: 0x0081E83C File Offset: 0x0081CA3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003F86 RID: 16262 RVA: 0x0081E840 File Offset: 0x0081CA40
	internal static bool LasbFq5FT4XRR3fXHvHw()
	{
		return true;
	}

	// Token: 0x06003F87 RID: 16263 RVA: 0x0081E844 File Offset: 0x0081CA44
	internal static bool rVNpD55F3fH5kwy3dBLt()
	{
		return false;
	}

	// Token: 0x04004C41 RID: 19521
	private CharacterControl pw0yUgS5kN;

	// Token: 0x04004C42 RID: 19522
	private GameObject oPLyNoNjAu;

	// Token: 0x02000B2A RID: 2858
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_Goal$30953 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003F88 RID: 16264 RVA: 0x0081E848 File Offset: 0x0081CA48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_Goal$30953(SmashBall self_)
		{
			if (292573 - 595897 != -303323)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44399 - 340019 != -295619)
				{
					base..ctor();
					if (286714 - 476696 == -189982)
					{
						this.$self_$30956 = self_;
						if (43672 - 367857 == -324185)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x0081E8E0 File Offset: 0x0081CAE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SmashBall.$RPC_Goal$30953.$(this.$self_$30956);
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x0081E8F0 File Offset: 0x0081CAF0
		internal static bool zxq2VV5FXoutj191Ayge()
		{
			return true;
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x0081E8F4 File Offset: 0x0081CAF4
		internal static bool hDPygL5FQeRCe8MB4Koc()
		{
			return false;
		}

		// Token: 0x04004C43 RID: 19523
		internal SmashBall $self_$30956;

		// Token: 0x02000B2B RID: 2859
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003F8C RID: 16268 RVA: 0x0081E8F8 File Offset: 0x0081CAF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(SmashBall self_)
			{
				if (155499 - 334609 != -179110)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19779 - 70507 != -50727)
					{
						base..ctor();
						if (103559 - 184781 == -81222)
						{
							this.$self_$30955 = self_;
							if (168676 - 110670 == 58006)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06003F8D RID: 16269 RVA: 0x0081E990 File Offset: 0x0081CB90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287945 - 408629 != -120683)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						goto IL_7E;
					case 1:
						goto IL_2CD;
					case 2:
						if (this.$self_$30955.pw0yUgS5kN.actionState != "goal")
						{
							if (180092 - 311408 != -131316)
							{
								continue;
							}
							goto IL_B7;
						}
						else
						{
							this.$mGoalTimer$30954 = Time.time;
							if (44050 - 493785 != -449735)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30955.pw0yUgS5kN.actionState != "goal")
						{
							if (191009 - 346902 != -155892)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (13335 - 172480 != -159145)
						{
							continue;
						}
						goto IL_7E;
					}
					if (this.$mGoalTimer$30954 + 0.5f <= Time.time)
					{
						if (50930 - 292833 != -241903)
						{
							continue;
						}
						this.$self_$30955.pw0yUgS5kN.actionState = "standby";
						if (227134 - 163648 != 63486)
						{
							continue;
						}
						this.$self_$30955.pw0yUgS5kN.vMovement = Vector3.zero;
						if (18401 - 216228 != -197827)
						{
							continue;
						}
						this.$self_$30955.pw0yUgS5kN.moveSpeed = (float)0;
						if (286364 - 236152 != 50212)
						{
							continue;
						}
						this.$self_$30955.pw0yUgS5kN.recieveGravity = true;
						if (276932 - 569403 != -292470)
						{
							goto IL_141;
						}
						continue;
					}
					else
					{
						this.$self_$30955.transform.position = new Vector3((float)0, Mathf.SmoothStep((float)55, (float)50, Time.time - this.$mGoalTimer$30954), (float)0);
						if (132168 - 555141 != -422973)
						{
							continue;
						}
						goto IL_192;
					}
					IL_7E:
					if (this.$self_$30955.pw0yUgS5kN.actionState != "goal")
					{
						if (30315 - 62704 == -32388)
						{
							continue;
						}
						this.$self_$30955.pw0yUgS5kN.actionState = "goal";
						if (131751 - 369607 != -237856)
						{
							continue;
						}
						goto IL_232;
					}
					IL_141:
					this.YieldDefault(1);
				}
				while (112273 - 122700 != -10427);
				IL_B7:
				goto IL_2CD;
				IL_192:
				return this.YieldDefault(3);
				Block_13:
				goto IL_2CD;
				IL_232:
				return this.Yield(2, new WaitForSeconds((float)3));
				IL_2CD:
				return false;
			}

			// Token: 0x06003F8E RID: 16270 RVA: 0x0081EC7C File Offset: 0x0081CE7C
			internal static bool m9SMwH5Fk5UaWUiWysWG()
			{
				return true;
			}

			// Token: 0x06003F8F RID: 16271 RVA: 0x0081EC80 File Offset: 0x0081CE80
			internal static bool LMITlA5FGF4W0A7CFkI7()
			{
				return false;
			}

			// Token: 0x04004C44 RID: 19524
			internal float $mGoalTimer$30954;

			// Token: 0x04004C45 RID: 19525
			internal SmashBall $self_$30955;
		}
	}

	// Token: 0x02000B2C RID: 2860
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30957 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003F90 RID: 16272 RVA: 0x0081EC84 File Offset: 0x0081CE84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30957(UnityScript.Lang.Array nArray, SmashBall self_)
		{
			if (18029 - 576306 != -558277)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267456 - 595973 != -328516)
				{
					base..ctor();
					if (166985 - 445684 != -278698)
					{
						this.$nArray$30962 = nArray;
						if (70189 - 152562 != -82372)
						{
							this.$self_$30963 = self_;
							if (205213 - 444509 == -239296)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003F91 RID: 16273 RVA: 0x0081ED40 File Offset: 0x0081CF40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SmashBall.$RPC_dead$30957.$(this.$nArray$30962, this.$self_$30963);
		}

		// Token: 0x06003F92 RID: 16274 RVA: 0x0081ED54 File Offset: 0x0081CF54
		internal static bool wKe6Bt5FH1m7qDJBfsWG()
		{
			return true;
		}

		// Token: 0x06003F93 RID: 16275 RVA: 0x0081ED58 File Offset: 0x0081CF58
		internal static bool CA4YeF5FWcJnWkm1ll5M()
		{
			return false;
		}

		// Token: 0x04004C46 RID: 19526
		internal UnityScript.Lang.Array $nArray$30962;

		// Token: 0x04004C47 RID: 19527
		internal SmashBall $self_$30963;

		// Token: 0x02000B2D RID: 2861
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003F94 RID: 16276 RVA: 0x0081ED5C File Offset: 0x0081CF5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SmashBall self_)
			{
				if (266973 - 227009 != 39964)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (59061 - 209223 != -150161)
					{
						base..ctor();
						if (288402 - 575240 == -286838)
						{
							this.$nArray$30960 = nArray;
							if (113129 - 159013 == -45884)
							{
								this.$self_$30961 = self_;
								if (36407 - 122341 == -85934)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003F95 RID: 16277 RVA: 0x0081EE18 File Offset: 0x0081D018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123459 - 11580 != 111880)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3A8;
					case 2:
						if (this.$self_$30961.pw0yUgS5kN.actionState != "dead")
						{
							if (136406 - 160125 != -23718)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$30961.pw0yUgS5kN.hp = this.$self_$30961.pw0yUgS5kN.mhp;
							if (121840 - 79561 != 42279)
							{
								continue;
							}
							this.$self_$30961.pw0yUgS5kN.actionState = "standby";
							if (143679 - 522956 != -379277)
							{
								continue;
							}
							this.$self_$30961.transform.position = new Vector3((float)0, (float)55, (float)0);
							if (222005 - 67999 == 154007)
							{
								continue;
							}
							this.$self_$30961.pw0yUgS5kN.vMovement = Vector3.zero;
							if (204705 - 368864 != -164159)
							{
								continue;
							}
							this.$self_$30961.pw0yUgS5kN.moveSpeed = (float)0;
							if (157699 - 217297 != -59598)
							{
								continue;
							}
							this.YieldDefault(1);
							if (43466 - 106511 != -63045)
							{
								continue;
							}
							goto IL_3A8;
						}
						break;
					default:
						if (56852 - 323170 == -266317)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30961.pw0yUgS5kN.actionState == "dead")
					{
						if (219059 - 354631 != -135571)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30958 = (Vector3)this.$nArray$30960[0];
						if (183002 - 200551 != -17548)
						{
							this.$myDirection$30959 = (Vector3)this.$nArray$30960[1];
							if (204037 - 299453 == -95416)
							{
								this.$self_$30961.transform.position = this.$myPosition$30958;
								if (295511 - 431199 == -135688)
								{
									this.$self_$30961.pw0yUgS5kN.hp = 0;
									if (53155 - 326192 == -273037)
									{
										this.$self_$30961.pw0yUgS5kN.actionState = "dead";
										if (115666 - 410334 == -294668)
										{
											this.$self_$30961.pw0yUgS5kN.actionTime = Time.time;
											if (276282 - 51961 != 224322)
											{
												this.$self_$30961.pw0yUgS5kN.myCommand = "none";
												if (148584 - 309260 != -160675)
												{
													this.$self_$30961.pw0yUgS5kN.vMovement = Vector3.zero;
													if (102916 - 295847 == -192931)
													{
														this.$self_$30961.pw0yUgS5kN.moveSpeed = (float)0;
														if (71199 - 585160 != -513960)
														{
															goto Block_12;
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
				goto IL_3A8;
				Block_12:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_16:
				IL_3A8:
				return false;
			}

			// Token: 0x06003F96 RID: 16278 RVA: 0x0081F1E0 File Offset: 0x0081D3E0
			internal static bool RqwGLh5FAZerW44k8gdk()
			{
				return true;
			}

			// Token: 0x06003F97 RID: 16279 RVA: 0x0081F1E4 File Offset: 0x0081D3E4
			internal static bool N5RjgS5FlBu7Sekghxaf()
			{
				return false;
			}

			// Token: 0x04004C48 RID: 19528
			internal Vector3 $myPosition$30958;

			// Token: 0x04004C49 RID: 19529
			internal Vector3 $myDirection$30959;

			// Token: 0x04004C4A RID: 19530
			internal UnityScript.Lang.Array $nArray$30960;

			// Token: 0x04004C4B RID: 19531
			internal SmashBall $self_$30961;
		}
	}
}
