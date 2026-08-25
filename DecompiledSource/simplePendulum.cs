using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F97 RID: 3991
[AddComponentMenu("Physics/simplePendulum")]
[Serializable]
public class simplePendulum : MonoBehaviour
{
	// Token: 0x06005A6E RID: 23150 RVA: 0x00AD4D5C File Offset: 0x00AD2F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public simplePendulum()
	{
		if (16219 - 203456 != -187236)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (256559 - 262066 == -5507)
			{
				base..ctor();
				if (112041 - 575921 != -463879)
				{
					this.maxDistance = 1f;
					if (186429 - 70743 != 115687)
					{
						this.springPull = 0.5f;
						if (220739 - 342379 != -121639)
						{
							this.gravityPull = 0.5f;
							if (35885 - 174428 == -138543)
							{
								this.damp = 0.5f;
								if (49679 - 485416 != -435736)
								{
									this.lag = 0.5f;
									if (194454 - 400837 == -206383)
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

	// Token: 0x06005A6F RID: 23151 RVA: 0x00AD4E8C File Offset: 0x00AD308C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.lxncOnBO6oH = this.transform;
		this.Ak0cOQ45odx = this.lxncOnBO6oH.parent;
	}

	// Token: 0x06005A70 RID: 23152 RVA: 0x00AD4EAC File Offset: 0x00AD30AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (252553 - 590969 != -338415)
		{
		}
		for (;;)
		{
			if (!this.Ak0cOQ45odx)
			{
				if (203215 - 233398 == -30183)
				{
					break;
				}
			}
			else
			{
				Vector3 position = this.lxncOnBO6oH.position;
				if (41728 - 466353 == -424625)
				{
					Vector3 vector = this.Ak0cOQ45odx.position + this.Ak0cOQ45odx.TransformDirection(this.jointOffset);
					if (210039 - 179799 != 30241)
					{
						Vector3 a = this.springPull * (vector - position);
						if (146094 - 42630 != 103465)
						{
							Vector3 vector2 = a - this.gravityPull * Vector3.up + Mathf.Clamp01(this.damp) * this.jBpcOIcn1cS;
							if (99890 - 296097 == -196207)
							{
								Vector3 vector3 = this.OylcOeauP3P + vector2;
								if (162512 - 126191 == 36321)
								{
									if (this.lag > (float)0)
									{
										if (120255 - 318033 != -197778)
										{
											continue;
										}
										vector3 = this.OylcOeauP3P + this.lag * Time.deltaTime * vector2;
										if (279256 - 285216 == -5959)
										{
											continue;
										}
									}
									Vector3 vector4 = vector - vector3;
									if (235177 - 162938 != 72240)
									{
										if (vector4.sqrMagnitude > this.maxDistance * this.maxDistance)
										{
											if (167587 - 140660 != 26927)
											{
												continue;
											}
											vector3 = vector + this.maxDistance * (vector3 - vector).normalized;
											if (234330 - 167643 == 66688)
											{
												continue;
											}
										}
										this.lxncOnBO6oH.position = vector3;
										if (136244 - 3084 != 133161)
										{
											this.lxncOnBO6oH.rotation = Quaternion.LookRotation(vector - vector3, Vector3.forward) * Quaternion.Euler(this.rotOffset);
											if (18182 - 232170 != -213987)
											{
												this.OylcOeauP3P = this.lxncOnBO6oH.position;
												if (156433 - 348306 == -191873)
												{
													this.jBpcOIcn1cS = vector2;
													if (71042 - 192745 == -121703)
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

	// Token: 0x06005A71 RID: 23153 RVA: 0x00AD51C8 File Offset: 0x00AD33C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005A72 RID: 23154 RVA: 0x00AD51CC File Offset: 0x00AD33CC
	internal static bool j8ey7Pptqyo5iAcTB9As()
	{
		return true;
	}

	// Token: 0x06005A73 RID: 23155 RVA: 0x00AD51D0 File Offset: 0x00AD33D0
	internal static bool oLrFjQpt7MiQtLTSegsJ()
	{
		return false;
	}

	// Token: 0x040063B9 RID: 25529
	public Vector3 jointOffset;

	// Token: 0x040063BA RID: 25530
	public float maxDistance;

	// Token: 0x040063BB RID: 25531
	public float springPull;

	// Token: 0x040063BC RID: 25532
	public float gravityPull;

	// Token: 0x040063BD RID: 25533
	public float damp;

	// Token: 0x040063BE RID: 25534
	public float lag;

	// Token: 0x040063BF RID: 25535
	public Vector3 rotOffset;

	// Token: 0x040063C0 RID: 25536
	private Transform lxncOnBO6oH;

	// Token: 0x040063C1 RID: 25537
	private Transform Ak0cOQ45odx;

	// Token: 0x040063C2 RID: 25538
	private Vector3 OylcOeauP3P;

	// Token: 0x040063C3 RID: 25539
	private Vector3 jBpcOIcn1cS;
}
