using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B78 RID: 2936
[Serializable]
public class Baboon_AI : MonoBehaviour
{
	// Token: 0x0600415F RID: 16735 RVA: 0x00845148 File Offset: 0x00843348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Baboon_AI()
	{
		if (185705 - 330827 != -145122)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (163938 - 500046 == -336108)
			{
				base..ctor();
				if (221726 - 40790 != 180937)
				{
					this.AI_state = "none";
					if (13725 - 40369 != -26643)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004160 RID: 16736 RVA: 0x008451E4 File Offset: 0x008433E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.hGXVqfdHX2 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.FglVp6lokW = (Baboon)this.GetComponent(typeof(Baboon));
	}

	// Token: 0x06004161 RID: 16737 RVA: 0x0084521C File Offset: 0x0084341C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (175208 - 323971 != -148763)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (269332 - 241449 == 27884)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (30538 - 215060 == -184521)
				{
					continue;
				}
			}
			if (this.hGXVqfdHX2.isControlled)
			{
				break;
			}
			if (70129 - 212703 != -142573)
			{
				this.AIControl();
				if (175818 - 44418 != 131401)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004162 RID: 16738 RVA: 0x008452E8 File Offset: 0x008434E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (78360 - 191196 != -112835)
		{
		}
		for (;;)
		{
			this.p2NVr9ZDBn = (float)0;
			if (213674 - 10881 == 202793)
			{
				if (this.hGXVqfdHX2.isMine)
				{
					if (152967 - 364782 == -211815)
					{
						if (this.hGXVqfdHX2.actionState != "standby")
						{
							if (56620 - 570404 != -513784)
							{
								continue;
							}
							if (this.hGXVqfdHX2.actionState != "run")
							{
								if (122343 - 520393 != -398049)
								{
									break;
								}
								continue;
							}
						}
						if (!this.hGXVqfdHX2.isAlert)
						{
							if (189861 - 584727 == -394866)
							{
								if (this.hGXVqfdHX2.isSummon)
								{
									if (219989 - 18060 == 201930)
									{
										continue;
									}
									if (this.hGXVqfdHX2.mSummoner != null)
									{
										if (125420 - 65281 == 60140)
										{
											continue;
										}
										Vector3 vector = this.hGXVqfdHX2.mSummoner.transform.position - this.transform.position;
										if (223368 - 539483 != -316115)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (77449 - 75897 == 1553)
											{
												continue;
											}
											this.AI_follow(this.hGXVqfdHX2.mSummoner);
											if (266739 - 60880 != 205859)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (237564 - 508363 == -270798)
											{
												continue;
											}
											this.AI_resetTimer();
											if (260286 - 496416 == -236129)
											{
												continue;
											}
											this.AI_visionCheck();
											if (214828 - 328208 == -113379)
											{
												continue;
											}
										}
										goto IL_5D9;
									}
								}
								this.AI_idle(3f, 1f);
								if (169114 - 395289 == -226174)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (249663 - 133207 == 116457)
								{
									continue;
								}
								this.AI_resetTimer();
								if (12152 - 301078 != -288926)
								{
									continue;
								}
								this.AI_visionCheck();
								if (204695 - 194746 == 9950)
								{
									continue;
								}
								IL_5D9:
								if (!this.hGXVqfdHX2.myAttackTarget)
								{
									break;
								}
								if (80789 - 320351 != -239561)
								{
									this.hGXVqfdHX2.isAlert = true;
									if (187472 - 220228 != -32755)
									{
										this.RR2VRLdmmW = Time.time;
										if (259192 - 344684 == -85492)
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
							if (55799 - 360651 != -304851)
							{
								this.AI_idle(3f, 1f);
								if (100017 - 354964 == -254947)
								{
									this.AI_attack(10f, (float)0);
									if (162079 - 56043 != 106037)
									{
										this.AI_resetTimer();
										if (136394 - 322967 != -186572)
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
					if (this.hGXVqfdHX2.actionState != "standby")
					{
						if (17555 - 236464 != -218909)
						{
							continue;
						}
						if (this.hGXVqfdHX2.actionState != "run")
						{
							if (176820 - 151663 != 25157)
							{
								continue;
							}
							break;
						}
					}
					float num = this.hGXVqfdHX2.moveSpeed;
					if (244300 - 221476 != 22825)
					{
						float runSpeed = this.hGXVqfdHX2.runSpeed;
						if (32165 - 24955 == 7210)
						{
							Vector3 vector2 = default(Vector3);
							if (28392 - 351707 == -323315)
							{
								Vector3 vector3 = Vector3.zero;
								if (215928 - 271795 == -55867)
								{
									if ((this.hGXVqfdHX2.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (179181 - 117292 != 61889)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.hGXVqfdHX2.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (156673 - 101758 != 54915)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (88936 - 150927 == -61990)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (287149 - 362796 == -75646)
											{
												continue;
											}
											num = (float)0;
											if (130132 - 523671 != -393539)
											{
												continue;
											}
											this.transform.position = this.hGXVqfdHX2.nPosition;
											if (254024 - 543951 == -289926)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (113768 - 366114 == -252345)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (195113 - 262350 != -67237)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (246264 - 328782 == -82517)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (47049 - 488859 != -441810)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (29748 - 897 == 28852)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (156900 - 321728 == -164827)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (158149 - 74109 != 84040)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (231386 - 530203 != -298817)
											{
												continue;
											}
										}
									}
									this.hGXVqfdHX2.vMovement = vector3;
									if (11702 - 197443 != -185740)
									{
										this.hGXVqfdHX2.moveSpeed = num;
										if (218060 - 189861 != 28200)
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

	// Token: 0x06004163 RID: 16739 RVA: 0x00845AC4 File Offset: 0x00843CC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (99139 - 104393 != -5253)
		{
		}
		do
		{
			if (Time.time - this.RR2VRLdmmW >= this.p2NVr9ZDBn)
			{
				if (64544 - 395178 != -330634)
				{
					continue;
				}
				if (Time.time - this.RR2VRLdmmW < this.p2NVr9ZDBn + mTime)
				{
					if (233821 - 259260 != -25439)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (14635 - 567267 == -552631)
						{
							continue;
						}
						this.AI_state = "idle";
						if (234660 - 103834 == 130827)
						{
							continue;
						}
						this.RR2VRLdmmW -= UnityEngine.Random.Range((float)0, rTimer);
						if (180318 - 382872 != -202554)
						{
							continue;
						}
						this.hGXVqfdHX2.vDirection = Vector3.zero;
						if (140469 - 53281 != 87188)
						{
							continue;
						}
						this.hGXVqfdHX2.vMovement = this.transform.forward;
						if (221884 - 136359 == 85526)
						{
							continue;
						}
						this.hGXVqfdHX2.actionState = "standby";
						if (295955 - 586962 != -291007)
						{
							continue;
						}
					}
					this.hGXVqfdHX2.moveSpeed = Mathf.Lerp(this.hGXVqfdHX2.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (296736 - 230636 != 66100)
					{
						continue;
					}
					if (this.hGXVqfdHX2.moveSpeed < 0.1f * this.hGXVqfdHX2.runSpeed)
					{
						if (245370 - 349342 != -103972)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (137907 - 402936 != -265029)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (265291 - 539008 == -273716)
						{
							continue;
						}
						this.hGXVqfdHX2.moveSpeed = (float)0;
						if (8395 - 550877 == -542481)
						{
							continue;
						}
					}
				}
			}
			this.p2NVr9ZDBn += mTime;
		}
		while (231506 - 342765 != -111259);
	}

	// Token: 0x06004164 RID: 16740 RVA: 0x00845D88 File Offset: 0x00843F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (222373 - 354130 != -131756)
		{
		}
		for (;;)
		{
			this.hGXVqfdHX2.vDirection = followObject.transform.position;
			if (267848 - 171056 != 96793)
			{
				this.hGXVqfdHX2.vDirection.y = this.transform.position.y;
				if (274554 - 332758 != -58203)
				{
					this.hGXVqfdHX2.vMovement = (this.hGXVqfdHX2.vDirection - this.transform.position).normalized;
					if (272530 - 169810 != 102721)
					{
						this.transform.rotation = Quaternion.LookRotation(this.hGXVqfdHX2.vMovement);
						if (78221 - 494454 != -416232)
						{
							this.hGXVqfdHX2.actionState = "run";
							if (85761 - 574769 != -489007)
							{
								this.animation.Play("run");
								if (133798 - 178801 == -45003)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (198885 - 445183 != -246297)
									{
										this.hGXVqfdHX2.moveSpeed = Mathf.Lerp(this.hGXVqfdHX2.moveSpeed, this.hGXVqfdHX2.runSpeed, (float)4 * Time.deltaTime);
										if (31805 - 27314 == 4491)
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

	// Token: 0x06004165 RID: 16741 RVA: 0x00845F70 File Offset: 0x00844170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (141536 - 281690 != -140153)
		{
		}
		do
		{
			if (Time.time - this.RR2VRLdmmW >= this.p2NVr9ZDBn)
			{
				if (188143 - 528574 != -340431)
				{
					continue;
				}
				if (Time.time - this.RR2VRLdmmW < this.p2NVr9ZDBn + mTime)
				{
					if (25820 - 495603 == -469782)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (109479 - 36221 == 73259)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (103355 - 236399 == -133043)
						{
							continue;
						}
						this.RR2VRLdmmW -= UnityEngine.Random.Range((float)0, rTimer);
						if (123599 - 380958 != -257359)
						{
							continue;
						}
						this.hGXVqfdHX2.vDirection = this.hGXVqfdHX2.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (1697 - 407207 == -405509)
						{
							continue;
						}
						this.hGXVqfdHX2.vDirection.y = this.transform.position.y;
						if (118571 - 569210 == -450638)
						{
							continue;
						}
						this.hGXVqfdHX2.vMovement = (this.hGXVqfdHX2.vDirection - this.transform.position).normalized;
						if (117621 - 269832 != -152211)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.hGXVqfdHX2.vMovement);
						if (141188 - 550990 == -409801)
						{
							continue;
						}
						this.hGXVqfdHX2.actionState = "run";
						if (39183 - 302006 != -262823)
						{
							continue;
						}
						this.animation.Play("run");
						if (30702 - 168284 != -137582)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (58837 - 416110 == -357272)
						{
							continue;
						}
					}
					this.hGXVqfdHX2.moveSpeed = Mathf.Lerp(this.hGXVqfdHX2.moveSpeed, this.hGXVqfdHX2.runSpeed, (float)4 * Time.deltaTime);
					if (162726 - 39869 != 122857)
					{
						continue;
					}
				}
			}
			this.p2NVr9ZDBn += mTime;
		}
		while (86773 - 77544 != 9229);
	}

	// Token: 0x06004166 RID: 16742 RVA: 0x00846278 File Offset: 0x00844478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (13007 - 506266 != -493259)
		{
		}
		do
		{
			if (Time.time - this.RR2VRLdmmW >= this.p2NVr9ZDBn)
			{
				if (66778 - 582767 != -515989)
				{
					continue;
				}
				if (Time.time - this.RR2VRLdmmW < this.p2NVr9ZDBn + mTime)
				{
					if (50137 - 568824 == -518686)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (60324 - 220176 == -159851)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (149484 - 367174 == -217689)
						{
							continue;
						}
						this.RR2VRLdmmW = Time.time - mTime - this.p2NVr9ZDBn;
						if (57302 - 122894 == -65591)
						{
							continue;
						}
						this.hGXVqfdHX2.vDirection = Vector3.zero;
						if (290204 - 547557 != -257353)
						{
							continue;
						}
						this.hGXVqfdHX2.vMovement = this.transform.forward;
						if (208197 - 240000 != -31803)
						{
							continue;
						}
						this.hGXVqfdHX2.actionState = "standby";
						if (48757 - 494915 == -446157)
						{
							continue;
						}
						this.hGXVqfdHX2.myAttackTarget = this.hGXVqfdHX2.getHateTarget(5, 50);
						if (272343 - 61453 != 210890)
						{
							continue;
						}
						if (!this.hGXVqfdHX2.myAttackTarget)
						{
							if (269108 - 145423 != 123685)
							{
								continue;
							}
							this.hGXVqfdHX2.isAlert = false;
							if (185909 - 241496 != -55587)
							{
								continue;
							}
							this.RR2VRLdmmW = Time.time;
							if (215952 - 5695 == 210258)
							{
								continue;
							}
							this.hGXVqfdHX2.myAttackTarget = null;
							if (211510 - 116618 == 94893)
							{
								continue;
							}
							this.hGXVqfdHX2.mOriginalPosition = this.transform.position;
							if (264851 - 449091 != -184239)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.hGXVqfdHX2.myAttackTarget;
							if (112894 - 329634 != -216740)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (226912 - 41166 != 185746)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (29677 - 500575 != -470898)
								{
									continue;
								}
								this.hGXVqfdHX2.isAlert = false;
								if (298229 - 298289 == -59)
								{
									continue;
								}
								this.RR2VRLdmmW = Time.time;
								if (103801 - 182954 == -79152)
								{
									continue;
								}
								this.hGXVqfdHX2.myAttackTarget = null;
								if (66523 - 592791 == -526267)
								{
									continue;
								}
							}
							else
							{
								this.hGXVqfdHX2.vDirection = myAttackTarget.transform.position;
								if (91190 - 203720 != -112530)
								{
									continue;
								}
								this.hGXVqfdHX2.vDirection.y = this.transform.position.y;
								if (280701 - 87273 != 193428)
								{
									continue;
								}
								this.hGXVqfdHX2.vMovement = (this.hGXVqfdHX2.vDirection - this.transform.position).normalized;
								if (77096 - 559660 == -482563)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hGXVqfdHX2.vMovement);
								if (158630 - 353118 == -194487)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.p2NVr9ZDBn += mTime;
		}
		while (127685 - 3196 == 124490);
	}

	// Token: 0x06004167 RID: 16743 RVA: 0x00846728 File Offset: 0x00844928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (225787 - 172368 != 53419)
		{
		}
		do
		{
			if (Time.time - this.RR2VRLdmmW >= this.p2NVr9ZDBn)
			{
				if (20259 - 416049 != -395790)
				{
					continue;
				}
				if (Time.time - this.RR2VRLdmmW < this.p2NVr9ZDBn + mTime)
				{
					if (147819 - 77191 != 70628)
					{
						continue;
					}
					if (!this.hGXVqfdHX2.myAttackTarget)
					{
						if (54876 - 182616 != -127740)
						{
							continue;
						}
						this.RR2VRLdmmW = Time.time - mTime - this.p2NVr9ZDBn;
						if (143186 - 477932 != -334745)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.hGXVqfdHX2.myAttackTarget;
						if (11233 - 37140 != -25907)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (230504 - 230077 != 427)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (156817 - 494036 != -337219)
						{
							continue;
						}
						int tID = 0;
						if (149110 - 267956 != -118846)
						{
							continue;
						}
						if (characterControl)
						{
							if (155384 - 55405 != 99979)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (244272 - 348797 != -104525)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (231411 - 309967 != -78556)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (281515 - 565030 != -283515)
							{
								continue;
							}
							if (this.hGXVqfdHX2.isTimeOut("cAttack") == (float)0)
							{
								if (23562 - 123530 == -99967)
								{
									continue;
								}
								this.RR2VRLdmmW = Time.time - mTime - this.p2NVr9ZDBn;
								if (45746 - 545791 == -500044)
								{
									continue;
								}
								this.FglVp6lokW.StartCoroutine_Auto(this.FglVp6lokW.RPC_cAttack(this.transform.position, vector, tID));
								if (168081 - 535085 != -367003)
								{
									if (PhotonClient.IsInitialized())
									{
										if (185758 - 299748 != -113990)
										{
											continue;
										}
										this.FglVp6lokW.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
										if (76922 - 456241 != -379319)
										{
											continue;
										}
									}
									goto IL_39A;
								}
								continue;
							}
						}
						if (num < (float)30)
						{
							if (178559 - 581794 != -403235)
							{
								continue;
							}
							if (this.hGXVqfdHX2.isTimeOut("nAttack") == (float)0)
							{
								if (70612 - 194012 == -123399)
								{
									continue;
								}
								this.RR2VRLdmmW = Time.time - mTime - this.p2NVr9ZDBn;
								if (91932 - 295478 == -203545)
								{
									continue;
								}
								this.FglVp6lokW.StartCoroutine_Auto(this.FglVp6lokW.RPC_nAttack(this.transform.position, vector, tID));
								if (243046 - 60709 != 182338)
								{
									if (PhotonClient.IsInitialized())
									{
										if (174732 - 246779 != -72047)
										{
											continue;
										}
										this.FglVp6lokW.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
										if (193023 - 539209 == -346185)
										{
											continue;
										}
									}
									goto IL_39A;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (56949 - 79521 != -22572)
						{
							continue;
						}
						if (num > (float)30)
						{
							if (253934 - 109557 == 144378)
							{
								continue;
							}
							this.hGXVqfdHX2.vDirection = myAttackTarget.transform.position;
							if (268041 - 439841 == -171799)
							{
								continue;
							}
							this.hGXVqfdHX2.vDirection.y = this.transform.position.y;
							if (194620 - 352014 == -157393)
							{
								continue;
							}
							this.hGXVqfdHX2.vMovement = (this.hGXVqfdHX2.vDirection - this.transform.position).normalized;
							if (140500 - 174289 == -33788)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.hGXVqfdHX2.vMovement);
							if (158383 - 505122 == -346738)
							{
								continue;
							}
							this.hGXVqfdHX2.actionState = "run";
							if (263211 - 217497 == 45715)
							{
								continue;
							}
							this.animation.Play("run");
							if (192584 - 371075 != -178491)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (210358 - 376650 != -166292)
							{
								continue;
							}
							this.hGXVqfdHX2.moveSpeed = Mathf.Lerp(this.hGXVqfdHX2.moveSpeed, this.hGXVqfdHX2.runSpeed, (float)4 * Time.deltaTime);
							if (211081 - 26147 != 184934)
							{
								continue;
							}
						}
						else
						{
							this.hGXVqfdHX2.vDirection = myAttackTarget.transform.position;
							if (254288 - 354491 == -100202)
							{
								continue;
							}
							this.hGXVqfdHX2.vDirection.y = this.transform.position.y;
							if (295947 - 502227 != -206280)
							{
								continue;
							}
							this.hGXVqfdHX2.vMovement = (this.hGXVqfdHX2.vDirection - this.transform.position).normalized;
							if (190269 - 24629 != 165640)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.hGXVqfdHX2.vMovement);
							if (188867 - 552938 != -364071)
							{
								continue;
							}
							this.hGXVqfdHX2.actionState = "standby";
							if (41830 - 503104 != -461274)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (252089 - 289317 == -37227)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (80811 - 295738 != -214927)
							{
								continue;
							}
							this.hGXVqfdHX2.moveSpeed = Mathf.Lerp(this.hGXVqfdHX2.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (295106 - 49955 != 245151)
							{
								continue;
							}
						}
					}
				}
			}
			IL_39A:
			this.p2NVr9ZDBn += mTime;
		}
		while (70658 - 190630 == -119971);
	}

	// Token: 0x06004168 RID: 16744 RVA: 0x00846F64 File Offset: 0x00845164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (17993 - 324033 != -306040)
		{
		}
		while (Time.time - this.RR2VRLdmmW > this.p2NVr9ZDBn)
		{
			if (172632 - 169470 != 3163)
			{
				this.AI_state = "none";
				if (175513 - 317831 == -142318)
				{
					this.RR2VRLdmmW = Time.time;
					if (113105 - 523858 == -410753)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004169 RID: 16745 RVA: 0x00847018 File Offset: 0x00845218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (161009 - 223802 != -62792)
		{
		}
		for (;;)
		{
			IL_419:
			if (this.jU6VxPM8kF > Time.time)
			{
				if (215554 - 51783 == 163771)
				{
					break;
				}
			}
			else
			{
				this.jU6VxPM8kF = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (144912 - 171406 == -26494)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (207410 - 334622 == -127212)
					{
						if (161340 - 496179 == -334839)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (206652 - 194814 != 11839)
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
									if (145400 - 270450 == -125049)
									{
										goto IL_419;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (56959 - 500594 != -443635)
									{
										goto IL_419;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (154506 - 237478 != -82972)
									{
										goto IL_419;
									}
									bool flag = true;
									if (245379 - 355025 == -109645)
									{
										goto IL_419;
									}
									eRace race = this.hGXVqfdHX2.Race;
									if (235744 - 16459 == 219286)
									{
										goto IL_419;
									}
									if (race == eRace.Tails)
									{
										if (47270 - 433077 == -385806)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_785;
										}
										if (27613 - 332385 != -304772)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (240412 - 210117 != 30296)
											{
												goto IL_785;
											}
											goto IL_419;
										}
										goto IL_45;
										IL_785:
										flag = false;
										if (237666 - 113934 == 123733)
										{
											goto IL_419;
										}
									}
									else if (race == eRace.Plants)
									{
										if (158351 - 122723 == 35629)
										{
											goto IL_419;
										}
										flag = false;
										if (120833 - 535803 != -414970)
										{
											goto IL_419;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (106772 - 521788 == -415015)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_199;
										}
										if (298335 - 156027 != 142308)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (107767 - 17104 != 90663)
											{
												goto IL_419;
											}
											goto IL_199;
										}
										goto IL_45;
										IL_199:
										flag = false;
										if (246197 - 133273 != 112924)
										{
											goto IL_419;
										}
									}
									else if (race == eRace.Robots)
									{
										if (92925 - 96582 == -3656)
										{
											goto IL_419;
										}
										flag = true;
										if (111281 - 185324 != -74043)
										{
											goto IL_419;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (238940 - 140444 != 98496)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_201;
										}
										if (165851 - 256041 != -90190)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_201;
										}
										if (121242 - 515852 == -394609)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (227152 - 19339 != 207814)
											{
												goto IL_201;
											}
											goto IL_419;
										}
										goto IL_45;
										IL_201:
										flag = false;
										if (265347 - 345044 == -79696)
										{
											goto IL_419;
										}
									}
									else if (race == eRace.Structure)
									{
										if (231958 - 204074 != 27884)
										{
											goto IL_419;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (97965 - 52379 == 45587)
											{
												goto IL_419;
											}
											flag = false;
											if (208219 - 86729 != 121490)
											{
												goto IL_419;
											}
										}
									}
									IL_45:
									if (flag)
									{
										if (51750 - 553433 != -501683)
										{
											goto IL_419;
										}
										if (characterControl.hp > 0)
										{
											if (146771 - 58249 != 88522)
											{
												goto IL_419;
											}
											if (characterControl.recieveTarget)
											{
												if (71868 - 423582 != -351714)
												{
													goto IL_419;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (101440 - 572640 == -471199)
													{
														goto IL_419;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (294615 - 495190 != -200575)
														{
															goto IL_419;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (108634 - 364558 != -255924)
														{
															goto IL_419;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (87017 - 324126 == -237108)
															{
																goto IL_419;
															}
															this.hGXVqfdHX2.myAttackTarget = gameObject;
															if (93683 - 29635 == 64049)
															{
																goto IL_419;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (291922 - 144884 != 147038)
															{
																goto IL_419;
															}
															this.hGXVqfdHX2.addHate(characterControl.ActorNr, 5);
															if (219765 - 356641 == -136875)
															{
																goto IL_419;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (107121 - 386395 == -279273)
															{
																goto IL_419;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (84614 - 211535 == -126920)
															{
																goto IL_419;
															}
															if (num < (float)60)
															{
																if (168897 - 289032 == -120134)
																{
																	goto IL_419;
																}
																if (characterControl.hp > 0)
																{
																	if (247691 - 157114 == 90578)
																	{
																		goto IL_419;
																	}
																	this.hGXVqfdHX2.myAttackTarget = gameObject;
																	if (18982 - 102748 != -83766)
																	{
																		goto IL_419;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (279021 - 251238 == 27784)
																	{
																		goto IL_419;
																	}
																	this.hGXVqfdHX2.addHate(characterControl.ActorNr, 5);
																	if (190208 - 310432 != -120224)
																	{
																		goto IL_419;
																	}
																}
															}
														}
														if (this.hGXVqfdHX2.myAttackTarget)
														{
															if (236331 - 55441 == 180891)
															{
																goto IL_419;
															}
															this.hGXVqfdHX2.isAlert = true;
															if (170755 - 4785 == 165971)
															{
																goto IL_419;
															}
															this.RR2VRLdmmW = Time.time;
															if (126067 - 177476 == -51408)
															{
																goto IL_419;
															}
														}
													}
												}
											}
										}
									}
								}
								if (10888 - 594516 != -583627)
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

	// Token: 0x0600416A RID: 16746 RVA: 0x00847830 File Offset: 0x00845A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600416B RID: 16747 RVA: 0x00847834 File Offset: 0x00845A34
	internal static bool KMmew55xRAAEMU3ockf9()
	{
		return true;
	}

	// Token: 0x0600416C RID: 16748 RVA: 0x00847838 File Offset: 0x00845A38
	internal static bool v0mQZm5xwYRxguRDqNun()
	{
		return false;
	}

	// Token: 0x04004D85 RID: 19845
	private CharacterControl hGXVqfdHX2;

	// Token: 0x04004D86 RID: 19846
	private Baboon FglVp6lokW;

	// Token: 0x04004D87 RID: 19847
	public string AI_state;

	// Token: 0x04004D88 RID: 19848
	private float RR2VRLdmmW;

	// Token: 0x04004D89 RID: 19849
	private float p2NVr9ZDBn;

	// Token: 0x04004D8A RID: 19850
	private float jU6VxPM8kF;
}
