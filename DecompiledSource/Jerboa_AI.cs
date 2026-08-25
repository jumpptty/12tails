using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C9A RID: 3226
[Serializable]
public class Jerboa_AI : MonoBehaviour
{
	// Token: 0x06004849 RID: 18505 RVA: 0x008FAD3C File Offset: 0x008F8F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Jerboa_AI()
	{
		if (281412 - 440565 != -159152)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (38414 - 475035 != -436620)
			{
				base..ctor();
				if (80801 - 214731 == -133930)
				{
					this.AI_state = "none";
					if (278396 - 121065 == 157331)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600484A RID: 18506 RVA: 0x008FADD8 File Offset: 0x008F8FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Pryzl1gYyE = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.iinzG1LBbm = (Jerboa)this.GetComponent(typeof(Jerboa));
	}

	// Token: 0x0600484B RID: 18507 RVA: 0x008FAE10 File Offset: 0x008F9010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (77916 - 473543 != -395626)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (68084 - 341534 == -273449)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (218781 - 174962 == 43820)
				{
					continue;
				}
			}
			if (this.Pryzl1gYyE.isControlled)
			{
				break;
			}
			if (147699 - 170082 != -22382)
			{
				this.AIControl();
				if (21409 - 77617 != -56207)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600484C RID: 18508 RVA: 0x008FAEDC File Offset: 0x008F90DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (52593 - 51964 != 630)
		{
		}
		for (;;)
		{
			this.eMszqGkYqG = (float)0;
			if (99573 - 264321 != -164747)
			{
				if (this.Pryzl1gYyE.isMine)
				{
					if (39658 - 422069 != -382410)
					{
						if (this.Pryzl1gYyE.actionState != "standby")
						{
							if (271897 - 271268 != 629)
							{
								continue;
							}
							if (this.Pryzl1gYyE.actionState != "run")
							{
								if (233743 - 18041 != 215703)
								{
									break;
								}
								continue;
							}
						}
						if (!this.Pryzl1gYyE.isAlert)
						{
							if (1354 - 279841 == -278487)
							{
								if (!this.Pryzl1gYyE.isSummon)
								{
									goto IL_66E;
								}
								if (213506 - 321908 != -108402)
								{
									continue;
								}
								if (!(this.Pryzl1gYyE.mSummoner != null))
								{
									goto IL_66E;
								}
								if (7660 - 139630 != -131970)
								{
									continue;
								}
								Vector3 vector = this.Pryzl1gYyE.mSummoner.transform.position - this.transform.position;
								if (92939 - 4693 == 88247)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (162406 - 417876 != -255470)
									{
										continue;
									}
									this.AI_follow(this.Pryzl1gYyE.mSummoner);
									if (261119 - 537236 != -276117)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (140905 - 122222 == 18684)
									{
										continue;
									}
									this.AI_camp(1f, (float)0);
									if (174951 - 14608 == 160344)
									{
										continue;
									}
									this.AI_resetTimer();
									if (111013 - 372114 == -261100)
									{
										continue;
									}
									this.AI_visionCheck();
									if (3787 - 317951 == -314163)
									{
										continue;
									}
								}
								IL_141:
								if (!this.Pryzl1gYyE.myAttackTarget)
								{
									break;
								}
								if (21886 - 339673 == -317786)
								{
									continue;
								}
								this.Pryzl1gYyE.isAlert = true;
								if (259873 - 392619 != -132746)
								{
									continue;
								}
								this.r3rz1oRD48 = Time.time;
								if (209648 - 297845 != -88196)
								{
									break;
								}
								continue;
								IL_66E:
								this.AI_idle(3f, 1f);
								if (94721 - 321960 != -227238)
								{
									this.AI_patrol(1f, 0.25f);
									if (54918 - 522764 != -467845)
									{
										this.AI_resetTimer();
										if (161299 - 185525 == -24226)
										{
											this.AI_visionCheck();
											if (226502 - 254075 == -27573)
											{
												goto IL_141;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (181667 - 66270 == 115397)
							{
								this.AI_idle(2f, 1f);
								if (79260 - 579697 == -500437)
								{
									this.AI_patrol(3f, 2f);
									if (210420 - 542102 == -331682)
									{
										this.AI_attack(5f, 2f);
										if (58009 - 588272 == -530263)
										{
											this.AI_resetTimer();
											if (237807 - 583419 != -345611)
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
					if (this.Pryzl1gYyE.actionState != "standby")
					{
						if (118237 - 453953 != -335716)
						{
							continue;
						}
						if (this.Pryzl1gYyE.actionState != "run")
						{
							if (249879 - 362178 != -112298)
							{
								break;
							}
							continue;
						}
					}
					float num = this.Pryzl1gYyE.moveSpeed;
					if (167394 - 330738 != -163343)
					{
						float runSpeed = this.Pryzl1gYyE.runSpeed;
						if (201930 - 368708 != -166777)
						{
							Vector3 vector2 = default(Vector3);
							if (25101 - 139439 == -114338)
							{
								Vector3 vector3 = Vector3.zero;
								if (91737 - 2354 != 89384)
								{
									if ((this.Pryzl1gYyE.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (112720 - 256336 != -143616)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.Pryzl1gYyE.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (8612 - 541994 == -533381)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (67276 - 574409 == -507132)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (222029 - 452103 == -230073)
											{
												continue;
											}
											num = (float)0;
											if (9251 - 8273 != 978)
											{
												continue;
											}
											this.transform.position = this.Pryzl1gYyE.nPosition;
											if (193122 - 313369 != -120247)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (266775 - 85063 != 181712)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (81120 - 353354 == -272233)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (237812 - 167645 != 70167)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (31895 - 390425 != -358530)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (224747 - 58511 != 166236)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (172490 - 249014 == -76523)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (142034 - 230609 != -88575)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (104287 - 447990 != -343703)
											{
												continue;
											}
										}
									}
									this.Pryzl1gYyE.vMovement = vector3;
									if (132529 - 465661 == -333132)
									{
										this.Pryzl1gYyE.moveSpeed = num;
										if (172622 - 209364 != -36741)
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

	// Token: 0x0600484D RID: 18509 RVA: 0x008FB70C File Offset: 0x008F990C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (155956 - 219964 != -64007)
		{
		}
		do
		{
			if (Time.time - this.r3rz1oRD48 >= this.eMszqGkYqG)
			{
				if (84856 - 239273 != -154417)
				{
					continue;
				}
				if (Time.time - this.r3rz1oRD48 < this.eMszqGkYqG + mTime)
				{
					if (150418 - 304010 != -153592)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (133474 - 102230 == 31245)
						{
							continue;
						}
						this.AI_state = "idle";
						if (189831 - 596163 == -406331)
						{
							continue;
						}
						this.r3rz1oRD48 -= UnityEngine.Random.Range((float)0, rTimer);
						if (54826 - 240731 == -185904)
						{
							continue;
						}
						this.Pryzl1gYyE.vDirection = Vector3.zero;
						if (43502 - 157219 == -113716)
						{
							continue;
						}
						this.Pryzl1gYyE.vMovement = this.transform.forward;
						if (68995 - 535889 != -466894)
						{
							continue;
						}
						this.Pryzl1gYyE.actionState = "standby";
						if (295800 - 466759 == -170958)
						{
							continue;
						}
					}
					this.Pryzl1gYyE.moveSpeed = Mathf.Lerp(this.Pryzl1gYyE.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (294032 - 192887 == 101146)
					{
						continue;
					}
					if (this.Pryzl1gYyE.moveSpeed < 0.1f * this.Pryzl1gYyE.runSpeed)
					{
						if (57847 - 321215 != -263368)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (125855 - 440776 != -314921)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (153921 - 462791 == -308869)
						{
							continue;
						}
						this.Pryzl1gYyE.moveSpeed = (float)0;
						if (67786 - 292805 != -225019)
						{
							continue;
						}
					}
				}
			}
			this.eMszqGkYqG += mTime;
		}
		while (70292 - 457401 == -387108);
	}

	// Token: 0x0600484E RID: 18510 RVA: 0x008FB9D0 File Offset: 0x008F9BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (166260 - 464898 != -298637)
		{
		}
		for (;;)
		{
			this.Pryzl1gYyE.vDirection = followObject.transform.position;
			if (201984 - 77126 != 124859)
			{
				this.Pryzl1gYyE.vDirection.y = this.transform.position.y;
				if (29501 - 197915 != -168413)
				{
					this.Pryzl1gYyE.vMovement = (this.Pryzl1gYyE.vDirection - this.transform.position).normalized;
					if (296408 - 306614 != -10205)
					{
						this.transform.rotation = Quaternion.LookRotation(this.Pryzl1gYyE.vMovement);
						if (120098 - 526969 != -406870)
						{
							this.Pryzl1gYyE.actionState = "run";
							if (224923 - 16132 == 208791)
							{
								this.animation.Play("run");
								if (43180 - 527624 != -484443)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (25783 - 574299 == -548516)
									{
										this.Pryzl1gYyE.moveSpeed = Mathf.Lerp(this.Pryzl1gYyE.moveSpeed, this.Pryzl1gYyE.runSpeed, (float)4 * Time.deltaTime);
										if (258657 - 469395 == -210738)
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

	// Token: 0x0600484F RID: 18511 RVA: 0x008FBBB8 File Offset: 0x008F9DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (259722 - 406384 != -146661)
		{
		}
		do
		{
			if (Time.time - this.r3rz1oRD48 >= this.eMszqGkYqG)
			{
				if (43336 - 565212 != -521876)
				{
					continue;
				}
				if (Time.time - this.r3rz1oRD48 < this.eMszqGkYqG + mTime)
				{
					if (204853 - 196385 == 8469)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (205302 - 282169 != -76867)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (233823 - 558660 == -324836)
						{
							continue;
						}
						this.r3rz1oRD48 -= UnityEngine.Random.Range((float)0, rTimer);
						if (260522 - 86823 != 173699)
						{
							continue;
						}
						this.Pryzl1gYyE.vDirection = this.Pryzl1gYyE.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (15080 - 192205 == -177124)
						{
							continue;
						}
						this.Pryzl1gYyE.vDirection.y = this.transform.position.y;
						if (13048 - 575866 == -562817)
						{
							continue;
						}
						this.Pryzl1gYyE.vMovement = (this.Pryzl1gYyE.vDirection - this.transform.position).normalized;
						if (95066 - 169864 != -74798)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Pryzl1gYyE.vMovement);
						if (258280 - 266019 == -7738)
						{
							continue;
						}
						this.Pryzl1gYyE.actionState = "run";
						if (36523 - 570737 != -534214)
						{
							continue;
						}
						this.animation.Play("run");
						if (234640 - 308211 != -73571)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (287585 - 571235 == -283649)
						{
							continue;
						}
					}
					this.Pryzl1gYyE.moveSpeed = Mathf.Lerp(this.Pryzl1gYyE.moveSpeed, this.Pryzl1gYyE.runSpeed, (float)4 * Time.deltaTime);
					if (86518 - 595040 == -508521)
					{
						continue;
					}
				}
			}
			this.eMszqGkYqG += mTime;
		}
		while (4958 - 554426 != -549468);
	}

	// Token: 0x06004850 RID: 18512 RVA: 0x008FBEC0 File Offset: 0x008FA0C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (188649 - 379988 != -191338)
		{
		}
		do
		{
			if (Time.time - this.r3rz1oRD48 >= this.eMszqGkYqG)
			{
				if (262993 - 358322 != -95329)
				{
					continue;
				}
				if (Time.time - this.r3rz1oRD48 < this.eMszqGkYqG + mTime)
				{
					if (88754 - 572971 == -484216)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (43821 - 321017 == -277195)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (284405 - 562961 != -278556)
						{
							continue;
						}
						this.r3rz1oRD48 = Time.time - mTime - this.eMszqGkYqG;
						if (219733 - 455762 != -236029)
						{
							continue;
						}
						this.Pryzl1gYyE.vDirection = Vector3.zero;
						if (114098 - 502821 != -388723)
						{
							continue;
						}
						this.Pryzl1gYyE.vMovement = this.transform.forward;
						if (18023 - 316328 != -298305)
						{
							continue;
						}
						this.Pryzl1gYyE.actionState = "standby";
						if (148955 - 289535 == -140579)
						{
							continue;
						}
						this.Pryzl1gYyE.myAttackTarget = this.Pryzl1gYyE.getHateTarget(5, 50);
						if (158698 - 92905 == 65794)
						{
							continue;
						}
						if (!this.Pryzl1gYyE.myAttackTarget)
						{
							if (24937 - 568687 == -543749)
							{
								continue;
							}
							this.Pryzl1gYyE.isAlert = false;
							if (41099 - 25314 != 15785)
							{
								continue;
							}
							this.r3rz1oRD48 = Time.time;
							if (280456 - 215729 != 64727)
							{
								continue;
							}
							this.Pryzl1gYyE.myAttackTarget = null;
							if (15528 - 280219 == -264690)
							{
								continue;
							}
							this.Pryzl1gYyE.mOriginalPosition = this.transform.position;
							if (162358 - 312478 != -150119)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.Pryzl1gYyE.myAttackTarget;
							if (198136 - 291386 != -93250)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (204762 - 363401 == -158638)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (53069 - 214808 == -161738)
								{
									continue;
								}
								this.Pryzl1gYyE.isAlert = false;
								if (65355 - 188930 != -123575)
								{
									continue;
								}
								this.r3rz1oRD48 = Time.time;
								if (98269 - 179394 == -81124)
								{
									continue;
								}
								this.Pryzl1gYyE.myAttackTarget = null;
								if (214531 - 146543 != 67988)
								{
									continue;
								}
							}
							else
							{
								this.Pryzl1gYyE.vDirection = myAttackTarget.transform.position;
								if (56685 - 36882 == 19804)
								{
									continue;
								}
								this.Pryzl1gYyE.vDirection.y = this.transform.position.y;
								if (154444 - 175762 == -21317)
								{
									continue;
								}
								this.Pryzl1gYyE.vMovement = (this.Pryzl1gYyE.vDirection - this.transform.position).normalized;
								if (149539 - 399415 != -249876)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Pryzl1gYyE.vMovement);
								if (15546 - 395290 == -379743)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.eMszqGkYqG += mTime;
		}
		while (107014 - 280826 == -173811);
	}

	// Token: 0x06004851 RID: 18513 RVA: 0x008FC370 File Offset: 0x008FA570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (91736 - 48417 != 43320)
		{
		}
		do
		{
			if (Time.time - this.r3rz1oRD48 >= this.eMszqGkYqG)
			{
				if (18695 - 846 == 17850)
				{
					continue;
				}
				if (Time.time - this.r3rz1oRD48 < this.eMszqGkYqG + mTime)
				{
					if (269348 - 174220 == 95129)
					{
						continue;
					}
					if (!this.Pryzl1gYyE.myAttackTarget)
					{
						if (270445 - 454974 != -184529)
						{
							continue;
						}
						this.r3rz1oRD48 = Time.time - mTime - this.eMszqGkYqG;
						if (259771 - 15544 != 244228)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.Pryzl1gYyE.myAttackTarget;
						if (115452 - 526705 == -411252)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (83092 - 8782 != 74310)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (248077 - 401009 == -152931 || 224055 - 539545 == -315489)
						{
							continue;
						}
						if (characterControl)
						{
							if (5768 - 127209 != -121441)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (190252 - 467595 == -277342)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (292393 - 339639 != -47246)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (106016 - 414586 == -308569)
							{
								continue;
							}
							if (this.Pryzl1gYyE.isTimeOut("nAttack") == (float)0)
							{
								if (147330 - 364818 == -217487)
								{
									continue;
								}
								this.r3rz1oRD48 = Time.time - mTime - this.eMszqGkYqG;
								if (270221 - 219680 == 50542)
								{
									continue;
								}
								this.iinzG1LBbm.StartCoroutine_Auto(this.iinzG1LBbm.RPC_nAttack(this.transform.position, vector.normalized, 0));
								if (19041 - 157312 != -138271)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (113385 - 335637 != -222252)
									{
										continue;
									}
									this.iinzG1LBbm.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, 0);
									if (108257 - 116115 == -7857)
									{
										continue;
									}
								}
								goto IL_2A0;
							}
						}
						this.AI_state = "attack";
						if (231068 - 339559 == -108490)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (187205 - 128643 != 58562)
							{
								continue;
							}
							this.Pryzl1gYyE.vDirection = myAttackTarget.transform.position;
							if (286880 - 353414 != -66534)
							{
								continue;
							}
							this.Pryzl1gYyE.vDirection.y = this.transform.position.y;
							if (201740 - 98165 != 103575)
							{
								continue;
							}
							this.Pryzl1gYyE.vMovement = (this.Pryzl1gYyE.vDirection - this.transform.position).normalized;
							if (237253 - 190575 != 46678)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Pryzl1gYyE.vMovement);
							if (63350 - 212877 == -149526)
							{
								continue;
							}
							this.Pryzl1gYyE.actionState = "run";
							if (206518 - 597161 == -390642)
							{
								continue;
							}
							this.animation.Play("run");
							if (292597 - 367888 == -75290)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (294120 - 275338 == 18783)
							{
								continue;
							}
							this.Pryzl1gYyE.moveSpeed = Mathf.Lerp(this.Pryzl1gYyE.moveSpeed, this.Pryzl1gYyE.runSpeed, (float)4 * Time.deltaTime);
							if (96859 - 275634 == -178774)
							{
								continue;
							}
						}
						else
						{
							this.Pryzl1gYyE.vDirection = myAttackTarget.transform.position;
							if (15466 - 234772 != -219306)
							{
								continue;
							}
							this.Pryzl1gYyE.vDirection.y = this.transform.position.y;
							if (5385 - 372832 != -367447)
							{
								continue;
							}
							this.Pryzl1gYyE.vMovement = (this.Pryzl1gYyE.vDirection - this.transform.position).normalized;
							if (64329 - 577078 != -512749)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Pryzl1gYyE.vMovement);
							if (257187 - 462243 != -205056)
							{
								continue;
							}
							this.Pryzl1gYyE.actionState = "standby";
							if (104829 - 134997 != -30168)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (8511 - 593076 == -584564)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (284720 - 561368 == -276647)
							{
								continue;
							}
							this.Pryzl1gYyE.moveSpeed = Mathf.Lerp(this.Pryzl1gYyE.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (11666 - 173553 == -161886)
							{
								continue;
							}
						}
					}
				}
			}
			IL_2A0:
			this.eMszqGkYqG += mTime;
		}
		while (13985 - 390767 != -376782);
	}

	// Token: 0x06004852 RID: 18514 RVA: 0x008FCA94 File Offset: 0x008FAC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_camp(float mTime, float rTimer)
	{
		if (2298 - 121268 != -118970)
		{
		}
		do
		{
			IL_29B:
			if (Time.time - this.r3rz1oRD48 >= this.eMszqGkYqG)
			{
				if (269887 - 202325 == 67563)
				{
					continue;
				}
				if (Time.time - this.r3rz1oRD48 < this.eMszqGkYqG + mTime)
				{
					if (157439 - 34683 != 122756)
					{
						continue;
					}
					if (this.Pryzl1gYyE.isTimeOut("cAttack") == (float)0)
					{
						if (200151 - 537709 != -337558)
						{
							continue;
						}
						GameObject[] array = GameObject.FindGameObjectsWithTag("Item");
						if (38484 - 498907 != -460423)
						{
							continue;
						}
						bool flag = false;
						if (173543 - 31337 == 142207)
						{
							continue;
						}
						int i = 0;
						if (221201 - 339583 == -118381)
						{
							continue;
						}
						GameObject[] array2 = array;
						if (164556 - 83083 == 81474)
						{
							continue;
						}
						int length = array2.Length;
						if (293455 - 97594 != 195861)
						{
							continue;
						}
						while (i < length)
						{
							if (array2[i].name == "campFire")
							{
								if (137110 - 518241 != -381131)
								{
									goto IL_29B;
								}
								Vector3 vector = array2[i].transform.position - this.transform.position;
								if (292236 - 331548 != -39312)
								{
									goto IL_29B;
								}
								if (vector.sqrMagnitude < (float)196)
								{
									if (26655 - 559198 != -532543)
									{
										goto IL_29B;
									}
									flag = true;
									if (191732 - 158377 != 33355)
									{
										goto IL_29B;
									}
								}
							}
							i++;
							if (293107 - 442228 == -149120)
							{
								goto IL_29B;
							}
						}
						if (106465 - 190032 == -83566)
						{
							continue;
						}
						if (flag)
						{
							if (169214 - 12100 != 157114)
							{
								continue;
							}
							this.Pryzl1gYyE.addTimeOut("cAttack", (float)30);
							if (130026 - 495120 != -365094)
							{
								continue;
							}
						}
						else
						{
							this.r3rz1oRD48 = Time.time - mTime - this.eMszqGkYqG;
							if (180982 - 190050 != -9068)
							{
								continue;
							}
							this.iinzG1LBbm.StartCoroutine_Auto(this.iinzG1LBbm.RPC_camp(this.transform.position, this.transform.forward, 0));
							if (241022 - 503870 != -262848)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (127066 - 457982 == -330915)
								{
									continue;
								}
								this.iinzG1LBbm.ActionEvent("RPC_camp", this.transform.position, this.transform.forward, 0);
								if (60386 - 109725 != -49339)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.eMszqGkYqG += mTime;
		}
		while (121072 - 248273 != -127201);
	}

	// Token: 0x06004853 RID: 18515 RVA: 0x008FCE4C File Offset: 0x008FB04C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (246960 - 494856 != -247895)
		{
		}
		while (Time.time - this.r3rz1oRD48 > this.eMszqGkYqG)
		{
			if (154553 - 436012 == -281459)
			{
				this.AI_state = "none";
				if (149379 - 547440 != -398060)
				{
					this.r3rz1oRD48 = Time.time;
					if (42711 - 374569 != -331857)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004854 RID: 18516 RVA: 0x008FCF00 File Offset: 0x008FB100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (85477 - 129785 != -44308)
		{
		}
		for (;;)
		{
			IL_30E:
			if (this.Cr4zpylJS6 > Time.time)
			{
				if (60987 - 587701 == -526714)
				{
					break;
				}
			}
			else
			{
				this.Cr4zpylJS6 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (156086 - 546951 == -390865)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (51553 - 83395 != -31841 && 34278 - 510609 != -476330)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (264872 - 597368 != -332495)
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
								if (20579 - 456950 != -436371)
								{
									goto IL_30E;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (256741 - 430387 == -173645)
								{
									goto IL_30E;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (187887 - 501440 != -313553)
								{
									goto IL_30E;
								}
								bool flag = true;
								if (112413 - 210941 == -98527)
								{
									goto IL_30E;
								}
								eRace race = this.Pryzl1gYyE.Race;
								if (89344 - 274374 == -185029)
								{
									goto IL_30E;
								}
								if (race == eRace.Tails)
								{
									if (243421 - 245781 == -2359)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_133;
									}
									if (66079 - 122029 != -55950)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (267198 - 465959 != -198761)
										{
											goto IL_30E;
										}
										goto IL_133;
									}
									goto IL_520;
									IL_133:
									flag = false;
									if (216318 - 186807 == 29512)
									{
										goto IL_30E;
									}
								}
								else if (race == eRace.Plants)
								{
									if (236693 - 478690 != -241997)
									{
										goto IL_30E;
									}
									flag = false;
									if (274515 - 576894 == -302378)
									{
										goto IL_30E;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (9633 - 538486 != -528853)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_705;
									}
									if (54047 - 536814 == -482766)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (53212 - 576089 != -522876)
										{
											goto IL_705;
										}
										goto IL_30E;
									}
									goto IL_520;
									IL_705:
									flag = false;
									if (206847 - 520941 == -314093)
									{
										goto IL_30E;
									}
								}
								else if (race == eRace.Robots)
								{
									if (3573 - 392815 == -389241)
									{
										goto IL_30E;
									}
									flag = true;
									if (231110 - 381081 == -149970)
									{
										goto IL_30E;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (180053 - 549476 != -369423)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_176;
									}
									if (283597 - 158520 != 125077)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_176;
									}
									if (60750 - 468551 == -407800)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (39070 - 400772 != -361702)
										{
											goto IL_30E;
										}
										goto IL_176;
									}
									goto IL_520;
									IL_176:
									flag = false;
									if (188882 - 133445 == 55438)
									{
										goto IL_30E;
									}
								}
								else if (race == eRace.Structure)
								{
									if (84994 - 358094 == -273099)
									{
										goto IL_30E;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (284891 - 307163 != -22272)
										{
											goto IL_30E;
										}
										flag = false;
										if (95256 - 283038 == -187781)
										{
											goto IL_30E;
										}
									}
								}
								IL_520:
								if (flag)
								{
									if (100268 - 178858 != -78590)
									{
										goto IL_30E;
									}
									if (characterControl.hp > 0)
									{
										if (22425 - 464070 == -441644)
										{
											goto IL_30E;
										}
										if (characterControl.recieveTarget)
										{
											if (251493 - 519259 == -267765)
											{
												goto IL_30E;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (186327 - 348739 == -162411)
												{
													goto IL_30E;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (162377 - 552320 == -389942)
													{
														goto IL_30E;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (168885 - 364570 == -195684)
													{
														goto IL_30E;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (70229 - 164181 == -93951)
														{
															goto IL_30E;
														}
														this.Pryzl1gYyE.myAttackTarget = gameObject;
														if (174483 - 450154 != -275671)
														{
															goto IL_30E;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (178938 - 97377 != 81561)
														{
															goto IL_30E;
														}
														this.Pryzl1gYyE.addHate(characterControl.ActorNr, 5);
														if (218779 - 405588 == -186808)
														{
															goto IL_30E;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (199866 - 357763 != -157897)
														{
															goto IL_30E;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (293874 - 140180 == 153695)
														{
															goto IL_30E;
														}
														if (num < (float)60)
														{
															if (87836 - 372478 != -284642)
															{
																goto IL_30E;
															}
															if (characterControl.hp > 0)
															{
																if (44984 - 482061 != -437077)
																{
																	goto IL_30E;
																}
																this.Pryzl1gYyE.myAttackTarget = gameObject;
																if (168130 - 416293 == -248162)
																{
																	goto IL_30E;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (60863 - 281370 == -220506)
																{
																	goto IL_30E;
																}
																this.Pryzl1gYyE.addHate(characterControl.ActorNr, 5);
																if (216239 - 572214 == -355974)
																{
																	goto IL_30E;
																}
															}
														}
													}
													if (this.Pryzl1gYyE.myAttackTarget)
													{
														if (141021 - 565500 != -424479)
														{
															goto IL_30E;
														}
														this.Pryzl1gYyE.isAlert = true;
														if (78764 - 335376 == -256611)
														{
															goto IL_30E;
														}
														this.r3rz1oRD48 = Time.time;
														if (108593 - 404962 == -296368)
														{
															goto IL_30E;
														}
													}
												}
											}
										}
									}
								}
							}
							if (150470 - 322267 == -171797)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004855 RID: 18517 RVA: 0x008FD718 File Offset: 0x008FB918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004856 RID: 18518 RVA: 0x008FD71C File Offset: 0x008FB91C
	internal static bool PepNaJ5vVpycwwmMWIrY()
	{
		return true;
	}

	// Token: 0x06004857 RID: 18519 RVA: 0x008FD720 File Offset: 0x008FB920
	internal static bool Ba7Hym5vtvflg8HBkk1f()
	{
		return false;
	}

	// Token: 0x04005347 RID: 21319
	private CharacterControl Pryzl1gYyE;

	// Token: 0x04005348 RID: 21320
	private Jerboa iinzG1LBbm;

	// Token: 0x04005349 RID: 21321
	public string AI_state;

	// Token: 0x0400534A RID: 21322
	private float r3rz1oRD48;

	// Token: 0x0400534B RID: 21323
	private float eMszqGkYqG;

	// Token: 0x0400534C RID: 21324
	private float Cr4zpylJS6;
}
