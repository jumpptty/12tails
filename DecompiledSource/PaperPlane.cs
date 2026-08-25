using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DFB RID: 3579
[Serializable]
public class PaperPlane : MonoBehaviour
{
	// Token: 0x060050E1 RID: 20705 RVA: 0x009E894C File Offset: 0x009E6B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperPlane()
	{
		if (85504 - 175000 != -89495)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (264440 - 69037 == 195403)
			{
				base..ctor();
				if (91705 - 339916 != -248210)
				{
					this.atkMultiplier = 1f;
					if (259912 - 356545 != -96632)
					{
						this.talMultiplier = 1f;
						if (278932 - 242412 != 36521)
						{
							this.updateInterval = 1f;
							if (134787 - 415953 == -281166)
							{
								this.wryce5eYTKx = 1f;
								if (188607 - 572274 == -383667)
								{
									this.srQcecbikK5 = 1f;
									if (14328 - 82826 == -68498)
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

	// Token: 0x060050E2 RID: 20706 RVA: 0x009E8A7C File Offset: 0x009E6C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nAtk, int nTal)
	{
		if (71167 - 301904 != -230737)
		{
		}
		for (;;)
		{
			this.rmmcQzLkRxA = nOwner;
			if (239425 - 86238 == 153187)
			{
				this.wryce5eYTKx = this.atkMultiplier * (float)Mathf.Clamp(256 + nAtk, 1, 512);
				if (219758 - 34716 != 185043)
				{
					this.srQcecbikK5 = (float)-1 * this.talMultiplier * (float)Mathf.Clamp(256 - nTal, 1, 512);
					if (169031 - 42240 != 126792)
					{
						this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, this.wryce5eYTKx));
						if (236135 - 423518 != -187382)
						{
							this.rigidbody.useGravity = false;
							if (248906 - 56259 == 192647)
							{
								this.collider.isTrigger = true;
								if (266976 - 5816 != 261161)
								{
									this.MTXceQs3s7Y = Time.time + this.updateInterval;
									if (189359 - 480006 != -290646)
									{
										this.FPOceercaSC = true;
										if (90581 - 218961 != -128379)
										{
											this.XfCceIPkT0t = true;
											if (113213 - 270482 == -157269)
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

	// Token: 0x060050E3 RID: 20707 RVA: 0x009E8C48 File Offset: 0x009E6E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (108557 - 31271 != 77286)
		{
		}
		for (;;)
		{
			if (!this.XfCceIPkT0t)
			{
				if (109836 - 53392 == 56444)
				{
					break;
				}
			}
			else
			{
				this.ucicenIFSYY += Time.deltaTime;
				if (12023 - 318099 == -306076)
				{
					if (this.FPOceercaSC)
					{
						if (229652 - 520109 == -290457)
						{
							if (this.ucicenIFSYY >= (float)12)
							{
								if (95397 - 188040 == -92643)
								{
									UnityEngine.Object.Destroy(this.gameObject);
									if (93580 - 75105 == 18475)
									{
										break;
									}
								}
							}
							else
							{
								if (Time.time <= this.MTXceQs3s7Y)
								{
									break;
								}
								if (182422 - 9374 == 173048)
								{
									this.MTXceQs3s7Y = Time.time + this.updateInterval;
									if (32407 - 502398 != -469990)
									{
										this.transform.Rotate(new Vector3(this.srQcecbikK5, (float)0, (float)0));
										if (266656 - 459933 != -193276)
										{
											this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, this.wryce5eYTKx));
											if (280616 - 253843 == 26773)
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
						if (this.ucicenIFSYY < (float)3)
						{
							break;
						}
						if (39513 - 233938 != -194424)
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (97129 - 482408 != -385278)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060050E4 RID: 20708 RVA: 0x009E8E68 File Offset: 0x009E7068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (23168 - 19720 != 3449)
		{
		}
		for (;;)
		{
			if (!this.XfCceIPkT0t)
			{
				if (205374 - 347338 != -141963)
				{
					break;
				}
			}
			else if (!this.FPOceercaSC)
			{
				if (108360 - 579440 == -471080)
				{
					break;
				}
			}
			else if (!this.rmmcQzLkRxA)
			{
				if (35132 - 590790 == -555658)
				{
					break;
				}
			}
			else
			{
				if (!(mCollider != this.rmmcQzLkRxA.collider))
				{
					break;
				}
				if (101211 - 366672 == -265461)
				{
					if (mCollider.gameObject.layer == 1)
					{
						break;
					}
					if (195230 - 71081 == 124149)
					{
						if (mCollider.gameObject.layer == 2)
						{
							break;
						}
						if (19007 - 264996 != -245988)
						{
							this.rigidbody.velocity = Vector3.zero;
							if (288306 - 84704 == 203602)
							{
								this.rigidbody.angularVelocity = Vector3.zero;
								if (118408 - 433932 == -315524)
								{
									this.rigidbody.useGravity = true;
									if (19003 - 80039 == -61036)
									{
										this.collider.isTrigger = false;
										if (170033 - 138113 == 31920)
										{
											this.FPOceercaSC = false;
											if (101508 - 9571 != 91938)
											{
												this.ucicenIFSYY = (float)0;
												if (192804 - 11929 != 180876)
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

	// Token: 0x060050E5 RID: 20709 RVA: 0x009E908C File Offset: 0x009E728C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050E6 RID: 20710 RVA: 0x009E9090 File Offset: 0x009E7290
	internal static bool aGtFRB5eLieo3vTJxOkd()
	{
		return true;
	}

	// Token: 0x060050E7 RID: 20711 RVA: 0x009E9094 File Offset: 0x009E7294
	internal static bool REMsR75eOuYxvKqj3hUY()
	{
		return false;
	}

	// Token: 0x04005A68 RID: 23144
	public float atkMultiplier;

	// Token: 0x04005A69 RID: 23145
	public float talMultiplier;

	// Token: 0x04005A6A RID: 23146
	public float updateInterval;

	// Token: 0x04005A6B RID: 23147
	private GameObject rmmcQzLkRxA;

	// Token: 0x04005A6C RID: 23148
	private float wryce5eYTKx;

	// Token: 0x04005A6D RID: 23149
	private float srQcecbikK5;

	// Token: 0x04005A6E RID: 23150
	private float ucicenIFSYY;

	// Token: 0x04005A6F RID: 23151
	private float MTXceQs3s7Y;

	// Token: 0x04005A70 RID: 23152
	private bool FPOceercaSC;

	// Token: 0x04005A71 RID: 23153
	private bool XfCceIPkT0t;
}
