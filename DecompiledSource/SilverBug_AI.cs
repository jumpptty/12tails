using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001ED RID: 493
[Serializable]
public class SilverBug_AI : MonoBehaviour
{
	// Token: 0x06000B16 RID: 2838 RVA: 0x0011D358 File Offset: 0x0011B558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SilverBug_AI()
	{
		if (86623 - 432952 != -346328)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (42920 - 127093 != -84172)
			{
				base..ctor();
				if (81686 - 228669 != -146982)
				{
					this.AI_state = "none";
					if (51154 - 474971 == -423817)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x0011D3F4 File Offset: 0x0011B5F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.z7Ae1Rg4tB = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.HWPeqb0t7s = (SilverBug)this.GetComponent(typeof(SilverBug));
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x0011D42C File Offset: 0x0011B62C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (41197 - 193365 != -152168)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (160668 - 350392 == -189723)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (156742 - 507860 != -351118)
				{
					continue;
				}
			}
			if (this.z7Ae1Rg4tB.isControlled)
			{
				break;
			}
			if (21113 - 373787 != -352673)
			{
				this.AIControl();
				if (128923 - 217889 != -88965)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x0011D4F8 File Offset: 0x0011B6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (160432 - 392278 != -231846)
		{
		}
		for (;;)
		{
			this.koMeRNh5gJ = (float)0;
			if (297933 - 154462 != 143472)
			{
				if (this.z7Ae1Rg4tB.isMine)
				{
					if (13605 - 42021 != -28415)
					{
						if (this.z7Ae1Rg4tB.actionState != "standby")
						{
							if (163509 - 225940 == -62430)
							{
								continue;
							}
							if (this.z7Ae1Rg4tB.actionState != "run")
							{
								if (160872 - 137683 != 23190)
								{
									break;
								}
								continue;
							}
						}
						if (!this.z7Ae1Rg4tB.isAlert)
						{
							if (41334 - 345351 != -304016)
							{
								this.AI_idle(3f, 1f);
								if (147856 - 264229 != -116372)
								{
									this.AI_patrol(1f, 0.25f);
									if (215525 - 352742 != -137216)
									{
										this.AI_resetTimer();
										if (138063 - 345980 != -207916)
										{
											this.AI_visionCheck();
											if (115491 - 345998 != -230506)
											{
												if (!this.z7Ae1Rg4tB.myAttackTarget)
												{
													break;
												}
												if (151452 - 332822 == -181370)
												{
													this.z7Ae1Rg4tB.isAlert = true;
													if (244475 - 438805 != -194329)
													{
														this.gKCepmiWQL = Time.time;
														if (38120 - 8776 != 29345)
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
							if (98081 - 186090 != -88008)
							{
								this.AI_idle(3f, 1f);
								if (128073 - 406814 == -278741)
								{
									this.AI_attack(10f, (float)0);
									if (235376 - 573817 == -338441)
									{
										this.AI_resetTimer();
										if (259454 - 450251 == -190797)
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
					if (this.z7Ae1Rg4tB.actionState != "standby")
					{
						if (62327 - 521822 != -459495)
						{
							continue;
						}
						if (this.z7Ae1Rg4tB.actionState != "run")
						{
							if (60471 - 286800 != -226329)
							{
								continue;
							}
							break;
						}
					}
					float num = this.z7Ae1Rg4tB.moveSpeed;
					if (96407 - 420430 == -324023)
					{
						float runSpeed = this.z7Ae1Rg4tB.runSpeed;
						if (40968 - 197733 != -156764)
						{
							Vector3 vector = default(Vector3);
							if (122987 - 540967 == -417980)
							{
								Vector3 vector2 = Vector3.zero;
								if (59701 - 455235 != -395533)
								{
									if ((this.z7Ae1Rg4tB.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (270514 - 211078 != 59436)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.z7Ae1Rg4tB.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (125023 - 136047 == -11023)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (278340 - 587998 == -309657)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (43211 - 554322 != -511111)
											{
												continue;
											}
											num = (float)0;
											if (6032 - 519019 == -512986)
											{
												continue;
											}
											this.transform.position = this.z7Ae1Rg4tB.nPosition;
											if (7478 - 103617 == -96138)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (17859 - 15144 == 2716)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (100130 - 413998 != -313868)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (191016 - 281583 == -90566)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (60189 - 338970 != -278781)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (102639 - 300944 != -198305)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (103195 - 378114 == -274918)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (191417 - 303728 == -112310)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (148968 - 232437 != -83469)
											{
												continue;
											}
										}
									}
									this.z7Ae1Rg4tB.vMovement = vector2;
									if (53316 - 393503 != -340186)
									{
										this.z7Ae1Rg4tB.moveSpeed = num;
										if (262264 - 23709 == 238555)
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

	// Token: 0x06000B1A RID: 2842 RVA: 0x0011DB70 File Offset: 0x0011BD70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (11762 - 516205 != -504443)
		{
		}
		do
		{
			if (Time.time - this.gKCepmiWQL >= this.koMeRNh5gJ)
			{
				if (193068 - 534198 == -341129)
				{
					continue;
				}
				if (Time.time - this.gKCepmiWQL < this.koMeRNh5gJ + mTime)
				{
					if (292528 - 220511 != 72017)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (256582 - 516893 != -260311)
						{
							continue;
						}
						this.AI_state = "idle";
						if (298285 - 445610 == -147324)
						{
							continue;
						}
						this.gKCepmiWQL -= UnityEngine.Random.Range((float)0, rTimer);
						if (231397 - 266869 == -35471)
						{
							continue;
						}
						this.z7Ae1Rg4tB.vDirection = Vector3.zero;
						if (83999 - 111658 != -27659)
						{
							continue;
						}
						this.z7Ae1Rg4tB.vMovement = this.transform.forward;
						if (163057 - 441980 != -278923)
						{
							continue;
						}
						this.z7Ae1Rg4tB.actionState = "standby";
						if (107486 - 569248 != -461762)
						{
							continue;
						}
					}
					this.z7Ae1Rg4tB.moveSpeed = Mathf.Lerp(this.z7Ae1Rg4tB.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (213881 - 101038 != 112843)
					{
						continue;
					}
					if (this.z7Ae1Rg4tB.moveSpeed < 0.1f * this.z7Ae1Rg4tB.runSpeed)
					{
						if (72202 - 346432 != -274230)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (34972 - 468496 == -433523)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (193584 - 14818 == 178767)
						{
							continue;
						}
						this.z7Ae1Rg4tB.moveSpeed = (float)0;
						if (58806 - 74607 != -15801)
						{
							continue;
						}
					}
				}
			}
			this.koMeRNh5gJ += mTime;
		}
		while (31187 - 212611 != -181424);
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x0011DE34 File Offset: 0x0011C034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (206569 - 572042 != -365473)
		{
		}
		do
		{
			if (Time.time - this.gKCepmiWQL >= this.koMeRNh5gJ)
			{
				if (236205 - 201969 == 34237)
				{
					continue;
				}
				if (Time.time - this.gKCepmiWQL < this.koMeRNh5gJ + mTime)
				{
					if (184100 - 101865 == 82236)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (37042 - 169035 == -131992)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (265082 - 66900 != 198182)
						{
							continue;
						}
						this.gKCepmiWQL -= UnityEngine.Random.Range((float)0, rTimer);
						if (211469 - 578066 != -366597)
						{
							continue;
						}
						this.z7Ae1Rg4tB.vDirection = this.z7Ae1Rg4tB.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (70531 - 97622 != -27091)
						{
							continue;
						}
						this.z7Ae1Rg4tB.vDirection.y = this.transform.position.y;
						if (232521 - 310295 != -77774)
						{
							continue;
						}
						this.z7Ae1Rg4tB.vMovement = (this.z7Ae1Rg4tB.vDirection - this.transform.position).normalized;
						if (284563 - 253729 != 30834)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.z7Ae1Rg4tB.vMovement);
						if (123137 - 11173 != 111964)
						{
							continue;
						}
						this.z7Ae1Rg4tB.actionState = "run";
						if (290968 - 34253 == 256716)
						{
							continue;
						}
						this.animation.Play("run");
						if (160221 - 94447 == 65775)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (80546 - 25053 != 55493)
						{
							continue;
						}
					}
					this.z7Ae1Rg4tB.moveSpeed = Mathf.Lerp(this.z7Ae1Rg4tB.moveSpeed, this.z7Ae1Rg4tB.runSpeed, (float)4 * Time.deltaTime);
					if (259159 - 163886 == 95274)
					{
						continue;
					}
				}
			}
			this.koMeRNh5gJ += mTime;
		}
		while (25064 - 588163 != -563099);
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x0011E13C File Offset: 0x0011C33C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (58909 - 34454 != 24456)
		{
		}
		do
		{
			if (Time.time - this.gKCepmiWQL >= this.koMeRNh5gJ)
			{
				if (4263 - 60696 == -56432)
				{
					continue;
				}
				if (Time.time - this.gKCepmiWQL < this.koMeRNh5gJ + mTime)
				{
					if (170601 - 319433 != -148832)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (152699 - 415278 != -262579)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (254153 - 126641 == 127513)
						{
							continue;
						}
						this.gKCepmiWQL = Time.time - mTime - this.koMeRNh5gJ;
						if (25911 - 471489 != -445578)
						{
							continue;
						}
						this.z7Ae1Rg4tB.vDirection = Vector3.zero;
						if (112974 - 347764 != -234790)
						{
							continue;
						}
						this.z7Ae1Rg4tB.vMovement = this.transform.forward;
						if (72900 - 230591 == -157690)
						{
							continue;
						}
						this.z7Ae1Rg4tB.actionState = "standby";
						if (231848 - 188089 != 43759)
						{
							continue;
						}
						this.z7Ae1Rg4tB.myAttackTarget = this.z7Ae1Rg4tB.getHateTarget(5, 50);
						if (189456 - 384751 == -195294)
						{
							continue;
						}
						if (!this.z7Ae1Rg4tB.myAttackTarget)
						{
							if (260417 - 86967 != 173450)
							{
								continue;
							}
							this.z7Ae1Rg4tB.isAlert = false;
							if (272367 - 597051 != -324684)
							{
								continue;
							}
							this.gKCepmiWQL = Time.time;
							if (190232 - 54962 == 135271)
							{
								continue;
							}
							this.z7Ae1Rg4tB.myAttackTarget = null;
							if (14593 - 20705 == -6111)
							{
								continue;
							}
							this.z7Ae1Rg4tB.mOriginalPosition = this.transform.position;
							if (30416 - 325880 != -295464)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.z7Ae1Rg4tB.myAttackTarget;
							if (112060 - 531669 == -419608)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (18931 - 414442 == -395510)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (251748 - 586260 != -334512)
								{
									continue;
								}
								this.z7Ae1Rg4tB.isAlert = false;
								if (54796 - 231100 != -176304)
								{
									continue;
								}
								this.gKCepmiWQL = Time.time;
								if (183668 - 393626 != -209958)
								{
									continue;
								}
								this.z7Ae1Rg4tB.myAttackTarget = null;
								if (134413 - 132469 == 1945)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.koMeRNh5gJ += mTime;
		}
		while (54765 - 461381 == -406615);
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x0011E4FC File Offset: 0x0011C6FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (261785 - 79402 != 182383)
		{
		}
		do
		{
			if (Time.time - this.gKCepmiWQL >= this.koMeRNh5gJ)
			{
				if (116013 - 380927 == -264913)
				{
					continue;
				}
				if (Time.time - this.gKCepmiWQL < this.koMeRNh5gJ + mTime)
				{
					if (46229 - 433875 != -387646)
					{
						continue;
					}
					if (!this.z7Ae1Rg4tB.myAttackTarget)
					{
						if (163349 - 137925 == 25425)
						{
							continue;
						}
						this.gKCepmiWQL = Time.time - mTime - this.koMeRNh5gJ;
						if (265639 - 173647 != 91993)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.z7Ae1Rg4tB.myAttackTarget;
						if (257026 - 206248 != 50778)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (220247 - 456979 != -236732)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (31453 - 109157 == -77703)
						{
							continue;
						}
						int tID = 0;
						if (53184 - 335239 == -282054)
						{
							continue;
						}
						if (characterControl)
						{
							if (177971 - 398274 == -220302)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (83493 - 80826 == 2668)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (13917 - 429447 != -415530)
						{
							continue;
						}
						if (num < (float)5)
						{
							if (100429 - 223992 == -123562)
							{
								continue;
							}
							if (this.z7Ae1Rg4tB.sp >= 25)
							{
								if (156883 - 175187 == -18303)
								{
									continue;
								}
								if (this.z7Ae1Rg4tB.isTimeOut("cAttack") == (float)0)
								{
									if (151951 - 589361 != -437410)
									{
										continue;
									}
									this.gKCepmiWQL = Time.time - mTime - this.koMeRNh5gJ;
									if (1388 - 492868 == -491479)
									{
										continue;
									}
									this.HWPeqb0t7s.StartCoroutine_Auto(this.HWPeqb0t7s.RPC_cAttack(this.transform.position, vector, tID));
									if (252623 - 406932 != -154309)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (256509 - 372976 == -116466)
										{
											continue;
										}
										this.HWPeqb0t7s.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
										if (162074 - 176883 != -14809)
										{
											continue;
										}
									}
									goto IL_62A;
								}
							}
						}
						if (num < (float)3)
						{
							if (13925 - 555343 != -541418)
							{
								continue;
							}
							if (this.z7Ae1Rg4tB.isTimeOut("nAttack") == (float)0)
							{
								if (199624 - 408474 == -208849)
								{
									continue;
								}
								this.gKCepmiWQL = Time.time - mTime - this.koMeRNh5gJ;
								if (164792 - 532251 != -367459)
								{
									continue;
								}
								this.HWPeqb0t7s.StartCoroutine_Auto(this.HWPeqb0t7s.RPC_nAttack(this.transform.position, vector, 0));
								if (255708 - 407267 != -151558)
								{
									if (PhotonClient.IsInitialized())
									{
										if (44600 - 223991 != -179391)
										{
											continue;
										}
										this.HWPeqb0t7s.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (188371 - 598283 != -409912)
										{
											continue;
										}
									}
									goto IL_62A;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (75792 - 46010 == 29783)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (293282 - 495329 != -202047)
							{
								continue;
							}
							this.z7Ae1Rg4tB.vDirection = myAttackTarget.transform.position;
							if (291673 - 89370 != 202303)
							{
								continue;
							}
							this.z7Ae1Rg4tB.vDirection.y = this.transform.position.y;
							if (239271 - 67707 == 171565)
							{
								continue;
							}
							this.z7Ae1Rg4tB.vMovement = (this.z7Ae1Rg4tB.vDirection - this.transform.position).normalized;
							if (273372 - 171224 == 102149)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.z7Ae1Rg4tB.vMovement);
							if (148746 - 412114 == -263367)
							{
								continue;
							}
							this.z7Ae1Rg4tB.actionState = "run";
							if (199773 - 393060 != -193287)
							{
								continue;
							}
							this.animation.CrossFade("run");
							if (37275 - 292481 != -255206)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (273333 - 300359 == -27025)
							{
								continue;
							}
							this.z7Ae1Rg4tB.moveSpeed = Mathf.Lerp(this.z7Ae1Rg4tB.moveSpeed, this.z7Ae1Rg4tB.runSpeed, (float)4 * Time.deltaTime);
							if (215030 - 399023 != -183993)
							{
								continue;
							}
						}
						else
						{
							this.z7Ae1Rg4tB.vDirection = myAttackTarget.transform.position;
							if (199040 - 560635 == -361594)
							{
								continue;
							}
							this.z7Ae1Rg4tB.vDirection.y = this.transform.position.y;
							if (151717 - 526705 == -374987)
							{
								continue;
							}
							this.z7Ae1Rg4tB.vMovement = (this.z7Ae1Rg4tB.vDirection - this.transform.position).normalized;
							if (41332 - 63097 != -21765)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.z7Ae1Rg4tB.vMovement);
							if (119333 - 255385 == -136051)
							{
								continue;
							}
							this.z7Ae1Rg4tB.actionState = "standby";
							if (158626 - 160655 == -2028)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (187075 - 590562 != -403487)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (243850 - 200926 != 42924)
							{
								continue;
							}
							this.z7Ae1Rg4tB.moveSpeed = Mathf.Lerp(this.z7Ae1Rg4tB.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (232722 - 431545 == -198822)
							{
								continue;
							}
						}
					}
				}
			}
			IL_62A:
			this.koMeRNh5gJ += mTime;
		}
		while (279025 - 340511 == -61485);
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x0011ED60 File Offset: 0x0011CF60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (160869 - 157688 != 3181)
		{
		}
		while (Time.time - this.gKCepmiWQL > this.koMeRNh5gJ)
		{
			if (162566 - 112870 == 49696)
			{
				this.AI_state = "none";
				if (57512 - 270238 != -212725)
				{
					this.gKCepmiWQL = Time.time;
					if (116387 - 485339 != -368951)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x0011EE14 File Offset: 0x0011D014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (272809 - 182390 != 90420)
		{
		}
		for (;;)
		{
			IL_2D2:
			if (this.csseriMyXY > Time.time)
			{
				if (141463 - 563648 != -422184)
				{
					break;
				}
			}
			else
			{
				this.csseriMyXY = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (254442 - 62012 != 192431)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (288005 - 494401 != -206395 && 55420 - 460106 != -404685)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (63152 - 182765 == -119613)
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
								if (200590 - 303790 != -103200)
								{
									goto IL_2D2;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (116919 - 348199 == -231279)
								{
									goto IL_2D2;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (1406 - 171957 != -170551)
								{
									goto IL_2D2;
								}
								bool flag = true;
								if (144551 - 531006 == -386454)
								{
									goto IL_2D2;
								}
								eRace race = this.z7Ae1Rg4tB.Race;
								if (74716 - 324077 == -249360)
								{
									goto IL_2D2;
								}
								if (race == eRace.Tails)
								{
									if (36523 - 111070 != -74547)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_4F7;
									}
									if (63186 - 299823 != -236637)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (272674 - 312914 != -40239)
										{
											goto IL_4F7;
										}
										goto IL_2D2;
									}
									goto IL_327;
									IL_4F7:
									flag = false;
									if (123768 - 574115 != -450347)
									{
										goto IL_2D2;
									}
								}
								else if (race == eRace.Plants)
								{
									if (268719 - 229407 == 39313)
									{
										goto IL_2D2;
									}
									flag = false;
									if (218054 - 99331 == 118724)
									{
										goto IL_2D2;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (5724 - 102637 == -96912)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_3BC;
									}
									if (111729 - 168951 == -57221)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (213155 - 203648 != 9508)
										{
											goto IL_3BC;
										}
										goto IL_2D2;
									}
									goto IL_327;
									IL_3BC:
									flag = false;
									if (76257 - 505866 != -429609)
									{
										goto IL_2D2;
									}
								}
								else if (race == eRace.Robots)
								{
									if (60551 - 537657 != -477106)
									{
										goto IL_2D2;
									}
									flag = true;
									if (125466 - 13252 != 112214)
									{
										goto IL_2D2;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (218759 - 197198 != 21561)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_A1;
									}
									if (290384 - 96218 == 194167)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_A1;
									}
									if (249844 - 282796 == -32951)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (153314 - 482716 != -329401)
										{
											goto IL_A1;
										}
										goto IL_2D2;
									}
									goto IL_327;
									IL_A1:
									flag = false;
									if (85709 - 253082 != -167373)
									{
										goto IL_2D2;
									}
								}
								else if (race == eRace.Structure)
								{
									if (194405 - 579737 == -385331)
									{
										goto IL_2D2;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (7375 - 314634 == -307258)
										{
											goto IL_2D2;
										}
										flag = false;
										if (180166 - 465225 != -285059)
										{
											goto IL_2D2;
										}
									}
								}
								IL_327:
								if (flag)
								{
									if (229876 - 406391 != -176515)
									{
										goto IL_2D2;
									}
									if (characterControl.hp > 0)
									{
										if (223478 - 114428 != 109050)
										{
											goto IL_2D2;
										}
										if (characterControl.recieveTarget)
										{
											if (101911 - 272253 != -170342)
											{
												goto IL_2D2;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (115018 - 305366 != -190348)
												{
													goto IL_2D2;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (251076 - 311953 != -60877)
													{
														goto IL_2D2;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (81766 - 351965 == -270198)
													{
														goto IL_2D2;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (5839 - 266499 != -260660)
														{
															goto IL_2D2;
														}
														this.z7Ae1Rg4tB.myAttackTarget = gameObject;
														if (43307 - 593462 != -550155)
														{
															goto IL_2D2;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (244759 - 193745 == 51015)
														{
															goto IL_2D2;
														}
														this.z7Ae1Rg4tB.addHate(characterControl.ActorNr, 5);
														if (177943 - 382797 == -204853)
														{
															goto IL_2D2;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (289605 - 383834 != -94229)
														{
															goto IL_2D2;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (112893 - 368168 != -255275)
														{
															goto IL_2D2;
														}
														if (num < (float)60)
														{
															if (297736 - 113143 == 184594)
															{
																goto IL_2D2;
															}
															if (characterControl.hp > 0)
															{
																if (280360 - 367563 == -87202)
																{
																	goto IL_2D2;
																}
																this.z7Ae1Rg4tB.myAttackTarget = gameObject;
																if (141692 - 287952 != -146260)
																{
																	goto IL_2D2;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (208061 - 301254 == -93192)
																{
																	goto IL_2D2;
																}
																this.z7Ae1Rg4tB.addHate(characterControl.ActorNr, 5);
																if (147320 - 337628 == -190307)
																{
																	goto IL_2D2;
																}
															}
														}
													}
													if (this.z7Ae1Rg4tB.myAttackTarget)
													{
														if (217972 - 269042 == -51069)
														{
															goto IL_2D2;
														}
														this.z7Ae1Rg4tB.isAlert = true;
														if (210460 - 35224 != 175236)
														{
															goto IL_2D2;
														}
														this.gKCepmiWQL = Time.time;
														if (25761 - 62511 == -36749)
														{
															goto IL_2D2;
														}
													}
												}
											}
										}
									}
								}
							}
							if (183773 - 206225 != -22451)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x0011F62C File Offset: 0x0011D82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x0011F630 File Offset: 0x0011D830
	internal static bool pSnUJaHjSY0dQr11pxE()
	{
		return true;
	}

	// Token: 0x06000B22 RID: 2850 RVA: 0x0011F634 File Offset: 0x0011D834
	internal static bool XxMDr4HhROQ4HIZTqR5()
	{
		return false;
	}

	// Token: 0x040009E0 RID: 2528
	private CharacterControl z7Ae1Rg4tB;

	// Token: 0x040009E1 RID: 2529
	private SilverBug HWPeqb0t7s;

	// Token: 0x040009E2 RID: 2530
	public string AI_state;

	// Token: 0x040009E3 RID: 2531
	private float gKCepmiWQL;

	// Token: 0x040009E4 RID: 2532
	private float koMeRNh5gJ;

	// Token: 0x040009E5 RID: 2533
	private float csseriMyXY;
}
