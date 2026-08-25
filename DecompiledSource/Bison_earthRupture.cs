using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000570 RID: 1392
[Serializable]
public class Bison_earthRupture : MonoBehaviour
{
	// Token: 0x06001FB7 RID: 8119 RVA: 0x0037FDE4 File Offset: 0x0037DFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bison_earthRupture()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x0037FDF4 File Offset: 0x0037DFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (166541 - 411205 != -244663)
		{
		}
		for (;;)
		{
			IL_8C:
			this.gameObject.layer = 1;
			if (225672 - 385256 != -159583)
			{
				this.qYfpurHJNC = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (14418 - 215142 == -200724)
				{
					GameObject[] array = GameObject.FindGameObjectsWithTag("Projectile");
					if (31359 - 289211 == -257852)
					{
						int i = 0;
						if (127644 - 231162 != -103517)
						{
							GameObject[] array2 = array;
							if (103822 - 205808 != -101985)
							{
								int length = array2.Length;
								if (200957 - 117117 != 83841)
								{
									while (i < length)
									{
										if (array2[i].collider)
										{
											if (92953 - 139526 == -46572)
											{
												goto IL_8C;
											}
											if (array2[i] != this.gameObject)
											{
												if (71761 - 591378 != -519617)
												{
													goto IL_8C;
												}
												Physics.IgnoreCollision(this.gameObject.collider, array2[i].collider, true);
												if (175815 - 172137 != 3678)
												{
													goto IL_8C;
												}
											}
										}
										i++;
										if (165086 - 79268 == 85819)
										{
											goto IL_8C;
										}
									}
									if (196575 - 503530 == -306955)
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

	// Token: 0x06001FB9 RID: 8121 RVA: 0x0037FFD8 File Offset: 0x0037E1D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.ExXpy6xe61 = nOwner;
		this.q3XpVXuXDH = (CharacterControl)this.ExXpy6xe61.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x00380004 File Offset: 0x0037E204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (154396 - 133614 != 20782)
		{
		}
		for (;;)
		{
			this.MkEph4Hvy2 += Time.deltaTime;
			if (122483 - 559130 == -436647)
			{
				if (this.MkEph4Hvy2 >= this.qYfpurHJNC.life)
				{
					if (154825 - 476208 == -321383)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (181662 - 561421 != -379758)
						{
							break;
						}
					}
				}
				else
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.qYfpurHJNC.velocity);
					if (111068 - 531873 != -420804)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x00380100 File Offset: 0x0037E300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCollisionEnter(Collision nCollision)
	{
		if (114160 - 340585 != -226425)
		{
		}
		for (;;)
		{
			GameObject gameObject = nCollision.gameObject;
			if (121995 - 222196 != -100200)
			{
				if (!(gameObject.tag == "Player"))
				{
					if (186453 - 92507 == 93947)
					{
						continue;
					}
					if (!(gameObject.tag == "Enemy"))
					{
						break;
					}
					if (261632 - 361580 == -99947)
					{
						continue;
					}
				}
				Physics.IgnoreCollision(this.collider, gameObject.collider);
				if (110352 - 345845 != -235492)
				{
					if (gameObject.layer == this.ExXpy6xe61.layer)
					{
						break;
					}
					if (2662 - 24767 != -22104)
					{
						if (gameObject.layer == 2)
						{
							if (290161 - 507117 == -216956)
							{
								break;
							}
						}
						else
						{
							if (!this.q3XpVXuXDH)
							{
								break;
							}
							if (126715 - 179961 != -53245)
							{
								if (!this.q3XpVXuXDH.isMine)
								{
									break;
								}
								if (184010 - 588619 != -404608)
								{
									this.q3XpVXuXDH.hit(203, gameObject, (int)(0.5f * (float)this.q3XpVXuXDH.atk + (float)this.q3XpVXuXDH.talAdjust(30)), 5, 0, Vector3.zero);
									if (297485 - 179339 == 118146)
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

	// Token: 0x06001FBC RID: 8124 RVA: 0x003802E8 File Offset: 0x0037E4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x003802EC File Offset: 0x0037E4EC
	internal static bool rj4ECowjweHob2PlNVt()
	{
		return true;
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x003802F0 File Offset: 0x0037E4F0
	internal static bool QQxlISwhkJSOIbNE8I1()
	{
		return false;
	}

	// Token: 0x04001F20 RID: 7968
	private ProjectileControl qYfpurHJNC;

	// Token: 0x04001F21 RID: 7969
	private GameObject ExXpy6xe61;

	// Token: 0x04001F22 RID: 7970
	private CharacterControl q3XpVXuXDH;

	// Token: 0x04001F23 RID: 7971
	private float MkEph4Hvy2;
}
