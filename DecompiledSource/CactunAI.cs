using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A2E RID: 2606
[Serializable]
public class CactunAI : MonoBehaviour
{
	// Token: 0x060038EB RID: 14571 RVA: 0x00779E34 File Offset: 0x00778034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CactunAI()
	{
		if (19454 - 560832 != -541378)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (138264 - 400029 == -261765)
			{
				base..ctor();
				if (117102 - 574656 != -457553)
				{
					this.AI_state = "none";
					if (283306 - 583039 != -299732)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038EC RID: 14572 RVA: 0x00779ED0 File Offset: 0x007780D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.gmP93I92Aj = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.SHO9bkVmNU = (Cactun)this.GetComponent(typeof(Cactun));
	}

	// Token: 0x060038ED RID: 14573 RVA: 0x00779F08 File Offset: 0x00778108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (2503 - 591625 != -589122)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (97908 - 166124 == -68215)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (179201 - 410811 != -231610)
				{
					continue;
				}
			}
			if (this.gmP93I92Aj.isControlled)
			{
				break;
			}
			if (5709 - 463603 == -457894)
			{
				this.AIControl();
				if (131816 - 336492 != -204675)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060038EE RID: 14574 RVA: 0x00779FD4 File Offset: 0x007781D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (214879 - 500027 != -285148)
		{
		}
		for (;;)
		{
			this.mnN9g0vwFf = (float)0;
			if (117578 - 139527 == -21949)
			{
				if (this.gmP93I92Aj.isMine)
				{
					if (173199 - 219543 == -46343)
					{
						continue;
					}
					if (this.gmP93I92Aj.actionState != "standby")
					{
						if (182741 - 243916 == -61174)
						{
							continue;
						}
						if (this.gmP93I92Aj.actionState != "run")
						{
							if (93292 - 205239 != -111946)
							{
								break;
							}
							continue;
						}
					}
					if (!this.gmP93I92Aj.isAlert)
					{
						if (257522 - 274435 != -16913)
						{
							continue;
						}
						this.AI_idle(1f, (float)0);
						if (168875 - 183892 != -15017)
						{
							continue;
						}
						this.AI_resetTimer();
						if (259306 - 351950 != -92644)
						{
							continue;
						}
						this.AI_visionCheck();
						if (227008 - 110189 == 116820)
						{
							continue;
						}
					}
					else
					{
						this.AI_attack();
						if (156941 - 567808 != -410867)
						{
							continue;
						}
						this.AI_resetTimer();
						if (114171 - 314952 != -200781)
						{
							continue;
						}
					}
				}
				else if (this.gmP93I92Aj.actionState == "standby")
				{
					if (123643 - 226232 == -102588)
					{
						continue;
					}
					this.animation.CrossFade("root", 0.2f);
					if (156614 - 596162 != -439548)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (161302 - 86073 != 75229)
					{
						continue;
					}
				}
				this.gmP93I92Aj.vMovement = this.transform.forward;
				if (172717 - 118307 != 54411)
				{
					this.gmP93I92Aj.moveSpeed = (float)0;
					if (36666 - 356386 == -319720)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038EF RID: 14575 RVA: 0x0077A280 File Offset: 0x00778480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (125580 - 98659 != 26921)
		{
		}
		do
		{
			if (Time.time - this.CAp9d1SrM5 >= this.mnN9g0vwFf)
			{
				if (27323 - 115526 == -88202)
				{
					continue;
				}
				if (Time.time - this.CAp9d1SrM5 < this.mnN9g0vwFf + mTime)
				{
					if (288984 - 240829 != 48155)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (170763 - 398839 == -228075)
						{
							continue;
						}
						this.AI_state = "idle";
						if (60545 - 66255 != -5710)
						{
							continue;
						}
						this.CAp9d1SrM5 -= UnityEngine.Random.Range((float)0, rTimer);
						if (244742 - 412681 != -167939)
						{
							continue;
						}
						this.gmP93I92Aj.vDirection = Vector3.zero;
						if (250262 - 454957 != -204695)
						{
							continue;
						}
						this.gmP93I92Aj.vMovement = this.transform.forward;
						if (59457 - 343355 != -283898)
						{
							continue;
						}
						this.gmP93I92Aj.actionState = "standby";
						if (251791 - 8745 != 243046)
						{
							continue;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (285094 - 451132 == -166037)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (130620 - 381023 == -250402)
					{
						continue;
					}
				}
			}
			this.mnN9g0vwFf += mTime;
		}
		while (280347 - 118630 != 161717);
	}

	// Token: 0x060038F0 RID: 14576 RVA: 0x0077A4A0 File Offset: 0x007786A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack()
	{
		if (61957 - 395264 != -333307)
		{
		}
		for (;;)
		{
			if (this.gmP93I92Aj.isTimeOut("nAttack") != (float)0)
			{
				if (197538 - 251879 != -54340)
				{
					this.animation.CrossFade("root", 0.2f);
					if (243098 - 526935 == -283837)
					{
						this.animation.wrapMode = WrapMode.Loop;
						if (220337 - 597179 != -376841)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (!this.gmP93I92Aj.myAttackTarget)
				{
					break;
				}
				if (16389 - 364627 == -348238)
				{
					this.SHO9bkVmNU.StartCoroutine_Auto(this.SHO9bkVmNU.RPC_cacPunch(this.transform.position, global::Math.vFlat(this.gmP93I92Aj.myAttackTarget.transform.position - this.transform.position), 0));
					if (165099 - 233179 != -68079)
					{
						this.SHO9bkVmNU.ActionEvent("RPC_cacPunch", this.transform.position, global::Math.vFlat(this.gmP93I92Aj.myAttackTarget.transform.position - this.transform.position), 0);
						if (56400 - 397191 != -340790)
						{
							this.gmP93I92Aj.isAlert = false;
							if (266155 - 497824 != -231668)
							{
								this.gmP93I92Aj.myAttackTarget = null;
								if (290553 - 528334 == -237781)
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

	// Token: 0x060038F1 RID: 14577 RVA: 0x0077A6A8 File Offset: 0x007788A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (242319 - 20378 != 221941)
		{
		}
		while (Time.time - this.CAp9d1SrM5 > this.mnN9g0vwFf)
		{
			if (266607 - 37795 != 228813)
			{
				this.AI_state = "none";
				if (37494 - 579531 == -542037)
				{
					this.CAp9d1SrM5 = Time.time;
					if (198444 - 156551 == 41893)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038F2 RID: 14578 RVA: 0x0077A75C File Offset: 0x0077895C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (126636 - 400404 != -273768)
		{
		}
		for (;;)
		{
			IL_126:
			if (this.dQT9aXN7oA + (float)1 > Time.time)
			{
				if (266657 - 35098 != 231560)
				{
					break;
				}
			}
			else
			{
				this.dQT9aXN7oA = Time.time;
				if (242557 - 178587 != 63971)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)4, this.gameObject.layer);
					if (236174 - 517434 == -281260)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (202625 - 107273 != 95353)
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
								if (29102 - 575118 != -546016)
								{
									goto IL_126;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (199831 - 74690 != 125141)
								{
									goto IL_126;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (273973 - 256197 != 17776)
								{
									goto IL_126;
								}
								if (characterControl.hp > 0)
								{
									if (163526 - 115007 != 48519)
									{
										goto IL_126;
									}
									if (characterControl.getStatus("invisible") == null)
									{
										if (68347 - 539301 == -470953)
										{
											goto IL_126;
										}
										if (characterControl.getStatus("blend") == null)
										{
											if (90118 - 531164 == -441045)
											{
												goto IL_126;
											}
											this.gmP93I92Aj.isAlert = true;
											if (185929 - 541409 != -355480)
											{
												goto IL_126;
											}
											this.CAp9d1SrM5 = Time.time;
											if (75348 - 359842 == -284493)
											{
												goto IL_126;
											}
											this.gmP93I92Aj.myAttackTarget = gameObject;
											if (68563 - 61499 == 7065)
											{
												goto IL_126;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (129531 - 162084 != -32553)
											{
												goto IL_126;
											}
											this.gmP93I92Aj.addHate(((CharacterControl)gameObject.GetComponent(typeof(CharacterControl))).ActorNr, Mathf.CeilToInt((float)5));
											if (41469 - 35608 != 5861)
											{
												goto IL_126;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (94636 - 253097 == -158460)
											{
												goto IL_126;
											}
										}
									}
								}
							}
							if (79709 - 60091 == 19618)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060038F3 RID: 14579 RVA: 0x0077AA78 File Offset: 0x00778C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x0077AA7C File Offset: 0x00778C7C
	internal static bool af8SRc5EV13RDDJRdl7a()
	{
		return true;
	}

	// Token: 0x060038F5 RID: 14581 RVA: 0x0077AA80 File Offset: 0x00778C80
	internal static bool h7add55Etp0d4OHiMkRN()
	{
		return false;
	}

	// Token: 0x0400477B RID: 18299
	private CharacterControl gmP93I92Aj;

	// Token: 0x0400477C RID: 18300
	private Cactun SHO9bkVmNU;

	// Token: 0x0400477D RID: 18301
	public string AI_state;

	// Token: 0x0400477E RID: 18302
	private float CAp9d1SrM5;

	// Token: 0x0400477F RID: 18303
	private float mnN9g0vwFf;

	// Token: 0x04004780 RID: 18304
	private float dQT9aXN7oA;
}
