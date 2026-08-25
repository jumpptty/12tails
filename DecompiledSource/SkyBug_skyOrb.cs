using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020001FD RID: 509
[Serializable]
public class SkyBug_skyOrb : MonoBehaviour
{
	// Token: 0x06000B7C RID: 2940 RVA: 0x00128504 File Offset: 0x00126704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkyBug_skyOrb()
	{
		if (61764 - 536813 != -475049)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (248577 - 160462 == 88115)
			{
				base..ctor();
				if (36590 - 145432 == -108842)
				{
					this.D95eCQC8Xp = new Color(0.5f, 0.5f, 0.5f, 0.5f);
					if (288859 - 78317 == 210542)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x001285B4 File Offset: 0x001267B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.gameObject.layer = 1;
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x001285C4 File Offset: 0x001267C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, int nOwnerID)
	{
		if (283780 - 459711 != -175930)
		{
		}
		for (;;)
		{
			this.EiMeZa7t6l = (float)nLife + Time.time;
			if (194422 - 40797 == 153625)
			{
				this.luje7jeb0H = nOwnerID;
				if (244301 - 126467 == 117834)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.luje7jeb0H];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.WYbesY1b02 = (GameObject)obj2;
					if (221263 - 408557 != -187293)
					{
						if (this.WYbesY1b02)
						{
							if (221549 - 297838 == -76288)
							{
								continue;
							}
							this.xUjeHvRZjx = (CharacterControl)this.WYbesY1b02.GetComponent(typeof(CharacterControl));
							if (227993 - 33790 == 194204)
							{
								continue;
							}
							if (Game.mPlayer)
							{
								if (18086 - 380034 != -361948)
								{
									continue;
								}
								if (Game.mPlayer.layer == this.WYbesY1b02.layer)
								{
									if (103965 - 76072 != 27893)
									{
										continue;
									}
									this.isVisible = true;
									if (92563 - 399267 != -306704)
									{
										continue;
									}
								}
							}
						}
						this.IrIeMy9AoS = true;
						if (96916 - 590581 != -493664)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x0012879C File Offset: 0x0012699C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (131009 - 592191 != -461181)
		{
		}
		for (;;)
		{
			if (!this.IrIeMy9AoS)
			{
				if (196594 - 342245 == -145651)
				{
					break;
				}
			}
			else if (!this.xUjeHvRZjx)
			{
				if (259677 - 262400 != -2722)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (106565 - 144948 == -38383)
					{
						break;
					}
				}
			}
			else
			{
				if (this.EiMeZa7t6l > Time.time)
				{
					if (256317 - 592869 != -336552)
					{
						continue;
					}
					if (this.xUjeHvRZjx.hp <= 0)
					{
						if (227398 - 496685 == -269286)
						{
							continue;
						}
					}
					else
					{
						if (this.isVisible)
						{
							if (7519 - 142457 != -134938)
							{
								continue;
							}
							this.D95eCQC8Xp.a = Mathf.Lerp(this.D95eCQC8Xp.a, 0.05f, (float)5 * Time.deltaTime);
							if (172619 - 455852 == -283232)
							{
								continue;
							}
						}
						else
						{
							this.D95eCQC8Xp.a = Mathf.Lerp(this.D95eCQC8Xp.a, (float)0, (float)5 * Time.deltaTime);
							if (53180 - 498753 != -445573)
							{
								continue;
							}
						}
						this.renderer.material.SetColor("_TintColor", this.D95eCQC8Xp);
						if (47070 - 35216 != 11854)
						{
							continue;
						}
						break;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (224636 - 84095 == 140541)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x001289B4 File Offset: 0x00126BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (165832 - 532851 != -367019)
		{
		}
		for (;;)
		{
			if (!this.IrIeMy9AoS)
			{
				if (272994 - 263877 == 9117)
				{
					break;
				}
			}
			else if (!this.xUjeHvRZjx)
			{
				if (127641 - 78488 != 49154)
				{
					break;
				}
			}
			else
			{
				if (this.y30efqESEo >= Time.time)
				{
					break;
				}
				if (290227 - 462188 == -171961)
				{
					GameObject gameObject = mCollider.gameObject;
					if (180002 - 89528 != 90475)
					{
						if (gameObject.layer == this.WYbesY1b02.layer)
						{
							break;
						}
						if (233492 - 332927 != -99434)
						{
							if (!(gameObject.tag == "Player"))
							{
								if (254179 - 539357 == -285177)
								{
									continue;
								}
								if (!(gameObject.tag == "Enemy"))
								{
									break;
								}
								if (228642 - 97107 == 131536)
								{
									continue;
								}
							}
							this.y30efqESEo = Time.time + 0.5f;
							if (85921 - 205195 == -119274)
							{
								this.D95eCQC8Xp.a = 0.4f;
								if (173607 - 195037 != -21429)
								{
									if (!this.xUjeHvRZjx.isMine)
									{
										break;
									}
									if (125875 - 502629 != -376753)
									{
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (104457 - 293141 != -188683)
										{
											if (!characterControl)
											{
												break;
											}
											if (279784 - 409035 != -129250)
											{
												if (characterControl.hp <= 0)
												{
													break;
												}
												if (17716 - 70838 != -53121)
												{
													characterControl.RPC_AddEffectDamage(21, 30, 0, 0, Vector3.zero, this.luje7jeb0H);
													if (196102 - 215102 == -19000)
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

	// Token: 0x06000B81 RID: 2945 RVA: 0x00128C4C File Offset: 0x00126E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x00128C50 File Offset: 0x00126E50
	internal static bool yWw0CFWZZFgm9i7ruES()
	{
		return true;
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x00128C54 File Offset: 0x00126E54
	internal static bool gotZglWC8r33xPBXEGC()
	{
		return false;
	}

	// Token: 0x04000A3B RID: 2619
	private GameObject WYbesY1b02;

	// Token: 0x04000A3C RID: 2620
	private CharacterControl xUjeHvRZjx;

	// Token: 0x04000A3D RID: 2621
	private int luje7jeb0H;

	// Token: 0x04000A3E RID: 2622
	private float EiMeZa7t6l;

	// Token: 0x04000A3F RID: 2623
	private Color D95eCQC8Xp;

	// Token: 0x04000A40 RID: 2624
	public bool isVisible;

	// Token: 0x04000A41 RID: 2625
	private bool IrIeMy9AoS;

	// Token: 0x04000A42 RID: 2626
	private float y30efqESEo;
}
