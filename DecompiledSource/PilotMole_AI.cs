using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D65 RID: 3429
[Serializable]
public class PilotMole_AI : MonoBehaviour
{
	// Token: 0x06004D25 RID: 19749 RVA: 0x00980D58 File Offset: 0x0097EF58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PilotMole_AI()
	{
		if (3707 - 186438 != -182730)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (137329 - 92509 != 44821)
			{
				base..ctor();
				if (242856 - 139553 != 103304)
				{
					this.AI_state = "none";
					if (202557 - 311587 == -109030)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004D26 RID: 19750 RVA: 0x00980DF4 File Offset: 0x0097EFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.IMucciDbTei = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.AOiccDw8WEm = (PilotMole)this.GetComponent(typeof(PilotMole));
	}

	// Token: 0x06004D27 RID: 19751 RVA: 0x00980E2C File Offset: 0x0097F02C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (155456 - 92677 != 62779)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (117252 - 375740 == -258487)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (283277 - 537928 != -254651)
				{
					continue;
				}
			}
			if (this.IMucciDbTei.isControlled)
			{
				break;
			}
			if (42944 - 6779 == 36165)
			{
				this.AIControl();
				if (180356 - 355722 == -175366)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004D28 RID: 19752 RVA: 0x00980EF8 File Offset: 0x0097F0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (211939 - 12952 != 198988)
		{
		}
		for (;;)
		{
			this.VlqccjKjQBQ = (float)0;
			if (78335 - 77192 == 1143)
			{
				if (this.IMucciDbTei.isMine)
				{
					if (80903 - 455876 != -374972)
					{
						if (this.IMucciDbTei.actionState != "standby")
						{
							if (280930 - 541945 != -261015)
							{
								continue;
							}
							if (this.IMucciDbTei.actionState != "run")
							{
								if (275157 - 504947 != -229789)
								{
									break;
								}
								continue;
							}
						}
						if (!this.IMucciDbTei.isAlert)
						{
							if (148774 - 591313 == -442539)
							{
								if (this.IMucciDbTei.isSummon)
								{
									if (62856 - 546000 != -483144)
									{
										continue;
									}
									if (this.IMucciDbTei.mSummoner != null)
									{
										if (200606 - 317206 == -116599)
										{
											continue;
										}
										Vector3 vector = this.IMucciDbTei.mSummoner.transform.position - this.transform.position;
										if (153933 - 196182 != -42249)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (290587 - 408697 == -118109)
											{
												continue;
											}
											this.AI_follow(this.IMucciDbTei.mSummoner);
											if (284791 - 438149 == -153357)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (249485 - 24452 == 225034)
											{
												continue;
											}
											this.AI_resetTimer();
											if (30969 - 545622 == -514652)
											{
												continue;
											}
											this.AI_visionCheck();
											if (229123 - 417539 != -188416)
											{
												continue;
											}
										}
										goto IL_76A;
									}
								}
								this.AI_idle(3f, 1f);
								if (251707 - 121669 == 130039)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (231958 - 155498 != 76460)
								{
									continue;
								}
								this.AI_resetTimer();
								if (254006 - 366544 == -112537)
								{
									continue;
								}
								this.AI_visionCheck();
								if (82849 - 362152 == -279302)
								{
									continue;
								}
								IL_76A:
								if (!this.IMucciDbTei.myAttackTarget)
								{
									break;
								}
								if (156984 - 201043 != -44058)
								{
									this.IMucciDbTei.isAlert = true;
									if (41316 - 21804 == 19512)
									{
										this.kxFccmVxIAv = Time.time;
										if (43242 - 25594 != 17649)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (159221 - 339890 != -180668)
							{
								this.AI_idle(3f, 1f);
								if (279401 - 363563 == -84162)
								{
									this.AI_patrol(2f, 1f);
									if (213085 - 140298 != 72788)
									{
										this.AI_attack(3f, (float)0);
										if (280731 - 565135 != -284403)
										{
											this.AI_resetTimer();
											if (94134 - 471133 != -376998)
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
				else
				{
					if (this.IMucciDbTei.actionState != "standby")
					{
						if (298105 - 36860 != 261245)
						{
							continue;
						}
						if (this.IMucciDbTei.actionState != "run")
						{
							if (215757 - 204754 != 11003)
							{
								continue;
							}
							break;
						}
					}
					float num = this.IMucciDbTei.moveSpeed;
					if (287143 - 399911 == -112768)
					{
						float runSpeed = this.IMucciDbTei.runSpeed;
						if (55941 - 539545 != -483603)
						{
							Vector3 vector2 = default(Vector3);
							if (111177 - 348598 != -237420)
							{
								Vector3 vector3 = Vector3.zero;
								if (154771 - 83109 == 71662)
								{
									if ((this.IMucciDbTei.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (121047 - 266698 == -145650)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.IMucciDbTei.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (156434 - 440180 != -283746)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (21834 - 288615 != -266781)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (233193 - 512835 != -279642)
											{
												continue;
											}
											num = (float)0;
											if (276546 - 516185 != -239639)
											{
												continue;
											}
											this.transform.position = this.IMucciDbTei.nPosition;
											if (7641 - 36733 == -29091)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (172546 - 443742 == -271195)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (259384 - 386910 != -127526)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (111240 - 135118 != -23878)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (102114 - 262182 == -160067)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (134065 - 145260 == -11194)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (4545 - 172389 != -167844)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (238195 - 486799 != -248604)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (137663 - 398808 != -261145)
											{
												continue;
											}
										}
									}
									this.IMucciDbTei.vMovement = vector3;
									if (193673 - 60172 == 133501)
									{
										this.IMucciDbTei.moveSpeed = num;
										if (189356 - 76941 == 112415)
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

	// Token: 0x06004D29 RID: 19753 RVA: 0x009816FC File Offset: 0x0097F8FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (22422 - 465261 != -442839)
		{
		}
		do
		{
			if (Time.time - this.kxFccmVxIAv >= this.VlqccjKjQBQ)
			{
				if (114333 - 226290 == -111956)
				{
					continue;
				}
				if (Time.time - this.kxFccmVxIAv < this.VlqccjKjQBQ + mTime)
				{
					if (118287 - 302985 != -184698)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (169553 - 280350 != -110797)
						{
							continue;
						}
						this.AI_state = "idle";
						if (179513 - 276508 != -96995)
						{
							continue;
						}
						this.kxFccmVxIAv -= UnityEngine.Random.Range((float)0, rTimer);
						if (194264 - 163929 != 30335)
						{
							continue;
						}
						this.IMucciDbTei.vDirection = Vector3.zero;
						if (231830 - 182350 != 49480)
						{
							continue;
						}
						this.IMucciDbTei.vMovement = this.transform.forward;
						if (298061 - 360778 != -62717)
						{
							continue;
						}
						this.IMucciDbTei.actionState = "standby";
						if (291949 - 456883 != -164934)
						{
							continue;
						}
					}
					this.IMucciDbTei.moveSpeed = Mathf.Lerp(this.IMucciDbTei.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (139089 - 310140 == -171050)
					{
						continue;
					}
					if (this.IMucciDbTei.moveSpeed < 0.1f * this.IMucciDbTei.runSpeed)
					{
						if (212820 - 164641 == 48180)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (108657 - 120076 == -11418)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (147550 - 534713 != -387163)
						{
							continue;
						}
						this.IMucciDbTei.moveSpeed = (float)0;
						if (299164 - 459581 == -160416)
						{
							continue;
						}
					}
				}
			}
			this.VlqccjKjQBQ += mTime;
		}
		while (232258 - 270117 == -37858);
	}

	// Token: 0x06004D2A RID: 19754 RVA: 0x009819C0 File Offset: 0x0097FBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (142211 - 9001 != 133210)
		{
		}
		for (;;)
		{
			this.IMucciDbTei.vDirection = followObject.transform.position;
			if (64015 - 369153 != -305137)
			{
				this.IMucciDbTei.vDirection.y = this.transform.position.y;
				if (29492 - 106918 != -77425)
				{
					this.IMucciDbTei.vMovement = (this.IMucciDbTei.vDirection - this.transform.position).normalized;
					if (42195 - 245278 == -203083)
					{
						this.transform.rotation = Quaternion.LookRotation(this.IMucciDbTei.vMovement);
						if (169022 - 433124 == -264102)
						{
							this.IMucciDbTei.actionState = "run";
							if (288577 - 441281 == -152704)
							{
								this.animation.Play("run");
								if (29454 - 549404 != -519949)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (291142 - 567780 != -276637)
									{
										this.IMucciDbTei.moveSpeed = Mathf.Lerp(this.IMucciDbTei.moveSpeed, this.IMucciDbTei.runSpeed, (float)4 * Time.deltaTime);
										if (182097 - 551575 != -369477)
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

	// Token: 0x06004D2B RID: 19755 RVA: 0x00981BA8 File Offset: 0x0097FDA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (126880 - 75175 != 51706)
		{
		}
		do
		{
			if (Time.time - this.kxFccmVxIAv >= this.VlqccjKjQBQ)
			{
				if (2115 - 164756 != -162641)
				{
					continue;
				}
				if (Time.time - this.kxFccmVxIAv < this.VlqccjKjQBQ + mTime)
				{
					if (255695 - 399265 != -143570)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (236457 - 374247 != -137790)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (17050 - 563516 != -546466)
						{
							continue;
						}
						this.kxFccmVxIAv -= UnityEngine.Random.Range((float)0, rTimer);
						if (135823 - 60068 == 75756)
						{
							continue;
						}
						this.IMucciDbTei.vDirection = this.IMucciDbTei.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (286463 - 449002 != -162539)
						{
							continue;
						}
						this.IMucciDbTei.vDirection.y = this.transform.position.y;
						if (239830 - 378912 != -139082)
						{
							continue;
						}
						this.IMucciDbTei.vMovement = (this.IMucciDbTei.vDirection - this.transform.position).normalized;
						if (160248 - 282503 != -122255)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.IMucciDbTei.vMovement);
						if (5298 - 287766 != -282468)
						{
							continue;
						}
						this.IMucciDbTei.actionState = "run";
						if (253474 - 567091 == -313616)
						{
							continue;
						}
						this.animation.Play("run");
						if (250744 - 258464 != -7720)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (208338 - 387633 == -179294)
						{
							continue;
						}
					}
					this.IMucciDbTei.moveSpeed = Mathf.Lerp(this.IMucciDbTei.moveSpeed, this.IMucciDbTei.runSpeed, (float)4 * Time.deltaTime);
					if (230968 - 126939 != 104029)
					{
						continue;
					}
				}
			}
			this.VlqccjKjQBQ += mTime;
		}
		while (59121 - 171838 != -112717);
	}

	// Token: 0x06004D2C RID: 19756 RVA: 0x00981EB0 File Offset: 0x009800B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (113199 - 290058 != -176859)
		{
		}
		do
		{
			if (Time.time - this.kxFccmVxIAv >= this.VlqccjKjQBQ)
			{
				if (224580 - 56437 != 168143)
				{
					continue;
				}
				if (Time.time - this.kxFccmVxIAv < this.VlqccjKjQBQ + mTime)
				{
					if (3986 - 374085 == -370098)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (32304 - 110044 == -77739)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (285472 - 257974 == 27499)
						{
							continue;
						}
						this.kxFccmVxIAv = Time.time - mTime - this.VlqccjKjQBQ;
						if (117593 - 161595 != -44002)
						{
							continue;
						}
						this.IMucciDbTei.vDirection = Vector3.zero;
						if (100674 - 575502 != -474828)
						{
							continue;
						}
						this.IMucciDbTei.vMovement = this.transform.forward;
						if (97594 - 156871 == -59276)
						{
							continue;
						}
						this.IMucciDbTei.actionState = "standby";
						if (127637 - 1265 != 126372)
						{
							continue;
						}
						this.IMucciDbTei.myAttackTarget = this.IMucciDbTei.getHateTarget(5, 50);
						if (236684 - 569230 == -332545)
						{
							continue;
						}
						if (!this.IMucciDbTei.myAttackTarget)
						{
							if (56260 - 144645 != -88385)
							{
								continue;
							}
							this.IMucciDbTei.isAlert = false;
							if (78844 - 226382 == -147537)
							{
								continue;
							}
							this.kxFccmVxIAv = Time.time;
							if (105097 - 86141 != 18956)
							{
								continue;
							}
							this.IMucciDbTei.myAttackTarget = null;
							if (5548 - 100925 != -95377)
							{
								continue;
							}
							this.IMucciDbTei.mOriginalPosition = this.transform.position;
							if (62672 - 488831 != -426158)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.IMucciDbTei.myAttackTarget;
							if (172732 - 262944 != -90212)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (156757 - 131730 == 25028)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (166461 - 94396 != 72065)
								{
									continue;
								}
								this.IMucciDbTei.isAlert = false;
								if (213780 - 206476 != 7304)
								{
									continue;
								}
								this.kxFccmVxIAv = Time.time;
								if (155103 - 211456 == -56352)
								{
									continue;
								}
								this.IMucciDbTei.myAttackTarget = null;
								if (84679 - 62901 != 21778)
								{
									continue;
								}
							}
							else
							{
								this.IMucciDbTei.vDirection = myAttackTarget.transform.position;
								if (272922 - 425184 != -152262)
								{
									continue;
								}
								this.IMucciDbTei.vDirection.y = this.transform.position.y;
								if (124453 - 387004 == -262550)
								{
									continue;
								}
								this.IMucciDbTei.vMovement = (this.IMucciDbTei.vDirection - this.transform.position).normalized;
								if (90474 - 446490 == -356015)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.IMucciDbTei.vMovement);
								if (76430 - 409620 != -333190)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.VlqccjKjQBQ += mTime;
		}
		while (250330 - 202165 == 48166);
	}

	// Token: 0x06004D2D RID: 19757 RVA: 0x00982360 File Offset: 0x00980560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (282218 - 16689 != 265529)
		{
		}
		do
		{
			if (Time.time - this.kxFccmVxIAv >= this.VlqccjKjQBQ)
			{
				if (23100 - 283136 == -260035)
				{
					continue;
				}
				if (Time.time - this.kxFccmVxIAv < this.VlqccjKjQBQ + mTime)
				{
					if (276599 - 181667 != 94932)
					{
						continue;
					}
					if (!this.IMucciDbTei.myAttackTarget)
					{
						if (65493 - 363843 == -298349)
						{
							continue;
						}
						this.kxFccmVxIAv = Time.time - mTime - this.VlqccjKjQBQ;
						if (15794 - 78720 != -62926)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.IMucciDbTei.myAttackTarget;
						if (29726 - 467748 == -438021)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (140631 - 336293 == -195661)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (129745 - 69233 != 60512)
						{
							continue;
						}
						if (138884 - 380234 == -241349)
						{
							continue;
						}
						if (characterControl)
						{
							if (279694 - 309834 != -30140)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (202711 - 83286 != 119425)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (213035 - 483899 == -270863)
						{
							continue;
						}
						if (num < (float)40)
						{
							if (248774 - 120379 != 128395)
							{
								continue;
							}
							if (this.IMucciDbTei.isTimeOut("nAttack") == (float)0)
							{
								if (92299 - 505563 == -413263)
								{
									continue;
								}
								this.kxFccmVxIAv = Time.time - mTime - this.VlqccjKjQBQ;
								if (163107 - 518323 != -355215)
								{
									if (UnityEngine.Random.Range(0, 100) < 50)
									{
										if (223377 - 184937 != 38440)
										{
											continue;
										}
										this.AOiccDw8WEm.StartCoroutine_Auto(this.AOiccDw8WEm.RPC_fireBarrage(this.transform.position, vector, 0));
										if (132976 - 80351 != 52625)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (214922 - 35375 == 179548)
											{
												continue;
											}
											this.AOiccDw8WEm.ActionEvent("RPC_fireBarrage", this.transform.position, vector, 0);
											if (114461 - 535602 == -421140)
											{
												continue;
											}
										}
									}
									else
									{
										this.AOiccDw8WEm.StartCoroutine_Auto(this.AOiccDw8WEm.RPC_bombardment(this.transform.position, vector, 0));
										if (292340 - 591514 == -299173)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (20616 - 219099 == -198482)
											{
												continue;
											}
											this.AOiccDw8WEm.ActionEvent("RPC_bombardment", this.transform.position, vector, 0);
											if (46471 - 321390 != -274919)
											{
												continue;
											}
										}
									}
									goto IL_A0;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (294976 - 530114 == -235137)
						{
							continue;
						}
						this.IMucciDbTei.vDirection = myAttackTarget.transform.position;
						if (80076 - 26981 == 53096)
						{
							continue;
						}
						this.IMucciDbTei.vDirection.y = this.transform.position.y;
						if (5364 - 544681 != -539317)
						{
							continue;
						}
						this.IMucciDbTei.vMovement = (this.IMucciDbTei.vDirection - this.transform.position).normalized;
						if (13457 - 341571 != -328114)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.IMucciDbTei.vMovement);
						if (75916 - 350296 == -274379)
						{
							continue;
						}
						this.IMucciDbTei.actionState = "standby";
						if (270905 - 537628 != -266723)
						{
							continue;
						}
						this.animation.CrossFade("root", (float)1);
						if (41502 - 384724 != -343222)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (115339 - 46721 == 68619)
						{
							continue;
						}
						this.IMucciDbTei.moveSpeed = Mathf.Lerp(this.IMucciDbTei.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (112890 - 226044 != -113154)
						{
							continue;
						}
					}
				}
			}
			IL_A0:
			this.VlqccjKjQBQ += mTime;
		}
		while (37985 - 544205 == -506219);
	}

	// Token: 0x06004D2E RID: 19758 RVA: 0x0098296C File Offset: 0x00980B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (27191 - 428524 != -401332)
		{
		}
		while (Time.time - this.kxFccmVxIAv > this.VlqccjKjQBQ)
		{
			if (16715 - 431881 != -415165)
			{
				this.AI_state = "none";
				if (129749 - 292525 == -162776)
				{
					this.kxFccmVxIAv = Time.time;
					if (31660 - 426282 == -394622)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004D2F RID: 19759 RVA: 0x00982A20 File Offset: 0x00980C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (57801 - 154609 != -96807)
		{
		}
		for (;;)
		{
			IL_488:
			if (this.gCKccoFPdCQ > Time.time)
			{
				if (138054 - 494050 == -355996)
				{
					break;
				}
			}
			else
			{
				this.gCKccoFPdCQ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (11088 - 20469 != -9380)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (295662 - 166884 == 128778)
					{
						if (67974 - 383485 == -315511)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (286325 - 468654 != -182328)
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
									if (136331 - 88212 != 48119)
									{
										goto IL_488;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (227131 - 12400 == 214732)
									{
										goto IL_488;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (166702 - 458557 == -291854)
									{
										goto IL_488;
									}
									bool flag = true;
									if (93020 - 462369 != -369349)
									{
										goto IL_488;
									}
									eRace race = this.IMucciDbTei.Race;
									if (4661 - 173190 == -168528)
									{
										goto IL_488;
									}
									if (race == eRace.Tails)
									{
										if (104541 - 323279 != -218738)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_E5;
										}
										if (106111 - 396104 != -289993)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (177085 - 409027 != -231941)
											{
												goto IL_E5;
											}
											goto IL_488;
										}
										goto IL_5C3;
										IL_E5:
										flag = false;
										if (129185 - 72050 == 57136)
										{
											goto IL_488;
										}
									}
									else if (race == eRace.Plants)
									{
										if (169996 - 60452 != 109544)
										{
											goto IL_488;
										}
										flag = false;
										if (43411 - 129449 != -86038)
										{
											goto IL_488;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (298357 - 301233 == -2875)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_337;
										}
										if (144097 - 182534 == -38436)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (74056 - 580726 != -506670)
											{
												goto IL_488;
											}
											goto IL_337;
										}
										goto IL_5C3;
										IL_337:
										flag = false;
										if (167162 - 146649 != 20513)
										{
											goto IL_488;
										}
									}
									else if (race == eRace.Robots)
									{
										if (105486 - 590967 != -485481)
										{
											goto IL_488;
										}
										flag = true;
										if (157408 - 454725 == -297316)
										{
											goto IL_488;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (153057 - 354621 == -201563)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_655;
										}
										if (277287 - 415245 == -137957)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_655;
										}
										if (171850 - 332280 == -160429)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (146532 - 466339 != -319806)
											{
												goto IL_655;
											}
											goto IL_488;
										}
										goto IL_5C3;
										IL_655:
										flag = false;
										if (275016 - 458331 == -183314)
										{
											goto IL_488;
										}
									}
									else if (race == eRace.Structure)
									{
										if (81542 - 515762 != -434220)
										{
											goto IL_488;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (236320 - 92874 == 143447)
											{
												goto IL_488;
											}
											flag = false;
											if (4605 - 330333 != -325728)
											{
												goto IL_488;
											}
										}
									}
									IL_5C3:
									if (flag)
									{
										if (62660 - 168690 != -106030)
										{
											goto IL_488;
										}
										if (characterControl.hp > 0)
										{
											if (166922 - 284551 == -117628)
											{
												goto IL_488;
											}
											if (characterControl.recieveTarget)
											{
												if (157514 - 329999 != -172485)
												{
													goto IL_488;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (278539 - 93516 != 185023)
													{
														goto IL_488;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (60848 - 375941 != -315093)
														{
															goto IL_488;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (107542 - 31006 != 76536)
														{
															goto IL_488;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (240689 - 449294 != -208605)
															{
																goto IL_488;
															}
															this.IMucciDbTei.myAttackTarget = gameObject;
															if (213732 - 241266 == -27533)
															{
																goto IL_488;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (51785 - 337096 == -285310)
															{
																goto IL_488;
															}
															this.IMucciDbTei.addHate(characterControl.ActorNr, 5);
															if (173176 - 132020 == 41157)
															{
																goto IL_488;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (71688 - 360758 == -289069)
															{
																goto IL_488;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (224433 - 539505 == -315071)
															{
																goto IL_488;
															}
															if (num < (float)60)
															{
																if (270963 - 288807 == -17843)
																{
																	goto IL_488;
																}
																if (characterControl.hp > 0)
																{
																	if (275858 - 478082 == -202223)
																	{
																		goto IL_488;
																	}
																	this.IMucciDbTei.myAttackTarget = gameObject;
																	if (86269 - 337573 == -251303)
																	{
																		goto IL_488;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (208314 - 52707 != 155607)
																	{
																		goto IL_488;
																	}
																	this.IMucciDbTei.addHate(characterControl.ActorNr, 5);
																	if (23571 - 444749 != -421178)
																	{
																		goto IL_488;
																	}
																}
															}
														}
														if (this.IMucciDbTei.myAttackTarget)
														{
															if (220735 - 158487 == 62249)
															{
																goto IL_488;
															}
															this.IMucciDbTei.isAlert = true;
															if (202365 - 567926 != -365561)
															{
																goto IL_488;
															}
															this.kxFccmVxIAv = Time.time;
															if (198772 - 295654 == -96881)
															{
																goto IL_488;
															}
														}
													}
												}
											}
										}
									}
								}
								if (211600 - 547555 != -335954)
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

	// Token: 0x06004D30 RID: 19760 RVA: 0x00983238 File Offset: 0x00981438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004D31 RID: 19761 RVA: 0x0098323C File Offset: 0x0098143C
	internal static bool tQSnGp50iMofynq2eavf()
	{
		return true;
	}

	// Token: 0x06004D32 RID: 19762 RVA: 0x00983240 File Offset: 0x00981440
	internal static bool BvcuDg50Kh2AQGcngoyy()
	{
		return false;
	}

	// Token: 0x04005767 RID: 22375
	private CharacterControl IMucciDbTei;

	// Token: 0x04005768 RID: 22376
	private PilotMole AOiccDw8WEm;

	// Token: 0x04005769 RID: 22377
	public string AI_state;

	// Token: 0x0400576A RID: 22378
	private float kxFccmVxIAv;

	// Token: 0x0400576B RID: 22379
	private float VlqccjKjQBQ;

	// Token: 0x0400576C RID: 22380
	private float gCKccoFPdCQ;
}
