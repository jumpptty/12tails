using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000ED7 RID: 3799
[Serializable]
public class PrototypeKaiserAI : MonoBehaviour
{
	// Token: 0x0600561F RID: 22047 RVA: 0x00A6B198 File Offset: 0x00A69398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PrototypeKaiserAI()
	{
		if (128739 - 82632 != 46107)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (83801 - 562502 != -478700)
			{
				base..ctor();
				if (59133 - 225816 == -166683)
				{
					this.AI_state = "none";
					if (276688 - 265970 == 10718)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005620 RID: 22048 RVA: 0x00A6B234 File Offset: 0x00A69434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.BN7cJR9g0QC = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.xdOcJrlfyWn = (PrototypeKaiser)this.GetComponent(typeof(PrototypeKaiser));
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x00A6B26C File Offset: 0x00A6946C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (272129 - 184943 != 87186)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (163086 - 520592 != -357506)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (162550 - 202233 != -39683)
				{
					continue;
				}
			}
			if (this.BN7cJR9g0QC.isControlled)
			{
				break;
			}
			if (65892 - 69183 != -3290)
			{
				this.AIControl();
				if (46995 - 458734 != -411738)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005622 RID: 22050 RVA: 0x00A6B338 File Offset: 0x00A69538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (248218 - 294841 != -46622)
		{
		}
		for (;;)
		{
			this.xlJcJTn23ls = (float)0;
			if (118024 - 128479 != -10454)
			{
				if (this.BN7cJR9g0QC.isMine)
				{
					if (47532 - 588654 != -541121)
					{
						if (this.BN7cJR9g0QC.actionState != "standby")
						{
							if (144277 - 110422 == 33856)
							{
								continue;
							}
							if (this.BN7cJR9g0QC.actionState != "run")
							{
								if (151592 - 49709 != 101883)
								{
									continue;
								}
								break;
							}
						}
						if (!this.BN7cJR9g0QC.isAlert)
						{
							if (243581 - 337900 == -94319)
							{
								this.AI_idle(3f, 1f);
								if (173550 - 304191 != -130640)
								{
									this.AI_patrol(1f, 0.25f);
									if (117347 - 125860 != -8512)
									{
										this.AI_resetTimer();
										if (70856 - 184280 == -113424)
										{
											this.AI_visionCheck();
											if (11888 - 301629 == -289741)
											{
												if (!this.BN7cJR9g0QC.myAttackTarget)
												{
													break;
												}
												if (83444 - 235215 == -151771)
												{
													this.BN7cJR9g0QC.isAlert = true;
													if (170032 - 263755 != -93722)
													{
														this.qmAcJxVjRXA = Time.time;
														if (115007 - 119513 == -4506)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (151182 - 599022 != -447839)
							{
								this.AI_idle(2f, 1f);
								if (96591 - 454158 != -357566)
								{
									this.AI_attack(10f, (float)0);
									if (382 - 123041 == -122659)
									{
										this.AI_resetTimer();
										if (252568 - 177723 == 74845)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				else
				{
					if (this.BN7cJR9g0QC.actionState != "standby")
					{
						if (184164 - 283959 != -99795)
						{
							continue;
						}
						if (this.BN7cJR9g0QC.actionState != "run")
						{
							if (83680 - 529843 != -446163)
							{
								continue;
							}
							break;
						}
					}
					float num = this.BN7cJR9g0QC.moveSpeed;
					if (36223 - 63608 == -27385)
					{
						float runSpeed = this.BN7cJR9g0QC.runSpeed;
						if (142181 - 111497 != 30685)
						{
							Vector3 vector = default(Vector3);
							if (51815 - 473650 != -421834)
							{
								Vector3 vector2 = Vector3.zero;
								if (9593 - 374377 != -364783)
								{
									if ((this.BN7cJR9g0QC.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (3190 - 278535 != -275345)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.BN7cJR9g0QC.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (247704 - 58952 == 188753)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (117265 - 170806 != -53541)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (124198 - 310518 == -186319)
											{
												continue;
											}
											num = (float)0;
											if (250873 - 238060 != 12813)
											{
												continue;
											}
											this.transform.position = this.BN7cJR9g0QC.nPosition;
											if (290145 - 302503 == -12357)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (7722 - 172275 == -164552)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (120229 - 501706 == -381476)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (242579 - 253681 != -11102)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (166277 - 150926 != 15351)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (238294 - 209271 != 29023)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (221358 - 427831 == -206472)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (145303 - 534771 != -389468)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (146029 - 577500 == -431470)
											{
												continue;
											}
										}
									}
									this.BN7cJR9g0QC.vMovement = vector2;
									if (15334 - 349168 != -333833)
									{
										this.BN7cJR9g0QC.moveSpeed = num;
										if (249399 - 278653 != -29253)
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

	// Token: 0x06005623 RID: 22051 RVA: 0x00A6B9B0 File Offset: 0x00A69BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (47954 - 355157 != -307203)
		{
		}
		do
		{
			if (Time.time - this.qmAcJxVjRXA >= this.xlJcJTn23ls)
			{
				if (9779 - 296681 == -286901)
				{
					continue;
				}
				if (Time.time - this.qmAcJxVjRXA < this.xlJcJTn23ls + mTime)
				{
					if (13014 - 452010 != -438996)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (119810 - 438324 == -318513)
						{
							continue;
						}
						this.AI_state = "idle";
						if (256964 - 215219 != 41745)
						{
							continue;
						}
						this.qmAcJxVjRXA -= UnityEngine.Random.Range((float)0, rTimer);
						if (180265 - 280947 != -100682)
						{
							continue;
						}
						this.BN7cJR9g0QC.vDirection = Vector3.zero;
						if (170405 - 350863 != -180458)
						{
							continue;
						}
						this.BN7cJR9g0QC.vMovement = this.transform.forward;
						if (86880 - 353062 == -266181)
						{
							continue;
						}
						this.BN7cJR9g0QC.actionState = "standby";
						if (157517 - 504116 != -346599)
						{
							continue;
						}
					}
					this.BN7cJR9g0QC.moveSpeed = Mathf.Lerp(this.BN7cJR9g0QC.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (289421 - 75454 == 213968)
					{
						continue;
					}
					if (this.BN7cJR9g0QC.moveSpeed < 0.1f * this.BN7cJR9g0QC.runSpeed)
					{
						if (86153 - 280176 == -194022)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (64711 - 214536 != -149825)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (192369 - 187657 == 4713)
						{
							continue;
						}
						this.BN7cJR9g0QC.moveSpeed = (float)0;
						if (292742 - 232815 == 59928)
						{
							continue;
						}
					}
				}
			}
			this.xlJcJTn23ls += mTime;
		}
		while (45786 - 399782 != -353996);
	}

	// Token: 0x06005624 RID: 22052 RVA: 0x00A6BC74 File Offset: 0x00A69E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (96501 - 481205 != -384704)
		{
		}
		do
		{
			if (Time.time - this.qmAcJxVjRXA >= this.xlJcJTn23ls)
			{
				if (28597 - 308582 != -279985)
				{
					continue;
				}
				if (Time.time - this.qmAcJxVjRXA < this.xlJcJTn23ls + mTime)
				{
					if (60882 - 45441 != 15441)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (9702 - 384565 != -374863)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (144637 - 170778 != -26141)
						{
							continue;
						}
						this.qmAcJxVjRXA -= UnityEngine.Random.Range((float)0, rTimer);
						if (26199 - 36340 == -10140)
						{
							continue;
						}
						this.BN7cJR9g0QC.vDirection = this.BN7cJR9g0QC.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (117537 - 397863 != -280326)
						{
							continue;
						}
						this.BN7cJR9g0QC.vDirection.y = this.transform.position.y;
						if (262138 - 510618 != -248480)
						{
							continue;
						}
						this.BN7cJR9g0QC.vMovement = (this.BN7cJR9g0QC.vDirection - this.transform.position).normalized;
						if (100619 - 6253 == 94367)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.BN7cJR9g0QC.vMovement);
						if (52347 - 368073 == -315725)
						{
							continue;
						}
						this.BN7cJR9g0QC.actionState = "run";
						if (97643 - 88690 != 8953)
						{
							continue;
						}
						this.animation.Play("run");
						if (178351 - 220797 != -42446)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (74625 - 102447 != -27822)
						{
							continue;
						}
					}
					this.BN7cJR9g0QC.moveSpeed = Mathf.Lerp(this.BN7cJR9g0QC.moveSpeed, this.BN7cJR9g0QC.runSpeed, (float)4 * Time.deltaTime);
					if (190185 - 556055 != -365870)
					{
						continue;
					}
				}
			}
			this.xlJcJTn23ls += mTime;
		}
		while (127816 - 361583 == -233766);
	}

	// Token: 0x06005625 RID: 22053 RVA: 0x00A6BF7C File Offset: 0x00A6A17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (273951 - 496655 != -222704)
		{
		}
		do
		{
			if (Time.time - this.qmAcJxVjRXA >= this.xlJcJTn23ls)
			{
				if (295253 - 148595 != 146658)
				{
					continue;
				}
				if (Time.time - this.qmAcJxVjRXA < this.xlJcJTn23ls + mTime)
				{
					if (253153 - 437868 != -184715)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (75727 - 401670 != -325943)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (190885 - 50628 != 140257)
						{
							continue;
						}
						this.qmAcJxVjRXA = Time.time - mTime - this.xlJcJTn23ls;
						if (73900 - 301857 != -227957)
						{
							continue;
						}
						this.BN7cJR9g0QC.vDirection = Vector3.zero;
						if (92195 - 31254 == 60942)
						{
							continue;
						}
						this.BN7cJR9g0QC.vMovement = this.transform.forward;
						if (280207 - 462908 != -182701)
						{
							continue;
						}
						this.BN7cJR9g0QC.actionState = "standby";
						if (195678 - 402456 == -206777)
						{
							continue;
						}
						this.BN7cJR9g0QC.myAttackTarget = this.BN7cJR9g0QC.getHateTarget(5, 50);
						if (77625 - 116109 == -38483)
						{
							continue;
						}
						if (!this.BN7cJR9g0QC.myAttackTarget)
						{
							if (55594 - 302047 == -246452)
							{
								continue;
							}
							this.BN7cJR9g0QC.isAlert = false;
							if (190700 - 27045 != 163655)
							{
								continue;
							}
							this.qmAcJxVjRXA = Time.time;
							if (129630 - 51225 == 78406)
							{
								continue;
							}
							this.BN7cJR9g0QC.myAttackTarget = null;
							if (284684 - 261143 == 23542)
							{
								continue;
							}
							this.BN7cJR9g0QC.mOriginalPosition = this.transform.position;
							if (274953 - 245127 != 29826)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.BN7cJR9g0QC.myAttackTarget;
							if (197762 - 153000 == 44763)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (197208 - 34896 != 162312)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (53806 - 457368 == -403561)
								{
									continue;
								}
								this.BN7cJR9g0QC.isAlert = false;
								if (291249 - 311468 != -20219)
								{
									continue;
								}
								this.qmAcJxVjRXA = Time.time;
								if (46110 - 369196 == -323085)
								{
									continue;
								}
								this.BN7cJR9g0QC.myAttackTarget = null;
								if (290674 - 59293 == 231382)
								{
									continue;
								}
							}
							else
							{
								this.BN7cJR9g0QC.vDirection = myAttackTarget.transform.position;
								if (247526 - 295216 != -47690)
								{
									continue;
								}
								this.BN7cJR9g0QC.vDirection.y = this.transform.position.y;
								if (75602 - 212617 == -137014)
								{
									continue;
								}
								this.BN7cJR9g0QC.vMovement = (this.BN7cJR9g0QC.vDirection - this.transform.position).normalized;
								if (116984 - 147426 != -30442)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.BN7cJR9g0QC.vMovement);
								if (30789 - 534674 != -503885)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.xlJcJTn23ls += mTime;
		}
		while (203460 - 318012 != -114552);
	}

	// Token: 0x06005626 RID: 22054 RVA: 0x00A6C42C File Offset: 0x00A6A62C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (104546 - 581373 != -476827)
		{
		}
		do
		{
			if (Time.time - this.qmAcJxVjRXA >= this.xlJcJTn23ls)
			{
				if (220950 - 190847 == 30104)
				{
					continue;
				}
				if (Time.time - this.qmAcJxVjRXA < this.xlJcJTn23ls + mTime)
				{
					if (220973 - 212069 != 8904)
					{
						continue;
					}
					if (!this.BN7cJR9g0QC.myAttackTarget)
					{
						if (241675 - 564326 == -322650)
						{
							continue;
						}
						this.qmAcJxVjRXA = Time.time - mTime - this.xlJcJTn23ls;
						if (162966 - 346818 != -183851)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.BN7cJR9g0QC.myAttackTarget;
						if (160896 - 314927 == -154030)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (90156 - 390020 != -299864)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (248415 - 548022 != -299607)
						{
							continue;
						}
						int tID = 0;
						if (276834 - 540096 == -263261)
						{
							continue;
						}
						if (characterControl)
						{
							if (247743 - 536463 != -288720)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (279157 - 296046 != -16889)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (97017 - 27864 != 69153)
						{
							continue;
						}
						if (num > (float)8)
						{
							if (29698 - 13088 != 16610)
							{
								continue;
							}
							if (num < (float)32)
							{
								if (277956 - 171219 == 106738)
								{
									continue;
								}
								if (this.BN7cJR9g0QC.isTimeOut("kaiserCannon") == (float)0)
								{
									if (143922 - 49626 != 94296)
									{
										continue;
									}
									this.qmAcJxVjRXA = Time.time - mTime - this.xlJcJTn23ls;
									if (265108 - 64461 == 200648)
									{
										continue;
									}
									this.xdOcJrlfyWn.StartCoroutine_Auto(this.xdOcJrlfyWn.RPC_kaiserCannon(this.transform.position, vector, tID));
									if (49960 - 15731 != 34230)
									{
										if (PhotonClient.IsInitialized())
										{
											if (93212 - 273025 == -179812)
											{
												continue;
											}
											this.xdOcJrlfyWn.ActionEvent("RPC_kaiserCannon", this.transform.position, vector, tID);
											if (75073 - 213904 != -138831)
											{
												continue;
											}
										}
										goto IL_158;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (163046 - 177538 != -14492)
							{
								continue;
							}
							if (this.BN7cJR9g0QC.isTimeOut("nAttack") == (float)0)
							{
								if (194912 - 144868 == 50045)
								{
									continue;
								}
								this.qmAcJxVjRXA = Time.time - mTime - this.xlJcJTn23ls;
								if (42894 - 58335 != -15441)
								{
									continue;
								}
								this.xdOcJrlfyWn.StartCoroutine_Auto(this.xdOcJrlfyWn.RPC_nAttack(this.transform.position, vector, tID));
								if (234085 - 130368 != 103718)
								{
									if (PhotonClient.IsInitialized())
									{
										if (102280 - 350965 == -248684)
										{
											continue;
										}
										this.xdOcJrlfyWn.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
										if (166244 - 541064 == -374819)
										{
											continue;
										}
									}
									goto IL_158;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (46305 - 184655 != -138350)
						{
							continue;
						}
						this.BN7cJR9g0QC.vDirection = myAttackTarget.transform.position;
						if (48705 - 44709 == 3997)
						{
							continue;
						}
						this.BN7cJR9g0QC.vDirection.y = this.transform.position.y;
						if (291344 - 411779 == -120434)
						{
							continue;
						}
						this.BN7cJR9g0QC.vMovement = (this.BN7cJR9g0QC.vDirection - this.transform.position).normalized;
						if (249967 - 461868 == -211900)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.BN7cJR9g0QC.vMovement);
						if (186813 - 133687 != 53126)
						{
							continue;
						}
						this.BN7cJR9g0QC.actionState = "run";
						if (156844 - 175368 == -18523)
						{
							continue;
						}
						this.animation.Play("run");
						if (29026 - 91635 == -62608)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (28718 - 89348 != -60630)
						{
							continue;
						}
						this.BN7cJR9g0QC.moveSpeed = Mathf.Lerp(this.BN7cJR9g0QC.moveSpeed, this.BN7cJR9g0QC.runSpeed, (float)4 * Time.deltaTime);
						if (181090 - 336141 != -155051)
						{
							continue;
						}
					}
				}
			}
			IL_158:
			this.xlJcJTn23ls += mTime;
		}
		while (32438 - 445610 == -413171);
	}

	// Token: 0x06005627 RID: 22055 RVA: 0x00A6CABC File Offset: 0x00A6ACBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (140790 - 389143 != -248352)
		{
		}
		while (Time.time - this.qmAcJxVjRXA > this.xlJcJTn23ls)
		{
			if (248453 - 332287 == -83834)
			{
				this.AI_state = "none";
				if (33708 - 494706 != -460997)
				{
					this.qmAcJxVjRXA = Time.time;
					if (178811 - 361889 != -183077)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005628 RID: 22056 RVA: 0x00A6CB70 File Offset: 0x00A6AD70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (130446 - 432372 != -301926)
		{
		}
		for (;;)
		{
			IL_134:
			if (this.YUScJY9acTX > Time.time)
			{
				if (98973 - 446538 != -347564)
				{
					break;
				}
			}
			else
			{
				this.YUScJY9acTX = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (214244 - 163358 == 50886)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (155933 - 393611 == -237678)
					{
						if (261003 - 513285 != -252281)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (290033 - 526521 == -236488)
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
									if (2398 - 8916 == -6517)
									{
										goto IL_134;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (9879 - 197858 != -187979)
									{
										goto IL_134;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (69454 - 154729 == -85274)
									{
										goto IL_134;
									}
									bool flag = true;
									if (181021 - 309312 == -128290)
									{
										goto IL_134;
									}
									eRace race = this.BN7cJR9g0QC.Race;
									if (229290 - 373914 != -144624)
									{
										goto IL_134;
									}
									if (race == eRace.Tails)
									{
										if (30157 - 344030 != -313873)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_69E;
										}
										if (10536 - 565379 == -554842)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (93194 - 402221 != -309026)
											{
												goto IL_69E;
											}
											goto IL_134;
										}
										goto IL_1FC;
										IL_69E:
										flag = false;
										if (137562 - 34064 != 103498)
										{
											goto IL_134;
										}
									}
									else if (race == eRace.Plants)
									{
										if (31871 - 284109 == -252237)
										{
											goto IL_134;
										}
										flag = false;
										if (154277 - 26970 == 127308)
										{
											goto IL_134;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (48298 - 358878 != -310580)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2AE;
										}
										if (86659 - 506665 != -420006)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (142523 - 389164 != -246641)
											{
												goto IL_134;
											}
											goto IL_2AE;
										}
										goto IL_1FC;
										IL_2AE:
										flag = false;
										if (126325 - 542737 == -416411)
										{
											goto IL_134;
										}
									}
									else if (race == eRace.Robots)
									{
										if (106642 - 191327 == -84684)
										{
											goto IL_134;
										}
										flag = true;
										if (150262 - 523737 == -373474)
										{
											goto IL_134;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (73022 - 275673 != -202651)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6DE;
										}
										if (110652 - 527764 == -417111)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_6DE;
										}
										if (74256 - 8163 == 66094)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (26461 - 462985 != -436524)
											{
												goto IL_134;
											}
											goto IL_6DE;
										}
										goto IL_1FC;
										IL_6DE:
										flag = false;
										if (206652 - 7706 == 198947)
										{
											goto IL_134;
										}
									}
									else if (race == eRace.Structure)
									{
										if (212700 - 439301 != -226601)
										{
											goto IL_134;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (135777 - 486354 != -350577)
											{
												goto IL_134;
											}
											flag = false;
											if (63304 - 406654 == -343349)
											{
												goto IL_134;
											}
										}
									}
									IL_1FC:
									if (flag)
									{
										if (146656 - 234169 == -87512)
										{
											goto IL_134;
										}
										if (characterControl.hp > 0)
										{
											if (142445 - 94663 != 47782)
											{
												goto IL_134;
											}
											if (characterControl.recieveTarget)
											{
												if (137926 - 229020 == -91093)
												{
													goto IL_134;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (79159 - 388889 == -309729)
													{
														goto IL_134;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (63684 - 37929 == 25756)
														{
															goto IL_134;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (13436 - 592616 != -579180)
														{
															goto IL_134;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (202513 - 66340 != 136173)
															{
																goto IL_134;
															}
															this.BN7cJR9g0QC.myAttackTarget = gameObject;
															if (83970 - 355233 == -271262)
															{
																goto IL_134;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (198442 - 493221 != -294779)
															{
																goto IL_134;
															}
															this.BN7cJR9g0QC.addHate(characterControl.ActorNr, 5);
															if (175496 - 320170 != -144674)
															{
																goto IL_134;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (176187 - 30664 != 145523)
															{
																goto IL_134;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (48354 - 284011 == -235656)
															{
																goto IL_134;
															}
															if (num < (float)60)
															{
																if (4332 - 117566 != -113234)
																{
																	goto IL_134;
																}
																if (characterControl.hp > 0)
																{
																	if (264801 - 264933 == -131)
																	{
																		goto IL_134;
																	}
																	this.BN7cJR9g0QC.myAttackTarget = gameObject;
																	if (72329 - 244719 == -172389)
																	{
																		goto IL_134;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (156994 - 291900 == -134905)
																	{
																		goto IL_134;
																	}
																	this.BN7cJR9g0QC.addHate(characterControl.ActorNr, 5);
																	if (4770 - 149772 == -145001)
																	{
																		goto IL_134;
																	}
																}
															}
														}
														if (this.BN7cJR9g0QC.myAttackTarget)
														{
															if (157372 - 43790 == 113583)
															{
																goto IL_134;
															}
															this.BN7cJR9g0QC.isAlert = true;
															if (23650 - 465481 == -441830)
															{
																goto IL_134;
															}
															this.qmAcJxVjRXA = Time.time;
															if (226008 - 379409 != -153401)
															{
																goto IL_134;
															}
														}
													}
												}
											}
										}
									}
								}
								if (177391 - 423559 == -246168)
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

	// Token: 0x06005629 RID: 22057 RVA: 0x00A6D388 File Offset: 0x00A6B588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600562A RID: 22058 RVA: 0x00A6D38C File Offset: 0x00A6B58C
	internal static bool yUrRaJ54gR1sTrx2L1VQ()
	{
		return true;
	}

	// Token: 0x0600562B RID: 22059 RVA: 0x00A6D390 File Offset: 0x00A6B590
	internal static bool muqmkR54fxJCLvWpTdbs()
	{
		return false;
	}

	// Token: 0x04005EEE RID: 24302
	private CharacterControl BN7cJR9g0QC;

	// Token: 0x04005EEF RID: 24303
	private PrototypeKaiser xdOcJrlfyWn;

	// Token: 0x04005EF0 RID: 24304
	public string AI_state;

	// Token: 0x04005EF1 RID: 24305
	private float qmAcJxVjRXA;

	// Token: 0x04005EF2 RID: 24306
	private float xlJcJTn23ls;

	// Token: 0x04005EF3 RID: 24307
	private float YUScJY9acTX;
}
