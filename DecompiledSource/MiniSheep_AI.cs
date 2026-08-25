using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D11 RID: 3345
[Serializable]
public class MiniSheep_AI : MonoBehaviour
{
	// Token: 0x06004B1B RID: 19227 RVA: 0x00948BB4 File Offset: 0x00946DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniSheep_AI()
	{
		if (208095 - 269329 != -61233)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (58091 - 60610 == -2519)
			{
				base..ctor();
				if (4140 - 376243 != -372102)
				{
					this.AI_state = "none";
					if (20634 - 201608 != -180973)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B1C RID: 19228 RVA: 0x00948C50 File Offset: 0x00946E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.pcfc5DFujE6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.ap1c5mRkFYJ = (MiniSheep)this.GetComponent(typeof(MiniSheep));
	}

	// Token: 0x06004B1D RID: 19229 RVA: 0x00948C88 File Offset: 0x00946E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (24624 - 346173 != -321549)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (26530 - 61720 == -35189)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (102288 - 217662 == -115373)
				{
					continue;
				}
			}
			if (this.pcfc5DFujE6.isControlled)
			{
				break;
			}
			if (105756 - 164467 == -58711)
			{
				this.AIControl();
				if (249128 - 281653 == -32525)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004B1E RID: 19230 RVA: 0x00948D54 File Offset: 0x00946F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (111368 - 219735 != -108367)
		{
		}
		for (;;)
		{
			this.auWc5od5pnZ = (float)0;
			if (41880 - 139250 != -97369)
			{
				if (this.pcfc5DFujE6.isMine)
				{
					if (219600 - 296024 != -76423)
					{
						if (this.pcfc5DFujE6.actionState != "standby")
						{
							if (240098 - 199571 == 40528)
							{
								continue;
							}
							if (this.pcfc5DFujE6.actionState != "run")
							{
								if (93246 - 339594 != -246347)
								{
									break;
								}
								continue;
							}
						}
						if (!this.pcfc5DFujE6.isAlert)
						{
							if (199088 - 246009 == -46921)
							{
								if (!this.pcfc5DFujE6.isSummon)
								{
									goto IL_5F6;
								}
								if (291556 - 179984 != 111572)
								{
									continue;
								}
								if (!(this.pcfc5DFujE6.mSummoner != null))
								{
									goto IL_5F6;
								}
								if (169263 - 125119 != 44144)
								{
									continue;
								}
								Vector3 vector = this.pcfc5DFujE6.mSummoner.transform.position - this.transform.position;
								if (20726 - 3390 == 17337)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (59974 - 216901 == -156926)
									{
										continue;
									}
									this.AI_follow(this.pcfc5DFujE6.mSummoner);
									if (118159 - 139575 != -21416)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (198330 - 258885 == -60554)
									{
										continue;
									}
									this.AI_resetTimer();
									if (215611 - 563334 == -347722)
									{
										continue;
									}
									this.AI_visionCheck();
									if (42998 - 288271 == -245272)
									{
										continue;
									}
								}
								IL_300:
								if (!this.pcfc5DFujE6.myAttackTarget)
								{
									break;
								}
								if (154110 - 54476 == 99635)
								{
									continue;
								}
								this.pcfc5DFujE6.isAlert = true;
								if (119377 - 547055 != -427678)
								{
									continue;
								}
								this.KaCc5jvD8IB = Time.time;
								if (160249 - 70865 != 89385)
								{
									break;
								}
								continue;
								IL_5F6:
								this.AI_idle(3f, 1f);
								if (167315 - 82421 != 84895)
								{
									this.AI_patrol(1f, 0.25f);
									if (257540 - 227131 == 30409)
									{
										this.AI_resetTimer();
										if (168578 - 266203 != -97624)
										{
											this.AI_visionCheck();
											if (154554 - 507794 != -353239)
											{
												goto IL_300;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (76500 - 116294 == -39794)
							{
								this.AI_idle(3f, 1f);
								if (200253 - 501491 == -301238)
								{
									this.AI_attack(10f, (float)0);
									if (185885 - 136670 != 49216)
									{
										this.AI_resetTimer();
										if (205718 - 476950 != -271231)
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
					if (this.pcfc5DFujE6.actionState != "standby")
					{
						if (106781 - 402858 == -296076)
						{
							continue;
						}
						if (this.pcfc5DFujE6.actionState != "run")
						{
							if (31256 - 429286 != -398030)
							{
								continue;
							}
							break;
						}
					}
					float num = this.pcfc5DFujE6.moveSpeed;
					if (231200 - 446555 != -215354)
					{
						float runSpeed = this.pcfc5DFujE6.runSpeed;
						if (205886 - 147259 != 58628)
						{
							Vector3 vector2 = default(Vector3);
							if (229217 - 559993 == -330776)
							{
								Vector3 vector3 = Vector3.zero;
								if (190210 - 393755 != -203544)
								{
									if ((this.pcfc5DFujE6.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (258873 - 597757 == -338883)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.pcfc5DFujE6.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (113285 - 300109 == -186823)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (1251 - 141126 == -139874)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (12324 - 302358 != -290034)
											{
												continue;
											}
											num = (float)0;
											if (9138 - 108580 == -99441)
											{
												continue;
											}
											this.transform.position = this.pcfc5DFujE6.nPosition;
											if (254549 - 448684 != -194135)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (175419 - 572530 == -397110)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (84006 - 198773 != -114767)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (288431 - 479971 != -191540)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (71621 - 481807 != -410186)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (155713 - 171125 == -15411)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (183468 - 57923 == 125546)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (264924 - 13308 == 251617)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (8948 - 244295 != -235347)
											{
												continue;
											}
										}
									}
									this.pcfc5DFujE6.vMovement = vector3;
									if (204941 - 448413 != -243471)
									{
										this.pcfc5DFujE6.moveSpeed = num;
										if (273445 - 205613 != 67833)
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

	// Token: 0x06004B1F RID: 19231 RVA: 0x00949530 File Offset: 0x00947730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (177697 - 540376 != -362678)
		{
		}
		do
		{
			if (Time.time - this.KaCc5jvD8IB >= this.auWc5od5pnZ)
			{
				if (158951 - 10388 == 148564)
				{
					continue;
				}
				if (Time.time - this.KaCc5jvD8IB < this.auWc5od5pnZ + mTime)
				{
					if (103656 - 460618 != -356962)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (146312 - 311300 != -164988)
						{
							continue;
						}
						this.AI_state = "idle";
						if (178638 - 129147 == 49492)
						{
							continue;
						}
						this.KaCc5jvD8IB -= UnityEngine.Random.Range((float)0, rTimer);
						if (75362 - 207938 == -132575)
						{
							continue;
						}
						this.pcfc5DFujE6.vDirection = Vector3.zero;
						if (116494 - 206440 != -89946)
						{
							continue;
						}
						this.pcfc5DFujE6.vMovement = this.transform.forward;
						if (268322 - 457939 != -189617)
						{
							continue;
						}
						this.pcfc5DFujE6.actionState = "standby";
						if (75431 - 60994 == 14438)
						{
							continue;
						}
					}
					this.pcfc5DFujE6.moveSpeed = Mathf.Lerp(this.pcfc5DFujE6.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (206420 - 8547 != 197873)
					{
						continue;
					}
					if (this.pcfc5DFujE6.moveSpeed < 0.1f * this.pcfc5DFujE6.runSpeed)
					{
						if (172324 - 23572 == 148753)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (103514 - 405279 == -301764)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (129196 - 374145 != -244949)
						{
							continue;
						}
						this.pcfc5DFujE6.moveSpeed = (float)0;
						if (231430 - 188708 == 42723)
						{
							continue;
						}
					}
				}
			}
			this.auWc5od5pnZ += mTime;
		}
		while (285664 - 490741 != -205077);
	}

	// Token: 0x06004B20 RID: 19232 RVA: 0x009497F4 File Offset: 0x009479F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (127695 - 286669 != -158973)
		{
		}
		for (;;)
		{
			this.pcfc5DFujE6.vDirection = followObject.transform.position;
			if (266181 - 125229 != 140953)
			{
				this.pcfc5DFujE6.vDirection.y = this.transform.position.y;
				if (79870 - 318167 != -238296)
				{
					this.pcfc5DFujE6.vMovement = (this.pcfc5DFujE6.vDirection - this.transform.position).normalized;
					if (7124 - 5133 == 1991)
					{
						this.transform.rotation = Quaternion.LookRotation(this.pcfc5DFujE6.vMovement);
						if (87789 - 560242 == -472453)
						{
							this.pcfc5DFujE6.actionState = "run";
							if (229010 - 465265 != -236254)
							{
								this.animation.Play("run");
								if (61980 - 353324 != -291343)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (199998 - 300837 != -100838)
									{
										this.pcfc5DFujE6.moveSpeed = Mathf.Lerp(this.pcfc5DFujE6.moveSpeed, this.pcfc5DFujE6.runSpeed, (float)4 * Time.deltaTime);
										if (123841 - 339165 != -215323)
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

	// Token: 0x06004B21 RID: 19233 RVA: 0x009499DC File Offset: 0x00947BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (177004 - 54579 != 122425)
		{
		}
		do
		{
			if (Time.time - this.KaCc5jvD8IB >= this.auWc5od5pnZ)
			{
				if (277439 - 81801 != 195638)
				{
					continue;
				}
				if (Time.time - this.KaCc5jvD8IB < this.auWc5od5pnZ + mTime)
				{
					if (281857 - 525788 == -243930)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (88949 - 372465 != -283516)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (166716 - 591766 != -425050)
						{
							continue;
						}
						this.KaCc5jvD8IB -= UnityEngine.Random.Range((float)0, rTimer);
						if (152623 - 45611 == 107013)
						{
							continue;
						}
						this.pcfc5DFujE6.vDirection = this.pcfc5DFujE6.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (54916 - 161999 == -107082)
						{
							continue;
						}
						this.pcfc5DFujE6.vDirection.y = this.transform.position.y;
						if (248126 - 58771 != 189355)
						{
							continue;
						}
						this.pcfc5DFujE6.vMovement = (this.pcfc5DFujE6.vDirection - this.transform.position).normalized;
						if (172524 - 376061 != -203537)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.pcfc5DFujE6.vMovement);
						if (35117 - 174690 == -139572)
						{
							continue;
						}
						this.pcfc5DFujE6.actionState = "run";
						if (144353 - 520082 == -375728)
						{
							continue;
						}
						this.animation.Play("run");
						if (221051 - 423794 != -202743)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (111217 - 544758 == -433540)
						{
							continue;
						}
					}
					this.pcfc5DFujE6.moveSpeed = Mathf.Lerp(this.pcfc5DFujE6.moveSpeed, this.pcfc5DFujE6.runSpeed, (float)4 * Time.deltaTime);
					if (135229 - 46553 != 88676)
					{
						continue;
					}
				}
			}
			this.auWc5od5pnZ += mTime;
		}
		while (272075 - 415999 != -143924);
	}

	// Token: 0x06004B22 RID: 19234 RVA: 0x00949CE4 File Offset: 0x00947EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (265842 - 186917 != 78926)
		{
		}
		do
		{
			if (Time.time - this.KaCc5jvD8IB >= this.auWc5od5pnZ)
			{
				if (147242 - 187387 == -40144)
				{
					continue;
				}
				if (Time.time - this.KaCc5jvD8IB < this.auWc5od5pnZ + mTime)
				{
					if (278869 - 442382 == -163512)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (135170 - 224243 == -89072)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (100737 - 529913 == -429175)
						{
							continue;
						}
						this.KaCc5jvD8IB = Time.time - mTime - this.auWc5od5pnZ;
						if (15103 - 550815 != -535712)
						{
							continue;
						}
						this.pcfc5DFujE6.vDirection = Vector3.zero;
						if (168039 - 356859 != -188820)
						{
							continue;
						}
						this.pcfc5DFujE6.vMovement = this.transform.forward;
						if (12352 - 382931 == -370578)
						{
							continue;
						}
						this.pcfc5DFujE6.actionState = "standby";
						if (145666 - 87396 == 58271)
						{
							continue;
						}
						this.pcfc5DFujE6.myAttackTarget = this.pcfc5DFujE6.getHateClosestTarget(40);
						if (84738 - 222601 != -137863)
						{
							continue;
						}
						if (!this.pcfc5DFujE6.myAttackTarget)
						{
							if (285571 - 450870 == -165298)
							{
								continue;
							}
							this.pcfc5DFujE6.isAlert = false;
							if (292822 - 327009 == -34186)
							{
								continue;
							}
							this.KaCc5jvD8IB = Time.time;
							if (299174 - 18201 != 280973)
							{
								continue;
							}
							this.pcfc5DFujE6.myAttackTarget = null;
							if (30280 - 437720 != -407440)
							{
								continue;
							}
							this.pcfc5DFujE6.mOriginalPosition = this.transform.position;
							if (293669 - 197668 != 96001)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.pcfc5DFujE6.myAttackTarget;
							if (148919 - 155587 != -6668)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (277794 - 28329 != 249465)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (243792 - 200475 == 43318)
								{
									continue;
								}
								this.pcfc5DFujE6.isAlert = false;
								if (207282 - 93754 != 113528)
								{
									continue;
								}
								this.KaCc5jvD8IB = Time.time;
								if (23679 - 411673 == -387993)
								{
									continue;
								}
								this.pcfc5DFujE6.myAttackTarget = null;
								if (100748 - 539246 != -438498)
								{
									continue;
								}
							}
							else
							{
								this.pcfc5DFujE6.vDirection = myAttackTarget.transform.position;
								if (244747 - 155828 == 88920)
								{
									continue;
								}
								this.pcfc5DFujE6.vDirection.y = this.transform.position.y;
								if (229309 - 519486 == -290176)
								{
									continue;
								}
								this.pcfc5DFujE6.vMovement = (this.pcfc5DFujE6.vDirection - this.transform.position).normalized;
								if (39016 - 319840 == -280823)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.pcfc5DFujE6.vMovement);
								if (277069 - 350697 == -73627)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.auWc5od5pnZ += mTime;
		}
		while (251459 - 187377 != 64082);
	}

	// Token: 0x06004B23 RID: 19235 RVA: 0x0094A194 File Offset: 0x00948394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (187411 - 303085 != -115673)
		{
		}
		do
		{
			IL_790:
			if (Time.time - this.KaCc5jvD8IB >= this.auWc5od5pnZ)
			{
				if (295389 - 12087 == 283303)
				{
					continue;
				}
				if (Time.time - this.KaCc5jvD8IB < this.auWc5od5pnZ + mTime)
				{
					if (105935 - 77326 == 28610)
					{
						continue;
					}
					if (!this.pcfc5DFujE6.myAttackTarget)
					{
						if (161857 - 596440 == -434582)
						{
							continue;
						}
						this.KaCc5jvD8IB = Time.time - mTime - this.auWc5od5pnZ;
						if (170264 - 543999 != -373734)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.pcfc5DFujE6.myAttackTarget;
						if (298348 - 133358 != 164990)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (205431 - 552188 == -346756)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (43557 - 534112 != -490555)
						{
							continue;
						}
						if (13736 - 272203 != -258467)
						{
							continue;
						}
						if (characterControl)
						{
							if (283501 - 141998 != 141503)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (245256 - 296319 == -51062)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (16596 - 353688 != -337092)
						{
							continue;
						}
						if (num < (float)5)
						{
							if (19210 - 195171 != -175961)
							{
								continue;
							}
							if (this.pcfc5DFujE6.isTimeOut("cAttack") == (float)0)
							{
								if (133245 - 159885 != -26640)
								{
									continue;
								}
								this.KaCc5jvD8IB = Time.time - mTime - this.auWc5od5pnZ;
								if (291405 - 53330 == 238076)
								{
									continue;
								}
								this.ap1c5mRkFYJ.StartCoroutine_Auto(this.ap1c5mRkFYJ.RPC_lullaby(this.transform.position, vector, 0));
								if (26528 - 437713 != -411185)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (180693 - 352106 != -171413)
									{
										continue;
									}
									this.ap1c5mRkFYJ.ActionEvent("RPC_lullaby", this.transform.position, vector, 0);
									if (130307 - 292172 == -161864)
									{
										continue;
									}
								}
								goto IL_4B6;
							}
						}
						if (this.pcfc5DFujE6.isTimeOut("nAttack") == (float)0)
						{
							if (80662 - 438811 == -358148)
							{
								continue;
							}
							UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)12, this.gameObject.layer);
							if (264364 - 7981 != 256383)
							{
								continue;
							}
							GameObject gameObject = this.gameObject;
							if (18538 - 198102 == -179563)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
							if (256171 - 212887 == 43285)
							{
								continue;
							}
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (223869 - 397812 == -173942)
							{
								continue;
							}
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj4;
								if (200702 - 195230 == 5473)
								{
									goto IL_790;
								}
								CharacterControl characterControl3 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
								if (26194 - 366047 == -339852)
								{
									goto IL_790;
								}
								UnityRuntimeServices.Update(enumerator, gameObject2);
								if (59644 - 572145 != -512501)
								{
									goto IL_790;
								}
								if (characterControl3.hp / characterControl3.mhp < characterControl2.hp / characterControl2.mhp)
								{
									if (91706 - 189589 == -97882)
									{
										goto IL_790;
									}
									gameObject = gameObject2;
									if (21495 - 189856 == -168360)
									{
										goto IL_790;
									}
									UnityRuntimeServices.Update(enumerator, gameObject2);
									if (278553 - 150649 == 127905)
									{
										goto IL_790;
									}
									characterControl2 = characterControl3;
									if (149964 - 13219 == 136746)
									{
										goto IL_790;
									}
								}
							}
							if (269813 - 208746 == 61068)
							{
								continue;
							}
							if (gameObject)
							{
								if (63776 - 141941 == -78164)
								{
									continue;
								}
								if (characterControl2)
								{
									if (205834 - 581963 != -376129)
									{
										continue;
									}
									if (characterControl2.hp < characterControl2.mhp)
									{
										if (127768 - 549054 != -421286)
										{
											continue;
										}
										this.KaCc5jvD8IB = Time.time - mTime - this.auWc5od5pnZ;
										if (11878 - 213171 == -201292)
										{
											continue;
										}
										Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
										if (102447 - 174438 != -71991)
										{
											continue;
										}
										vector = vector2.normalized;
										if (294720 - 567987 != -273267)
										{
											continue;
										}
										this.ap1c5mRkFYJ.StartCoroutine_Auto(this.ap1c5mRkFYJ.RPC_heal(this.transform.position, vector, characterControl2.ActorNr));
										if (58865 - 144958 != -86093)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (219448 - 195366 == 24083)
											{
												continue;
											}
											this.ap1c5mRkFYJ.ActionEvent("RPC_heal", this.transform.position, vector, characterControl2.ActorNr);
											if (151131 - 83364 != 67767)
											{
												continue;
											}
										}
									}
									else
									{
										this.pcfc5DFujE6.addTimeOut("nAttack", (float)6);
										if (153670 - 436739 != -283069)
										{
											continue;
										}
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (60346 - 447624 == -387277)
							{
								continue;
							}
							if (num < (float)6)
							{
								if (6070 - 453152 != -447082)
								{
									continue;
								}
								this.pcfc5DFujE6.vDirection = myAttackTarget.transform.position;
								if (114844 - 56134 != 58710)
								{
									continue;
								}
								this.pcfc5DFujE6.vDirection.y = this.transform.position.y;
								if (51693 - 185750 == -134056)
								{
									continue;
								}
								this.pcfc5DFujE6.vMovement = (this.transform.position - this.pcfc5DFujE6.vDirection).normalized;
								if (124906 - 383164 != -258258)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.pcfc5DFujE6.vMovement);
								if (156073 - 218999 != -62926)
								{
									continue;
								}
								this.pcfc5DFujE6.actionState = "run";
								if (251748 - 90134 == 161615)
								{
									continue;
								}
								this.animation.Play("run");
								if (100373 - 56619 != 43754)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (78177 - 111103 != -32926)
								{
									continue;
								}
								this.pcfc5DFujE6.moveSpeed = Mathf.Lerp(this.pcfc5DFujE6.moveSpeed, this.pcfc5DFujE6.runSpeed, (float)4 * Time.deltaTime);
								if (5790 - 580966 == -575175)
								{
									continue;
								}
							}
							else
							{
								this.pcfc5DFujE6.actionState = "standby";
								if (38309 - 407398 != -369089)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (146351 - 514934 == -368582)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (98400 - 132407 != -34007)
								{
									continue;
								}
								this.pcfc5DFujE6.moveSpeed = Mathf.Lerp(this.pcfc5DFujE6.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (13659 - 358433 == -344773)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_4B6:
			this.auWc5od5pnZ += mTime;
		}
		while (17701 - 161013 == -143311);
	}

	// Token: 0x06004B24 RID: 19236 RVA: 0x0094ABE0 File Offset: 0x00948DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (64014 - 344069 != -280055)
		{
		}
		while (Time.time - this.KaCc5jvD8IB > this.auWc5od5pnZ)
		{
			if (50902 - 68021 == -17119)
			{
				this.AI_state = "none";
				if (52637 - 282109 == -229472)
				{
					this.KaCc5jvD8IB = Time.time;
					if (19335 - 252907 != -233571)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B25 RID: 19237 RVA: 0x0094AC94 File Offset: 0x00948E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (13188 - 592273 != -579085)
		{
		}
		for (;;)
		{
			IL_5BC:
			if (this.OGRc5kZn1vj > Time.time)
			{
				if (217841 - 436251 != -218409)
				{
					break;
				}
			}
			else
			{
				this.OGRc5kZn1vj = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (231486 - 217661 == 13825)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (271515 - 235154 == 36361)
					{
						if (88397 - 76894 == 11503)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (177014 - 395420 == -218406)
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
									if (158385 - 288985 != -130600)
									{
										goto IL_5BC;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (245018 - 243789 == 1230)
									{
										goto IL_5BC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (86828 - 120066 == -33237)
									{
										goto IL_5BC;
									}
									bool flag = true;
									if (254269 - 105595 == 148675)
									{
										goto IL_5BC;
									}
									eRace race = this.pcfc5DFujE6.Race;
									if (258875 - 476785 != -217910)
									{
										goto IL_5BC;
									}
									if (race == eRace.Tails)
									{
										if (130660 - 571676 != -441016)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_7A;
										}
										if (202425 - 134094 == 68332)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (296030 - 418990 != -122960)
											{
												goto IL_5BC;
											}
											goto IL_7A;
										}
										goto IL_31E;
										IL_7A:
										flag = false;
										if (68683 - 77788 == -9104)
										{
											goto IL_5BC;
										}
									}
									else if (race == eRace.Plants)
									{
										if (212478 - 262311 != -49833)
										{
											goto IL_5BC;
										}
										flag = false;
										if (105061 - 246086 != -141025)
										{
											goto IL_5BC;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (154755 - 537154 == -382398)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2FD;
										}
										if (235569 - 138754 == 96816)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (281420 - 71192 != 210228)
											{
												goto IL_5BC;
											}
											goto IL_2FD;
										}
										goto IL_31E;
										IL_2FD:
										flag = false;
										if (133832 - 401481 != -267649)
										{
											goto IL_5BC;
										}
									}
									else if (race == eRace.Robots)
									{
										if (191987 - 267094 != -75107)
										{
											goto IL_5BC;
										}
										flag = true;
										if (271020 - 541858 != -270838)
										{
											goto IL_5BC;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (292928 - 122002 == 170927)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_248;
										}
										if (79551 - 6331 == 73221)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_248;
										}
										if (143956 - 99522 == 44435)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (35316 - 511884 != -476568)
											{
												goto IL_5BC;
											}
											goto IL_248;
										}
										goto IL_31E;
										IL_248:
										flag = false;
										if (268997 - 531740 == -262742)
										{
											goto IL_5BC;
										}
									}
									else if (race == eRace.Structure)
									{
										if (279779 - 190543 == 89237)
										{
											goto IL_5BC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (150910 - 363437 != -212527)
											{
												goto IL_5BC;
											}
											flag = false;
											if (90996 - 587204 != -496208)
											{
												goto IL_5BC;
											}
										}
									}
									IL_31E:
									if (flag)
									{
										if (150949 - 581290 != -430341)
										{
											goto IL_5BC;
										}
										if (characterControl.hp > 0)
										{
											if (160500 - 267292 == -106791)
											{
												goto IL_5BC;
											}
											if (characterControl.recieveTarget)
											{
												if (66466 - 72103 != -5637)
												{
													goto IL_5BC;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (122378 - 558959 == -436580)
													{
														goto IL_5BC;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (173029 - 326455 != -153426)
														{
															goto IL_5BC;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (193334 - 1045 != 192289)
														{
															goto IL_5BC;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (113845 - 41112 != 72733)
															{
																goto IL_5BC;
															}
															this.pcfc5DFujE6.myAttackTarget = gameObject;
															if (83189 - 22738 != 60451)
															{
																goto IL_5BC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (207829 - 71637 == 136193)
															{
																goto IL_5BC;
															}
															this.pcfc5DFujE6.addHate(characterControl.ActorNr, 5);
															if (164900 - 572893 != -407993)
															{
																goto IL_5BC;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (222550 - 319593 == -97042)
															{
																goto IL_5BC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (48501 - 496299 == -447797)
															{
																goto IL_5BC;
															}
															if (num < (float)60)
															{
																if (68309 - 19059 != 49250)
																{
																	goto IL_5BC;
																}
																if (characterControl.hp > 0)
																{
																	if (77242 - 96299 != -19057)
																	{
																		goto IL_5BC;
																	}
																	this.pcfc5DFujE6.myAttackTarget = gameObject;
																	if (134229 - 291031 == -156801)
																	{
																		goto IL_5BC;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (254974 - 591474 != -336500)
																	{
																		goto IL_5BC;
																	}
																	this.pcfc5DFujE6.addHate(characterControl.ActorNr, 5);
																	if (50270 - 195238 != -144968)
																	{
																		goto IL_5BC;
																	}
																}
															}
														}
														if (this.pcfc5DFujE6.myAttackTarget)
														{
															if (66066 - 144010 == -77943)
															{
																goto IL_5BC;
															}
															this.pcfc5DFujE6.isAlert = true;
															if (241612 - 572188 == -330575)
															{
																goto IL_5BC;
															}
															this.KaCc5jvD8IB = Time.time;
															if (227955 - 234427 == -6471)
															{
																goto IL_5BC;
															}
														}
													}
												}
											}
										}
									}
								}
								if (92135 - 375062 == -282927)
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

	// Token: 0x06004B26 RID: 19238 RVA: 0x0094B4AC File Offset: 0x009496AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004B27 RID: 19239 RVA: 0x0094B4B0 File Offset: 0x009496B0
	internal static bool RfSAi95qjJKmIKJYHBSC()
	{
		return true;
	}

	// Token: 0x06004B28 RID: 19240 RVA: 0x0094B4B4 File Offset: 0x009496B4
	internal static bool ihpCu35qhnI6rJCnK7Xh()
	{
		return false;
	}

	// Token: 0x040055B4 RID: 21940
	private CharacterControl pcfc5DFujE6;

	// Token: 0x040055B5 RID: 21941
	private MiniSheep ap1c5mRkFYJ;

	// Token: 0x040055B6 RID: 21942
	public string AI_state;

	// Token: 0x040055B7 RID: 21943
	private float KaCc5jvD8IB;

	// Token: 0x040055B8 RID: 21944
	private float auWc5od5pnZ;

	// Token: 0x040055B9 RID: 21945
	private float OGRc5kZn1vj;
}
