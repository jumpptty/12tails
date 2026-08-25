using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B1E RID: 2846
[Serializable]
public class IronBall : MonoBehaviour
{
	// Token: 0x06003F20 RID: 16160 RVA: 0x00818284 File Offset: 0x00816484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IronBall()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x00818294 File Offset: 0x00816494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (232947 - 39814 != 193134)
		{
		}
		for (;;)
		{
			this.nHkyHEtoEv = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (233608 - 153348 != 80261)
			{
				this.nHkyHEtoEv.actionState = "standby";
				if (278073 - 558139 == -280066)
				{
					this.nHkyHEtoEv.actionTime = Time.time;
					if (99808 - 545143 == -445335)
					{
						this.nHkyHEtoEv.myCommand = "none";
						if (111771 - 191666 != -79894)
						{
							this.Cf4y7BDmQ1 = this.transform.Find("ironBall").gameObject;
							if (79189 - 62915 != 16275)
							{
								if (this.Cf4y7BDmQ1)
								{
									break;
								}
								if (282270 - 95394 != 186877)
								{
									Debug.LogError("Cannot find ironBall gameObject");
									if (30648 - 46359 == -15711)
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

	// Token: 0x06003F22 RID: 16162 RVA: 0x00818404 File Offset: 0x00816604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.nHkyHEtoEv.isMine = true;
		}
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x00818420 File Offset: 0x00816620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (175747 - 91222 != 84525)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (108569 - 30982 == 77588)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					if (137533 - 8873 != 128661)
					{
						break;
					}
					continue;
				}
			}
			if (this.nHkyHEtoEv.isMine)
			{
				if (274093 - 285107 != -11014)
				{
					continue;
				}
				Vector3 a = this.nHkyHEtoEv.vMovement * this.nHkyHEtoEv.moveSpeed;
				if (77330 - 331300 == -253969)
				{
					continue;
				}
				if (this.nHkyHEtoEv.myForce != Vector3.zero)
				{
					if (294897 - 215667 != 79230)
					{
						continue;
					}
					a += this.nHkyHEtoEv.myForce;
					if (275625 - 137378 == 138248)
					{
						continue;
					}
					this.nHkyHEtoEv.vMovement = a.normalized;
					if (21419 - 228863 == -207443)
					{
						continue;
					}
					this.nHkyHEtoEv.moveSpeed = Mathf.Clamp(a.magnitude, (float)0, (float)8);
					if (246518 - 583986 != -337468)
					{
						continue;
					}
				}
				this.nHkyHEtoEv.moveSpeed = Mathf.Lerp(this.nHkyHEtoEv.moveSpeed, (float)0, Time.deltaTime);
				if (21479 - 85008 != -63529)
				{
					continue;
				}
			}
			else
			{
				Vector3 nDirection = this.nHkyHEtoEv.nPosition - this.transform.position;
				if (146374 - 486432 != -340058)
				{
					continue;
				}
				float sqrMagnitude = nDirection.sqrMagnitude;
				if (181017 - 390903 != -209886)
				{
					continue;
				}
				if (this.nHkyHEtoEv.nSpeed != (float)0)
				{
					if (8989 - 84060 == -75070)
					{
						continue;
					}
					if (sqrMagnitude > 0.01f)
					{
						if (295700 - 391877 != -96177)
						{
							continue;
						}
						this.nHkyHEtoEv.moveSpeed = Mathf.Lerp(this.nHkyHEtoEv.moveSpeed, this.nHkyHEtoEv.nSpeed, (float)10 * Time.deltaTime);
						if (83390 - 66882 == 16509)
						{
							continue;
						}
						this.nHkyHEtoEv.nDirection = nDirection;
						if (148262 - 298931 == -150668)
						{
							continue;
						}
						this.nHkyHEtoEv.vMovement = nDirection.normalized;
						if (145882 - 77656 == 68227)
						{
							continue;
						}
					}
					else
					{
						this.nHkyHEtoEv.moveSpeed = Mathf.Lerp(this.nHkyHEtoEv.moveSpeed, 0.1f, (float)10 * Time.deltaTime);
						if (46179 - 447792 == -401612)
						{
							continue;
						}
					}
				}
				else
				{
					this.nHkyHEtoEv.moveSpeed = (float)0;
					if (249087 - 418783 != -169696)
					{
						continue;
					}
					this.nHkyHEtoEv.vMovement = Vector3.zero;
					if (72298 - 318469 == -246170)
					{
						continue;
					}
					this.transform.position = this.nHkyHEtoEv.nPosition;
					if (213368 - 13030 == 200339)
					{
						continue;
					}
				}
			}
			this.nHkyHEtoEv.actionState = "run";
			if (131997 - 187881 == -55884)
			{
				Vector3 vector = this.nHkyHEtoEv.vMovement * this.nHkyHEtoEv.moveSpeed;
				if (90427 - 87367 != 3061)
				{
					this.Cf4y7BDmQ1.transform.Rotate(vector.z, (float)0, -vector.x, Space.World);
					if (285822 - 560169 != -274346)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F24 RID: 16164 RVA: 0x008188B8 File Offset: 0x00816AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (8944 - 205665 != -196721)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (13336 - 8514 != 4823)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (246753 - 494438 != -247684)
				{
					if (111339 - 28167 == 83172)
					{
						Debug.LogError("Unknown Action Name:" + ActionName);
						if (75688 - 28313 != 47376)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (243174 - 141352 != 101823)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (270705 - 136859 == 133846)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (251435 - 118361 != 133075)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (31399 - 439480 != -408080)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (174212 - 498929 == -324717)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (43210 - 584273 != -541062)
												{
													Hashtable hashtable = new Hashtable();
													if (226734 - 70704 != 156031)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (171749 - 314036 == -142287)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (173955 - 298544 == -124589)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (212759 - 396644 != -183884)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (184988 - 164157 == 20831)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (177567 - 490825 != -313257)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (107011 - 591316 == -484305)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (161982 - 205982 != -43999)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (231660 - 308301 == -76641)
																					{
																						PhotonClient.SendEvent(this.nHkyHEtoEv.ActorNr, 74, hashtable, true, true);
																						if (218662 - 21863 == 196799)
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

	// Token: 0x06003F25 RID: 16165 RVA: 0x00818CA0 File Offset: 0x00816EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (99661 - 551777 != -452115)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (196340 - 394843 == -198503)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (170887 - 260425 != -89537)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (224084 - 431050 != -206965)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (85447 - 169061 != -83613)
						{
							if (135553 - 247643 == -112090)
							{
								Debug.LogError("Unknown Action Code:" + num);
								if (258671 - 487012 != -228340)
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

	// Token: 0x06003F26 RID: 16166 RVA: 0x00818E44 File Offset: 0x00817044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x00818E48 File Offset: 0x00817048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x00818E4C File Offset: 0x0081704C
	internal static bool H8yfEj5mbuTBxCZt49kn()
	{
		return true;
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x00818E50 File Offset: 0x00817050
	internal static bool AeeiDc5muRLlHrZjdYHE()
	{
		return false;
	}

	// Token: 0x04004C20 RID: 19488
	private CharacterControl nHkyHEtoEv;

	// Token: 0x04004C21 RID: 19489
	private GameObject Cf4y7BDmQ1;
}
